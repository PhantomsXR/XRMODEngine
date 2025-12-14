using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Immersal;
using Immersal.AR;
using Immersal.REST;
using Phantom.XRMOD.Immersal.Editor.Models;
using Unity.EditorCoroutines.Editor;
using UnityEditor;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Networking;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.Immersal.Editor
{
    public class MapDownloadEditor : EditorWindow
    {
        private static MapDownloadEditor _MAP_DOWNLOAD_EDITOR;
        private static string _MAP_DATA_PATH;
        private const string _CONST_GATEWAY = "https://api.immersal.com";
        private const string _CONST_DOWNLOAD_GATEWAY = "https://developers.immersal.com";
        private const string _CONST_MAP_PARAM = "map";
        private const string _CONST_MESH_PARAM = "tex";
        private string token;
        private Texture refreshTextureIcon;

        private MapModel mapModel;
        private string[] tableheader = new[] {"MapId", "MapName", "MapFrames"};
        private string inputToken;
        private Vector2 scrollerView;
        private string mapSavedPath = String.Empty;

        public class RequestBody
        {
            public string token;
        }

        [MenuItem(itemName: "Tools/XR-MOD/Map Downloader", false, 3)]
        private static void GetDownloadWindow()
        {
            MakeSureData();
            _MAP_DOWNLOAD_EDITOR.Show();
        }

        private static void MakeSureData()
        {
            if (_MAP_DOWNLOAD_EDITOR == null)
            {
                _MAP_DOWNLOAD_EDITOR = GetWindow<MapDownloadEditor>();
                _MAP_DOWNLOAD_EDITOR.titleContent = new GUIContent("Map Downloader");
            }

            if (string.IsNullOrEmpty(_MAP_DOWNLOAD_EDITOR.token))
            {
                _MAP_DOWNLOAD_EDITOR.token = PlayerPrefs.GetString("token", string.Empty);
                if (!string.IsNullOrEmpty(_MAP_DOWNLOAD_EDITOR.token) && _MAP_DOWNLOAD_EDITOR.mapModel == null)
                {
                    EditorCoroutineUtility.StartCoroutineOwnerless(_MAP_DOWNLOAD_EDITOR.FetchMapData());
                }
            }

            if (!_MAP_DOWNLOAD_EDITOR.refreshTextureIcon)
                _MAP_DOWNLOAD_EDITOR.refreshTextureIcon =
                    AssetDatabase.LoadAssetAtPath<Texture>(
                        "Packages/com.phantomsxr.immersalsdk/Editor/Assets/Refresh.png");
        }

        private IEnumerator FetchMapData()
        {
            UnityWebRequest tmp_UnityWebRequest =
                UnityWebRequest.Put(new Uri($"{_CONST_GATEWAY}/list"), JsonUtility.ToJson(new RequestBody()
                {
                    token = token
                }));
            tmp_UnityWebRequest.method = UnityWebRequest.kHttpVerbPOST;
            tmp_UnityWebRequest.SetRequestHeader("Content-Type", "application/json");
            tmp_UnityWebRequest.SetRequestHeader("Accept", "application/json");
            yield return tmp_UnityWebRequest.SendWebRequest();
            switch (tmp_UnityWebRequest.result)
            {
                case UnityWebRequest.Result.Success:
                    mapModel = JsonUtility.FromJson<MapModel>(tmp_UnityWebRequest.downloadHandler.text);
                    break;
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.ProtocolError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(tmp_UnityWebRequest.error);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void OnGUI()
        {
            if (string.IsNullOrEmpty(token))
            {
                inputToken = EditorGUILayout.TextField("Token", inputToken);
                if (GUILayout.Button("Save") && !string.IsNullOrEmpty(inputToken))
                {
                    EditorCoroutineUtility.StartCoroutineOwnerless(_MAP_DOWNLOAD_EDITOR.FetchMapData());
                    PlayerPrefs.SetString("token", inputToken);
                    token = inputToken;
                }
            }
            else
            {
                if (mapModel == null) return;
                float tmp_FieldSize = EditorGUIUtility.currentViewWidth * 0.3f;
                EditorGUILayout.BeginHorizontal();

                foreach (string tmp_Field in tableheader)
                {
                    EditorGUILayout.LabelField(tmp_Field, GUILayout.Width(tmp_FieldSize));
                }

                if (GUILayout.Button(_MAP_DOWNLOAD_EDITOR.refreshTextureIcon, GUILayout.Width(24),
                        GUILayout.Height(24)))
                {
                    mapModel = null;
                    EditorCoroutineUtility.StartCoroutineOwnerless(_MAP_DOWNLOAD_EDITOR.FetchMapData());
                }

                EditorGUILayout.EndHorizontal();

                scrollerView = EditorGUILayout.BeginScrollView(scrollerView);
                EditorGUILayout.BeginVertical();

                if (mapModel != null)
                {
                    foreach (JobsItem tmp_JobsItem in mapModel.jobs)
                    {
                        EditorGUILayout.BeginHorizontal();
                        EditorGUILayout.LabelField(tmp_JobsItem.id.ToString(), GUILayout.Width(tmp_FieldSize));
                        EditorGUILayout.LabelField(tmp_JobsItem.name, GUILayout.Width(tmp_FieldSize));
                        EditorGUILayout.LabelField(tmp_JobsItem.size.ToString(), GUILayout.Width(tmp_FieldSize));
                        if (GUILayout.Button("Download"))
                        {
                            var tmp_SaveMapPath = EditorUtility.SaveFolderPanel("Save Map data", "Assets", "");
                            if (string.IsNullOrEmpty(tmp_SaveMapPath))
                            {
                                break;
                            }

                            EditorCoroutineUtility.StartCoroutineOwnerless(DownloadMapMetadata(tmp_JobsItem.id,
                                tmp_JobsItem.name, tmp_SaveMapPath));
                            EditorPrefs.SetString("ARMapPath", tmp_SaveMapPath);
                            EditorUtility.DisplayDialog("Downloading", "The map has started downloading", "Ok");
                        }

                        EditorGUILayout.EndHorizontal();
                    }
                }

                EditorGUILayout.EndVertical();
                EditorGUILayout.EndScrollView();
            }
        }


        private IEnumerator DownloadMapBytes(int _mapId, string _mapName, string _savePath)
        {
            UnityWebRequest tmp_UnityWebRequest =
                new UnityWebRequest(
                    new Uri($"{_CONST_DOWNLOAD_GATEWAY}/{_CONST_MAP_PARAM}?token={token}&id={_mapId}"));
            tmp_UnityWebRequest.downloadHandler = new DownloadHandlerBuffer();
            yield return tmp_UnityWebRequest.SendWebRequest();

            File.WriteAllBytes(Path.Combine(_savePath, $"{_mapId}-{_mapName}.bytes"),
                tmp_UnityWebRequest.downloadHandler.data);
            yield return DownloadMapMesh(_mapId, _mapName, _savePath);
        }

        private IEnumerator DownloadMapMesh(int _mapId, string _mapName, string _savePath)
        {
            UnityWebRequest tmp_UnityWebRequest =
                new UnityWebRequest(
                    new Uri($"{_CONST_DOWNLOAD_GATEWAY}/{_CONST_MESH_PARAM}?token={token}&id={_mapId}"));
            tmp_UnityWebRequest.downloadHandler = new DownloadHandlerBuffer();
            yield return tmp_UnityWebRequest.SendWebRequest();

            var tmp_SavedPath = Path.Combine(_savePath, $"{_mapName}-Tex.glb");
            File.WriteAllBytes(tmp_SavedPath, tmp_UnityWebRequest.downloadHandler.data);
            AssetDatabase.Refresh();

            InstantiatedToScene(tmp_SavedPath, Path.Combine(_savePath, $"{_mapId}-{_mapName}.bytes"));
        }

        private IEnumerator DownloadMapMetadata(int _mapId, string _mapName, string _savePath)
        {
            //
            // Downloads map metadata, saves it to disk, downloads the map file and sets up the AR Map game object
            //

            // Load map metadata from Immersal Cloud Service
            SDKMapMetadataGetRequest r = new SDKMapMetadataGetRequest();
            r.token = token;
            r.id = _mapId;

            string jsonString = JsonUtility.ToJson(r);
            UnityWebRequest request =
                UnityWebRequest.Put(
                    string.Format(ImmersalHttp.URL_FORMAT, ImmersalSDK.Instance.defaultServer,
                        SDKMapMetadataGetRequest.endpoint), jsonString);
            request.method = UnityWebRequest.kHttpVerbPOST;
            request.useHttpContinue = false;
            request.SetRequestHeader("Content-Type", "application/json");
            request.SetRequestHeader("Accept", "application/json");
            request.SendWebRequest();

            while (!request.isDone)
            {
                yield return null;
            }

#if UNITY_2020_1_OR_NEWER
            if (request.result != UnityWebRequest.Result.Success)
#else
            if (request.isNetworkError || request.isHttpError)
#endif
            {
                Debug.LogError(request.error);
            }
            else
            {
                SDKMapMetadataGetResult tmp_Result =
                    JsonUtility.FromJson<SDKMapMetadataGetResult>(request.downloadHandler.text);
                if (tmp_Result.error != "none") yield break;
                // Save metadata file on disk, overwrite existing file
                string tmp_JsonFilePath =
                    Path.Combine(_savePath, $"{tmp_Result.id}-{tmp_Result.name}-metadata.json");
                File.WriteAllText(tmp_JsonFilePath, request.downloadHandler.text);
                // Load map file from Immersal Cloud Service
                // EditorCoroutineUtility.StartCoroutine(DownloadMapFile(_mapId, result), this);
                EditorCoroutineUtility.StartCoroutineOwnerless(DownloadMapBytes(_mapId, _mapName, _savePath));
            }
        }

        private void InstantiatedToScene(string _filePath, string _mapPath)
        {
            const string tmp_const_MatchFormat = "Assets";
            var tmp_MapDataPathStarIdx = _mapPath.IndexOf(tmp_const_MatchFormat, StringComparison.Ordinal);
            GameObject tmp_PointCloudMap = new GameObject(Path.GetFileNameWithoutExtension(_filePath));
            var tmp_ARMapComp = tmp_PointCloudMap.AddComponent<ARMap>();
            tmp_ARMapComp.mapFile =
                AssetDatabase.LoadAssetAtPath<TextAsset>(_mapPath.Substring(tmp_MapDataPathStarIdx,
                    _mapPath.Length - tmp_MapDataPathStarIdx));


            var tmp_StarIdx = _filePath.IndexOf(tmp_const_MatchFormat, StringComparison.Ordinal);
            _filePath = _filePath.Substring(tmp_StarIdx, _filePath.Length - tmp_StarIdx);
            var tmp_MapMesh = AssetDatabase.LoadAssetAtPath<GameObject>(_filePath);
            Object.Instantiate(tmp_MapMesh);
        }
    }
}
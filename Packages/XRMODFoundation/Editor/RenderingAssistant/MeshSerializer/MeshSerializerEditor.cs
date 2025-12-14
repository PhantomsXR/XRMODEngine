// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the com.Phantoms.ARMODRenderingAssistant.Editor.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.RenderAssistant.Editor.MeshSerializer
{
    public class MeshSerializerEditor : UnityEditor.EditorWindow
    {
        private static MeshSerializerEditor _INSTANCE;
        private GameObject meshContainer;
        private const string CONST_MESH_CONTAINER_NAME = "Mesh Container";
        private const string CONST_DIGITAL_OBJECT_CONTAINER_NAME = "Digital Object Container";
        private GameObject digitalObjectContainer;
        
        private static void GetMeshSerializerWindow()
        {
            _INSTANCE = GetWindow<MeshSerializerEditor>();
            _INSTANCE.ShowUtility();
        }

        private void OnEnable()
        {
            var tmp_Toolbar = new Toolbar();
            var tmp_GenerateMeshToolbarItem = new ToolbarToggle()
                {text = "Generate Mesh", tabIndex = 0, name = "generate_mesh_toolbar"};
            tmp_GenerateMeshToolbarItem.RegisterCallback(new EventCallback<ChangeEvent<bool>>(_evt =>
            {
                DisplayView(_evt.newValue ? 0 : 1);
            }));
            var tmp_SaveAlignmentToolbarItem = new ToolbarToggle()
                {text = "Generate Alignment", tabIndex = 1, name = "generate_alignment_toolbar"};
            tmp_SaveAlignmentToolbarItem.RegisterCallback(new EventCallback<ChangeEvent<bool>>(_evt =>
            {
                DisplayView(_evt.newValue ? 1 : 0);
            }));
            tmp_Toolbar.Add(tmp_GenerateMeshToolbarItem);
            tmp_Toolbar.Add(new ToolbarSpacer());
            tmp_Toolbar.Add(tmp_SaveAlignmentToolbarItem);
            rootVisualElement.Add(tmp_Toolbar);
            rootVisualElement.Add(GenerateMeshView());
            rootVisualElement.Add(GenerateAlignmentDataView());
            tmp_GenerateMeshToolbarItem.value = true;
        }

        private VisualElement GenerateMeshView()
        {
            var tmp_GenerateMeshVE = new VisualElement() {name = "generate_mesh_visual_element"};
            var tmp_FileScrollView = new ScrollView(ScrollViewMode.Vertical);
            var tmp_FolderObj = new ObjectField("Mesh Data")
            {
                allowSceneObjects = false,
            };
            tmp_FolderObj.RegisterValueChangedCallback(new EventCallback<ChangeEvent<Object>>(_evt =>
            {
                var tmp_PathOfFolder = AssetDatabase.GetAssetPath(_evt.newValue);
                if (string.IsNullOrEmpty(tmp_PathOfFolder)) return;
                if (AssetDatabase.IsValidFolder(tmp_PathOfFolder))
                {
                    tmp_FileScrollView.contentContainer.Clear();

                    var tmp_DataFilesPath =
                        Directory.GetFiles($"{Application.dataPath.Replace("Assets", "")}/{tmp_PathOfFolder}",
                            "*.bytes");
                    foreach (var tmp_FileOfPath in tmp_DataFilesPath)
                    {
                        var tmp_AssetName = Path.GetFileNameWithoutExtension(tmp_FileOfPath);
                        tmp_FileScrollView.contentContainer.Add(new Label(tmp_AssetName) {style = {flexGrow = 1}});
                    }
                }
            }));

            var tmp_CreateContainerBtn = new Button(() =>
            {
                var tmp_PathOfFolder = AssetDatabase.GetAssetPath(tmp_FolderObj.value);
                if (string.IsNullOrEmpty(tmp_PathOfFolder)) return;
                if (!AssetDatabase.IsValidFolder(tmp_PathOfFolder))
                {
                    Debug.LogError($"{tmp_FolderObj.value.name} is not a valid type, only support folder.");
                    return;
                }

                GameObject.DestroyImmediate(meshContainer, true);

                if (meshContainer == null)
                    meshContainer = GameObject.Find(CONST_MESH_CONTAINER_NAME);
                if (meshContainer == null)
                    meshContainer = new GameObject(CONST_MESH_CONTAINER_NAME);

                if (digitalObjectContainer == null)
                    digitalObjectContainer = GameObject.Find(CONST_DIGITAL_OBJECT_CONTAINER_NAME);
                if (digitalObjectContainer == null)
                    digitalObjectContainer = new GameObject(CONST_DIGITAL_OBJECT_CONTAINER_NAME);

                var tmp_DataFilesPath =
                    Directory.GetFiles($"{Application.dataPath.Replace("Assets", "")}/{tmp_PathOfFolder}", "*.bytes");
                foreach (var tmp_FileOfPath in tmp_DataFilesPath)
                {
                    var tmp_MeshBytes = File.ReadAllBytes(tmp_FileOfPath);
                    var tmp_AssetName = Path.GetFileNameWithoutExtension(tmp_FileOfPath);

                    Mesh tmp_NewMesh = new Mesh();
                    Phantom.XRMOD.RenderAssistant.Runtime.MeshSerializer.DeserializeMesh(tmp_MeshBytes, tmp_NewMesh);
                    var tmp_MeshFilter = new GameObject(tmp_AssetName).AddComponent<MeshFilter>();
                    tmp_MeshFilter.gameObject.AddComponent<MeshRenderer>().sharedMaterial =
                        new Material(Shader.Find("Universal Render Pipeline/Lit"));
                    tmp_MeshFilter.transform.SetParent(meshContainer.transform);
                    tmp_MeshFilter.sharedMesh = tmp_NewMesh;
                }
            })
            {
                text = $"Generate Meshes"
            };


            tmp_GenerateMeshVE.Add(tmp_CreateContainerBtn);
            tmp_GenerateMeshVE.Add(tmp_FolderObj);
            tmp_GenerateMeshVE.Add(tmp_FileScrollView);
            return tmp_GenerateMeshVE;
        }

        private VisualElement GenerateAlignmentDataView()
        {
            var tmp_GenerateAlignmentVE = new VisualElement()
            {
                name = "generate_alignment_visual_element",
                style =
                {
                    display = new StyleEnum<DisplayStyle>(DisplayStyle.None),
                    alignSelf = new StyleEnum<Align>(Align.Stretch),
                    flexGrow = 1
                }
            };

            var tmp_HorizontalLayoutVE = new VisualElement()
                {style = {flexDirection = new StyleEnum<FlexDirection>(FlexDirection.Row)}};

            List<Transform> tmp_AllAnchors = new List<Transform>();
            var tmp_ScrollView = new ScrollView(ScrollViewMode.Vertical);

            var tmp_FetchAnchorBtn = new Button(() =>
            {
                tmp_AllAnchors.Clear();
                tmp_ScrollView.contentContainer.Clear();

                if (digitalObjectContainer == null)
                    digitalObjectContainer = GameObject.Find(CONST_DIGITAL_OBJECT_CONTAINER_NAME);

                if (digitalObjectContainer == null) return;

                for (int tmp_ChildIdx = 0; tmp_ChildIdx < digitalObjectContainer.transform.childCount; tmp_ChildIdx++)
                {
                    var tmp_Anchor = digitalObjectContainer.transform.GetChild(tmp_ChildIdx);
                    var tmp_ItemGroup = new VisualElement()
                    {
                        style =
                        {
                            borderBottomColor = new StyleColor(new Color(0.39f, 0.39f, 0.39f)),
                            borderLeftColor = new StyleColor(new Color(0.39f, 0.39f, 0.39f)),
                            borderRightColor = new StyleColor(new Color(0.39f, 0.39f, 0.39f)),
                            borderTopColor = new StyleColor(new Color(0.39f, 0.39f, 0.39f)),
                            borderTopWidth = 1,
                            borderBottomWidth = 1,
                            borderLeftWidth = 1,
                            borderRightWidth = 1,
                            marginTop = 5,
                            marginLeft = 5,
                            marginRight = 5,
                            borderTopLeftRadius = 5,
                            borderBottomLeftRadius = 5,
                            borderBottomRightRadius = 5,
                            borderTopRightRadius = 5,
                            flexDirection = new StyleEnum<FlexDirection>(FlexDirection.Row),
                            alignContent = new StyleEnum<Align>(Align.Stretch),
                            alignItems = new StyleEnum<Align>(Align.Center)
                        }
                    };
                    tmp_AllAnchors.Add(tmp_Anchor);
                    tmp_ItemGroup.Add(new Label(tmp_Anchor.name) {style = {flexGrow = 1}});
                    tmp_ItemGroup.Add(new Button(() =>
                        {
                            tmp_AllAnchors.RemoveAt(tmp_ScrollView.IndexOf(tmp_ItemGroup));
                            tmp_ScrollView.contentContainer.Remove(tmp_ItemGroup);
                        })
                        {text = "×"});
                    tmp_ScrollView.contentContainer.Add(tmp_ItemGroup);
                }
            })
            {
                text = "Fetch Anchor",
                style =
                {
                    flexGrow = 1
                }
            };
            var tmp_GenerateAnchorDataBtn = new Button(() =>
            {
                var tmp_Path = EditorUtility.SaveFilePanel("Save Alignment Data", "", "AllAnchorJsonString", "json");
                if (string.IsNullOrEmpty(tmp_Path)) return;

                var tmp_AllAnchorSerialization = new AllAnchorSerialization();
                foreach (Transform tmp_Anchor in tmp_AllAnchors)
                {
                    tmp_AllAnchorSerialization.AllAnchorSerializations.Add(new AnchorSerializationData()
                    {
                        Name = tmp_Anchor.gameObject.name,
                        Position = tmp_Anchor.position,
                        Rotation = tmp_Anchor.rotation.eulerAngles,
                        Scale = tmp_Anchor.localScale
                    });
                }

                var tmp_AllAnchorJsonDataString = JsonUtility.ToJson(tmp_AllAnchorSerialization);
                File.WriteAllText(tmp_Path, tmp_AllAnchorJsonDataString);
                AssetDatabase.Refresh();
            })
            {
                text = "Generate Data",
                style =
                {
                    flexGrow = 1
                }
            };


            tmp_HorizontalLayoutVE.Add(tmp_FetchAnchorBtn);
            tmp_HorizontalLayoutVE.Add(tmp_GenerateAnchorDataBtn);
            tmp_GenerateAlignmentVE.Add(tmp_HorizontalLayoutVE);
            tmp_GenerateAlignmentVE.Add(tmp_ScrollView);
            return tmp_GenerateAlignmentVE;
        }

        private void DisplayView(int _value)
        {
            rootVisualElement.Q<VisualElement>("generate_mesh_visual_element").style.display =
                new StyleEnum<DisplayStyle>(_value == 0 ? DisplayStyle.Flex : DisplayStyle.None);
            rootVisualElement.Q<ToolbarToggle>("generate_mesh_toolbar").value = _value == 0;
            rootVisualElement.Q<VisualElement>("generate_alignment_visual_element").style.display =
                new StyleEnum<DisplayStyle>(_value == 1 ? DisplayStyle.Flex : DisplayStyle.None);
            rootVisualElement.Q<ToolbarToggle>("generate_alignment_toolbar").value = _value == 1;
        }

        [System.Serializable]
        public class AnchorSerializationData
        {
            public string Name;
            public Vector3 Position;
            public Vector3 Scale;
            public Vector3 Rotation;
        }

        [System.Serializable]
        public class AllAnchorSerialization
        {
            public List<AnchorSerializationData> AllAnchorSerializations = new List<AnchorSerializationData>();
        }
    }
}
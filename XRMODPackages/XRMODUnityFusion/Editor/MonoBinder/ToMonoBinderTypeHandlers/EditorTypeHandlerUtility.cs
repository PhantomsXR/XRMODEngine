// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Editor.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.UnityFusion.Runtime.CodeHook;
using Phantom.XRMOD.XRMODPackageTools.Editor;
using Phantom.XRMOD.XRMODPackageTools.Runtime;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;
using Utility = Phantom.XRMOD.XRMODPackageTools.Editor.Utility;

namespace Phantom.XRMOD.Runtime.Editor
{
    public static class EditorTypeHandlerUtility
    {
        public static string MakePrimitiveGenericData<T>(object _value)
        {
            List<T> tmp_NewList = new List<T>(_value as IEnumerable<T> ?? Array.Empty<T>());
            var tmp_SystemObject = new GenericPrimitiveObject<T>
            {
                List = tmp_NewList,
                ListType = typeof(T).ToString()
            };

            return JsonUtility.ToJson(tmp_SystemObject);
        }

        public static bool SkipConvert(FieldInfo _field)
        {
            var tmp_DontConvertAttribute = _field.IsDefined(typeof(DontConvertToMonoBinderAttribute), true);
            var tmp_HideInInspectorAttribute = _field.IsDefined(typeof(HideInInspector), true);

            if (_field.IsPublic)
            {
                return tmp_DontConvertAttribute || tmp_HideInInspectorAttribute;
            }

            bool tmp_HasSerializeFieldAttribute = _field.IsDefined(typeof(SerializeField), true);
            if (!tmp_HasSerializeFieldAttribute || tmp_DontConvertAttribute || tmp_HideInInspectorAttribute)
            {
                return true;
            }

            return false;
        }

        public static bool AddAssetToPackageTools(Object _assetObject)
        {
            // Add this gameobject to package tool
            var tmp_PathStr = AssetDatabase.GetAssetPath(_assetObject);
            if (string.IsNullOrEmpty(tmp_PathStr)) return false;
            // Avoid treating nested prefabs as separate resources.
            var tmp_Extension = Path.GetExtension(tmp_PathStr);
            var tmp_PathOfAsset =
                Path.Combine(Path.GetDirectoryName(tmp_PathStr) ?? string.Empty, $"{_assetObject.name}{tmp_Extension}");
            if (!File.Exists(Application.dataPath.Replace("Assets", tmp_PathOfAsset))) return false;
            try
            {
                var tmp_EditingProjectData = PackageToolsEditor.ALL_PROJECT_CACHE.GetEditingProjectData();
                List<ContentModel> tmp_ContentList = new List<ContentModel>();
                tmp_EditingProjectData.DetailCacheData.Groups.ForEach(_group =>
                {
                    tmp_ContentList.AddRange(_group.Assets);
                });

                var tmp_Idx =
                    tmp_ContentList.FindIndex(_content => _content.DisplayName == _assetObject.name);
                if (tmp_Idx < 0)
                {
                    string tmp_TypeName = _assetObject.GetType().FullName;
                    var tmp_Assets = AssetDatabase.LoadAllAssetsAtPath(tmp_PathStr);
                    foreach (var tmp_Asset in tmp_Assets)
                    {
                        if (tmp_Asset is not Sprite) continue;
                        tmp_TypeName = typeof(Sprite).FullName;
                    }

                    tmp_ContentList.Add(new ContentModel
                    {
                        Id = tmp_ContentList.Count,
                        DisplayName = _assetObject.name,
                        AssetPathInUnity = tmp_PathStr,
                        Type = tmp_TypeName
                    });
                }

                var tmp_ProjectPath = Utility.ShortenPath(tmp_EditingProjectData.DetailCacheData.GetProjectPath());
                var tmp_FilePath = $"{tmp_ProjectPath}/Cache/{nameof(RuntimeAssetReferenceDatabase)}.asset";
                var tmp_Rardb = AssetDatabase.LoadAssetAtPath<RuntimeAssetReferenceDatabase>(tmp_FilePath);

                if (tmp_Rardb == null)
                {
                    tmp_Rardb = ScriptableObject.CreateInstance<RuntimeAssetReferenceDatabase>();
                    AssetDatabase.CreateAsset(tmp_Rardb, tmp_FilePath);
                }


                if (!tmp_Rardb.ExistAssetReference(_assetObject.name))
                {
                    var tmp_AssetReferenceData = ScriptableObject.CreateInstance<AssetReferenceData>();
                    tmp_AssetReferenceData.name = _assetObject.name;
                    tmp_AssetReferenceData.AssetName = _assetObject.name;
                    tmp_AssetReferenceData.AssetType = _assetObject.GetType().FullName;
                    AssetDatabase.AddObjectToAsset(tmp_AssetReferenceData, tmp_Rardb);
                    tmp_Rardb.AddAssetReference(tmp_AssetReferenceData);
                }

                ContentView.TreeRenderer?.Reload();
                return true;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
                throw;
            }
        }

        public static bool SetAssetReferenceArrayField(object _value, MonoField _field, Type _type)
        {
            if (_value is not IList tmp_List) return false;
            Dictionary<string, Object> tmp_ObjName = new();
            foreach (object tmp_O in tmp_List)
            {
                if (tmp_O is not Object tmp_UObj) continue;

                if (AddAssetToPackageTools(tmp_UObj))
                {
                    tmp_ObjName.TryAdd(tmp_UObj.name, tmp_UObj);
                }
            }

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            if (tmp_ObjName.Values.Count <= 0) return false;
            _field.Value = JsonConvert.SerializeObject(tmp_ObjName.Keys);
            _field.FieldType = MonoField.FieldTypeEnum.AssetReferenceArray;
            _field.AssetType = _type.ToString();
            return true;
        }
    }
}
// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Editor.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.UnityFusion.Runtime.CodeHook;
using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.Runtime.Editor
{
    public partial class MonoBinderEditor
    {
        [InitializeOnLoadMethod]
        private static void RegisterConvertAction()
        {
            EditorNotificationCenter.Center.AddAsyncObserver(ConvertToExecutor,
                nameof(ConvertToMonoBinderBatch));
            EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
        }

        static void OnPlayModeStateChanged(PlayModeStateChange _state)
        {
            if (_state == PlayModeStateChange.EnteredEditMode)
            {
                EditorNotificationCenter.Center.AddAsyncObserver(ConvertToExecutor,
                    nameof(ConvertToMonoBinderBatch));
            }
        }

        private static async Task<object> ConvertToExecutor(BaseNotificationData _baseNotification)
        {
            if (_baseNotification.ObjectData is GameObject tmp_GameObject)
                await ConvertToMonoBinderBatch(tmp_GameObject);
            return Task.CompletedTask;
        }

        [MenuItem("Tools/XR-MOD/Tools/Convert To MonoBinder (Batch)", priority = 99)]
        private static async void ConvertToMonoBinderBatch()
        {
            var tmp_SelectedObj = Selection.activeObject;
            if (tmp_SelectedObj == null) return;
            var tmp_PrefabOrGo = tmp_SelectedObj as GameObject;
            if (!EditorUtility.DisplayDialog("Convert to MonoBinder",
                    "Convert to MonoBinder will remove this script! Are you sure?", "Ok", "Cancel")) return;
            await ConvertToMonoBinderBatch(tmp_PrefabOrGo);
        }

        public static async Task ConvertToMonoBinderBatch(GameObject _selectedObj)
        {
            try
            {
                var tmp_SelectedObjPath = AssetDatabase.GetAssetPath(_selectedObj);
                var tmp_Go = PrefabUtility.LoadPrefabContents(tmp_SelectedObjPath);
                // ReSharper disable once InconsistentNaming
                var tmp_XRMODBehaviours = tmp_Go?.GetComponentsInChildren<XRMODBehaviour>(true);
                if (tmp_XRMODBehaviours == null || tmp_XRMODBehaviours.Length <= 0) return;

                foreach (XRMODBehaviour tmp_Behaviour in tmp_XRMODBehaviours)
                {
                    if (!tmp_Behaviour.gameObject.TryGetComponent<MonoBinder>(out var tmp_MonoBinder))
                    {
                        tmp_MonoBinder = tmp_Behaviour.gameObject.AddComponent<MonoBinder>();
                    }

                    var tmp_MonoType = tmp_Behaviour.GetType();
                    tmp_MonoBinder.ScriptList ??= new List<MonoData>();

                    var tmp_IndexOfScript =
                        tmp_MonoBinder.ScriptList.FindIndex(_data => _data.ClassName.Equals(tmp_MonoType.Name));

                    if (tmp_IndexOfScript >= 0)
                    {
                        var tmp_DataOfScript = tmp_MonoBinder.ScriptList[tmp_IndexOfScript];
                        if (String.Compare(tmp_DataOfScript.ClassName, tmp_MonoType.Name, StringComparison.Ordinal) !=
                            0)
                        {
                            tmp_DataOfScript.ClassName = tmp_MonoType.Name;
                        }

                        if (String.Compare(tmp_DataOfScript.ClassNamespace, tmp_MonoType.Namespace,
                                StringComparison.Ordinal) != 0)
                        {
                            tmp_DataOfScript.ClassNamespace = tmp_MonoType.Namespace;
                        }
                    }
                    else
                    {
                        tmp_MonoBinder.ScriptList.Add(new MonoData()
                        {
                            ClassName = tmp_MonoType.Name,
                            ClassNamespace = tmp_MonoType.Namespace
                        });
                    }
                    SharedData.TARGET_MONO = tmp_Behaviour;
                    SharedData.TARGET_MONO.enabled = true;
                    await GrabFieldsType(tmp_MonoBinder);
                    if (tmp_Behaviour)
                        tmp_Behaviour.enabled = false;
                }
                
                PrefabUtility.SaveAsPrefabAsset(tmp_Go, tmp_SelectedObjPath); 
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                EditorUtility.ClearProgressBar();
                
                AssetDatabase.SaveAssets();
                AssetDatabase.Refresh();
            }
        }

        [MenuItem("Tools/XR-MOD/Tools/Remove All MonoBinder (Batch)", priority = 98)]
        private static void RemoveAllMonoBinderBatch()
        {
            var tmp_SelectedObj = Selection.activeObject;
            if (tmp_SelectedObj == null) return;
            var tmp_MonoBinders = (tmp_SelectedObj as GameObject)?.GetComponentsInChildren<MonoBinder>(true);
            if (tmp_MonoBinders == null || tmp_MonoBinders.Length <= 0) return;

            if (!EditorUtility.DisplayDialog("Remove All MonoBinders",
                    "It will remove all MonoBinder scripts! Are you sure?", "Ok", "Cancel")) return;
            for (int tmp_Idx = 0; tmp_Idx < tmp_MonoBinders.Length; tmp_Idx++)
            {
                if (tmp_MonoBinders[tmp_Idx].gameObject.TryGetComponent<XRMODBehaviour>(out var tmp_Behaviour))
                {
                    tmp_Behaviour.enabled = true;
                }

                DestroyImmediate(tmp_MonoBinders[tmp_Idx], true);
            }
        }
    }
}
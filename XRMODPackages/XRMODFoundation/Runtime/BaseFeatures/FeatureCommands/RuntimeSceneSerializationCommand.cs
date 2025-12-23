#if INSTALL_RUNTIMESERIALIZATION
// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.BaseFeaturesModule.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using System.Threading.Tasks;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.UnityFusion.Runtime.CodeHook;
//using Unity.RuntimeSceneSerialization;
using UnityEngine;
//using UnityEngine.Assertions;

namespace Phantom.XRMOD.BaseFeatures.Runtime
{
    /// <summary>
    /// Command that handles importing and instantiating entire Unity scenes that were serialized at runtime.
    /// It binds scripts (MonoBinders) and applies lighting bakes after importing.
    /// </summary>
    public class RuntimeSceneSerializationCommand : ICommand, IReleaseCommand
    {
        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(LoadRuntimeSceneExecution,
                nameof(ActionParameterDataType.LoadRuntimeScene));
        }

        private async void LoadRuntimeSceneExecution(BaseNotificationData _base)
        {
            if (string.IsNullOrEmpty(_base.BaseData)) return;
            PropertyBagOverrides.InitializeOverrides();
            await Task.Delay(100);
            var tmp_Data = _base.BaseData.Split("|");

            if (_base.ObjectData is not AssetPack _assetPack) return;
            var tmp_ProcessContainer = GameObject.Find(tmp_Data[0]).transform;
            List<GameObject> tmp_SceneGos = new List<GameObject>();
            SceneSerialization.ImportScene(tmp_Data[1], _assetPack, _goes =>
            {
                tmp_SceneGos.AddRange(_goes);
                List<MonoBinder> tmp_AllMonoBinder = new List<MonoBinder>();
                foreach (GameObject tmp_Go in _goes)
                {
                    if (tmp_Go.TryGetComponent<MonoBinder>(out var tmp_MonoBinder))
                    {
                        tmp_AllMonoBinder.Add(tmp_MonoBinder);
                    }
                }

                // Binding All scripts
                BinderManager.DoBind(tmp_AllMonoBinder);
            });


            foreach (GameObject tmp_Go in tmp_SceneGos)
            {
                tmp_Go.transform.SetParent(tmp_ProcessContainer);
            }

            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.ForceLightingBakeApply), new BaseNotificationData());
        }

        public void Release(string _projectName = null)
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.LoadRuntimeScene));
            ActionNotificationCenter.DefaultCenter.RemoveObserver(
                nameof(ActionParameterDataType.ForceLightingBakeApply));
        }
    }
}
#endif
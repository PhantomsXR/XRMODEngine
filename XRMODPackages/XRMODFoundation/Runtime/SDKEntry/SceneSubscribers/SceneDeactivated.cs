// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the XR-MOD SDK.
// 
// The XR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact nswell@phantomsxr.com for licensing requests.
// ===============================================================================*/


using System;
using System.Collections;
using System.Threading.Tasks;
using Phantom.XRMOD.Models.Runtime;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.XR.ARFoundation;
using Phantom.XRMOD.Core.Runtime;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.SDKEntry.Runtime
{
    /// <summary>
    /// Subscriber that handles cleanup when an XR scene is deactivated.
    /// Releases memory, unregisters models, and handles player unloading.
    /// </summary>
    public class SceneDeactivated
    {
        /// <summary>
        /// Deactivated current scene to release the memory
        /// </summary>
        public bool Executed()
        {
            try
            {
                Debug.Log(nameof(SceneDeactivated));
                FixScreenFreeze();
                return true;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
                return false;
            }
        }


        private async void FixScreenFreeze()
        {
            //Reset to low memory quality level.
            //To reduce the memory required when running in the background.
            QualitySettings.SetQualityLevel(3, true);
            await Task.Delay(12);
            var tmp_EngineType = IocContainer.GetIoc.Resolve<SdkConfigModel>().SDKConfiguration.Value.engineType;

            //Why to unregister at here?
            //Because the two sets of data will also be used to
            IocContainer.GetIoc.UnRegister<SdkConfigModel>();
            IocContainer.GetIoc.UnRegister<BaseContextDataModel>();

            LoaderUtility.Deinitialize();

            await Task.Delay(12);

            // Clean up the memory.
            GC.Collect();
            Resources.UnloadUnusedAssets();

            if (tmp_EngineType == EngineType.Native)
            {
#if !ENABLED_FOR_DEBUG
                //Unload the unity player
                Application.Unload();
#endif
            }
            else
            {
                var tmp_SDKEntryPoint = Object.FindObjectOfType<SDKEntryPoint>();
                if (tmp_SDKEntryPoint)
                {
                    tmp_SDKEntryPoint.gameObject.DestroyWithPlatform();
                }
            }
        }
    }
}
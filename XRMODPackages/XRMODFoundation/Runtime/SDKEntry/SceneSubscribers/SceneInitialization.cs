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
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.SDKEntry.Runtime
{
    /// <summary>
    /// Subscriber that handles initialization when the main XR scene is loaded.
    /// Instantiates the device launcher and sets up initial scene state.
    /// </summary>
    public class SceneInitialization
    {
        private Camera uiCamera;

        public bool Executed()
        {
            try
            {
                var tmp_SDKInformation = Resources.Load<SDKInformation>(nameof(SDKInformation));
                if (!tmp_SDKInformation) return false;
                if (SceneManager.GetActiveScene().name != "Main") return false;
                if (tmp_SDKInformation.DeviceLauncher == null) return true;
                var tmp_DeviceLauncher = Object.Instantiate(tmp_SDKInformation.DeviceLauncher);
                tmp_DeviceLauncher.transform.localPosition = Vector3.zero;
                tmp_DeviceLauncher.transform.localRotation = Quaternion.identity;

                return true;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
            }

            return false;
        }
    }
}
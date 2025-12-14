// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Pico.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Threading.Tasks;
using Phantom.XRMOD.Models.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.SDKEntry.Runtime.Test
{
    public class LaunchAction : MonoBehaviour
    {
        public SDKConfiguration Configure;
        public string ProjectUid = "180536908";

        public async void Luanch()
        {
            var tmp_SDKEntry = FindObjectOfType<SDKEntryPoint>();
            tmp_SDKEntry.InitSDK(JsonUtility.ToJson(Configure));
            await Task.Delay(1000);
            tmp_SDKEntry.LaunchXRQuery(ProjectUid);
        }
    }
}
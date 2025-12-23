// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the com.Phantoms.PackageTools.Runtime.
// //
// // The XRMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.XRMODUtilites.Runtime
{
    /// <summary>
    /// Component used to store and manage the unique process identifier for an XR experience.
    /// </summary>
    public class ProcessIdComponent : MonoBehaviour
    {
        private string processId;
        public string ProcessId => processId;
        [HideInInspector] public byte SpaceType;

        public void InitProcessId(string _processId)
        {
            processId = _processId;
        }

        // private void OnDisable()
        // {
        //     ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
        //         new ProcessesNotificationData()
        //         {
        //             ProcessId = processId,
        //         });
        // }
    }
}
// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.VisionOSModule.Runtime.
// //
// // The AVPPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.VisionOSModule.Runtime.Models;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

namespace Phantom.XRMOD.VisionOSModule.Runtime
{
    public class BuildVisionOSARAvailabilityCommand: ICommand, IReleaseCommand
    {
        public void Execute()
        {
            var tmp_MonoBehaviour = Object.FindObjectOfType<MonoBehaviour>();
            tmp_MonoBehaviour.StartCoroutine(CheckAvailability());
        }

        private IEnumerator CheckAvailability()
        {
            if (ARSession.state is ARSessionState.None or ARSessionState.CheckingAvailability)
            {
                yield return ARSession.CheckAvailability();
            }

            IocContainer.GetIoc.Resolve<ARContextDataModel>().ARSessionState.Value =
                Application.isEditor ? ARSessionState.SessionTracking : ARSession.state;
        }

        public void Release(string _projectName = null)
        {
        }
    }

}
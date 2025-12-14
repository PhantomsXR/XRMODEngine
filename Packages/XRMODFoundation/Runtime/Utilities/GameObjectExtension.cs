// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODUtilites.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.XRMODUtilites.Runtime
{
    public static class GameObjectExtension
    {
        public static GameObject InstantiateWithTransform(this GameObject _prefab, Transform _parent)
        {
            var tmp_InstantiateData = new InstantiateArgs()
            {
                Prefab = _prefab,
                Parent = _parent
            };
            var tmp_Results = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                nameof(ActionParameterDataType.Instantiate), tmp_InstantiateData);
            return tmp_Results?[0] as GameObject;
        }
    }
}
// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the com.Phatoms.Immersal.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEngine;

namespace Immersal.AR
{
    [RequireComponent(typeof(ARMap))]
    public class ImmersalMapRegister : MonoBehaviour
    {
        public void Start()
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.OnImmersalMapRegister), new BaseNotificationData());
        }
    }
}
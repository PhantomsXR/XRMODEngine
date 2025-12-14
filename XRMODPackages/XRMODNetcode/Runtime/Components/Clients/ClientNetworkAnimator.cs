// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.NetcodeModule.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Unity.Netcode.Components;
using UnityEngine;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    public class ClientNetworkAnimator:NetworkAnimator
    {
        /// <summary>
        /// If true, only the Server can update the animator of the object.
        /// </summary>
        [SerializeField, Tooltip("Determines Local or Server animator updating.")]
        bool isServerAuthoritative = false;

        ///<inheritdoc/>
        protected override bool OnIsServerAuthoritative()
        {
            return isServerAuthoritative;
        }
    }
}
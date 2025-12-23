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
    /// <summary>
    /// Client-authoritative network animator that allows clients to update animator states.
    /// </summary>
    /// <remarks>
    /// Extends Unity's <see cref="NetworkAnimator"/> to support client-side authority for animation updates.
    /// Useful for player avatars where the owning client should drive animations.
    /// </remarks>
    public class ClientNetworkAnimator : NetworkAnimator
    {
        /// <summary>
        /// If true, only the Server can update the animator of the object.
        /// If false, the owner client can update the animator.
        /// </summary>
        [SerializeField, Tooltip("Determines Local or Server animator updating.")]
        bool isServerAuthoritative = false;

        /// <inheritdoc/>
        protected override bool OnIsServerAuthoritative()
        {
            return isServerAuthoritative;
        }
    }
}
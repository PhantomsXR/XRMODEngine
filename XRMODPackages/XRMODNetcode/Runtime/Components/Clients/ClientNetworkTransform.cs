// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.NetcodeModule.Runtime.
// //
// // The VisionOSPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Unity.Netcode.Components;
using UnityEngine;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    /// <summary>
    /// Client-authoritative network transform that allows clients to update transform states.
    /// </summary>
    /// <remarks>
    /// Extends Unity's <see cref="NetworkTransform"/> to support client-side authority for transform updates.
    /// This is essential for player-controlled objects where the owning client should drive position, rotation, and scale.
    /// </remarks>
    [DisallowMultipleComponent]
    public class ClientNetworkTransform : NetworkTransform
    {
        /// <summary>
        /// If true, only the Server can update the transform of the object.
        /// If false, the owner client can update the transform.
        /// </summary>
        [SerializeField, Tooltip("Determines Local or Server transform updating.")]
        bool isServerAuthoritative = false;

        /// <inheritdoc/>
        protected override bool OnIsServerAuthoritative()
        {
            return isServerAuthoritative;
        }
    }
}
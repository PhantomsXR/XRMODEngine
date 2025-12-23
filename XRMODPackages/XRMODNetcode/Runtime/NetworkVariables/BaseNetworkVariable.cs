// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.NetcodeModule.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Unity.Netcode;
using UnityEngine;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    /// <summary>
    /// Base class for all MonoBehaviour-based network variables in XRMOD.
    /// </summary>
    /// <remarks>
    /// This abstract class provides common configuration for network variables:
    /// - Read/Write permissions
    /// - Change event subscriptions
    /// - Unique key identification
    /// 
    /// All network variable components require an <see cref="XRMODNetworkBehaviour"/> on the same GameObject.
    /// Derived classes implement specific synchronization logic for different data types.
    /// </remarks>
    [RequireComponent(typeof(XRMODNetworkBehaviour))]
    public abstract class BaseNetworkVariable : NetworkBehaviour
    {
        /// <summary>
        /// Determines who can write (modify) this network variable.
        /// </summary>
        /// <remarks>
        /// Default is Server-only write permission. Change this to allow owner or everyone to write.
        /// </remarks>
        public NetworkVariableWritePermission WritePermission = NetworkVariableWritePermission.Server;
        
        /// <summary>
        /// Determines who can read this network variable.
        /// </summary>
        /// <remarks>
        /// Default is Everyone can read. Restricting read access limits which clients receive updates.
        /// </remarks>
        public NetworkVariableReadPermission ReadPermission = NetworkVariableReadPermission.Everyone;
        
        /// <summary>
        /// Whether to invoke value change events when the variable updates.
        /// </summary>
        /// <remarks>
        /// Enable this to receive callbacks via UnityEvents when the value changes.
        /// Disable if you don't need change notifications to save performance.
        /// </remarks>
        public bool UseChangeEvent;
        
        /// <summary>
        /// Unique identifier key for this network variable.
        /// </summary>
        /// <remarks>
        /// Used for debugging and identification purposes. Helpful when multiple network variables exist on the same object.
        /// </remarks>
        public string Key;
    }
}
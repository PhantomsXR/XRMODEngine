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

using System;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Events;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    /// <summary>
    /// Abstract base class for MonoBehaviour-based network variables with type-specific value handling.
    /// </summary>
    /// <typeparam name="T">The type of value to synchronize over the network.</typeparam>
    /// <remarks>
    /// This class provides a Unity-friendly wrapper around Unity Netcode's NetworkVariable&lt;T&gt;.
    /// It exposes the network variable as a MonoBehaviour component that can be:
    /// - Configured in the Unity Inspector
    /// - Accessed via UnityEvents for value changes
    /// - Managed with standard Unity lifecycle methods
    /// 
    /// Concrete implementations simply need to specify the type parameter.
    /// All derived classes inherit automatic network synchronization and permission handling.
    /// </remarks>
    public abstract class AbstractNetworkVariable<T> : BaseNetworkVariable
    {
        /// <summary>
        /// Event invoked when the network variable value changes.
        /// </summary>
        /// <remarks>
        /// Parameters are (oldValue, newValue). This event fires on all clients when synced.
        /// </remarks>
        [HideInInspector] public UnityEvent<T, T> OnValueChanged = new();
        
        /// <summary>
        /// The underlying NetworkVariable storing the synchronized value.
        /// </summary>
        [SerializeField] protected NetworkVariable<T> value;

        /// <summary>
        /// Gets or sets the synchronized value.
        /// </summary>
        /// <remarks>
        /// Writing to this property is permission-controlled. By default, only the server can write.
        /// Attempting to write without proper permissions will log an error.
        /// </remarks>
        public T Value
        {
            get => value.Value;
            set
            {
                if (WritePermission == NetworkVariableWritePermission.Server && IsServer)
                    this.value.Value = value;
                else
                {
                    Debug.LogError($"Write permissions (Server) for {name}.{Key}.");
                }
            }
        }


        private void Awake()
        {
            if (!enabled) return;
            value ??= new NetworkVariable<T>(readPerm: ReadPermission, writePerm: WritePermission);
            if (UseChangeEvent)
                value.OnValueChanged = OnChangeCallback;
        }


        /// <summary>
        /// Internal callback invoked when the underlying network variable value changes.
        /// </summary>
        /// <param name="_oldValue">The value before the change.</param>
        /// <param name="_newValue">The value after the change.</param>
        private void OnChangeCallback(T _oldValue, T _newValue)
        {
            OnValueChanged?.Invoke(_oldValue, _newValue);
        }
    }
}
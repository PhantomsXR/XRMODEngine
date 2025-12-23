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

using Phantom.XRMOD.Core.Runtime;
using Unity.Collections;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.Events;

namespace Phantom.XRMOD.NetcodeModule.Runtime.Gameplay
{
    /// <summary>
    /// Base class for networked player objects using Unity Netcode for GameObjects (NGO).
    /// </summary>
    /// <remarks>
    /// This class provides synchronized player properties like name, device type, and ready state.
    /// It uses network variables for automatic synchronization and exposes bindable properties for UI integration.
    /// </remarks>
    public abstract class NGOPlayerBase : NetworkBehaviour
    {
        /// <summary>
        /// The unique player ID.
        /// </summary>
        public ulong PlayerId;

        /// <summary>
        /// Gets the player's name from the network variable.
        /// </summary>
        public string GetPlayerName => playerNameNetworkVariable.Value.ToString();

        /// <summary>
        /// Gets the player's device type from the network variable.
        /// </summary>
        public string GetDeviceType => deviceTypeNetworkVariable.Value.ToString();
        
        /// <summary>
        /// Gets whether the player is ready.
        /// </summary>
        public bool IsReady => isReadyNetworkVariable.Value;

        /// <summary>
        /// Network variable for the player's name (owner-writable, everyone-readable).
        /// </summary>
        protected readonly NetworkVariable<FixedString128Bytes> playerNameNetworkVariable = new("",
            NetworkVariableReadPermission.Everyone,
            NetworkVariableWritePermission.Owner);

        /// <summary>
        /// Network variable for the player's device type (owner-writable, everyone-readable).
        /// </summary>
        protected readonly NetworkVariable<FixedString32Bytes> deviceTypeNetworkVariable = new("VP",
            NetworkVariableReadPermission.Everyone,
            NetworkVariableWritePermission.Owner);

        /// <summary>
        /// Network variable for the player's ready state (owner-writable, everyone-readable).
        /// </summary>
        protected readonly NetworkVariable<bool> isReadyNetworkVariable = new(false,
            NetworkVariableReadPermission.Everyone,
            NetworkVariableWritePermission.Owner);

        /// <summary>
        /// Bindable property for the player's name (useful for UI binding).
        /// </summary>
        public BindableProperty<string> PlayerNameProperty = new();
        
        /// <summary>
        /// Bindable property for the player's device type (useful for UI binding).
        /// </summary>
        public BindableProperty<string> DeviceTypeProperty = new();
        
        /// <summary>
        /// Bindable property for the player's ready state (useful for UI binding).
        /// </summary>
        public BindableProperty<bool> IsReadyProperty = new();


        /// <summary>
        /// Event invoked when the player spawns (parameter indicates if this is the local owner).
        /// </summary>
        public UnityEvent<bool> OnSpawned;
        
        /// <summary>
        /// Event invoked after the player spawns (parameter indicates if this is the local owner).
        /// </summary>
        public UnityEvent<bool> OnPostSpawn;


        /// <summary>
        /// Called when the object awakens. Subscribes to network variable change events.
        /// </summary>
        protected virtual void Awake()
        {
            playerNameNetworkVariable.OnValueChanged += OnPlayerNameChanged;
            deviceTypeNetworkVariable.OnValueChanged += OnDeviceTypeChanged;
            isReadyNetworkVariable.OnValueChanged += OnReadyStateChanged;
        }

        private void OnReadyStateChanged(bool _previousValue, bool _newValue)
        {
            IsReadyProperty.Value = _newValue;
        }

        private void OnDeviceTypeChanged(FixedString32Bytes _previousValue, FixedString32Bytes _newValue)
        {
            DeviceTypeProperty.Value = _newValue.ToString();
        }

        private void OnPlayerNameChanged(FixedString128Bytes _previousValue, FixedString128Bytes _newValue)
        {
            PlayerNameProperty.Value = _newValue.ToString();
        }


        /// <summary>
        /// Sets the player's name (only callable by the owner).
        /// </summary>
        /// <param name="_playerName">The new player name.</param>
        public virtual void SetPlayerName(string _playerName)
        {
            if (!IsOwner) return;
            playerNameNetworkVariable.Value = _playerName;
        }

        /// <summary>
        /// Sets the player's device type (only callable by the owner).
        /// </summary>
        /// <param name="_deviceType">The device type string.</param>
        public virtual void SetPlayerDeviceType(string _deviceType)
        {
            if (!IsOwner) return;
            deviceTypeNetworkVariable.Value = _deviceType;
        }

        /// <summary>
        /// Sets the player's ready state (only callable by the owner).
        /// </summary>
        /// <param name="_ready">Whether the player is ready.</param>
        public virtual void SetPlayerReadyState(bool _ready)
        {
            if (!IsOwner) return;
            isReadyNetworkVariable.Value = _ready;
        }

        /// <summary>
        /// Gets whether this player instance is valid (has a valid player ID).
        /// </summary>
        public bool IsValid => PlayerId != ulong.MaxValue;

        /// <summary>
        /// Called when the network object spawns.
        /// </summary>
        public override void OnNetworkSpawn()
        {
            base.OnNetworkSpawn();
            OnSpawned?.Invoke(IsOwner);
        }

        /// <summary>
        /// Called when the network object is destroyed.
        /// </summary>
        public virtual void OnNetworkDestroy()
        {
            
        }

        /// <summary>
        /// Called after the network object spawns.
        /// </summary>
        protected override void OnNetworkPostSpawn()
        {
            base.OnNetworkPostSpawn();
            OnPostSpawn?.Invoke(IsOwner);

            if (IsOwner) return;
            OnDeviceTypeChanged(deviceTypeNetworkVariable.Value, deviceTypeNetworkVariable.Value);
            OnPlayerNameChanged(playerNameNetworkVariable.Value, playerNameNetworkVariable.Value);
        }
    }
}
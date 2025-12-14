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
    public abstract class NGOPlayerBase : NetworkBehaviour
    {
        public ulong PlayerId;

        /// <summary>
        /// Player Name string that reads from the internal NetworkVariable for the Player Name.
        /// </summary>
        public string GetPlayerName => playerNameNetworkVariable.Value.ToString();

        public string GetDeviceType => deviceTypeNetworkVariable.Value.ToString();
        public bool IsReady => isReadyNetworkVariable.Value;

        protected readonly NetworkVariable<FixedString128Bytes> playerNameNetworkVariable = new("",
            NetworkVariableReadPermission.Everyone,
            NetworkVariableWritePermission.Owner);

        protected readonly NetworkVariable<FixedString32Bytes> deviceTypeNetworkVariable = new("VP",
            NetworkVariableReadPermission.Everyone,
            NetworkVariableWritePermission.Owner);

        protected readonly NetworkVariable<bool> isReadyNetworkVariable = new(false,
            NetworkVariableReadPermission.Everyone,
            NetworkVariableWritePermission.Owner);

        public BindableProperty<string> PlayerNameProperty = new();
        public BindableProperty<string> DeviceTypeProperty = new();
        public BindableProperty<bool> IsReadyProperty = new();


        public UnityEvent<bool> OnSpawned;
        public UnityEvent<bool> OnPostSpawn;


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


        public virtual void SetPlayerName(string _playerName)
        {
            if (!IsOwner) return;
            playerNameNetworkVariable.Value = _playerName;
        }

        public virtual void SetPlayerDeviceType(string _deviceType)
        {
            if (!IsOwner) return;
            deviceTypeNetworkVariable.Value = _deviceType;
        }

        public virtual void SetPlayerReadyState(bool _ready)
        {
            if (!IsOwner) return;
            isReadyNetworkVariable.Value = _ready;
        }

        public bool IsValid => PlayerId != ulong.MaxValue;

        public override void OnNetworkSpawn()
        {
            base.OnNetworkSpawn();
            OnSpawned?.Invoke(IsOwner);
        }

        public virtual void OnNetworkDestroy()
        {
            
        }

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
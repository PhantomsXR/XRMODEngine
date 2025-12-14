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
    public abstract class AbstractNetworkVariable<T> : BaseNetworkVariable
    {
        [HideInInspector] public UnityEvent<T, T> OnValueChanged = new();
        [SerializeField] protected NetworkVariable<T> value;

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


        private void OnChangeCallback(T _oldValue, T _newValue)
        {
            OnValueChanged?.Invoke(_oldValue, _newValue);
        }
    }
}
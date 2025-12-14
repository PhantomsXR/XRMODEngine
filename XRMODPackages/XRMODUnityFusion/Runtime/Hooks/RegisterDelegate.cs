// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the XR-MOD SDK.
// 
// The XR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact nswell@phantomsxr.com for licensing requests.
// ===============================================================================*/

using System;
using Phantom.XRMOD.ActionNotification.Runtime;
//using com.PhantomsXR.MirrorExtension.Runtime;
using UnityFusion.Runtime.Intepreter;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using UnityEngine.U2D;
using UnityEngine.Video;
using UnityFusion.CLRBinding.Adapter;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;
using InputDevice = UnityEngine.XR.InputDevice;

namespace Phantom.XRMOD.UnityFusion.Runtime
{
    public class RegisterDelegate : IRegister
    {
        public void Register(AppDomain _appDomain)
        {
            _appDomain.DelegateManager.RegisterMethodDelegate<BaseNotificationData>();
            _appDomain.DelegateManager.RegisterMethodDelegate<Transform>();
            _appDomain.DelegateManager.RegisterMethodDelegate<BaseEventData>();
            _appDomain.DelegateManager.RegisterMethodDelegate<GameObject>();
            _appDomain.DelegateManager.RegisterMethodDelegate<Texture2D>();
            _appDomain.DelegateManager.RegisterMethodDelegate<TextAsset>();
            _appDomain.DelegateManager.RegisterMethodDelegate<AudioClip>();
            _appDomain.DelegateManager.RegisterMethodDelegate<SpriteAtlas>();
            _appDomain.DelegateManager.RegisterMethodDelegate<VideoClip>();
            _appDomain.DelegateManager.RegisterMethodDelegate<Material>();
            _appDomain.DelegateManager.RegisterMethodDelegate<Shader>();
            _appDomain.DelegateManager.RegisterMethodDelegate<Sprite>();
            _appDomain.DelegateManager.RegisterMethodDelegate<Animation>();
#if UNITY_6000_0_OR_NEWER
            _appDomain.DelegateManager.RegisterMethodDelegate<PhysicsMaterial>();
#else
            _appDomain.DelegateManager.RegisterMethodDelegate<PhysicMaterial>();
#endif
            _appDomain.DelegateManager.RegisterMethodDelegate<int>();
            _appDomain.DelegateManager.RegisterMethodDelegate<bool>();
            _appDomain.DelegateManager.RegisterMethodDelegate<int[]>();
            _appDomain.DelegateManager.RegisterMethodDelegate<byte[]>();
            _appDomain.DelegateManager.RegisterMethodDelegate<long[]>();
            _appDomain.DelegateManager.RegisterMethodDelegate<float[]>();
            _appDomain.DelegateManager.RegisterMethodDelegate<string[]>();
            
            _appDomain.DelegateManager.RegisterMethodDelegate<Single>();
            _appDomain.DelegateManager.RegisterMethodDelegate<String>();


            _appDomain.DelegateManager.RegisterMethodDelegate<Single, LitJson.JsonWriter>();
            _appDomain.DelegateManager.RegisterMethodDelegate<String, GameObject>();
            _appDomain.DelegateManager.RegisterMethodDelegate<String, Transform>();
            _appDomain.DelegateManager.RegisterMethodDelegate<String, Texture2D>();
            _appDomain.DelegateManager.RegisterMethodDelegate<int, GameObject>();
            _appDomain.DelegateManager.RegisterFunctionDelegate<Collider, Collider, Int32>();
            _appDomain.DelegateManager.RegisterFunctionDelegate<Transform, Transform, Int32>();
            _appDomain.DelegateManager.RegisterFunctionDelegate<GameObject, GameObject, Int32>();
            _appDomain.DelegateManager.RegisterMethodDelegate<System.Collections.Generic.List<System.Object>>();

            _appDomain.DelegateManager.RegisterMethodDelegate<AsyncOperation>();
            _appDomain.DelegateManager.RegisterMethodDelegate<System.Object>();
            _appDomain.DelegateManager.RegisterMethodDelegate<Pose>();

            _appDomain.DelegateManager
                .RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs>();
            _appDomain.DelegateManager.RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.ActivateEventArgs>();
            _appDomain.DelegateManager.RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.DeactivateEventArgs>();
            _appDomain.DelegateManager.RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.HoverEnterEventArgs>();
            _appDomain.DelegateManager.RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.HoverExitEventArgs>();
            _appDomain.DelegateManager.RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs>();

            _appDomain.DelegateManager
                .RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs>();
            _appDomain.DelegateManager
                .RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.BaseRegistrationEventArgs>();
            _appDomain.DelegateManager
                .RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.InteractableRegisteredEventArgs>();
            _appDomain.DelegateManager
                .RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.InteractorUnregisteredEventArgs>();
            _appDomain.DelegateManager
                .RegisterMethodDelegate<UnityEngine.XR.Interaction.Toolkit.InteractableUnregisteredEventArgs>();

            _appDomain.DelegateManager
                .RegisterFunctionDelegate<Vector3, Int32, System.Collections.Generic.KeyValuePair<Vector3, Int32>>();
            _appDomain.DelegateManager
                .RegisterFunctionDelegate<System.Collections.Generic.KeyValuePair<Vector3, System.Int32>, Vector3>();

            _appDomain.DelegateManager
                .RegisterFunctionDelegate<XRMODBehaviourAdapter.Adapter, XRMODBehaviourAdapter.Adapter, System.Int32>();
            _appDomain.DelegateManager.RegisterFunctionDelegate<ILTypeInstance, ILTypeInstance, System.Int32>();
            _appDomain.DelegateManager.RegisterFunctionDelegate<ILTypeInstance, bool>();
            _appDomain.DelegateManager.RegisterFunctionDelegate<XRMODBehaviourAdapter.Adapter, System.Int32>();
            _appDomain.DelegateManager.RegisterFunctionDelegate<XRMODBehaviourAdapter.Adapter, bool>();
            _appDomain.DelegateManager.RegisterFunctionDelegate<ILTypeInstance, System.Int32>();

            _appDomain.DelegateManager.RegisterMethodDelegate<ulong>();
            _appDomain.DelegateManager.RegisterMethodDelegate<Byte>();
            _appDomain.DelegateManager.RegisterMethodDelegate<double>();

            _appDomain.DelegateManager.RegisterMethodDelegate<Int32, int>();
            _appDomain.DelegateManager.RegisterFunctionDelegate<Transform, Boolean>();
            _appDomain.DelegateManager.RegisterMethodDelegate<InputDevice, InputDeviceChange>();
            _appDomain.DelegateManager.RegisterMethodDelegate<InputAction.CallbackContext>();
            _appDomain.DelegateManager.RegisterMethodDelegate<UnityEngine.InputSystem.InputDevice, InputDeviceChange>();
            
            _appDomain.DelegateManager.RegisterMethodDelegate<VideoPlayer, String>();
            _appDomain.DelegateManager.RegisterMethodDelegate<VideoPlayer, Int64>();
            _appDomain.DelegateManager.RegisterMethodDelegate<VideoPlayer, Double>();
            
            _appDomain.DelegateManager.RegisterMethodDelegate<ILTypeInstance>();
            _appDomain.DelegateManager.RegisterMethodDelegate<PlayerInput>();
            _appDomain.DelegateManager.RegisterMethodDelegate<VideoPlayer>();
            _appDomain.DelegateManager.RegisterMethodDelegate<PointerEventData>();
            
            _appDomain.DelegateManager.RegisterMethodDelegate<System.Collections.Generic.List<System.Int32>>();
            _appDomain.DelegateManager.RegisterMethodDelegate<System.Collections.Generic.List<System.String>>();
            _appDomain.DelegateManager.RegisterMethodDelegate<System.Collections.Generic.List<System.Single>>();
            _appDomain.DelegateManager.RegisterMethodDelegate<System.Collections.Generic.List<float>>();
            _appDomain.DelegateManager.RegisterMethodDelegate<System.Collections.Generic.List<double>>();
        }
    }
}
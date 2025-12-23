// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the UnityFusion.Runtime.CodeHook.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Unity.Profiling;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.CLRBinding.Adapter;
using UnityFusion.Runtime.Intepreter;
using UnityEngine;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook.ICommand
{
    /// <summary>
    /// Command to initialize and add an <see cref="XRMODBehaviourAdapter.Adapter"/> to a GameObject.
    /// Handles the setup of the ILRuntime instance, AppDomain, and constructor invocation.
    /// </summary>
    public class InitMonoBehaviourAdapter : BaseInitCommandAdapter<XRMODBehaviourAdapter.Adapter>
    {
        public InitMonoBehaviourAdapter(GameObject _gameObject, ILTypeInstance _instance, MonoData _monoData,
            IType _iLType) : base(_gameObject, _instance, _monoData, _iLType)
        {
        }
    
        public override XRMODBehaviourAdapter.Adapter Execute()
        {
            var tmp_Adapter = GameObject.AddComponent<XRMODBehaviourAdapter.Adapter>();
            tmp_Adapter.enabled = false;
            tmp_Adapter.ILInstance = Instance;
            tmp_Adapter.AppDomain = CodesHook.GetAppDomain;
            Instance.CLRInstance = tmp_Adapter;
            MonoData.ClrInstance = tmp_Adapter;
            MonoData.Added = true;
            Utility.InvokeConstructor(Instance, ILType);
            return tmp_Adapter;
        }
    }
}
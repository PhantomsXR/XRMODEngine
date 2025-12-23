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

using UnityFusion.CLR.TypeSystem;
using UnityFusion.CLRBinding.Adapter;
using UnityFusion.Runtime.Intepreter;
using UnityEngine;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook.ICommand
{
    /// <summary>
    /// Command to initialize and add a <see cref="UIBehaviourAdaptor.Adapter"/> to a GameObject.
    /// Specifically tailored for hot-reload UI components.
    /// </summary>
    public class InitUIMonoBehaviourAdaptor : BaseInitCommandAdapter<UIBehaviourAdaptor.Adapter>
    {
        public InitUIMonoBehaviourAdaptor(GameObject _gameObject, ILTypeInstance _instance, MonoData _monoData,
            IType _iLType) : base(_gameObject, _instance, _monoData, _iLType)
        {
        }

        public override UIBehaviourAdaptor.Adapter Execute()
        {
            var tmp_Adapter = GameObject.AddComponent<UIBehaviourAdaptor.Adapter>();
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
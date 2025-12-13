// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Runtime.CodeHook.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Linq;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.UnityFusion.Runtime.CodeHook.ICommand;
using UnityEngine;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.CLRBinding.Adapter;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    public class XRMODBehaviourCreation : IScriptCreation
    {
        public bool CanHandle(Type _baseType)
        { 
            
            return _baseType != null && (_baseType == typeof(XRMODBehaviourAdapter.Adapter)
                                         || _baseType.IsSubclassOf(typeof(XRMODBehaviour)));
        }

        public void Create(GameObject _target, ILTypeInstance _ilTypeInstance, MonoData _monoData, ILType _ilType)
        {
            new InitMonoBehaviourAdapter(_target, _ilTypeInstance, _monoData, _ilType).Execute();
        }
    }
}
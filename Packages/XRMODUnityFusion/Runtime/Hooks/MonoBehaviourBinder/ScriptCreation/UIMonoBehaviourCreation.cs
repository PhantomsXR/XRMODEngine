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
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.UnityFusion.Runtime.CodeHook.ICommand;
using UnityEngine;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.CLRBinding.Adapter;
using UnityFusion.Runtime.Intepreter;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    public class UIMonoBehaviourCreation : IScriptCreation
    {
        public bool CanHandle(Type _baseType)
        {
            return _baseType.IsSubclassOf(typeof(UIMonoBehaviour))
                   || _baseType.FullName == typeof(UIBehaviourAdaptor.Adapter).FullName;
        }

        public void Create(GameObject _target, ILTypeInstance _ilTypeInstance, MonoData _monoData, ILType _ilType)
        {
            new InitUIMonoBehaviourAdaptor(_target, _ilTypeInstance, _monoData, _ilType).Execute();
        }
    }
}
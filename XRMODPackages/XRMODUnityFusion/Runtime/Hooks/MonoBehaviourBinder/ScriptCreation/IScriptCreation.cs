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
using UnityEngine;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.Runtime.Intepreter;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    public interface IScriptCreation
    {
        bool CanHandle(Type _baseType);
        void Create(GameObject _target, ILTypeInstance _ilTypeInstance, MonoData _monoData, ILType _ilType);
    }
}
/*===============================================================================
Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.

This file is part of the XRMODEngineCore.Runtime.

The  XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using System;

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// Attribute that prevents a specific field or class from being automatically converted 
    /// or bound to a MonoBehaviour mono-binder within the framework's internal tools.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field)]
    public class DontConvertToMonoBinderAttribute : Attribute
    {
    }
}
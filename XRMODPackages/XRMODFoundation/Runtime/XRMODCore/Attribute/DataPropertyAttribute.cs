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
    /// Attribute used to mark a field or property as a data-driven property within the XRMOD framework.
    /// This is typically used for automatic serialization or UI binding.
    /// </summary>
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class DataPropertyAttribute : Attribute
    {
    }
}
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
using System.Collections.Generic;
using UnityFusion.Runtime.Enviorment;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{ 
    /// <summary>
    /// Represents the metadata and state of a runtime script to be bound to a GameObject.
    /// </summary>
    [System.Serializable]
    public class MonoData
    {
        /// <summary> The namespace of the class. </summary>
        public string ClassNamespace;
        /// <summary> The name of the class. </summary>
        public string ClassName;

        /// <summary> The list of fields and their values for this script instance. </summary>
        public List<MonoField> Fields = new();

        /// <summary> Indicates if the data has been bound to the instance. </summary>
        public bool BoundData = false;
        /// <summary> Indicates if the script has been added to the GameObject. </summary>
        public bool Added = false;
        /// <summary> Indicates if the script has been activated/enabled. </summary>
        public bool Activated = false;

        /// <summary> The cross-binding adaptor instance (ILRuntime/CLR bridge). </summary>
        public CrossBindingAdaptorType ClrInstance;
        /// <summary> The actual System.Type of the class. </summary>
        public Type ClassType;
    }

    /// <summary>
    /// Defines the visibility/rendering state of a GameObject.
    /// </summary>
    public enum RenderStateType
    {
        /// <summary> No change to render state. </summary>
        None,
        /// <summary> Set the GameObject to visible/active. </summary>
        Visiable,
        /// <summary> Set the GameObject to hidden/inactive. </summary>
        Hiden
    }
}
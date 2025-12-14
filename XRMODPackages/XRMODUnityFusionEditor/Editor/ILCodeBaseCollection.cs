// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the com.Phantoms.UnityFusion.Editor.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using UnityEngine;

public class ILCodeBaseCollection : ScriptableObject
{
    public int CurrentSelectAssemblyIdx = 0;
    public List<AllTypesInAssembly> TypesInAssembly = new List<AllTypesInAssembly>();
    //public List<Type> AllTypes = new List<Type>();
    public List<string> AllAssemblies = new List<string>();


    public class AllTypesInAssembly
    {
        public string TypeInAssembly;
        public bool Toggled;
    }
}
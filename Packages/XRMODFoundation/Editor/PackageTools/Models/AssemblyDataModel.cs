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

using System.Collections.Generic;

namespace  Phantom.XRMOD.XRMODPackageTools.Editor
{
    [System.Serializable]
    public class AssemblyDataModel
    {
        public string name;
        public string rootNamespace;
        public List<string> references;

        public List<string> includePlatforms;


        public List<string> excludePlatforms;


        public bool allowUnsafeCode;


        public bool overrideReferences;


        public List<string> precompiledReferences;


        public bool autoReferenced;


        public List<string> defineConstraints;

        public List<string> versionDefines;


        public bool noEngineReferences;
    }
}
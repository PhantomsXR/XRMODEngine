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
using Newtonsoft.Json;
using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    [System.Serializable]
    public class TemplateDataModel
    {
        public string TemplateDisplayName;
        public string TemplateName;
        public string TemplateDescription;
        public string TemplateIcon;
        public string TemplatePath;
        public string TemplateAuthor;
        public string TemplateLicense;
        public string TemplateType = "C Sharp";
        public string TemplateVersion = "1.0.0";
        [HideInInspector] public int ID;
    }
#if !DEV_PROJECT
    [CreateAssetMenu(menuName = "XR-MOD/Editor/PackageTools/TemplateData")]
#endif
    public class TemplatesScriptableObject : ScriptableObject
    {
        public List<TemplateDataModel> Templates;

        private void OnDisable()
        {
            EditorUtility.SetDirty(this);
        }
    }

    public class TemplateJsonMode
    {
        public List<TemplateDataModel> Templates;
    }
    
    public static class Extension
    {
        public static string ToJson(this TemplatesScriptableObject templatesScriptableObject)
        {
            return JsonConvert.SerializeObject(templatesScriptableObject);
        }
    }
}
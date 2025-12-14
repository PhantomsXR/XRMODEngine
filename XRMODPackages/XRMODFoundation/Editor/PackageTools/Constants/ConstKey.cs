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

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class ConstKey
    {
        public const string ACTION_NOTIFICATION = "Phantom.XRMOD.ActionNotification.Runtime";
        public const string PACKAGE_TOOLS = "Phantom.XRMOD.PackageTools.Runtime";
        public const string ARMOD_API = "Phantom.XRMOD.XRMODAPI.Runtime";
        public const string CONST_XRMODUTILITIES = "Phantom.XRMOD.XRMODUtilites.Runtime";
        public const string CONST_LOCALIZATION = "Phantom.XRMOD.Localization.Runtime";
        public const string CONST_XRMODCORE = "Phantom.XRMOD.Core.Runtime";
        public const string CONST_XRMODINPUT = "Phantom.XRMOD.XRMODInput.Runtime";
        public const string CONST_XRMOD_GAMESERVICES = "Phantom.XRMOD.GameServices.Runtime";
        public const string CONST_XRMOD_LITJSON = "Phantom.XRMOD.LitJson.Runtime";
        public const string CONST_LEAN_TWEEN = "LeanTween.Runtime";
        public const string CONST_UNITY_INPUTSYSTEM = "Unity.InputSystem";
        public const string CONST_UNITY_XRI = "Unity.XR.Interaction.Toolkit";
        public const string CONST_UNITY_HAND = "Unity.XR.Hands";
        public const string CONST_TEXT_MESH_PRO = "Unity.TextMeshPro";


        public const string PACKAGE_NAME = "com.phantomsxr.foundation";
        public const string TOOLS_DATA_CACHE_FOLDER = "Editor Default Resources/PackageToolsCache";
        public const string TOOLS_DATA_CACHE_ASSETS = "PROJECT_DATA_MODEL.asset";

        public const string CONST_CREATE_NEW_AR_EXPERIENCE = "CreateNewARExperience";

        public static string CONST_PACKAGE_PATH = $"Packages/{PACKAGE_NAME}";
        public static string CONST_UASSETS_PATH = $"{CONST_PACKAGE_PATH}/Editor/PackageTools/UI/Assets";

        //PackageToolsEditor.cs
        public const string CONST_PROPERTIES_TOGGLE = "properties";
        public const string CONST_CONTENTS_TOGGLE = "contents";
        public const string CONST_BUILD_TOGGLE = "build";
        public const string CONST_NO_EDITING_VIEW = "NoEditingView";
        public const string CONST_EDITING_VIEW = "EditingView";
        public const string CONST_PACKAGE_TOOLS_WINDOW_TITLE = "Package Tools";
        public const string CONST_ALL_PROJECT_CACHE_FILE = "AllProjectsCache.asset";
        public const string CONST_TOOLBAR_LABEL_ITEM_USS = "toolbar-label-item";
        public const string CONST_PACKAGE_TOOLS_EDITOR_UXML = "PackageToolsEditor.uxml";
        public const string CONST_PACKAGE_TOOLS_EDITOR_USS = "PackageToolsEditor.uss";
        public const string CONST_VIEW_TAG = "view";

        //BundlePacker.cs
        public const string CONST_ASSET_SUFFIX = "arexperience";
        public const string CONST_ASSET_INFO_SUFFIX = "json";
    }
}
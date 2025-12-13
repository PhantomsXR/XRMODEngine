// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XRMODEngineSettings.Editor.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.Setup.Editor
{
    public abstract class AbstractDrawer : ISettingsDrawer
    {
        public Texture CheckedTexture { get; set; }
        public Texture ErrorTexture { get; set; }
        

        public AbstractDrawer()
        {
            Initializer();
        }

        public virtual void Initializer()
        {
            CheckedTexture = AssetDatabase.LoadAssetAtPath<Texture2D>(Path.Combine(ConstKey.CONST_PACKAGE_PATH,
                "Editor/SetupEditor/Assets/Textures/checked.png"));
            ErrorTexture = AssetDatabase.LoadAssetAtPath<Texture2D>(Path.Combine(ConstKey.CONST_PACKAGE_PATH,
                "Editor/SetupEditor/Assets/Textures/error.png"));
        }

        public abstract VisualElement CreateVisualElement();
    }
}
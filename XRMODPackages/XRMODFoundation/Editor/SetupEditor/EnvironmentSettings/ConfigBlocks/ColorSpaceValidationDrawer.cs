// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XRMODEngineSettings.Editor.
// //
// // The ARMOD-DevelopmentKit cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.Setup.Editor
{
    public class ColorSpaceValidationDrawer : AbstractDrawer,IFixer
    {
        private const string _CONST_HELP = "Click 'Fix' Button to set Color Space to Gamma, please.";

        public override VisualElement CreateVisualElement()
        {
            return DrawUtility.CreateSettingStateUI("Color Space", _CONST_HELP, () => CheckColorSpaceType(),
                CheckedTexture,
                ErrorTexture,
                FixColorSpace);
        }

        private void FixColorSpace()
        {
            PlayerSettings.colorSpace = ColorSpace.Linear;
        }

        private bool CheckColorSpaceType()
        {
            return PlayerSettings.colorSpace == ColorSpace.Linear;
        }

        void IFixer.DoFix()
        {
            FixColorSpace();
        }
    }
}
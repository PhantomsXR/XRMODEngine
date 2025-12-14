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
    public class AndroidMiniSDKVersionDrawer : AbstractDrawer, IFixer
    {
        private const string _CONST_HELP = "Click 'Fix' Button to set Android Minimum API Level to 26, please.";

        public override VisualElement CreateVisualElement()
        {
            return DrawUtility.CreateSettingStateUI("Android Mini SDK", _CONST_HELP, () => CheckMinSdkVersion(),
                CheckedTexture,
                ErrorTexture,
                FixMinSdkVersion);
        }

        private bool CheckMinSdkVersion()
        {
            return PlayerSettings.Android.minSdkVersion >= AndroidSdkVersions.AndroidApiLevel29;
        }

        private void FixMinSdkVersion()
        {
            PlayerSettings.Android.minSdkVersion = AndroidSdkVersions.AndroidApiLevel29;
        }

        void IFixer.DoFix()
        {
#if UNITY_ANDROID
            FixMinSdkVersion();
#endif
        }
    }
}
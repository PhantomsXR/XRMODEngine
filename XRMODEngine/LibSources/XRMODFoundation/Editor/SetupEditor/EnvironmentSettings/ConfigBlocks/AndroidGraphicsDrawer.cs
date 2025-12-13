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
using UnityEngine.Rendering;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.Setup.Editor
{
    public class AndroidGraphicsDrawer : AbstractDrawer, IFixer
    {
        private const string _CONST_HELP = "Click 'Fix' Button to set Graphics API only OpenGLES3, please.";

        public override VisualElement CreateVisualElement()
        {
            return DrawUtility.CreateSettingStateUI("Android Graphics API", _CONST_HELP, () => CheckGraphicsType(),
                CheckedTexture, ErrorTexture, FixGraphicsAPI);
        }

        private void FixGraphicsAPI()
        {
            PlayerSettings.SetUseDefaultGraphicsAPIs(Utility.GetBuildTarget(), false);
            PlayerSettings.SetGraphicsAPIs(Utility.GetBuildTarget(), new GraphicsDeviceType[1]
            {
                GraphicsDeviceType.OpenGLES3
            });
        }

        private bool CheckGraphicsType()
        {
            var tmp_Graphics = PlayerSettings.GetGraphicsAPIs(Utility.GetBuildTarget());
            foreach (GraphicsDeviceType tmp_GraphicType in tmp_Graphics)
            {
                if (tmp_GraphicType == GraphicsDeviceType.Vulkan)
                    return false;
            }

            return true;
        }

        void IFixer.DoFix()
        {
#if UNITY_ANDROID && HANDHELD_ARMODULE_INSTALL
            FixGraphics();
#endif
        }
    }
}
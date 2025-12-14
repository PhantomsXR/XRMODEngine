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

using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.Setup.Editor
{
    public class ApiCompatibilityDrawer : AbstractDrawer, IFixer
    {
        private const string _CONST_HELP = "Click 'Fix' Button to set Api Compatibility Level to .NET 4.x, please.";

        public override VisualElement CreateVisualElement()
        {
            return DrawUtility.CreateSettingStateUI("Api Compatibility Level", _CONST_HELP, () => CheckApiCompatibility(),
                CheckedTexture,
                ErrorTexture,
                SwitchApiCompatibilityLevel);
        }

        private bool CheckApiCompatibility()
        {
            return PlayerSettings.GetApiCompatibilityLevel(GetBuildTargetGroup()) ==
                   ApiCompatibilityLevel.NET_Unity_4_8;
        }

        private void SwitchApiCompatibilityLevel()
        {
            PlayerSettings.SetApiCompatibilityLevel(GetBuildTargetGroup(), ApiCompatibilityLevel.NET_Unity_4_8);
        }

        private BuildTargetGroup GetBuildTargetGroup()
        {
            var tmp_Target = EditorUserBuildSettings.activeBuildTarget;
            return BuildPipeline.GetBuildTargetGroup(tmp_Target);
        }

        void IFixer.DoFix()
        {
            SwitchApiCompatibilityLevel();
        }
    }
}
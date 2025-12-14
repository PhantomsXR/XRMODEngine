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

using System.IO;
using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.Setup.Editor
{
    public static class Utility
    {
        public static BuildTargetGroup GetBuildTargetGroup()
        {
            var tmp_Target = EditorUserBuildSettings.activeBuildTarget;
            return BuildPipeline.GetBuildTargetGroup(tmp_Target);
        }

        public static BuildTarget GetBuildTarget() => EditorUserBuildSettings.activeBuildTarget;

        public static BuildTarget GetSimulationTarget()
        {
#if UNITY_EDITOR_OSX
            return BuildTarget.StandaloneOSX;
#else
            return BuildTarget.StandaloneWindows;
#endif
        }

        public static void CreateLinkXml(string _platform)
        {
            var tmp_LinkXml =
                AssetDatabase.LoadAssetAtPath<TextAsset>(
                    assetPath: "Packages/com.phantomsxr.foundation/Editor/SetupEditor/Assets/LinkXml/Link.xml");
            if (tmp_LinkXml)
            {
                var tmp_ModifyLinkXml = tmp_LinkXml.text.Replace("{{PLATFORM_MODULE}}", $"{_platform}Module");
                File.WriteAllText($"{Application.dataPath}/link.xml", tmp_ModifyLinkXml);
            }
        }
    }
}
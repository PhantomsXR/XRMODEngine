// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.OpenXRModule.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

#if UNITY_OPENXR

using UnityEngine;
using System.Runtime.InteropServices;
using UnityEditor;
using UnityEngine;
using UnityEngine.XR.OpenXR;
using UnityEngine.XR.OpenXR.Features;

namespace Phantom.XRMOD.OpenXRMOD.Runtime
{
#if UNITY_EDITOR
// OpenXR feature declaration.
    [UnityEditor.XR.OpenXR.Features.OpenXRFeature(UiName = "URP Application Spacewarp",
        Desc = @"URP Application Spacewarp feature",
        Company = "Unity",
        DocumentationLink = "",
        OpenxrExtensionStrings = "XR_FB_space_warp",
        Version = "1.0.0",
        BuildTargetGroups = new[] {BuildTargetGroup.Android},
        FeatureId = featureId)]
#endif
    public class SpacewarpFeature : OpenXRFeature
    {
        // The feature id string. This is used to give the feature a well known id for reference.
        public const string featureId = "com.unity.openxr.feature.Spacewarp";


        // Turn spacewarp on or off.
        public static bool SetSpacewarp(bool enabled)
        {
            return MetaSetSpaceWarp(enabled);
        }

        // Update spacewarp for camera movement.
        public static bool SetAppSpaceTransform(Vector3 position, Quaternion rotation)
        {
            return MetaSetAppSpacePosition(
                       position.x,
                       position.y,
                       position.z)
                   &&
                   MetaSetAppSpaceRotation(
                       rotation.x,
                       rotation.y,
                       rotation.z,
                       rotation.w);
        }

        // Import functions from the UnityOpenXR dll.
        [DllImport("UnityOpenXR", EntryPoint = "MetaSetSpaceWarp")]
        private static extern bool MetaSetSpaceWarp(bool enabled);

        [DllImport("UnityOpenXR", EntryPoint = "MetaSetAppSpacePosition")]
        private static extern bool MetaSetAppSpacePosition(float x, float y, float z);

        [DllImport("UnityOpenXR", EntryPoint = "MetaSetAppSpaceRotation")]
        private static extern bool MetaSetAppSpaceRotation(float x, float y, float z, float w);
    }
}
#endif
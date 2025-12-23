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
    /// <summary>
    /// OpenXR feature that implements Support for Meta's Application SpaceWarp.
    /// This feature requires the <c>XR_FB_space_warp</c> extension.
    /// </summary>
    public class SpacewarpFeature : OpenXRFeature
    {
        // The feature id string. This is used to give the feature a well known id for reference.
        public const string featureId = "com.unity.openxr.feature.Spacewarp";


        /// <summary>
        /// Enables or disables Application SpaceWarp at the OpenXR runtime level.
        /// </summary>
        /// <param name="enabled">True to enable, false to disable.</param>
        /// <returns>True if the operation was successful, false otherwise.</returns>
        public static bool SetSpacewarp(bool enabled)
        {
            return MetaSetSpaceWarp(enabled);
        }

        /// <summary>
        /// Updates the application space transform (position and rotation) for SpaceWarp calculations.
        /// This should be called every frame when SpaceWarp is active, typically using the camera's transform.
        /// </summary>
        /// <param name="position">The current world position of the application's reference space (e.g., Camera position).</param>
        /// <param name="rotation">The current world rotation of the application's reference space (e.g., Camera rotation).</param>
        /// <returns>True if the transform was successfully updated, false otherwise.</returns>
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
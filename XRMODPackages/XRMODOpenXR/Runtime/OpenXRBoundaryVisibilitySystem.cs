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


#if QUEST_INSTALL

using System;
using UnityEngine.Events;
#if UNITY_OPENXR && META_OPENXR
using UnityEngine.XR.OpenXR;
using UnityEngine.XR.OpenXR.Features.Meta;
#endif

namespace Phantom.XRMOD.OpenXRMOD.Runtime
{
    /// <summary>
    /// Provides functionality to manage and listen for platform boundary visibility changes,
    /// specifically tailored for Meta OpenXR runtimes.
    /// </summary>
    public static class OpenXRBoundaryVisibilitySystem
    {
        /// <summary>
        /// Event triggered when the platform boundary visibility state changes.
        /// <list type="bullet">
        /// <item><term>bool</term><description>True if the visibility was successfully changed; false if an error occurred.</description></item>
        /// <item><term>string</term><description>Error message or status information.</description></item>
        /// </list>
        /// </summary>
        public static UnityEvent<bool, string> OnBoundaryVisibilityChanged { get; private set; } = new();
#if UNITY_OPENXR && META_OPENXR && PLATFORM_ANDROID
        private static UnityEngine.XR.OpenXR.Features.Meta.XrBoundaryVisibility boundaryVisibility =
            UnityEngine.XR.OpenXR.Features.Meta.XrBoundaryVisibility.VisibilitySuppressed;
#endif
        /// <summary>
        /// Requests a change in the platform's boundary visibility state.
        /// </summary>
        /// <param name="_boundaryVisibility">The desired visibility state (Suppressed or Not Suppressed).</param>
        /// <example>
        /// <code>
        /// // To suppress the boundary visibility
        /// OpenXRBoundaryVisibilitySystem.ChangeBoundaryVisibility(XrBoundaryVisibility.VisibilitySuppressed);
        /// </code>
        /// </example>
        /// <remarks>
        /// This feature is primarily supported on Meta Quest devices via the Meta OpenXR Boundary Visibility extension.
        /// Suppression might not be allowed in all contexts (e.g., if safety protocols are active).
        /// </remarks>
        public static void ChangeBoundaryVisibility(XrBoundaryVisibility _boundaryVisibility)
        {
#if UNITY_OPENXR && META_OPENXR && PLATFORM_ANDROID
            boundaryVisibility =
                Enum.Parse<UnityEngine.XR.OpenXR.Features.Meta.XrBoundaryVisibility>(_boundaryVisibility.ToString());

            SetBoundaryVisibility();
#endif
        }

        private static void SetBoundaryVisibility()
        {
#if UNITY_OPENXR && META_OPENXR && PLATFORM_ANDROID
            var tmp_Feature = OpenXRSettings.Instance.GetFeature<BoundaryVisibilityFeature>();
            var tmp_Result = tmp_Feature.TryRequestBoundaryVisibility(boundaryVisibility);

            if ((int) tmp_Result ==
                BoundaryVisibilityFeature.XR_BOUNDARY_VISIBILITY_SUPPRESSION_NOT_ALLOWED_META)
            {
                OnBoundaryVisibilityChanged?.Invoke(false, "XR Boundary Visibility Not Allowed");
            }

            if (tmp_Result < 0)
            {
                OnBoundaryVisibilityChanged?.Invoke(false,
                    $"Error occured when requesting boundary visibility. Error Code: {tmp_Result}");
            }
#endif
        }
    }


    /// <summary>
    /// Defines the visibility states for the OpenXR boundary.
    /// </summary>
    public enum XrBoundaryVisibility
    {
        /// <summary>
        /// The boundary is visible and following default system behavior.
        /// </summary>
        VisibilityNotSuppressed = 1,

        /// <summary>
        /// The boundary visibility is suppressed (hidden).
        /// </summary>
        VisibilitySuppressed = 2,
    }
}

#endif
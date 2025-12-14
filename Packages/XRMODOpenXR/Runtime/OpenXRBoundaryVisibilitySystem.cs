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
    public static class OpenXRBoundaryVisibilitySystem
    {
        public static UnityEvent<bool, string> OnBoundaryVisibilityChanged { get; private set; } = new();
#if UNITY_OPENXR && META_OPENXR && PLATFORM_ANDROID
        private static UnityEngine.XR.OpenXR.Features.Meta.XrBoundaryVisibility boundaryVisibility =
            UnityEngine.XR.OpenXR.Features.Meta.XrBoundaryVisibility.VisibilitySuppressed;
#endif
        /// <summary>
        /// Change current platform boundary visibility state
        /// </summary>
        /// <param name="_boundaryVisibility">Represents the visibility of the Meta OpenXR runtime's boundary.
        /// <see cref="XrBoundaryVisibility"/></param>
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


    public enum XrBoundaryVisibility
    {
        /// <summary>
        /// Boundary visibility is not suppressed.
        /// </summary>
        VisibilityNotSuppressed = 1,

        /// <summary>
        /// Boundary visibility is suppressed.
        /// </summary>
        VisibilitySuppressed = 2,
    }
}

#endif
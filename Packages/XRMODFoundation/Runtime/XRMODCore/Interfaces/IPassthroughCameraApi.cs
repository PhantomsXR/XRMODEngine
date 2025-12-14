// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Core.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.Core.Runtime
{
    public interface IPassthroughCameraApi
    {
        /// <summary>
        /// Get the camera focal length
        /// </summary>
        /// <param name="_focalLength">Focal length</param>
        /// <returns></returns>
        bool GetCameraFocalLength(out float[] _focalLength);

        /// <summary>
        /// Get the camera principal point.
        /// </summary>
        /// <param name="_principalPoint">Principal point</param>
        /// <returns></returns>
        bool GetPrincipalPoint(out float[] _principalPoint);


        /// <summary>
        /// Get the camera frame image dimensions.
        /// </summary>
        /// <param name="_dimensions">Image dimensions</param>
        /// <returns></returns>
        bool GetImageDimensions(out int[] _dimensions);


        /// <summary>
        /// Get the camera distortion params.
        /// </summary>
        /// <param name="_distortionParams">Distortion params</param>
        /// <returns></returns>
        bool GetDistortion(out float[] _distortionParams);


        /// <summary>
        /// Get the history camera physics pose.
        /// </summary>
        /// <param name="_timestamp">The frame timestamp</param>
        /// <param name="_pose">The camera pose</param>
        /// <returns></returns>
        bool GetHistoryCameraPhysicsPose(long _timestamp, out Pose _pose);
    }
}
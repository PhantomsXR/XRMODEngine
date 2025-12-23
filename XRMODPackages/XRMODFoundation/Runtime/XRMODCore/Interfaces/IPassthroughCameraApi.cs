/*===============================================================================
Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Core.Runtime.

The  XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// Interface for accessing passthrough camera parameters and history poses.
    /// Essential for MR experiences that require precise alignment of virtual content with the real world.
    /// </summary>
    public interface IPassthroughCameraApi
    {
        /// <summary>
        /// Attempts to retrieve the camera's focal length.
        /// </summary>
        /// <param name="_focalLength">When this method returns, contains the focal length components.</param>
        /// <returns>True if the focal length was successfully retrieved; otherwise, false.</returns>
        bool GetCameraFocalLength(out float[] _focalLength);

        /// <summary>
        /// Attempts to retrieve the camera's principal point.
        /// </summary>
        /// <param name="_principalPoint">When this method returns, contains the principal point coordinates.</param>
        /// <returns>True if the principal point was successfully retrieved; otherwise, false.</returns>
        bool GetPrincipalPoint(out float[] _principalPoint);

        /// <summary>
        /// Attempts to retrieve the camera frame image dimensions.
        /// </summary>
        /// <param name="_dimensions">When this method returns, contains the width and height of the image.</param>
        /// <returns>True if the dimensions were successfully retrieved; otherwise, false.</returns>
        bool GetImageDimensions(out int[] _dimensions);

        /// <summary>
        /// Attempts to retrieve the camera's lens distortion parameters.
        /// </summary>
        /// <param name="_distortionParams">When this method returns, contains the distortion coefficients.</param>
        /// <returns>True if the distortion parameters were successfully retrieved; otherwise, false.</returns>
        bool GetDistortion(out float[] _distortionParams);

        /// <summary>
        /// Retrieves the historical physics pose of the camera at a specific timestamp.
        /// Useful for reprojecting past frames or handling latency.
        /// </summary>
        /// <param name="_timestamp">The frame timestamp to query.</param>
        /// <param name="_pose">When this method returns, contains the historical camera pose.</param>
        /// <returns>True if the pose was successfully retrieved; otherwise, false.</returns>
        bool GetHistoryCameraPhysicsPose(long _timestamp, out Pose _pose);
    }
}
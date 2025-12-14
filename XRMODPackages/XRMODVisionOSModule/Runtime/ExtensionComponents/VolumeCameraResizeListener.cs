// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.VisionOSModule.Runtime.
// //
// // The AVPPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.ActionNotification.Runtime;
using Unity.PolySpatial;
using UnityEngine;

namespace Phantom.XRMOD.VisionOSModule.Runtime
{
    public class VolumeCameraResizeListener : MonoBehaviour
    {
        public BoundResizeMode Mode;

        Vector3 originalVolumeCameraDimensions;

        void OnEnable()
        {
            var tmp_VolumeCamera = GetComponent<VolumeCamera>();

            // Save the original volume camera dimensions so we know what we're starting with.
            // Note: in case you want to change these dimensions dynamically, you'll need to
            // adapt this script to take that into account
            originalVolumeCameraDimensions = tmp_VolumeCamera.Dimensions;

            // The first time a window is opened for a volume camera, a WindowOpened event will be triggered.
            // If the volume window changes size after that, a WindowResized event will be triggered.
            // We want to handle both in the same way, so we can just add the same listener to both events.
            tmp_VolumeCamera.WindowStateChanged.AddListener(VolumeWindowResized);
        }

        void OnDisable()
        {
            var tmp_VolumeCamera = GetComponent<VolumeCamera>();
            tmp_VolumeCamera.WindowStateChanged.RemoveListener(VolumeWindowResized);
        }

        // We are being informed of the actual dimensions of the opened window (windowDimensions).
        // In this function, the only thing that we can manipulate is the volume camera dimensions/scale/position itself,
        // or to change to an entirely different output configuration. We cannot affect the output window dimensions
        // in any way.
        //
        // The windowDimensions are the dimensions of the output window, in the platform's units. The contentDimensions
        // are the dimensions that your Volume Camera's dimensions are mapped to, in Unity's coordinate units.
        // (On visionOS, these will typically be the same, but they may not be on other platforms.)

        void VolumeWindowResized(VolumeCamera _volumeCamera, VolumeCamera.WindowState _windowState)
        {
            if (_volumeCamera != GetComponent<VolumeCamera>())
                return;

            if (_windowState.Mode == VolumeCamera.PolySpatialVolumeCameraMode.Unbounded)
                return;

            var tmp_VolumeCamera = GetComponent<VolumeCamera>();

            // These are the desired output dimensions that we asked for. (volumeCamera.OutputDimensions will be the actual
            // dimensions, and will equal contentDimensions)
            var tmp_DesiredOutputDimensions = tmp_VolumeCamera.WindowConfiguration.Dimensions;

            // If they match, there's nothing to do; we got what we asked for.
            if (_windowState.ContentDimensions == tmp_DesiredOutputDimensions)
                return;

            // This is the original scale factor between the window dimensions and the volume camera dimensions, in order
            // to preserve whatever the original mapping is. Typically this will be a uniform scale.
            var tmp_OriginalScaleFactor = new Vector3(
                originalVolumeCameraDimensions.x / tmp_DesiredOutputDimensions.x,
                originalVolumeCameraDimensions.y / tmp_DesiredOutputDimensions.y,
                originalVolumeCameraDimensions.z / tmp_DesiredOutputDimensions.z);

            // First, compute dimensions such that content remains the same size and shape as it would have if we had received
            // our requested dimensions. If we received smaller dimensions, this would cause the content to be cropped. If bigger,
            // surrounding content will be visible.
            var tmp_NewDimensions = _windowState.ContentDimensions;
            var tmp_OriginalDimensions = _windowState.ContentDimensions;
            tmp_NewDimensions.Scale(tmp_OriginalScaleFactor);

            if (Mode == BoundResizeMode.ScaleToFit)
            {
                // If instead we want to scale the content to fit, further scale these
                // dimensions based on the smallest output dimension. (This may not be
                // correct depending on your content, but it's a reasonable default.)
                var tmp_SmallestSize = tmp_OriginalDimensions.x;
                float tmp_Scale = tmp_DesiredOutputDimensions.x / tmp_OriginalDimensions.x;

                if (tmp_OriginalDimensions.y < tmp_SmallestSize)
                {
                    tmp_SmallestSize = tmp_OriginalDimensions.y;
                    tmp_Scale = tmp_DesiredOutputDimensions.y / tmp_OriginalDimensions.y;
                }

                if (tmp_OriginalDimensions.z < tmp_SmallestSize)
                {
                    tmp_Scale = tmp_DesiredOutputDimensions.z / tmp_OriginalDimensions.z;
                }

                tmp_NewDimensions *= tmp_Scale;
            }

            tmp_VolumeCamera.Dimensions = tmp_NewDimensions;

            Debug.Log(
                $"Volume camera dimensions set to {tmp_NewDimensions} (got window of size {tmp_OriginalDimensions}, expected {tmp_DesiredOutputDimensions})");
        }
    }
}
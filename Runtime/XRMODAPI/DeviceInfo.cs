/*===============================================================================
Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.

This file is part of the XR-MOD SDK.

The XR-MOD SDK cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using System;
using UnityEngine;

namespace Phantom.XRMOD.XRMODAPI.Runtime
{
    /// <summary>
    /// Represents detailed information about the hardware and software environment of the current device.
    /// This class is designed to be serialized to JSON and provided through the <see cref="API.GetDeviceInfo"/> method.
    /// </summary>
    [Serializable]
    public class DeviceInfo
    {
        /// <summary>
        /// (Read-only) The model or mode of the device.
        /// </summary>
        public string deviceModel;

        /// <summary>
        /// (Read-only) The user-defined name of the device.
        /// </summary>
        public string deviceName;

        /// <summary>
        /// (Read-only) The unique identifier for the device. Every device has a unique identifier.
        /// </summary>
        public string deviceUniqueIdentifier;

        /// <summary>
        /// (Read-only) The unique identifier ID of the graphics card.
        /// </summary>
        public int graphicsDeviceID;

        /// <summary>
        /// (Read-only) The name of the graphics card.
        /// </summary>
        public string graphicsDeviceName;

        /// <summary>
        /// (Read-only) The type of the graphics card.
        /// </summary>
        public string graphicsDeviceType;

        /// <summary>
        /// (Read-only) The vendor of the graphics card.
        /// </summary>
        public string graphicsDeviceVendor;

        /// <summary>
        /// (Read-only) The unique identification code ID of the graphics card vendor.
        /// </summary>
        public int graphicsDeviceVendorID;

        /// <summary>
        /// (Read-only) The type and version of the graphics card.
        /// </summary>
        public string graphicsDeviceVersion;

        /// <summary>
        /// (Read-only) The size of the graphics memory (VRAM) in megabytes.
        /// </summary>
        public int graphicsMemorySize;

        /// <summary>
        /// (Read-only) Indicates whether multi-threaded rendering is supported.
        /// </summary>
        public bool graphicsMultiThreaded;

        /// <summary>
        /// (Read-only) The shader capability level of the graphics card.
        /// </summary>
        public int graphicsShaderLevel;

        /// <summary>
        /// (Read-only) The maximum texture size supported by the graphics hardware.
        /// </summary>
        public int maxTextureSize;

        /// <summary>
        /// (Read-only) The level of support for Non-Power of Two (NPOT) textures.
        /// </summary>
        public string npotSupport;

        /// <summary>
        /// (Read-only) The name and version of the operating system.
        /// </summary>
        public string operatingSystem;

        /// <summary>
        /// (Read-only) The number of logical processor cores.
        /// </summary>
        public int processorCount;

        /// <summary>
        /// (Read-only) The operating frequency of the primary processor in MHz.
        /// </summary>
        public int processorFrequency;

        /// <summary>
        /// (Read-only) The name/type of the processor.
        /// </summary>
        public string processorType;

        /// <summary>
        /// (Read-only) The number of simultaneous render targets supported.
        /// </summary>
        public int supportedRenderTargetCount;

        /// <summary>
        /// (Read-only) Indicates whether 2D array textures are supported.
        /// </summary>
        public bool supports2DArrayTextures;

        /// <summary>
        /// (Read-only) Indicates whether 3D (volumetric) textures are supported.
        /// </summary>
        public bool supports3DTextures;

        /// <summary>
        /// (Read-only) Indicates whether an accelerometer is available on the device.
        /// </summary>
        public bool supportsAccelerometer;

        /// <summary>
        /// (Read-only) Indicates whether audio playback device is available.
        /// </summary>
        public bool supportsAudio;

        /// <summary>
        /// (Read-only) Indicates whether compute shaders are supported.
        /// </summary>
        public bool supportsComputeShaders;

        /// <summary>
        /// (Read-only) Indicates whether a gyroscope is available on the device.
        /// </summary>
        public bool supportsGyroscope;

        /// <summary>
        /// (Read-only) Indicates whether image effects are supported.
        /// </summary>
        public bool supportsImageEffects;

        /// <summary>
        /// (Read-only) Indicates whether location services (GPS) are available.
        /// </summary>
        public bool supportsLocationService;

        /// <summary>
        /// (Read-only) Indicates whether motion vectors are supported for temporal effects.
        /// </summary>
        public bool supportsMotionVectors;

        /// <summary>
        /// (Read-only) Indicates whether haptic vibration feedback is supported.
        /// </summary>
        public bool supportsVibration;

        /// <summary>
        /// (Read-only) The total amount of system memory (RAM) in megabytes.
        /// </summary>
        public int systemMemorySize;

        /// <summary>
        /// Property value indicating an unsupported identifier when requested via <see cref="SystemInfo"/>.
        /// </summary>
        public string unsupportedIdentifier;
    }
}
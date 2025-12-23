/*===============================================================================
Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.

This file is part of the XR-MOD SDK.

The XR-MOD SDK cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using UnityEngine;
using Phantom.XRMOD.Core.Runtime.Enums;

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// ScriptableObject that stores global SDK information, versioning, and environment settings.
    /// This is typically used to identify the SDK's capabilities and target device at runtime.
    /// </summary>
    [CreateAssetMenu(fileName = "SDKInformation", menuName = "XR-MOD/SDK/SDKInformation", order = 0)]
    public class SDKInformation : ScriptableObject
    {
        /// <summary>
        /// The current version of the XRMOD SDK.
        /// </summary>
        public string Version;

        /// <summary>
        /// The target device type this SDK build is configured for.
        /// </summary>
        public SDKDeviceType currentSDKDeviceType;

        /// <summary>
        /// The prefab used as the primary device launcher for XR experiences.
        /// </summary>
        public GameObject DeviceLauncher;

        /// <summary>
        /// The current deployment environment (Development, Staging, or Production).
        /// </summary>
        public EnvironmentType environmentType = EnvironmentType.Development;
    }

    /// <summary>
    /// Denotes the environment context in which the SDK is currently running.
    /// </summary>
    public enum EnvironmentType
    {
        /// <summary>
        /// Local development environment with full logging and debugging enabled.
        /// </summary>
        Development,

        /// <summary>
        /// Shared staging environment for integration testing and user acceptance.
        /// </summary>
        Staging,

        /// <summary>
        /// Final production environment with optimizations and minimal logging.
        /// </summary>
        Production
    }
}
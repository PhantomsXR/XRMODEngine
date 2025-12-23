// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XR-MOD SDK.
// //
// // The XR-MOD SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Phantom.XRMOD.XRMODPackageTools.Runtime;
using UnityEngine;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.SDKEntry.Runtime.DataRequest;
using Phantom.XRMOD.SDKEntry.Runtime.Mapper;

namespace Phantom.XRMOD.SDKEntry.Runtime.Models
{
    public class SDKEntryPointModel : IReleaseCommand
    {
        private static SDKInformation _SDK_INFORMATION;

        public SDKInformation SDKInformation => _SDK_INFORMATION;

        public SDKEntryPointModel()
        {
            _SDK_INFORMATION = Resources.Load<SDKInformation>("SDKInformation");
            if (!_SDK_INFORMATION)
            {
                throw new NullReferenceException(
                    "SDKInformation is empty. You need to create a new one and then put it to Resources folder.");
            }

            SdkVersion = new BindableProperty<string>();
            SdkInitialed = new() {Value = false};
            SdkType = new BindableProperty<string>() {Value = _SDK_INFORMATION.currentSDKDeviceType.ToString()};
            MaximumOfRetries = new() {Value = 5};
            SDKAvailability = new() {Value = false};
            ProjectResourceInfo = new();
            BreakDownloadWhenGreaterPresetSize = new();
            VersionMatched = new();
        }


        /// <summary>
        /// Global property for tracking and reacting to changes in the SDK version.
        /// </summary>
        public BindableProperty<string> SdkVersion;
        /// <summary>
        /// Global property for tracking the current SDK device type (e.g., Handheld, Headset).
        /// </summary>
        public BindableProperty<string> SdkType;
        /// <summary>
        /// Indicates whether the SDK has finished its basic initialization sequence.
        /// </summary>
        public BindableProperty<bool> SdkInitialed;
        /// <summary>
        /// The maximum number of retries allowed for network or loading operations.
        /// </summary>
        public BindableProperty<int> MaximumOfRetries;
        /// <summary>
        /// Indicates if the SDK is fully available and ready to launch experiences.
        /// </summary>
        public BindableProperty<bool> SDKAvailability;

        /// <summary>
        /// Maps experience resource IDs to their respective project configurations and URLs.
        /// </summary>
        public BindableProperty<ExperienceResourceMapper> ProjectResourceInfo;

        /// <summary>
        /// If true, the asset download will be interrupted if the total size exceeds a preset limit.
        /// </summary>
        public BindableProperty<bool> BreakDownloadWhenGreaterPresetSize;
        /// <summary>
        /// Indicates if the project configuration's required SDK version matches the current SDK.
        /// </summary>
        public BindableProperty<bool> VersionMatched;

        /// <summary> The type of network request system currently active (e.g., Supabase, Legacy). </summary>
        public NetworkRequestType NetworkRequestType;
        /// <summary> Maps backend response data to internal SDK models. </summary>
        public ResponseMapper ResponseMapper;
        /// <summary> Detailed data for the currently active XR experience. </summary>
        public XRExperienceData XRExperienceData;

        public void Release(string _projectName = null)
        {
            SdkVersion.OnValueChanged = null;
            SdkInitialed.OnValueChanged = null;
            MaximumOfRetries.OnValueChanged = null;
            SDKAvailability.OnValueChanged = null;
            ProjectResourceInfo.OnValueChanged = null;
            BreakDownloadWhenGreaterPresetSize.OnValueChanged = null;
            VersionMatched.OnValueChanged = null;
        }
    }
}
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


        public BindableProperty<string> SdkVersion;
        public BindableProperty<string> SdkType;
        public BindableProperty<bool> SdkInitialed;
        public BindableProperty<int> MaximumOfRetries;
        public BindableProperty<bool> SDKAvailability;

        public BindableProperty<ExperienceResourceMapper> ProjectResourceInfo;

        //Conditions for executing the method of continuing to download assets
        public BindableProperty<bool> BreakDownloadWhenGreaterPresetSize;
        public BindableProperty<bool> VersionMatched;

        public NetworkRequestType NetworkRequestType;
        public ResponseMapper ResponseMapper;
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
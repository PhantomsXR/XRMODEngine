// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PackageTools.Editor.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class RefreshCommand : BaseGenericMenuItemCommand
    {
        public RefreshCommand(GenericMenuItemCommandData _commandData) : base(_commandData)
        {
        }

        public override void Execute()
        {
            MakeSureBuildPlatform();
            EditorNotificationCenter.Center.PostNotification(nameof(RefreshCommand), null);
        }


        private void MakeSureBuildPlatform()
        {
            var tmp_EditingProjectData = allProjectsCache.GetEditingProjectData();
            if (!tmp_EditingProjectData) return;
            var tmp_ProjectDetail = tmp_EditingProjectData.DetailCacheData;
            var tmp_BuildSettingData = tmp_ProjectDetail.BuildSettingData;
            switch (tmp_ProjectDetail.Configures.SDKDeviceType)
            {
                case SDKDeviceType.VisionOS:
                    tmp_BuildSettingData.BuildTarget = BuildTarget.VisionOS;
                    tmp_BuildSettingData.BuildTargetGroup = BuildTargetGroup.VisionOS;
                    break;
                case SDKDeviceType.HandheldAR:
#if UNITY_IOS
                    tmp_BuildSettingData.BuildTarget = BuildTarget.iOS;
                    tmp_BuildSettingData.BuildTargetGroup = BuildTargetGroup.iOS;
#else
                    tmp_BuildSettingData.BuildTarget = BuildTarget.Android;
                    tmp_BuildSettingData.BuildTargetGroup = BuildTargetGroup.Android;
#endif
                    break;
                case SDKDeviceType.Hololens:
                    tmp_BuildSettingData.BuildTarget = BuildTarget.WSAPlayer;
                    tmp_BuildSettingData.BuildTargetGroup = BuildTargetGroup.WSA;
                    break;
                case SDKDeviceType.Pico:
                case SDKDeviceType.Quest:
                case SDKDeviceType.Rokid:
                case SDKDeviceType.XReal:
                    tmp_BuildSettingData.BuildTarget = BuildTarget.Android;
                    tmp_BuildSettingData.BuildTargetGroup = BuildTargetGroup.Android;
                    break;
                case SDKDeviceType.WebAR:
                case SDKDeviceType.WebVR:
                case SDKDeviceType.Web3D:
                    tmp_BuildSettingData.BuildTarget = BuildTarget.WebGL;
                    tmp_BuildSettingData.BuildTargetGroup = BuildTargetGroup.WebGL;
                    break;
                case SDKDeviceType.Classic3D:
#if UNITY_IOS
                    tmp_BuildSettingData.BuildTarget = BuildTarget.iOS;
                    tmp_BuildSettingData.BuildTargetGroup = BuildTargetGroup.iOS;
#elif UNITY_ANDROID
                    tmp_BuildSettingData.BuildTarget = BuildTarget.Android;
                    tmp_BuildSettingData.BuildTargetGroup = BuildTargetGroup.Android;
#elif UNITY_STANDALONE_OSX && CLASSIC3D_OSX
                    tmp_BuildSettingData.BuildTarget = BuildTarget.StandaloneOSX;
                    tmp_BuildSettingData.BuildTargetGroup = BuildTargetGroup.Standalone;
#elif UNITY_STANDALONE_WIN && CLASSIC3D_WIN
                    tmp_BuildSettingData.BuildTarget = BuildTarget.StandaloneWindows64;
                    tmp_BuildSettingData.BuildTargetGroup = BuildTargetGroup.Standalone;
#elif UNITY_STANDALONE_LINUX && CLASSIC3D_LINUX
                    tmp_BuildSettingData.BuildTarget = BuildTarget.StandaloneLinux64;
                    tmp_BuildSettingData.BuildTargetGroup = BuildTargetGroup.Standalone;
#elif UNITY_SERVER && DEDICATED_SERVER_OSX
                    tmp_BuildSettingData.BuildTarget = BuildTarget.StandaloneOSX;
                    tmp_BuildSettingData.BuildTargetGroup = BuildTargetGroup.Standalone;
#elif UNITY_SERVER && DEDICATED_SERVER_WIN
                    tmp_BuildSettingData.BuildTarget = BuildTarget.StandaloneWindows64;
                    tmp_BuildSettingData.BuildTargetGroup = BuildTargetGroup.Standalone;
#elif UNITY_SERVER && DEDICATED_SERVER_LINUX
                    tmp_BuildSettingData.BuildTarget = BuildTarget.StandaloneLinux64;
                    tmp_BuildSettingData.BuildTargetGroup = BuildTargetGroup.Standalone;
#endif
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
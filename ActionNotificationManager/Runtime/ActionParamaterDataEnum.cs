// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the AR-MOD SDK.
// 
// The AR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact info@phantomsxr.com for licensing requests.
// ===============================================================================*/


using System;

namespace Phantom.XRMOD.ActionNotification.Runtime
{
    public enum ActionParameterDataType
    {
        OnFocusStateChange,
        ImageStateChange,
        ReleaseMemory,
        OnUpdate,
        OnLoad,
        OnEvent,
        InitMonoScripts,
        CreateAnchor,
        SetFocusAlgorithmState,
        OpenBuiltInBrowser,
        Exit,
        TryAcquireAppInfo,
        TryAcquireCurrentFrame,
        TryAcquireAROcclusionFrame,
        TryAcquireSDKVersion,
        TryAcquireProjectInfo,
        TryAcquireLightEstimateValue,
        TryAcquireNetworkMesh,
        CheckARAvailability,
        CheckARFeaturesAvailability,
        ARAlgorithmLifeCTRL,
        TryAcquireLoadObject,
        ResizeARWorldScale,
        ImmersalLocalizer,
        Instantiate,

        [Obsolete("Deprecated", true)] OnMultiplayerEvent,
        MakeContentAppearAt,
        AlignWorldOriginByImageTrack,

        /// <summary>
        /// Cast a ray from a point in screen space against trackables,
        /// that is, detected features such as planes.
        /// </summary>
        ARRaycast,

        [Obsolete("Deprecated", true)] StartVideoRecording,
        [Obsolete("Deprecated", true)] StopVideoRecording,
        [Obsolete("Deprecated", true)] TakePhoto,

        /// <summary>
        /// Query temporary cache path
        /// </summary>
        TryAcquireTemporaryCachePath,

        /// <summary>
        /// Query currently sdk type
        /// </summary>
        TryAcquireSdkType,

        /// <summary>
        /// Query the custom launch data
        /// </summary>
        TryAcquireCustomConfig,

        /// <summary>
        /// On XR project fetched [Not for external use]
        /// </summary>
        OnXRDataGot,

        /// <summary>
        /// Query the project detail from the XRMOD cloud [Not for external use]
        /// </summary>
        FetchProjectDetail,

        /// <summary>
        /// Download network mesh
        /// </summary>
        DownloadMesh,

        /// <summary>
        /// Call this method when the immersal map was
        /// load into the memory and starting localizing
        /// </summary>
        OnImmersalMapRegister,
        SendMessageToSDK,

        /// <summary>
        /// Send the notification message to
        /// trigger the  `load the AR word map` method
        /// </summary>
        LoadEnvironmentMap,

        /// <summary>
        /// Send the notification message to
        /// trigger the `save the AR word map` method
        /// </summary>
        SaveEnvironmentMap,

        /// <summary>
        /// Send the notification message to
        /// trigger the `Delete the AR word map` method
        /// </summary>
        DeleteEnvironmentMap,

        /// <summary>
        /// Release current project
        /// </summary>
        ReleaseProject,

        /// <summary>
        /// Register extra ilcode
        /// </summary>
        RegisterExtraCLR,

        /// <summary>
        /// Register new tracking image
        /// </summary>
        AddNewImageForTracking,

        /// <summary>
        ///  All processes
        /// </summary>
        GetAllProcesses,

        /// <summary>
        ///  Add new process
        /// </summary>
        AddNewProcess,

        /// <summary>
        /// Register extra ilcode adaptor
        /// </summary>
        RegisterExtraAdaptor,

        /// <summary>
        /// Register builtin ilcode adaptor[Not for external use]
        /// </summary>
        RegisterBuiltInAdaptor,

        /// <summary>
        /// Register builtin ilcode delegate[Not for external use]
        /// </summary>
        RegisterBuiltInDelegate,

        /// <summary>
        /// Register builtin ilcode[Not for external use]
        /// </summary>
        RegisterBuiltInCLR,

        /// <summary>
        /// Switch between different modes: shared and full mode
        /// </summary>
        SwitchSpaceType,

        /// <summary>
        /// Get currently space mode
        /// </summary>
        GetSpaceType,
        LoadRuntimeScene,
        ForceLightingBakeApply,
        RemoveFeatures,

        /// <summary>
        /// Remove the specified Anchor 
        /// </summary>
        DestroyAnchor,

        /// <summary>
        /// Start process the monobinder
        /// </summary>
        ProcessMonoBinder
    }
}
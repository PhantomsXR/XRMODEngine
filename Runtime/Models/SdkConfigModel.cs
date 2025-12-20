// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantoms.Models.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;
using Phantom.XRMOD.Core.Runtime;

namespace Phantom.XRMOD.Models.Runtime
{
    [System.Serializable]
    public class ImageCloudRecognizerConfig
    {
        /// <summary>
        /// cloud recognizer gateway
        /// </summary>
        public string gateway;

        /// <summary>
        /// scan retry counts
        /// </summary>
        public int maximumOfRetries;

        /// <summary>
        /// scan frequency (seconds)
        /// </summary>
        public float frequencyOfScan;
    }


    [System.Serializable]
    public class DashboardConfig
    {
        /// <summary>
        /// The backend type
        /// </summary>
        public BackendType backendType = BackendType.Supabase;

        /// <summary>
        /// CMS gateway
        /// </summary>
        public string dashboardGateway;

        /// <summary>
        /// Exception collector
        /// </summary>
        public string exceptionCollectorUrl;

        /// <summary>
        /// SDK License
        /// </summary>
        [Multiline] public string token;

        public string appKey;
       
        /// <summary>
        /// Max time of networking require
        /// </summary>
        public int timeout = 30;

        /// <summary>
        /// Maximum download size for file
        /// </summary>
        public float maximumDownloadSize = 30;
    }


    [System.Serializable]
    public class CustomConfig
    {
        public string config;
    }


    [System.Serializable]
    public class SDKConfiguration
    {
        public EngineType engineType = EngineType.Unity;
        public DashboardConfig dashboardConfig;
        public ImageCloudRecognizerConfig imageCloudRecognizerConfig;
        public CustomConfig customConfig;
        public AppModel AppModel = AppModel.Online;
    }


    [System.Serializable]
    public enum EngineType
    {
        /// <summary>
        /// Based on Unity secondary development
        /// </summary>
        Unity,

        /// <summary>
        /// Embedded based on Native apps
        /// </summary>
        Native
    }

    [System.Serializable]
    public enum BackendType
    {
        Legacy,
        Supabase
    }


    public enum AppModel
    {
        Online,
        Offline,
        Simulator
    }

    public class SdkConfigModel : IModel
    {
        public BindableProperty<SDKConfiguration> SDKConfiguration { get; private set; }

        public SdkConfigModel()
        {
            Initialize();
        }

        public void Initialize()
        {
            SDKConfiguration = new BindableProperty<SDKConfiguration>();
        }
    }
}
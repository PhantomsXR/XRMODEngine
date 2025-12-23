// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.RokidModule.Runtime.
// //
// // The RokidPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/
#if ENABLE_IMMERSAL
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Immersal;
using Immersal.AR;
using Immersal.REST;
using Immersal.XR.Rokid;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Models.Runtime;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Events;
using LocalizerPose = Phantom.XRMOD.ActionNotification.Runtime.LocalizerPose;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.RokidModule.Runtime
{
    /// <summary>
    /// Implementation of <see cref="IFeatureDecorator"/> for integrating Immersal AR capabilities on Rokid devices.
    /// Manages Immersal SDK lifecycle, localization, map loading, and event handling.
    /// </summary>
    public class ImmersalFeature : IFeatureDecorator
    {
        private GameObject immersalGameObject;
        private ImmersalLocationProviderExtension locationProvider;

        private ImmersalSDK immersalSDK;
        private LocalizerBase arLocalizer;

        private Dictionary<int, ARMap> arMaps = new();
        private IDictionary<int, SDKJob> maps;
        private List<Task> jobs;
        private bool wasPaused;

        //private int jobLock = 0;

        private LocalizerPose localizerPose;
        private OnEventImmersalEventArgs immersalNotificationData;
        private RokidContextDataModel arContextData;

        public ImmersalFeature()
        {
            Initialize(); 
        }

        /// <summary>
        /// Checks if the Immersal feature is supported.
        /// </summary>
        /// <returns>Always true for this implementation.</returns>
        public bool SupportThisFeature()
        {
            return true;
        }

        /// <summary>
        /// Starts the Immersal localization algorithm.
        /// Enables the SDK and localizer, and initiates map loading or auto-start based on configuration.
        /// </summary>
        public void StartAlgorithm()
        {
            immersalSDK.enabled = true;
            arLocalizer.enabled = true;
            if (wasPaused && arContextData.ImmersalParameters.AutoStart)
            {
                arLocalizer.autoStart = arContextData.ImmersalParameters.AutoStart;
                wasPaused = false;
                return;
            }

            if (arContextData.ImmersalParameters.UseServerLocalizer)
            {
                GetMaps();
                return;
            }


            if (arContextData.ImmersalParameters.AutoStart)
                arLocalizer.StartLocalizing();
        }

        private void Initialize()
        {
            arContextData = IocContainer.GetIoc.Resolve<RokidContextDataModel>();

            //arMaps = new List<ARMap>();
            maps = new Dictionary<int, SDKJob>();
            jobs = new List<Task>();

            immersalGameObject = Object.Instantiate(Resources.Load<GameObject>("Prefabs/Rokid-ImmersalSDK"));

            Assert.IsNotNull(immersalGameObject);
            immersalSDK = immersalGameObject.GetComponent<ImmersalSDK>();
            immersalSDK.enabled = false;

            if (!immersalGameObject.TryGetComponent(out arLocalizer))
            {
                arLocalizer = immersalGameObject.AddComponent<RokidLocalizer>();
            }

            arLocalizer.enabled = false;

            if (arContextData.ImmersalParameters.UseServerLocalizer)
            {
                locationProvider = immersalGameObject.AddComponent<ImmersalLocationProviderExtension>();
                locationProvider.StartGeolocationTracking = GetMaps;
            }

            immersalSDK.onPoseFound = new UnityEvent();
            immersalSDK.onPoseFound.AddListener(OnPoseFound);
            immersalSDK.onPoseLost = new UnityEvent();
            immersalSDK.onPoseLost.AddListener(OnPoseLose);


            arLocalizer.OnPoseFound += OnLocalizerPoseFound;
            arLocalizer.OnMapChanged += OnMapChanged;
            arLocalizer.OnReset += OnReset;


            immersalSDK.developerToken = arContextData.ImmersalParameters.DeveloperToken;
            arLocalizer.autoStart = arContextData.ImmersalParameters.AutoStart;
            arLocalizer.burstMode = arContextData.ImmersalParameters.BurstMode;
            arLocalizer.localizationInterval = arContextData.ImmersalParameters.LocalizationInterval;
            arLocalizer.useServerLocalizer = arContextData.ImmersalParameters.UseServerLocalizer;
            arLocalizer.useFiltering = arContextData.ImmersalParameters.UseFiltering;
            arLocalizer.resetOnMapChange = arContextData.ImmersalParameters.ResetOnMapChange;

            ActionNotificationCenter.DefaultCenter.AddObserver(OnImmersalMapRegister,
                nameof(ActionParameterDataType.OnImmersalMapRegister));

            ActionNotificationCenter.DefaultCenter.AddObserver(Localize,
                nameof(ActionParameterDataType.ImmersalLocalizer));


            localizerPose = new LocalizerPose();
            immersalNotificationData = new OnEventImmersalEventArgs();
        }

        private void OnImmersalMapRegister(BaseNotificationData _obj)
        {
            foreach (ARMap tmp_ARMap in Object.FindObjectsOfType<ARMap>())
            {
                if (!arMaps.TryAdd(tmp_ARMap.mapId, tmp_ARMap)) continue;
                tmp_ARMap.OnFirstLocalization ??= new MapLocalizedEvent();
                tmp_ARMap.OnFirstLocalization.AddListener(OnFirstLocalization);
            }
        }

        /// <summary>
        /// Pauses the Immersal algorithm.
        /// Disables the localizer, SDK, and all active AR maps.
        /// </summary>
        public void PauseAlgorithm()
        {
            arLocalizer.enabled = false;
            immersalSDK.enabled = false;

            foreach (var tmp_Map in arMaps)
            {
                tmp_Map.Value.enabled = false;
            }
        }

        /// <summary>
        /// Stops the Immersal algorithm and cleans up all resources.
        /// Destroys the SDK instance, frees maps, and unregisters event listeners.
        /// </summary>
        public void StopAlgorithm()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType
                .OnImmersalMapRegister));

            if (arContextData.ImmersalParameters.UseServerLocalizer)
            {
                StopOnServerLocalizer();
                maps.Clear();
            }

            if (arLocalizer)
            {
                arLocalizer.OnPoseFound -= OnLocalizerPoseFound;
                arLocalizer.OnMapChanged -= OnMapChanged;
                arLocalizer.OnReset -= OnReset;

                arLocalizer.StopLocalizing();
                arLocalizer.StopAllCoroutines();

                arLocalizer.enabled = false;
            }

            if (immersalSDK)
            {
                immersalSDK.onPoseFound.RemoveAllListeners();
                immersalSDK.onPoseLost.RemoveAllListeners();
                immersalSDK.onPoseLost = null;
                immersalSDK.onPoseFound = null;
                immersalSDK.enabled = false;
                immersalSDK.developerToken = null;
                immersalGameObject.DestroyWithPlatform();
            }

            foreach (var tmp_Map in arMaps)
            {
                if (tmp_Map.Value == null) continue;
                tmp_Map.Value.OnFirstLocalization.RemoveAllListeners();
                tmp_Map.Value.OnFirstLocalization = null;
                tmp_Map.Value.FreeMap(true);
            }

            immersalNotificationData = null;

            ARMap.mapHandleToMap.Clear();
            ARSpace.spaceToTransform.Clear();
            ARSpace.transformToSpace.Clear();
            ARSpace.mapIdToMap.Clear();
            ARSpace.mapIdToOffset.Clear();

            arMaps.Clear();
            jobs.Clear();
            if (!arContextData.ImmersalParameters.AutoStart)
                ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType
                    .ImmersalLocalizer));
        }


        private void OnFirstLocalization(int _id)
        {
            immersalNotificationData.MapId = _id;
            immersalNotificationData.ActionName = nameof(OnFirstLocalization);
            immersalNotificationData.ImmersalEventType =
                OnEventImmersalEventArgs.ImmersalEventTypes.OnFirstLocalization;
            ActionNotificationCenter.DefaultCenter.PostNotification(ConstKey.CONST_ON_EVENT,
                immersalNotificationData);

            //To pause the localization
            if (!arContextData.ImmersalParameters.StopLocalizedAfterSuccess) return;
            arLocalizer.autoStart = false;
            arLocalizer.StopLocalizing();
            wasPaused = true;
        }

        private void OnLocalizerPoseFound(Immersal.AR.LocalizerPose _pose)
        {
            localizerPose.matrix = _pose.matrix;
            localizerPose.valid = _pose.valid;
            localizerPose.vAltitude = _pose.vAltitude;
            localizerPose.vLatitude = _pose.vLatitude;
            localizerPose.lastUpdatedPose = _pose.lastUpdatedPose;
            localizerPose.mapToEcef = _pose.mapToEcef;

            immersalNotificationData.LocalizerPose = localizerPose;
            immersalNotificationData.ActionName = nameof(OnLocalizerPoseFound);
            immersalNotificationData.ImmersalEventType =
                OnEventImmersalEventArgs.ImmersalEventTypes.OnLocalizerPoseFound;
            ActionNotificationCenter.DefaultCenter.PostNotification(ConstKey.CONST_ON_EVENT,
                immersalNotificationData);
        }

        private void StartOnServerLocalizer()
        {
            ARLocalizer.Instance.StopLocalizing();
            foreach (var tmp_Map in arMaps)
            {
                tmp_Map.Value.FreeMap();
                tmp_Map.Value.OnFirstLocalization.RemoveAllListeners();
                tmp_Map.Value.OnFirstLocalization = null;
            }


            List<SDKJob> tmp_Maps = new List<SDKJob>();
            tmp_Maps.AddRange(maps.Values.ToList());
            SDKMapId[] tmp_MapIds = new SDKMapId[tmp_Maps.Count];
            for (int tmp_Idx = 0; tmp_Idx < tmp_MapIds.Length; tmp_Idx++)
            {
                tmp_MapIds[tmp_Idx] = new SDKMapId {id = tmp_Maps[tmp_Idx].id};
            }

            if (tmp_MapIds.Length <= 0) return;
            if (tmp_MapIds.Length > 5)
                Array.Resize(ref tmp_MapIds, 5);

            ARLocalizer.Instance.OnMapChanged += OnMapChanged;
            ARLocalizer.Instance.mapIds = tmp_MapIds;
            ARLocalizer.Instance.StartLocalizing();
        }

        private void StopOnServerLocalizer()
        {
            ARLocalizer.Instance.useServerLocalizer = false;
            ARLocalizer.Instance.StopLocalizing();
            ARLocalizer.Instance.OnMapChanged -= OnMapChanged;
        }

        private void GetMaps()
        {
            JobListJobsAsync tmp_GetPrivateMapJobAsync = new JobListJobsAsync
            {
#if UNITY_EDITOR
                useGPS = true,
#else
                useGPS = locationProvider.gpsOn,
#endif
                latitude = locationProvider.latitude,
                longitude = locationProvider.longitude,
                radius = 200
            };

            tmp_GetPrivateMapJobAsync.OnResult += _result =>
            {
                maps.Clear();
                if (_result.count > 0)
                {
                    // add private maps
                    foreach (SDKJob tmp_Job in _result.jobs)
                    {
                        if (String.Compare(tmp_Job.status, ConstKey.CONST_STATUS_FAILED, StringComparison.Ordinal) != 0)
                        {
                            maps[tmp_Job.id] = tmp_Job;
                        }
                    }
                }

                //load public maps
                JobListJobsAsync tmp_GetPublicMapJobAsync = new JobListJobsAsync
                {
                    useToken = false,
                    useGPS = locationProvider.gpsOn,
                    latitude = locationProvider.latitude,
                    longitude = locationProvider.longitude,
                    radius = 200
                };
                tmp_GetPublicMapJobAsync.OnResult += _publicResult =>
                {
                    if (_publicResult.count > 0)
                    {
                        // add public maps
                        foreach (SDKJob tmp_Job in _publicResult.jobs)
                        {
                            if (tmp_Job.status != ConstKey.CONST_STATUS_FAILED)
                            {
                                maps[tmp_Job.id] = tmp_Job;
                            }
                        }
                    }

                    StartOnServerLocalizer();
                };

                jobs.Add(tmp_GetPublicMapJobAsync.RunJobAsync());
            };

            jobs.Add(tmp_GetPrivateMapJobAsync.RunJobAsync());
        }

        private async void RunJob(Task _t)
        {
            await _t;
            if (jobs.Count > 0)
            {
                jobs.RemoveAt(0);
            }

            //jobLock = 0;
        }


        private void OnPoseLose()
        {
            immersalNotificationData.ActionName = nameof(OnPoseLose);
            immersalNotificationData.ImmersalEventType =
                OnEventImmersalEventArgs.ImmersalEventTypes.OnPoseLose;
            ActionNotificationCenter.DefaultCenter.PostNotification(ConstKey.CONST_ON_EVENT, immersalNotificationData);
        }

        private void OnPoseFound()
        {
            immersalNotificationData.ActionName = nameof(OnPoseFound);
            immersalNotificationData.ImmersalEventType =
                OnEventImmersalEventArgs.ImmersalEventTypes.OnPoseFound;
            ActionNotificationCenter.DefaultCenter.PostNotification(ConstKey.CONST_ON_EVENT, immersalNotificationData);
        }

        private void OnReset()
        {
            immersalNotificationData.ActionName = nameof(OnReset);
            immersalNotificationData.ImmersalEventType =
                OnEventImmersalEventArgs.ImmersalEventTypes.OnReset;
            ActionNotificationCenter.DefaultCenter.PostNotification(ConstKey.CONST_ON_EVENT, immersalNotificationData);
        }

        private void OnMapChanged(int _id)
        {
            immersalNotificationData.MapId = _id;
            immersalNotificationData.ActionName = nameof(OnMapChanged);
            immersalNotificationData.ImmersalEventType =
                OnEventImmersalEventArgs.ImmersalEventTypes.OnMapChanged;
            ActionNotificationCenter.DefaultCenter.PostNotification(ConstKey.CONST_ON_EVENT, immersalNotificationData);
        }

        private void Localize(BaseNotificationData _notification)
        {
            immersalSDK.Localizer.Localize();
        }
    }
}
#endif
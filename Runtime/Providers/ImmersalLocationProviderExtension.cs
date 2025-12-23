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
using System.Collections;
#if (UNITY_IOS || UNITY_ANDROID) && !UNITY_EDITOR && ENABLE_IMMERSAL
using Immersal;
#endif
using UnityEngine;
using UnityEngine.Android;

namespace Phantom.XRMOD.RokidModule.Runtime
{
    /// <summary>
    /// Provides location services for Immersal SDK on Rokid devices.
    /// Extends Unity's location functionality to support Immersal's requirements.
    /// </summary>
    public class ImmersalLocationProviderExtension : MonoBehaviour
    {
        /// <summary>
        /// Current latitude.
        /// </summary>
        public double latitude { get; private set; } = 0;

        /// <summary>
        /// Current longitude.
        /// </summary>
        public double longitude { get; private set; } = 0;

        /// <summary>
        /// Current altitude.
        /// </summary>
        public double altitude { get; private set; } = 0.0;

        private static ImmersalLocationProviderExtension INSTANCE;

        /// <summary>
        /// Action triggered when geolocation tracking starts.
        /// </summary>
        public Action StartGeolocationTracking;

        /// <summary>
        /// Checks if GPS is enabled and running.
        /// </summary>
        public bool gpsOn
        {
#if (UNITY_IOS || UNITY_ANDROID) && !UNITY_EDITOR
            get { return NativeBindings.LocationServicesEnabled(); }
#else
            get { return Input.location.status == LocationServiceStatus.Running; }
#endif
        }

        /// <summary>
        /// Singleton instance of the location provider.
        /// </summary>
        public static ImmersalLocationProviderExtension Instance
        {
            get
            {
#if UNITY_EDITOR
                if (INSTANCE == null && !Application.isPlaying)
                {
                    INSTANCE = UnityEngine.Object.FindObjectOfType<ImmersalLocationProviderExtension>();
                }
#endif
                if (INSTANCE == null)
                {
                    Debug.LogError("No LocationProvider instance found. Ensure one exists in the scene.");
                }

                return INSTANCE;
            }
        }


        void Awake()
        {
            if (INSTANCE == null)
            {
                INSTANCE = this;
            }

            if (INSTANCE != this)
            {
                Debug.LogError("There must be only one LocationProvider object in a scene.");
                UnityEngine.Object.DestroyImmediate(this);
                return;
            }
        }

        private void Start()
        {
#if UNITY_IOS
            StartCoroutine(EnableLocationServices());
#elif UNITY_ANDROID
            if (Permission.HasUserAuthorizedPermission(Permission.FineLocation))
            {
                Debug.Log("Location permission OK");
                StartCoroutine(EnableLocationServices());
            }
            else
            {
                Debug.Log("Requesting location permission");
                Permission.RequestUserPermission(Permission.FineLocation);
                StartCoroutine(WaitForLocationPermission());
            }
#endif
        }

        private void Update()
        {
            UpdateLocation();
        }

        private void UpdateLocation()
        {
            if (gpsOn)
            {
#if (UNITY_IOS || UNITY_ANDROID) && !UNITY_EDITOR
                latitude = NativeBindings.GetLatitude();
                longitude = NativeBindings.GetLongitude();
                altitude = NativeBindings.GetAltitude();
#else
                latitude = Input.location.lastData.latitude;
                longitude = Input.location.lastData.longitude;
                altitude = Input.location.lastData.altitude;
#endif
            }
        }


#if UNITY_ANDROID
        private IEnumerator WaitForLocationPermission()
        {
            while (!Permission.HasUserAuthorizedPermission(Permission.FineLocation))
            {
                yield return null;
            }

            Debug.Log("Location permission OK");
            StartCoroutine(EnableLocationServices());
            yield return null;
        }
#endif

        private IEnumerator EnableLocationServices()
        {
            // First, check if user has location service enabled
            if (!Input.location.isEnabledByUser)
            {
                Debug.Log("Location services not enabled");
                yield break;
            }

            // Start service before querying location
#if (UNITY_IOS || UNITY_ANDROID) && !UNITY_EDITOR
            NativeBindings.StartLocation();
#else
            Input.location.Start(0.001f, 0.001f);
#endif
            // Wait until service initializes
            int tmp_MAXWait = 20;
#if (UNITY_IOS || UNITY_ANDROID) && !UNITY_EDITOR
            while (!NativeBindings.LocationServicesEnabled() && tmp_MAXWait > 0)
#else
            while (Input.location.status == LocationServiceStatus.Initializing && tmp_MAXWait > 0)
#endif
            {
                yield return new WaitForSeconds(1);
                tmp_MAXWait--;
            }

            // Service didn't initialize in 20 seconds
            if (tmp_MAXWait < 1)
            {
                Debug.Log("Timed out");
                yield break;
            }

            // Connection has failed
#if (UNITY_IOS || UNITY_ANDROID) && !UNITY_EDITOR && ENABLE_IMMERSAL
            if (!NativeBindings.LocationServicesEnabled())
#else
            if (Input.location.status == LocationServiceStatus.Failed)
#endif
            {
                Debug.Log("Unable to determine device location");
                yield break;
            }

#if (UNITY_IOS || UNITY_ANDROID) && !UNITY_EDITOR && ENABLE_IMMERSAL
            if (NativeBindings.LocationServicesEnabled())
#else
            if (Input.location.status == LocationServiceStatus.Running)
#endif
            {
                Debug.Log("Tracking geolocation");
                StartGeolocationTracking?.Invoke();
            }
        }
    }
}
#endif
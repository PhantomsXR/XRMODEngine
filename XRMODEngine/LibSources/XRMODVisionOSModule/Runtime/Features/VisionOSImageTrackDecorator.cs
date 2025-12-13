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

using System;
using System.Collections;
using System.Collections.Generic;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.VisionOSModule.Runtime.Models;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.VisionOSModule.Runtime
{
    public class VisionOSImageTrackDecorator : BaseVisionOSFeatureDecorator
    {
        private ARTrackedImageManager trackedImageManager;

        //private readonly int maxNumOfMovingImages;
        private  Dictionary<string, ARTrackedImage> allArTrackedImages;
        private OnEventMarkerEventArgs onEventMarkerEventArgs = new();

        private List<AddReferenceImageJobState> addReferenceImagesJobState;
        private ARComponentModel arComponentModel;


        private void OnTrackedImagesChanged(ARTrackedImagesChangedEventArgs _args)
        {
            foreach (ARTrackedImage tmp_Image in _args.added)
            {
                //Avoid identifying the same image multiple times
                if (!allArTrackedImages.TryAdd(tmp_Image.name, tmp_Image)) return;

                onEventMarkerEventArgs.MarkerName = tmp_Image.referenceImage.name;
                onEventMarkerEventArgs.MarkerState = MarkerTrackingState.Added;
                onEventMarkerEventArgs.MarkerTrackable = tmp_Image.transform;

                ActionNotificationCenter.DefaultCenter.PostNotification(ConstKey.CONST_ON_EVENT,
                    onEventMarkerEventArgs);
            }


            foreach (var tmp_Image in _args.updated)
            {
                onEventMarkerEventArgs.MarkerName = tmp_Image.referenceImage.name;
                switch (tmp_Image.trackingState)
                {
                    case TrackingState.None:
                        onEventMarkerEventArgs.MarkerState = MarkerTrackingState.None;
                        break;
                    case TrackingState.Limited:
                        onEventMarkerEventArgs.MarkerState = MarkerTrackingState.Limited;
                        break;
                    case TrackingState.Tracking:
                        onEventMarkerEventArgs.MarkerState = MarkerTrackingState.Tracking;
                        break;
                }

                onEventMarkerEventArgs.MarkerTrackable = tmp_Image.transform;

                ActionNotificationCenter.DefaultCenter.PostNotification(ConstKey.CONST_ON_EVENT,
                    onEventMarkerEventArgs);
            }
        }

        public override void StartAlgorithm()
        {
            base.StartAlgorithm();
            try
            {
                arComponentModel = IocContainer.GetIoc.Resolve<ARComponentModel>();

                trackedImageManager = arComponentModel.XROriginGameObject.AddComponent<ARTrackedImageManager>();
                trackedImageManager.enabled = false;
                arComponentModel.ARTrackedImageManager = trackedImageManager;

                allArTrackedImages = new Dictionary<string, ARTrackedImage>();

                arComponentModel.ARTrackedImageManager.requestedMaxNumberOfMovingImages =
                    ((ARConfiguresModel) IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>().CurrentConfigures.Value)
                    .MaxMovingOfTracking;

                Object.FindObjectOfType<MonoBehaviour>().StartCoroutine(ProcessImage());
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception.Message);
                throw new Exception(tmp_Exception.Message);
            }
        }

        private IEnumerator ProcessImage()
        {
            // IReferenceImageLibrary tmp_ImageData = null;
            // MutableRuntimeReferenceImageLibrary tmp_RuntimeLibrary = null;
            if (trackedImageManager.referenceLibrary == null)
            {
                try
                {
                    var tmp_ReferenceImageLib =
                        IocContainer.GetIoc.Resolve<ARContextDataModel>().ReferenceImageLibrary;
                    if (trackedImageManager.subsystem == null || tmp_ReferenceImageLib == null)
                        yield break;
                    trackedImageManager.referenceLibrary =
                        Resources.Load<XRReferenceImageLibrary>("Configures/BuiltInReferenceImageLibrary");
                    if (trackedImageManager.referenceLibrary is MutableRuntimeReferenceImageLibrary tmp_RuntimeLibrary)
                    {
                        addReferenceImagesJobState = new List<AddReferenceImageJobState>();
                        foreach (XRReferenceImage tmp_ReferenceImage in tmp_ReferenceImageLib)
                        {
                            if (tmp_ReferenceImage.texture == null || !tmp_ReferenceImage.texture.isReadable)
                                continue;

                            var tmp_JobState =
                                tmp_RuntimeLibrary.ScheduleAddImageWithValidationJob(tmp_ReferenceImage.texture,
                                    tmp_ReferenceImage.name, tmp_ReferenceImage.width);
                            addReferenceImagesJobState.Add(tmp_JobState);
                        }
                    }
                    else
                    {
                        throw new Exception($"RuntimeLibrary is not a mutable Runtime Reference Image Library.");
                    }
                }
                catch (InvalidOperationException tmp_Exception)
                {
                    Debug.LogError(tmp_Exception.Message);
                    throw new InvalidOperationException(tmp_Exception.Message);
                }
            }

            while (!addReferenceImagesJobState[addReferenceImagesJobState.Count - 1].jobHandle.IsCompleted)
            {
                yield return null;
            }

            // Assert.IsNotNull(tmp_RuntimeLibrary, "Create ReferenceLibrary failed!");
            // trackedImageManager.referenceLibrary = tmp_RuntimeLibrary;
            // trackedImageManager.requestedMaxNumberOfMovingImages = maxNumOfMovingImages;
            trackedImageManager.enabled = true;
            trackedImageManager.trackedImagesChanged += OnTrackedImagesChanged;
        }


        public override void PauseAlgorithm()
        {
            try
            {
                if (!trackedImageManager && trackedImageManager.descriptor == null) return;
                Assert.IsNotNull(trackedImageManager, "TrackedImageManager is no exist");
                trackedImageManager.trackedImagesChanged -= OnTrackedImagesChanged;
                trackedImageManager.enabled = false;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception.Message);
                throw new Exception(tmp_Exception.Message);
            }
        }


        public override void StopAlgorithm()
        {
            try
            {
                if (!trackedImageManager && trackedImageManager.descriptor == null) return;

                PauseAlgorithm();

                if (trackedImageManager.trackedImagePrefab)
                {
                    Object.DestroyImmediate(trackedImageManager.trackedImagePrefab, true);
                    trackedImageManager.trackedImagePrefab = null;
                }

                Assert.IsNull(trackedImageManager.trackedImagePrefab, "trackedImagePrefab != null");

                var tmp_ReferenceImageLib =
                    IocContainer.GetIoc.Resolve<ARContextDataModel>().ReferenceImageLibrary;

                if (tmp_ReferenceImageLib)
                {
                    Object.DestroyImmediate(tmp_ReferenceImageLib, true);
                }

                Assert.IsNull(tmp_ReferenceImageLib, "TrackedImageManager != null");

                trackedImageManager.subsystem?.Stop();
                trackedImageManager.subsystem?.Destroy();


                trackedImageManager.enabled = false;
                if (trackedImageManager)
                {
                    Object.Destroy(trackedImageManager);
                    trackedImageManager = null;
                }

                allArTrackedImages.Clear();
                Assert.IsNull(trackedImageManager, "TrackedImageManager != null");

                onEventMarkerEventArgs = null;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception.Message);
                throw new Exception(tmp_Exception.Message);
            }
        }

        public override bool SupportThisFeature()
        {
            return trackedImageManager.descriptor != null;
        }
    }
}
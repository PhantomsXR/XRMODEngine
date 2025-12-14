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
using Phantom.XRMOD.VisionOSModule.Runtime.Models;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

namespace Phantom.XRMOD.VisionOSModule.Runtime
{
    public class VisionOSDynamicLibraryDecorator : BaseVisionOSFeatureDecorator
    {
        private readonly ARTrackedImageManager trackedImageManager;
        private readonly List<AddReferenceImageJobState> addReferenceImagesJobState;
        private readonly List<DynamicLibraryArgs.ImageData> images;
        private readonly Action onValidationJob;

        public VisionOSDynamicLibraryDecorator(List<DynamicLibraryArgs.ImageData> _images,
            Action _onValidationJob = null)
        {
            images = _images;
            addReferenceImagesJobState = new List<AddReferenceImageJobState>();
            if (_onValidationJob != null)
                onValidationJob = _onValidationJob;
            var tmp_ARComponentModel = IocContainer.GetIoc.Resolve<ARComponentModel>();
            trackedImageManager = tmp_ARComponentModel.ARTrackedImageManager;
        }

        public override bool SupportThisFeature()
        {
            return true;
        }

        public override void StartAlgorithm()
        {
            base.StartAlgorithm();
            UnityEngine.Object.FindObjectOfType<MonoBehaviour>().StartCoroutine(ProcessImages());
        }

        private IEnumerator ProcessImages()
        {
            if (trackedImageManager == null || trackedImageManager.referenceLibrary == null) yield return null;
            if (trackedImageManager.referenceLibrary is MutableRuntimeReferenceImageLibrary tmp_MutableLibrary)
            {
                try
                {
                    foreach (var tmp_Image in images)
                    {
                        // Note: You do not need to do anything with the returned JobHandle, but it can be
                        // useful if you want to know when the image has been added to the library since it may
                        // take several frames.
                        var tmp_State = tmp_MutableLibrary.ScheduleAddImageWithValidationJob(tmp_Image.texture,
                            tmp_Image.name,
                            tmp_Image.width);
                        addReferenceImagesJobState.Add(tmp_State);
                    }
                }
                catch (InvalidOperationException e)
                {
                    Debug.LogError($"ScheduleAddImageJob threw exception: {e.Message}");
                }

                while (!addReferenceImagesJobState[^1].jobHandle.IsCompleted)
                {
                    yield return null;
                }

                onValidationJob?.Invoke();
            }
            else
            {
                Debug.LogError($"The reference image library is not mutable.");
            }
        }

        public override void PauseAlgorithm()
        {
            return;
        }

        public override void StopAlgorithm()
        {
            foreach (DynamicLibraryArgs.ImageData tmp_ImageData in images)
            {
                UnityEngine.Object.DestroyImmediate(tmp_ImageData.texture, true);
            }

            images.Clear();
        }
    }
}
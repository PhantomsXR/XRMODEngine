// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.QuestModule.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

namespace Phantom.XRMOD.QuestModule.Runtime
{
    public class XRRuntimeContextDataModel
    {
        public BindableProperty<bool> ARAvailability { get; private set; }
        public BindableProperty<ARSessionState> ARSessionState { get; private set; }

        public BindableProperty<bool> EnableHDR { get; private set; }
        


        public BindableProperty<Texture2D> FrameTexture { get; private set; }

        public BindableProperty<string> OnMarkerRecognized;

        public BindableProperty<IFeatureDecorator> FrameGetter;
        public GameObject PlaneVisualizer { get; set; }

        public GameObject MeshVisualizer { get; set; }

        public GameObject PointCloudVisualizer { get; set; }


        public SpaceType SpaceType { get; set; }

        public ConversionType ConversionType { get; set; }

        public TextureFormat TextureFormat { get; set; }

        public bool StopARModule { get; set; }

        public bool IsARCollaborationAvailability = false;
        public bool ARKitCoachingOverlayAvailability = false;

        public string ARKitWordMapSavePath = $"{Application.temporaryCachePath}/ARKitWordMap.bytes";

        public Dictionary<string, List<IFeatureDecorator>> FeatureDecoratorsAtRuntime = new();

        public XRRuntimeContextDataModel()
        {
            Initialize();
        }

        public void Initialize()
        {
            FrameGetter = new BindableProperty<IFeatureDecorator>();
            OnMarkerRecognized = new BindableProperty<string>();
            FrameTexture = new BindableProperty<Texture2D>();
            ARAvailability = new BindableProperty<bool>();
            EnableHDR = new BindableProperty<bool>();
            ARSessionState = new BindableProperty<ARSessionState>();
        }

        public void Release()
        {
            ARAvailability.OnValueChanged = null;
            EnableHDR.OnValueChanged = null;
            ARSessionState.OnValueChanged = null;
            FrameGetter.OnValueChanged = null;
            OnMarkerRecognized.OnValueChanged = null; 

            StopARModule = false; 
        }
    }
}
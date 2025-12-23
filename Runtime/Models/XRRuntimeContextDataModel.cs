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
    /// <summary>
    /// Runtime data model for the Quest module.
    /// <para>
    /// Stores the state of the AR session, availability, visualizers, feature decorators, and other runtime context information.
    /// </para>
    /// </summary>
    public class XRRuntimeContextDataModel
    {
        /// <summary>
        /// Bindable property for AR availability status.
        /// </summary>
        public BindableProperty<bool> ARAvailability { get; private set; }
        /// <summary>
        /// Bindable property for the current AR session state.
        /// </summary>
        public BindableProperty<ARSessionState> ARSessionState { get; private set; }

        /// <summary>
        /// Bindable property for enabling HDR.
        /// </summary>
        public BindableProperty<bool> EnableHDR { get; private set; }
        


        /// <summary>
        /// Bindable property for the current camera frame texture.
        /// </summary>
        public BindableProperty<Texture2D> FrameTexture { get; private set; }

        /// <summary>
        /// Bindable property triggered when a marker is recognized.
        /// </summary>
        public BindableProperty<string> OnMarkerRecognized;

        /// <summary>
        /// Bindable property for the frame getter decorator.
        /// </summary>
        public BindableProperty<IFeatureDecorator> FrameGetter;
        /// <summary>
        /// Reference to the plane visualizer GameObject.
        /// </summary>
        public GameObject PlaneVisualizer { get; set; }

        /// <summary>
        /// Reference to the mesh visualizer GameObject.
        /// </summary>
        public GameObject MeshVisualizer { get; set; }

        /// <summary>
        /// Reference to the point cloud visualizer GameObject.
        /// </summary>
        public GameObject PointCloudVisualizer { get; set; }


        /// <summary>
        /// Current space type (e.g., Local, Global).
        /// </summary>
        public SpaceType SpaceType { get; set; }

        /// <summary>
        /// Texture conversion type.
        /// </summary>
        public ConversionType ConversionType { get; set; }

        /// <summary>
        /// Format of the camera texture.
        /// </summary>
        public TextureFormat TextureFormat { get; set; }

        /// <summary>
        /// Flag to indicate if the AR module should stop.
        /// </summary>
        public bool StopARModule { get; set; }

        /// <summary>
        /// Availability of AR collaboration.
        /// </summary>
        public bool IsARCollaborationAvailability = false;
        /// <summary>
        /// Availability of ARKit coaching overlay.
        /// </summary>
        public bool ARKitCoachingOverlayAvailability = false;

        /// <summary>
        /// Path to save the ARKit world map.
        /// </summary>
        public string ARKitWordMapSavePath = $"{Application.temporaryCachePath}/ARKitWordMap.bytes";

        /// <summary>
        /// Dictionary of active feature decorators grouped by project name.
        /// </summary>
        public Dictionary<string, List<IFeatureDecorator>> FeatureDecoratorsAtRuntime = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="XRRuntimeContextDataModel"/> class.
        /// </summary>
        public XRRuntimeContextDataModel()
        {
            Initialize();
        }

        /// <summary>
        /// Initializes bindable properties.
        /// </summary>
        public void Initialize()
        {
            FrameGetter = new BindableProperty<IFeatureDecorator>();
            OnMarkerRecognized = new BindableProperty<string>();
            FrameTexture = new BindableProperty<Texture2D>();
            ARAvailability = new BindableProperty<bool>();
            EnableHDR = new BindableProperty<bool>();
            ARSessionState = new BindableProperty<ARSessionState>();
        }

        /// <summary>
        /// Releases resources and unbinds events.
        /// </summary>
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
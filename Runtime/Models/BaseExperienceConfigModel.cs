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
 
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Core.Runtime.Enums;
using UnityEngine; 

namespace Phantom.XRMOD.Models.Runtime
{
    /// <summary>
    /// Specifies the type of tracking algorithm used for the XR experience.
    /// </summary>
    public enum AlgorithmType : int
    {
        /// <summary> Focus-based SLAM tracking. </summary>
        FocusSlam = 0,
        /// <summary> Anchor-based spatial tracking. </summary>
        Anchor = 1,
        /// <summary> Gyroscope-based rotational tracking. </summary>
        Gyro = 2,
        /// <summary> Fixed position tracking. </summary>
        Fixed = 3,
        /// <summary> Image-based marker tracking. </summary>
        ImageTracker = 4,
        /// <summary> Immersal-based visual positioning. </summary>
        Immersal = 5,
        /// <summary> Face-based tracking and mesh generation. </summary>
        FaceMesh = 6,
        /// <summary> Environment meshing and spatial mapping. </summary>
        Meshing = 7,
        /// <summary> Classic 3D (non-AR) rendering mode. </summary>
        Classic3D = 8,
        /// <summary> No algorithm specified. </summary>
        None = 9,
    }

    public enum ProgrammableType
    {
        CSharp,
        VisualScripting
    }

    public enum JITFlags : int
    {
        None = 0,

        /// <summary>
        /// Method will be JIT when method is called multiple time
        /// </summary>
        JITOnDemand = 1,

        /// <summary>
        /// Method will be JIT immediately when called, instead of progressively warm up
        /// </summary>
        JITImmediately = 2,

        /// <summary>
        /// Method will not be JIT when called
        /// </summary>
        NoJIT = 4,

        /// <summary>
        /// Method will always be inlined when called
        /// </summary>
        ForceInline = 8,
    }

    public enum MediaResolution : uint
    {
        Normal,
        HD
    }

    /// <summary>
    /// The base data model for XR experience configurations.
    /// contains settings for algorithms, scripting, graphics, and spatial positioning.
    /// </summary>
    [System.Serializable]
    public class BaseExperienceConfigModel : IModel
    {
        /// <summary> The name of the project associated with this configuration. </summary>
        public string ProjectName;

        //Base
        /// <summary> The target SDK device type (e.g., HandheldAR, MR). </summary>
        public SDKDeviceType SDKDeviceType = SDKDeviceType.HandheldAR;
        /// <summary> The configuration version string. </summary>
        public string Version = "0.0.1";
        /// <summary> The primary tracking algorithm to use. </summary>
        public AlgorithmType Algorithm;
        /// <summary> Whether the algorithm should start automatically upon loading. </summary>
        public bool AlgorithmAutoStart;


        //script
        /// <summary> The name of the main entry point script or class. </summary>
        public string MainEntry;
        /// <summary> The domain name for script isolation. </summary>
        public string DomainName;
        /// <summary> The type of programmable logic (C#, Visual Scripting). </summary>
        public ProgrammableType ProgrammableType;
        /// <summary> The name of the main visual scripting graph. </summary>
        public string MainVisualScripting;
        /// <summary> Whether to enable debug mode for scripts. </summary>
        public bool DebugModel;
        /// <summary> JIT flags for script runtime performance tuning. </summary>
        public JITFlags JitFlag = 0;


        //Graphics
        /// <summary> The Unity quality level setting (0-indexed). </summary>
        public int QualityLevel = 1;

        /// <summary> Whether to enable post-processing effects. </summary>
        public bool PostProcessing;


        //Recording
        // public bool UseMediaRecorder = false;
        // public bool UseMicrophone = false;
        // public MediaResolution MediaResolution = MediaResolution.Normal;

        /// <summary> The type of space the experience occupies (Exclusive, Open). </summary>
        public SpaceType SpaceType = SpaceType.ExclusiveSpace;

        // For vst device
        /// <summary> Whether the experience is designed for Mixed Reality. </summary>
        public bool MixedReality = false;
        /// <summary> Whether to enable pass-through rendering for MR. </summary>
        public bool MRPassthrough;

        // For universal rendering device
        /// <summary> The mode for resizing the experience bounds. </summary>
        public BoundResizeMode BoundResizeMode = BoundResizeMode.None;
        /// <summary> The physical dimensions of the experience volume. </summary>
        public Vector3 Dimensions = Vector3.one;
        /// <summary> The initial physical position offset. </summary>
        public Vector3 Position = new Vector3(0, 0.5f, 0);
        /// <summary> The culling mask for rendering the experience. </summary>
        public LayerMask CullingMask = LayerMask.NameToLayer("Default");

        /// <summary>
        /// Initializes the configuration model. Can be overridden in derived classes.
        /// </summary>
        public virtual void Initialize()
        {
        }
    }
}
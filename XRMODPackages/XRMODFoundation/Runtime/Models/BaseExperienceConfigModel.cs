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
    public enum AlgorithmType
    {
        FocusSlam = 0,
        Anchor = 1, 
        Gyro = 2,
        Fixed = 3, 
        ImageTracker = 4,
        Immersal = 5,
        FaceMesh = 6,
        Meshing = 7,
        Classic3D = 8,
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

    [System.Serializable]
    public class BaseExperienceConfigModel : IModel
    {
        public string ProjectName;

        //Base
        public SDKDeviceType SDKDeviceType = SDKDeviceType.HandheldAR;
        public string Version = "0.0.1";
        public AlgorithmType Algorithm;
        public bool AlgorithmAutoStart;


        //script
        public string MainEntry;
        public string DomainName;
        public ProgrammableType ProgrammableType;
        public string MainVisualScripting;
        public bool DebugModel;
        public JITFlags JitFlag = 0;


        //Graphics
        public int QualityLevel = 1;

        public bool PostProcessing;


        //Multiplayer
        // public bool Multiplayer;
        // public bool DisplayPing;
        // public bool Discovery;


        //Recording
        // public bool UseMediaRecorder = false;
        // public bool UseMicrophone = false;
        // public MediaResolution MediaResolution = MediaResolution.Normal;

        public SpaceType SpaceType = SpaceType.ExclusiveSpace;

        // For vst device
        public bool MixedReality = false;
        public bool MRPassthrough;

        // For universal rendering device
        public BoundResizeMode BoundResizeMode = BoundResizeMode.None;
        public Vector3 Dimensions = Vector3.one;
        public Vector3 Position = new Vector3(0, 0.5f, 0);
        public LayerMask CullingMask = LayerMask.NameToLayer("Default");

        public virtual void Initialize()
        {
        }
    }
}
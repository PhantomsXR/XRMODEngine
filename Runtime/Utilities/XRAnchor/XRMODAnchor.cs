// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.MixedRealityUtilities.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using UnityEngine;

namespace Phantom.XRMOD.XRMODUtilites.Runtime
{
    /// <summary>
    /// Represents a spatial anchor in the XRMOD system, identified by a unique UUID.
    /// </summary>
    public class XRMODAnchor : MonoBehaviour
    {
        /// <summary>
        /// The unique identifier for this spatial anchor.
        /// </summary>
        public Guid Uuid;
    }
    
    /// <summary>
    /// Parameters required for loading an XR environment map.
    /// </summary>
    [System.Serializable]
    public class LoadEnvironmentParameters
    {
        /// <summary>
        /// The name of the map to load.
        /// </summary>
        public string MapName;

        /// <summary>
        /// The process identifier associated with the environment.
        /// </summary>
        public string ProcessId;
    }
}
// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.VisionOSModule.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using UnityEngine;

namespace Phantom.XRMOD.ActionNotification.Runtime
{
    public class OnEventMeshEventArgs : OnEventBaseArgs
    {
        /// <summary>
        /// The list of <c>MeshFilter</c>s added since the last event.
        /// </summary>
        public List<MeshFilter> Added { get; set; }

        /// <summary>
        /// The list of <c>MeshFilter</c>s udpated since the last event.
        /// </summary>
        public List<MeshFilter> Updated { get; set; }

        /// <summary>
        /// The list of <c>MeshFilter</c>s removed since the last event.
        /// </summary>
        public List<MeshFilter> Removed { get; set; }
    }
}
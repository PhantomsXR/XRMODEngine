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

using System.Collections.Generic;
using UnityEngine;

namespace Phantom.XRMOD.ActionNotification.Runtime
{
    public class OnEventPlaneEventArgs : OnEventBaseArgs
    {
        /// <summary>
        /// The list of <see cref="Transform"/>s added since the last event.
        /// </summary>
        public List<Transform> Added { get; set; }

        /// <summary>
        /// The list of <see cref="Transform"/>s udpated since the last event.
        /// </summary>
        public List<Transform> Updated { get; set; }

        /// <summary>
        /// The list of <see cref="Transform"/>s removed since the last event.
        /// At the time the event is invoked, the <see cref="Transform"/>s in
        /// this list still exist. They are destroyed immediately afterward.
        /// </summary>
        public List<Transform> Removed { get; set; }
    }
}
// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the com.Phantoms.Immersal.Editor.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;

namespace Phantom.XRMOD.Immersal.Editor.Models
{
    [Serializable]
    public class MapModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string error ;
        /// <summary>
        /// 
        /// </summary>
        public int count ;
        /// <summary>
        /// 
        /// </summary>
        public List <JobsItem > jobs ;
    }
}
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

namespace Phantom.XRMOD.Immersal.Editor.Models
{
    [Serializable]
    public class JobsItem
    {
        /// <summary>
        /// 
        /// </summary>
        public int id;

        /// <summary>
        /// 
        /// </summary>
        public int type;

        /// <summary>
        /// 
        /// </summary>
        public string version;

        /// <summary>
        /// 
        /// </summary>
        public int creator;

        /// <summary>
        /// 
        /// </summary>
        public int size;

        /// <summary>
        /// 
        /// </summary>
        public string status;

        /// <summary>
        /// 
        /// </summary>
        public int errno;

        /// <summary>
        /// 
        /// </summary>
        public int privacy;

        /// <summary>
        /// 
        /// </summary>
        public string name;

        /// <summary>
        /// 
        /// </summary>
        public double latitude;

        /// <summary>
        /// 
        /// </summary>
        public double longitude;

        /// <summary>
        /// 
        /// </summary>
        public double altitude;

        /// <summary>
        /// 
        /// </summary>
        public string created;

        /// <summary>
        /// 
        /// </summary>
        public string modified;

        /// <summary>
        /// 
        /// </summary>
        public string sha256_al;

        /// <summary>
        /// 
        /// </summary>
        public string sha256_sparse;

        /// <summary>
        /// 
        /// </summary>
        public string sha256_dense;

        /// <summary>
        /// 
        /// </summary>
        public string sha256_tex;
    }
}
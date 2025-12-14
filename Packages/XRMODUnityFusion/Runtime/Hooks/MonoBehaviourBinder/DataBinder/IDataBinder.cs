// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Runtime.CodeHook.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Threading.Tasks;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    public interface IDataBinder
    {
        /// <summary>
        /// Asynchronously processes the fields in MonoData and injects the values
        /// into the target script instance.
        /// </summary>
        /// <param name="_data">The data container with field information and the target instance.</param>
        void BindData(MonoData _data);
    }
}
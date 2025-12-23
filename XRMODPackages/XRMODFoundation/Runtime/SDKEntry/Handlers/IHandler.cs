// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the XR-MOD SDK.
// 
// The XR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact nswell@phantomsxr.com for licensing requests.
// ===============================================================================*/

using System.Threading.Tasks;

namespace Phantom.XRMOD.SDKEntry.Runtime
{
    /// <summary>
    /// Interface for all handlers in the SDK's project loading and lifecycle pipeline.
    /// </summary>
    public interface IHandler
    {
        /// <summary> Specifies the next handler in the execution chain. </summary>
        IHandler SetNext(IHandler _header);
        /// <summary> Executes the logic associated with this handler. </summary>
        void Handle();
    }
}
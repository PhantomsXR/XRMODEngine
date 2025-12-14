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
using Phantom.XRMOD.SDKEntry.Runtime.Mapper;

namespace Phantom.XRMOD.SDKEntry.Runtime.DataRequest
{
    public interface IHttpRequestCommand
    {
        Task<string> Executed();
    }

    public interface IHttpRequestCommand<T>
    {
        Task<T> Execute();
    }
}
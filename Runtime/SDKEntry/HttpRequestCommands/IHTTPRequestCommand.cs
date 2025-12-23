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
    /// <summary>
    /// Interface for a generic HTTP request command that returns a string result.
    /// </summary>
    public interface IHttpRequestCommand
    {
        /// <summary> Executes the request and returns the response as a string. </summary>
        Task<string> Executed();
    }

    /// <summary>
    /// Interface for a generic HTTP request command that returns a typed result.
    /// </summary>
    /// <typeparam name="T">The expected type of the response data.</typeparam>
    public interface IHttpRequestCommand<T>
    {
        /// <summary> Executes the request and returns the response as type T. </summary>
        Task<T> Execute();
    }
}
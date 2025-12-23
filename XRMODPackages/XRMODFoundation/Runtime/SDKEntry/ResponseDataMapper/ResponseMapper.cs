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

namespace Phantom.XRMOD.SDKEntry.Runtime.Mapper
{
    /// <summary>
    /// Specific server response that includes <see cref="ExperienceResourceMapper"/> data.
    /// </summary>
    public class ResponseMapper:BaseServerResponse
    {
        public ExperienceResourceMapper data;
    }
}
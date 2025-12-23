/*===============================================================================
Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.

This file is part of the XR-MOD SDK.

The XR-MOD SDK cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// Interface for components that implement custom runtime tagging.
    /// Provides a mechanism for tag identification and comparison.
    /// </summary>
    public interface IRuntimeTag
    {
        /// <summary>
        /// Performs a comparison between the component's tag and a target tag.
        /// </summary>
        /// <param name="_tag">The target tag string.</param>
        /// <returns>True if the tags are considered identical; otherwise, false.</returns>
        bool DoCompareTag(string _tag);
    }
}
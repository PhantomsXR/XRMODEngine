/*===============================================================================
Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.

This file is part of the XR-MOD SDK.

The XR-MOD SDK cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using System;
using UnityEngine;

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// A component that assigns a custom runtime tag to a GameObject, allowing it to be 
    /// discovered by the <see cref="RuntimeTagManager"/> regardless of Unity's built-in tag system.
    /// </summary>
    public class GameObjectRuntimeTag : MonoBehaviour, IRuntimeTag
    {
        /// <summary>
        /// The custom tag string assigned to this GameObject.
        /// </summary>
        [Tooltip("The custom tag used for runtime discovery.")]
        public string RuntimeTag;
        
        /// <summary>
        /// Compares the current runtime tag with the specified tag.
        /// </summary>
        /// <param name="_tag">The tag string to compare against.</param>
        /// <returns>True if the tags match exactly; otherwise, false.</returns>
        public bool DoCompareTag(string _tag)
        {
            return String.CompareOrdinal(RuntimeTag, _tag) == 0;
        }
    }
}
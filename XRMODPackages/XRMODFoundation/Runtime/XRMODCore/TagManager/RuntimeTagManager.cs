/*===============================================================================
Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.

This file is part of the XR-MOD SDK.

The XR-MOD SDK cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using System;
using System.Linq;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.Assertions;

namespace Phantom.XRMOD.Core.Runtime
{
    /// <summary>
    /// Singleton manager for finding objects tagged with <see cref="GameObjectRuntimeTag"/> at runtime.
    /// This provides a more flexible alternative to Unity's native tag system, especially across dynamically loaded content.
    /// </summary>
    public class RuntimeTagManager
    {
        private static RuntimeTagManager INSTANCE;

        /// <summary>
        /// Gets the singleton instance of the <see cref="RuntimeTagManager"/>.
        /// </summary>
        public static RuntimeTagManager GetRuntimeTagManager => INSTANCE ??= new RuntimeTagManager();

        /// <summary>
        /// Finds a GameObject in the scene that has a <see cref="GameObjectRuntimeTag"/> Matching the specified tag.
        /// </summary>
        /// <param name="_tag">The custom tag to search for.</param>
        /// <param name="_result">When this method returns, contains the found GameObject if successful; otherwise, null.</param>
        /// <remarks>
        /// <b>Warning:</b> This method uses <see cref="Resources.FindObjectsOfTypeAll"/> which is resource-intensive.
        /// In the Editor, it automatically filters out prefab assets to only return scene-instances.
        /// </remarks>
        public void GetGameObjectByTag(string _tag, out GameObject _result)
        {
            Assert.AreNotEqual(_tag, string.Empty);
            _result = null;

            var tmp_AllGameObject = Resources.FindObjectsOfTypeAll<GameObjectRuntimeTag>();
            var tmp_Q = tmp_AllGameObject.Where((_runtimeTag, _) =>
            {
#if UNITY_EDITOR
                // We must ignore the asset prefab and only search in active scene objects
                if (!PrefabUtility.IsPartOfPrefabAsset(_runtimeTag.gameObject))
                {
#endif
                    return String.Compare(_tag, _runtimeTag.RuntimeTag, StringComparison.Ordinal) == 0
                           && _runtimeTag.gameObject.scene.IsValid();
#if UNITY_EDITOR
                }
#endif
                return false;
            });
            
            var tmp_RuntimeTags = tmp_Q as GameObjectRuntimeTag[] ?? tmp_Q.ToArray();
            if (tmp_RuntimeTags.Length > 0)
                _result = tmp_RuntimeTags[0].gameObject;
        }
    }
}
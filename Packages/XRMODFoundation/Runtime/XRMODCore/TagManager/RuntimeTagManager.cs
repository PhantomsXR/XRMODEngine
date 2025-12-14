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

using System;
using System.Linq;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.Assertions;

namespace Phantom.XRMOD.Core.Runtime
{
    public class RuntimeTagManager
    {
        private static RuntimeTagManager INSTANCE;

        public static RuntimeTagManager GetRuntimeTagManager => INSTANCE ??= new RuntimeTagManager();

        public void GetGameObjectByTag(string _tag, out GameObject _result)
        {
            Assert.AreNotEqual(_tag, string.Empty);
            _result = null;

            //WARING: FindObjectsOfTypeAll are get all object with <T> (Include <T> prefab asset on Unity project)
            var tmp_AllGameObject = Resources.FindObjectsOfTypeAll<GameObjectRuntimeTag>();
            var tmp_Q = tmp_AllGameObject.Where((_runtimeTag, _) =>
            {
#if UNITY_EDITOR
                //We must ignore the asset prefab
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
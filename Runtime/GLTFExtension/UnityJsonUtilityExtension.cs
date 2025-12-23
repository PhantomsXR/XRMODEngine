// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the BaseFeaturesModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Phantom.XRMOD.GLTFExtension.Runtime
{
    // List<T>
    /// <summary>
    /// A generic wrapper to enable serialization of <see cref="List{T}"/> using Unity's <see cref="JsonUtility"/>.
    /// </summary>
    /// <typeparam name="T">The type of elements in the list.</typeparam>
    [Serializable]
    public class Serialization<T>
    {
        [SerializeField] List<T> target;

        public List<T> ToList()
        {
            return target;
        }

        public Serialization(List<T> _target)
        {
            this.target = _target;
        }
    }

    // Dictionary<TKey, TValue>
    /// <summary>
    /// A generic wrapper to enable serialization of <see cref="Dictionary{TKey, TValue}"/> using Unity's <see cref="JsonUtility"/>.
    /// It implements <see cref="ISerializationCallbackReceiver"/> to convert the dictionary into two lists for serialization.
    /// </summary>
    /// <typeparam name="TKey">The type of keys in the dictionary.</typeparam>
    /// <typeparam name="TValue">The type of values in the dictionary.</typeparam>
    [Serializable]
    public class Serialization<TKey, TValue> : ISerializationCallbackReceiver
    {
        [SerializeField] List<TKey> keys;
        [SerializeField] List<TValue> values;

        Dictionary<TKey, TValue> target;

        public Dictionary<TKey, TValue> ToDictionary()
        {
            return target;
        }

        public Serialization(Dictionary<TKey, TValue> _target)
        {
            this.target = _target;
        }

        public void OnBeforeSerialize()
        {
            keys = new List<TKey>(target.Keys);
            values = new List<TValue>(target.Values);
        }

        public void OnAfterDeserialize()
        {
            var tmp_Count = Math.Min(keys.Count, values.Count);
            target = new Dictionary<TKey, TValue>(tmp_Count);
            for (var i = 0; i < tmp_Count; ++i)
            {
                target.Add(keys[i], values[i]);
            }
        }
    }
}
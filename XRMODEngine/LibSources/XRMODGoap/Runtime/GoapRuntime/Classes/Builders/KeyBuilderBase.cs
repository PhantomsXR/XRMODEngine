using System;
using System.Collections.Generic;
using Phantom.XRMOD.UnityFusion.Runtime;
using UnityEngine;

namespace Goap.Runtime
{
    public abstract class KeyBuilderBase<TInterface>
    {
        private Dictionary<Type, TInterface> keys = new();

        public TInterface GetKey<TKey>()
            where TKey : TInterface
        {
            var type = typeof(TKey);

            if (this.keys.TryGetValue(type, out var key))
            {
                return key;
            }

            key = (TInterface) Activator.CreateInstance(type);

            this.InjectData(key);
            this.keys.Add(type, key);

            return key;
        }

        public TInterface GetKey(Type _type)
        {
            if (this.keys.TryGetValue(_type, out var tmp_Key))
            {
                return tmp_Key;
            }

            tmp_Key = (TInterface) CodesHook.GetAppDomain.Instantiate(_type.FullName).CLRInstance; 
            this.InjectData(tmp_Key);
            this.keys.Add(_type, tmp_Key);

            return tmp_Key;
        }

        protected abstract void InjectData(TInterface key);
    }
}
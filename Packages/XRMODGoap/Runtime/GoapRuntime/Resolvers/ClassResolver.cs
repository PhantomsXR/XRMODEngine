using System;
using System.Collections.Generic;
using System.Linq;
using Goap.Core;
using Phantom.XRMOD.UnityFusion.Runtime;
using UnityEngine;
using UnityFusion.CLR.TypeSystem;

namespace Goap.Runtime
{
    public class ClassResolver
    {
        public List<TType> Load<TType, TConfig>(IEnumerable<TConfig> list)
            where TType : class, IHasConfig<TConfig>
            where TConfig : IClassConfig
        {
            TType action;

            if (list == null)
                return new List<TType>();

            return list.Where(x => !string.IsNullOrEmpty(x?.ClassType) && x.ClassType != "UNDEFINED").Select(x =>
            { 
                if (x is CLRType || CodesHook.GetAppDomain == null)
                {
                    action = Activator.CreateInstance(Type.GetType(x.ClassType)) as TType;
                }
                else
                {
                    try
                    {
                        action = CodesHook.GetAppDomain.Instantiate(x.ClassType).CLRInstance as TType;
                    }
                    catch (Exception tmp_Exception)
                    {
                        Debug.LogError($"Error:{x.ClassType}\n{tmp_Exception}");
                        throw;
                    }
                }

                action?.SetConfig(x);
                return action;
            }).ToList();
        }

        public TType Load<TType>(string type)
            where TType : class
        {
            if (string.IsNullOrEmpty(type))
                return null;

            return Activator.CreateInstance(Type.GetType(type)) as TType;
        }

        public HashSet<T> LoadTypes<T>(IEnumerable<string> list)
        {
            var types = list.Select(Type.GetType);
            var classes = types.Select(Activator.CreateInstance);

            return classes.Cast<T>().ToHashSet();
        }
    }
}
using System;
using System.Collections.Concurrent;
using System.Reflection;
using UnityEngine;

namespace VContainer.Internal
{
    public static class InjectorCache
    {
        static readonly ConcurrentDictionary<Type, IInjector> Injectors = new ConcurrentDictionary<Type, IInjector>();

        public static IInjector GetOrBuild(Type _type)
        {
            var tmp_Result = Injectors.GetOrAdd(_type, ValueFactory);
            return tmp_Result;
        }

        private static IInjector ValueFactory(Type _key)
        {
            // SourceGenerator
#if ENABLE_UNITYFUSION
            if (Phantom.XRMOD.UnityFusion.Runtime.CodesHook.GetAppDomain != null)
            {
                var tmp_RegisterType = Phantom.XRMOD.UnityFusion.Runtime.CodesHook.GetAppDomain.Instantiate(
                    $"{_key.FullName}GeneratedInjector");
                if (tmp_RegisterType != null)
                {
                    return (IInjector) tmp_RegisterType.CLRInstance;
                }
            }
            else
            {
                var generatedType = _key.Assembly.GetType($"{_key.FullName}GeneratedInjector", false);
                if (generatedType != null)
                {
                    return (IInjector) Activator.CreateInstance(generatedType);
                }
            }
#else
                var generatedType = key.Assembly.GetType($"{key.FullName}GeneratedInjector", false);
                if (generatedType != null)
                {
                    return (IInjector)Activator.CreateInstance(generatedType);
                }
#endif

            // IL weaving (Deprecated)
            var getter = _key.GetMethod("__GetGeneratedInjector", BindingFlags.Static | BindingFlags.Public);
            if (getter != null)
            {
                return (IInjector) getter.Invoke(null, null);
            }

            return ReflectionInjector.Build(_key);
        }
    }
}
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityFusion.CLR.TypeSystem;

namespace VContainer.Internal
{
    static class RuntimeTypeCache
    {
        static readonly ConcurrentDictionary<Type, Type> OpenGenericTypes = new ConcurrentDictionary<Type, Type>();

        static readonly ConcurrentDictionary<Type, Type[]> GenericTypeParameters =
            new ConcurrentDictionary<Type, Type[]>();

        static readonly ConcurrentDictionary<Type, Type> ArrayTypes = new ConcurrentDictionary<Type, Type>();
        static readonly ConcurrentDictionary<Type, Type> EnumerableTypes = new ConcurrentDictionary<Type, Type>();
        static readonly ConcurrentDictionary<Type, Type> ReadOnlyListTypes = new ConcurrentDictionary<Type, Type>();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Type OpenGenericTypeOf(Type closedGenericType)
            => OpenGenericTypes.GetOrAdd(closedGenericType, key => key.GetGenericTypeDefinition());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Type[] GenericTypeParametersOf(Type closedGenericType)
            => GenericTypeParameters.GetOrAdd(closedGenericType, key => key.GetGenericArguments());

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Type ArrayTypeOf(Type elementType)
        {
#if ENABLE_UNITYFUSION
            var tmp_AppDomain = Phantom.XRMOD.UnityFusion.Runtime.CodesHook.GetAppDomain;
            if (tmp_AppDomain != null)
            {
                return ArrayTypes.GetOrAdd(elementType,
                    _key => tmp_AppDomain.GetType(elementType.FullName).MakeArrayType(1).ReflectionType);
            }
#endif
            return ArrayTypes.GetOrAdd(elementType, key => key.MakeArrayType());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Type EnumerableTypeOf(Type elementType)
        {
#if ENABLE_UNITYFUSION
            var tmp_AppDomain = Phantom.XRMOD.UnityFusion.Runtime.CodesHook.GetAppDomain;
            if (tmp_AppDomain != null)
            {
                return EnumerableTypes.GetOrAdd(elementType, _key =>
                {
                    var tmp_Type = tmp_AppDomain.GetType(typeof(IEnumerable<>));
                    if (tmp_Type == null)
                        throw new Exception("IEnumerable<> not found");

                    var tmp_GenericArgs = new KeyValuePair<string, IType>[]
                    {
                        new(_key.FullName, tmp_AppDomain.GetType(_key))
                    };

                    return tmp_Type.MakeGenericInstance(tmp_GenericArgs).ReflectionType;
                });
            }
#endif
            return EnumerableTypes.GetOrAdd(elementType, key => typeof(IEnumerable<>).MakeGenericType(key));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static Type ReadOnlyListTypeOf(Type elementType)
        {
#if ENABLE_UNITYFUSION
            var tmp_AppDomain = Phantom.XRMOD.UnityFusion.Runtime.CodesHook.GetAppDomain;
            if (tmp_AppDomain != null)
            {
                return ReadOnlyListTypes.GetOrAdd(elementType, _key =>
                {
                    var tmp_Type = tmp_AppDomain.GetType(typeof(IReadOnlyList<>));
                    if (tmp_Type == null)
                        throw new Exception("IReadOnlyList<> not found");

                    var tmp_GenericArgs = new KeyValuePair<string, IType>[]
                    {
                        new(_key.FullName, tmp_AppDomain.GetType(_key))
                    };

                    return tmp_Type.MakeGenericInstance(tmp_GenericArgs).ReflectionType;
                });
            }
#endif
            return ReadOnlyListTypes.GetOrAdd(elementType, key => typeof(IReadOnlyList<>).MakeGenericType(key));
        }
    }
}
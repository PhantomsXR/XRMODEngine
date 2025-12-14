using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.CLR.Method;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using UnityFusion.Runtime.Stack;
using UnityFusion.Reflection;
using UnityFusion.CLR.Utils;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif

namespace UnityFusion.Runtime.Generated
{
    unsafe class Phantom_XRMOD_NetcodeModule_Runtime_NetworkObjectPool_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool);
            args = new Type[] { };
            method = type.GetMethod("get_Singleton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Singleton_0);
            args = new Type[] { };
            method = type.GetMethod("Awake", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Awake_1);
            args = new Type[] { };
            method = type.GetMethod("OnNetworkSpawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkSpawn_2);
            args = new Type[]
                {typeof(System.Collections.Generic.List<Phantom.XRMOD.NetcodeModule.Runtime.PoolConfigObject>)};
            method = type.GetMethod("BuildPool", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BuildPool_3);
            args = new Type[] {typeof(Phantom.XRMOD.NetcodeModule.Runtime.PoolConfigObject)};
            method = type.GetMethod("BuildPool", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BuildPool_4);
            args = new Type[] { };
            method = type.GetMethod("OnNetworkDespawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkDespawn_5);
            args = new Type[]
                {typeof(UnityEngine.GameObject), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("GetNetworkObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetNetworkObject_6);
            args = new Type[] {typeof(Unity.Netcode.NetworkObject), typeof(UnityEngine.GameObject)};
            method = type.GetMethod("ReturnNetworkObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReturnNetworkObject_7);


            app.RegisterCLRCreateDefaultInstance(type,
                () => new Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool[s]);

            args = new Type[] { };
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static StackObject* get_Singleton_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool.Singleton;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Awake_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Awake();

            return __ret;
        }

        static StackObject* OnNetworkSpawn_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkSpawn();

            return __ret;
        }

        static StackObject* BuildPool_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<Phantom.XRMOD.NetcodeModule.Runtime.PoolConfigObject> @_pooledPrefabsList =
                (System.Collections.Generic.List<Phantom.XRMOD.NetcodeModule.Runtime.PoolConfigObject>)
                typeof(System.Collections.Generic.List<Phantom.XRMOD.NetcodeModule.Runtime.PoolConfigObject>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.BuildPool(@_pooledPrefabsList);

            return __ret;
        }

        static StackObject* BuildPool_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1); 
            Phantom.XRMOD.NetcodeModule.Runtime.PoolConfigObject @_pooledPrefab =
                (Phantom.XRMOD.NetcodeModule.Runtime.PoolConfigObject)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.PoolConfigObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2); 
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);
            instance_of_this_method.BuildPool(@_pooledPrefab);

            return __ret;
        }

        static StackObject* OnNetworkDespawn_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkDespawn();

            return __ret;
        }

        static StackObject* GetNetworkObject_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @_rotation = (UnityEngine.Quaternion) typeof(UnityEngine.Quaternion).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @_position = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GameObject @_prefab = (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetNetworkObject(@_prefab, @_position, @_rotation);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ReturnNetworkObject_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @_prefab = (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkObject @_networkObject =
                (Unity.Netcode.NetworkObject) typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ReturnNetworkObject(@_networkObject, @_prefab);

            return __ret;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.NetcodeModule.Runtime.NetworkObjectPool();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}
#if FUSION2 && XRMOD_INSTALL
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Fusion;
using Phantom.XRMOD.PhotonModule.Runtime;
using UnityEngine;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.CLR.Method;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using UnityFusion.Runtime.Stack;
using UnityFusion.Reflection;
using UnityFusion.CLR.Utils;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif

namespace UnityFusion.Runtime.Generated
{
    unsafe class XRMODNetworkBehaviour_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour);

            var tmp_GetInput = type.GetMethods().ToList()
                .Find(_i => _i.Name == "GetInput" && _i.GetGenericArguments().Length == 1);
            app.RegisterCLRMethodRedirection(tmp_GetInput, GetInput);
            args = new Type[] { };
            method = type.GetMethod("FixedUpdateNetwork", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FixedUpdateNetwork_0);
            args = new Type[] {typeof(Fusion.NetworkRunner), typeof(System.Boolean)};
            method = type.GetMethod("Despawned", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Despawned_1);
            args = new Type[] { };
            method = type.GetMethod("Spawned", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Spawned_2);
            args = new Type[] { };
            method = type.GetMethod("Render", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Render_3);
            args = new Type[] {typeof(System.String), typeof(System.String), typeof(Fusion.RpcInfo)};
            method = type.GetMethod("RPC_SendStateAuthority", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RPC_SendStateAuthority_4);
            args = new Type[] {typeof(System.String), typeof(System.String), typeof(Fusion.RpcInfo)};
            method = type.GetMethod("RPC_SendStateAuthorityForInputAuthority", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RPC_SendStateAuthorityForInputAuthority_5);
            args = new Type[] {typeof(System.String), typeof(System.String), typeof(Fusion.RpcInfo)};
            method = type.GetMethod("RPC_SendStateAuthorityForAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RPC_SendStateAuthorityForAll_6);
            args = new Type[] {typeof(System.String), typeof(System.String), typeof(Fusion.RpcInfo)};
            method = type.GetMethod("RPC_SendAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RPC_SendAll_7);
            args = new Type[] {typeof(System.String), typeof(System.String), typeof(Fusion.RpcInfo)};
            method = type.GetMethod("RPC_SendAllForInputAuthority", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RPC_SendAllForInputAuthority_8);
            args = new Type[] {typeof(System.String), typeof(System.String), typeof(Fusion.RpcInfo)};
            method = type.GetMethod("RPC_SendAllForStateAuthority", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RPC_SendAllForStateAuthority_9);
            args = new Type[] {typeof(System.String), typeof(System.String), typeof(Fusion.RpcInfo)};
            method = type.GetMethod("RPC_SendInputAuthority", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RPC_SendInputAuthority_10);
            args = new Type[] {typeof(System.String), typeof(System.String), typeof(Fusion.RpcInfo)};
            method = type.GetMethod("RPC_SendInputStateAuthority", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RPC_SendInputStateAuthority_11);
            args = new Type[] {typeof(System.String), typeof(System.String), typeof(Fusion.RpcInfo)};
            method = type.GetMethod("RPC_SendInputAuthorityForAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RPC_SendInputAuthorityForAll_12);
            args = new Type[] {typeof(System.String), typeof(System.Action<System.String, Fusion.RpcInfo>)};
            method = type.GetMethod("RegisterRpcMethods", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterRpcMethods_13);


            var tmp_TryGetFusionType = type.GetMethods().ToList()
                .Find(_i => _i.Name == "TryGetFusionType" && _i.GetGenericArguments().Length == 1);
            app.RegisterCLRMethodRedirection(tmp_TryGetFusionType, TryGetFusionType_14);

            args = new Type[] { };
            method = type.GetMethod("CopyStateToBackingFields", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyStateToBackingFields_15);

            field = type.GetField("FixedUpdateNetworkEvent", flag);
            app.RegisterCLRFieldGetter(field, get_FixedUpdateNetworkEvent_0);
            app.RegisterCLRFieldSetter(field, set_FixedUpdateNetworkEvent_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_FixedUpdateNetworkEvent_0,
                AssignFromStack_FixedUpdateNetworkEvent_0);
            field = type.GetField("SpawnedEvent", flag);
            app.RegisterCLRFieldGetter(field, get_SpawnedEvent_1);
            app.RegisterCLRFieldSetter(field, set_SpawnedEvent_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_SpawnedEvent_1, AssignFromStack_SpawnedEvent_1);
            field = type.GetField("DespawnedEvent", flag);
            app.RegisterCLRFieldGetter(field, get_DespawnedEvent_2);
            app.RegisterCLRFieldSetter(field, set_DespawnedEvent_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_DespawnedEvent_2, AssignFromStack_DespawnedEvent_2);
            field = type.GetField("RenderEvent", flag);
            app.RegisterCLRFieldGetter(field, get_RenderEvent_3);
            app.RegisterCLRFieldSetter(field, set_RenderEvent_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_RenderEvent_3, AssignFromStack_RenderEvent_3);


            app.RegisterCLRCreateDefaultInstance(type,
                () => new Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour());
            app.RegisterCLRCreateArrayInstance(type,
                s => new Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour[s]);

            args = new Type[] { };
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static StackObject* FixedUpdateNetwork_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.FixedUpdateNetwork();

            return __ret;
        }

        static StackObject* Despawned_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @_hasState = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.NetworkRunner @_runner = (Fusion.NetworkRunner) typeof(Fusion.NetworkRunner).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Despawned(@_runner, @_hasState);

            return __ret;
        }

        static StackObject* Spawned_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Spawned();

            return __ret;
        }

        static StackObject* Render_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Render();

            return __ret;
        }

        static StackObject* RPC_SendStateAuthority_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.RpcInfo @_info = (Fusion.RpcInfo) typeof(Fusion.RpcInfo).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_data = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_key = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RPC_SendStateAuthority(@_key, @_data, @_info);

            return __ret;
        }

        static StackObject* RPC_SendStateAuthorityForInputAuthority_5(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.RpcInfo @_info = (Fusion.RpcInfo) typeof(Fusion.RpcInfo).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_data = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_key = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RPC_SendStateAuthorityForInputAuthority(@_key, @_data, @_info);

            return __ret;
        }

        static StackObject* RPC_SendStateAuthorityForAll_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.RpcInfo @_info = (Fusion.RpcInfo) typeof(Fusion.RpcInfo).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_data = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_key = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RPC_SendStateAuthorityForAll(@_key, @_data, @_info);

            return __ret;
        }

        static StackObject* RPC_SendAll_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.RpcInfo @_info = (Fusion.RpcInfo) typeof(Fusion.RpcInfo).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_data = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_key = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RPC_SendAll(@_key, @_data, @_info);

            return __ret;
        }

        static StackObject* RPC_SendAllForInputAuthority_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.RpcInfo @_info = (Fusion.RpcInfo) typeof(Fusion.RpcInfo).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_data = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_key = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RPC_SendAllForInputAuthority(@_key, @_data, @_info);

            return __ret;
        }

        static StackObject* RPC_SendAllForStateAuthority_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.RpcInfo @_info = (Fusion.RpcInfo) typeof(Fusion.RpcInfo).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_data = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_key = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RPC_SendAllForStateAuthority(@_key, @_data, @_info);

            return __ret;
        }

        static StackObject* RPC_SendInputAuthority_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.RpcInfo @_info = (Fusion.RpcInfo) typeof(Fusion.RpcInfo).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_data = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_key = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RPC_SendInputAuthority(@_key, @_data, @_info);

            return __ret;
        }

        static StackObject* RPC_SendInputStateAuthority_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.RpcInfo @_info = (Fusion.RpcInfo) typeof(Fusion.RpcInfo).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_data = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_key = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RPC_SendInputStateAuthority(@_key, @_data, @_info);

            return __ret;
        }

        static StackObject* RPC_SendInputAuthorityForAll_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.RpcInfo @_info = (Fusion.RpcInfo) typeof(Fusion.RpcInfo).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_data = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_key = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RPC_SendInputAuthorityForAll(@_key, @_data, @_info);

            return __ret;
        }

        static StackObject* RegisterRpcMethods_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.String, Fusion.RpcInfo> @_action =
                (System.Action<System.String, Fusion.RpcInfo>) typeof(System.Action<System.String, Fusion.RpcInfo>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_key = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RegisterRpcMethods(@_key, @_action);

            return __ret;
        }


        static StackObject* TryGetFusionType_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            try
            {
                ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
                BaseFusionType @OutValue =
                    (BaseFusionType) typeof(BaseFusionType).CheckCLRTypes(
                        __intp.RetriveObject(ptr_of_this_method, __mStack), 0);

                ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
                string @TypeName =
                    (string) typeof(string).CheckCLRTypes(
                        __intp.RetriveObject(ptr_of_this_method, __mStack), 0);

                if (__method.GenericArguments.Length == 0) return __esp;

                ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
                XRMODNetworkBehaviour instance_of_this_method =
                    (XRMODNetworkBehaviour) typeof(XRMODNetworkBehaviour).CheckCLRTypes(
                        StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);

                bool tmp_Result_of_this_method = false;
                tmp_Result_of_this_method = instance_of_this_method.TryGetFusionType(@TypeName, out @OutValue);
                ptr_of_this_method = ILIntepreter.Minus(__esp, 1);

                switch (ptr_of_this_method->ObjectType)
                {
                    case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @OutValue;

                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType) ___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                            return ILIntepreter.PushObject(ptr_of_this_method, __mStack, ___obj);
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                        break;
                    case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if (___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = @OutValue;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @OutValue);
                        }
                    }
                        break;
                    case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if (___type is ILType)
                        {
                            ((ILType) ___type).StaticInstance[ptr_of_this_method->ValueLow] = @OutValue;
                        }
                        else
                        {
                            ((CLRType) ___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @OutValue);
                        }
                    }
                        break;
                    case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Component[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @OutValue;
                    }
                        break;
                }

                __intp.Free(ptr_of_this_method);
                ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
                __intp.Free(ptr_of_this_method);
                ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
                __intp.Free(ptr_of_this_method);
                __ret->ObjectType = ObjectTypes.Integer;
                __ret->Value = tmp_Result_of_this_method ? 1 : 0;
                return __ret + 1;
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
                throw;
            }
        }

        static StackObject* CopyStateToBackingFields_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyStateToBackingFields();

            return __ret;
        }


        static object get_FixedUpdateNetworkEvent_0(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour) o).FixedUpdateNetworkEvent;
        }

        static StackObject* CopyToStack_FixedUpdateNetworkEvent_0(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method =
                ((Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour) o).FixedUpdateNetworkEvent;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_FixedUpdateNetworkEvent_0(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour) o).FixedUpdateNetworkEvent =
                (UnityEngine.Events.UnityEvent) v;
        }

        static StackObject* AssignFromStack_FixedUpdateNetworkEvent_0(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent @FixedUpdateNetworkEvent =
                (UnityEngine.Events.UnityEvent) typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour) o).FixedUpdateNetworkEvent =
                @FixedUpdateNetworkEvent;
            return ptr_of_this_method;
        }

        static object get_SpawnedEvent_1(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour) o).SpawnedEvent;
        }

        static StackObject* CopyToStack_SpawnedEvent_1(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour) o).SpawnedEvent;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_SpawnedEvent_1(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour) o).SpawnedEvent =
                (UnityEngine.Events.UnityEvent) v;
        }

        static StackObject* AssignFromStack_SpawnedEvent_1(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent @SpawnedEvent =
                (UnityEngine.Events.UnityEvent) typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour) o).SpawnedEvent = @SpawnedEvent;
            return ptr_of_this_method;
        }

        static object get_DespawnedEvent_2(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour) o).DespawnedEvent;
        }

        static StackObject* CopyToStack_DespawnedEvent_2(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour) o).DespawnedEvent;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_DespawnedEvent_2(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour) o).DespawnedEvent =
                (UnityEngine.Events.UnityEvent<Fusion.NetworkRunner, System.Boolean>) v;
        }

        static StackObject* AssignFromStack_DespawnedEvent_2(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<Fusion.NetworkRunner, System.Boolean> @DespawnedEvent =
                (UnityEngine.Events.UnityEvent<Fusion.NetworkRunner, System.Boolean>)
                typeof(UnityEngine.Events.UnityEvent<Fusion.NetworkRunner, System.Boolean>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour) o).DespawnedEvent = @DespawnedEvent;
            return ptr_of_this_method;
        }

        static object get_RenderEvent_3(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour) o).RenderEvent;
        }

        static StackObject* CopyToStack_RenderEvent_3(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour) o).RenderEvent;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_RenderEvent_3(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour) o).RenderEvent =
                (UnityEngine.Events.UnityEvent) v;
        }


        static StackObject* GetInput(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            var ptr = __esp - 1;
            var instance = StackObject.ToObject(ptr, __domain, __mStack);
            if (instance == null)
                throw new System.NullReferenceException();
            __intp.Free(ptr);

            var genericArgument = __method.GenericArguments;
            if (genericArgument == null || genericArgument.Length != 1) return __esp;

            var type = genericArgument[0];
            object res = null;
            Debug.Log($"IL:{instance is Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour}");
            // if (instance is Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour tmp_NetworkBehaviour)
            // {
            //     if (type is CLRType)
            //     {
            //         res = Activator.CreateInstance(type.GetType());
            //         if (res is CrossBindingAdaptorType crossBindingAdaptorType)
            //         {
            //             res = crossBindingAdaptorType.ILInstance;
            //         }
            //     }
            //     else
            //     {
            //         res = Activator.CreateInstance(type.GetType());
            //     }
            // }


            return ILIntepreter.PushObject(ptr, __mStack, res);
        }

        static StackObject* AssignFromStack_RenderEvent_3(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent @RenderEvent =
                (UnityEngine.Events.UnityEvent) typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour) o).RenderEvent = @RenderEvent;
            return ptr_of_this_method;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.PhotonModule.Runtime.XRMODNetworkBehaviour();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}
#endif
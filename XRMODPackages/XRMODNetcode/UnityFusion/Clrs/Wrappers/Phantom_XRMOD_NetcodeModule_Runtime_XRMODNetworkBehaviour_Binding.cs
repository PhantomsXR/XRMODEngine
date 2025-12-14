using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
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
    unsafe class Phantom_XRMOD_NetcodeModule_Runtime_XRMODNetworkBehaviour_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour);
            args = new Type[] {typeof(System.String), typeof(System.Action<System.String, Unity.Netcode.RpcParams>)};
            method = type.GetMethod("RegisterRpcMethods", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterRpcMethods_0);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("OnDeferringDespawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnDeferringDespawn_1);
            args = new Type[] { };
            method = type.GetMethod("OnNetworkDespawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkDespawn_2);
            args = new Type[] { };
            method = type.GetMethod("OnDestroy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnDestroy_3);
            args = new Type[] { };
            method = type.GetMethod("OnGainedOwnership", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnGainedOwnership_4);
            args = new Type[] { };
            method = type.GetMethod("OnLostOwnership", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnLostOwnership_5);
            args = new Type[] {typeof(Unity.Netcode.NetworkObject)};
            method = type.GetMethod("OnNetworkObjectParentChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkObjectParentChanged_6);
            args = new Type[] { };
            method = type.GetMethod("OnNetworkSpawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkSpawn_7);
            args = new Type[] {typeof(System.Double)};
            method = type.GetMethod("OnReanticipate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnReanticipate_8);
            args = new Type[] {typeof(System.String), typeof(System.String), typeof(Unity.Netcode.RpcParams)};
            method = type.GetMethod("SendToServerRpc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendToServerRpc_9);
            args = new Type[] {typeof(System.String), typeof(System.String), typeof(Unity.Netcode.RpcParams)};
            method = type.GetMethod("SendToAuthorityRpc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendToAuthorityRpc_10);
            args = new Type[] {typeof(System.String), typeof(System.String), typeof(Unity.Netcode.RpcParams)};
            method = type.GetMethod("SendToMeRpc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendToMeRpc_11);
            args = new Type[] {typeof(System.String), typeof(System.String), typeof(Unity.Netcode.RpcParams)};
            method = type.GetMethod("SendToEveryoneRpc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendToEveryoneRpc_12);
            args = new Type[] {typeof(System.String), typeof(System.String), typeof(Unity.Netcode.RpcParams)};
            method = type.GetMethod("SendToOwnerRpc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendToOwnerRpc_13);
            args = new Type[] {typeof(System.String), typeof(System.String), typeof(Unity.Netcode.RpcParams)};
            method = type.GetMethod("SendToNotAuthorityRpc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendToNotAuthorityRpc_14);
            args = new Type[] {typeof(System.String), typeof(System.String), typeof(Unity.Netcode.RpcParams)};
            method = type.GetMethod("SendToNotMeRpc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendToNotMeRpc_15);
            args = new Type[] {typeof(System.String), typeof(System.String), typeof(Unity.Netcode.RpcParams)};
            method = type.GetMethod("SendToNotOwnerRpc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendToNotOwnerRpc_16);
            args = new Type[] {typeof(System.String), typeof(System.String), typeof(Unity.Netcode.RpcParams)};
            method = type.GetMethod("SendToNotServerRpc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendToNotServerRpc_17);
            args = new Type[] {typeof(System.String), typeof(System.String), typeof(Unity.Netcode.RpcParams)};
            method = type.GetMethod("SendToClientsAndHostRpc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendToClientsAndHostRpc_18);

            args = new Type[]
            {
                typeof(System.String), typeof(Phantom.XRMOD.NetcodeModule.Runtime.BaseNetworkVariable).MakeByRefType()
            };
            method = type.GetMethod("TryGetNetworkVariable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetNetworkVariable_0);

            field = type.GetField("OnDeferringDespawnEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnDeferringDespawnEvent_0);
            app.RegisterCLRFieldSetter(field, set_OnDeferringDespawnEvent_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnDeferringDespawnEvent_0,
                AssignFromStack_OnDeferringDespawnEvent_0);
            field = type.GetField("OnNetworkDespawnEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnNetworkDespawnEvent_1);
            app.RegisterCLRFieldSetter(field, set_OnNetworkDespawnEvent_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnNetworkDespawnEvent_1,
                AssignFromStack_OnNetworkDespawnEvent_1);
            field = type.GetField("OnDestroyEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnDestroyEvent_2);
            app.RegisterCLRFieldSetter(field, set_OnDestroyEvent_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnDestroyEvent_2, AssignFromStack_OnDestroyEvent_2);
            field = type.GetField("OnGainedOwnershipEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnGainedOwnershipEvent_3);
            app.RegisterCLRFieldSetter(field, set_OnGainedOwnershipEvent_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnGainedOwnershipEvent_3,
                AssignFromStack_OnGainedOwnershipEvent_3);
            field = type.GetField("OnInSceneObjectsSpawnedEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnInSceneObjectsSpawnedEvent_4);
            app.RegisterCLRFieldSetter(field, set_OnInSceneObjectsSpawnedEvent_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnInSceneObjectsSpawnedEvent_4,
                AssignFromStack_OnInSceneObjectsSpawnedEvent_4);
            field = type.GetField("OnLostOwnershipEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnLostOwnershipEvent_5);
            app.RegisterCLRFieldSetter(field, set_OnLostOwnershipEvent_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnLostOwnershipEvent_5,
                AssignFromStack_OnLostOwnershipEvent_5);
            field = type.GetField("OnNetworkPostSpawnEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnNetworkPostSpawnEvent_6);
            app.RegisterCLRFieldSetter(field, set_OnNetworkPostSpawnEvent_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnNetworkPostSpawnEvent_6,
                AssignFromStack_OnNetworkPostSpawnEvent_6);
            field = type.GetField("OnNetworkPreSpawnEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnNetworkPreSpawnEvent_7);
            app.RegisterCLRFieldSetter(field, set_OnNetworkPreSpawnEvent_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnNetworkPreSpawnEvent_7,
                AssignFromStack_OnNetworkPreSpawnEvent_7);
            field = type.GetField("OnNetworkObjectParentChangedEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnNetworkObjectParentChangedEvent_8);
            app.RegisterCLRFieldSetter(field, set_OnNetworkObjectParentChangedEvent_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnNetworkObjectParentChangedEvent_8,
                AssignFromStack_OnNetworkObjectParentChangedEvent_8);
            field = type.GetField("OnNetworkSessionSynchronizedEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnNetworkSessionSynchronizedEvent_9);
            app.RegisterCLRFieldSetter(field, set_OnNetworkSessionSynchronizedEvent_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnNetworkSessionSynchronizedEvent_9,
                AssignFromStack_OnNetworkSessionSynchronizedEvent_9);
            field = type.GetField("OnOwnershipChangedEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnOwnershipChangedEvent_10);
            app.RegisterCLRFieldSetter(field, set_OnOwnershipChangedEvent_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnOwnershipChangedEvent_10,
                AssignFromStack_OnOwnershipChangedEvent_10);
            field = type.GetField("OnReanticipateEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnReanticipateEvent_11);
            app.RegisterCLRFieldSetter(field, set_OnReanticipateEvent_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnReanticipateEvent_11,
                AssignFromStack_OnReanticipateEvent_11);
            field = type.GetField("OnNetworkSpawnEvent", flag);
            app.RegisterCLRFieldGetter(field, get_OnNetworkSpawnEvent_12);
            app.RegisterCLRFieldSetter(field, set_OnNetworkSpawnEvent_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnNetworkSpawnEvent_12,
                AssignFromStack_OnNetworkSpawnEvent_12);
            field = type.GetField("OnUpdate", flag);
            app.RegisterCLRFieldGetter(field, get_OnUpdate_13);
            app.RegisterCLRFieldSetter(field, set_OnUpdate_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnUpdate_13, AssignFromStack_OnUpdate_13);
            field = type.GetField("OnFixedUpdate", flag);
            app.RegisterCLRFieldGetter(field, get_OnFixedUpdate_14);
            app.RegisterCLRFieldSetter(field, set_OnFixedUpdate_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnFixedUpdate_14, AssignFromStack_OnFixedUpdate_14);

            app.RegisterCLRCreateDefaultInstance(type,
                () => new Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour());
            app.RegisterCLRCreateArrayInstance(type,
                s => new Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour[s]);

            args = new Type[] { };
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }

        static StackObject* TryGetNetworkVariable_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.BaseNetworkVariable @_networkVariable =
                (Phantom.XRMOD.NetcodeModule.Runtime.BaseNetworkVariable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.BaseNetworkVariable).CheckCLRTypes(
                    __intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_key = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);

          
            var result_of_this_method = instance_of_this_method.TryGetNetworkVariable(@_key, out @_networkVariable);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch (ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                {
                    var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                    object ___obj = @_networkVariable;
                    if (___dst->ObjectType >= ObjectTypes.Object)
                    {
                        if (___obj is CrossBindingAdaptorType)
                            ___obj = ((CrossBindingAdaptorType) ___obj).ILInstance;
                        __mStack[___dst->Value] = ___obj;
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
                        ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = @_networkVariable;
                    }
                    else
                    {
                        var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                        ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @_networkVariable);
                    }
                }
                    break;
                case ObjectTypes.StaticFieldReference:
                {
                    var ___type = __domain.GetType(ptr_of_this_method->Value);
                    if (___type is ILType)
                    {
                        ((ILType) ___type).StaticInstance[ptr_of_this_method->ValueLow] = @_networkVariable;
                    }
                    else
                    {
                        ((CLRType) ___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @_networkVariable);
                    }
                }
                    break;
                case ObjectTypes.ArrayReference:
                {
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as Phantom.XRMOD.NetcodeModule.Runtime.BaseNetworkVariable
                            [];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = @_networkVariable;
                }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static StackObject* RegisterRpcMethods_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.String, Unity.Netcode.RpcParams> @_action =
                (System.Action<System.String, Unity.Netcode.RpcParams>)
                typeof(System.Action<System.String, Unity.Netcode.RpcParams>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_key = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RegisterRpcMethods(@_key, @_action);

            return __ret;
        }

        static StackObject* OnDeferringDespawn_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @despawnTick = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnDeferringDespawn(@despawnTick);

            return __ret;
        }

        static StackObject* OnNetworkDespawn_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkDespawn();

            return __ret;
        }

        static StackObject* OnDestroy_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnDestroy();

            return __ret;
        }

        static StackObject* OnGainedOwnership_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnGainedOwnership();

            return __ret;
        }

        static StackObject* OnLostOwnership_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnLostOwnership();

            return __ret;
        }

        static StackObject* OnNetworkObjectParentChanged_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkObject @parentNetworkObject =
                (Unity.Netcode.NetworkObject) typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkObjectParentChanged(@parentNetworkObject);

            return __ret;
        }

        static StackObject* OnNetworkSpawn_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkSpawn();

            return __ret;
        }

        static StackObject* OnReanticipate_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @_lastRoundTripTime = *(double*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnReanticipate(@_lastRoundTripTime);

            return __ret;
        }

        static StackObject* SendToServerRpc_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.RpcParams @_rpcParams =
                (Unity.Netcode.RpcParams) typeof(Unity.Netcode.RpcParams).CheckCLRTypes(
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
            Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SendToServerRpc(@_key, @_data, @_rpcParams);

            return __ret;
        }

        static StackObject* SendToAuthorityRpc_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.RpcParams @_rpcParams =
                (Unity.Netcode.RpcParams) typeof(Unity.Netcode.RpcParams).CheckCLRTypes(
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
            Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SendToAuthorityRpc(@_key, @_data, @_rpcParams);

            return __ret;
        }

        static StackObject* SendToMeRpc_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.RpcParams @_rpcParams =
                (Unity.Netcode.RpcParams) typeof(Unity.Netcode.RpcParams).CheckCLRTypes(
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
            Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SendToMeRpc(@_key, @_data, @_rpcParams);

            return __ret;
        }

        static StackObject* SendToEveryoneRpc_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.RpcParams @_rpcParams =
                (Unity.Netcode.RpcParams) typeof(Unity.Netcode.RpcParams).CheckCLRTypes(
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
            Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SendToEveryoneRpc(@_key, @_data, @_rpcParams);

            return __ret;
        }

        static StackObject* SendToOwnerRpc_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.RpcParams @_rpcParams =
                (Unity.Netcode.RpcParams) typeof(Unity.Netcode.RpcParams).CheckCLRTypes(
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
            Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SendToOwnerRpc(@_key, @_data, @_rpcParams);

            return __ret;
        }

        static StackObject* SendToNotAuthorityRpc_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.RpcParams @_rpcParams =
                (Unity.Netcode.RpcParams) typeof(Unity.Netcode.RpcParams).CheckCLRTypes(
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
            Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SendToNotAuthorityRpc(@_key, @_data, @_rpcParams);

            return __ret;
        }

        static StackObject* SendToNotMeRpc_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.RpcParams @_rpcParams =
                (Unity.Netcode.RpcParams) typeof(Unity.Netcode.RpcParams).CheckCLRTypes(
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
            Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SendToNotMeRpc(@_key, @_data, @_rpcParams);

            return __ret;
        }

        static StackObject* SendToNotOwnerRpc_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.RpcParams @_rpcParams =
                (Unity.Netcode.RpcParams) typeof(Unity.Netcode.RpcParams).CheckCLRTypes(
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
            Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SendToNotOwnerRpc(@_key, @_data, @_rpcParams);

            return __ret;
        }

        static StackObject* SendToNotServerRpc_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.RpcParams @_rpcParams =
                (Unity.Netcode.RpcParams) typeof(Unity.Netcode.RpcParams).CheckCLRTypes(
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
            Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SendToNotServerRpc(@_key, @_data, @_rpcParams);

            return __ret;
        }

        static StackObject* SendToClientsAndHostRpc_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.RpcParams @_rpcParams =
                (Unity.Netcode.RpcParams) typeof(Unity.Netcode.RpcParams).CheckCLRTypes(
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
            Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SendToClientsAndHostRpc(@_key, @_data, @_rpcParams);

            return __ret;
        }


        static object get_OnDeferringDespawnEvent_0(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnDeferringDespawnEvent;
        }

        static StackObject* CopyToStack_OnDeferringDespawnEvent_0(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method =
                ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnDeferringDespawnEvent;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnDeferringDespawnEvent_0(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnDeferringDespawnEvent =
                (UnityEngine.Events.UnityEvent<System.Int32>) v;
        }

        static StackObject* AssignFromStack_OnDeferringDespawnEvent_0(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<System.Int32> @OnDeferringDespawnEvent =
                (UnityEngine.Events.UnityEvent<System.Int32>) typeof(UnityEngine.Events.UnityEvent<System.Int32>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnDeferringDespawnEvent =
                @OnDeferringDespawnEvent;
            return ptr_of_this_method;
        }

        static object get_OnNetworkDespawnEvent_1(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkDespawnEvent;
        }

        static StackObject* CopyToStack_OnNetworkDespawnEvent_1(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method =
                ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkDespawnEvent;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnNetworkDespawnEvent_1(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkDespawnEvent =
                (UnityEngine.Events.UnityEvent) v;
        }

        static StackObject* AssignFromStack_OnNetworkDespawnEvent_1(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent @OnNetworkDespawnEvent =
                (UnityEngine.Events.UnityEvent) typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkDespawnEvent =
                @OnNetworkDespawnEvent;
            return ptr_of_this_method;
        }

        static object get_OnDestroyEvent_2(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnDestroyEvent;
        }

        static StackObject* CopyToStack_OnDestroyEvent_2(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnDestroyEvent;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnDestroyEvent_2(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnDestroyEvent =
                (UnityEngine.Events.UnityEvent) v;
        }

        static StackObject* AssignFromStack_OnDestroyEvent_2(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent @OnDestroyEvent =
                (UnityEngine.Events.UnityEvent) typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnDestroyEvent = @OnDestroyEvent;
            return ptr_of_this_method;
        }

        static object get_OnGainedOwnershipEvent_3(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnGainedOwnershipEvent;
        }

        static StackObject* CopyToStack_OnGainedOwnershipEvent_3(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method =
                ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnGainedOwnershipEvent;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnGainedOwnershipEvent_3(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnGainedOwnershipEvent =
                (UnityEngine.Events.UnityEvent) v;
        }

        static StackObject* AssignFromStack_OnGainedOwnershipEvent_3(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent @OnGainedOwnershipEvent =
                (UnityEngine.Events.UnityEvent) typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnGainedOwnershipEvent =
                @OnGainedOwnershipEvent;
            return ptr_of_this_method;
        }

        static object get_OnInSceneObjectsSpawnedEvent_4(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnInSceneObjectsSpawnedEvent;
        }

        static StackObject* CopyToStack_OnInSceneObjectsSpawnedEvent_4(ref object o, ILIntepreter __intp,
            StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o)
                .OnInSceneObjectsSpawnedEvent;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnInSceneObjectsSpawnedEvent_4(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnInSceneObjectsSpawnedEvent =
                (UnityEngine.Events.UnityEvent) v;
        }

        static StackObject* AssignFromStack_OnInSceneObjectsSpawnedEvent_4(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent @OnInSceneObjectsSpawnedEvent =
                (UnityEngine.Events.UnityEvent) typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnInSceneObjectsSpawnedEvent =
                @OnInSceneObjectsSpawnedEvent;
            return ptr_of_this_method;
        }

        static object get_OnLostOwnershipEvent_5(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnLostOwnershipEvent;
        }

        static StackObject* CopyToStack_OnLostOwnershipEvent_5(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method =
                ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnLostOwnershipEvent;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnLostOwnershipEvent_5(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnLostOwnershipEvent =
                (UnityEngine.Events.UnityEvent) v;
        }

        static StackObject* AssignFromStack_OnLostOwnershipEvent_5(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent @OnLostOwnershipEvent =
                (UnityEngine.Events.UnityEvent) typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnLostOwnershipEvent =
                @OnLostOwnershipEvent;
            return ptr_of_this_method;
        }

        static object get_OnNetworkPostSpawnEvent_6(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkPostSpawnEvent;
        }

        static StackObject* CopyToStack_OnNetworkPostSpawnEvent_6(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method =
                ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkPostSpawnEvent;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnNetworkPostSpawnEvent_6(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkPostSpawnEvent =
                (UnityEngine.Events.UnityEvent) v;
        }

        static StackObject* AssignFromStack_OnNetworkPostSpawnEvent_6(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent @OnNetworkPostSpawnEvent =
                (UnityEngine.Events.UnityEvent) typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkPostSpawnEvent =
                @OnNetworkPostSpawnEvent;
            return ptr_of_this_method;
        }

        static object get_OnNetworkPreSpawnEvent_7(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkPreSpawnEvent;
        }

        static StackObject* CopyToStack_OnNetworkPreSpawnEvent_7(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method =
                ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkPreSpawnEvent;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnNetworkPreSpawnEvent_7(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkPreSpawnEvent =
                (UnityEngine.Events.UnityEvent<Unity.Netcode.NetworkManager>) v;
        }

        static StackObject* AssignFromStack_OnNetworkPreSpawnEvent_7(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<Unity.Netcode.NetworkManager> @OnNetworkPreSpawnEvent =
                (UnityEngine.Events.UnityEvent<Unity.Netcode.NetworkManager>)
                typeof(UnityEngine.Events.UnityEvent<Unity.Netcode.NetworkManager>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkPreSpawnEvent =
                @OnNetworkPreSpawnEvent;
            return ptr_of_this_method;
        }

        static object get_OnNetworkObjectParentChangedEvent_8(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkObjectParentChangedEvent;
        }

        static StackObject* CopyToStack_OnNetworkObjectParentChangedEvent_8(ref object o, ILIntepreter __intp,
            StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o)
                .OnNetworkObjectParentChangedEvent;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnNetworkObjectParentChangedEvent_8(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkObjectParentChangedEvent =
                (UnityEngine.Events.UnityEvent<Unity.Netcode.NetworkObject>) v;
        }

        static StackObject* AssignFromStack_OnNetworkObjectParentChangedEvent_8(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<Unity.Netcode.NetworkObject> @OnNetworkObjectParentChangedEvent =
                (UnityEngine.Events.UnityEvent<Unity.Netcode.NetworkObject>)
                typeof(UnityEngine.Events.UnityEvent<Unity.Netcode.NetworkObject>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkObjectParentChangedEvent =
                @OnNetworkObjectParentChangedEvent;
            return ptr_of_this_method;
        }

        static object get_OnNetworkSessionSynchronizedEvent_9(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkSessionSynchronizedEvent;
        }

        static StackObject* CopyToStack_OnNetworkSessionSynchronizedEvent_9(ref object o, ILIntepreter __intp,
            StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o)
                .OnNetworkSessionSynchronizedEvent;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnNetworkSessionSynchronizedEvent_9(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkSessionSynchronizedEvent =
                (UnityEngine.Events.UnityEvent) v;
        }

        static StackObject* AssignFromStack_OnNetworkSessionSynchronizedEvent_9(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent @OnNetworkSessionSynchronizedEvent =
                (UnityEngine.Events.UnityEvent) typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkSessionSynchronizedEvent =
                @OnNetworkSessionSynchronizedEvent;
            return ptr_of_this_method;
        }

        static object get_OnOwnershipChangedEvent_10(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnOwnershipChangedEvent;
        }

        static StackObject* CopyToStack_OnOwnershipChangedEvent_10(ref object o, ILIntepreter __intp,
            StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method =
                ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnOwnershipChangedEvent;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnOwnershipChangedEvent_10(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnOwnershipChangedEvent =
                (UnityEngine.Events.UnityEvent<System.UInt64, System.UInt64>) v;
        }

        static StackObject* AssignFromStack_OnOwnershipChangedEvent_10(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<System.UInt64, System.UInt64> @OnOwnershipChangedEvent =
                (UnityEngine.Events.UnityEvent<System.UInt64, System.UInt64>)
                typeof(UnityEngine.Events.UnityEvent<System.UInt64, System.UInt64>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnOwnershipChangedEvent =
                @OnOwnershipChangedEvent;
            return ptr_of_this_method;
        }

        static object get_OnReanticipateEvent_11(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnReanticipateEvent;
        }

        static StackObject* CopyToStack_OnReanticipateEvent_11(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method =
                ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnReanticipateEvent;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnReanticipateEvent_11(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnReanticipateEvent =
                (UnityEngine.Events.UnityEvent<System.Double>) v;
        }

        static StackObject* AssignFromStack_OnReanticipateEvent_11(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<System.Double> @OnReanticipateEvent =
                (UnityEngine.Events.UnityEvent<System.Double>) typeof(UnityEngine.Events.UnityEvent<System.Double>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnReanticipateEvent = @OnReanticipateEvent;
            return ptr_of_this_method;
        }

        static object get_OnNetworkSpawnEvent_12(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkSpawnEvent;
        }

        static StackObject* CopyToStack_OnNetworkSpawnEvent_12(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method =
                ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkSpawnEvent;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnNetworkSpawnEvent_12(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkSpawnEvent =
                (UnityEngine.Events.UnityEvent) v;
        }

        static StackObject* AssignFromStack_OnNetworkSpawnEvent_12(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent @OnNetworkSpawnEvent =
                (UnityEngine.Events.UnityEvent) typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnNetworkSpawnEvent = @OnNetworkSpawnEvent;
            return ptr_of_this_method;
        }

        static object get_OnUpdate_13(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnUpdate;
        }

        static StackObject* CopyToStack_OnUpdate_13(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnUpdate;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnUpdate_13(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnUpdate =
                (UnityEngine.Events.UnityEvent) v;
        }

        static StackObject* AssignFromStack_OnUpdate_13(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent @OnUpdate =
                (UnityEngine.Events.UnityEvent) typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnUpdate = @OnUpdate;
            return ptr_of_this_method;
        }

        static object get_OnFixedUpdate_14(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnFixedUpdate;
        }

        static StackObject* CopyToStack_OnFixedUpdate_14(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnFixedUpdate;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnFixedUpdate_14(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnFixedUpdate =
                (UnityEngine.Events.UnityEvent) v;
        }

        static StackObject* AssignFromStack_OnFixedUpdate_14(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent @OnFixedUpdate =
                (UnityEngine.Events.UnityEvent) typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour) o).OnFixedUpdate = @OnFixedUpdate;
            return ptr_of_this_method;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.NetcodeModule.Runtime.XRMODNetworkBehaviour();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}
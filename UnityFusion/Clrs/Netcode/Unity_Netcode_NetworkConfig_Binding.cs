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
    unsafe class Unity_Netcode_NetworkConfig_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Netcode.NetworkConfig);
            args = new Type[]{};
            method = type.GetMethod("ToBase64", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToBase64_0);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("FromBase64", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FromBase64_1);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("GetConfig", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetConfig_2);
            args = new Type[]{typeof(System.UInt64)};
            method = type.GetMethod("CompareConfig", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CompareConfig_3);

            field = type.GetField("ProtocolVersion", flag);
            app.RegisterCLRFieldGetter(field, get_ProtocolVersion_0);
            app.RegisterCLRFieldSetter(field, set_ProtocolVersion_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_ProtocolVersion_0, AssignFromStack_ProtocolVersion_0);
            field = type.GetField("NetworkTransport", flag);
            app.RegisterCLRFieldGetter(field, get_NetworkTransport_1);
            app.RegisterCLRFieldSetter(field, set_NetworkTransport_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_NetworkTransport_1, AssignFromStack_NetworkTransport_1);
            field = type.GetField("PlayerPrefab", flag);
            app.RegisterCLRFieldGetter(field, get_PlayerPrefab_2);
            app.RegisterCLRFieldSetter(field, set_PlayerPrefab_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_PlayerPrefab_2, AssignFromStack_PlayerPrefab_2);
            field = type.GetField("Prefabs", flag);
            app.RegisterCLRFieldGetter(field, get_Prefabs_3);
            app.RegisterCLRFieldSetter(field, set_Prefabs_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Prefabs_3, AssignFromStack_Prefabs_3);
            field = type.GetField("TickRate", flag);
            app.RegisterCLRFieldGetter(field, get_TickRate_4);
            app.RegisterCLRFieldSetter(field, set_TickRate_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_TickRate_4, AssignFromStack_TickRate_4);
            field = type.GetField("ClientConnectionBufferTimeout", flag);
            app.RegisterCLRFieldGetter(field, get_ClientConnectionBufferTimeout_5);
            app.RegisterCLRFieldSetter(field, set_ClientConnectionBufferTimeout_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientConnectionBufferTimeout_5, AssignFromStack_ClientConnectionBufferTimeout_5);
            field = type.GetField("ConnectionApproval", flag);
            app.RegisterCLRFieldGetter(field, get_ConnectionApproval_6);
            app.RegisterCLRFieldSetter(field, set_ConnectionApproval_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_ConnectionApproval_6, AssignFromStack_ConnectionApproval_6);
            field = type.GetField("ConnectionData", flag);
            app.RegisterCLRFieldGetter(field, get_ConnectionData_7);
            app.RegisterCLRFieldSetter(field, set_ConnectionData_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_ConnectionData_7, AssignFromStack_ConnectionData_7);
            field = type.GetField("EnableTimeResync", flag);
            app.RegisterCLRFieldGetter(field, get_EnableTimeResync_8);
            app.RegisterCLRFieldSetter(field, set_EnableTimeResync_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_EnableTimeResync_8, AssignFromStack_EnableTimeResync_8);
            field = type.GetField("TimeResyncInterval", flag);
            app.RegisterCLRFieldGetter(field, get_TimeResyncInterval_9);
            app.RegisterCLRFieldSetter(field, set_TimeResyncInterval_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_TimeResyncInterval_9, AssignFromStack_TimeResyncInterval_9);
            field = type.GetField("EnsureNetworkVariableLengthSafety", flag);
            app.RegisterCLRFieldGetter(field, get_EnsureNetworkVariableLengthSafety_10);
            app.RegisterCLRFieldSetter(field, set_EnsureNetworkVariableLengthSafety_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_EnsureNetworkVariableLengthSafety_10, AssignFromStack_EnsureNetworkVariableLengthSafety_10);
            field = type.GetField("EnableSceneManagement", flag);
            app.RegisterCLRFieldGetter(field, get_EnableSceneManagement_11);
            app.RegisterCLRFieldSetter(field, set_EnableSceneManagement_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_EnableSceneManagement_11, AssignFromStack_EnableSceneManagement_11);
            field = type.GetField("ForceSamePrefabs", flag);
            app.RegisterCLRFieldGetter(field, get_ForceSamePrefabs_12);
            app.RegisterCLRFieldSetter(field, set_ForceSamePrefabs_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_ForceSamePrefabs_12, AssignFromStack_ForceSamePrefabs_12);
            field = type.GetField("RecycleNetworkIds", flag);
            app.RegisterCLRFieldGetter(field, get_RecycleNetworkIds_13);
            app.RegisterCLRFieldSetter(field, set_RecycleNetworkIds_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_RecycleNetworkIds_13, AssignFromStack_RecycleNetworkIds_13);
            field = type.GetField("NetworkIdRecycleDelay", flag);
            app.RegisterCLRFieldGetter(field, get_NetworkIdRecycleDelay_14);
            app.RegisterCLRFieldSetter(field, set_NetworkIdRecycleDelay_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_NetworkIdRecycleDelay_14, AssignFromStack_NetworkIdRecycleDelay_14);
            field = type.GetField("RpcHashSize", flag);
            app.RegisterCLRFieldGetter(field, get_RpcHashSize_15);
            app.RegisterCLRFieldSetter(field, set_RpcHashSize_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_RpcHashSize_15, AssignFromStack_RpcHashSize_15);
            field = type.GetField("LoadSceneTimeOut", flag);
            app.RegisterCLRFieldGetter(field, get_LoadSceneTimeOut_16);
            app.RegisterCLRFieldSetter(field, set_LoadSceneTimeOut_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_LoadSceneTimeOut_16, AssignFromStack_LoadSceneTimeOut_16);
            field = type.GetField("SpawnTimeout", flag);
            app.RegisterCLRFieldGetter(field, get_SpawnTimeout_17);
            app.RegisterCLRFieldSetter(field, set_SpawnTimeout_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_SpawnTimeout_17, AssignFromStack_SpawnTimeout_17);
            field = type.GetField("EnableNetworkLogs", flag);
            app.RegisterCLRFieldGetter(field, get_EnableNetworkLogs_18);
            app.RegisterCLRFieldSetter(field, set_EnableNetworkLogs_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_EnableNetworkLogs_18, AssignFromStack_EnableNetworkLogs_18);
            field = type.GetField("RttAverageSamples", flag);
            app.RegisterCLRFieldGetter(field, get_RttAverageSamples_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_RttAverageSamples_19, null);
            field = type.GetField("RttWindowSize", flag);
            app.RegisterCLRFieldGetter(field, get_RttWindowSize_20);
            app.RegisterCLRFieldBinding(field, CopyToStack_RttWindowSize_20, null);
            field = type.GetField("NetworkTopology", flag);
            app.RegisterCLRFieldGetter(field, get_NetworkTopology_21);
            app.RegisterCLRFieldSetter(field, set_NetworkTopology_21);
            app.RegisterCLRFieldBinding(field, CopyToStack_NetworkTopology_21, AssignFromStack_NetworkTopology_21);
            field = type.GetField("UseCMBService", flag);
            app.RegisterCLRFieldGetter(field, get_UseCMBService_22);
            app.RegisterCLRFieldSetter(field, set_UseCMBService_22);
            app.RegisterCLRFieldBinding(field, CopyToStack_UseCMBService_22, AssignFromStack_UseCMBService_22);
            field = type.GetField("AutoSpawnPlayerPrefabClientSide", flag);
            app.RegisterCLRFieldGetter(field, get_AutoSpawnPlayerPrefabClientSide_23);
            app.RegisterCLRFieldSetter(field, set_AutoSpawnPlayerPrefabClientSide_23);
            app.RegisterCLRFieldBinding(field, CopyToStack_AutoSpawnPlayerPrefabClientSide_23, AssignFromStack_AutoSpawnPlayerPrefabClientSide_23);
            field = type.GetField("NetworkProfilingMetrics", flag);
            app.RegisterCLRFieldGetter(field, get_NetworkProfilingMetrics_24);
            app.RegisterCLRFieldSetter(field, set_NetworkProfilingMetrics_24);
            app.RegisterCLRFieldBinding(field, CopyToStack_NetworkProfilingMetrics_24, AssignFromStack_NetworkProfilingMetrics_24);


            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.Netcode.NetworkConfig());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Netcode.NetworkConfig[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* ToBase64_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkConfig instance_of_this_method = (Unity.Netcode.NetworkConfig)typeof(Unity.Netcode.NetworkConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ToBase64();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* FromBase64_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @base64 = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkConfig instance_of_this_method = (Unity.Netcode.NetworkConfig)typeof(Unity.Netcode.NetworkConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.FromBase64(@base64);

            return __ret;
        }

        static StackObject* GetConfig_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @cache = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkConfig instance_of_this_method = (Unity.Netcode.NetworkConfig)typeof(Unity.Netcode.NetworkConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetConfig(@cache);

            __ret->ObjectType = ObjectTypes.Long;
            *(ulong*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* CompareConfig_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @hash = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkConfig instance_of_this_method = (Unity.Netcode.NetworkConfig)typeof(Unity.Netcode.NetworkConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CompareConfig(@hash);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static object get_ProtocolVersion_0(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).ProtocolVersion;
        }

        static StackObject* CopyToStack_ProtocolVersion_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).ProtocolVersion;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_ProtocolVersion_0(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).ProtocolVersion = (System.UInt16)v;
        }

        static StackObject* AssignFromStack_ProtocolVersion_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.UInt16 @ProtocolVersion = (ushort)ptr_of_this_method->Value;
            ((Unity.Netcode.NetworkConfig)o).ProtocolVersion = @ProtocolVersion;
            return ptr_of_this_method;
        }

        static object get_NetworkTransport_1(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).NetworkTransport;
        }

        static StackObject* CopyToStack_NetworkTransport_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).NetworkTransport;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_NetworkTransport_1(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).NetworkTransport = (Unity.Netcode.NetworkTransport)v;
        }

        static StackObject* AssignFromStack_NetworkTransport_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.NetworkTransport @NetworkTransport = (Unity.Netcode.NetworkTransport)typeof(Unity.Netcode.NetworkTransport).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.NetworkConfig)o).NetworkTransport = @NetworkTransport;
            return ptr_of_this_method;
        }

        static object get_PlayerPrefab_2(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).PlayerPrefab;
        }

        static StackObject* CopyToStack_PlayerPrefab_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).PlayerPrefab;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PlayerPrefab_2(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).PlayerPrefab = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_PlayerPrefab_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @PlayerPrefab = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.NetworkConfig)o).PlayerPrefab = @PlayerPrefab;
            return ptr_of_this_method;
        }

        static object get_Prefabs_3(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).Prefabs;
        }

        static StackObject* CopyToStack_Prefabs_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).Prefabs;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Prefabs_3(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).Prefabs = (Unity.Netcode.NetworkPrefabs)v;
        }

        static StackObject* AssignFromStack_Prefabs_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.NetworkPrefabs @Prefabs = (Unity.Netcode.NetworkPrefabs)typeof(Unity.Netcode.NetworkPrefabs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.NetworkConfig)o).Prefabs = @Prefabs;
            return ptr_of_this_method;
        }

        static object get_TickRate_4(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).TickRate;
        }

        static StackObject* CopyToStack_TickRate_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).TickRate;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static void set_TickRate_4(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).TickRate = (System.UInt32)v;
        }

        static StackObject* AssignFromStack_TickRate_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.UInt32 @TickRate = (uint)ptr_of_this_method->Value;
            ((Unity.Netcode.NetworkConfig)o).TickRate = @TickRate;
            return ptr_of_this_method;
        }

        static object get_ClientConnectionBufferTimeout_5(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).ClientConnectionBufferTimeout;
        }

        static StackObject* CopyToStack_ClientConnectionBufferTimeout_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).ClientConnectionBufferTimeout;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_ClientConnectionBufferTimeout_5(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).ClientConnectionBufferTimeout = (System.Int32)v;
        }

        static StackObject* AssignFromStack_ClientConnectionBufferTimeout_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @ClientConnectionBufferTimeout = ptr_of_this_method->Value;
            ((Unity.Netcode.NetworkConfig)o).ClientConnectionBufferTimeout = @ClientConnectionBufferTimeout;
            return ptr_of_this_method;
        }

        static object get_ConnectionApproval_6(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).ConnectionApproval;
        }

        static StackObject* CopyToStack_ConnectionApproval_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).ConnectionApproval;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_ConnectionApproval_6(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).ConnectionApproval = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_ConnectionApproval_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @ConnectionApproval = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkConfig)o).ConnectionApproval = @ConnectionApproval;
            return ptr_of_this_method;
        }

        static object get_ConnectionData_7(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).ConnectionData;
        }

        static StackObject* CopyToStack_ConnectionData_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).ConnectionData;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ConnectionData_7(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).ConnectionData = (System.Byte[])v;
        }

        static StackObject* AssignFromStack_ConnectionData_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Byte[] @ConnectionData = (System.Byte[])typeof(System.Byte[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.NetworkConfig)o).ConnectionData = @ConnectionData;
            return ptr_of_this_method;
        }

        static object get_EnableTimeResync_8(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).EnableTimeResync;
        }

        static StackObject* CopyToStack_EnableTimeResync_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).EnableTimeResync;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_EnableTimeResync_8(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).EnableTimeResync = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_EnableTimeResync_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @EnableTimeResync = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkConfig)o).EnableTimeResync = @EnableTimeResync;
            return ptr_of_this_method;
        }

        static object get_TimeResyncInterval_9(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).TimeResyncInterval;
        }

        static StackObject* CopyToStack_TimeResyncInterval_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).TimeResyncInterval;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_TimeResyncInterval_9(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).TimeResyncInterval = (System.Int32)v;
        }

        static StackObject* AssignFromStack_TimeResyncInterval_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @TimeResyncInterval = ptr_of_this_method->Value;
            ((Unity.Netcode.NetworkConfig)o).TimeResyncInterval = @TimeResyncInterval;
            return ptr_of_this_method;
        }

        static object get_EnsureNetworkVariableLengthSafety_10(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).EnsureNetworkVariableLengthSafety;
        }

        static StackObject* CopyToStack_EnsureNetworkVariableLengthSafety_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).EnsureNetworkVariableLengthSafety;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_EnsureNetworkVariableLengthSafety_10(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).EnsureNetworkVariableLengthSafety = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_EnsureNetworkVariableLengthSafety_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @EnsureNetworkVariableLengthSafety = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkConfig)o).EnsureNetworkVariableLengthSafety = @EnsureNetworkVariableLengthSafety;
            return ptr_of_this_method;
        }

        static object get_EnableSceneManagement_11(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).EnableSceneManagement;
        }

        static StackObject* CopyToStack_EnableSceneManagement_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).EnableSceneManagement;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_EnableSceneManagement_11(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).EnableSceneManagement = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_EnableSceneManagement_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @EnableSceneManagement = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkConfig)o).EnableSceneManagement = @EnableSceneManagement;
            return ptr_of_this_method;
        }

        static object get_ForceSamePrefabs_12(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).ForceSamePrefabs;
        }

        static StackObject* CopyToStack_ForceSamePrefabs_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).ForceSamePrefabs;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_ForceSamePrefabs_12(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).ForceSamePrefabs = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_ForceSamePrefabs_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @ForceSamePrefabs = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkConfig)o).ForceSamePrefabs = @ForceSamePrefabs;
            return ptr_of_this_method;
        }

        static object get_RecycleNetworkIds_13(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).RecycleNetworkIds;
        }

        static StackObject* CopyToStack_RecycleNetworkIds_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).RecycleNetworkIds;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_RecycleNetworkIds_13(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).RecycleNetworkIds = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_RecycleNetworkIds_13(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @RecycleNetworkIds = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkConfig)o).RecycleNetworkIds = @RecycleNetworkIds;
            return ptr_of_this_method;
        }

        static object get_NetworkIdRecycleDelay_14(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).NetworkIdRecycleDelay;
        }

        static StackObject* CopyToStack_NetworkIdRecycleDelay_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).NetworkIdRecycleDelay;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_NetworkIdRecycleDelay_14(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).NetworkIdRecycleDelay = (System.Single)v;
        }

        static StackObject* AssignFromStack_NetworkIdRecycleDelay_14(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @NetworkIdRecycleDelay = *(float*)&ptr_of_this_method->Value;
            ((Unity.Netcode.NetworkConfig)o).NetworkIdRecycleDelay = @NetworkIdRecycleDelay;
            return ptr_of_this_method;
        }

        static object get_RpcHashSize_15(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).RpcHashSize;
        }

        static StackObject* CopyToStack_RpcHashSize_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).RpcHashSize;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_RpcHashSize_15(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).RpcHashSize = (Unity.Netcode.HashSize)v;
        }

        static StackObject* AssignFromStack_RpcHashSize_15(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.HashSize @RpcHashSize = (Unity.Netcode.HashSize)typeof(Unity.Netcode.HashSize).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Unity.Netcode.NetworkConfig)o).RpcHashSize = @RpcHashSize;
            return ptr_of_this_method;
        }

        static object get_LoadSceneTimeOut_16(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).LoadSceneTimeOut;
        }

        static StackObject* CopyToStack_LoadSceneTimeOut_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).LoadSceneTimeOut;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_LoadSceneTimeOut_16(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).LoadSceneTimeOut = (System.Int32)v;
        }

        static StackObject* AssignFromStack_LoadSceneTimeOut_16(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @LoadSceneTimeOut = ptr_of_this_method->Value;
            ((Unity.Netcode.NetworkConfig)o).LoadSceneTimeOut = @LoadSceneTimeOut;
            return ptr_of_this_method;
        }

        static object get_SpawnTimeout_17(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).SpawnTimeout;
        }

        static StackObject* CopyToStack_SpawnTimeout_17(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).SpawnTimeout;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_SpawnTimeout_17(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).SpawnTimeout = (System.Single)v;
        }

        static StackObject* AssignFromStack_SpawnTimeout_17(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @SpawnTimeout = *(float*)&ptr_of_this_method->Value;
            ((Unity.Netcode.NetworkConfig)o).SpawnTimeout = @SpawnTimeout;
            return ptr_of_this_method;
        }

        static object get_EnableNetworkLogs_18(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).EnableNetworkLogs;
        }

        static StackObject* CopyToStack_EnableNetworkLogs_18(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).EnableNetworkLogs;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_EnableNetworkLogs_18(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).EnableNetworkLogs = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_EnableNetworkLogs_18(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @EnableNetworkLogs = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkConfig)o).EnableNetworkLogs = @EnableNetworkLogs;
            return ptr_of_this_method;
        }

        static object get_RttAverageSamples_19(ref object o)
        {
            return Unity.Netcode.NetworkConfig.RttAverageSamples;
        }

        static StackObject* CopyToStack_RttAverageSamples_19(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.NetworkConfig.RttAverageSamples;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_RttWindowSize_20(ref object o)
        {
            return Unity.Netcode.NetworkConfig.RttWindowSize;
        }

        static StackObject* CopyToStack_RttWindowSize_20(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.NetworkConfig.RttWindowSize;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_NetworkTopology_21(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).NetworkTopology;
        }

        static StackObject* CopyToStack_NetworkTopology_21(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).NetworkTopology;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_NetworkTopology_21(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).NetworkTopology = (Unity.Netcode.NetworkTopologyTypes)v;
        }

        static StackObject* AssignFromStack_NetworkTopology_21(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.NetworkTopologyTypes @NetworkTopology = (Unity.Netcode.NetworkTopologyTypes)typeof(Unity.Netcode.NetworkTopologyTypes).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Unity.Netcode.NetworkConfig)o).NetworkTopology = @NetworkTopology;
            return ptr_of_this_method;
        }

        static object get_UseCMBService_22(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).UseCMBService;
        }

        static StackObject* CopyToStack_UseCMBService_22(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).UseCMBService;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_UseCMBService_22(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).UseCMBService = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_UseCMBService_22(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @UseCMBService = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkConfig)o).UseCMBService = @UseCMBService;
            return ptr_of_this_method;
        }

        static object get_AutoSpawnPlayerPrefabClientSide_23(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).AutoSpawnPlayerPrefabClientSide;
        }

        static StackObject* CopyToStack_AutoSpawnPlayerPrefabClientSide_23(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).AutoSpawnPlayerPrefabClientSide;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_AutoSpawnPlayerPrefabClientSide_23(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).AutoSpawnPlayerPrefabClientSide = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_AutoSpawnPlayerPrefabClientSide_23(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @AutoSpawnPlayerPrefabClientSide = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkConfig)o).AutoSpawnPlayerPrefabClientSide = @AutoSpawnPlayerPrefabClientSide;
            return ptr_of_this_method;
        }

        static object get_NetworkProfilingMetrics_24(ref object o)
        {
            return ((Unity.Netcode.NetworkConfig)o).NetworkProfilingMetrics;
        }

        static StackObject* CopyToStack_NetworkProfilingMetrics_24(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkConfig)o).NetworkProfilingMetrics;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_NetworkProfilingMetrics_24(ref object o, object v)
        {
            ((Unity.Netcode.NetworkConfig)o).NetworkProfilingMetrics = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_NetworkProfilingMetrics_24(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @NetworkProfilingMetrics = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkConfig)o).NetworkProfilingMetrics = @NetworkProfilingMetrics;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Unity.Netcode.NetworkConfig();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

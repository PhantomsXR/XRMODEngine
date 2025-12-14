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
    unsafe class Phantom_XRMOD_PhotonModule_Runtime_PhotonServerAPI_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI);
            args = new Type[]{};
            method = type.GetMethod("get_GetInstance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GetInstance_0);
            args = new Type[]{};
            method = type.GetMethod("get_LastCreatedClientIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_LastCreatedClientIndex_1);
            args = new Type[]{};
            method = type.GetMethod("get_GetNetworkRunner", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GetNetworkRunner_2);
            args = new Type[]{};
            method = type.GetMethod("get_GetNetworkEvents", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GetNetworkEvents_3);
            args = new Type[]{};
            method = type.GetMethod("get_Baker", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Baker_4);
            args = new Type[]{};
            method = type.GetMethod("get_IsConnected", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsConnected_5);
            args = new Type[]{};
            method = type.GetMethod("get_Ping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Ping_6);
            args = new Type[]{typeof(System.String), typeof(Fusion.SessionLobby)};
            method = type.GetMethod("JoinLobby", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, JoinLobby_7);
            args = new Type[]{typeof(System.String), typeof(System.String), typeof(Fusion.GameMode), typeof(System.Boolean), typeof(System.Collections.Generic.Dictionary<System.String, Fusion.SessionProperty>), typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("CreateOrJoinSession", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateOrJoinSession_8);
            args = new Type[]{typeof(System.String), typeof(Fusion.GameMode), typeof(System.Boolean), typeof(System.Collections.Generic.Dictionary<System.String, Fusion.SessionProperty>)};
            method = type.GetMethod("JoinRandomSession", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, JoinRandomSession_9);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("DisconnectAsync", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DisconnectAsync_10);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("RegisterNetworkPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterNetworkPrefab_11);
            args = new Type[]{typeof(Phantom.XRMOD.PhotonModule.Runtime.RegionEnum), typeof(Phantom.XRMOD.PhotonModule.Runtime.NetworkSettingConfig)};
            method = type.GetMethod("BuildNetworkConfig", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BuildNetworkConfig_12);
            args = new Type[]{};
            method = type.GetMethod("Dispose", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Dispose_13);

            field = type.GetField("OnGameStartCallback", flag);
            app.RegisterCLRFieldGetter(field, get_OnGameStartCallback_0);
            app.RegisterCLRFieldSetter(field, set_OnGameStartCallback_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnGameStartCallback_0, AssignFromStack_OnGameStartCallback_0);
            field = type.GetField("AlwaysShowStats", flag);
            app.RegisterCLRFieldGetter(field, get_AlwaysShowStats_1);
            app.RegisterCLRFieldSetter(field, set_AlwaysShowStats_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_AlwaysShowStats_1, AssignFromStack_AlwaysShowStats_1);


            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI[s]);


        }


        static StackObject* get_GetInstance_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI.GetInstance;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_LastCreatedClientIndex_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI)typeof(Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LastCreatedClientIndex;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_GetNetworkRunner_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI)typeof(Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetNetworkRunner;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_GetNetworkEvents_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI)typeof(Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetNetworkEvents;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Baker_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI)typeof(Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Baker;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_IsConnected_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI)typeof(Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsConnected;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_Ping_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI)typeof(Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Ping;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* JoinLobby_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.SessionLobby @_lobbyType = (Fusion.SessionLobby)typeof(Fusion.SessionLobby).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_lobbyId = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI)typeof(Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.JoinLobby(@_lobbyId, @_lobbyType);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateOrJoinSession_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @_isPublic = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @_maxPlayer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.Dictionary<System.String, Fusion.SessionProperty> @_customProperties = (System.Collections.Generic.Dictionary<System.String, Fusion.SessionProperty>)typeof(System.Collections.Generic.Dictionary<System.String, Fusion.SessionProperty>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean @_enableClientSessionCreation = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            Fusion.GameMode @_gameMode = (Fusion.GameMode)typeof(Fusion.GameMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.String @_sessionCode = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.String @_gameName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI)typeof(Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CreateOrJoinSession(@_gameName, @_sessionCode, @_gameMode, @_enableClientSessionCreation, @_customProperties, @_maxPlayer, @_isPublic);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* JoinRandomSession_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.Dictionary<System.String, Fusion.SessionProperty> @_sessionInfos = (System.Collections.Generic.Dictionary<System.String, Fusion.SessionProperty>)typeof(System.Collections.Generic.Dictionary<System.String, Fusion.SessionProperty>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @_enableClientSessionCreation = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.GameMode @_gameMode = (Fusion.GameMode)typeof(Fusion.GameMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String @_gameName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI)typeof(Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.JoinRandomSession(@_gameName, @_gameMode, @_enableClientSessionCreation, @_sessionInfos);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* DisconnectAsync_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @_reason = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI)typeof(Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DisconnectAsync(@_reason);

            return __ret;
        }

        static StackObject* RegisterNetworkPrefab_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @_prefab = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI)typeof(Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.RegisterNetworkPrefab(@_prefab);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* BuildNetworkConfig_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.PhotonModule.Runtime.NetworkSettingConfig @_config = (Phantom.XRMOD.PhotonModule.Runtime.NetworkSettingConfig)typeof(Phantom.XRMOD.PhotonModule.Runtime.NetworkSettingConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.PhotonModule.Runtime.RegionEnum @_region = (Phantom.XRMOD.PhotonModule.Runtime.RegionEnum)typeof(Phantom.XRMOD.PhotonModule.Runtime.RegionEnum).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI)typeof(Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.BuildNetworkConfig(@_region, @_config);

            return __ret;
        }

        static StackObject* Dispose_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI)typeof(Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Dispose();

            return __ret;
        }


        static object get_OnGameStartCallback_0(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI)o).OnGameStartCallback;
        }

        static StackObject* CopyToStack_OnGameStartCallback_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI)o).OnGameStartCallback;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnGameStartCallback_0(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI)o).OnGameStartCallback = (System.Action<Fusion.NetworkRunner>)v;
        }

        static StackObject* AssignFromStack_OnGameStartCallback_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<Fusion.NetworkRunner> @OnGameStartCallback = (System.Action<Fusion.NetworkRunner>)typeof(System.Action<Fusion.NetworkRunner>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI)o).OnGameStartCallback = @OnGameStartCallback;
            return ptr_of_this_method;
        }

        static object get_AlwaysShowStats_1(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI)o).AlwaysShowStats;
        }

        static StackObject* CopyToStack_AlwaysShowStats_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI)o).AlwaysShowStats;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_AlwaysShowStats_1(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI)o).AlwaysShowStats = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_AlwaysShowStats_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @AlwaysShowStats = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.PhotonModule.Runtime.PhotonServerAPI)o).AlwaysShowStats = @AlwaysShowStats;
            return ptr_of_this_method;
        }




    }
}

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
    unsafe class Fusion_FusionBootstrap_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.FusionBootstrap);
            args = new Type[]{};
            method = type.GetMethod("get_CurrentStage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_CurrentStage_0);
            args = new Type[]{};
            method = type.GetMethod("get_LastCreatedClientIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_LastCreatedClientIndex_1);
            args = new Type[]{};
            method = type.GetMethod("get_CurrentServerMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_CurrentServerMode_2);
            args = new Type[]{};
            method = type.GetMethod("StartSinglePlayer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartSinglePlayer_3);
            args = new Type[]{};
            method = type.GetMethod("StartServer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartServer_4);
            args = new Type[]{};
            method = type.GetMethod("StartHost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartHost_5);
            args = new Type[]{};
            method = type.GetMethod("StartClient", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartClient_6);
            args = new Type[]{};
            method = type.GetMethod("StartSharedClient", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartSharedClient_7);
            args = new Type[]{};
            method = type.GetMethod("StartAutoClient", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartAutoClient_8);
            args = new Type[]{};
            method = type.GetMethod("StartServerPlusClients", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartServerPlusClients_9);
            args = new Type[]{};
            method = type.GetMethod("StartHostPlusClients", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartHostPlusClients_10);
            args = new Type[]{};
            method = type.GetMethod("Shutdown", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Shutdown_11);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("StartServerPlusClients", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartServerPlusClients_12);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("StartHostPlusClients", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartHostPlusClients_13);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("StartMultipleClients", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartMultipleClients_14);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("StartMultipleSharedClients", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartMultipleSharedClients_15);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("StartMultipleAutoClients", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartMultipleAutoClients_16);
            args = new Type[]{};
            method = type.GetMethod("ShutdownAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ShutdownAll_17);
            args = new Type[]{};
            method = type.GetMethod("AddClient", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddClient_18);
            args = new Type[]{};
            method = type.GetMethod("AddSharedClient", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddSharedClient_19);
            args = new Type[]{typeof(Fusion.GameMode), typeof(Fusion.SceneRef)};
            method = type.GetMethod("AddClient", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddClient_20);
            args = new Type[]{};
            method = type.GetMethod("get_ShouldShowGUI", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ShouldShowGUI_21);

            field = type.GetField("RunnerPrefab", flag);
            app.RegisterCLRFieldGetter(field, get_RunnerPrefab_0);
            app.RegisterCLRFieldSetter(field, set_RunnerPrefab_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_RunnerPrefab_0, AssignFromStack_RunnerPrefab_0);
            field = type.GetField("StartMode", flag);
            app.RegisterCLRFieldGetter(field, get_StartMode_1);
            app.RegisterCLRFieldSetter(field, set_StartMode_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_StartMode_1, AssignFromStack_StartMode_1);
            field = type.GetField("AutoStartAs", flag);
            app.RegisterCLRFieldGetter(field, get_AutoStartAs_2);
            app.RegisterCLRFieldSetter(field, set_AutoStartAs_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_AutoStartAs_2, AssignFromStack_AutoStartAs_2);
            field = type.GetField("AutoHideGUI", flag);
            app.RegisterCLRFieldGetter(field, get_AutoHideGUI_3);
            app.RegisterCLRFieldSetter(field, set_AutoHideGUI_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_AutoHideGUI_3, AssignFromStack_AutoHideGUI_3);
            field = type.GetField("AutoClients", flag);
            app.RegisterCLRFieldGetter(field, get_AutoClients_4);
            app.RegisterCLRFieldSetter(field, set_AutoClients_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_AutoClients_4, AssignFromStack_AutoClients_4);
            field = type.GetField("ClientStartDelay", flag);
            app.RegisterCLRFieldGetter(field, get_ClientStartDelay_5);
            app.RegisterCLRFieldSetter(field, set_ClientStartDelay_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientStartDelay_5, AssignFromStack_ClientStartDelay_5);
            field = type.GetField("ServerPort", flag);
            app.RegisterCLRFieldGetter(field, get_ServerPort_6);
            app.RegisterCLRFieldSetter(field, set_ServerPort_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_ServerPort_6, AssignFromStack_ServerPort_6);
            field = type.GetField("DefaultRoomName", flag);
            app.RegisterCLRFieldGetter(field, get_DefaultRoomName_7);
            app.RegisterCLRFieldSetter(field, set_DefaultRoomName_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_DefaultRoomName_7, AssignFromStack_DefaultRoomName_7);
            field = type.GetField("InitialScenePath", flag);
            app.RegisterCLRFieldGetter(field, get_InitialScenePath_8);
            app.RegisterCLRFieldSetter(field, set_InitialScenePath_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_InitialScenePath_8, AssignFromStack_InitialScenePath_8);
            field = type.GetField("AutoConnectVirtualInstances", flag);
            app.RegisterCLRFieldGetter(field, get_AutoConnectVirtualInstances_9);
            app.RegisterCLRFieldSetter(field, set_AutoConnectVirtualInstances_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_AutoConnectVirtualInstances_9, AssignFromStack_AutoConnectVirtualInstances_9);
            field = type.GetField("VirtualInstanceConnectDelay", flag);
            app.RegisterCLRFieldGetter(field, get_VirtualInstanceConnectDelay_10);
            app.RegisterCLRFieldSetter(field, set_VirtualInstanceConnectDelay_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_VirtualInstanceConnectDelay_10, AssignFromStack_VirtualInstanceConnectDelay_10);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.FusionBootstrap());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.FusionBootstrap[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_CurrentStage_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CurrentStage;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_LastCreatedClientIndex_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LastCreatedClientIndex;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_CurrentServerMode_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CurrentServerMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* StartSinglePlayer_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartSinglePlayer();

            return __ret;
        }

        static StackObject* StartServer_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartServer();

            return __ret;
        }

        static StackObject* StartHost_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartHost();

            return __ret;
        }

        static StackObject* StartClient_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartClient();

            return __ret;
        }

        static StackObject* StartSharedClient_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartSharedClient();

            return __ret;
        }

        static StackObject* StartAutoClient_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartAutoClient();

            return __ret;
        }

        static StackObject* StartServerPlusClients_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartServerPlusClients();

            return __ret;
        }

        static StackObject* StartHostPlusClients_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartHostPlusClients();

            return __ret;
        }

        static StackObject* Shutdown_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Shutdown();

            return __ret;
        }

        static StackObject* StartServerPlusClients_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @clientCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartServerPlusClients(@clientCount);

            return __ret;
        }

        static StackObject* StartHostPlusClients_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @clientCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartHostPlusClients(@clientCount);

            return __ret;
        }

        static StackObject* StartMultipleClients_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @clientCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartMultipleClients(@clientCount);

            return __ret;
        }

        static StackObject* StartMultipleSharedClients_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @clientCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartMultipleSharedClients(@clientCount);

            return __ret;
        }

        static StackObject* StartMultipleAutoClients_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @clientCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartMultipleAutoClients(@clientCount);

            return __ret;
        }

        static StackObject* ShutdownAll_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ShutdownAll();

            return __ret;
        }

        static StackObject* AddClient_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddClient();

            return __ret;
        }

        static StackObject* AddSharedClient_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddSharedClient();

            return __ret;
        }

        static StackObject* AddClient_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.SceneRef @sceneRef = (Fusion.SceneRef)typeof(Fusion.SceneRef).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.GameMode @serverMode = (Fusion.GameMode)typeof(Fusion.GameMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AddClient(@serverMode, @sceneRef);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_ShouldShowGUI_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.FusionBootstrap instance_of_this_method = (Fusion.FusionBootstrap)typeof(Fusion.FusionBootstrap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ShouldShowGUI;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static object get_RunnerPrefab_0(ref object o)
        {
            return ((Fusion.FusionBootstrap)o).RunnerPrefab;
        }

        static StackObject* CopyToStack_RunnerPrefab_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.FusionBootstrap)o).RunnerPrefab;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_RunnerPrefab_0(ref object o, object v)
        {
            ((Fusion.FusionBootstrap)o).RunnerPrefab = (Fusion.NetworkRunner)v;
        }

        static StackObject* AssignFromStack_RunnerPrefab_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.NetworkRunner @RunnerPrefab = (Fusion.NetworkRunner)typeof(Fusion.NetworkRunner).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.FusionBootstrap)o).RunnerPrefab = @RunnerPrefab;
            return ptr_of_this_method;
        }

        static object get_StartMode_1(ref object o)
        {
            return ((Fusion.FusionBootstrap)o).StartMode;
        }

        static StackObject* CopyToStack_StartMode_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.FusionBootstrap)o).StartMode;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_StartMode_1(ref object o, object v)
        {
            ((Fusion.FusionBootstrap)o).StartMode = (Fusion.FusionBootstrap.StartModes)v;
        }

        static StackObject* AssignFromStack_StartMode_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.FusionBootstrap.StartModes @StartMode = (Fusion.FusionBootstrap.StartModes)typeof(Fusion.FusionBootstrap.StartModes).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Fusion.FusionBootstrap)o).StartMode = @StartMode;
            return ptr_of_this_method;
        }

        static object get_AutoStartAs_2(ref object o)
        {
            return ((Fusion.FusionBootstrap)o).AutoStartAs;
        }

        static StackObject* CopyToStack_AutoStartAs_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.FusionBootstrap)o).AutoStartAs;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AutoStartAs_2(ref object o, object v)
        {
            ((Fusion.FusionBootstrap)o).AutoStartAs = (Fusion.GameMode)v;
        }

        static StackObject* AssignFromStack_AutoStartAs_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.GameMode @AutoStartAs = (Fusion.GameMode)typeof(Fusion.GameMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Fusion.FusionBootstrap)o).AutoStartAs = @AutoStartAs;
            return ptr_of_this_method;
        }

        static object get_AutoHideGUI_3(ref object o)
        {
            return ((Fusion.FusionBootstrap)o).AutoHideGUI;
        }

        static StackObject* CopyToStack_AutoHideGUI_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.FusionBootstrap)o).AutoHideGUI;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_AutoHideGUI_3(ref object o, object v)
        {
            ((Fusion.FusionBootstrap)o).AutoHideGUI = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_AutoHideGUI_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @AutoHideGUI = ptr_of_this_method->Value == 1;
            ((Fusion.FusionBootstrap)o).AutoHideGUI = @AutoHideGUI;
            return ptr_of_this_method;
        }

        static object get_AutoClients_4(ref object o)
        {
            return ((Fusion.FusionBootstrap)o).AutoClients;
        }

        static StackObject* CopyToStack_AutoClients_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.FusionBootstrap)o).AutoClients;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_AutoClients_4(ref object o, object v)
        {
            ((Fusion.FusionBootstrap)o).AutoClients = (System.Int32)v;
        }

        static StackObject* AssignFromStack_AutoClients_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @AutoClients = ptr_of_this_method->Value;
            ((Fusion.FusionBootstrap)o).AutoClients = @AutoClients;
            return ptr_of_this_method;
        }

        static object get_ClientStartDelay_5(ref object o)
        {
            return ((Fusion.FusionBootstrap)o).ClientStartDelay;
        }

        static StackObject* CopyToStack_ClientStartDelay_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.FusionBootstrap)o).ClientStartDelay;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_ClientStartDelay_5(ref object o, object v)
        {
            ((Fusion.FusionBootstrap)o).ClientStartDelay = (System.Single)v;
        }

        static StackObject* AssignFromStack_ClientStartDelay_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @ClientStartDelay = *(float*)&ptr_of_this_method->Value;
            ((Fusion.FusionBootstrap)o).ClientStartDelay = @ClientStartDelay;
            return ptr_of_this_method;
        }

        static object get_ServerPort_6(ref object o)
        {
            return ((Fusion.FusionBootstrap)o).ServerPort;
        }

        static StackObject* CopyToStack_ServerPort_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.FusionBootstrap)o).ServerPort;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_ServerPort_6(ref object o, object v)
        {
            ((Fusion.FusionBootstrap)o).ServerPort = (System.UInt16)v;
        }

        static StackObject* AssignFromStack_ServerPort_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.UInt16 @ServerPort = (ushort)ptr_of_this_method->Value;
            ((Fusion.FusionBootstrap)o).ServerPort = @ServerPort;
            return ptr_of_this_method;
        }

        static object get_DefaultRoomName_7(ref object o)
        {
            return ((Fusion.FusionBootstrap)o).DefaultRoomName;
        }

        static StackObject* CopyToStack_DefaultRoomName_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.FusionBootstrap)o).DefaultRoomName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_DefaultRoomName_7(ref object o, object v)
        {
            ((Fusion.FusionBootstrap)o).DefaultRoomName = (System.String)v;
        }

        static StackObject* AssignFromStack_DefaultRoomName_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @DefaultRoomName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.FusionBootstrap)o).DefaultRoomName = @DefaultRoomName;
            return ptr_of_this_method;
        }

        static object get_InitialScenePath_8(ref object o)
        {
            return ((Fusion.FusionBootstrap)o).InitialScenePath;
        }

        static StackObject* CopyToStack_InitialScenePath_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.FusionBootstrap)o).InitialScenePath;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_InitialScenePath_8(ref object o, object v)
        {
            ((Fusion.FusionBootstrap)o).InitialScenePath = (System.String)v;
        }

        static StackObject* AssignFromStack_InitialScenePath_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @InitialScenePath = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.FusionBootstrap)o).InitialScenePath = @InitialScenePath;
            return ptr_of_this_method;
        }

        static object get_AutoConnectVirtualInstances_9(ref object o)
        {
            return ((Fusion.FusionBootstrap)o).AutoConnectVirtualInstances;
        }

        static StackObject* CopyToStack_AutoConnectVirtualInstances_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.FusionBootstrap)o).AutoConnectVirtualInstances;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_AutoConnectVirtualInstances_9(ref object o, object v)
        {
            ((Fusion.FusionBootstrap)o).AutoConnectVirtualInstances = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_AutoConnectVirtualInstances_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @AutoConnectVirtualInstances = ptr_of_this_method->Value == 1;
            ((Fusion.FusionBootstrap)o).AutoConnectVirtualInstances = @AutoConnectVirtualInstances;
            return ptr_of_this_method;
        }

        static object get_VirtualInstanceConnectDelay_10(ref object o)
        {
            return ((Fusion.FusionBootstrap)o).VirtualInstanceConnectDelay;
        }

        static StackObject* CopyToStack_VirtualInstanceConnectDelay_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.FusionBootstrap)o).VirtualInstanceConnectDelay;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_VirtualInstanceConnectDelay_10(ref object o, object v)
        {
            ((Fusion.FusionBootstrap)o).VirtualInstanceConnectDelay = (System.Single)v;
        }

        static StackObject* AssignFromStack_VirtualInstanceConnectDelay_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @VirtualInstanceConnectDelay = *(float*)&ptr_of_this_method->Value;
            ((Fusion.FusionBootstrap)o).VirtualInstanceConnectDelay = @VirtualInstanceConnectDelay;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.FusionBootstrap();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

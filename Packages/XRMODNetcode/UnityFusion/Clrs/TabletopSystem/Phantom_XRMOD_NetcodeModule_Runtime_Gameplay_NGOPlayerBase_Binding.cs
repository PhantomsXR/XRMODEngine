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
    unsafe class Phantom_XRMOD_NetcodeModule_Runtime_Gameplay_NGOPlayerBase_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase);
            args = new Type[]{};
            method = type.GetMethod("get_GetPlayerName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GetPlayerName_0);
            args = new Type[]{};
            method = type.GetMethod("get_GetDeviceType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GetDeviceType_1);
            args = new Type[]{};
            method = type.GetMethod("get_IsReady", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsReady_2);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("SetPlayerName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPlayerName_3);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("SetPlayerDeviceType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPlayerDeviceType_4);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("SetPlayerReadyState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPlayerReadyState_5);
            args = new Type[]{};
            method = type.GetMethod("get_IsValid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsValid_6);
            args = new Type[]{};
            method = type.GetMethod("OnNetworkSpawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkSpawn_7);

            field = type.GetField("PlayerId", flag);
            app.RegisterCLRFieldGetter(field, get_PlayerId_0);
            app.RegisterCLRFieldSetter(field, set_PlayerId_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_PlayerId_0, AssignFromStack_PlayerId_0);
            field = type.GetField("PlayerNameProperty", flag);
            app.RegisterCLRFieldGetter(field, get_PlayerNameProperty_1);
            app.RegisterCLRFieldSetter(field, set_PlayerNameProperty_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_PlayerNameProperty_1, AssignFromStack_PlayerNameProperty_1);
            field = type.GetField("DeviceTypeProperty", flag);
            app.RegisterCLRFieldGetter(field, get_DeviceTypeProperty_2);
            app.RegisterCLRFieldSetter(field, set_DeviceTypeProperty_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_DeviceTypeProperty_2, AssignFromStack_DeviceTypeProperty_2);
            field = type.GetField("IsReadyProperty", flag);
            app.RegisterCLRFieldGetter(field, get_IsReadyProperty_3);
            app.RegisterCLRFieldSetter(field, set_IsReadyProperty_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsReadyProperty_3, AssignFromStack_IsReadyProperty_3);
            field = type.GetField("OnSpawned", flag);
            app.RegisterCLRFieldGetter(field, get_OnSpawned_4);
            app.RegisterCLRFieldSetter(field, set_OnSpawned_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnSpawned_4, AssignFromStack_OnSpawned_4);
            field = type.GetField("OnPostSpawn", flag);
            app.RegisterCLRFieldGetter(field, get_OnPostSpawn_5);
            app.RegisterCLRFieldSetter(field, set_OnPostSpawn_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnPostSpawn_5, AssignFromStack_OnPostSpawn_5);


            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase[s]);


        }


        static StackObject* get_GetPlayerName_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)typeof(Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPlayerName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_GetDeviceType_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)typeof(Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetDeviceType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_IsReady_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)typeof(Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsReady;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetPlayerName_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_playerName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)typeof(Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPlayerName(@_playerName);

            return __ret;
        }

        static StackObject* SetPlayerDeviceType_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_deviceType = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)typeof(Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPlayerDeviceType(@_deviceType);

            return __ret;
        }

        static StackObject* SetPlayerReadyState_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @_ready = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)typeof(Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPlayerReadyState(@_ready);

            return __ret;
        }

        static StackObject* get_IsValid_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)typeof(Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsValid;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* OnNetworkSpawn_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)typeof(Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkSpawn();

            return __ret;
        }


        static object get_PlayerId_0(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).PlayerId;
        }

        static StackObject* CopyToStack_PlayerId_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).PlayerId;
            __ret->ObjectType = ObjectTypes.Long;
            *(ulong*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_PlayerId_0(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).PlayerId = (System.UInt64)v;
        }

        static StackObject* AssignFromStack_PlayerId_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.UInt64 @PlayerId = *(ulong*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).PlayerId = @PlayerId;
            return ptr_of_this_method;
        }

        static object get_PlayerNameProperty_1(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).PlayerNameProperty;
        }

        static StackObject* CopyToStack_PlayerNameProperty_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).PlayerNameProperty;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PlayerNameProperty_1(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).PlayerNameProperty = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.String>)v;
        }

        static StackObject* AssignFromStack_PlayerNameProperty_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.Core.Runtime.BindableProperty<System.String> @PlayerNameProperty = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.String>)typeof(Phantom.XRMOD.Core.Runtime.BindableProperty<System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).PlayerNameProperty = @PlayerNameProperty;
            return ptr_of_this_method;
        }

        static object get_DeviceTypeProperty_2(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).DeviceTypeProperty;
        }

        static StackObject* CopyToStack_DeviceTypeProperty_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).DeviceTypeProperty;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_DeviceTypeProperty_2(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).DeviceTypeProperty = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.String>)v;
        }

        static StackObject* AssignFromStack_DeviceTypeProperty_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.Core.Runtime.BindableProperty<System.String> @DeviceTypeProperty = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.String>)typeof(Phantom.XRMOD.Core.Runtime.BindableProperty<System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).DeviceTypeProperty = @DeviceTypeProperty;
            return ptr_of_this_method;
        }

        static object get_IsReadyProperty_3(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).IsReadyProperty;
        }

        static StackObject* CopyToStack_IsReadyProperty_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).IsReadyProperty;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_IsReadyProperty_3(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).IsReadyProperty = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_IsReadyProperty_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.Core.Runtime.BindableProperty<System.Boolean> @IsReadyProperty = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Boolean>)typeof(Phantom.XRMOD.Core.Runtime.BindableProperty<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).IsReadyProperty = @IsReadyProperty;
            return ptr_of_this_method;
        }

        static object get_OnSpawned_4(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).OnSpawned;
        }

        static StackObject* CopyToStack_OnSpawned_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).OnSpawned;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnSpawned_4(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).OnSpawned = (UnityEngine.Events.UnityEvent<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_OnSpawned_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<System.Boolean> @OnSpawned = (UnityEngine.Events.UnityEvent<System.Boolean>)typeof(UnityEngine.Events.UnityEvent<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).OnSpawned = @OnSpawned;
            return ptr_of_this_method;
        }

        static object get_OnPostSpawn_5(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).OnPostSpawn;
        }

        static StackObject* CopyToStack_OnPostSpawn_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).OnPostSpawn;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnPostSpawn_5(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).OnPostSpawn = (UnityEngine.Events.UnityEvent<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_OnPostSpawn_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<System.Boolean> @OnPostSpawn = (UnityEngine.Events.UnityEvent<System.Boolean>)typeof(UnityEngine.Events.UnityEvent<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase)o).OnPostSpawn = @OnPostSpawn;
            return ptr_of_this_method;
        }




    }
}

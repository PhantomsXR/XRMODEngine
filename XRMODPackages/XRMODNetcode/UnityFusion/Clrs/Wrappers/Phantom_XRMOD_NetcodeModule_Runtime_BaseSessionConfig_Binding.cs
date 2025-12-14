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
    unsafe class Phantom_XRMOD_NetcodeModule_Runtime_BaseSessionConfig_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig);
            args = new Type[]{};
            method = type.GetMethod("get_SessionCode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_SessionCode_0);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_SessionCode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_SessionCode_1);
            args = new Type[]{};
            method = type.GetMethod("get_TopologyTypes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_TopologyTypes_2);
            args = new Type[]{typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkTopologyTypes)};
            method = type.GetMethod("set_TopologyTypes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_TopologyTypes_3);
            args = new Type[]{};
            method = type.GetMethod("get_MaxPlayer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MaxPlayer_4);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_MaxPlayer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MaxPlayer_5);
            args = new Type[]{};
            method = type.GetMethod("get_CustomProperties", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_CustomProperties_6);
            args = new Type[]{typeof(System.Collections.Generic.Dictionary<System.String, Unity.Services.Multiplayer.SessionProperty>)};
            method = type.GetMethod("set_CustomProperties", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_CustomProperties_7);
            args = new Type[]{};
            method = type.GetMethod("get_CustomPlayerProperties", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_CustomPlayerProperties_8);
            args = new Type[]{typeof(System.Collections.Generic.Dictionary<System.String, Unity.Services.Multiplayer.PlayerProperty>)};
            method = type.GetMethod("set_CustomPlayerProperties", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_CustomPlayerProperties_9);

            field = type.GetField("Private", flag);
            app.RegisterCLRFieldGetter(field, get_Private_0);
            app.RegisterCLRFieldSetter(field, set_Private_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Private_0, AssignFromStack_Private_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_SessionCode_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig)typeof(Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SessionCode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_SessionCode_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig)typeof(Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SessionCode = value;

            return __ret;
        }

        static StackObject* get_TopologyTypes_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig)typeof(Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TopologyTypes;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_TopologyTypes_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkTopologyTypes @value = (Phantom.XRMOD.NetcodeModule.Runtime.NetworkTopologyTypes)typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkTopologyTypes).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig)typeof(Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TopologyTypes = value;

            return __ret;
        }

        static StackObject* get_MaxPlayer_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig)typeof(Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MaxPlayer;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_MaxPlayer_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig)typeof(Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MaxPlayer = value;

            return __ret;
        }

        static StackObject* get_CustomProperties_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig)typeof(Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CustomProperties;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_CustomProperties_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.Dictionary<System.String, Unity.Services.Multiplayer.SessionProperty> @value = (System.Collections.Generic.Dictionary<System.String, Unity.Services.Multiplayer.SessionProperty>)typeof(System.Collections.Generic.Dictionary<System.String, Unity.Services.Multiplayer.SessionProperty>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig)typeof(Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CustomProperties = value;

            return __ret;
        }

        static StackObject* get_CustomPlayerProperties_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig)typeof(Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CustomPlayerProperties;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_CustomPlayerProperties_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.Dictionary<System.String, Unity.Services.Multiplayer.PlayerProperty> @value = (System.Collections.Generic.Dictionary<System.String, Unity.Services.Multiplayer.PlayerProperty>)typeof(System.Collections.Generic.Dictionary<System.String, Unity.Services.Multiplayer.PlayerProperty>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig)typeof(Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CustomPlayerProperties = value;

            return __ret;
        }


        static object get_Private_0(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig)o).Private;
        }

        static StackObject* CopyToStack_Private_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig)o).Private;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_Private_0(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig)o).Private = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_Private_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @Private = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig)o).Private = @Private;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.NetcodeModule.Runtime.BaseSessionConfig();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

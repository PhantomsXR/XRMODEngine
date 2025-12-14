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
    unsafe class Phantom_XRMOD_GameServices_Runtime_XRMODGameServicesManager_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.GameServices.Runtime.XRMODGameServicesManager);
            args = new Type[]{};
            method = type.GetMethod("get_GetInstance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GetInstance_0);

            field = type.GetField("EnableFriend", flag);
            app.RegisterCLRFieldGetter(field, get_EnableFriend_0);
            app.RegisterCLRFieldSetter(field, set_EnableFriend_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_EnableFriend_0, AssignFromStack_EnableFriend_0);
            field = type.GetField("EnableVoice", flag);
            app.RegisterCLRFieldGetter(field, get_EnableVoice_1);
            app.RegisterCLRFieldSetter(field, set_EnableVoice_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_EnableVoice_1, AssignFromStack_EnableVoice_1);
            field = type.GetField("GameServicesReady", flag);
            app.RegisterCLRFieldGetter(field, get_GameServicesReady_2);
            app.RegisterCLRFieldSetter(field, set_GameServicesReady_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_GameServicesReady_2, AssignFromStack_GameServicesReady_2);
            field = type.GetField("GameServicesFailed", flag);
            app.RegisterCLRFieldGetter(field, get_GameServicesFailed_3);
            app.RegisterCLRFieldSetter(field, set_GameServicesFailed_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_GameServicesFailed_3, AssignFromStack_GameServicesFailed_3);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.GameServices.Runtime.XRMODGameServicesManager());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.GameServices.Runtime.XRMODGameServicesManager[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_GetInstance_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.XRMODGameServicesManager.GetInstance;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_EnableFriend_0(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.XRMODGameServicesManager)o).EnableFriend;
        }

        static StackObject* CopyToStack_EnableFriend_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.XRMODGameServicesManager)o).EnableFriend;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_EnableFriend_0(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.XRMODGameServicesManager)o).EnableFriend = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_EnableFriend_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @EnableFriend = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.GameServices.Runtime.XRMODGameServicesManager)o).EnableFriend = @EnableFriend;
            return ptr_of_this_method;
        }

        static object get_EnableVoice_1(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.XRMODGameServicesManager)o).EnableVoice;
        }

        static StackObject* CopyToStack_EnableVoice_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.XRMODGameServicesManager)o).EnableVoice;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_EnableVoice_1(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.XRMODGameServicesManager)o).EnableVoice = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_EnableVoice_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @EnableVoice = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.GameServices.Runtime.XRMODGameServicesManager)o).EnableVoice = @EnableVoice;
            return ptr_of_this_method;
        }

        static object get_GameServicesReady_2(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.XRMODGameServicesManager)o).GameServicesReady;
        }

        static StackObject* CopyToStack_GameServicesReady_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.XRMODGameServicesManager)o).GameServicesReady;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_GameServicesReady_2(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.XRMODGameServicesManager)o).GameServicesReady = (UnityEngine.Events.UnityEvent)v;
        }

        static StackObject* AssignFromStack_GameServicesReady_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent @GameServicesReady = (UnityEngine.Events.UnityEvent)typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.XRMODGameServicesManager)o).GameServicesReady = @GameServicesReady;
            return ptr_of_this_method;
        }

        static object get_GameServicesFailed_3(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.XRMODGameServicesManager)o).GameServicesFailed;
        }

        static StackObject* CopyToStack_GameServicesFailed_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.XRMODGameServicesManager)o).GameServicesFailed;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_GameServicesFailed_3(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.XRMODGameServicesManager)o).GameServicesFailed = (UnityEngine.Events.UnityEvent)v;
        }

        static StackObject* AssignFromStack_GameServicesFailed_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent @GameServicesFailed = (UnityEngine.Events.UnityEvent)typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.XRMODGameServicesManager)o).GameServicesFailed = @GameServicesFailed;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.GameServices.Runtime.XRMODGameServicesManager();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

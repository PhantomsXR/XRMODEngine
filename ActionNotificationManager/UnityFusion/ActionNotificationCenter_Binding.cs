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
    unsafe class ActionNotificationCenter_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter);
            args = new Type[]{};
            method = type.GetMethod("Release", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Release_0);
            args = new Type[]{};
            method = type.GetMethod("get_DefaultCenter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_DefaultCenter_1);
            args = new Type[]{typeof(System.Action<Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData>), typeof(System.String)};
            method = type.GetMethod("AddObserver", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddObserver_2);
            args = new Type[]{typeof(System.Func<Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData, System.Object>), typeof(System.String)};
            method = type.GetMethod("AddObserver", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddObserver_3);
            args = new Type[]{typeof(System.String), typeof(System.Action<Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData>)};
            method = type.GetMethod("RemoveObserver", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveObserver_4);
            args = new Type[]{typeof(System.String), typeof(System.Func<Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData, System.Object>)};
            method = type.GetMethod("RemoveObserver", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveObserver_5);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("RemoveObserver", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveObserver_6);
            args = new Type[]{typeof(System.String), typeof(Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData)};
            method = type.GetMethod("PostNotification", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PostNotification_7);
            args = new Type[]{typeof(System.String), typeof(Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData)};
            method = type.GetMethod("PostNotificationWithResult", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PostNotificationWithResult_8);



            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter[s]);


        }


        static StackObject* Release_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter instance_of_this_method = (Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter)typeof(Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Release();

            return __ret;
        }

        static StackObject* get_DefaultCenter_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter.DefaultCenter;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* AddObserver_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Action<Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData> @_action = (System.Action<Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData>)typeof(System.Action<Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter instance_of_this_method = (Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter)typeof(Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddObserver(@_action, @_name);

            return __ret;
        }

        static StackObject* AddObserver_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Func<Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData, System.Object> @_action = (System.Func<Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData, System.Object>)typeof(System.Func<Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData, System.Object>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter instance_of_this_method = (Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter)typeof(Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddObserver(@_action, @_name);

            return __ret;
        }

        static StackObject* RemoveObserver_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData> @_action = (System.Action<Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData>)typeof(System.Action<Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter instance_of_this_method = (Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter)typeof(Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveObserver(@_name, @_action);

            return __ret;
        }

        static StackObject* RemoveObserver_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Func<Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData, System.Object> @_action = (System.Func<Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData, System.Object>)typeof(System.Func<Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData, System.Object>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter instance_of_this_method = (Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter)typeof(Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveObserver(@_name, @_action);

            return __ret;
        }

        static StackObject* RemoveObserver_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter instance_of_this_method = (Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter)typeof(Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveObserver(@_name);

            return __ret;
        }

        static StackObject* PostNotification_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData @_object = (Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData)typeof(Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter instance_of_this_method = (Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter)typeof(Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PostNotification(@_name, @_object);

            return __ret;
        }

        static StackObject* PostNotificationWithResult_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData @_object = (Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData)typeof(Phantom.XRMOD.ActionNotification.Runtime.BaseNotificationData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter instance_of_this_method = (Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter)typeof(Phantom.XRMOD.ActionNotification.Runtime.ActionNotificationCenter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.PostNotificationWithResult(@_name, @_object);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }





    }
}

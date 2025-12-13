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
    unsafe class MarkerArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.ActionNotification.Runtime.OnEventMarkerEventArgs);
            args = new Type[]{};
            method = type.GetMethod("Dispose", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Dispose_0);

            field = type.GetField("MarkerName", flag);
            app.RegisterCLRFieldGetter(field, get_MarkerName_0);
            app.RegisterCLRFieldSetter(field, set_MarkerName_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_MarkerName_0, AssignFromStack_MarkerName_0);
            field = type.GetField("MarkerState", flag);
            app.RegisterCLRFieldGetter(field, get_MarkerState_1);
            app.RegisterCLRFieldSetter(field, set_MarkerState_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_MarkerState_1, AssignFromStack_MarkerState_1);
            field = type.GetField("MarkerTrackable", flag);
            app.RegisterCLRFieldGetter(field, get_MarkerTrackable_2);
            app.RegisterCLRFieldSetter(field, set_MarkerTrackable_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_MarkerTrackable_2, AssignFromStack_MarkerTrackable_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.ActionNotification.Runtime.OnEventMarkerEventArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.ActionNotification.Runtime.OnEventMarkerEventArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Dispose_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.ActionNotification.Runtime.OnEventMarkerEventArgs instance_of_this_method = (Phantom.XRMOD.ActionNotification.Runtime.OnEventMarkerEventArgs)typeof(Phantom.XRMOD.ActionNotification.Runtime.OnEventMarkerEventArgs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Dispose();

            return __ret;
        }


        static object get_MarkerName_0(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.OnEventMarkerEventArgs)o).MarkerName;
        }

        static StackObject* CopyToStack_MarkerName_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.OnEventMarkerEventArgs)o).MarkerName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_MarkerName_0(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventMarkerEventArgs)o).MarkerName = (System.String)v;
        }

        static StackObject* AssignFromStack_MarkerName_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @MarkerName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventMarkerEventArgs)o).MarkerName = @MarkerName;
            return ptr_of_this_method;
        }

        static object get_MarkerState_1(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.OnEventMarkerEventArgs)o).MarkerState;
        }

        static StackObject* CopyToStack_MarkerState_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.OnEventMarkerEventArgs)o).MarkerState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_MarkerState_1(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventMarkerEventArgs)o).MarkerState = (Phantom.XRMOD.ActionNotification.Runtime.MarkerTrackingState)v;
        }

        static StackObject* AssignFromStack_MarkerState_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.ActionNotification.Runtime.MarkerTrackingState @MarkerState = (Phantom.XRMOD.ActionNotification.Runtime.MarkerTrackingState)typeof(Phantom.XRMOD.ActionNotification.Runtime.MarkerTrackingState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventMarkerEventArgs)o).MarkerState = @MarkerState;
            return ptr_of_this_method;
        }

        static object get_MarkerTrackable_2(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.OnEventMarkerEventArgs)o).MarkerTrackable;
        }

        static StackObject* CopyToStack_MarkerTrackable_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.OnEventMarkerEventArgs)o).MarkerTrackable;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_MarkerTrackable_2(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventMarkerEventArgs)o).MarkerTrackable = (UnityEngine.Transform)v;
        }

        static StackObject* AssignFromStack_MarkerTrackable_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Transform @MarkerTrackable = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventMarkerEventArgs)o).MarkerTrackable = @MarkerTrackable;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.ActionNotification.Runtime.OnEventMarkerEventArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

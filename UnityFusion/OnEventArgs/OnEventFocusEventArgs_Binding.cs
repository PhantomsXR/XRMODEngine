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
    unsafe class OnEventFocusEventArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs);

            field = type.GetField("Size", flag);
            app.RegisterCLRFieldGetter(field, get_Size_0);
            app.RegisterCLRFieldSetter(field, set_Size_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Size_0, AssignFromStack_Size_0);
            field = type.GetField("FocusPos", flag);
            app.RegisterCLRFieldGetter(field, get_FocusPos_1);
            app.RegisterCLRFieldSetter(field, set_FocusPos_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_FocusPos_1, AssignFromStack_FocusPos_1);
            field = type.GetField("FocusRot", flag);
            app.RegisterCLRFieldGetter(field, get_FocusRot_2);
            app.RegisterCLRFieldSetter(field, set_FocusRot_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_FocusRot_2, AssignFromStack_FocusRot_2);
            field = type.GetField("FocusState", flag);
            app.RegisterCLRFieldGetter(field, get_FocusState_3);
            app.RegisterCLRFieldSetter(field, set_FocusState_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_FocusState_3, AssignFromStack_FocusState_3);
            field = type.GetField("PlaneAlignment", flag);
            app.RegisterCLRFieldGetter(field, get_PlaneAlignment_4);
            app.RegisterCLRFieldSetter(field, set_PlaneAlignment_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_PlaneAlignment_4, AssignFromStack_PlaneAlignment_4);
            field = type.GetField("PlaneClassification", flag);
            app.RegisterCLRFieldGetter(field, get_PlaneClassification_5);
            app.RegisterCLRFieldSetter(field, set_PlaneClassification_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_PlaneClassification_5, AssignFromStack_PlaneClassification_5);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_Size_0(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).Size;
        }

        static StackObject* CopyToStack_Size_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).Size;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Size_0(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).Size = (UnityEngine.Vector2)v;
        }

        static StackObject* AssignFromStack_Size_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector2 @Size = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).Size = @Size;
            return ptr_of_this_method;
        }

        static object get_FocusPos_1(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).FocusPos;
        }

        static StackObject* CopyToStack_FocusPos_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).FocusPos;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_FocusPos_1(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).FocusPos = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_FocusPos_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @FocusPos = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).FocusPos = @FocusPos;
            return ptr_of_this_method;
        }

        static object get_FocusRot_2(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).FocusRot;
        }

        static StackObject* CopyToStack_FocusRot_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).FocusRot;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_FocusRot_2(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).FocusRot = (UnityEngine.Quaternion)v;
        }

        static StackObject* AssignFromStack_FocusRot_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Quaternion @FocusRot = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).FocusRot = @FocusRot;
            return ptr_of_this_method;
        }

        static object get_FocusState_3(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).FocusState;
        }

        static StackObject* CopyToStack_FocusState_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).FocusState;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_FocusState_3(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).FocusState = (Phantom.XRMOD.ActionNotification.Runtime.FindingType)v;
        }

        static StackObject* AssignFromStack_FocusState_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.ActionNotification.Runtime.FindingType @FocusState = (Phantom.XRMOD.ActionNotification.Runtime.FindingType)typeof(Phantom.XRMOD.ActionNotification.Runtime.FindingType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).FocusState = @FocusState;
            return ptr_of_this_method;
        }

        static object get_PlaneAlignment_4(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).PlaneAlignment;
        }

        static StackObject* CopyToStack_PlaneAlignment_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).PlaneAlignment;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PlaneAlignment_4(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).PlaneAlignment = (Phantom.XRMOD.ActionNotification.Runtime.PlaneAlignment)v;
        }

        static StackObject* AssignFromStack_PlaneAlignment_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.ActionNotification.Runtime.PlaneAlignment @PlaneAlignment = (Phantom.XRMOD.ActionNotification.Runtime.PlaneAlignment)typeof(Phantom.XRMOD.ActionNotification.Runtime.PlaneAlignment).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).PlaneAlignment = @PlaneAlignment;
            return ptr_of_this_method;
        }

        static object get_PlaneClassification_5(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).PlaneClassification;
        }

        static StackObject* CopyToStack_PlaneClassification_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).PlaneClassification;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PlaneClassification_5(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).PlaneClassification = (Phantom.XRMOD.ActionNotification.Runtime.PlaneClassification)v;
        }

        static StackObject* AssignFromStack_PlaneClassification_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.ActionNotification.Runtime.PlaneClassification @PlaneClassification = (Phantom.XRMOD.ActionNotification.Runtime.PlaneClassification)typeof(Phantom.XRMOD.ActionNotification.Runtime.PlaneClassification).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs)o).PlaneClassification = @PlaneClassification;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.ActionNotification.Runtime.OnEventFocusEventArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

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
    unsafe class AnchorArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs);

            field = type.GetField("StickType", flag);
            app.RegisterCLRFieldGetter(field, get_StickType_0);
            app.RegisterCLRFieldSetter(field, set_StickType_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_StickType_0, AssignFromStack_StickType_0);
            field = type.GetField("TrackableType", flag);
            app.RegisterCLRFieldGetter(field, get_TrackableType_1);
            app.RegisterCLRFieldSetter(field, set_TrackableType_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_TrackableType_1, AssignFromStack_TrackableType_1);
            field = type.GetField("Position", flag);
            app.RegisterCLRFieldGetter(field, get_Position_2);
            app.RegisterCLRFieldSetter(field, set_Position_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Position_2, AssignFromStack_Position_2);
            field = type.GetField("Rotation", flag);
            app.RegisterCLRFieldGetter(field, get_Rotation_3);
            app.RegisterCLRFieldSetter(field, set_Rotation_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Rotation_3, AssignFromStack_Rotation_3);
            field = type.GetField("Offset", flag);
            app.RegisterCLRFieldGetter(field, get_Offset_4);
            app.RegisterCLRFieldSetter(field, set_Offset_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Offset_4, AssignFromStack_Offset_4);
            field = type.GetField("Content", flag);
            app.RegisterCLRFieldGetter(field, get_Content_5);
            app.RegisterCLRFieldSetter(field, set_Content_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_Content_5, AssignFromStack_Content_5);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_StickType_0(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).StickType;
        }

        static StackObject* CopyToStack_StickType_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).StickType;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_StickType_0(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).StickType = (Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs.StickTypeEnum)v;
        }

        static StackObject* AssignFromStack_StickType_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs.StickTypeEnum @StickType = (Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs.StickTypeEnum)typeof(Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs.StickTypeEnum).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).StickType = @StickType;
            return ptr_of_this_method;
        }

        static object get_TrackableType_1(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).TrackableType;
        }

        static StackObject* CopyToStack_TrackableType_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).TrackableType;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TrackableType_1(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).TrackableType = (Phantom.XRMOD.ActionNotification.Runtime.TrackableTypeEnum)v;
        }

        static StackObject* AssignFromStack_TrackableType_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.ActionNotification.Runtime.TrackableTypeEnum @TrackableType = (Phantom.XRMOD.ActionNotification.Runtime.TrackableTypeEnum)typeof(Phantom.XRMOD.ActionNotification.Runtime.TrackableTypeEnum).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).TrackableType = @TrackableType;
            return ptr_of_this_method;
        }

        static object get_Position_2(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).Position;
        }

        static StackObject* CopyToStack_Position_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).Position;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Position_2(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).Position = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_Position_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @Position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).Position = @Position;
            return ptr_of_this_method;
        }

        static object get_Rotation_3(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).Rotation;
        }

        static StackObject* CopyToStack_Rotation_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).Rotation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Rotation_3(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).Rotation = (UnityEngine.Quaternion)v;
        }

        static StackObject* AssignFromStack_Rotation_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Quaternion @Rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).Rotation = @Rotation;
            return ptr_of_this_method;
        }

        static object get_Offset_4(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).Offset;
        }

        static StackObject* CopyToStack_Offset_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).Offset;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Offset_4(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).Offset = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_Offset_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @Offset = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).Offset = @Offset;
            return ptr_of_this_method;
        }

        static object get_Content_5(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).Content;
        }

        static StackObject* CopyToStack_Content_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).Content;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Content_5(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).Content = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_Content_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @ControllerTargetNode = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)o).Content = @ControllerTargetNode;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

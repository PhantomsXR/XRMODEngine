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
    unsafe class SpaceTypeArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs);

            field = type.GetField("SpaceTypeValue", flag);
            app.RegisterCLRFieldGetter(field, get_SpaceTypeValue_0);
            app.RegisterCLRFieldSetter(field, set_SpaceTypeValue_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_SpaceTypeValue_0, AssignFromStack_SpaceTypeValue_0);
            field = type.GetField("BoundResizeMode", flag);
            app.RegisterCLRFieldGetter(field, get_BoundResizeMode_1);
            app.RegisterCLRFieldSetter(field, set_BoundResizeMode_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_BoundResizeMode_1, AssignFromStack_BoundResizeMode_1);
            field = type.GetField("Dimensions", flag);
            app.RegisterCLRFieldGetter(field, get_Dimensions_2);
            app.RegisterCLRFieldSetter(field, set_Dimensions_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Dimensions_2, AssignFromStack_Dimensions_2);
            field = type.GetField("BoundPosition", flag);
            app.RegisterCLRFieldGetter(field, get_BoundPosition_3);
            app.RegisterCLRFieldSetter(field, set_BoundPosition_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_BoundPosition_3, AssignFromStack_BoundPosition_3);
            field = type.GetField("CullingMask", flag);
            app.RegisterCLRFieldGetter(field, get_CullingMask_4);
            app.RegisterCLRFieldSetter(field, set_CullingMask_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_CullingMask_4, AssignFromStack_CullingMask_4);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_SpaceTypeValue_0(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs)o).SpaceTypeValue;
        }

        static StackObject* CopyToStack_SpaceTypeValue_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs)o).SpaceTypeValue;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_SpaceTypeValue_0(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs)o).SpaceTypeValue = (Phantom.XRMOD.ActionNotification.Runtime.SpaceType)v;
        }

        static StackObject* AssignFromStack_SpaceTypeValue_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.ActionNotification.Runtime.SpaceType @SpaceTypeValue = (Phantom.XRMOD.ActionNotification.Runtime.SpaceType)typeof(Phantom.XRMOD.ActionNotification.Runtime.SpaceType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs)o).SpaceTypeValue = @SpaceTypeValue;
            return ptr_of_this_method;
        }

        static object get_BoundResizeMode_1(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs)o).BoundResizeMode;
        }

        static StackObject* CopyToStack_BoundResizeMode_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs)o).BoundResizeMode;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_BoundResizeMode_1(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs)o).BoundResizeMode = (Phantom.XRMOD.ActionNotification.Runtime.BoundResizeMode)v;
        }

        static StackObject* AssignFromStack_BoundResizeMode_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.ActionNotification.Runtime.BoundResizeMode @BoundResizeMode = (Phantom.XRMOD.ActionNotification.Runtime.BoundResizeMode)typeof(Phantom.XRMOD.ActionNotification.Runtime.BoundResizeMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs)o).BoundResizeMode = @BoundResizeMode;
            return ptr_of_this_method;
        }

        static object get_Dimensions_2(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs)o).Dimensions;
        }

        static StackObject* CopyToStack_Dimensions_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs)o).Dimensions;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Dimensions_2(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs)o).Dimensions = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_Dimensions_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @Dimensions = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs)o).Dimensions = @Dimensions;
            return ptr_of_this_method;
        }

        static object get_BoundPosition_3(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs)o).BoundPosition;
        }

        static StackObject* CopyToStack_BoundPosition_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs)o).BoundPosition;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_BoundPosition_3(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs)o).BoundPosition = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_BoundPosition_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @BoundPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs)o).BoundPosition = @BoundPosition;
            return ptr_of_this_method;
        }

        static object get_CullingMask_4(ref object o)
        {
            return ((Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs)o).CullingMask;
        }

        static StackObject* CopyToStack_CullingMask_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs)o).CullingMask;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_CullingMask_4(ref object o, object v)
        {
            ((Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs)o).CullingMask = (UnityEngine.LayerMask)v;
        }

        static StackObject* AssignFromStack_CullingMask_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.LayerMask @CullingMask = (UnityEngine.LayerMask)typeof(UnityEngine.LayerMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs)o).CullingMask = @CullingMask;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.ActionNotification.Runtime.SpaceTypeActionArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

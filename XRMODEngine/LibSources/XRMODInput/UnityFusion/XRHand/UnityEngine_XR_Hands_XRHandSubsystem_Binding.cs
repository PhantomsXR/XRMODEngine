#if XR_HAND

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
    unsafe class UnityEngine_XR_Hands_XRHandSubsystem_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Hands.XRHandSubsystem);
            args = new Type[]{};
            method = type.GetMethod("get_leftHand", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_leftHand_0);
            args = new Type[]{};
            method = type.GetMethod("get_rightHand", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rightHand_1);
            args = new Type[]{};
            method = type.GetMethod("get_jointsInLayout", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_jointsInLayout_2);
            args = new Type[]{};
            method = type.GetMethod("get_updateSuccessFlags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_updateSuccessFlags_3);
            args = new Type[]{typeof(UnityEngine.XR.Hands.XRHandSubsystem.UpdateType)};
            method = type.GetMethod("TryUpdateHands", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryUpdateHands_4);

            field = type.GetField("updatedHands", flag);
            app.RegisterCLRFieldGetter(field, get_updatedHands_0);
            app.RegisterCLRFieldSetter(field, set_updatedHands_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_updatedHands_0, AssignFromStack_updatedHands_0);
            field = type.GetField("trackingAcquired", flag);
            app.RegisterCLRFieldGetter(field, get_trackingAcquired_1);
            app.RegisterCLRFieldSetter(field, set_trackingAcquired_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_trackingAcquired_1, AssignFromStack_trackingAcquired_1);
            field = type.GetField("trackingLost", flag);
            app.RegisterCLRFieldGetter(field, get_trackingLost_2);
            app.RegisterCLRFieldSetter(field, set_trackingLost_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_trackingLost_2, AssignFromStack_trackingLost_2);
            field = type.GetField("preprocessJoints", flag);
            app.RegisterCLRFieldGetter(field, get_preprocessJoints_3);
            app.RegisterCLRFieldSetter(field, set_preprocessJoints_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_preprocessJoints_3, AssignFromStack_preprocessJoints_3);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.Hands.XRHandSubsystem());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Hands.XRHandSubsystem[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_leftHand_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Hands.XRHandSubsystem instance_of_this_method = (UnityEngine.XR.Hands.XRHandSubsystem)typeof(UnityEngine.XR.Hands.XRHandSubsystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.leftHand;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_rightHand_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Hands.XRHandSubsystem instance_of_this_method = (UnityEngine.XR.Hands.XRHandSubsystem)typeof(UnityEngine.XR.Hands.XRHandSubsystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rightHand;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_jointsInLayout_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Hands.XRHandSubsystem instance_of_this_method = (UnityEngine.XR.Hands.XRHandSubsystem)typeof(UnityEngine.XR.Hands.XRHandSubsystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.jointsInLayout;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_updateSuccessFlags_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Hands.XRHandSubsystem instance_of_this_method = (UnityEngine.XR.Hands.XRHandSubsystem)typeof(UnityEngine.XR.Hands.XRHandSubsystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.updateSuccessFlags;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TryUpdateHands_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Hands.XRHandSubsystem.UpdateType @updateType = (UnityEngine.XR.Hands.XRHandSubsystem.UpdateType)typeof(UnityEngine.XR.Hands.XRHandSubsystem.UpdateType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Hands.XRHandSubsystem instance_of_this_method = (UnityEngine.XR.Hands.XRHandSubsystem)typeof(UnityEngine.XR.Hands.XRHandSubsystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryUpdateHands(@updateType);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_updatedHands_0(ref object o)
        {
            return ((UnityEngine.XR.Hands.XRHandSubsystem)o).updatedHands;
        }

        static StackObject* CopyToStack_updatedHands_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.Hands.XRHandSubsystem)o).updatedHands;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_updatedHands_0(ref object o, object v)
        {
            ((UnityEngine.XR.Hands.XRHandSubsystem)o).updatedHands = (System.Action<UnityEngine.XR.Hands.XRHandSubsystem, UnityEngine.XR.Hands.XRHandSubsystem.UpdateSuccessFlags, UnityEngine.XR.Hands.XRHandSubsystem.UpdateType>)v;
        }

        static StackObject* AssignFromStack_updatedHands_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<UnityEngine.XR.Hands.XRHandSubsystem, UnityEngine.XR.Hands.XRHandSubsystem.UpdateSuccessFlags, UnityEngine.XR.Hands.XRHandSubsystem.UpdateType> @updatedHands = (System.Action<UnityEngine.XR.Hands.XRHandSubsystem, UnityEngine.XR.Hands.XRHandSubsystem.UpdateSuccessFlags, UnityEngine.XR.Hands.XRHandSubsystem.UpdateType>)typeof(System.Action<UnityEngine.XR.Hands.XRHandSubsystem, UnityEngine.XR.Hands.XRHandSubsystem.UpdateSuccessFlags, UnityEngine.XR.Hands.XRHandSubsystem.UpdateType>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((UnityEngine.XR.Hands.XRHandSubsystem)o).updatedHands = @updatedHands;
            return ptr_of_this_method;
        }

        static object get_trackingAcquired_1(ref object o)
        {
            return ((UnityEngine.XR.Hands.XRHandSubsystem)o).trackingAcquired;
        }

        static StackObject* CopyToStack_trackingAcquired_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.Hands.XRHandSubsystem)o).trackingAcquired;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_trackingAcquired_1(ref object o, object v)
        {
            ((UnityEngine.XR.Hands.XRHandSubsystem)o).trackingAcquired = (System.Action<UnityEngine.XR.Hands.XRHand>)v;
        }

        static StackObject* AssignFromStack_trackingAcquired_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<UnityEngine.XR.Hands.XRHand> @trackingAcquired = (System.Action<UnityEngine.XR.Hands.XRHand>)typeof(System.Action<UnityEngine.XR.Hands.XRHand>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((UnityEngine.XR.Hands.XRHandSubsystem)o).trackingAcquired = @trackingAcquired;
            return ptr_of_this_method;
        }

        static object get_trackingLost_2(ref object o)
        {
            return ((UnityEngine.XR.Hands.XRHandSubsystem)o).trackingLost;
        }

        static StackObject* CopyToStack_trackingLost_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.Hands.XRHandSubsystem)o).trackingLost;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_trackingLost_2(ref object o, object v)
        {
            ((UnityEngine.XR.Hands.XRHandSubsystem)o).trackingLost = (System.Action<UnityEngine.XR.Hands.XRHand>)v;
        }

        static StackObject* AssignFromStack_trackingLost_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<UnityEngine.XR.Hands.XRHand> @trackingLost = (System.Action<UnityEngine.XR.Hands.XRHand>)typeof(System.Action<UnityEngine.XR.Hands.XRHand>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((UnityEngine.XR.Hands.XRHandSubsystem)o).trackingLost = @trackingLost;
            return ptr_of_this_method;
        }

        static object get_preprocessJoints_3(ref object o)
        {
            return ((UnityEngine.XR.Hands.XRHandSubsystem)o).preprocessJoints;
        }

        static StackObject* CopyToStack_preprocessJoints_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.XR.Hands.XRHandSubsystem)o).preprocessJoints;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_preprocessJoints_3(ref object o, object v)
        {
            ((UnityEngine.XR.Hands.XRHandSubsystem)o).preprocessJoints = (System.Action<UnityEngine.XR.Hands.XRHandSubsystem, UnityEngine.XR.Hands.XRHandSubsystem.UpdateSuccessFlags, UnityEngine.XR.Hands.XRHandSubsystem.UpdateType>)v;
        }

        static StackObject* AssignFromStack_preprocessJoints_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<UnityEngine.XR.Hands.XRHandSubsystem, UnityEngine.XR.Hands.XRHandSubsystem.UpdateSuccessFlags, UnityEngine.XR.Hands.XRHandSubsystem.UpdateType> @preprocessJoints = (System.Action<UnityEngine.XR.Hands.XRHandSubsystem, UnityEngine.XR.Hands.XRHandSubsystem.UpdateSuccessFlags, UnityEngine.XR.Hands.XRHandSubsystem.UpdateType>)typeof(System.Action<UnityEngine.XR.Hands.XRHandSubsystem, UnityEngine.XR.Hands.XRHandSubsystem.UpdateSuccessFlags, UnityEngine.XR.Hands.XRHandSubsystem.UpdateType>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((UnityEngine.XR.Hands.XRHandSubsystem)o).preprocessJoints = @preprocessJoints;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.Hands.XRHandSubsystem();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
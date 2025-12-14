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
    unsafe class UnityEngine_XR_Hands_XRHandJointTrackingState_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Hands.XRHandJointTrackingState);

            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_None_0, null);
            field = type.GetField("Radius", flag);
            app.RegisterCLRFieldGetter(field, get_Radius_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Radius_1, null);
            field = type.GetField("Pose", flag);
            app.RegisterCLRFieldGetter(field, get_Pose_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Pose_2, null);
            field = type.GetField("LinearVelocity", flag);
            app.RegisterCLRFieldGetter(field, get_LinearVelocity_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_LinearVelocity_3, null);
            field = type.GetField("AngularVelocity", flag);
            app.RegisterCLRFieldGetter(field, get_AngularVelocity_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_AngularVelocity_4, null);
            field = type.GetField("WillNeverBeValid", flag);
            app.RegisterCLRFieldGetter(field, get_WillNeverBeValid_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_WillNeverBeValid_5, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.Hands.XRHandJointTrackingState());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Hands.XRHandJointTrackingState[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.XR.Hands.XRHandJointTrackingState instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.XR.Hands.XRHandJointTrackingState[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_None_0(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointTrackingState.None;
        }

        static StackObject* CopyToStack_None_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointTrackingState.None;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Radius_1(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointTrackingState.Radius;
        }

        static StackObject* CopyToStack_Radius_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointTrackingState.Radius;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Pose_2(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointTrackingState.Pose;
        }

        static StackObject* CopyToStack_Pose_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointTrackingState.Pose;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_LinearVelocity_3(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointTrackingState.LinearVelocity;
        }

        static StackObject* CopyToStack_LinearVelocity_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointTrackingState.LinearVelocity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_AngularVelocity_4(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointTrackingState.AngularVelocity;
        }

        static StackObject* CopyToStack_AngularVelocity_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointTrackingState.AngularVelocity;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_WillNeverBeValid_5(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointTrackingState.WillNeverBeValid;
        }

        static StackObject* CopyToStack_WillNeverBeValid_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointTrackingState.WillNeverBeValid;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.XR.Hands.XRHandJointTrackingState();
            ins = (UnityEngine.XR.Hands.XRHandJointTrackingState)o;
            return ins;
        }


    }
}
#endif
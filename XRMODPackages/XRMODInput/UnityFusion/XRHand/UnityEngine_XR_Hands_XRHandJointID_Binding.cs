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
    unsafe class UnityEngine_XR_Hands_XRHandJointID_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Hands.XRHandJointID);

            field = type.GetField("Invalid", flag);
            app.RegisterCLRFieldGetter(field, get_Invalid_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Invalid_0, null);
            field = type.GetField("BeginMarker", flag);
            app.RegisterCLRFieldGetter(field, get_BeginMarker_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_BeginMarker_1, null);
            field = type.GetField("Wrist", flag);
            app.RegisterCLRFieldGetter(field, get_Wrist_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Wrist_2, null);
            field = type.GetField("Palm", flag);
            app.RegisterCLRFieldGetter(field, get_Palm_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Palm_3, null);
            field = type.GetField("ThumbMetacarpal", flag);
            app.RegisterCLRFieldGetter(field, get_ThumbMetacarpal_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_ThumbMetacarpal_4, null);
            field = type.GetField("ThumbProximal", flag);
            app.RegisterCLRFieldGetter(field, get_ThumbProximal_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_ThumbProximal_5, null);
            field = type.GetField("ThumbDistal", flag);
            app.RegisterCLRFieldGetter(field, get_ThumbDistal_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_ThumbDistal_6, null);
            field = type.GetField("ThumbTip", flag);
            app.RegisterCLRFieldGetter(field, get_ThumbTip_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_ThumbTip_7, null);
            field = type.GetField("IndexMetacarpal", flag);
            app.RegisterCLRFieldGetter(field, get_IndexMetacarpal_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_IndexMetacarpal_8, null);
            field = type.GetField("IndexProximal", flag);
            app.RegisterCLRFieldGetter(field, get_IndexProximal_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_IndexProximal_9, null);
            field = type.GetField("IndexIntermediate", flag);
            app.RegisterCLRFieldGetter(field, get_IndexIntermediate_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_IndexIntermediate_10, null);
            field = type.GetField("IndexDistal", flag);
            app.RegisterCLRFieldGetter(field, get_IndexDistal_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_IndexDistal_11, null);
            field = type.GetField("IndexTip", flag);
            app.RegisterCLRFieldGetter(field, get_IndexTip_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_IndexTip_12, null);
            field = type.GetField("MiddleMetacarpal", flag);
            app.RegisterCLRFieldGetter(field, get_MiddleMetacarpal_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_MiddleMetacarpal_13, null);
            field = type.GetField("MiddleProximal", flag);
            app.RegisterCLRFieldGetter(field, get_MiddleProximal_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_MiddleProximal_14, null);
            field = type.GetField("MiddleIntermediate", flag);
            app.RegisterCLRFieldGetter(field, get_MiddleIntermediate_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_MiddleIntermediate_15, null);
            field = type.GetField("MiddleDistal", flag);
            app.RegisterCLRFieldGetter(field, get_MiddleDistal_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_MiddleDistal_16, null);
            field = type.GetField("MiddleTip", flag);
            app.RegisterCLRFieldGetter(field, get_MiddleTip_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_MiddleTip_17, null);
            field = type.GetField("RingMetacarpal", flag);
            app.RegisterCLRFieldGetter(field, get_RingMetacarpal_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_RingMetacarpal_18, null);
            field = type.GetField("RingProximal", flag);
            app.RegisterCLRFieldGetter(field, get_RingProximal_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_RingProximal_19, null);
            field = type.GetField("RingIntermediate", flag);
            app.RegisterCLRFieldGetter(field, get_RingIntermediate_20);
            app.RegisterCLRFieldBinding(field, CopyToStack_RingIntermediate_20, null);
            field = type.GetField("RingDistal", flag);
            app.RegisterCLRFieldGetter(field, get_RingDistal_21);
            app.RegisterCLRFieldBinding(field, CopyToStack_RingDistal_21, null);
            field = type.GetField("RingTip", flag);
            app.RegisterCLRFieldGetter(field, get_RingTip_22);
            app.RegisterCLRFieldBinding(field, CopyToStack_RingTip_22, null);
            field = type.GetField("LittleMetacarpal", flag);
            app.RegisterCLRFieldGetter(field, get_LittleMetacarpal_23);
            app.RegisterCLRFieldBinding(field, CopyToStack_LittleMetacarpal_23, null);
            field = type.GetField("LittleProximal", flag);
            app.RegisterCLRFieldGetter(field, get_LittleProximal_24);
            app.RegisterCLRFieldBinding(field, CopyToStack_LittleProximal_24, null);
            field = type.GetField("LittleIntermediate", flag);
            app.RegisterCLRFieldGetter(field, get_LittleIntermediate_25);
            app.RegisterCLRFieldBinding(field, CopyToStack_LittleIntermediate_25, null);
            field = type.GetField("LittleDistal", flag);
            app.RegisterCLRFieldGetter(field, get_LittleDistal_26);
            app.RegisterCLRFieldBinding(field, CopyToStack_LittleDistal_26, null);
            field = type.GetField("LittleTip", flag);
            app.RegisterCLRFieldGetter(field, get_LittleTip_27);
            app.RegisterCLRFieldBinding(field, CopyToStack_LittleTip_27, null);
            field = type.GetField("EndMarker", flag);
            app.RegisterCLRFieldGetter(field, get_EndMarker_28);
            app.RegisterCLRFieldBinding(field, CopyToStack_EndMarker_28, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.Hands.XRHandJointID());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Hands.XRHandJointID[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.XR.Hands.XRHandJointID instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.XR.Hands.XRHandJointID[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Invalid_0(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.Invalid;
        }

        static StackObject* CopyToStack_Invalid_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.Invalid;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_BeginMarker_1(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.BeginMarker;
        }

        static StackObject* CopyToStack_BeginMarker_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.BeginMarker;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Wrist_2(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.Wrist;
        }

        static StackObject* CopyToStack_Wrist_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.Wrist;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Palm_3(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.Palm;
        }

        static StackObject* CopyToStack_Palm_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.Palm;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ThumbMetacarpal_4(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.ThumbMetacarpal;
        }

        static StackObject* CopyToStack_ThumbMetacarpal_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.ThumbMetacarpal;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ThumbProximal_5(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.ThumbProximal;
        }

        static StackObject* CopyToStack_ThumbProximal_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.ThumbProximal;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ThumbDistal_6(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.ThumbDistal;
        }

        static StackObject* CopyToStack_ThumbDistal_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.ThumbDistal;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ThumbTip_7(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.ThumbTip;
        }

        static StackObject* CopyToStack_ThumbTip_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.ThumbTip;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_IndexMetacarpal_8(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.IndexMetacarpal;
        }

        static StackObject* CopyToStack_IndexMetacarpal_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.IndexMetacarpal;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_IndexProximal_9(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.IndexProximal;
        }

        static StackObject* CopyToStack_IndexProximal_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.IndexProximal;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_IndexIntermediate_10(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.IndexIntermediate;
        }

        static StackObject* CopyToStack_IndexIntermediate_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.IndexIntermediate;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_IndexDistal_11(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.IndexDistal;
        }

        static StackObject* CopyToStack_IndexDistal_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.IndexDistal;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_IndexTip_12(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.IndexTip;
        }

        static StackObject* CopyToStack_IndexTip_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.IndexTip;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_MiddleMetacarpal_13(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.MiddleMetacarpal;
        }

        static StackObject* CopyToStack_MiddleMetacarpal_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.MiddleMetacarpal;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_MiddleProximal_14(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.MiddleProximal;
        }

        static StackObject* CopyToStack_MiddleProximal_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.MiddleProximal;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_MiddleIntermediate_15(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.MiddleIntermediate;
        }

        static StackObject* CopyToStack_MiddleIntermediate_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.MiddleIntermediate;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_MiddleDistal_16(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.MiddleDistal;
        }

        static StackObject* CopyToStack_MiddleDistal_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.MiddleDistal;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_MiddleTip_17(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.MiddleTip;
        }

        static StackObject* CopyToStack_MiddleTip_17(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.MiddleTip;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_RingMetacarpal_18(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.RingMetacarpal;
        }

        static StackObject* CopyToStack_RingMetacarpal_18(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.RingMetacarpal;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_RingProximal_19(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.RingProximal;
        }

        static StackObject* CopyToStack_RingProximal_19(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.RingProximal;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_RingIntermediate_20(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.RingIntermediate;
        }

        static StackObject* CopyToStack_RingIntermediate_20(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.RingIntermediate;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_RingDistal_21(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.RingDistal;
        }

        static StackObject* CopyToStack_RingDistal_21(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.RingDistal;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_RingTip_22(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.RingTip;
        }

        static StackObject* CopyToStack_RingTip_22(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.RingTip;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_LittleMetacarpal_23(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.LittleMetacarpal;
        }

        static StackObject* CopyToStack_LittleMetacarpal_23(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.LittleMetacarpal;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_LittleProximal_24(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.LittleProximal;
        }

        static StackObject* CopyToStack_LittleProximal_24(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.LittleProximal;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_LittleIntermediate_25(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.LittleIntermediate;
        }

        static StackObject* CopyToStack_LittleIntermediate_25(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.LittleIntermediate;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_LittleDistal_26(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.LittleDistal;
        }

        static StackObject* CopyToStack_LittleDistal_26(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.LittleDistal;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_LittleTip_27(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.LittleTip;
        }

        static StackObject* CopyToStack_LittleTip_27(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.LittleTip;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_EndMarker_28(ref object o)
        {
            return UnityEngine.XR.Hands.XRHandJointID.EndMarker;
        }

        static StackObject* CopyToStack_EndMarker_28(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.XRHandJointID.EndMarker;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.XR.Hands.XRHandJointID();
            ins = (UnityEngine.XR.Hands.XRHandJointID)o;
            return ins;
        }


    }
}
#endif
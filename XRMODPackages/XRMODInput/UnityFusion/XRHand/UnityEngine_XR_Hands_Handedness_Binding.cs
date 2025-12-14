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
    unsafe class UnityEngine_XR_Hands_Handedness_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Hands.Handedness);

            field = type.GetField("Invalid", flag);
            app.RegisterCLRFieldGetter(field, get_Invalid_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Invalid_0, null);
            field = type.GetField("Left", flag);
            app.RegisterCLRFieldGetter(field, get_Left_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Left_1, null);
            field = type.GetField("Right", flag);
            app.RegisterCLRFieldGetter(field, get_Right_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Right_2, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.Hands.Handedness());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Hands.Handedness[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.XR.Hands.Handedness instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.XR.Hands.Handedness[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Invalid_0(ref object o)
        {
            return UnityEngine.XR.Hands.Handedness.Invalid;
        }

        static StackObject* CopyToStack_Invalid_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.Handedness.Invalid;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Left_1(ref object o)
        {
            return UnityEngine.XR.Hands.Handedness.Left;
        }

        static StackObject* CopyToStack_Left_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.Handedness.Left;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Right_2(ref object o)
        {
            return UnityEngine.XR.Hands.Handedness.Right;
        }

        static StackObject* CopyToStack_Right_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.Hands.Handedness.Right;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.XR.Hands.Handedness();
            ins = (UnityEngine.XR.Hands.Handedness)o;
            return ins;
        }


    }
}
#endif
#if USE_TIMELINE
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
    unsafe class UnityEngine_Timeline_MatchTargetFields_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Timeline.MatchTargetFields);

            field = type.GetField("PositionX", flag);
            app.RegisterCLRFieldGetter(field, get_PositionX_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_PositionX_0, null);
            field = type.GetField("PositionY", flag);
            app.RegisterCLRFieldGetter(field, get_PositionY_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_PositionY_1, null);
            field = type.GetField("PositionZ", flag);
            app.RegisterCLRFieldGetter(field, get_PositionZ_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_PositionZ_2, null);
            field = type.GetField("RotationX", flag);
            app.RegisterCLRFieldGetter(field, get_RotationX_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_RotationX_3, null);
            field = type.GetField("RotationY", flag);
            app.RegisterCLRFieldGetter(field, get_RotationY_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_RotationY_4, null);
            field = type.GetField("RotationZ", flag);
            app.RegisterCLRFieldGetter(field, get_RotationZ_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_RotationZ_5, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Timeline.MatchTargetFields());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Timeline.MatchTargetFields[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.Timeline.MatchTargetFields instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Timeline.MatchTargetFields[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_PositionX_0(ref object o)
        {
            return UnityEngine.Timeline.MatchTargetFields.PositionX;
        }

        static StackObject* CopyToStack_PositionX_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.MatchTargetFields.PositionX;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_PositionY_1(ref object o)
        {
            return UnityEngine.Timeline.MatchTargetFields.PositionY;
        }

        static StackObject* CopyToStack_PositionY_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.MatchTargetFields.PositionY;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_PositionZ_2(ref object o)
        {
            return UnityEngine.Timeline.MatchTargetFields.PositionZ;
        }

        static StackObject* CopyToStack_PositionZ_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.MatchTargetFields.PositionZ;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_RotationX_3(ref object o)
        {
            return UnityEngine.Timeline.MatchTargetFields.RotationX;
        }

        static StackObject* CopyToStack_RotationX_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.MatchTargetFields.RotationX;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_RotationY_4(ref object o)
        {
            return UnityEngine.Timeline.MatchTargetFields.RotationY;
        }

        static StackObject* CopyToStack_RotationY_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.MatchTargetFields.RotationY;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_RotationZ_5(ref object o)
        {
            return UnityEngine.Timeline.MatchTargetFields.RotationZ;
        }

        static StackObject* CopyToStack_RotationZ_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.MatchTargetFields.RotationZ;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Timeline.MatchTargetFields();
            ins = (UnityEngine.Timeline.MatchTargetFields)o;
            return ins;
        }


    }
}
#endif
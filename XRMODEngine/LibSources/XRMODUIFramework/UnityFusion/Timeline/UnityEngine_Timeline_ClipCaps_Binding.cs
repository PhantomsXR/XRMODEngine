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
    unsafe class UnityEngine_Timeline_ClipCaps_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Timeline.ClipCaps);

            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_None_0, null);
            field = type.GetField("Looping", flag);
            app.RegisterCLRFieldGetter(field, get_Looping_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Looping_1, null);
            field = type.GetField("Extrapolation", flag);
            app.RegisterCLRFieldGetter(field, get_Extrapolation_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Extrapolation_2, null);
            field = type.GetField("ClipIn", flag);
            app.RegisterCLRFieldGetter(field, get_ClipIn_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClipIn_3, null);
            field = type.GetField("SpeedMultiplier", flag);
            app.RegisterCLRFieldGetter(field, get_SpeedMultiplier_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_SpeedMultiplier_4, null);
            field = type.GetField("Blending", flag);
            app.RegisterCLRFieldGetter(field, get_Blending_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_Blending_5, null);
            field = type.GetField("AutoScale", flag);
            app.RegisterCLRFieldGetter(field, get_AutoScale_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_AutoScale_6, null);
            field = type.GetField("All", flag);
            app.RegisterCLRFieldGetter(field, get_All_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_All_7, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Timeline.ClipCaps());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Timeline.ClipCaps[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.Timeline.ClipCaps instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Timeline.ClipCaps[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_None_0(ref object o)
        {
            return UnityEngine.Timeline.ClipCaps.None;
        }

        static StackObject* CopyToStack_None_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.ClipCaps.None;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Looping_1(ref object o)
        {
            return UnityEngine.Timeline.ClipCaps.Looping;
        }

        static StackObject* CopyToStack_Looping_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.ClipCaps.Looping;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Extrapolation_2(ref object o)
        {
            return UnityEngine.Timeline.ClipCaps.Extrapolation;
        }

        static StackObject* CopyToStack_Extrapolation_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.ClipCaps.Extrapolation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ClipIn_3(ref object o)
        {
            return UnityEngine.Timeline.ClipCaps.ClipIn;
        }

        static StackObject* CopyToStack_ClipIn_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.ClipCaps.ClipIn;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_SpeedMultiplier_4(ref object o)
        {
            return UnityEngine.Timeline.ClipCaps.SpeedMultiplier;
        }

        static StackObject* CopyToStack_SpeedMultiplier_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.ClipCaps.SpeedMultiplier;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Blending_5(ref object o)
        {
            return UnityEngine.Timeline.ClipCaps.Blending;
        }

        static StackObject* CopyToStack_Blending_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.ClipCaps.Blending;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_AutoScale_6(ref object o)
        {
            return UnityEngine.Timeline.ClipCaps.AutoScale;
        }

        static StackObject* CopyToStack_AutoScale_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.ClipCaps.AutoScale;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_All_7(ref object o)
        {
            return UnityEngine.Timeline.ClipCaps.All;
        }

        static StackObject* CopyToStack_All_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.ClipCaps.All;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Timeline.ClipCaps();
            ins = (UnityEngine.Timeline.ClipCaps)o;
            return ins;
        }


    }
}
#endif
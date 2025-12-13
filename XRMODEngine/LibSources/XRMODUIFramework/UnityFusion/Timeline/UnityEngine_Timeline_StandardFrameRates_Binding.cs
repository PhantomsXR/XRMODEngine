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
    unsafe class UnityEngine_Timeline_StandardFrameRates_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Timeline.StandardFrameRates);

            field = type.GetField("Fps24", flag);
            app.RegisterCLRFieldGetter(field, get_Fps24_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Fps24_0, null);
            field = type.GetField("Fps23_97", flag);
            app.RegisterCLRFieldGetter(field, get_Fps23_97_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Fps23_97_1, null);
            field = type.GetField("Fps25", flag);
            app.RegisterCLRFieldGetter(field, get_Fps25_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Fps25_2, null);
            field = type.GetField("Fps30", flag);
            app.RegisterCLRFieldGetter(field, get_Fps30_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Fps30_3, null);
            field = type.GetField("Fps29_97", flag);
            app.RegisterCLRFieldGetter(field, get_Fps29_97_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Fps29_97_4, null);
            field = type.GetField("Fps50", flag);
            app.RegisterCLRFieldGetter(field, get_Fps50_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_Fps50_5, null);
            field = type.GetField("Fps60", flag);
            app.RegisterCLRFieldGetter(field, get_Fps60_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_Fps60_6, null);
            field = type.GetField("Fps59_94", flag);
            app.RegisterCLRFieldGetter(field, get_Fps59_94_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_Fps59_94_7, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Timeline.StandardFrameRates());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Timeline.StandardFrameRates[s]);
        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain,
            StackObject* ptr_of_this_method, AutoList __mStack,
            ref UnityEngine.Timeline.StandardFrameRates instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch (ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                {
                    __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                }
                    break;
                case ObjectTypes.FieldReference:
                {
                    var ___obj = __mStack[ptr_of_this_method->Value];
                    if (___obj is ILTypeInstance)
                    {
                        ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
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
                    if (t is ILType)
                    {
                        ((ILType) t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    else
                    {
                        ((CLRType) t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                    }
                }
                    break;
                case ObjectTypes.ArrayReference:
                {
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as UnityEngine.Timeline.StandardFrameRates[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                }
                    break;
            }
        }


        static object get_Fps24_0(ref object o)
        {
            return UnityEngine.Timeline.StandardFrameRates.Fps24;
        }

        static StackObject* CopyToStack_Fps24_0(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.StandardFrameRates.Fps24;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Fps23_97_1(ref object o)
        {
            return UnityEngine.Timeline.StandardFrameRates.Fps23_97;
        }

        static StackObject* CopyToStack_Fps23_97_1(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.StandardFrameRates.Fps23_97;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Fps25_2(ref object o)
        {
            return UnityEngine.Timeline.StandardFrameRates.Fps25;
        }

        static StackObject* CopyToStack_Fps25_2(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.StandardFrameRates.Fps25;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Fps30_3(ref object o)
        {
            return UnityEngine.Timeline.StandardFrameRates.Fps30;
        }

        static StackObject* CopyToStack_Fps30_3(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.StandardFrameRates.Fps30;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Fps29_97_4(ref object o)
        {
            return UnityEngine.Timeline.StandardFrameRates.Fps29_97;
        }

        static StackObject* CopyToStack_Fps29_97_4(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.StandardFrameRates.Fps29_97;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Fps50_5(ref object o)
        {
            return UnityEngine.Timeline.StandardFrameRates.Fps50;
        }

        static StackObject* CopyToStack_Fps50_5(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.StandardFrameRates.Fps50;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Fps60_6(ref object o)
        {
            return UnityEngine.Timeline.StandardFrameRates.Fps60;
        }

        static StackObject* CopyToStack_Fps60_6(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.StandardFrameRates.Fps60;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Fps59_94_7(ref object o)
        {
            return UnityEngine.Timeline.StandardFrameRates.Fps59_94;
        }

        static StackObject* CopyToStack_Fps59_94_7(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Timeline.StandardFrameRates.Fps59_94;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Timeline.StandardFrameRates();
            ins = (UnityEngine.Timeline.StandardFrameRates) o;
            return ins;
        }
    }
}
#endif
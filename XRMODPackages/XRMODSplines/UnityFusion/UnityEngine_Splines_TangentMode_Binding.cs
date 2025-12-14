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
    unsafe class UnityEngine_Splines_TangentMode_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Splines.TangentMode);

            field = type.GetField("AutoSmooth", flag);
            app.RegisterCLRFieldGetter(field, get_AutoSmooth_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_AutoSmooth_0, null);
            field = type.GetField("Linear", flag);
            app.RegisterCLRFieldGetter(field, get_Linear_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Linear_1, null);
            field = type.GetField("Mirrored", flag);
            app.RegisterCLRFieldGetter(field, get_Mirrored_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Mirrored_2, null);
            field = type.GetField("Continuous", flag);
            app.RegisterCLRFieldGetter(field, get_Continuous_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Continuous_3, null);
            field = type.GetField("Broken", flag);
            app.RegisterCLRFieldGetter(field, get_Broken_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Broken_4, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Splines.TangentMode());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Splines.TangentMode[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.Splines.TangentMode instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Splines.TangentMode[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_AutoSmooth_0(ref object o)
        {
            return UnityEngine.Splines.TangentMode.AutoSmooth;
        }

        static StackObject* CopyToStack_AutoSmooth_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Splines.TangentMode.AutoSmooth;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Linear_1(ref object o)
        {
            return UnityEngine.Splines.TangentMode.Linear;
        }

        static StackObject* CopyToStack_Linear_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Splines.TangentMode.Linear;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Mirrored_2(ref object o)
        {
            return UnityEngine.Splines.TangentMode.Mirrored;
        }

        static StackObject* CopyToStack_Mirrored_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Splines.TangentMode.Mirrored;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Continuous_3(ref object o)
        {
            return UnityEngine.Splines.TangentMode.Continuous;
        }

        static StackObject* CopyToStack_Continuous_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Splines.TangentMode.Continuous;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Broken_4(ref object o)
        {
            return UnityEngine.Splines.TangentMode.Broken;
        }

        static StackObject* CopyToStack_Broken_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Splines.TangentMode.Broken;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Splines.TangentMode();
            ins = (UnityEngine.Splines.TangentMode)o;
            return ins;
        }


    }
}

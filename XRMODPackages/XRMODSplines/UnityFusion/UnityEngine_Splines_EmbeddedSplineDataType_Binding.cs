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
    unsafe class UnityEngine_Splines_EmbeddedSplineDataType_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Splines.EmbeddedSplineDataType);

            field = type.GetField("Int", flag);
            app.RegisterCLRFieldGetter(field, get_Int_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Int_0, null);
            field = type.GetField("Float", flag);
            app.RegisterCLRFieldGetter(field, get_Float_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Float_1, null);
            field = type.GetField("Float4", flag);
            app.RegisterCLRFieldGetter(field, get_Float4_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Float4_2, null);
            field = type.GetField("Object", flag);
            app.RegisterCLRFieldGetter(field, get_Object_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Object_3, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Splines.EmbeddedSplineDataType());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Splines.EmbeddedSplineDataType[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.Splines.EmbeddedSplineDataType instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Splines.EmbeddedSplineDataType[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Int_0(ref object o)
        {
            return UnityEngine.Splines.EmbeddedSplineDataType.Int;
        }

        static StackObject* CopyToStack_Int_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Splines.EmbeddedSplineDataType.Int;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Float_1(ref object o)
        {
            return UnityEngine.Splines.EmbeddedSplineDataType.Float;
        }

        static StackObject* CopyToStack_Float_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Splines.EmbeddedSplineDataType.Float;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Float4_2(ref object o)
        {
            return UnityEngine.Splines.EmbeddedSplineDataType.Float4;
        }

        static StackObject* CopyToStack_Float4_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Splines.EmbeddedSplineDataType.Float4;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Object_3(ref object o)
        {
            return UnityEngine.Splines.EmbeddedSplineDataType.Object;
        }

        static StackObject* CopyToStack_Object_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Splines.EmbeddedSplineDataType.Object;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Splines.EmbeddedSplineDataType();
            ins = (UnityEngine.Splines.EmbeddedSplineDataType)o;
            return ins;
        }


    }
}

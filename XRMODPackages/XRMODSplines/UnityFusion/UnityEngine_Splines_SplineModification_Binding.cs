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
    unsafe class UnityEngine_Splines_SplineModification_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Splines.SplineModification);

            field = type.GetField("Default", flag);
            app.RegisterCLRFieldGetter(field, get_Default_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Default_0, null);
            field = type.GetField("ClosedModified", flag);
            app.RegisterCLRFieldGetter(field, get_ClosedModified_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClosedModified_1, null);
            field = type.GetField("KnotModified", flag);
            app.RegisterCLRFieldGetter(field, get_KnotModified_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_KnotModified_2, null);
            field = type.GetField("KnotInserted", flag);
            app.RegisterCLRFieldGetter(field, get_KnotInserted_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_KnotInserted_3, null);
            field = type.GetField("KnotRemoved", flag);
            app.RegisterCLRFieldGetter(field, get_KnotRemoved_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_KnotRemoved_4, null);
            field = type.GetField("KnotReordered", flag);
            app.RegisterCLRFieldGetter(field, get_KnotReordered_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_KnotReordered_5, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Splines.SplineModification());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Splines.SplineModification[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.Splines.SplineModification instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Splines.SplineModification[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Default_0(ref object o)
        {
            return UnityEngine.Splines.SplineModification.Default;
        }

        static StackObject* CopyToStack_Default_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Splines.SplineModification.Default;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ClosedModified_1(ref object o)
        {
            return UnityEngine.Splines.SplineModification.ClosedModified;
        }

        static StackObject* CopyToStack_ClosedModified_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Splines.SplineModification.ClosedModified;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_KnotModified_2(ref object o)
        {
            return UnityEngine.Splines.SplineModification.KnotModified;
        }

        static StackObject* CopyToStack_KnotModified_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Splines.SplineModification.KnotModified;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_KnotInserted_3(ref object o)
        {
            return UnityEngine.Splines.SplineModification.KnotInserted;
        }

        static StackObject* CopyToStack_KnotInserted_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Splines.SplineModification.KnotInserted;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_KnotRemoved_4(ref object o)
        {
            return UnityEngine.Splines.SplineModification.KnotRemoved;
        }

        static StackObject* CopyToStack_KnotRemoved_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Splines.SplineModification.KnotRemoved;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_KnotReordered_5(ref object o)
        {
            return UnityEngine.Splines.SplineModification.KnotReordered;
        }

        static StackObject* CopyToStack_KnotReordered_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Splines.SplineModification.KnotReordered;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Splines.SplineModification();
            ins = (UnityEngine.Splines.SplineModification)o;
            return ins;
        }


    }
}

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
    unsafe class UnityEngine_Experimental_AI_PathQueryStatus_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Experimental.AI.PathQueryStatus);

            field = type.GetField("Failure", flag);
            app.RegisterCLRFieldGetter(field, get_Failure_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Failure_0, null);
            field = type.GetField("Success", flag);
            app.RegisterCLRFieldGetter(field, get_Success_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Success_1, null);
            field = type.GetField("InProgress", flag);
            app.RegisterCLRFieldGetter(field, get_InProgress_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_InProgress_2, null);
            field = type.GetField("StatusDetailMask", flag);
            app.RegisterCLRFieldGetter(field, get_StatusDetailMask_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_StatusDetailMask_3, null);
            field = type.GetField("WrongMagic", flag);
            app.RegisterCLRFieldGetter(field, get_WrongMagic_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_WrongMagic_4, null);
            field = type.GetField("WrongVersion", flag);
            app.RegisterCLRFieldGetter(field, get_WrongVersion_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_WrongVersion_5, null);
            field = type.GetField("OutOfMemory", flag);
            app.RegisterCLRFieldGetter(field, get_OutOfMemory_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_OutOfMemory_6, null);
            field = type.GetField("InvalidParam", flag);
            app.RegisterCLRFieldGetter(field, get_InvalidParam_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_InvalidParam_7, null);
            field = type.GetField("BufferTooSmall", flag);
            app.RegisterCLRFieldGetter(field, get_BufferTooSmall_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_BufferTooSmall_8, null);
            field = type.GetField("OutOfNodes", flag);
            app.RegisterCLRFieldGetter(field, get_OutOfNodes_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_OutOfNodes_9, null);
            field = type.GetField("PartialResult", flag);
            app.RegisterCLRFieldGetter(field, get_PartialResult_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_PartialResult_10, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Experimental.AI.PathQueryStatus());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Experimental.AI.PathQueryStatus[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.Experimental.AI.PathQueryStatus instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Experimental.AI.PathQueryStatus[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Failure_0(ref object o)
        {
            return UnityEngine.Experimental.AI.PathQueryStatus.Failure;
        }

        static StackObject* CopyToStack_Failure_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Experimental.AI.PathQueryStatus.Failure;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Success_1(ref object o)
        {
            return UnityEngine.Experimental.AI.PathQueryStatus.Success;
        }

        static StackObject* CopyToStack_Success_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Experimental.AI.PathQueryStatus.Success;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_InProgress_2(ref object o)
        {
            return UnityEngine.Experimental.AI.PathQueryStatus.InProgress;
        }

        static StackObject* CopyToStack_InProgress_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Experimental.AI.PathQueryStatus.InProgress;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_StatusDetailMask_3(ref object o)
        {
            return UnityEngine.Experimental.AI.PathQueryStatus.StatusDetailMask;
        }

        static StackObject* CopyToStack_StatusDetailMask_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Experimental.AI.PathQueryStatus.StatusDetailMask;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_WrongMagic_4(ref object o)
        {
            return UnityEngine.Experimental.AI.PathQueryStatus.WrongMagic;
        }

        static StackObject* CopyToStack_WrongMagic_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Experimental.AI.PathQueryStatus.WrongMagic;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_WrongVersion_5(ref object o)
        {
            return UnityEngine.Experimental.AI.PathQueryStatus.WrongVersion;
        }

        static StackObject* CopyToStack_WrongVersion_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Experimental.AI.PathQueryStatus.WrongVersion;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OutOfMemory_6(ref object o)
        {
            return UnityEngine.Experimental.AI.PathQueryStatus.OutOfMemory;
        }

        static StackObject* CopyToStack_OutOfMemory_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Experimental.AI.PathQueryStatus.OutOfMemory;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_InvalidParam_7(ref object o)
        {
            return UnityEngine.Experimental.AI.PathQueryStatus.InvalidParam;
        }

        static StackObject* CopyToStack_InvalidParam_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Experimental.AI.PathQueryStatus.InvalidParam;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_BufferTooSmall_8(ref object o)
        {
            return UnityEngine.Experimental.AI.PathQueryStatus.BufferTooSmall;
        }

        static StackObject* CopyToStack_BufferTooSmall_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Experimental.AI.PathQueryStatus.BufferTooSmall;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OutOfNodes_9(ref object o)
        {
            return UnityEngine.Experimental.AI.PathQueryStatus.OutOfNodes;
        }

        static StackObject* CopyToStack_OutOfNodes_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Experimental.AI.PathQueryStatus.OutOfNodes;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_PartialResult_10(ref object o)
        {
            return UnityEngine.Experimental.AI.PathQueryStatus.PartialResult;
        }

        static StackObject* CopyToStack_PartialResult_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Experimental.AI.PathQueryStatus.PartialResult;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Experimental.AI.PathQueryStatus();
            ins = (UnityEngine.Experimental.AI.PathQueryStatus)o;
            return ins;
        }


    }
}

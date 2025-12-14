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
    unsafe class UnityEngine_RigidbodySleepMode2D_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.RigidbodySleepMode2D);

            field = type.GetField("NeverSleep", flag);
            app.RegisterCLRFieldGetter(field, get_NeverSleep_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_NeverSleep_0, null);
            field = type.GetField("StartAwake", flag);
            app.RegisterCLRFieldGetter(field, get_StartAwake_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_StartAwake_1, null);
            field = type.GetField("StartAsleep", flag);
            app.RegisterCLRFieldGetter(field, get_StartAsleep_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_StartAsleep_2, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.RigidbodySleepMode2D());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.RigidbodySleepMode2D[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.RigidbodySleepMode2D instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.RigidbodySleepMode2D[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_NeverSleep_0(ref object o)
        {
            return UnityEngine.RigidbodySleepMode2D.NeverSleep;
        }

        static StackObject* CopyToStack_NeverSleep_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.RigidbodySleepMode2D.NeverSleep;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_StartAwake_1(ref object o)
        {
            return UnityEngine.RigidbodySleepMode2D.StartAwake;
        }

        static StackObject* CopyToStack_StartAwake_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.RigidbodySleepMode2D.StartAwake;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_StartAsleep_2(ref object o)
        {
            return UnityEngine.RigidbodySleepMode2D.StartAsleep;
        }

        static StackObject* CopyToStack_StartAsleep_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.RigidbodySleepMode2D.StartAsleep;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.RigidbodySleepMode2D();
            ins = (UnityEngine.RigidbodySleepMode2D)o;
            return ins;
        }


    }
}

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
    unsafe class InputActionPhase_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.InputActionPhase);

            field = type.GetField("Disabled", flag);
            app.RegisterCLRFieldGetter(field, get_Disabled_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Disabled_0, null);
            field = type.GetField("Waiting", flag);
            app.RegisterCLRFieldGetter(field, get_Waiting_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Waiting_1, null);
            field = type.GetField("Started", flag);
            app.RegisterCLRFieldGetter(field, get_Started_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Started_2, null);
            field = type.GetField("Performed", flag);
            app.RegisterCLRFieldGetter(field, get_Performed_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Performed_3, null);
            field = type.GetField("Canceled", flag);
            app.RegisterCLRFieldGetter(field, get_Canceled_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Canceled_4, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.InputSystem.InputActionPhase());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.InputSystem.InputActionPhase[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.InputSystem.InputActionPhase instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.InputSystem.InputActionPhase[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Disabled_0(ref object o)
        {
            return UnityEngine.InputSystem.InputActionPhase.Disabled;
        }

        static StackObject* CopyToStack_Disabled_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputActionPhase.Disabled;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Waiting_1(ref object o)
        {
            return UnityEngine.InputSystem.InputActionPhase.Waiting;
        }

        static StackObject* CopyToStack_Waiting_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputActionPhase.Waiting;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Started_2(ref object o)
        {
            return UnityEngine.InputSystem.InputActionPhase.Started;
        }

        static StackObject* CopyToStack_Started_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputActionPhase.Started;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Performed_3(ref object o)
        {
            return UnityEngine.InputSystem.InputActionPhase.Performed;
        }

        static StackObject* CopyToStack_Performed_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputActionPhase.Performed;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Canceled_4(ref object o)
        {
            return UnityEngine.InputSystem.InputActionPhase.Canceled;
        }

        static StackObject* CopyToStack_Canceled_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputActionPhase.Canceled;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.InputSystem.InputActionPhase();
            ins = (UnityEngine.InputSystem.InputActionPhase)o;
            return ins;
        }


    }
}

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
    unsafe class UnityEngine_InputSystem_TouchPhase_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.TouchPhase);

            field = type.GetField("None", flag);
            app.RegisterCLRFieldGetter(field, get_None_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_None_0, null);
            field = type.GetField("Began", flag);
            app.RegisterCLRFieldGetter(field, get_Began_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Began_1, null);
            field = type.GetField("Moved", flag);
            app.RegisterCLRFieldGetter(field, get_Moved_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Moved_2, null);
            field = type.GetField("Ended", flag);
            app.RegisterCLRFieldGetter(field, get_Ended_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Ended_3, null);
            field = type.GetField("Canceled", flag);
            app.RegisterCLRFieldGetter(field, get_Canceled_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Canceled_4, null);
            field = type.GetField("Stationary", flag);
            app.RegisterCLRFieldGetter(field, get_Stationary_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_Stationary_5, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.InputSystem.TouchPhase());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.InputSystem.TouchPhase[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.InputSystem.TouchPhase instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.InputSystem.TouchPhase[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_None_0(ref object o)
        {
            return UnityEngine.InputSystem.TouchPhase.None;
        }

        static StackObject* CopyToStack_None_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.TouchPhase.None;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Began_1(ref object o)
        {
            return UnityEngine.InputSystem.TouchPhase.Began;
        }

        static StackObject* CopyToStack_Began_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.TouchPhase.Began;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Moved_2(ref object o)
        {
            return UnityEngine.InputSystem.TouchPhase.Moved;
        }

        static StackObject* CopyToStack_Moved_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.TouchPhase.Moved;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Ended_3(ref object o)
        {
            return UnityEngine.InputSystem.TouchPhase.Ended;
        }

        static StackObject* CopyToStack_Ended_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.TouchPhase.Ended;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Canceled_4(ref object o)
        {
            return UnityEngine.InputSystem.TouchPhase.Canceled;
        }

        static StackObject* CopyToStack_Canceled_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.TouchPhase.Canceled;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Stationary_5(ref object o)
        {
            return UnityEngine.InputSystem.TouchPhase.Stationary;
        }

        static StackObject* CopyToStack_Stationary_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.TouchPhase.Stationary;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.InputSystem.TouchPhase();
            ins = (UnityEngine.InputSystem.TouchPhase)o;
            return ins;
        }


    }
}

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
    unsafe class InputActionChange_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.InputActionChange);

            field = type.GetField("ActionEnabled", flag);
            app.RegisterCLRFieldGetter(field, get_ActionEnabled_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_ActionEnabled_0, null);
            field = type.GetField("ActionDisabled", flag);
            app.RegisterCLRFieldGetter(field, get_ActionDisabled_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_ActionDisabled_1, null);
            field = type.GetField("ActionMapEnabled", flag);
            app.RegisterCLRFieldGetter(field, get_ActionMapEnabled_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_ActionMapEnabled_2, null);
            field = type.GetField("ActionMapDisabled", flag);
            app.RegisterCLRFieldGetter(field, get_ActionMapDisabled_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_ActionMapDisabled_3, null);
            field = type.GetField("ActionStarted", flag);
            app.RegisterCLRFieldGetter(field, get_ActionStarted_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_ActionStarted_4, null);
            field = type.GetField("ActionPerformed", flag);
            app.RegisterCLRFieldGetter(field, get_ActionPerformed_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_ActionPerformed_5, null);
            field = type.GetField("ActionCanceled", flag);
            app.RegisterCLRFieldGetter(field, get_ActionCanceled_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_ActionCanceled_6, null);
            field = type.GetField("BoundControlsAboutToChange", flag);
            app.RegisterCLRFieldGetter(field, get_BoundControlsAboutToChange_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_BoundControlsAboutToChange_7, null);
            field = type.GetField("BoundControlsChanged", flag);
            app.RegisterCLRFieldGetter(field, get_BoundControlsChanged_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_BoundControlsChanged_8, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.InputSystem.InputActionChange());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.InputSystem.InputActionChange[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.InputSystem.InputActionChange instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.InputSystem.InputActionChange[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_ActionEnabled_0(ref object o)
        {
            return UnityEngine.InputSystem.InputActionChange.ActionEnabled;
        }

        static StackObject* CopyToStack_ActionEnabled_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputActionChange.ActionEnabled;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ActionDisabled_1(ref object o)
        {
            return UnityEngine.InputSystem.InputActionChange.ActionDisabled;
        }

        static StackObject* CopyToStack_ActionDisabled_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputActionChange.ActionDisabled;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ActionMapEnabled_2(ref object o)
        {
            return UnityEngine.InputSystem.InputActionChange.ActionMapEnabled;
        }

        static StackObject* CopyToStack_ActionMapEnabled_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputActionChange.ActionMapEnabled;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ActionMapDisabled_3(ref object o)
        {
            return UnityEngine.InputSystem.InputActionChange.ActionMapDisabled;
        }

        static StackObject* CopyToStack_ActionMapDisabled_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputActionChange.ActionMapDisabled;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ActionStarted_4(ref object o)
        {
            return UnityEngine.InputSystem.InputActionChange.ActionStarted;
        }

        static StackObject* CopyToStack_ActionStarted_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputActionChange.ActionStarted;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ActionPerformed_5(ref object o)
        {
            return UnityEngine.InputSystem.InputActionChange.ActionPerformed;
        }

        static StackObject* CopyToStack_ActionPerformed_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputActionChange.ActionPerformed;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ActionCanceled_6(ref object o)
        {
            return UnityEngine.InputSystem.InputActionChange.ActionCanceled;
        }

        static StackObject* CopyToStack_ActionCanceled_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputActionChange.ActionCanceled;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_BoundControlsAboutToChange_7(ref object o)
        {
            return UnityEngine.InputSystem.InputActionChange.BoundControlsAboutToChange;
        }

        static StackObject* CopyToStack_BoundControlsAboutToChange_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputActionChange.BoundControlsAboutToChange;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_BoundControlsChanged_8(ref object o)
        {
            return UnityEngine.InputSystem.InputActionChange.BoundControlsChanged;
        }

        static StackObject* CopyToStack_BoundControlsChanged_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputActionChange.BoundControlsChanged;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.InputSystem.InputActionChange();
            ins = (UnityEngine.InputSystem.InputActionChange)o;
            return ins;
        }


    }
}

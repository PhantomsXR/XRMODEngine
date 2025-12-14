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
    unsafe class UnityEngine_InputSystem_InputDeviceChange_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.InputDeviceChange);

            field = type.GetField("Added", flag);
            app.RegisterCLRFieldGetter(field, get_Added_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Added_0, null);
            field = type.GetField("Removed", flag);
            app.RegisterCLRFieldGetter(field, get_Removed_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Removed_1, null);
            field = type.GetField("Disconnected", flag);
            app.RegisterCLRFieldGetter(field, get_Disconnected_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Disconnected_2, null);
            field = type.GetField("Reconnected", flag);
            app.RegisterCLRFieldGetter(field, get_Reconnected_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Reconnected_3, null);
            field = type.GetField("Enabled", flag);
            app.RegisterCLRFieldGetter(field, get_Enabled_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Enabled_4, null);
            field = type.GetField("Disabled", flag);
            app.RegisterCLRFieldGetter(field, get_Disabled_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_Disabled_5, null);
            field = type.GetField("UsageChanged", flag);
            app.RegisterCLRFieldGetter(field, get_UsageChanged_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_UsageChanged_6, null);
            field = type.GetField("ConfigurationChanged", flag);
            app.RegisterCLRFieldGetter(field, get_ConfigurationChanged_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_ConfigurationChanged_7, null);
            field = type.GetField("SoftReset", flag);
            app.RegisterCLRFieldGetter(field, get_SoftReset_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_SoftReset_8, null);
            field = type.GetField("HardReset", flag);
            app.RegisterCLRFieldGetter(field, get_HardReset_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_HardReset_9, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.InputSystem.InputDeviceChange());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.InputSystem.InputDeviceChange[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.InputSystem.InputDeviceChange instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.InputSystem.InputDeviceChange[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Added_0(ref object o)
        {
            return UnityEngine.InputSystem.InputDeviceChange.Added;
        }

        static StackObject* CopyToStack_Added_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputDeviceChange.Added;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Removed_1(ref object o)
        {
            return UnityEngine.InputSystem.InputDeviceChange.Removed;
        }

        static StackObject* CopyToStack_Removed_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputDeviceChange.Removed;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Disconnected_2(ref object o)
        {
            return UnityEngine.InputSystem.InputDeviceChange.Disconnected;
        }

        static StackObject* CopyToStack_Disconnected_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputDeviceChange.Disconnected;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Reconnected_3(ref object o)
        {
            return UnityEngine.InputSystem.InputDeviceChange.Reconnected;
        }

        static StackObject* CopyToStack_Reconnected_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputDeviceChange.Reconnected;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Enabled_4(ref object o)
        {
            return UnityEngine.InputSystem.InputDeviceChange.Enabled;
        }

        static StackObject* CopyToStack_Enabled_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputDeviceChange.Enabled;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Disabled_5(ref object o)
        {
            return UnityEngine.InputSystem.InputDeviceChange.Disabled;
        }

        static StackObject* CopyToStack_Disabled_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputDeviceChange.Disabled;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_UsageChanged_6(ref object o)
        {
            return UnityEngine.InputSystem.InputDeviceChange.UsageChanged;
        }

        static StackObject* CopyToStack_UsageChanged_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputDeviceChange.UsageChanged;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ConfigurationChanged_7(ref object o)
        {
            return UnityEngine.InputSystem.InputDeviceChange.ConfigurationChanged;
        }

        static StackObject* CopyToStack_ConfigurationChanged_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputDeviceChange.ConfigurationChanged;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_SoftReset_8(ref object o)
        {
            return UnityEngine.InputSystem.InputDeviceChange.SoftReset;
        }

        static StackObject* CopyToStack_SoftReset_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputDeviceChange.SoftReset;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_HardReset_9(ref object o)
        {
            return UnityEngine.InputSystem.InputDeviceChange.HardReset;
        }

        static StackObject* CopyToStack_HardReset_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.InputDeviceChange.HardReset;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.InputSystem.InputDeviceChange();
            ins = (UnityEngine.InputSystem.InputDeviceChange)o;
            return ins;
        }


    }
}

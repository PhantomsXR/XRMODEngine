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
    unsafe class UnityEngine_XR_VisionOS_InputDevices_VisionOSSpatialPointerModifierKeys_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys);

            field = type.GetField("CapsLock", flag);
            app.RegisterCLRFieldGetter(field, get_CapsLock_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_CapsLock_0, null);
            field = type.GetField("Control", flag);
            app.RegisterCLRFieldGetter(field, get_Control_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Control_1, null);
            field = type.GetField("Alt", flag);
            app.RegisterCLRFieldGetter(field, get_Alt_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Alt_2, null);
            field = type.GetField("Command", flag);
            app.RegisterCLRFieldGetter(field, get_Command_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Command_3, null);
            field = type.GetField("Option", flag);
            app.RegisterCLRFieldGetter(field, get_Option_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Option_4, null);
            field = type.GetField("Shift", flag);
            app.RegisterCLRFieldGetter(field, get_Shift_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_Shift_5, null);
            field = type.GetField("NumericPad", flag);
            app.RegisterCLRFieldGetter(field, get_NumericPad_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_NumericPad_6, null);
            field = type.GetField("FunctionKey", flag);
            app.RegisterCLRFieldGetter(field, get_FunctionKey_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_FunctionKey_7, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_CapsLock_0(ref object o)
        {
            return UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys.CapsLock;
        }

        static StackObject* CopyToStack_CapsLock_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys.CapsLock;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Control_1(ref object o)
        {
            return UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys.Control;
        }

        static StackObject* CopyToStack_Control_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys.Control;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Alt_2(ref object o)
        {
            return UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys.Alt;
        }

        static StackObject* CopyToStack_Alt_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys.Alt;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Command_3(ref object o)
        {
            return UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys.Command;
        }

        static StackObject* CopyToStack_Command_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys.Command;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Option_4(ref object o)
        {
            return UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys.Option;
        }

        static StackObject* CopyToStack_Option_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys.Option;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Shift_5(ref object o)
        {
            return UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys.Shift;
        }

        static StackObject* CopyToStack_Shift_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys.Shift;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_NumericPad_6(ref object o)
        {
            return UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys.NumericPad;
        }

        static StackObject* CopyToStack_NumericPad_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys.NumericPad;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_FunctionKey_7(ref object o)
        {
            return UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys.FunctionKey;
        }

        static StackObject* CopyToStack_FunctionKey_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys.FunctionKey;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys();
            ins = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerModifierKeys)o;
            return ins;
        }


    }
}

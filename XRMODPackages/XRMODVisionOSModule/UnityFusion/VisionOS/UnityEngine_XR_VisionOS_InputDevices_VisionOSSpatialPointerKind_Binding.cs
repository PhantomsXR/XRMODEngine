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
    unsafe class UnityEngine_XR_VisionOS_InputDevices_VisionOSSpatialPointerKind_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind);

            field = type.GetField("Touch", flag);
            app.RegisterCLRFieldGetter(field, get_Touch_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Touch_0, null);
            field = type.GetField("DirectPinch", flag);
            app.RegisterCLRFieldGetter(field, get_DirectPinch_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_DirectPinch_1, null);
            field = type.GetField("IndirectPinch", flag);
            app.RegisterCLRFieldGetter(field, get_IndirectPinch_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_IndirectPinch_2, null);
            field = type.GetField("Pointer", flag);
            app.RegisterCLRFieldGetter(field, get_Pointer_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Pointer_3, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Touch_0(ref object o)
        {
            return UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind.Touch;
        }

        static StackObject* CopyToStack_Touch_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind.Touch;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_DirectPinch_1(ref object o)
        {
            return UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind.DirectPinch;
        }

        static StackObject* CopyToStack_DirectPinch_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind.DirectPinch;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_IndirectPinch_2(ref object o)
        {
            return UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind.IndirectPinch;
        }

        static StackObject* CopyToStack_IndirectPinch_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind.IndirectPinch;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Pointer_3(ref object o)
        {
            return UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind.Pointer;
        }

        static StackObject* CopyToStack_Pointer_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind.Pointer;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind();
            ins = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerKind)o;
            return ins;
        }


    }
}

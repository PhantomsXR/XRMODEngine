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
    unsafe class UnityEngine_InputSystem_UI_UIPointerBehavior_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.UI.UIPointerBehavior);

            field = type.GetField("SingleMouseOrPenButMultiTouchAndTrack", flag);
            app.RegisterCLRFieldGetter(field, get_SingleMouseOrPenButMultiTouchAndTrack_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_SingleMouseOrPenButMultiTouchAndTrack_0, null);
            field = type.GetField("SingleUnifiedPointer", flag);
            app.RegisterCLRFieldGetter(field, get_SingleUnifiedPointer_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_SingleUnifiedPointer_1, null);
            field = type.GetField("AllPointersAsIs", flag);
            app.RegisterCLRFieldGetter(field, get_AllPointersAsIs_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_AllPointersAsIs_2, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.InputSystem.UI.UIPointerBehavior());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.InputSystem.UI.UIPointerBehavior[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.InputSystem.UI.UIPointerBehavior instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.InputSystem.UI.UIPointerBehavior[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_SingleMouseOrPenButMultiTouchAndTrack_0(ref object o)
        {
            return UnityEngine.InputSystem.UI.UIPointerBehavior.SingleMouseOrPenButMultiTouchAndTrack;
        }

        static StackObject* CopyToStack_SingleMouseOrPenButMultiTouchAndTrack_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.UI.UIPointerBehavior.SingleMouseOrPenButMultiTouchAndTrack;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_SingleUnifiedPointer_1(ref object o)
        {
            return UnityEngine.InputSystem.UI.UIPointerBehavior.SingleUnifiedPointer;
        }

        static StackObject* CopyToStack_SingleUnifiedPointer_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.UI.UIPointerBehavior.SingleUnifiedPointer;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_AllPointersAsIs_2(ref object o)
        {
            return UnityEngine.InputSystem.UI.UIPointerBehavior.AllPointersAsIs;
        }

        static StackObject* CopyToStack_AllPointersAsIs_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.UI.UIPointerBehavior.AllPointersAsIs;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.InputSystem.UI.UIPointerBehavior();
            ins = (UnityEngine.InputSystem.UI.UIPointerBehavior)o;
            return ins;
        }


    }
}

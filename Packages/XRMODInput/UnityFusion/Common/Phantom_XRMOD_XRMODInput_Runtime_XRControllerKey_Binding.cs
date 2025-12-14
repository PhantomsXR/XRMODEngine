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
    unsafe class Phantom_XRMOD_XRMODInput_Runtime_XRControllerKey_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey);

            field = type.GetField("AButton", flag);
            app.RegisterCLRFieldGetter(field, get_AButton_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_AButton_0, null);
            field = type.GetField("BButton", flag);
            app.RegisterCLRFieldGetter(field, get_BButton_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_BButton_1, null);
            field = type.GetField("XButton", flag);
            app.RegisterCLRFieldGetter(field, get_XButton_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_XButton_2, null);
            field = type.GetField("YButton", flag);
            app.RegisterCLRFieldGetter(field, get_YButton_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_YButton_3, null);
            field = type.GetField("Trigger", flag);
            app.RegisterCLRFieldGetter(field, get_Trigger_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Trigger_4, null);
            field = type.GetField("Grip", flag);
            app.RegisterCLRFieldGetter(field, get_Grip_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_Grip_5, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_AButton_0(ref object o)
        {
            return Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey.AButton;
        }

        static StackObject* CopyToStack_AButton_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey.AButton;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_BButton_1(ref object o)
        {
            return Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey.BButton;
        }

        static StackObject* CopyToStack_BButton_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey.BButton;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_XButton_2(ref object o)
        {
            return Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey.XButton;
        }

        static StackObject* CopyToStack_XButton_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey.XButton;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_YButton_3(ref object o)
        {
            return Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey.YButton;
        }

        static StackObject* CopyToStack_YButton_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey.YButton;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Trigger_4(ref object o)
        {
            return Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey.Trigger;
        }

        static StackObject* CopyToStack_Trigger_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey.Trigger;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Grip_5(ref object o)
        {
            return Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey.Grip;
        }

        static StackObject* CopyToStack_Grip_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey.Grip;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey();
            ins = (Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey)o;
            return ins;
        }


    }
}

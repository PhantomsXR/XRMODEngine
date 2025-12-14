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
    unsafe class Phantom_XRMOD_XRMODInput_Runtime_InputType_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODInput.Runtime.InputType);

            field = type.GetField("NatureHands", flag);
            app.RegisterCLRFieldGetter(field, get_NatureHands_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_NatureHands_0, null);
            field = type.GetField("KeyboardNMouse", flag);
            app.RegisterCLRFieldGetter(field, get_KeyboardNMouse_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_KeyboardNMouse_1, null);
            field = type.GetField("GamePad", flag);
            app.RegisterCLRFieldGetter(field, get_GamePad_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_GamePad_2, null);
            field = type.GetField("XRController", flag);
            app.RegisterCLRFieldGetter(field, get_XRController_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_XRController_3, null);
            field = type.GetField("Unknown", flag);
            app.RegisterCLRFieldGetter(field, get_Unknown_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Unknown_4, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODInput.Runtime.InputType());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODInput.Runtime.InputType[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Phantom.XRMOD.XRMODInput.Runtime.InputType instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Phantom.XRMOD.XRMODInput.Runtime.InputType[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_NatureHands_0(ref object o)
        {
            return Phantom.XRMOD.XRMODInput.Runtime.InputType.NatureHands;
        }

        static StackObject* CopyToStack_NatureHands_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.InputType.NatureHands;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_KeyboardNMouse_1(ref object o)
        {
            return Phantom.XRMOD.XRMODInput.Runtime.InputType.KeyboardNMouse;
        }

        static StackObject* CopyToStack_KeyboardNMouse_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.InputType.KeyboardNMouse;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_GamePad_2(ref object o)
        {
            return Phantom.XRMOD.XRMODInput.Runtime.InputType.GamePad;
        }

        static StackObject* CopyToStack_GamePad_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.InputType.GamePad;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_XRController_3(ref object o)
        {
            return Phantom.XRMOD.XRMODInput.Runtime.InputType.XRController;
        }

        static StackObject* CopyToStack_XRController_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.InputType.XRController;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Unknown_4(ref object o)
        {
            return Phantom.XRMOD.XRMODInput.Runtime.InputType.Unknown;
        }

        static StackObject* CopyToStack_Unknown_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.InputType.Unknown;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Phantom.XRMOD.XRMODInput.Runtime.InputType();
            ins = (Phantom.XRMOD.XRMODInput.Runtime.InputType)o;
            return ins;
        }


    }
}

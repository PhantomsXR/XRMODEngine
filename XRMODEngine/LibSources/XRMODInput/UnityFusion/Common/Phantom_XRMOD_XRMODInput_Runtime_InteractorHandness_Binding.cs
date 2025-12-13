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
    unsafe class Phantom_XRMOD_XRMODInput_Runtime_InteractorHandness_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness);

            field = type.GetField("LeftController", flag);
            app.RegisterCLRFieldGetter(field, get_LeftController_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_LeftController_0, null);
            field = type.GetField("RightController", flag);
            app.RegisterCLRFieldGetter(field, get_RightController_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_RightController_1, null);
            field = type.GetField("LeftHand", flag);
            app.RegisterCLRFieldGetter(field, get_LeftHand_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_LeftHand_2, null);
            field = type.GetField("RightHand", flag);
            app.RegisterCLRFieldGetter(field, get_RightHand_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_RightHand_3, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_LeftController_0(ref object o)
        {
            return Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness.LeftController;
        }

        static StackObject* CopyToStack_LeftController_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness.LeftController;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_RightController_1(ref object o)
        {
            return Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness.RightController;
        }

        static StackObject* CopyToStack_RightController_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness.RightController;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_LeftHand_2(ref object o)
        {
            return Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness.LeftHand;
        }

        static StackObject* CopyToStack_LeftHand_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness.LeftHand;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_RightHand_3(ref object o)
        {
            return Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness.RightHand;
        }

        static StackObject* CopyToStack_RightHand_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness.RightHand;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness();
            ins = (Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness)o;
            return ins;
        }


    }
}

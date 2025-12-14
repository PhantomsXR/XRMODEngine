#if XR_HAND
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
    unsafe class GestureUtilities_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODInput.Runtime.GestureUtilities);
            args = new Type[] {typeof(UnityEngine.XR.Hands.XRHand)};
            method = type.GetMethod("IsIndexExtended", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsIndexExtended_0);
            args = new Type[] {typeof(UnityEngine.XR.Hands.XRHand)};
            method = type.GetMethod("IsMiddleGrabbing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsMiddleGrabbing_1);
            args = new Type[] {typeof(UnityEngine.XR.Hands.XRHand)};
            method = type.GetMethod("IsRingGrabbing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsRingGrabbing_2);
            args = new Type[] {typeof(UnityEngine.XR.Hands.XRHand)};
            method = type.GetMethod("IsLittleGrabbing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsLittleGrabbing_3);
        }


        static StackObject* IsIndexExtended_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Hands.XRHand @_hand =
                (UnityEngine.XR.Hands.XRHand) typeof(UnityEngine.XR.Hands.XRHand).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.GestureUtilities.IsIndexExtended(@_hand);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsMiddleGrabbing_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Hands.XRHand @_hand =
                (UnityEngine.XR.Hands.XRHand) typeof(UnityEngine.XR.Hands.XRHand).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.GestureUtilities.IsMiddleGrabbing(@_hand);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsRingGrabbing_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Hands.XRHand @_hand =
                (UnityEngine.XR.Hands.XRHand) typeof(UnityEngine.XR.Hands.XRHand).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.GestureUtilities.IsRingGrabbing(@_hand);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsLittleGrabbing_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Hands.XRHand @_hand =
                (UnityEngine.XR.Hands.XRHand) typeof(UnityEngine.XR.Hands.XRHand).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.GestureUtilities.IsLittleGrabbing(@_hand);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }
    }
}
#endif
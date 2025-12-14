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
    unsafe class Phantom_XRMOD_XRMODUtilites_Runtime_RuntimePlatformHelper_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODUtilites.Runtime.RuntimePlatformHelper);
            args = new Type[] {typeof(Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType)};
            method = type.GetMethod("IsPlatform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsPlatform_0);
            args = new Type[] { };
            method = type.GetMethod("GetPlatformName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPlatformName_1);
            args = new Type[] { };
            method = type.GetMethod("GetRuntimePlatform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRuntimePlatform_2);
            args = new Type[] { };
            method = type.GetMethod("IsVisionOS", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsVisionOS_3);
            args = new Type[] { };
            method = type.GetMethod("IsPico", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsPico_4);
            args = new Type[] { };
            method = type.GetMethod("IsRokid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsRokid_5);
            args = new Type[] { };
            method = type.GetMethod("IsHandheldAR", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsHandheldAR_6);
            args = new Type[] { };
            method = type.GetMethod("IsXReal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsXReal_7);
            args = new Type[] { };
            method = type.GetMethod("IsHololens", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsHololens_8);
            args = new Type[] { };
            method = type.GetMethod("IsQuest", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsQuest_9);
            args = new Type[] { };
            method = type.GetMethod("IsWebAR", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsWebAR_10);
            args = new Type[] { };
            method = type.GetMethod("IsWebVR", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsWebVR_11);
            args = new Type[] { };
            method = type.GetMethod("IsWeb3D", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsWeb3D_12);
            args = new Type[] { };
            method = type.GetMethod("IsClassic3D", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsClassic3D_13);
            args = new Type[] { };
            method = type.GetMethod("GetXRMODRuntimePlatformType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetXRMODRuntimePlatformType_0);
        }

        static StackObject* GetXRMODRuntimePlatformType_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method =
                Phantom.XRMOD.XRMODUtilites.Runtime.RuntimePlatformHelper.GetXRMODRuntimePlatformType();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* IsPlatform_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType @_platformType =
                (Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType)
                typeof(Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                Phantom.XRMOD.XRMODUtilites.Runtime.RuntimePlatformHelper.IsPlatform(@_platformType);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetPlatformName_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.RuntimePlatformHelper.GetPlatformName();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetRuntimePlatform_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.RuntimePlatformHelper.GetRuntimePlatform();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* IsVisionOS_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.RuntimePlatformHelper.IsVisionOS();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsPico_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.RuntimePlatformHelper.IsPico();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsRokid_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.RuntimePlatformHelper.IsRokid();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsHandheldAR_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.RuntimePlatformHelper.IsHandheldAR();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsXReal_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.RuntimePlatformHelper.IsXReal();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsHololens_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.RuntimePlatformHelper.IsHololens();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsQuest_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.RuntimePlatformHelper.IsQuest();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsWebAR_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.RuntimePlatformHelper.IsWebAR();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsWebVR_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.RuntimePlatformHelper.IsWebVR();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsWeb3D_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.RuntimePlatformHelper.IsWeb3D();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsClassic3D_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.RuntimePlatformHelper.IsClassic3D();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }
    }
}
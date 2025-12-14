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
    unsafe class Phantom_XRMOD_GameServices_Runtime_AuthenticationSystemManager_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager);
            args = new Type[] {typeof(System.Action)};
            method = type.GetMethod("add_SignedInCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_SignedInCallback_0);
            args = new Type[] {typeof(System.Action)};
            method = type.GetMethod("remove_SignedInCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_SignedInCallback_1);
            args = new Type[] {typeof(System.Action)};
            method = type.GetMethod("add_SignOutCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_SignOutCallback_2);
            args = new Type[] {typeof(System.Action)};
            method = type.GetMethod("remove_SignOutCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_SignOutCallback_3);
            args = new Type[] {typeof(System.Action<Unity.Services.Core.RequestFailedException>)};
            method = type.GetMethod("add_SignFailedCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_SignFailedCallback_4);
            args = new Type[] {typeof(System.Action<Unity.Services.Core.RequestFailedException>)};
            method = type.GetMethod("remove_SignFailedCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_SignFailedCallback_5);
            args = new Type[] {typeof(System.Action<Unity.Services.Authentication.SignInCodeInfo>)};
            method = type.GetMethod("add_SignInCodeReceivedCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_SignInCodeReceivedCallback_6);
            args = new Type[] {typeof(System.Action<Unity.Services.Authentication.SignInCodeInfo>)};
            method = type.GetMethod("remove_SignInCodeReceivedCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_SignInCodeReceivedCallback_7);
            args = new Type[] {typeof(System.Action)};
            method = type.GetMethod("add_SignInCodeExpiredCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_SignInCodeExpiredCallback_8);
            args = new Type[] {typeof(System.Action)};
            method = type.GetMethod("remove_SignInCodeExpiredCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_SignInCodeExpiredCallback_9);
            args = new Type[] {typeof(System.Action)};
            method = type.GetMethod("add_ExpiredCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_ExpiredCallback_10);
            args = new Type[] {typeof(System.Action)};
            method = type.GetMethod("remove_ExpiredCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_ExpiredCallback_11);
            args = new Type[] { };
            method = type.GetMethod("InitServices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InitServices_12);
            args = new Type[] {typeof(System.String), typeof(System.String), typeof(System.Action<System.String>)};
            method = type.GetMethod("SignInUserNameWithPassword", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SignInUserNameWithPassword_13);
            args = new Type[] {typeof(System.String), typeof(System.String)};
            method = type.GetMethod("UpdateUserNamePassword", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UpdateUserNamePassword_14);
            args = new Type[] {typeof(System.String), typeof(System.String), typeof(System.Action<System.String>)};
            method = type.GetMethod("SignUpUserNameWithPassword", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SignUpUserNameWithPassword_15);
            args = new Type[] { };
            method = type.GetMethod("SignInWithApple", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SignInWithApple_16);
            args = new Type[]
            {
                typeof(System.Action<Phantom.XRMOD.GameServices.Runtime.UserInfoModel>),
                typeof(System.Action<System.String>)
            };
            method = type.GetMethod("SignInWithGooglePlay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SignInWithGooglePlay_18);
            args = new Type[] { };
            method = type.GetMethod("SignInWithMeta", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SignInWithMeta_19);
            args = new Type[] { };
            method = type.GetMethod("SignInWithCache", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SignInWithCache_20);
            args = new Type[] { };
            method = type.GetMethod("SignInWithAnonymous", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SignInWithAnonymous_21);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("SignOut", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SignOut_22);
            args = new Type[] { };
            method = type.GetMethod("DeleteAccount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DeleteAccount_23);
            args = new Type[] { };
            method = type.GetMethod("GetUserInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetUserInfo_24);
            args = new Type[] { };
            method = type.GetMethod("get_IsSignedIn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsSignedIn_25);
            args = new Type[] { };
            method = type.GetMethod("get_IsAuthorized", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsAuthorized_26);
            args = new Type[] { };
            method = type.GetMethod("get_IsExpired", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsExpired_27);
            args = new Type[] { };
            method = type.GetMethod("get_SessionTokenExists", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_SessionTokenExists_28);


            app.RegisterCLRCreateDefaultInstance(type,
                () => new Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager());
            app.RegisterCLRCreateArrayInstance(type,
                s => new Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager[s]);

            args = new Type[] { };
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static StackObject* add_SignedInCallback_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action) typeof(System.Action).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.SignedInCallback += value;

            return __ret;
        }

        static StackObject* remove_SignedInCallback_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action) typeof(System.Action).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.SignedInCallback -= value;

            return __ret;
        }

        static StackObject* add_SignOutCallback_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action) typeof(System.Action).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.SignOutCallback += value;

            return __ret;
        }

        static StackObject* remove_SignOutCallback_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action) typeof(System.Action).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.SignOutCallback -= value;

            return __ret;
        }

        static StackObject* add_SignFailedCallback_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<Unity.Services.Core.RequestFailedException> @value =
                (System.Action<Unity.Services.Core.RequestFailedException>)
                typeof(System.Action<Unity.Services.Core.RequestFailedException>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.SignFailedCallback += value;

            return __ret;
        }

        static StackObject* remove_SignFailedCallback_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<Unity.Services.Core.RequestFailedException> @value =
                (System.Action<Unity.Services.Core.RequestFailedException>)
                typeof(System.Action<Unity.Services.Core.RequestFailedException>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.SignFailedCallback -= value;

            return __ret;
        }

        static StackObject* add_SignInCodeReceivedCallback_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<Unity.Services.Authentication.SignInCodeInfo> @value =
                (System.Action<Unity.Services.Authentication.SignInCodeInfo>)
                typeof(System.Action<Unity.Services.Authentication.SignInCodeInfo>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.SignInCodeReceivedCallback += value;

            return __ret;
        }

        static StackObject* remove_SignInCodeReceivedCallback_7(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<Unity.Services.Authentication.SignInCodeInfo> @value =
                (System.Action<Unity.Services.Authentication.SignInCodeInfo>)
                typeof(System.Action<Unity.Services.Authentication.SignInCodeInfo>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.SignInCodeReceivedCallback -= value;

            return __ret;
        }

        static StackObject* add_SignInCodeExpiredCallback_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action) typeof(System.Action).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.SignInCodeExpiredCallback += value;

            return __ret;
        }

        static StackObject* remove_SignInCodeExpiredCallback_9(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action) typeof(System.Action).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.SignInCodeExpiredCallback -= value;

            return __ret;
        }

        static StackObject* add_ExpiredCallback_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action) typeof(System.Action).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.ExpiredCallback += value;

            return __ret;
        }

        static StackObject* remove_ExpiredCallback_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action) typeof(System.Action).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.ExpiredCallback -= value;

            return __ret;
        }

        static StackObject* InitServices_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.InitServices();

            return __ret;
        }

        static StackObject* SignInUserNameWithPassword_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.String> @_error =
                (System.Action<System.String>) typeof(System.Action<System.String>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_pwd = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_userName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.SignInUserNameWithPassword(@_userName,
                    @_pwd, @_error);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* UpdateUserNamePassword_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_newPwd = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_currentPwd = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.UpdateUserNamePassword(@_currentPwd,
                    @_newPwd);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SignUpUserNameWithPassword_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.String> @_error =
                (System.Action<System.String>) typeof(System.Action<System.String>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_newPwd = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_userName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.SignUpUserNameWithPassword(@_userName,
                    @_newPwd, @_error);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SignInWithApple_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.SignInWithApple();
            return __ret;
        }


        static StackObject* SignInWithGooglePlay_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.SignInWithGooglePlay();

            return __ret;
        }

        static StackObject* SignInWithMeta_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.SignInWithMeta();
            return __ret;
        }

        static StackObject* SignInWithCache_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            var result_of_this_method =
                Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.SignInWithCache();

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SignInWithAnonymous_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            var result_of_this_method =
                Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.SignInWithAnonymous();

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SignOut_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_profileName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.SignOut(@_profileName);

            return __ret;
        }

        static StackObject* DeleteAccount_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.DeleteAccount();

            return __ret;
        }

        static StackObject* GetUserInfo_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.GetUserInfo();

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_IsSignedIn_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.IsSignedIn;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_IsAuthorized_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.IsAuthorized;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_IsExpired_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.IsExpired;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_SessionTokenExists_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method =
                Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager.SessionTokenExists;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.GameServices.Runtime.AuthenticationSystemManager();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}
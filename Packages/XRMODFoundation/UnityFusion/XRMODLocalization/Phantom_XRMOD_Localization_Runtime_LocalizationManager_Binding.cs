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
    unsafe class Phantom_XRMOD_Localization_Runtime_LocalizationManager_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.Localization.Runtime.LocalizationManager);
            args = new Type[] { };
            method = type.GetMethod("get_Instance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Instance_0);
            args = new Type[]
            {
                typeof(System.String), typeof(System.Byte[]), typeof(System.String),
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope)
            };
            method = type.GetMethod("Initialized", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Initialized_1);
            args = new Type[] {typeof(System.String), typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope)};
            method = type.GetMethod("GetLocalizedString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLocalizedString_3);
            args = new Type[]
            {
                typeof(System.Byte[]), typeof(System.String),
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope)
            };
            method = type.GetMethod("ChangeLanguage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ChangeLanguage_3);


            #region v1

            args = new Type[]
            {
                typeof(System.String), typeof(System.Byte[]), typeof(System.String),
                typeof(Phantom.XRMOD.Localization.Runtime.AvailablePlace)
            };
            method = type.GetMethod("Initialized", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Initialized_2);

            
            args = new Type[] {typeof(System.String), typeof(Phantom.XRMOD.Localization.Runtime.AvailablePlace)};
            method = type.GetMethod("GetLocalizedString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLocalizedString_2);
            args = new Type[]
            {
                typeof(System.Byte[]), typeof(System.String),
                typeof(Phantom.XRMOD.Localization.Runtime.AvailablePlace)
            };
            method = type.GetMethod("ChangeLanguage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ChangeLanguage_4);
            
            #endregion


            app.RegisterCLRCreateArrayInstance(type,
                s => new Phantom.XRMOD.Localization.Runtime.LocalizationManager[s]);
        }


        static StackObject* get_Instance_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.Localization.Runtime.LocalizationManager.Instance;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Initialized_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.LocalizationScope tmp_LocalizationScope =
                (Phantom.XRMOD.Localization.Runtime.LocalizationScope)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_language = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Byte[] @_localizationTable = (System.Byte[]) typeof(System.Byte[]).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String @_proejctName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            Phantom.XRMOD.Localization.Runtime.LocalizationManager instance_of_this_method =
                (Phantom.XRMOD.Localization.Runtime.LocalizationManager)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationManager).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Initialized(@_proejctName, @_localizationTable, @_language, tmp_LocalizationScope);

            return __ret;
        }

        static StackObject* Initialized_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.AvailablePlace tmp_LocalizationScope =
                (Phantom.XRMOD.Localization.Runtime.AvailablePlace)
                typeof(Phantom.XRMOD.Localization.Runtime.AvailablePlace).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_language = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Byte[] @_localizationTable = (System.Byte[]) typeof(System.Byte[]).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String @_proejctName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            Phantom.XRMOD.Localization.Runtime.LocalizationManager instance_of_this_method =
                (Phantom.XRMOD.Localization.Runtime.LocalizationManager)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationManager).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Initialized(@_proejctName, @_localizationTable, @_language, tmp_LocalizationScope);

            return __ret;
        }

        static StackObject* GetLocalizedString_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.LocalizationScope @_place =
                (Phantom.XRMOD.Localization.Runtime.LocalizationScope)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_key = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.Localization.Runtime.LocalizationManager instance_of_this_method =
                (Phantom.XRMOD.Localization.Runtime.LocalizationManager)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationManager).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetLocalizedString(@_key, @_place);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
        
        static StackObject* GetLocalizedString_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.AvailablePlace @_place =
                (Phantom.XRMOD.Localization.Runtime.AvailablePlace)
                typeof(Phantom.XRMOD.Localization.Runtime.AvailablePlace).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_key = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.Localization.Runtime.LocalizationManager instance_of_this_method =
                (Phantom.XRMOD.Localization.Runtime.LocalizationManager)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationManager).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetLocalizedString(@_key, @_place);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ChangeLanguage_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.LocalizationScope tmp_LocalizationScope =
                (Phantom.XRMOD.Localization.Runtime.LocalizationScope)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_language = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Byte[] @_localizationTable = (System.Byte[]) typeof(System.Byte[]).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.Localization.Runtime.LocalizationManager instance_of_this_method =
                (Phantom.XRMOD.Localization.Runtime.LocalizationManager)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationManager).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ChangeLanguage(@_localizationTable, @_language, tmp_LocalizationScope);

            return __ret;
        }
        
        static StackObject* ChangeLanguage_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.AvailablePlace tmp_LocalizationScope =
                (Phantom.XRMOD.Localization.Runtime.AvailablePlace)
                typeof(Phantom.XRMOD.Localization.Runtime.AvailablePlace).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_language = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Byte[] @_localizationTable = (System.Byte[]) typeof(System.Byte[]).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.Localization.Runtime.LocalizationManager instance_of_this_method =
                (Phantom.XRMOD.Localization.Runtime.LocalizationManager)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationManager).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ChangeLanguage(@_localizationTable, @_language, tmp_LocalizationScope);

            return __ret;
        }
    }
}
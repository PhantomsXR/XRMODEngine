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
    unsafe class Phantom_XRMOD_Localization_Runtime_LocalizationManagerV2_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2);
            args = new Type[] { };
            method = type.GetMethod("get_Instance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Instance_0);
            args = new Type[] { };
            method = type.GetMethod("get_CurrentLanguage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_CurrentLanguage_1);
            args = new Type[] {typeof(System.Action<UnityEngine.SystemLanguage>)};
            method = type.GetMethod("add_OnLanguageChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnLanguageChanged_2);
            args = new Type[] {typeof(System.Action<UnityEngine.SystemLanguage>)};
            method = type.GetMethod("remove_OnLanguageChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnLanguageChanged_3);
            args = new Type[] { };
            method = type.GetMethod("get_ProjectName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ProjectName_4);
            args = new Type[] { };
            method = type.GetMethod("get_Platform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Platform_5);
            args = new Type[] { };
            method = type.GetMethod("get_Database", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Database_6);
            args = new Type[]
            {
                typeof(System.String), typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope),
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationDatabase), typeof(UnityEngine.SystemLanguage),
                typeof(Phantom.XRMOD.XRMODUtilites.Runtime.XRMODPlatform)
            };
            method = type.GetMethod("Initialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Initialize_7);
            args = new Type[]
            {
                typeof(System.String), typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope),
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationDatabase),
                typeof(Phantom.XRMOD.XRMODUtilites.Runtime.XRMODPlatform)
            };
            method = type.GetMethod("Initialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Initialize_7_1);
            args = new Type[] {typeof(UnityEngine.SystemLanguage)};
            method = type.GetMethod("SetLanguage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLanguage_8);
            args = new Type[] {typeof(System.String), typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope)};
            method = type.GetMethod("GetLocalizedTemplate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLocalizedTemplate_9);
            args = new Type[] {typeof(System.String), typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope)};
            method = type.GetMethod("Release", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Release_10);


            app.RegisterCLRCreateArrayInstance(type,
                s => new Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2[s]);
        }


        static StackObject* get_Instance_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2.Instance;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_CurrentLanguage_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2 instance_of_this_method =
                (Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CurrentLanguage;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* add_OnLanguageChanged_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.SystemLanguage> @value =
                (System.Action<UnityEngine.SystemLanguage>) typeof(System.Action<UnityEngine.SystemLanguage>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2.OnLanguageChanged += value;

            return __ret;
        }

        static StackObject* remove_OnLanguageChanged_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.SystemLanguage> @value =
                (System.Action<UnityEngine.SystemLanguage>) typeof(System.Action<UnityEngine.SystemLanguage>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2.OnLanguageChanged -= value;

            return __ret;
        }

        static StackObject* get_ProjectName_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2 instance_of_this_method =
                (Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ProjectName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Platform_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2 instance_of_this_method =
                (Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Platform;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Database_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2 instance_of_this_method =
                (Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Database;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Initialize_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODUtilites.Runtime.XRMODPlatform @_platform =
                (Phantom.XRMOD.XRMODUtilites.Runtime.XRMODPlatform)
                typeof(Phantom.XRMOD.XRMODUtilites.Runtime.XRMODPlatform).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.SystemLanguage @_language =
                (UnityEngine.SystemLanguage) typeof(UnityEngine.SystemLanguage).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.Localization.Runtime.LocalizationDatabase @_database =
                (Phantom.XRMOD.Localization.Runtime.LocalizationDatabase)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationDatabase).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.Localization.Runtime.LocalizationScope @_scope =
                (Phantom.XRMOD.Localization.Runtime.LocalizationScope)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.String @_project = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2 instance_of_this_method =
                (Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Initialize(@_project, @_scope, @_database, @_language, @_platform);

            return __ret;
        }

        static StackObject* Initialize_7_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.LocalizationDatabase @_database =
                (Phantom.XRMOD.Localization.Runtime.LocalizationDatabase)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationDatabase).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.Localization.Runtime.LocalizationScope @_scope =
                (Phantom.XRMOD.Localization.Runtime.LocalizationScope)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_project = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2 instance_of_this_method =
                (Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Initialize(@_project, @_scope, @_database);

            return __ret;
        }

        static StackObject* SetLanguage_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SystemLanguage @_newLang =
                (UnityEngine.SystemLanguage) typeof(UnityEngine.SystemLanguage).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2 instance_of_this_method =
                (Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetLanguage(@_newLang);

            return __ret;
        }

        static StackObject* GetLocalizedTemplate_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.LocalizationScope @_scope =
                (Phantom.XRMOD.Localization.Runtime.LocalizationScope)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_key = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2 instance_of_this_method =
                (Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetLocalizedTemplate(@_key, @_scope);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Release_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.Localization.Runtime.LocalizationScope @_scope =
                (Phantom.XRMOD.Localization.Runtime.LocalizationScope)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationScope).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_projectName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2 instance_of_this_method =
                (Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2)
                typeof(Phantom.XRMOD.Localization.Runtime.LocalizationManagerV2).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Release(@_projectName, @_scope);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }
    }
}
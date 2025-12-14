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
    unsafe class UnityEngine_Device_Application_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Device.Application);
            args = new Type[]{};
            method = type.GetMethod("get_absoluteURL", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_absoluteURL_0);
            args = new Type[]{};
            method = type.GetMethod("get_backgroundLoadingPriority", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_backgroundLoadingPriority_1);
            args = new Type[]{typeof(UnityEngine.ThreadPriority)};
            method = type.GetMethod("set_backgroundLoadingPriority", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_backgroundLoadingPriority_2);
            args = new Type[]{};
            method = type.GetMethod("get_buildGUID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_buildGUID_3);
            args = new Type[]{};
            method = type.GetMethod("get_cloudProjectId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cloudProjectId_4);
            args = new Type[]{};
            method = type.GetMethod("get_companyName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_companyName_5);
            args = new Type[]{};
            method = type.GetMethod("get_consoleLogPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_consoleLogPath_6);
            args = new Type[]{};
            method = type.GetMethod("get_dataPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_dataPath_7);
            args = new Type[]{};
            method = type.GetMethod("get_genuine", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_genuine_8);
            args = new Type[]{};
            method = type.GetMethod("get_genuineCheckAvailable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_genuineCheckAvailable_9);
            args = new Type[]{};
            method = type.GetMethod("get_identifier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_identifier_10);
            args = new Type[]{};
            method = type.GetMethod("get_installerName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_installerName_11);
            args = new Type[]{};
            method = type.GetMethod("get_installMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_installMode_12);
            args = new Type[]{};
            method = type.GetMethod("get_internetReachability", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_internetReachability_13);
            args = new Type[]{};
            method = type.GetMethod("get_isBatchMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isBatchMode_14);
            args = new Type[]{};
            method = type.GetMethod("get_isConsolePlatform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isConsolePlatform_15);
            args = new Type[]{};
            method = type.GetMethod("get_isEditor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isEditor_16);
            args = new Type[]{};
            method = type.GetMethod("get_isFocused", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isFocused_17);
            args = new Type[]{};
            method = type.GetMethod("get_isMobilePlatform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isMobilePlatform_18);
            args = new Type[]{};
            method = type.GetMethod("get_isPlaying", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isPlaying_19);
            args = new Type[]{};
            method = type.GetMethod("get_persistentDataPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_persistentDataPath_20);
            args = new Type[]{};
            method = type.GetMethod("get_platform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_platform_21);
            args = new Type[]{};
            method = type.GetMethod("get_productName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_productName_22);
            args = new Type[]{};
            method = type.GetMethod("get_runInBackground", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_runInBackground_23);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_runInBackground", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_runInBackground_24);
            args = new Type[]{};
            method = type.GetMethod("get_sandboxType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sandboxType_25);
            args = new Type[]{};
            method = type.GetMethod("get_streamingAssetsPath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_streamingAssetsPath_26);
            args = new Type[]{};
            method = type.GetMethod("get_systemLanguage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_systemLanguage_27);
            args = new Type[]{};
            method = type.GetMethod("get_targetFrameRate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_targetFrameRate_28);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_targetFrameRate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_targetFrameRate_29);
            args = new Type[]{};
            method = type.GetMethod("get_temporaryCachePath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_temporaryCachePath_30);
            args = new Type[]{};
            method = type.GetMethod("get_unityVersion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_unityVersion_31);
            args = new Type[]{};
            method = type.GetMethod("get_version", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_version_32);
            args = new Type[]{typeof(System.Action<System.String>)};
            method = type.GetMethod("add_deepLinkActivated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_deepLinkActivated_33);
            args = new Type[]{typeof(System.Action<System.String>)};
            method = type.GetMethod("remove_deepLinkActivated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_deepLinkActivated_34);
            args = new Type[]{typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("add_focusChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_focusChanged_35);
            args = new Type[]{typeof(System.Action<System.Boolean>)};
            method = type.GetMethod("remove_focusChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_focusChanged_36);
            args = new Type[]{typeof(UnityEngine.Application.LogCallback)};
            method = type.GetMethod("add_logMessageReceived", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_logMessageReceived_37);
            args = new Type[]{typeof(UnityEngine.Application.LogCallback)};
            method = type.GetMethod("remove_logMessageReceived", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_logMessageReceived_38);
            args = new Type[]{typeof(UnityEngine.Application.LogCallback)};
            method = type.GetMethod("add_logMessageReceivedThreaded", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_logMessageReceivedThreaded_39);
            args = new Type[]{typeof(UnityEngine.Application.LogCallback)};
            method = type.GetMethod("remove_logMessageReceivedThreaded", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_logMessageReceivedThreaded_40);
            args = new Type[]{typeof(UnityEngine.Application.LowMemoryCallback)};
            method = type.GetMethod("add_lowMemory", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_lowMemory_41);
            args = new Type[]{typeof(UnityEngine.Application.LowMemoryCallback)};
            method = type.GetMethod("remove_lowMemory", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_lowMemory_42);
            args = new Type[]{typeof(UnityEngine.Application.MemoryUsageChangedCallback)};
            method = type.GetMethod("add_memoryUsageChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_memoryUsageChanged_43);
            args = new Type[]{typeof(UnityEngine.Application.MemoryUsageChangedCallback)};
            method = type.GetMethod("remove_memoryUsageChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_memoryUsageChanged_44);
            args = new Type[]{typeof(UnityEngine.Events.UnityAction)};
            method = type.GetMethod("add_onBeforeRender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_onBeforeRender_45);
            args = new Type[]{typeof(UnityEngine.Events.UnityAction)};
            method = type.GetMethod("remove_onBeforeRender", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_onBeforeRender_46);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_quitting", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_quitting_47);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_quitting", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_quitting_48);
            args = new Type[]{typeof(System.Func<System.Boolean>)};
            method = type.GetMethod("add_wantsToQuit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_wantsToQuit_49);
            args = new Type[]{typeof(System.Func<System.Boolean>)};
            method = type.GetMethod("remove_wantsToQuit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_wantsToQuit_50);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_unloading", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_unloading_51);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_unloading", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_unloading_52);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("CanStreamedLevelBeLoaded", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CanStreamedLevelBeLoaded_53);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("CanStreamedLevelBeLoaded", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CanStreamedLevelBeLoaded_54);
            args = new Type[]{typeof(UnityEngine.LogType)};
            method = type.GetMethod("GetStackTraceLogType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetStackTraceLogType_55);
            args = new Type[]{};
            method = type.GetMethod("HasProLicense", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HasProLicense_56);
            args = new Type[]{typeof(UnityEngine.UserAuthorization)};
            method = type.GetMethod("HasUserAuthorization", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HasUserAuthorization_57);
            args = new Type[]{typeof(UnityEngine.Object)};
            method = type.GetMethod("IsPlaying", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsPlaying_58);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("OpenURL", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OpenURL_59);
            args = new Type[]{};
            method = type.GetMethod("Quit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Quit_60);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("Quit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Quit_61);
            args = new Type[]{typeof(UnityEngine.Application.AdvertisingIdentifierCallback)};
            method = type.GetMethod("RequestAdvertisingIdentifierAsync", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RequestAdvertisingIdentifierAsync_62);
            args = new Type[]{typeof(UnityEngine.UserAuthorization)};
            method = type.GetMethod("RequestUserAuthorization", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RequestUserAuthorization_63);
            args = new Type[]{typeof(UnityEngine.LogType), typeof(UnityEngine.StackTraceLogType)};
            method = type.GetMethod("SetStackTraceLogType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetStackTraceLogType_64);
            args = new Type[]{};
            method = type.GetMethod("Unload", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Unload_65);
            args = new Type[]{};
            method = type.GetMethod("get_exitCancellationToken", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_exitCancellationToken_66);





        }


        static StackObject* get_absoluteURL_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.absoluteURL;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_backgroundLoadingPriority_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.backgroundLoadingPriority;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_backgroundLoadingPriority_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ThreadPriority @value = (UnityEngine.ThreadPriority)typeof(UnityEngine.ThreadPriority).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.backgroundLoadingPriority = value;

            return __ret;
        }

        static StackObject* get_buildGUID_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.buildGUID;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_cloudProjectId_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.cloudProjectId;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_companyName_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.companyName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_consoleLogPath_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.consoleLogPath;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_dataPath_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.dataPath;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_genuine_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.genuine;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_genuineCheckAvailable_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.genuineCheckAvailable;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_identifier_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.identifier;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_installerName_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.installerName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_installMode_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.installMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_internetReachability_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.internetReachability;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_isBatchMode_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.isBatchMode;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isConsolePlatform_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.isConsolePlatform;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isEditor_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.isEditor;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isFocused_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.isFocused;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isMobilePlatform_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.isMobilePlatform;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_isPlaying_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.isPlaying;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_persistentDataPath_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.persistentDataPath;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_platform_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.platform;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_productName_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.productName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_runInBackground_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.runInBackground;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_runInBackground_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Device.Application.runInBackground = value;

            return __ret;
        }

        static StackObject* get_sandboxType_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.sandboxType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_streamingAssetsPath_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.streamingAssetsPath;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_systemLanguage_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.systemLanguage;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_targetFrameRate_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.targetFrameRate;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_targetFrameRate_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.Device.Application.targetFrameRate = value;

            return __ret;
        }

        static StackObject* get_temporaryCachePath_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.temporaryCachePath;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_unityVersion_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.unityVersion;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_version_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.version;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* add_deepLinkActivated_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.String> @value = (System.Action<System.String>)typeof(System.Action<System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.deepLinkActivated += value;

            return __ret;
        }

        static StackObject* remove_deepLinkActivated_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.String> @value = (System.Action<System.String>)typeof(System.Action<System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.deepLinkActivated -= value;

            return __ret;
        }

        static StackObject* add_focusChanged_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> @value = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.focusChanged += value;

            return __ret;
        }

        static StackObject* remove_focusChanged_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Boolean> @value = (System.Action<System.Boolean>)typeof(System.Action<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.focusChanged -= value;

            return __ret;
        }

        static StackObject* add_logMessageReceived_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Application.LogCallback @value = (UnityEngine.Application.LogCallback)typeof(UnityEngine.Application.LogCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.logMessageReceived += value;

            return __ret;
        }

        static StackObject* remove_logMessageReceived_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Application.LogCallback @value = (UnityEngine.Application.LogCallback)typeof(UnityEngine.Application.LogCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.logMessageReceived -= value;

            return __ret;
        }

        static StackObject* add_logMessageReceivedThreaded_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Application.LogCallback @value = (UnityEngine.Application.LogCallback)typeof(UnityEngine.Application.LogCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.logMessageReceivedThreaded += value;

            return __ret;
        }

        static StackObject* remove_logMessageReceivedThreaded_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Application.LogCallback @value = (UnityEngine.Application.LogCallback)typeof(UnityEngine.Application.LogCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.logMessageReceivedThreaded -= value;

            return __ret;
        }

        static StackObject* add_lowMemory_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Application.LowMemoryCallback @value = (UnityEngine.Application.LowMemoryCallback)typeof(UnityEngine.Application.LowMemoryCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.lowMemory += value;

            return __ret;
        }

        static StackObject* remove_lowMemory_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Application.LowMemoryCallback @value = (UnityEngine.Application.LowMemoryCallback)typeof(UnityEngine.Application.LowMemoryCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.lowMemory -= value;

            return __ret;
        }

        static StackObject* add_memoryUsageChanged_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Application.MemoryUsageChangedCallback @value = (UnityEngine.Application.MemoryUsageChangedCallback)typeof(UnityEngine.Application.MemoryUsageChangedCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.memoryUsageChanged += value;

            return __ret;
        }

        static StackObject* remove_memoryUsageChanged_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Application.MemoryUsageChangedCallback @value = (UnityEngine.Application.MemoryUsageChangedCallback)typeof(UnityEngine.Application.MemoryUsageChangedCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.memoryUsageChanged -= value;

            return __ret;
        }

        static StackObject* add_onBeforeRender_45(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Events.UnityAction @value = (UnityEngine.Events.UnityAction)typeof(UnityEngine.Events.UnityAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.onBeforeRender += value;

            return __ret;
        }

        static StackObject* remove_onBeforeRender_46(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Events.UnityAction @value = (UnityEngine.Events.UnityAction)typeof(UnityEngine.Events.UnityAction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.onBeforeRender -= value;

            return __ret;
        }

        static StackObject* add_quitting_47(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.quitting += value;

            return __ret;
        }

        static StackObject* remove_quitting_48(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.quitting -= value;

            return __ret;
        }

        static StackObject* add_wantsToQuit_49(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Func<System.Boolean> @value = (System.Func<System.Boolean>)typeof(System.Func<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.wantsToQuit += value;

            return __ret;
        }

        static StackObject* remove_wantsToQuit_50(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Func<System.Boolean> @value = (System.Func<System.Boolean>)typeof(System.Func<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.wantsToQuit -= value;

            return __ret;
        }

        static StackObject* add_unloading_51(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.unloading += value;

            return __ret;
        }

        static StackObject* remove_unloading_52(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.unloading -= value;

            return __ret;
        }

        static StackObject* CanStreamedLevelBeLoaded_53(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @levelIndex = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Device.Application.CanStreamedLevelBeLoaded(@levelIndex);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* CanStreamedLevelBeLoaded_54(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @levelName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Device.Application.CanStreamedLevelBeLoaded(@levelName);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetStackTraceLogType_55(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LogType @logType = (UnityEngine.LogType)typeof(UnityEngine.LogType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Device.Application.GetStackTraceLogType(@logType);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* HasProLicense_56(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.HasProLicense();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* HasUserAuthorization_57(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.UserAuthorization @mode = (UnityEngine.UserAuthorization)typeof(UnityEngine.UserAuthorization).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Device.Application.HasUserAuthorization(@mode);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsPlaying_58(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Object @obj = (UnityEngine.Object)typeof(UnityEngine.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Device.Application.IsPlaying(@obj);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* OpenURL_59(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @url = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.OpenURL(@url);

            return __ret;
        }

        static StackObject* Quit_60(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.Device.Application.Quit();

            return __ret;
        }

        static StackObject* Quit_61(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @exitCode = ptr_of_this_method->Value;


            UnityEngine.Device.Application.Quit(@exitCode);

            return __ret;
        }

        static StackObject* RequestAdvertisingIdentifierAsync_62(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Application.AdvertisingIdentifierCallback @delegateMethod = (UnityEngine.Application.AdvertisingIdentifierCallback)typeof(UnityEngine.Application.AdvertisingIdentifierCallback).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Device.Application.RequestAdvertisingIdentifierAsync(@delegateMethod);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RequestUserAuthorization_63(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.UserAuthorization @mode = (UnityEngine.UserAuthorization)typeof(UnityEngine.UserAuthorization).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Device.Application.RequestUserAuthorization(@mode);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetStackTraceLogType_64(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.StackTraceLogType @stackTraceType = (UnityEngine.StackTraceLogType)typeof(UnityEngine.StackTraceLogType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LogType @logType = (UnityEngine.LogType)typeof(UnityEngine.LogType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Device.Application.SetStackTraceLogType(@logType, @stackTraceType);

            return __ret;
        }

        static StackObject* Unload_65(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.Device.Application.Unload();

            return __ret;
        }

        static StackObject* get_exitCancellationToken_66(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Device.Application.exitCancellationToken;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }





    }
}

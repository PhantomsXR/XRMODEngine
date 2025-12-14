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
    unsafe class Phantom_XRMOD_XRMODUtilites_Runtime_APICallback_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODUtilites.Runtime.APICallback);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_DeviceNotSupportEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_DeviceNotSupportEventHandle_0);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_DeviceNotSupportEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_DeviceNotSupportEventHandle_1);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_ExperienceStartLoadEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_ExperienceStartLoadEventHandle_2);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_ExperienceStartLoadEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_ExperienceStartLoadEventHandle_3);
            args = new Type[]{typeof(System.Action<System.Single>)};
            method = type.GetMethod("add_ExperienceLoadingEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_ExperienceLoadingEventHandle_4);
            args = new Type[]{typeof(System.Action<System.Single>)};
            method = type.GetMethod("remove_ExperienceLoadingEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_ExperienceLoadingEventHandle_5);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_ExperienceLoadCompletedEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_ExperienceLoadCompletedEventHandle_6);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_ExperienceLoadCompletedEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_ExperienceLoadCompletedEventHandle_7);
            args = new Type[]{typeof(System.Action<System.String, System.Int32>)};
            method = type.GetMethod("add_ThrowExceptionEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_ThrowExceptionEventHandle_8);
            args = new Type[]{typeof(System.Action<System.String, System.Int32>)};
            method = type.GetMethod("remove_ThrowExceptionEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_ThrowExceptionEventHandle_9);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_SdkInitializedEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_SdkInitializedEventHandle_10);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_SdkInitializedEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_SdkInitializedEventHandle_11);
            args = new Type[]{typeof(System.Action<System.String>)};
            method = type.GetMethod("add_OpenBuiltInBrowserEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OpenBuiltInBrowserEventHandle_12);
            args = new Type[]{typeof(System.Action<System.String>)};
            method = type.GetMethod("remove_OpenBuiltInBrowserEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OpenBuiltInBrowserEventHandle_13);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_RecognitionStartEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_RecognitionStartEventHandle_14);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_RecognitionStartEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_RecognitionStartEventHandle_15);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_RecognitionCompleteEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_RecognitionCompleteEventHandle_16);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_RecognitionCompleteEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_RecognitionCompleteEventHandle_17);
            args = new Type[]{typeof(System.Action<System.String, Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationDelegate>)};
            method = type.GetMethod("add_TryAcquireInformationEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_TryAcquireInformationEventHandle_18);
            args = new Type[]{typeof(System.Action<System.String, Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationDelegate>)};
            method = type.GetMethod("remove_TryAcquireInformationEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_TryAcquireInformationEventHandle_19);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_NeedInstallARCoreServicesEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_NeedInstallARCoreServicesEventHandle_20);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_NeedInstallARCoreServicesEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_NeedInstallARCoreServicesEventHandle_21);
            args = new Type[]{typeof(System.Action<System.Single, System.Single>)};
            method = type.GetMethod("add_PackageSizeMoreThanPresetSizeEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_PackageSizeMoreThanPresetSizeEventHandle_22);
            args = new Type[]{typeof(System.Action<System.Single, System.Single>)};
            method = type.GetMethod("remove_PackageSizeMoreThanPresetSizeEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_PackageSizeMoreThanPresetSizeEventHandle_23);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_OnXRMODExitEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnXRMODExitEventHandle_24);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_OnXRMODExitEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnXRMODExitEventHandle_25);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_OnXRMODLaunchEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnXRMODLaunchEventHandle_26);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_OnXRMODLaunchEventHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnXRMODLaunchEventHandle_27);
            args = new Type[]{typeof(System.Action<System.String>)};
            method = type.GetMethod("add_OnMessageReceivedHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnMessageReceivedHandle_28);
            args = new Type[]{typeof(System.Action<System.String>)};
            method = type.GetMethod("remove_OnMessageReceivedHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnMessageReceivedHandle_29);
            args = new Type[]{};
            method = type.GetMethod("DeviceNotSupport", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DeviceNotSupport_30);
            args = new Type[]{};
            method = type.GetMethod("ExperienceStartLoad", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ExperienceStartLoad_31);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("ExperienceLoading", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ExperienceLoading_32);
            args = new Type[]{};
            method = type.GetMethod("ExperienceLoadCompleted", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ExperienceLoadCompleted_33);
            args = new Type[]{typeof(System.String), typeof(System.Int32)};
            method = type.GetMethod("ThrowException", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ThrowException_34);
            args = new Type[]{};
            method = type.GetMethod("SdkInitialized", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SdkInitialized_35);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("OpenBuiltInBrowser", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OpenBuiltInBrowser_36);
            args = new Type[]{};
            method = type.GetMethod("RecognitionStart", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RecognitionStart_37);
            args = new Type[]{};
            method = type.GetMethod("RecognitionComplete", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RecognitionComplete_38);
            args = new Type[]{typeof(System.String), typeof(Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationDelegate)};
            method = type.GetMethod("TryAcquireInformation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireInformation_39);
            args = new Type[]{};
            method = type.GetMethod("NeedInstallARCoreServices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, NeedInstallARCoreServices_40);
            args = new Type[]{typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("PackageSizeMoreThanPresetSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PackageSizeMoreThanPresetSize_41);
            args = new Type[]{};
            method = type.GetMethod("OnXRMODExit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnXRMODExit_42);
            args = new Type[]{};
            method = type.GetMethod("OnXRMODLaunch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnXRMODLaunch_43);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("SendMessageToSDK", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendMessageToSDK_44);

            field = type.GetField("TryAcquireInformationAction", flag);
            app.RegisterCLRFieldGetter(field, get_TryAcquireInformationAction_0);
            app.RegisterCLRFieldSetter(field, set_TryAcquireInformationAction_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_TryAcquireInformationAction_0, AssignFromStack_TryAcquireInformationAction_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODUtilites.Runtime.APICallback());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODUtilites.Runtime.APICallback[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* add_DeviceNotSupportEventHandle_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.DeviceNotSupportEventHandle += value;

            return __ret;
        }

        static StackObject* remove_DeviceNotSupportEventHandle_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.DeviceNotSupportEventHandle -= value;

            return __ret;
        }

        static StackObject* add_ExperienceStartLoadEventHandle_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.ExperienceStartLoadEventHandle += value;

            return __ret;
        }

        static StackObject* remove_ExperienceStartLoadEventHandle_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.ExperienceStartLoadEventHandle -= value;

            return __ret;
        }

        static StackObject* add_ExperienceLoadingEventHandle_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Single> @value = (System.Action<System.Single>)typeof(System.Action<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.ExperienceLoadingEventHandle += value;

            return __ret;
        }

        static StackObject* remove_ExperienceLoadingEventHandle_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Single> @value = (System.Action<System.Single>)typeof(System.Action<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.ExperienceLoadingEventHandle -= value;

            return __ret;
        }

        static StackObject* add_ExperienceLoadCompletedEventHandle_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.ExperienceLoadCompletedEventHandle += value;

            return __ret;
        }

        static StackObject* remove_ExperienceLoadCompletedEventHandle_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.ExperienceLoadCompletedEventHandle -= value;

            return __ret;
        }

        static StackObject* add_ThrowExceptionEventHandle_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.String, System.Int32> @value = (System.Action<System.String, System.Int32>)typeof(System.Action<System.String, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.ThrowExceptionEventHandle += value;

            return __ret;
        }

        static StackObject* remove_ThrowExceptionEventHandle_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.String, System.Int32> @value = (System.Action<System.String, System.Int32>)typeof(System.Action<System.String, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.ThrowExceptionEventHandle -= value;

            return __ret;
        }

        static StackObject* add_SdkInitializedEventHandle_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.SdkInitializedEventHandle += value;

            return __ret;
        }

        static StackObject* remove_SdkInitializedEventHandle_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.SdkInitializedEventHandle -= value;

            return __ret;
        }

        static StackObject* add_OpenBuiltInBrowserEventHandle_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.String> @value = (System.Action<System.String>)typeof(System.Action<System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.OpenBuiltInBrowserEventHandle += value;

            return __ret;
        }

        static StackObject* remove_OpenBuiltInBrowserEventHandle_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.String> @value = (System.Action<System.String>)typeof(System.Action<System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.OpenBuiltInBrowserEventHandle -= value;

            return __ret;
        }

        static StackObject* add_RecognitionStartEventHandle_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.RecognitionStartEventHandle += value;

            return __ret;
        }

        static StackObject* remove_RecognitionStartEventHandle_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.RecognitionStartEventHandle -= value;

            return __ret;
        }

        static StackObject* add_RecognitionCompleteEventHandle_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.RecognitionCompleteEventHandle += value;

            return __ret;
        }

        static StackObject* remove_RecognitionCompleteEventHandle_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.RecognitionCompleteEventHandle -= value;

            return __ret;
        }

        static StackObject* add_TryAcquireInformationEventHandle_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.String, Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationDelegate> @value = (System.Action<System.String, Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationDelegate>)typeof(System.Action<System.String, Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationDelegate>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationEventHandle += value;

            return __ret;
        }

        static StackObject* remove_TryAcquireInformationEventHandle_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.String, Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationDelegate> @value = (System.Action<System.String, Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationDelegate>)typeof(System.Action<System.String, Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationDelegate>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationEventHandle -= value;

            return __ret;
        }

        static StackObject* add_NeedInstallARCoreServicesEventHandle_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.NeedInstallARCoreServicesEventHandle += value;

            return __ret;
        }

        static StackObject* remove_NeedInstallARCoreServicesEventHandle_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.NeedInstallARCoreServicesEventHandle -= value;

            return __ret;
        }

        static StackObject* add_PackageSizeMoreThanPresetSizeEventHandle_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Single, System.Single> @value = (System.Action<System.Single, System.Single>)typeof(System.Action<System.Single, System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.PackageSizeMoreThanPresetSizeEventHandle += value;

            return __ret;
        }

        static StackObject* remove_PackageSizeMoreThanPresetSizeEventHandle_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Single, System.Single> @value = (System.Action<System.Single, System.Single>)typeof(System.Action<System.Single, System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.PackageSizeMoreThanPresetSizeEventHandle -= value;

            return __ret;
        }

        static StackObject* add_OnXRMODExitEventHandle_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.OnXRMODExitEventHandle += value;

            return __ret;
        }

        static StackObject* remove_OnXRMODExitEventHandle_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.OnXRMODExitEventHandle -= value;

            return __ret;
        }

        static StackObject* add_OnXRMODLaunchEventHandle_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.OnXRMODLaunchEventHandle += value;

            return __ret;
        }

        static StackObject* remove_OnXRMODLaunchEventHandle_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.OnXRMODLaunchEventHandle -= value;

            return __ret;
        }

        static StackObject* add_OnMessageReceivedHandle_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.String> @value = (System.Action<System.String>)typeof(System.Action<System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.OnMessageReceivedHandle += value;

            return __ret;
        }

        static StackObject* remove_OnMessageReceivedHandle_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.String> @value = (System.Action<System.String>)typeof(System.Action<System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.OnMessageReceivedHandle -= value;

            return __ret;
        }

        static StackObject* DeviceNotSupport_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.DeviceNotSupport();

            return __ret;
        }

        static StackObject* ExperienceStartLoad_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.ExperienceStartLoad();

            return __ret;
        }

        static StackObject* ExperienceLoading_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @_progressValue = *(float*)&ptr_of_this_method->Value;


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.ExperienceLoading(@_progressValue);

            return __ret;
        }

        static StackObject* ExperienceLoadCompleted_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.ExperienceLoadCompleted();

            return __ret;
        }

        static StackObject* ThrowException_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @_errorCode = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_errorMessage = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.ThrowException(@_errorMessage, @_errorCode);

            return __ret;
        }

        static StackObject* SdkInitialized_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.SdkInitialized();

            return __ret;
        }

        static StackObject* OpenBuiltInBrowser_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_url = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.OpenBuiltInBrowser(@_url);

            return __ret;
        }

        static StackObject* RecognitionStart_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.RecognitionStart();

            return __ret;
        }

        static StackObject* RecognitionComplete_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.RecognitionComplete();

            return __ret;
        }

        static StackObject* TryAcquireInformation_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationDelegate @_callback = (Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationDelegate)typeof(Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_opCode = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformation(@_opCode, @_callback);

            return __ret;
        }

        static StackObject* NeedInstallARCoreServices_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.NeedInstallARCoreServices();

            return __ret;
        }

        static StackObject* PackageSizeMoreThanPresetSize_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @_presetSize = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @_currentSize = *(float*)&ptr_of_this_method->Value;


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.PackageSizeMoreThanPresetSize(@_currentSize, @_presetSize);

            return __ret;
        }

        static StackObject* OnXRMODExit_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.OnXRMODExit();

            return __ret;
        }

        static StackObject* OnXRMODLaunch_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.OnXRMODLaunch();

            return __ret;
        }

        static StackObject* SendMessageToSDK_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_data = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.SendMessageToSDK(@_data);

            return __ret;
        }


        static object get_TryAcquireInformationAction_0(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationAction;
        }

        static StackObject* CopyToStack_TryAcquireInformationAction_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationAction;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TryAcquireInformationAction_0(ref object o, object v)
        {
            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationAction = (Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationDelegate)v;
        }

        static StackObject* AssignFromStack_TryAcquireInformationAction_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationDelegate @TryAcquireInformationAction = (Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationDelegate)typeof(Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            Phantom.XRMOD.XRMODUtilites.Runtime.APICallback.TryAcquireInformationAction = @TryAcquireInformationAction;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.XRMODUtilites.Runtime.APICallback();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

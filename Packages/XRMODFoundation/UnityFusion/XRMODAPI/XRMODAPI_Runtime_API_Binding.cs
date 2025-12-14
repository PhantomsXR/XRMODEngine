using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Phantom.XRMOD.UnityFusion.Runtime.CodeHook;
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
    unsafe class XRMODAPI_Runtime_API_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODAPI.Runtime.API);
            args = new Type[] { };
            method = type.GetMethod("get_GetProcessId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GetProcessId_0);
            args = new Type[] { };
            method = type.GetMethod("get_GetProcessContainer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GetProcessContainer_1);
            args = new Type[] { };
            method = type.GetMethod("TryAcquireProcesses", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireProcesses_2);
            args = new Type[] { };
            method = type.GetMethod("TryAcquireProjectInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireProjectInfo_3);
            args = new Type[] { };
            method = type.GetMethod("TryAcquireXRMODEngineCachePath", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireXRMODEngineCachePath_4);
            args = new Type[] { };
            method = type.GetMethod("TryAcquireSdkType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireSdkType_5);
            args = new Type[] { };
            method = type.GetMethod("TryAcquireLaunchConfig", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireLaunchConfig_6);
            args = new Type[]
            {
                typeof(Phantom.XRMOD.ActionNotification.Runtime.SpaceType),
                typeof(System.Nullable<UnityEngine.Vector3>), typeof(System.Nullable<UnityEngine.Vector3>),
                typeof(System.String[]), typeof(Phantom.XRMOD.ActionNotification.Runtime.BoundResizeMode)
            };
            method = type.GetMethod("ChangeSpaceType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ChangeSpaceType_7);
            args = new Type[] { };
            method = type.GetMethod("IsPointerOverUi", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsPointerOverUi_8);
            args = new Type[] {typeof(System.String), typeof(System.String)};
            method = type.GetMethod("SaveKeyAndValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SaveKeyAndValue_9);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("GetValueByKey", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetValueByKey_10);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("RemoveKeyAndValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveKeyAndValue_11);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("LoadUnityScene", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadUnityScene_12);
            args = new Type[] {typeof(System.String), typeof(System.Action<UnityEngine.GameObject>)};
            method = type.GetMethod("TryAcquireNetworkMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireNetworkMesh_13);
            args = new Type[] {typeof(System.String), typeof(System.Action<System.String>)};
            method = type.GetMethod("DownloadNetworkMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DownloadNetworkMesh_14);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("ReleaseProject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReleaseProject_15);
            args = new Type[] { };
            method = type.GetMethod("GetDeviceInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDeviceInfo_16);
            args = new Type[] { };
            method = type.GetMethod("GetSystemLanguage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSystemLanguage_17);
            args = new Type[] {typeof(Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType)};
            method = type.GetMethod("IsPlatform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsPlatform_18);
            args = new Type[] {typeof(UnityEngine.ScreenOrientation)};
            method = type.GetMethod("SetScreenOrientation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetScreenOrientation_19);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("ResizeARWorldScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResizeARWorldScale_20);
            args = new Type[] {typeof(Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmArgs)};
            method = type.GetMethod("ChangeARAlgorithmLife", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ChangeARAlgorithmLife_21);
            args = new Type[]
                {typeof(UnityEngine.Transform), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("MakeContentAppearAt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MakeContentAppearAt_22);
            args = new Type[]
            {
                typeof(UnityEngine.Vector3), typeof(Phantom.XRMOD.ActionNotification.Runtime.TrackableTypeEnum),
                typeof(System.Action<UnityEngine.Pose>)
            };
            method = type.GetMethod("ARRaycast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ARRaycast_23);
            args = new Type[] {typeof(Phantom.XRMOD.ActionNotification.Runtime.TryAcquireCurrentFrameArgs)};
            method = type.GetMethod("TryAcquireCurrentFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireCurrentFrame_24);
            args = new Type[] {typeof(Phantom.XRMOD.ActionNotification.Runtime.AROcclusionArgs)};
            method = type.GetMethod("TryAcquireAROcclusionFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireAROcclusionFrame_25);
            args = new Type[] { };
            method = type.GetMethod("TryAcquireLightEstimateValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireLightEstimateValue_26);
            args = new Type[] { };
            method = type.GetMethod("CheckARAvailability", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CheckARAvailability_27);
            args = new Type[]
            {
                typeof(List<Phantom.XRMOD.ActionNotification.Runtime.DynamicLibraryArgs.ImageData>),
                typeof(System.Action)
            };
            method = type.GetMethod("AddNewImageForTracking", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddNewImageForTracking_28);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("CheckFeatureAvailability", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CheckFeatureAvailability_29);
            args = new Type[] { };
            method = type.GetMethod("TryAcquireSDKVersion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireSDKVersion_30);
            args = new Type[] { };
            method = type.GetMethod("Exit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Exit_31);
            args = new Type[] { };
            method = type.GetMethod("GetAllAnchors", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAllAnchors_32);
            args = new Type[] {typeof(Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)};
            method = type.GetMethod("CreateAnchor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateAnchor_33);
            args = new Type[] { };
            method = type.GetMethod("CaptureEnvironment", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CaptureEnvironment_35);
            args = new Type[] {typeof(System.Guid)};
            method = type.GetMethod("DestroyAnchor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DestroyAnchor_34);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("SaveEnvironmentMapping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SaveEnvironmentMapping_35);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("LoadEnvironmentMapping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LoadEnvironmentMapping_36);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("DeleteEnvironmentMapping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DeleteEnvironmentMapping_37);
            args = new Type[] {typeof(Phantom.XRMOD.ActionNotification.Runtime.OpenInBuiltInBrowserArgs)};
            method = type.GetMethod("OpenBuiltInBrowser", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OpenBuiltInBrowser_38);
            args = new Type[] {typeof(Phantom.XRMOD.ActionNotification.Runtime.TryAcquireAppInfoArgs)};
            method = type.GetMethod("TryAcquireAppInfo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireAppInfo_39);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("SendMessageToSDK", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendMessageToSDK_40);
            args = new Type[] {typeof(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset)};
            method = type.GetMethod("OverrideRenderPipelineAtRuntime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverrideRenderPipelineAtRuntime_41);
            args = new Type[] {typeof(UnityEngine.Material)};
            method = type.GetMethod("OverrideSkyBox", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OverrideSkyBox_42);
            method = type.GetMethod("GetCurrentExperienceSpaceType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCurrentExperienceSpaceType_43);

            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODAPI.Runtime.API[s]);

            args = new Type[] {typeof(System.String)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static StackObject* get_GetProcessId_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetProcessId;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_GetProcessContainer_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetProcessContainer;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TryAcquireProcesses_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryAcquireProcesses();

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TryAcquireProjectInfo_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryAcquireProjectInfo();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TryAcquireXRMODEngineCachePath_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryAcquireXRMODEngineCachePath();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TryAcquireSdkType_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryAcquireSdkType();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TryAcquireLaunchConfig_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryAcquireLaunchConfig();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ChangeSpaceType_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.ActionNotification.Runtime.BoundResizeMode @_boundResizeMode =
                (Phantom.XRMOD.ActionNotification.Runtime.BoundResizeMode)
                typeof(Phantom.XRMOD.ActionNotification.Runtime.BoundResizeMode).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String[] @_cullingMask = (System.String[]) typeof(System.String[]).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Nullable<UnityEngine.Vector3> @_boundPosition =
                (System.Nullable<UnityEngine.Vector3>) typeof(System.Nullable<UnityEngine.Vector3>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Nullable<UnityEngine.Vector3> @_dimensions =
                (System.Nullable<UnityEngine.Vector3>) typeof(System.Nullable<UnityEngine.Vector3>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            Phantom.XRMOD.ActionNotification.Runtime.SpaceType @_spaceType =
                (Phantom.XRMOD.ActionNotification.Runtime.SpaceType)
                typeof(Phantom.XRMOD.ActionNotification.Runtime.SpaceType).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ChangeSpaceType(@_spaceType, @_dimensions, @_boundPosition, @_cullingMask,
                @_boundResizeMode);

            return __ret;
        }

        static StackObject* IsPointerOverUi_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsPointerOverUi();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SaveKeyAndValue_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_value = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_key = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SaveKeyAndValue(@_key, @_value);

            return __ret;
        }

        static StackObject* GetValueByKey_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_key = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetValueByKey(@_key);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RemoveKeyAndValue_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_key = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveKeyAndValue(@_key);

            return __ret;
        }

        static StackObject* LoadUnityScene_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_sceneName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LoadUnityScene(@_sceneName);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }
            BinderManager.Instance.DoBind();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TryAcquireNetworkMesh_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.GameObject> @_result =
                (System.Action<UnityEngine.GameObject>) typeof(System.Action<UnityEngine.GameObject>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_url = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TryAcquireNetworkMesh(@_url, @_result);

            return __ret;
        }

        static StackObject* DownloadNetworkMesh_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.String> @_result =
                (System.Action<System.String>) typeof(System.Action<System.String>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_url = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DownloadNetworkMesh(@_url, @_result);

            return __ret;
        }

        static StackObject* ReleaseProject_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_projectName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ReleaseProject(@_projectName);

            return __ret;
        }

        static StackObject* GetDeviceInfo_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetDeviceInfo();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetSystemLanguage_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetSystemLanguage();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* IsPlatform_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType @_platform =
                (Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType)
                typeof(Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsPlatform(@_platform);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetScreenOrientation_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ScreenOrientation @_orientation =
                (UnityEngine.ScreenOrientation) typeof(UnityEngine.ScreenOrientation).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetScreenOrientation(@_orientation);

            return __ret;
        }

        static StackObject* ResizeARWorldScale_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @_worldScale = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ResizeARWorldScale(@_worldScale);

            return __ret;
        }

        static StackObject* ChangeARAlgorithmLife_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmArgs @_data =
                (Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmArgs)
                typeof(Phantom.XRMOD.ActionNotification.Runtime.ARAlgorithmArgs).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ChangeARAlgorithmLife(@_data);

            return __ret;
        }

        static StackObject* MakeContentAppearAt_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @_rotation = (UnityEngine.Quaternion) typeof(UnityEngine.Quaternion).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @_position = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Transform @_contentTrans = (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MakeContentAppearAt(@_contentTrans, @_position, @_rotation);

            return __ret;
        }

        static StackObject* ARRaycast_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.Pose> @_callback =
                (System.Action<UnityEngine.Pose>) typeof(System.Action<UnityEngine.Pose>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.ActionNotification.Runtime.TrackableTypeEnum @_trackableType =
                (Phantom.XRMOD.ActionNotification.Runtime.TrackableTypeEnum)
                typeof(Phantom.XRMOD.ActionNotification.Runtime.TrackableTypeEnum).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 @_inputPosition = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ARRaycast(@_inputPosition, @_trackableType, @_callback);

            return __ret;
        }

        static StackObject* TryAcquireCurrentFrame_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.ActionNotification.Runtime.TryAcquireCurrentFrameArgs @_data =
                (Phantom.XRMOD.ActionNotification.Runtime.TryAcquireCurrentFrameArgs)
                typeof(Phantom.XRMOD.ActionNotification.Runtime.TryAcquireCurrentFrameArgs).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryAcquireCurrentFrame(@_data);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TryAcquireAROcclusionFrame_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.ActionNotification.Runtime.AROcclusionArgs @_data =
                (Phantom.XRMOD.ActionNotification.Runtime.AROcclusionArgs)
                typeof(Phantom.XRMOD.ActionNotification.Runtime.AROcclusionArgs).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryAcquireAROcclusionFrame(@_data);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TryAcquireLightEstimateValue_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryAcquireLightEstimateValue();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CheckARAvailability_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CheckARAvailability();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* AddNewImageForTracking_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @_callback = (System.Action) typeof(System.Action).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<Phantom.XRMOD.ActionNotification.Runtime.DynamicLibraryArgs.ImageData>
                @_imageData =
                    (System.Collections.Generic.List<
                        Phantom.XRMOD.ActionNotification.Runtime.DynamicLibraryArgs.ImageData>)
                    typeof(System.Collections.Generic.List<
                            Phantom.XRMOD.ActionNotification.Runtime.DynamicLibraryArgs.ImageData>)
                        .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                            (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddNewImageForTracking(@_imageData, @_callback);

            return __ret;
        }

        static StackObject* CheckFeatureAvailability_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_featureName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CheckFeatureAvailability(@_featureName);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* TryAcquireSDKVersion_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryAcquireSDKVersion();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Exit_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Exit();

            return __ret;
        }

        static StackObject* GetAllAnchors_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAllAnchors();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateAnchor_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs @_createAnchorArgs =
                (Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs)
                typeof(Phantom.XRMOD.ActionNotification.Runtime.CreateAnchorArgs).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CreateAnchor(@_createAnchorArgs);

            return __ret;
        }

        static StackObject* DestroyAnchor_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Guid @_anchorId = (System.Guid) typeof(System.Guid).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DestroyAnchor(@_anchorId);

            return __ret;
        }

        static StackObject* CaptureEnvironment_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CaptureEnvironment();

            return __ret;
        }

        static StackObject* SaveEnvironmentMapping_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_mapName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SaveEnvironmentMapping(@_mapName);

            return __ret;
        }

        static StackObject* LoadEnvironmentMapping_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_mapName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LoadEnvironmentMapping(@_mapName);

            return __ret;
        }

        static StackObject* DeleteEnvironmentMapping_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_mapName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DeleteEnvironmentMapping(@_mapName);

            return __ret;
        }

        static StackObject* OpenBuiltInBrowser_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.ActionNotification.Runtime.OpenInBuiltInBrowserArgs @_data =
                (Phantom.XRMOD.ActionNotification.Runtime.OpenInBuiltInBrowserArgs)
                typeof(Phantom.XRMOD.ActionNotification.Runtime.OpenInBuiltInBrowserArgs).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OpenBuiltInBrowser(@_data);

            return __ret;
        }

        static StackObject* TryAcquireAppInfo_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.ActionNotification.Runtime.TryAcquireAppInfoArgs @_data =
                (Phantom.XRMOD.ActionNotification.Runtime.TryAcquireAppInfoArgs)
                typeof(Phantom.XRMOD.ActionNotification.Runtime.TryAcquireAppInfoArgs).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TryAcquireAppInfo(@_data);

            return __ret;
        }

        static StackObject* SendMessageToSDK_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_data = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SendMessageToSDK(@_data);

            return __ret;
        }

        static StackObject* OverrideRenderPipelineAtRuntime_41(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset @_pipelineAsset =
                (UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset)
                typeof(UnityEngine.Rendering.Universal.UniversalRenderPipelineAsset).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OverrideRenderPipelineAtRuntime(@_pipelineAsset);

            return __ret;
        }

        static StackObject* OverrideSkyBox_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material @_material = (UnityEngine.Material) typeof(UnityEngine.Material).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OverrideSkyBox(@_material);

            return __ret;
        }

        static StackObject* GetCurrentExperienceSpaceType_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetCurrentExperienceSpaceType();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_projectName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new Phantom.XRMOD.XRMODAPI.Runtime.API(@_projectName);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}
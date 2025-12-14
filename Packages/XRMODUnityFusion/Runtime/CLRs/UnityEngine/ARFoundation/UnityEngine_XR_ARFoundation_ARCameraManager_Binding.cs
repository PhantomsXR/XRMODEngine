#if USE_ARFOUNDATION
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
    unsafe class UnityEngine_XR_ARFoundation_ARCameraManager_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.ARFoundation.ARCameraManager);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.ARFoundation.ARCameraFrameEventArgs>)};
            method = type.GetMethod("add_frameReceived", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_frameReceived_0);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.ARFoundation.ARCameraFrameEventArgs>)};
            method = type.GetMethod("remove_frameReceived", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_frameReceived_1);
            args = new Type[]{};
            method = type.GetMethod("get_autoFocusRequested", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_autoFocusRequested_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_autoFocusRequested", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_autoFocusRequested_3);
            args = new Type[]{};
            method = type.GetMethod("get_autoFocusEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_autoFocusEnabled_4);
            args = new Type[]{};
            method = type.GetMethod("get_requestedLightEstimation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_requestedLightEstimation_5);
            args = new Type[]{typeof(UnityEngine.XR.ARFoundation.LightEstimation)};
            method = type.GetMethod("set_requestedLightEstimation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_requestedLightEstimation_6);
            args = new Type[]{};
            method = type.GetMethod("get_currentLightEstimation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentLightEstimation_7);
            args = new Type[]{};
            method = type.GetMethod("get_requestedFacingDirection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_requestedFacingDirection_8);
            args = new Type[]{typeof(UnityEngine.XR.ARFoundation.CameraFacingDirection)};
            method = type.GetMethod("set_requestedFacingDirection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_requestedFacingDirection_9);
            args = new Type[]{};
            method = type.GetMethod("get_currentFacingDirection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentFacingDirection_10);
            args = new Type[]{};
            method = type.GetMethod("get_requestedBackgroundRenderingMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_requestedBackgroundRenderingMode_11);
            args = new Type[]{typeof(UnityEngine.XR.ARFoundation.CameraBackgroundRenderingMode)};
            method = type.GetMethod("set_requestedBackgroundRenderingMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_requestedBackgroundRenderingMode_12);
            args = new Type[]{};
            method = type.GetMethod("get_currentRenderingMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentRenderingMode_13);
            args = new Type[]{};
            method = type.GetMethod("get_permissionGranted", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_permissionGranted_14);
            args = new Type[]{};
            method = type.GetMethod("get_cameraMaterial", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cameraMaterial_15);
            args = new Type[]{};
            method = type.GetMethod("OnBeforeSerialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnBeforeSerialize_16);
            args = new Type[]{};
            method = type.GetMethod("OnAfterDeserialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnAfterDeserialize_17);
            args = new Type[]{typeof(UnityEngine.XR.ARSubsystems.XRCameraIntrinsics).MakeByRefType()};
            method = type.GetMethod("TryGetIntrinsics", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetIntrinsics_18);
            args = new Type[]{typeof(Unity.Collections.Allocator)};
            method = type.GetMethod("GetConfigurations", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetConfigurations_19);
            args = new Type[]{};
            method = type.GetMethod("get_currentConfiguration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentConfiguration_20);
            args = new Type[]{typeof(System.Nullable<UnityEngine.XR.ARSubsystems.XRCameraConfiguration>)};
            method = type.GetMethod("set_currentConfiguration", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_currentConfiguration_21);
            args = new Type[]{typeof(UnityEngine.XR.ARSubsystems.XRCpuImage).MakeByRefType()};
            method = type.GetMethod("TryAcquireLatestCpuImage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireLatestCpuImage_22);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.ARFoundation.ARCameraManager());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.ARFoundation.ARCameraManager[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* add_frameReceived_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.ARFoundation.ARCameraFrameEventArgs> @value = (System.Action<UnityEngine.XR.ARFoundation.ARCameraFrameEventArgs>)typeof(System.Action<UnityEngine.XR.ARFoundation.ARCameraFrameEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.frameReceived += value;

            return __ret;
        }

        static StackObject* remove_frameReceived_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.XR.ARFoundation.ARCameraFrameEventArgs> @value = (System.Action<UnityEngine.XR.ARFoundation.ARCameraFrameEventArgs>)typeof(System.Action<UnityEngine.XR.ARFoundation.ARCameraFrameEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.frameReceived -= value;

            return __ret;
        }

        static StackObject* get_autoFocusRequested_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.autoFocusRequested;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_autoFocusRequested_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.autoFocusRequested = value;

            return __ret;
        }

        static StackObject* get_autoFocusEnabled_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.autoFocusEnabled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_requestedLightEstimation_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.requestedLightEstimation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_requestedLightEstimation_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.LightEstimation @value = (UnityEngine.XR.ARFoundation.LightEstimation)typeof(UnityEngine.XR.ARFoundation.LightEstimation).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.requestedLightEstimation = value;

            return __ret;
        }

        static StackObject* get_currentLightEstimation_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.currentLightEstimation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_requestedFacingDirection_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.requestedFacingDirection;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_requestedFacingDirection_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.CameraFacingDirection @value = (UnityEngine.XR.ARFoundation.CameraFacingDirection)typeof(UnityEngine.XR.ARFoundation.CameraFacingDirection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.requestedFacingDirection = value;

            return __ret;
        }

        static StackObject* get_currentFacingDirection_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.currentFacingDirection;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_requestedBackgroundRenderingMode_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.requestedBackgroundRenderingMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_requestedBackgroundRenderingMode_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.CameraBackgroundRenderingMode @value = (UnityEngine.XR.ARFoundation.CameraBackgroundRenderingMode)typeof(UnityEngine.XR.ARFoundation.CameraBackgroundRenderingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.requestedBackgroundRenderingMode = value;

            return __ret;
        }

        static StackObject* get_currentRenderingMode_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.currentRenderingMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_permissionGranted_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.permissionGranted;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_cameraMaterial_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.cameraMaterial;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OnBeforeSerialize_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnBeforeSerialize();

            return __ret;
        }

        static StackObject* OnAfterDeserialize_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnAfterDeserialize();

            return __ret;
        }

        static StackObject* TryGetIntrinsics_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARSubsystems.XRCameraIntrinsics @cameraIntrinsics = (UnityEngine.XR.ARSubsystems.XRCameraIntrinsics)typeof(UnityEngine.XR.ARSubsystems.XRCameraIntrinsics).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.TryGetIntrinsics(out @cameraIntrinsics);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @cameraIntrinsics;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @cameraIntrinsics;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @cameraIntrinsics);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @cameraIntrinsics;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @cameraIntrinsics);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.XR.ARSubsystems.XRCameraIntrinsics[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @cameraIntrinsics;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetConfigurations_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Collections.Allocator @allocator = (Unity.Collections.Allocator)typeof(Unity.Collections.Allocator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetConfigurations(@allocator);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_currentConfiguration_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.currentConfiguration;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_currentConfiguration_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Nullable<UnityEngine.XR.ARSubsystems.XRCameraConfiguration> @value = (System.Nullable<UnityEngine.XR.ARSubsystems.XRCameraConfiguration>)typeof(System.Nullable<UnityEngine.XR.ARSubsystems.XRCameraConfiguration>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.currentConfiguration = value;

            return __ret;
        }

        static StackObject* TryAcquireLatestCpuImage_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARSubsystems.XRCpuImage @cpuImage = (UnityEngine.XR.ARSubsystems.XRCpuImage)typeof(UnityEngine.XR.ARSubsystems.XRCpuImage).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARCameraManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARCameraManager)typeof(UnityEngine.XR.ARFoundation.ARCameraManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.TryAcquireLatestCpuImage(out @cpuImage);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @cpuImage;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @cpuImage;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @cpuImage);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @cpuImage;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @cpuImage);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.XR.ARSubsystems.XRCpuImage[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @cpuImage;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.ARFoundation.ARCameraManager();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
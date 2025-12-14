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
    unsafe class UnityEngine_XR_ARFoundation_AROcclusionManager_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.ARFoundation.AROcclusionManager);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.ARFoundation.AROcclusionFrameEventArgs>)};
            method = type.GetMethod("add_frameReceived", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_frameReceived_0);
            args = new Type[]{typeof(System.Action<UnityEngine.XR.ARFoundation.AROcclusionFrameEventArgs>)};
            method = type.GetMethod("remove_frameReceived", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_frameReceived_1);
            args = new Type[]{};
            method = type.GetMethod("get_requestedHumanStencilMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_requestedHumanStencilMode_2);
            args = new Type[]{typeof(UnityEngine.XR.ARSubsystems.HumanSegmentationStencilMode)};
            method = type.GetMethod("set_requestedHumanStencilMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_requestedHumanStencilMode_3);
            args = new Type[]{};
            method = type.GetMethod("get_currentHumanStencilMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentHumanStencilMode_4);
            args = new Type[]{};
            method = type.GetMethod("get_requestedHumanDepthMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_requestedHumanDepthMode_5);
            args = new Type[]{typeof(UnityEngine.XR.ARSubsystems.HumanSegmentationDepthMode)};
            method = type.GetMethod("set_requestedHumanDepthMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_requestedHumanDepthMode_6);
            args = new Type[]{};
            method = type.GetMethod("get_currentHumanDepthMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentHumanDepthMode_7);
            args = new Type[]{};
            method = type.GetMethod("get_requestedEnvironmentDepthMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_requestedEnvironmentDepthMode_8);
            args = new Type[]{typeof(UnityEngine.XR.ARSubsystems.EnvironmentDepthMode)};
            method = type.GetMethod("set_requestedEnvironmentDepthMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_requestedEnvironmentDepthMode_9);
            args = new Type[]{};
            method = type.GetMethod("get_currentEnvironmentDepthMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentEnvironmentDepthMode_10);
            args = new Type[]{};
            method = type.GetMethod("get_environmentDepthTemporalSmoothingRequested", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_environmentDepthTemporalSmoothingRequested_11);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_environmentDepthTemporalSmoothingRequested", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_environmentDepthTemporalSmoothingRequested_12);
            args = new Type[]{};
            method = type.GetMethod("get_environmentDepthTemporalSmoothingEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_environmentDepthTemporalSmoothingEnabled_13);
            args = new Type[]{};
            method = type.GetMethod("get_requestedOcclusionPreferenceMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_requestedOcclusionPreferenceMode_14);
            args = new Type[]{typeof(UnityEngine.XR.ARSubsystems.OcclusionPreferenceMode)};
            method = type.GetMethod("set_requestedOcclusionPreferenceMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_requestedOcclusionPreferenceMode_15);
            args = new Type[]{};
            method = type.GetMethod("get_currentOcclusionPreferenceMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentOcclusionPreferenceMode_16);
            args = new Type[]{};
            method = type.GetMethod("get_humanStencilTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_humanStencilTexture_17);
            args = new Type[]{typeof(UnityEngine.XR.ARSubsystems.XRCpuImage).MakeByRefType()};
            method = type.GetMethod("TryAcquireHumanStencilCpuImage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireHumanStencilCpuImage_18);
            args = new Type[]{};
            method = type.GetMethod("get_humanDepthTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_humanDepthTexture_19);
            args = new Type[]{typeof(UnityEngine.XR.ARSubsystems.XRCpuImage).MakeByRefType()};
            method = type.GetMethod("TryAcquireEnvironmentDepthConfidenceCpuImage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireEnvironmentDepthConfidenceCpuImage_20);
            args = new Type[]{};
            method = type.GetMethod("get_environmentDepthConfidenceTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_environmentDepthConfidenceTexture_21);
            args = new Type[]{typeof(UnityEngine.XR.ARSubsystems.XRCpuImage).MakeByRefType()};
            method = type.GetMethod("TryAcquireHumanDepthCpuImage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireHumanDepthCpuImage_22);
            args = new Type[]{};
            method = type.GetMethod("get_environmentDepthTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_environmentDepthTexture_23);
            args = new Type[]{typeof(UnityEngine.XR.ARSubsystems.XRCpuImage).MakeByRefType()};
            method = type.GetMethod("TryAcquireEnvironmentDepthCpuImage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireEnvironmentDepthCpuImage_24);
            args = new Type[]{typeof(UnityEngine.XR.ARSubsystems.XRCpuImage).MakeByRefType()};
            method = type.GetMethod("TryAcquireRawEnvironmentDepthCpuImage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireRawEnvironmentDepthCpuImage_25);
            args = new Type[]{typeof(UnityEngine.XR.ARSubsystems.XRCpuImage).MakeByRefType()};
            method = type.GetMethod("TryAcquireSmoothedEnvironmentDepthCpuImage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryAcquireSmoothedEnvironmentDepthCpuImage_26);
            args = new Type[]{};
            method = type.GetMethod("Update", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Update_27);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.ARFoundation.AROcclusionManager());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.ARFoundation.AROcclusionManager[s]);

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
            System.Action<UnityEngine.XR.ARFoundation.AROcclusionFrameEventArgs> @value = (System.Action<UnityEngine.XR.ARFoundation.AROcclusionFrameEventArgs>)typeof(System.Action<UnityEngine.XR.ARFoundation.AROcclusionFrameEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
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
            System.Action<UnityEngine.XR.ARFoundation.AROcclusionFrameEventArgs> @value = (System.Action<UnityEngine.XR.ARFoundation.AROcclusionFrameEventArgs>)typeof(System.Action<UnityEngine.XR.ARFoundation.AROcclusionFrameEventArgs>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.frameReceived -= value;

            return __ret;
        }

        static StackObject* get_requestedHumanStencilMode_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.requestedHumanStencilMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_requestedHumanStencilMode_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARSubsystems.HumanSegmentationStencilMode @value = (UnityEngine.XR.ARSubsystems.HumanSegmentationStencilMode)typeof(UnityEngine.XR.ARSubsystems.HumanSegmentationStencilMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.requestedHumanStencilMode = value;

            return __ret;
        }

        static StackObject* get_currentHumanStencilMode_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.currentHumanStencilMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_requestedHumanDepthMode_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.requestedHumanDepthMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_requestedHumanDepthMode_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARSubsystems.HumanSegmentationDepthMode @value = (UnityEngine.XR.ARSubsystems.HumanSegmentationDepthMode)typeof(UnityEngine.XR.ARSubsystems.HumanSegmentationDepthMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.requestedHumanDepthMode = value;

            return __ret;
        }

        static StackObject* get_currentHumanDepthMode_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.currentHumanDepthMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_requestedEnvironmentDepthMode_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.requestedEnvironmentDepthMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_requestedEnvironmentDepthMode_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARSubsystems.EnvironmentDepthMode @value = (UnityEngine.XR.ARSubsystems.EnvironmentDepthMode)typeof(UnityEngine.XR.ARSubsystems.EnvironmentDepthMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.requestedEnvironmentDepthMode = value;

            return __ret;
        }

        static StackObject* get_currentEnvironmentDepthMode_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.currentEnvironmentDepthMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_environmentDepthTemporalSmoothingRequested_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.environmentDepthTemporalSmoothingRequested;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_environmentDepthTemporalSmoothingRequested_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.environmentDepthTemporalSmoothingRequested = value;

            return __ret;
        }

        static StackObject* get_environmentDepthTemporalSmoothingEnabled_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.environmentDepthTemporalSmoothingEnabled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_requestedOcclusionPreferenceMode_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.requestedOcclusionPreferenceMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_requestedOcclusionPreferenceMode_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARSubsystems.OcclusionPreferenceMode @value = (UnityEngine.XR.ARSubsystems.OcclusionPreferenceMode)typeof(UnityEngine.XR.ARSubsystems.OcclusionPreferenceMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.requestedOcclusionPreferenceMode = value;

            return __ret;
        }

        static StackObject* get_currentOcclusionPreferenceMode_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.currentOcclusionPreferenceMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_humanStencilTexture_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.humanStencilTexture;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TryAcquireHumanStencilCpuImage_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARSubsystems.XRCpuImage @cpuImage = (UnityEngine.XR.ARSubsystems.XRCpuImage)typeof(UnityEngine.XR.ARSubsystems.XRCpuImage).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.TryAcquireHumanStencilCpuImage(out @cpuImage);

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

        static StackObject* get_humanDepthTexture_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.humanDepthTexture;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TryAcquireEnvironmentDepthConfidenceCpuImage_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARSubsystems.XRCpuImage @cpuImage = (UnityEngine.XR.ARSubsystems.XRCpuImage)typeof(UnityEngine.XR.ARSubsystems.XRCpuImage).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.TryAcquireEnvironmentDepthConfidenceCpuImage(out @cpuImage);

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

        static StackObject* get_environmentDepthConfidenceTexture_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.environmentDepthConfidenceTexture;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TryAcquireHumanDepthCpuImage_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARSubsystems.XRCpuImage @cpuImage = (UnityEngine.XR.ARSubsystems.XRCpuImage)typeof(UnityEngine.XR.ARSubsystems.XRCpuImage).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.TryAcquireHumanDepthCpuImage(out @cpuImage);

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

        static StackObject* get_environmentDepthTexture_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.environmentDepthTexture;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TryAcquireEnvironmentDepthCpuImage_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARSubsystems.XRCpuImage @cpuImage = (UnityEngine.XR.ARSubsystems.XRCpuImage)typeof(UnityEngine.XR.ARSubsystems.XRCpuImage).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.TryAcquireEnvironmentDepthCpuImage(out @cpuImage);

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

        static StackObject* TryAcquireRawEnvironmentDepthCpuImage_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARSubsystems.XRCpuImage @cpuImage = (UnityEngine.XR.ARSubsystems.XRCpuImage)typeof(UnityEngine.XR.ARSubsystems.XRCpuImage).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.TryAcquireRawEnvironmentDepthCpuImage(out @cpuImage);

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

        static StackObject* TryAcquireSmoothedEnvironmentDepthCpuImage_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARSubsystems.XRCpuImage @cpuImage = (UnityEngine.XR.ARSubsystems.XRCpuImage)typeof(UnityEngine.XR.ARSubsystems.XRCpuImage).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.TryAcquireSmoothedEnvironmentDepthCpuImage(out @cpuImage);

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

        static StackObject* Update_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.AROcclusionManager instance_of_this_method = (UnityEngine.XR.ARFoundation.AROcclusionManager)typeof(UnityEngine.XR.ARFoundation.AROcclusionManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Update();

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.ARFoundation.AROcclusionManager();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
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
    unsafe class UnityEngine_Rendering_GraphicsSettings_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Rendering.GraphicsSettings);
            args = new Type[]{};
            method = type.GetMethod("get_transparencySortMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_transparencySortMode_0);
            args = new Type[]{typeof(UnityEngine.TransparencySortMode)};
            method = type.GetMethod("set_transparencySortMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_transparencySortMode_1);
            args = new Type[]{};
            method = type.GetMethod("get_transparencySortAxis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_transparencySortAxis_2);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_transparencySortAxis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_transparencySortAxis_3);
            args = new Type[]{};
            method = type.GetMethod("get_realtimeDirectRectangularAreaLights", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_realtimeDirectRectangularAreaLights_4);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_realtimeDirectRectangularAreaLights", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_realtimeDirectRectangularAreaLights_5);
            args = new Type[]{};
            method = type.GetMethod("get_lightsUseLinearIntensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lightsUseLinearIntensity_6);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_lightsUseLinearIntensity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lightsUseLinearIntensity_7);
            args = new Type[]{};
            method = type.GetMethod("get_lightsUseColorTemperature", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lightsUseColorTemperature_8);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_lightsUseColorTemperature", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lightsUseColorTemperature_9);
            args = new Type[]{};
            method = type.GetMethod("get_defaultRenderingLayerMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_defaultRenderingLayerMask_10);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("set_defaultRenderingLayerMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_defaultRenderingLayerMask_11);
            args = new Type[]{};
            method = type.GetMethod("get_useScriptableRenderPipelineBatching", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useScriptableRenderPipelineBatching_12);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_useScriptableRenderPipelineBatching", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useScriptableRenderPipelineBatching_13);
            args = new Type[]{};
            method = type.GetMethod("get_logWhenShaderIsCompiled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_logWhenShaderIsCompiled_14);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_logWhenShaderIsCompiled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_logWhenShaderIsCompiled_15);
            args = new Type[]{};
            method = type.GetMethod("get_disableBuiltinCustomRenderTextureUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_disableBuiltinCustomRenderTextureUpdate_16);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_disableBuiltinCustomRenderTextureUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_disableBuiltinCustomRenderTextureUpdate_17);
            args = new Type[]{};
            // method = type.GetMethod("get_videoShadersIncludeMode", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_videoShadersIncludeMode_18);
            // args = new Type[]{typeof(UnityEngine.Rendering.VideoShadersIncludeMode)};
            // method = type.GetMethod("set_videoShadersIncludeMode", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_videoShadersIncludeMode_19);
            // args = new Type[]{};
            // method = type.GetMethod("get_lightProbeOutsideHullStrategy", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_lightProbeOutsideHullStrategy_20);
            // args = new Type[]{typeof(UnityEngine.Rendering.LightProbeOutsideHullStrategy)};
            // method = type.GetMethod("set_lightProbeOutsideHullStrategy", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, set_lightProbeOutsideHullStrategy_21);
            args = new Type[]{typeof(UnityEngine.Rendering.GraphicsTier), typeof(UnityEngine.Rendering.BuiltinShaderDefine)};
            method = type.GetMethod("HasShaderDefine", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HasShaderDefine_22);
            args = new Type[]{typeof(UnityEngine.Rendering.BuiltinShaderDefine)};
            method = type.GetMethod("HasShaderDefine", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HasShaderDefine_23);
            args = new Type[]{};
            method = type.GetMethod("get_currentRenderPipeline", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentRenderPipeline_24);
            args = new Type[]{};
            method = type.GetMethod("get_renderPipelineAsset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_renderPipelineAsset_25);
            args = new Type[]{typeof(UnityEngine.Rendering.RenderPipelineAsset)};
            method = type.GetMethod("set_renderPipelineAsset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_renderPipelineAsset_26);
            args = new Type[]{};
            method = type.GetMethod("get_defaultRenderPipeline", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_defaultRenderPipeline_27);
            args = new Type[]{typeof(UnityEngine.Rendering.RenderPipelineAsset)};
            method = type.GetMethod("set_defaultRenderPipeline", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_defaultRenderPipeline_28);
            args = new Type[]{};
            method = type.GetMethod("get_allConfiguredRenderPipelines", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_allConfiguredRenderPipelines_29);
            args = new Type[]{};
            method = type.GetMethod("GetGraphicsSettings", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGraphicsSettings_30);
            args = new Type[]{typeof(UnityEngine.Rendering.BuiltinShaderType), typeof(UnityEngine.Rendering.BuiltinShaderMode)};
            method = type.GetMethod("SetShaderMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetShaderMode_31);
            args = new Type[]{typeof(UnityEngine.Rendering.BuiltinShaderType)};
            method = type.GetMethod("GetShaderMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetShaderMode_32);
            args = new Type[]{typeof(UnityEngine.Rendering.BuiltinShaderType), typeof(UnityEngine.Shader)};
            method = type.GetMethod("SetCustomShader", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetCustomShader_33);
            args = new Type[]{typeof(UnityEngine.Rendering.BuiltinShaderType)};
            method = type.GetMethod("GetCustomShader", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCustomShader_34);
            args = new Type[]{};
            method = type.GetMethod("get_cameraRelativeLightCulling", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cameraRelativeLightCulling_35);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_cameraRelativeLightCulling", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_cameraRelativeLightCulling_36);
            args = new Type[]{};
            method = type.GetMethod("get_cameraRelativeShadowCulling", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cameraRelativeShadowCulling_37);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_cameraRelativeShadowCulling", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_cameraRelativeShadowCulling_38);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Rendering.GraphicsSettings[s]);


        }


        static StackObject* get_transparencySortMode_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.transparencySortMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_transparencySortMode_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TransparencySortMode @value = (UnityEngine.TransparencySortMode)typeof(UnityEngine.TransparencySortMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Rendering.GraphicsSettings.transparencySortMode = value;

            return __ret;
        }

        static StackObject* get_transparencySortAxis_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.transparencySortAxis;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_transparencySortAxis_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Rendering.GraphicsSettings.transparencySortAxis = value;

            return __ret;
        }

        static StackObject* get_realtimeDirectRectangularAreaLights_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.realtimeDirectRectangularAreaLights;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_realtimeDirectRectangularAreaLights_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Rendering.GraphicsSettings.realtimeDirectRectangularAreaLights = value;

            return __ret;
        }

        static StackObject* get_lightsUseLinearIntensity_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.lightsUseLinearIntensity;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_lightsUseLinearIntensity_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Rendering.GraphicsSettings.lightsUseLinearIntensity = value;

            return __ret;
        }

        static StackObject* get_lightsUseColorTemperature_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.lightsUseColorTemperature;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_lightsUseColorTemperature_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Rendering.GraphicsSettings.lightsUseColorTemperature = value;

            return __ret;
        }

        static StackObject* get_defaultRenderingLayerMask_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.defaultRenderingLayerMask;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_defaultRenderingLayerMask_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 @value = (uint)ptr_of_this_method->Value;


            UnityEngine.Rendering.GraphicsSettings.defaultRenderingLayerMask = value;

            return __ret;
        }

        static StackObject* get_useScriptableRenderPipelineBatching_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.useScriptableRenderPipelineBatching;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_useScriptableRenderPipelineBatching_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Rendering.GraphicsSettings.useScriptableRenderPipelineBatching = value;

            return __ret;
        }

        static StackObject* get_logWhenShaderIsCompiled_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.logWhenShaderIsCompiled;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_logWhenShaderIsCompiled_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Rendering.GraphicsSettings.logWhenShaderIsCompiled = value;

            return __ret;
        }

        static StackObject* get_disableBuiltinCustomRenderTextureUpdate_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.disableBuiltinCustomRenderTextureUpdate;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_disableBuiltinCustomRenderTextureUpdate_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Rendering.GraphicsSettings.disableBuiltinCustomRenderTextureUpdate = value;

            return __ret;
        }

        // static StackObject* get_videoShadersIncludeMode_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 0);
        //
        //
        //     var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.videoShadersIncludeMode;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }

        // static StackObject* set_videoShadersIncludeMode_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Rendering.VideoShadersIncludeMode @value = (UnityEngine.Rendering.VideoShadersIncludeMode)typeof(UnityEngine.Rendering.VideoShadersIncludeMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
        //     __intp.Free(ptr_of_this_method);
        //
        //
        //     UnityEngine.Rendering.GraphicsSettings.videoShadersIncludeMode = value;
        //
        //     return __ret;
        // }

        // static StackObject* get_lightProbeOutsideHullStrategy_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 0);
        //
        //
        //     var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.lightProbeOutsideHullStrategy;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }

        // static StackObject* set_lightProbeOutsideHullStrategy_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Rendering.LightProbeOutsideHullStrategy @value = (UnityEngine.Rendering.LightProbeOutsideHullStrategy)typeof(UnityEngine.Rendering.LightProbeOutsideHullStrategy).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
        //     __intp.Free(ptr_of_this_method);
        //
        //
        //     UnityEngine.Rendering.GraphicsSettings.lightProbeOutsideHullStrategy = value;
        //
        //     return __ret;
        // }

        static StackObject* HasShaderDefine_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.BuiltinShaderDefine @defineHash = (UnityEngine.Rendering.BuiltinShaderDefine)typeof(UnityEngine.Rendering.BuiltinShaderDefine).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.GraphicsTier @tier = (UnityEngine.Rendering.GraphicsTier)typeof(UnityEngine.Rendering.GraphicsTier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.HasShaderDefine(@tier, @defineHash);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* HasShaderDefine_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.BuiltinShaderDefine @defineHash = (UnityEngine.Rendering.BuiltinShaderDefine)typeof(UnityEngine.Rendering.BuiltinShaderDefine).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.HasShaderDefine(@defineHash);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_currentRenderPipeline_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.currentRenderPipeline;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_renderPipelineAsset_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.defaultRenderPipeline;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_renderPipelineAsset_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.RenderPipelineAsset @value = (UnityEngine.Rendering.RenderPipelineAsset)typeof(UnityEngine.Rendering.RenderPipelineAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Rendering.GraphicsSettings.defaultRenderPipeline = value;

            return __ret;
        }

        static StackObject* get_defaultRenderPipeline_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.defaultRenderPipeline;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_defaultRenderPipeline_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.RenderPipelineAsset @value = (UnityEngine.Rendering.RenderPipelineAsset)typeof(UnityEngine.Rendering.RenderPipelineAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Rendering.GraphicsSettings.defaultRenderPipeline = value;

            return __ret;
        }

        static StackObject* get_allConfiguredRenderPipelines_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.allConfiguredRenderPipelines;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGraphicsSettings_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.GetGraphicsSettings();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetShaderMode_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.BuiltinShaderMode @mode = (UnityEngine.Rendering.BuiltinShaderMode)typeof(UnityEngine.Rendering.BuiltinShaderMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.BuiltinShaderType @type = (UnityEngine.Rendering.BuiltinShaderType)typeof(UnityEngine.Rendering.BuiltinShaderType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Rendering.GraphicsSettings.SetShaderMode(@type, @mode);

            return __ret;
        }

        static StackObject* GetShaderMode_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.BuiltinShaderType @type = (UnityEngine.Rendering.BuiltinShaderType)typeof(UnityEngine.Rendering.BuiltinShaderType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.GetShaderMode(@type);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetCustomShader_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Shader @shader = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.BuiltinShaderType @type = (UnityEngine.Rendering.BuiltinShaderType)typeof(UnityEngine.Rendering.BuiltinShaderType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Rendering.GraphicsSettings.SetCustomShader(@type, @shader);

            return __ret;
        }

        static StackObject* GetCustomShader_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.BuiltinShaderType @type = (UnityEngine.Rendering.BuiltinShaderType)typeof(UnityEngine.Rendering.BuiltinShaderType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.GetCustomShader(@type);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_cameraRelativeLightCulling_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.cameraRelativeLightCulling;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_cameraRelativeLightCulling_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Rendering.GraphicsSettings.cameraRelativeLightCulling = value;

            return __ret;
        }

        static StackObject* get_cameraRelativeShadowCulling_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Rendering.GraphicsSettings.cameraRelativeShadowCulling;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_cameraRelativeShadowCulling_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.Rendering.GraphicsSettings.cameraRelativeShadowCulling = value;

            return __ret;
        }





    }
}

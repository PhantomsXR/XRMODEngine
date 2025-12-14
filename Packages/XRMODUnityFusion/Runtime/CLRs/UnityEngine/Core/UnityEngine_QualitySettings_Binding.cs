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
    unsafe class UnityEngine_QualitySettings_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.QualitySettings);
            args = new Type[]{typeof(System.Action<System.Int32, System.Int32>)};
            method = type.GetMethod("add_activeQualityLevelChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_activeQualityLevelChanged_0);
            args = new Type[]{typeof(System.Action<System.Int32, System.Int32>)};
            method = type.GetMethod("remove_activeQualityLevelChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_activeQualityLevelChanged_1);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("IncreaseLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IncreaseLevel_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("DecreaseLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DecreaseLevel_3);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("SetQualityLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetQualityLevel_4);
            args = new Type[]{};
            method = type.GetMethod("IncreaseLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IncreaseLevel_5);
            args = new Type[]{};
            method = type.GetMethod("DecreaseLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DecreaseLevel_6);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("ForEach", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ForEach_7);
            args = new Type[]{typeof(System.Action<System.Int32, System.String>)};
            method = type.GetMethod("ForEach", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ForEach_8);
            args = new Type[]{};
            method = type.GetMethod("get_pixelLightCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_pixelLightCount_9);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_pixelLightCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_pixelLightCount_10);
            args = new Type[]{};
            method = type.GetMethod("get_shadows", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadows_11);
            args = new Type[]{typeof(UnityEngine.ShadowQuality)};
            method = type.GetMethod("set_shadows", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadows_12);
            args = new Type[]{};
            method = type.GetMethod("get_shadowProjection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowProjection_13);
            args = new Type[]{typeof(UnityEngine.ShadowProjection)};
            method = type.GetMethod("set_shadowProjection", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowProjection_14);
            args = new Type[]{};
            method = type.GetMethod("get_shadowCascades", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowCascades_15);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_shadowCascades", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowCascades_16);
            args = new Type[]{};
            method = type.GetMethod("get_shadowDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowDistance_17);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_shadowDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowDistance_18);
            args = new Type[]{};
            method = type.GetMethod("get_shadowResolution", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowResolution_19);
            args = new Type[]{typeof(UnityEngine.ShadowResolution)};
            method = type.GetMethod("set_shadowResolution", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowResolution_20);
            args = new Type[]{};
            method = type.GetMethod("get_shadowmaskMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowmaskMode_21);
            args = new Type[]{typeof(UnityEngine.ShadowmaskMode)};
            method = type.GetMethod("set_shadowmaskMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowmaskMode_22);
            args = new Type[]{};
            method = type.GetMethod("get_shadowNearPlaneOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowNearPlaneOffset_23);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_shadowNearPlaneOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowNearPlaneOffset_24);
            args = new Type[]{};
            method = type.GetMethod("get_shadowCascade2Split", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowCascade2Split_25);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_shadowCascade2Split", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowCascade2Split_26);
            args = new Type[]{};
            method = type.GetMethod("get_shadowCascade4Split", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shadowCascade4Split_27);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_shadowCascade4Split", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shadowCascade4Split_28);
            args = new Type[]{};
            method = type.GetMethod("get_lodBias", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lodBias_29);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_lodBias", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_lodBias_30);
            args = new Type[]{};
            method = type.GetMethod("get_anisotropicFiltering", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_anisotropicFiltering_31);
            args = new Type[]{typeof(UnityEngine.AnisotropicFiltering)};
            method = type.GetMethod("set_anisotropicFiltering", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_anisotropicFiltering_32);
            args = new Type[]{};
            method = type.GetMethod("get_globalTextureMipmapLimit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_globalTextureMipmapLimit_33);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_globalTextureMipmapLimit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_globalTextureMipmapLimit_34);
            args = new Type[]{};
            method = type.GetMethod("get_maximumLODLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maximumLODLevel_35);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_maximumLODLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maximumLODLevel_36);
            args = new Type[]{};
            method = type.GetMethod("get_enableLODCrossFade", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_enableLODCrossFade_37);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_enableLODCrossFade", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_enableLODCrossFade_38);
            args = new Type[]{};
            method = type.GetMethod("get_particleRaycastBudget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_particleRaycastBudget_39);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_particleRaycastBudget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_particleRaycastBudget_40);
            args = new Type[]{};
            method = type.GetMethod("get_softParticles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_softParticles_41);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_softParticles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_softParticles_42);
            args = new Type[]{};
            method = type.GetMethod("get_softVegetation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_softVegetation_43);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_softVegetation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_softVegetation_44);
            args = new Type[]{};
            method = type.GetMethod("get_vSyncCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_vSyncCount_45);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_vSyncCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_vSyncCount_46);
            args = new Type[]{};
            method = type.GetMethod("get_realtimeGICPUUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_realtimeGICPUUsage_47);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_realtimeGICPUUsage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_realtimeGICPUUsage_48);
            args = new Type[]{};
            method = type.GetMethod("get_antiAliasing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_antiAliasing_49);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_antiAliasing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_antiAliasing_50);
            args = new Type[]{};
            method = type.GetMethod("get_asyncUploadTimeSlice", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_asyncUploadTimeSlice_51);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_asyncUploadTimeSlice", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_asyncUploadTimeSlice_52);
            args = new Type[]{};
            method = type.GetMethod("get_asyncUploadBufferSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_asyncUploadBufferSize_53);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_asyncUploadBufferSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_asyncUploadBufferSize_54);
            args = new Type[]{};
            method = type.GetMethod("get_asyncUploadPersistentBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_asyncUploadPersistentBuffer_55);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_asyncUploadPersistentBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_asyncUploadPersistentBuffer_56);
            args = new Type[]{typeof(System.Single), typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("SetLODSettings", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLODSettings_57);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.TextureMipmapLimitSettings)};
            method = type.GetMethod("SetTextureMipmapLimitSettings", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTextureMipmapLimitSettings_58);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetTextureMipmapLimitSettings", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTextureMipmapLimitSettings_59);
            args = new Type[]{};
            method = type.GetMethod("get_realtimeReflectionProbes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_realtimeReflectionProbes_60);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_realtimeReflectionProbes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_realtimeReflectionProbes_61);
            args = new Type[]{};
            method = type.GetMethod("get_billboardsFaceCameraPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_billboardsFaceCameraPosition_62);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_billboardsFaceCameraPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_billboardsFaceCameraPosition_63);
            args = new Type[]{};
            method = type.GetMethod("get_useLegacyDetailDistribution", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useLegacyDetailDistribution_64);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_useLegacyDetailDistribution", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useLegacyDetailDistribution_65);
            args = new Type[]{};
            method = type.GetMethod("get_resolutionScalingFixedDPIFactor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_resolutionScalingFixedDPIFactor_66);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_resolutionScalingFixedDPIFactor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_resolutionScalingFixedDPIFactor_67);
            args = new Type[]{};
            method = type.GetMethod("get_terrainQualityOverrides", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_terrainQualityOverrides_68);
            args = new Type[]{typeof(UnityEngine.TerrainQualityOverrides)};
            method = type.GetMethod("set_terrainQualityOverrides", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_terrainQualityOverrides_69);
            args = new Type[]{};
            method = type.GetMethod("get_terrainPixelError", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_terrainPixelError_70);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_terrainPixelError", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_terrainPixelError_71);
            args = new Type[]{};
            method = type.GetMethod("get_terrainDetailDensityScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_terrainDetailDensityScale_72);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_terrainDetailDensityScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_terrainDetailDensityScale_73);
            args = new Type[]{};
            method = type.GetMethod("get_terrainBasemapDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_terrainBasemapDistance_74);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_terrainBasemapDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_terrainBasemapDistance_75);
            args = new Type[]{};
            method = type.GetMethod("get_terrainDetailDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_terrainDetailDistance_76);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_terrainDetailDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_terrainDetailDistance_77);
            args = new Type[]{};
            method = type.GetMethod("get_terrainTreeDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_terrainTreeDistance_78);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_terrainTreeDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_terrainTreeDistance_79);
            args = new Type[]{};
            method = type.GetMethod("get_terrainBillboardStart", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_terrainBillboardStart_80);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_terrainBillboardStart", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_terrainBillboardStart_81);
            args = new Type[]{};
            method = type.GetMethod("get_terrainFadeLength", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_terrainFadeLength_82);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_terrainFadeLength", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_terrainFadeLength_83);
            args = new Type[]{};
            method = type.GetMethod("get_terrainMaxTrees", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_terrainMaxTrees_84);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_terrainMaxTrees", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_terrainMaxTrees_85);
            args = new Type[]{};
            method = type.GetMethod("get_renderPipeline", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_renderPipeline_86);
            args = new Type[]{typeof(UnityEngine.Rendering.RenderPipelineAsset)};
            method = type.GetMethod("set_renderPipeline", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_renderPipeline_87);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetRenderPipelineAssetAt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRenderPipelineAssetAt_88);
            args = new Type[]{};
            method = type.GetMethod("get_skinWeights", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_skinWeights_89);
            args = new Type[]{typeof(UnityEngine.SkinWeights)};
            method = type.GetMethod("set_skinWeights", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_skinWeights_90);
            args = new Type[]{};
            method = type.GetMethod("get_count", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_count_91);
            args = new Type[]{};
            method = type.GetMethod("get_streamingMipmapsActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_streamingMipmapsActive_92);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_streamingMipmapsActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_streamingMipmapsActive_93);
            args = new Type[]{};
            method = type.GetMethod("get_streamingMipmapsMemoryBudget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_streamingMipmapsMemoryBudget_94);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_streamingMipmapsMemoryBudget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_streamingMipmapsMemoryBudget_95);
            args = new Type[]{};
            method = type.GetMethod("get_streamingMipmapsRenderersPerFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_streamingMipmapsRenderersPerFrame_96);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_streamingMipmapsRenderersPerFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_streamingMipmapsRenderersPerFrame_97);
            args = new Type[]{};
            method = type.GetMethod("get_streamingMipmapsMaxLevelReduction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_streamingMipmapsMaxLevelReduction_98);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_streamingMipmapsMaxLevelReduction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_streamingMipmapsMaxLevelReduction_99);
            args = new Type[]{};
            method = type.GetMethod("get_streamingMipmapsAddAllCameras", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_streamingMipmapsAddAllCameras_100);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_streamingMipmapsAddAllCameras", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_streamingMipmapsAddAllCameras_101);
            args = new Type[]{};
            method = type.GetMethod("get_streamingMipmapsMaxFileIORequests", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_streamingMipmapsMaxFileIORequests_102);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_streamingMipmapsMaxFileIORequests", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_streamingMipmapsMaxFileIORequests_103);
            args = new Type[]{};
            method = type.GetMethod("get_maxQueuedFrames", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxQueuedFrames_104);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_maxQueuedFrames", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxQueuedFrames_105);
            args = new Type[]{};
            method = type.GetMethod("GetQualityLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetQualityLevel_106);
            args = new Type[]{};
            method = type.GetMethod("GetQualitySettings", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetQualitySettings_107);
            args = new Type[]{typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("SetQualityLevel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetQualityLevel_108);
            args = new Type[]{};
            method = type.GetMethod("get_names", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_names_109);
            // args = new Type[]{typeof(System.String), typeof(System.Int32)};
            // method = type.GetMethod("IsPlatformIncluded", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, IsPlatformIncluded_110);
            // args = new Type[]{typeof(System.String), typeof(System.Int32), typeof(System.Exception).MakeByRefType()};
            // method = type.GetMethod("TryIncludePlatformAt", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, TryIncludePlatformAt_111);
            // args = new Type[]{typeof(System.String), typeof(System.Int32), typeof(System.Exception).MakeByRefType()};
            // method = type.GetMethod("TryExcludePlatformAt", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, TryExcludePlatformAt_112);
            // args = new Type[]{typeof(System.String)};
            // method = type.GetMethod("GetActiveQualityLevelsForPlatform", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, GetActiveQualityLevelsForPlatform_113);
            // args = new Type[]{typeof(System.String)};
            // method = type.GetMethod("GetActiveQualityLevelsForPlatformCount", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, GetActiveQualityLevelsForPlatformCount_114);
            // args = new Type[]{typeof(System.String), typeof(System.Collections.Generic.List<UnityEngine.Rendering.RenderPipelineAsset>).MakeByRefType()};
            // method = type.GetMethod("GetAllRenderPipelineAssetsForPlatform", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, GetAllRenderPipelineAssetsForPlatform_115);
            args = new Type[]{};
            method = type.GetMethod("get_desiredColorSpace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_desiredColorSpace_116);
            args = new Type[]{};
            method = type.GetMethod("get_activeColorSpace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_activeColorSpace_117);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.QualitySettings[s]);


        }


        static StackObject* add_activeQualityLevelChanged_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Int32, System.Int32> @value = (System.Action<System.Int32, System.Int32>)typeof(System.Action<System.Int32, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.activeQualityLevelChanged += value;

            return __ret;
        }

        static StackObject* remove_activeQualityLevelChanged_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Int32, System.Int32> @value = (System.Action<System.Int32, System.Int32>)typeof(System.Action<System.Int32, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.activeQualityLevelChanged -= value;

            return __ret;
        }

        static StackObject* IncreaseLevel_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @applyExpensiveChanges = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.IncreaseLevel(@applyExpensiveChanges);

            return __ret;
        }

        static StackObject* DecreaseLevel_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @applyExpensiveChanges = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.DecreaseLevel(@applyExpensiveChanges);

            return __ret;
        }

        static StackObject* SetQualityLevel_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @index = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.SetQualityLevel(@index);

            return __ret;
        }

        static StackObject* IncreaseLevel_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.QualitySettings.IncreaseLevel();

            return __ret;
        }

        static StackObject* DecreaseLevel_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.QualitySettings.DecreaseLevel();

            return __ret;
        }

        static StackObject* ForEach_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @callback = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.ForEach(@callback);

            return __ret;
        }

        static StackObject* ForEach_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Int32, System.String> @callback = (System.Action<System.Int32, System.String>)typeof(System.Action<System.Int32, System.String>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.ForEach(@callback);

            return __ret;
        }

        static StackObject* get_pixelLightCount_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.pixelLightCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_pixelLightCount_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.pixelLightCount = value;

            return __ret;
        }

        static StackObject* get_shadows_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadows;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_shadows_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ShadowQuality @value = (UnityEngine.ShadowQuality)typeof(UnityEngine.ShadowQuality).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.shadows = value;

            return __ret;
        }

        static StackObject* get_shadowProjection_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowProjection;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_shadowProjection_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ShadowProjection @value = (UnityEngine.ShadowProjection)typeof(UnityEngine.ShadowProjection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.shadowProjection = value;

            return __ret;
        }

        static StackObject* get_shadowCascades_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowCascades;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_shadowCascades_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.shadowCascades = value;

            return __ret;
        }

        static StackObject* get_shadowDistance_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_shadowDistance_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.shadowDistance = value;

            return __ret;
        }

        static StackObject* get_shadowResolution_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowResolution;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_shadowResolution_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ShadowResolution @value = (UnityEngine.ShadowResolution)typeof(UnityEngine.ShadowResolution).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.shadowResolution = value;

            return __ret;
        }

        static StackObject* get_shadowmaskMode_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowmaskMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_shadowmaskMode_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ShadowmaskMode @value = (UnityEngine.ShadowmaskMode)typeof(UnityEngine.ShadowmaskMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.shadowmaskMode = value;

            return __ret;
        }

        static StackObject* get_shadowNearPlaneOffset_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowNearPlaneOffset;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_shadowNearPlaneOffset_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.shadowNearPlaneOffset = value;

            return __ret;
        }

        static StackObject* get_shadowCascade2Split_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowCascade2Split;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_shadowCascade2Split_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.shadowCascade2Split = value;

            return __ret;
        }

        static StackObject* get_shadowCascade4Split_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.shadowCascade4Split;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_shadowCascade4Split_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.shadowCascade4Split = value;

            return __ret;
        }

        static StackObject* get_lodBias_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.lodBias;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_lodBias_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.lodBias = value;

            return __ret;
        }

        static StackObject* get_anisotropicFiltering_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.anisotropicFiltering;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_anisotropicFiltering_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AnisotropicFiltering @value = (UnityEngine.AnisotropicFiltering)typeof(UnityEngine.AnisotropicFiltering).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.anisotropicFiltering = value;

            return __ret;
        }

        static StackObject* get_globalTextureMipmapLimit_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.globalTextureMipmapLimit;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_globalTextureMipmapLimit_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.globalTextureMipmapLimit = value;

            return __ret;
        }

        static StackObject* get_maximumLODLevel_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.maximumLODLevel;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maximumLODLevel_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.maximumLODLevel = value;

            return __ret;
        }

        static StackObject* get_enableLODCrossFade_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.enableLODCrossFade;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_enableLODCrossFade_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.enableLODCrossFade = value;

            return __ret;
        }

        static StackObject* get_particleRaycastBudget_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.particleRaycastBudget;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_particleRaycastBudget_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.particleRaycastBudget = value;

            return __ret;
        }

        static StackObject* get_softParticles_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.softParticles;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_softParticles_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.softParticles = value;

            return __ret;
        }

        static StackObject* get_softVegetation_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.softVegetation;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_softVegetation_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.softVegetation = value;

            return __ret;
        }

        static StackObject* get_vSyncCount_45(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.vSyncCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_vSyncCount_46(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.vSyncCount = value;

            return __ret;
        }

        static StackObject* get_realtimeGICPUUsage_47(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.realtimeGICPUUsage;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_realtimeGICPUUsage_48(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.realtimeGICPUUsage = value;

            return __ret;
        }

        static StackObject* get_antiAliasing_49(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.antiAliasing;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_antiAliasing_50(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.antiAliasing = value;

            return __ret;
        }

        static StackObject* get_asyncUploadTimeSlice_51(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.asyncUploadTimeSlice;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_asyncUploadTimeSlice_52(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.asyncUploadTimeSlice = value;

            return __ret;
        }

        static StackObject* get_asyncUploadBufferSize_53(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.asyncUploadBufferSize;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_asyncUploadBufferSize_54(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.asyncUploadBufferSize = value;

            return __ret;
        }

        static StackObject* get_asyncUploadPersistentBuffer_55(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.asyncUploadPersistentBuffer;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_asyncUploadPersistentBuffer_56(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.asyncUploadPersistentBuffer = value;

            return __ret;
        }

        static StackObject* SetLODSettings_57(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @setDirty = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @maximumLODLevel = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @lodBias = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.SetLODSettings(@lodBias, @maximumLODLevel, @setDirty);

            return __ret;
        }

        static StackObject* SetTextureMipmapLimitSettings_58(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TextureMipmapLimitSettings @textureMipmapLimitSettings = (UnityEngine.TextureMipmapLimitSettings)typeof(UnityEngine.TextureMipmapLimitSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @groupName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.SetTextureMipmapLimitSettings(@groupName, @textureMipmapLimitSettings);

            return __ret;
        }

        static StackObject* GetTextureMipmapLimitSettings_59(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @groupName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.QualitySettings.GetTextureMipmapLimitSettings(@groupName);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_realtimeReflectionProbes_60(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.realtimeReflectionProbes;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_realtimeReflectionProbes_61(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.realtimeReflectionProbes = value;

            return __ret;
        }

        static StackObject* get_billboardsFaceCameraPosition_62(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.billboardsFaceCameraPosition;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_billboardsFaceCameraPosition_63(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.billboardsFaceCameraPosition = value;

            return __ret;
        }

        static StackObject* get_useLegacyDetailDistribution_64(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.useLegacyDetailDistribution;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_useLegacyDetailDistribution_65(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.useLegacyDetailDistribution = value;

            return __ret;
        }

        static StackObject* get_resolutionScalingFixedDPIFactor_66(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.resolutionScalingFixedDPIFactor;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_resolutionScalingFixedDPIFactor_67(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.resolutionScalingFixedDPIFactor = value;

            return __ret;
        }

        static StackObject* get_terrainQualityOverrides_68(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.terrainQualityOverrides;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_terrainQualityOverrides_69(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.TerrainQualityOverrides @value = (UnityEngine.TerrainQualityOverrides)typeof(UnityEngine.TerrainQualityOverrides).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.terrainQualityOverrides = value;

            return __ret;
        }

        static StackObject* get_terrainPixelError_70(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.terrainPixelError;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_terrainPixelError_71(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.terrainPixelError = value;

            return __ret;
        }

        static StackObject* get_terrainDetailDensityScale_72(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.terrainDetailDensityScale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_terrainDetailDensityScale_73(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.terrainDetailDensityScale = value;

            return __ret;
        }

        static StackObject* get_terrainBasemapDistance_74(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.terrainBasemapDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_terrainBasemapDistance_75(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.terrainBasemapDistance = value;

            return __ret;
        }

        static StackObject* get_terrainDetailDistance_76(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.terrainDetailDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_terrainDetailDistance_77(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.terrainDetailDistance = value;

            return __ret;
        }

        static StackObject* get_terrainTreeDistance_78(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.terrainTreeDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_terrainTreeDistance_79(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.terrainTreeDistance = value;

            return __ret;
        }

        static StackObject* get_terrainBillboardStart_80(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.terrainBillboardStart;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_terrainBillboardStart_81(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.terrainBillboardStart = value;

            return __ret;
        }

        static StackObject* get_terrainFadeLength_82(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.terrainFadeLength;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_terrainFadeLength_83(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.terrainFadeLength = value;

            return __ret;
        }

        static StackObject* get_terrainMaxTrees_84(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.terrainMaxTrees;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_terrainMaxTrees_85(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.terrainMaxTrees = value;

            return __ret;
        }

        static StackObject* get_renderPipeline_86(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.renderPipeline;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_renderPipeline_87(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.RenderPipelineAsset @value = (UnityEngine.Rendering.RenderPipelineAsset)typeof(UnityEngine.Rendering.RenderPipelineAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.renderPipeline = value;

            return __ret;
        }

        static StackObject* GetRenderPipelineAssetAt_88(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @index = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.QualitySettings.GetRenderPipelineAssetAt(@index);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_skinWeights_89(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.skinWeights;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_skinWeights_90(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SkinWeights @value = (UnityEngine.SkinWeights)typeof(UnityEngine.SkinWeights).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.QualitySettings.skinWeights = value;

            return __ret;
        }

        static StackObject* get_count_91(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.count;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_streamingMipmapsActive_92(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.streamingMipmapsActive;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_streamingMipmapsActive_93(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.streamingMipmapsActive = value;

            return __ret;
        }

        static StackObject* get_streamingMipmapsMemoryBudget_94(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.streamingMipmapsMemoryBudget;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_streamingMipmapsMemoryBudget_95(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;


            UnityEngine.QualitySettings.streamingMipmapsMemoryBudget = value;

            return __ret;
        }

        static StackObject* get_streamingMipmapsRenderersPerFrame_96(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.streamingMipmapsRenderersPerFrame;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_streamingMipmapsRenderersPerFrame_97(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.streamingMipmapsRenderersPerFrame = value;

            return __ret;
        }

        static StackObject* get_streamingMipmapsMaxLevelReduction_98(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.streamingMipmapsMaxLevelReduction;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_streamingMipmapsMaxLevelReduction_99(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.streamingMipmapsMaxLevelReduction = value;

            return __ret;
        }

        static StackObject* get_streamingMipmapsAddAllCameras_100(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.streamingMipmapsAddAllCameras;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_streamingMipmapsAddAllCameras_101(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;


            UnityEngine.QualitySettings.streamingMipmapsAddAllCameras = value;

            return __ret;
        }

        static StackObject* get_streamingMipmapsMaxFileIORequests_102(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.streamingMipmapsMaxFileIORequests;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_streamingMipmapsMaxFileIORequests_103(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.streamingMipmapsMaxFileIORequests = value;

            return __ret;
        }

        static StackObject* get_maxQueuedFrames_104(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.maxQueuedFrames;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxQueuedFrames_105(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.maxQueuedFrames = value;

            return __ret;
        }

        static StackObject* GetQualityLevel_106(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.GetQualityLevel();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetQualitySettings_107(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.GetQualitySettings();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetQualityLevel_108(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @applyExpensiveChanges = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @index = ptr_of_this_method->Value;


            UnityEngine.QualitySettings.SetQualityLevel(@index, @applyExpensiveChanges);

            return __ret;
        }

        static StackObject* get_names_109(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.names;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        // static StackObject* IsPlatformIncluded_110(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Int32 @index = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     System.String @buildTargetGroupName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //
        //     var result_of_this_method = UnityEngine.QualitySettings.IsPlatformIncluded(@buildTargetGroupName, @index);
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }

        // static StackObject* TryIncludePlatformAt_111(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 3);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Exception @error = (System.Exception)typeof(System.Exception).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     System.Int32 @index = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
        //     System.String @buildTargetGroupName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //
        //
        //     var result_of_this_method = UnityEngine.QualitySettings.TryIncludePlatformAt(@buildTargetGroupName, @index, out @error);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     switch(ptr_of_this_method->ObjectType)
        //     {
        //         case ObjectTypes.StackObjectReference:
        //             {
        //                 var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
        //                 object ___obj = @error;
        //                 if (___dst->ObjectType >= ObjectTypes.Object)
        //                 {
        //                     if (___obj is CrossBindingAdaptorType)
        //                         ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
        //                     __mStack[___dst->Value] = ___obj;
        //                 }
        //                 else
        //                 {
        //                     ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
        //                 }
        //             }
        //             break;
        //         case ObjectTypes.FieldReference:
        //             {
        //                 var ___obj = __mStack[ptr_of_this_method->Value];
        //                 if(___obj is ILTypeInstance)
        //                 {
        //                     ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @error;
        //                 }
        //                 else
        //                 {
        //                     var ___type = __domain.GetType(___obj.GetType()) as CLRType;
        //                     ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @error);
        //                 }
        //             }
        //             break;
        //         case ObjectTypes.StaticFieldReference:
        //             {
        //                 var ___type = __domain.GetType(ptr_of_this_method->Value);
        //                 if(___type is ILType)
        //                 {
        //                     ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @error;
        //                 }
        //                 else
        //                 {
        //                     ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @error);
        //                 }
        //             }
        //             break;
        //          case ObjectTypes.ArrayReference:
        //             {
        //                 var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Exception[];
        //                 instance_of_arrayReference[ptr_of_this_method->ValueLow] = @error;
        //             }
        //             break;
        //     }
        //
        //     __intp.Free(ptr_of_this_method);
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     __intp.Free(ptr_of_this_method);
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
        //     __intp.Free(ptr_of_this_method);
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }

        // static StackObject* TryExcludePlatformAt_112(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 3);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Exception @error = (System.Exception)typeof(System.Exception).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     System.Int32 @index = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
        //     System.String @buildTargetGroupName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //
        //
        //     var result_of_this_method = UnityEngine.QualitySettings.TryExcludePlatformAt(@buildTargetGroupName, @index, out @error);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     switch(ptr_of_this_method->ObjectType)
        //     {
        //         case ObjectTypes.StackObjectReference:
        //             {
        //                 var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
        //                 object ___obj = @error;
        //                 if (___dst->ObjectType >= ObjectTypes.Object)
        //                 {
        //                     if (___obj is CrossBindingAdaptorType)
        //                         ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
        //                     __mStack[___dst->Value] = ___obj;
        //                 }
        //                 else
        //                 {
        //                     ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
        //                 }
        //             }
        //             break;
        //         case ObjectTypes.FieldReference:
        //             {
        //                 var ___obj = __mStack[ptr_of_this_method->Value];
        //                 if(___obj is ILTypeInstance)
        //                 {
        //                     ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @error;
        //                 }
        //                 else
        //                 {
        //                     var ___type = __domain.GetType(___obj.GetType()) as CLRType;
        //                     ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @error);
        //                 }
        //             }
        //             break;
        //         case ObjectTypes.StaticFieldReference:
        //             {
        //                 var ___type = __domain.GetType(ptr_of_this_method->Value);
        //                 if(___type is ILType)
        //                 {
        //                     ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @error;
        //                 }
        //                 else
        //                 {
        //                     ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @error);
        //                 }
        //             }
        //             break;
        //          case ObjectTypes.ArrayReference:
        //             {
        //                 var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Exception[];
        //                 instance_of_arrayReference[ptr_of_this_method->ValueLow] = @error;
        //             }
        //             break;
        //     }
        //
        //     __intp.Free(ptr_of_this_method);
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     __intp.Free(ptr_of_this_method);
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
        //     __intp.Free(ptr_of_this_method);
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }

        // static StackObject* GetActiveQualityLevelsForPlatform_113(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.String @buildTargetGroupName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //
        //     var result_of_this_method = UnityEngine.QualitySettings.GetActiveQualityLevelsForPlatform(@buildTargetGroupName);
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }

        // static StackObject* GetActiveQualityLevelsForPlatformCount_114(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.String @buildTargetGroupName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //
        //     var result_of_this_method = UnityEngine.QualitySettings.GetActiveQualityLevelsForPlatformCount(@buildTargetGroupName);
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method;
        //     return __ret + 1;
        // }

        // static StackObject* GetAllRenderPipelineAssetsForPlatform_115(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Collections.Generic.List<UnityEngine.Rendering.RenderPipelineAsset> @renderPipelineAssets = (System.Collections.Generic.List<UnityEngine.Rendering.RenderPipelineAsset>)typeof(System.Collections.Generic.List<UnityEngine.Rendering.RenderPipelineAsset>).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     System.String @buildTargetGroupName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //
        //
        //     UnityEngine.QualitySettings.GetAllRenderPipelineAssetsForPlatform(@buildTargetGroupName, ref @renderPipelineAssets);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     switch(ptr_of_this_method->ObjectType)
        //     {
        //         case ObjectTypes.StackObjectReference:
        //             {
        //                 var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
        //                 object ___obj = @renderPipelineAssets;
        //                 if (___dst->ObjectType >= ObjectTypes.Object)
        //                 {
        //                     if (___obj is CrossBindingAdaptorType)
        //                         ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
        //                     __mStack[___dst->Value] = ___obj;
        //                 }
        //                 else
        //                 {
        //                     ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
        //                 }
        //             }
        //             break;
        //         case ObjectTypes.FieldReference:
        //             {
        //                 var ___obj = __mStack[ptr_of_this_method->Value];
        //                 if(___obj is ILTypeInstance)
        //                 {
        //                     ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @renderPipelineAssets;
        //                 }
        //                 else
        //                 {
        //                     var ___type = __domain.GetType(___obj.GetType()) as CLRType;
        //                     ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @renderPipelineAssets);
        //                 }
        //             }
        //             break;
        //         case ObjectTypes.StaticFieldReference:
        //             {
        //                 var ___type = __domain.GetType(ptr_of_this_method->Value);
        //                 if(___type is ILType)
        //                 {
        //                     ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @renderPipelineAssets;
        //                 }
        //                 else
        //                 {
        //                     ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @renderPipelineAssets);
        //                 }
        //             }
        //             break;
        //          case ObjectTypes.ArrayReference:
        //             {
        //                 var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Collections.Generic.List<UnityEngine.Rendering.RenderPipelineAsset>[];
        //                 instance_of_arrayReference[ptr_of_this_method->ValueLow] = @renderPipelineAssets;
        //             }
        //             break;
        //     }
        //
        //     __intp.Free(ptr_of_this_method);
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     __intp.Free(ptr_of_this_method);
        //     return __ret;
        // }

        static StackObject* get_desiredColorSpace_116(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.desiredColorSpace;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_activeColorSpace_117(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QualitySettings.activeColorSpace;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }





    }
}

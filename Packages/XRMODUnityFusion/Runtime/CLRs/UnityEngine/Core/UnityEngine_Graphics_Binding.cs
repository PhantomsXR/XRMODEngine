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
    unsafe class UnityEngine_Graphics_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Graphics);
            args = new Type[]{};
            method = type.GetMethod("get_activeColorGamut", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_activeColorGamut_0);
            args = new Type[]{};
            method = type.GetMethod("get_activeTier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_activeTier_1);
            args = new Type[]{typeof(UnityEngine.Rendering.GraphicsTier)};
            method = type.GetMethod("set_activeTier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_activeTier_2);
            args = new Type[]{};
            method = type.GetMethod("get_preserveFramebufferAlpha", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_preserveFramebufferAlpha_3);
            args = new Type[]{};
            method = type.GetMethod("get_minOpenGLESVersion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_minOpenGLESVersion_4);
            args = new Type[]{};
            method = type.GetMethod("ClearRandomWriteTargets", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearRandomWriteTargets_5);
            args = new Type[]{typeof(UnityEngine.Rendering.CommandBuffer)};
            method = type.GetMethod("ExecuteCommandBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ExecuteCommandBuffer_6);
            args = new Type[]{typeof(UnityEngine.Rendering.CommandBuffer), typeof(UnityEngine.Rendering.ComputeQueueType)};
            method = type.GetMethod("ExecuteCommandBufferAsync", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ExecuteCommandBufferAsync_7);
            args = new Type[]{typeof(UnityEngine.RenderTexture), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_8);
            args = new Type[]{typeof(UnityEngine.RenderBuffer), typeof(UnityEngine.RenderBuffer), typeof(System.Int32), typeof(UnityEngine.CubemapFace), typeof(System.Int32)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_9);
            args = new Type[]{typeof(UnityEngine.RenderBuffer[]), typeof(UnityEngine.RenderBuffer)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_10);
            args = new Type[]{typeof(UnityEngine.RenderTargetSetup)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_11);
            args = new Type[]{};
            method = type.GetMethod("get_activeColorBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_activeColorBuffer_12);
            args = new Type[]{};
            method = type.GetMethod("get_activeDepthBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_activeDepthBuffer_13);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.RenderTexture)};
            method = type.GetMethod("SetRandomWriteTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRandomWriteTarget_14);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Boolean)};
            method = type.GetMethod("SetRandomWriteTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRandomWriteTarget_15);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Boolean)};
            method = type.GetMethod("SetRandomWriteTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRandomWriteTarget_16);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.Texture)};
            method = type.GetMethod("CopyTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTexture_17);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(System.Int32), typeof(UnityEngine.Texture), typeof(System.Int32)};
            method = type.GetMethod("CopyTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTexture_18);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("CopyTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTexture_19);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("CopyTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyTexture_20);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.Texture)};
            method = type.GetMethod("ConvertTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ConvertTexture_21);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(System.Int32), typeof(UnityEngine.Texture), typeof(System.Int32)};
            method = type.GetMethod("ConvertTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ConvertTexture_22);
            args = new Type[]{typeof(UnityEngine.Rendering.SynchronisationStage)};
            method = type.GetMethod("CreateAsyncGraphicsFence", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateAsyncGraphicsFence_23);
            args = new Type[]{};
            method = type.GetMethod("CreateAsyncGraphicsFence", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateAsyncGraphicsFence_24);
            args = new Type[]{typeof(UnityEngine.Rendering.GraphicsFenceType), typeof(UnityEngine.Rendering.SynchronisationStageFlags)};
            method = type.GetMethod("CreateGraphicsFence", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateGraphicsFence_25);
            args = new Type[]{typeof(UnityEngine.Rendering.GraphicsFence)};
            method = type.GetMethod("WaitOnAsyncGraphicsFence", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WaitOnAsyncGraphicsFence_26);
            args = new Type[]{typeof(UnityEngine.Rendering.GraphicsFence), typeof(UnityEngine.Rendering.SynchronisationStage)};
            method = type.GetMethod("WaitOnAsyncGraphicsFence", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WaitOnAsyncGraphicsFence_27);
            args = new Type[]{typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.GraphicsBuffer)};
            method = type.GetMethod("CopyBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyBuffer_28);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color), typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_29);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_30);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_31);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_32);
            args = new Type[]{typeof(UnityEngine.RenderParams).MakeByRefType(), typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Matrix4x4), typeof(System.Nullable<UnityEngine.Matrix4x4>)};
            method = type.GetMethod("RenderMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RenderMesh_33);
            args = new Type[]{typeof(UnityEngine.RenderParams).MakeByRefType(), typeof(UnityEngine.Mesh), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("RenderMeshIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RenderMeshIndirect_34);
            args = new Type[]{typeof(UnityEngine.RenderParams).MakeByRefType(), typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("RenderMeshPrimitives", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RenderMeshPrimitives_35);
            args = new Type[]{typeof(UnityEngine.RenderParams).MakeByRefType(), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("RenderPrimitives", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RenderPrimitives_36);
            args = new Type[]{typeof(UnityEngine.RenderParams).MakeByRefType(), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("RenderPrimitivesIndexed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RenderPrimitivesIndexed_37);
            args = new Type[]{typeof(UnityEngine.RenderParams).MakeByRefType(), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("RenderPrimitivesIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RenderPrimitivesIndirect_38);
            args = new Type[]{typeof(UnityEngine.RenderParams).MakeByRefType(), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("RenderPrimitivesIndexedIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RenderPrimitivesIndexedIndirect_39);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(System.Int32)};
            method = type.GetMethod("DrawMeshNow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshNow_40);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(System.Int32)};
            method = type.GetMethod("DrawMeshNow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshNow_41);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("DrawMeshNow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshNow_42);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("DrawMeshNow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshNow_43);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_44);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(UnityEngine.Transform), typeof(System.Boolean)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_45);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_46);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(UnityEngine.Transform), typeof(UnityEngine.Rendering.LightProbeUsage), typeof(UnityEngine.LightProbeProxyVolume)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_47);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4[]), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(UnityEngine.Rendering.LightProbeUsage), typeof(UnityEngine.LightProbeProxyVolume)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_48);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(UnityEngine.Rendering.LightProbeUsage), typeof(UnityEngine.LightProbeProxyVolume)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_49);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Bounds), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(UnityEngine.Rendering.LightProbeUsage), typeof(UnityEngine.LightProbeProxyVolume)};
            method = type.GetMethod("DrawMeshInstancedProcedural", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstancedProcedural_50);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Bounds), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(UnityEngine.Rendering.LightProbeUsage), typeof(UnityEngine.LightProbeProxyVolume)};
            method = type.GetMethod("DrawMeshInstancedIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstancedIndirect_51);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Bounds), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(UnityEngine.Rendering.LightProbeUsage), typeof(UnityEngine.LightProbeProxyVolume)};
            method = type.GetMethod("DrawMeshInstancedIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstancedIndirect_52);
            args = new Type[]{typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("DrawProceduralNow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProceduralNow_53);
            args = new Type[]{typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("DrawProceduralNow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProceduralNow_54);
            args = new Type[]{typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32)};
            method = type.GetMethod("DrawProceduralIndirectNow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProceduralIndirectNow_55);
            args = new Type[]{typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32)};
            method = type.GetMethod("DrawProceduralIndirectNow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProceduralIndirectNow_56);
            args = new Type[]{typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32)};
            method = type.GetMethod("DrawProceduralIndirectNow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProceduralIndirectNow_57);
            args = new Type[]{typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32)};
            method = type.GetMethod("DrawProceduralIndirectNow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProceduralIndirectNow_58);
            args = new Type[]{typeof(UnityEngine.Material), typeof(UnityEngine.Bounds), typeof(UnityEngine.MeshTopology), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32)};
            method = type.GetMethod("DrawProcedural", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProcedural_59);
            args = new Type[]{typeof(UnityEngine.Material), typeof(UnityEngine.Bounds), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32)};
            method = type.GetMethod("DrawProcedural", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProcedural_60);
            args = new Type[]{typeof(UnityEngine.Material), typeof(UnityEngine.Bounds), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32)};
            method = type.GetMethod("DrawProceduralIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProceduralIndirect_61);
            args = new Type[]{typeof(UnityEngine.Material), typeof(UnityEngine.Bounds), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32)};
            method = type.GetMethod("DrawProceduralIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProceduralIndirect_62);
            args = new Type[]{typeof(UnityEngine.Material), typeof(UnityEngine.Bounds), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32)};
            method = type.GetMethod("DrawProceduralIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProceduralIndirect_63);
            args = new Type[]{typeof(UnityEngine.Material), typeof(UnityEngine.Bounds), typeof(UnityEngine.MeshTopology), typeof(UnityEngine.GraphicsBuffer), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32)};
            method = type.GetMethod("DrawProceduralIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawProceduralIndirect_64);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.RenderTexture)};
            method = type.GetMethod("Blit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Blit_65);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.RenderTexture), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("Blit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Blit_66);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2)};
            method = type.GetMethod("Blit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Blit_67);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("Blit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Blit_68);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("Blit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Blit_69);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("Blit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Blit_70);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Material)};
            method = type.GetMethod("Blit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Blit_71);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("Blit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Blit_72);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.Material), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("Blit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Blit_73);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.Material)};
            method = type.GetMethod("Blit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Blit_74);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Material), typeof(UnityEngine.Vector2[])};
            method = type.GetMethod("BlitMultiTap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BlitMultiTap_75);
            args = new Type[]{typeof(UnityEngine.Texture), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Vector2[])};
            method = type.GetMethod("BlitMultiTap", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BlitMultiTap_76);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_77);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_78);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_79);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_80);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Boolean)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_81);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_82);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_83);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_84);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(UnityEngine.Transform)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_85);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_86);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_87);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_88);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_89);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Boolean)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_90);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_91);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_92);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_93);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(UnityEngine.Transform)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_94);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(UnityEngine.Transform), typeof(System.Boolean)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_95);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(UnityEngine.Matrix4x4), typeof(UnityEngine.Material), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(UnityEngine.Transform), typeof(UnityEngine.Rendering.LightProbeUsage)};
            method = type.GetMethod("DrawMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMesh_96);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4[])};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_97);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4[]), typeof(System.Int32)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_98);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4[]), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_99);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4[]), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_100);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4[]), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_101);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4[]), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_102);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4[]), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32), typeof(UnityEngine.Camera)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_103);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Matrix4x4[]), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(UnityEngine.Rendering.LightProbeUsage)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_104);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_105);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>), typeof(UnityEngine.MaterialPropertyBlock)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_106);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_107);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_108);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_109);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32), typeof(UnityEngine.Camera)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_110);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(UnityEngine.Rendering.LightProbeUsage)};
            method = type.GetMethod("DrawMeshInstanced", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstanced_111);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Bounds), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(UnityEngine.Rendering.LightProbeUsage)};
            method = type.GetMethod("DrawMeshInstancedIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstancedIndirect_112);
            args = new Type[]{typeof(UnityEngine.Mesh), typeof(System.Int32), typeof(UnityEngine.Material), typeof(UnityEngine.Bounds), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(UnityEngine.MaterialPropertyBlock), typeof(UnityEngine.Rendering.ShadowCastingMode), typeof(System.Boolean), typeof(System.Int32), typeof(UnityEngine.Camera), typeof(UnityEngine.Rendering.LightProbeUsage)};
            method = type.GetMethod("DrawMeshInstancedIndirect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawMeshInstancedIndirect_113);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color), typeof(UnityEngine.Material)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_114);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Color)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_115);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Material)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_116);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.Rect), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_117);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Material)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_118);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_119);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture), typeof(UnityEngine.Material)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_120);
            args = new Type[]{typeof(UnityEngine.Rect), typeof(UnityEngine.Texture)};
            method = type.GetMethod("DrawTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DrawTexture_121);
            args = new Type[]{typeof(UnityEngine.RenderTexture)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_122);
            args = new Type[]{typeof(UnityEngine.RenderTexture), typeof(System.Int32)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_123);
            args = new Type[]{typeof(UnityEngine.RenderTexture), typeof(System.Int32), typeof(UnityEngine.CubemapFace)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_124);
            args = new Type[]{typeof(UnityEngine.RenderBuffer), typeof(UnityEngine.RenderBuffer)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_125);
            args = new Type[]{typeof(UnityEngine.RenderBuffer), typeof(UnityEngine.RenderBuffer), typeof(System.Int32)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_126);
            args = new Type[]{typeof(UnityEngine.RenderBuffer), typeof(UnityEngine.RenderBuffer), typeof(System.Int32), typeof(UnityEngine.CubemapFace)};
            method = type.GetMethod("SetRenderTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRenderTarget_127);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.ComputeBuffer)};
            method = type.GetMethod("SetRandomWriteTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRandomWriteTarget_128);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer)};
            method = type.GetMethod("SetRandomWriteTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRandomWriteTarget_129);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Graphics());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Graphics[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_activeColorGamut_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Graphics.activeColorGamut;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_activeTier_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Graphics.activeTier;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_activeTier_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.GraphicsTier @value = (UnityEngine.Rendering.GraphicsTier)typeof(UnityEngine.Rendering.GraphicsTier).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.activeTier = value;

            return __ret;
        }

        static StackObject* get_preserveFramebufferAlpha_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Graphics.preserveFramebufferAlpha;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_minOpenGLESVersion_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Graphics.minOpenGLESVersion;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ClearRandomWriteTargets_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.Graphics.ClearRandomWriteTargets();

            return __ret;
        }

        static StackObject* ExecuteCommandBuffer_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.CommandBuffer @buffer = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.ExecuteCommandBuffer(@buffer);

            return __ret;
        }

        static StackObject* ExecuteCommandBufferAsync_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ComputeQueueType @queueType = (UnityEngine.Rendering.ComputeQueueType)typeof(UnityEngine.Rendering.ComputeQueueType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.CommandBuffer @buffer = (UnityEngine.Rendering.CommandBuffer)typeof(UnityEngine.Rendering.CommandBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.ExecuteCommandBufferAsync(@buffer, @queueType);

            return __ret;
        }

        static StackObject* SetRenderTarget_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @depthSlice = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CubemapFace @face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @mipLevel = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.RenderTexture @rt = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.SetRenderTarget(@rt, @mipLevel, @face, @depthSlice);

            return __ret;
        }

        static StackObject* SetRenderTarget_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @depthSlice = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CubemapFace @face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @mipLevel = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.RenderBuffer @depthBuffer = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.RenderBuffer @colorBuffer = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.SetRenderTarget(@colorBuffer, @depthBuffer, @mipLevel, @face, @depthSlice);

            return __ret;
        }

        static StackObject* SetRenderTarget_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderBuffer @depthBuffer = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RenderBuffer[] @colorBuffers = (UnityEngine.RenderBuffer[])typeof(UnityEngine.RenderBuffer[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.SetRenderTarget(@colorBuffers, @depthBuffer);

            return __ret;
        }

        static StackObject* SetRenderTarget_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderTargetSetup @setup = (UnityEngine.RenderTargetSetup)typeof(UnityEngine.RenderTargetSetup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.SetRenderTarget(@setup);

            return __ret;
        }

        static StackObject* get_activeColorBuffer_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Graphics.activeColorBuffer;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_activeDepthBuffer_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Graphics.activeDepthBuffer;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetRandomWriteTarget_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderTexture @uav = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @index = ptr_of_this_method->Value;


            UnityEngine.Graphics.SetRandomWriteTarget(@index, @uav);

            return __ret;
        }

        static StackObject* SetRandomWriteTarget_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @preserveCounterValue = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ComputeBuffer @uav = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @index = ptr_of_this_method->Value;


            UnityEngine.Graphics.SetRandomWriteTarget(@index, @uav, @preserveCounterValue);

            return __ret;
        }

        static StackObject* SetRandomWriteTarget_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @preserveCounterValue = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GraphicsBuffer @uav = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @index = ptr_of_this_method->Value;


            UnityEngine.Graphics.SetRandomWriteTarget(@index, @uav, @preserveCounterValue);

            return __ret;
        }

        static StackObject* CopyTexture_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture @dst = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture @src = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.CopyTexture(@src, @dst);

            return __ret;
        }

        static StackObject* CopyTexture_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @dstElement = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture @dst = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @srcElement = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Texture @src = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.CopyTexture(@src, @srcElement, @dst, @dstElement);

            return __ret;
        }

        static StackObject* CopyTexture_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @dstMip = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @dstElement = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Texture @dst = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @srcMip = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @srcElement = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Texture @src = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.CopyTexture(@src, @srcElement, @srcMip, @dst, @dstElement, @dstMip);

            return __ret;
        }

        static StackObject* CopyTexture_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 12);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @dstY = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @dstX = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @dstMip = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @dstElement = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Texture @dst = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @srcHeight = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 @srcWidth = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Int32 @srcY = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            System.Int32 @srcX = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            System.Int32 @srcMip = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            System.Int32 @srcElement = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 12);
            UnityEngine.Texture @src = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.CopyTexture(@src, @srcElement, @srcMip, @srcX, @srcY, @srcWidth, @srcHeight, @dst, @dstElement, @dstMip, @dstX, @dstY);

            return __ret;
        }

        static StackObject* ConvertTexture_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture @dst = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture @src = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Graphics.ConvertTexture(@src, @dst);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* ConvertTexture_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @dstElement = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture @dst = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @srcElement = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Texture @src = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Graphics.ConvertTexture(@src, @srcElement, @dst, @dstElement);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* CreateAsyncGraphicsFence_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.SynchronisationStage @stage = (UnityEngine.Rendering.SynchronisationStage)typeof(UnityEngine.Rendering.SynchronisationStage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Graphics.CreateAsyncGraphicsFence(@stage);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateAsyncGraphicsFence_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Graphics.CreateAsyncGraphicsFence();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateGraphicsFence_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.SynchronisationStageFlags @stage = (UnityEngine.Rendering.SynchronisationStageFlags)typeof(UnityEngine.Rendering.SynchronisationStageFlags).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.GraphicsFenceType @fenceType = (UnityEngine.Rendering.GraphicsFenceType)typeof(UnityEngine.Rendering.GraphicsFenceType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Graphics.CreateGraphicsFence(@fenceType, @stage);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* WaitOnAsyncGraphicsFence_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.GraphicsFence @fence = (UnityEngine.Rendering.GraphicsFence)typeof(UnityEngine.Rendering.GraphicsFence).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.WaitOnAsyncGraphicsFence(@fence);

            return __ret;
        }

        static StackObject* WaitOnAsyncGraphicsFence_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.SynchronisationStage @stage = (UnityEngine.Rendering.SynchronisationStage)typeof(UnityEngine.Rendering.SynchronisationStage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.GraphicsFence @fence = (UnityEngine.Rendering.GraphicsFence)typeof(UnityEngine.Rendering.GraphicsFence).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.WaitOnAsyncGraphicsFence(@fence, @stage);

            return __ret;
        }

        static StackObject* CopyBuffer_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GraphicsBuffer @dest = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GraphicsBuffer @source = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.CopyBuffer(@source, @dest);

            return __ret;
        }

        static StackObject* DrawTexture_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @pass = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material @mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Color @color = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @bottomBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @topBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @rightBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 @leftBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Rect @sourceRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Texture @texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawTexture(@screenRect, @texture, @sourceRect, @leftBorder, @rightBorder, @topBorder, @bottomBorder, @color, @mat, @pass);

            return __ret;
        }

        static StackObject* DrawTexture_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @pass = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material @mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @bottomBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @topBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @rightBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @leftBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Rect @sourceRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Texture @texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawTexture(@screenRect, @texture, @sourceRect, @leftBorder, @rightBorder, @topBorder, @bottomBorder, @mat, @pass);

            return __ret;
        }

        static StackObject* DrawTexture_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @pass = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material @mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @bottomBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @topBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @rightBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @leftBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Texture @texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawTexture(@screenRect, @texture, @leftBorder, @rightBorder, @topBorder, @bottomBorder, @mat, @pass);

            return __ret;
        }

        static StackObject* DrawTexture_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @pass = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material @mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Texture @texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawTexture(@screenRect, @texture, @mat, @pass);

            return __ret;
        }

        static StackObject* RenderMesh_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Nullable<UnityEngine.Matrix4x4> @prevObjectToWorld = (System.Nullable<UnityEngine.Matrix4x4>)typeof(System.Nullable<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Matrix4x4 @objectToWorld = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.RenderParams @rparams = (UnityEngine.RenderParams)typeof(UnityEngine.RenderParams).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);


            UnityEngine.Graphics.RenderMesh(in @rparams, @mesh, @submeshIndex, @objectToWorld, @prevObjectToWorld);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @rparams;
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
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @rparams;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @rparams);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @rparams;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @rparams);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.RenderParams[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @rparams;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* RenderMeshIndirect_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @startCommand = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @commandCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GraphicsBuffer @commandBuffer = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.RenderParams @rparams = (UnityEngine.RenderParams)typeof(UnityEngine.RenderParams).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);


            UnityEngine.Graphics.RenderMeshIndirect(in @rparams, @mesh, @commandBuffer, @commandCount, @startCommand);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @rparams;
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
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @rparams;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @rparams);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @rparams;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @rparams);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.RenderParams[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @rparams;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* RenderMeshPrimitives_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @instanceCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.RenderParams @rparams = (UnityEngine.RenderParams)typeof(UnityEngine.RenderParams).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);


            UnityEngine.Graphics.RenderMeshPrimitives(in @rparams, @mesh, @submeshIndex, @instanceCount);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @rparams;
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
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @rparams;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @rparams);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @rparams;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @rparams);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.RenderParams[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @rparams;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* RenderPrimitives_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @instanceCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @vertexCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MeshTopology @topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.RenderParams @rparams = (UnityEngine.RenderParams)typeof(UnityEngine.RenderParams).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);


            UnityEngine.Graphics.RenderPrimitives(in @rparams, @topology, @vertexCount, @instanceCount);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @rparams;
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
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @rparams;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @rparams);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @rparams;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @rparams);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.RenderParams[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @rparams;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* RenderPrimitivesIndexed_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @instanceCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @startIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @indexCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.GraphicsBuffer @indexBuffer = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.MeshTopology @topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.RenderParams @rparams = (UnityEngine.RenderParams)typeof(UnityEngine.RenderParams).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);


            UnityEngine.Graphics.RenderPrimitivesIndexed(in @rparams, @topology, @indexBuffer, @indexCount, @startIndex, @instanceCount);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @rparams;
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
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @rparams;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @rparams);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @rparams;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @rparams);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.RenderParams[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @rparams;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* RenderPrimitivesIndirect_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @startCommand = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @commandCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GraphicsBuffer @commandBuffer = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MeshTopology @topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.RenderParams @rparams = (UnityEngine.RenderParams)typeof(UnityEngine.RenderParams).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);


            UnityEngine.Graphics.RenderPrimitivesIndirect(in @rparams, @topology, @commandBuffer, @commandCount, @startCommand);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @rparams;
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
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @rparams;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @rparams);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @rparams;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @rparams);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.RenderParams[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @rparams;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* RenderPrimitivesIndexedIndirect_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @startCommand = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @commandCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GraphicsBuffer @commandBuffer = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.GraphicsBuffer @indexBuffer = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.MeshTopology @topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.RenderParams @rparams = (UnityEngine.RenderParams)typeof(UnityEngine.RenderParams).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);


            UnityEngine.Graphics.RenderPrimitivesIndexedIndirect(in @rparams, @topology, @indexBuffer, @commandBuffer, @commandCount, @startCommand);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @rparams;
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
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @rparams;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @rparams);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @rparams;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @rparams);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.RenderParams[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @rparams;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* DrawMeshNow_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @materialIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshNow(@mesh, @position, @rotation, @materialIndex);

            return __ret;
        }

        static StackObject* DrawMeshNow_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @materialIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Matrix4x4 @matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshNow(@mesh, @matrix, @materialIndex);

            return __ret;
        }

        static StackObject* DrawMeshNow_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshNow(@mesh, @position, @rotation);

            return __ret;
        }

        static StackObject* DrawMeshNow_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 @matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshNow(@mesh, @matrix);

            return __ret;
        }

        static StackObject* DrawMesh_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 11);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @useLightProbes = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @castShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @position, @rotation, @material, @layer, @camera, @submeshIndex, @properties, @castShadows, @receiveShadows, @useLightProbes);

            return __ret;
        }

        static StackObject* DrawMesh_45(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 12);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @useLightProbes = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform @probeAnchor = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 12);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @position, @rotation, @material, @layer, @camera, @submeshIndex, @properties, @castShadows, @receiveShadows, @probeAnchor, @useLightProbes);

            return __ret;
        }

        static StackObject* DrawMesh_46(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @useLightProbes = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @castShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Matrix4x4 @matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @matrix, @material, @layer, @camera, @submeshIndex, @properties, @castShadows, @receiveShadows, @useLightProbes);

            return __ret;
        }

        static StackObject* DrawMesh_47(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 12);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume @lightProbeProxyVolume = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.LightProbeUsage @lightProbeUsage = (UnityEngine.Rendering.LightProbeUsage)typeof(UnityEngine.Rendering.LightProbeUsage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Transform @probeAnchor = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            UnityEngine.Matrix4x4 @matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 12);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @matrix, @material, @layer, @camera, @submeshIndex, @properties, @castShadows, @receiveShadows, @probeAnchor, @lightProbeUsage, @lightProbeProxyVolume);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_48(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 12);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume @lightProbeProxyVolume = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.LightProbeUsage @lightProbeUsage = (UnityEngine.Rendering.LightProbeUsage)typeof(UnityEngine.Rendering.LightProbeUsage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Int32 @count = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Matrix4x4[] @matrices = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 12);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstanced(@mesh, @submeshIndex, @material, @matrices, @count, @properties, @castShadows, @receiveShadows, @layer, @camera, @lightProbeUsage, @lightProbeProxyVolume);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_49(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 11);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume @lightProbeProxyVolume = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.LightProbeUsage @lightProbeUsage = (UnityEngine.Rendering.LightProbeUsage)typeof(UnityEngine.Rendering.LightProbeUsage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> @matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstanced(@mesh, @submeshIndex, @material, @matrices, @properties, @castShadows, @receiveShadows, @layer, @camera, @lightProbeUsage, @lightProbeProxyVolume);

            return __ret;
        }

        static StackObject* DrawMeshInstancedProcedural_50(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 12);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume @lightProbeProxyVolume = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.LightProbeUsage @lightProbeUsage = (UnityEngine.Rendering.LightProbeUsage)typeof(UnityEngine.Rendering.LightProbeUsage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Int32 @count = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Bounds @bounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 12);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstancedProcedural(@mesh, @submeshIndex, @material, @bounds, @count, @properties, @castShadows, @receiveShadows, @layer, @camera, @lightProbeUsage, @lightProbeProxyVolume);

            return __ret;
        }

        static StackObject* DrawMeshInstancedIndirect_51(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 13);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume @lightProbeProxyVolume = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.LightProbeUsage @lightProbeUsage = (UnityEngine.Rendering.LightProbeUsage)typeof(UnityEngine.Rendering.LightProbeUsage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Int32 @argsOffset = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.ComputeBuffer @bufferWithArgs = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Bounds @bounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 12);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 13);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstancedIndirect(@mesh, @submeshIndex, @material, @bounds, @bufferWithArgs, @argsOffset, @properties, @castShadows, @receiveShadows, @layer, @camera, @lightProbeUsage, @lightProbeProxyVolume);

            return __ret;
        }

        static StackObject* DrawMeshInstancedIndirect_52(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 13);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbeProxyVolume @lightProbeProxyVolume = (UnityEngine.LightProbeProxyVolume)typeof(UnityEngine.LightProbeProxyVolume).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.LightProbeUsage @lightProbeUsage = (UnityEngine.Rendering.LightProbeUsage)typeof(UnityEngine.Rendering.LightProbeUsage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Int32 @argsOffset = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.GraphicsBuffer @bufferWithArgs = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Bounds @bounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 12);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 13);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstancedIndirect(@mesh, @submeshIndex, @material, @bounds, @bufferWithArgs, @argsOffset, @properties, @castShadows, @receiveShadows, @layer, @camera, @lightProbeUsage, @lightProbeProxyVolume);

            return __ret;
        }

        static StackObject* DrawProceduralNow_53(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @instanceCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @vertexCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MeshTopology @topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawProceduralNow(@topology, @vertexCount, @instanceCount);

            return __ret;
        }

        static StackObject* DrawProceduralNow_54(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @instanceCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @indexCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GraphicsBuffer @indexBuffer = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MeshTopology @topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawProceduralNow(@topology, @indexBuffer, @indexCount, @instanceCount);

            return __ret;
        }

        static StackObject* DrawProceduralIndirectNow_55(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @argsOffset = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ComputeBuffer @bufferWithArgs = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MeshTopology @topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawProceduralIndirectNow(@topology, @bufferWithArgs, @argsOffset);

            return __ret;
        }

        static StackObject* DrawProceduralIndirectNow_56(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @argsOffset = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.ComputeBuffer @bufferWithArgs = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GraphicsBuffer @indexBuffer = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MeshTopology @topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawProceduralIndirectNow(@topology, @indexBuffer, @bufferWithArgs, @argsOffset);

            return __ret;
        }

        static StackObject* DrawProceduralIndirectNow_57(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @argsOffset = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GraphicsBuffer @bufferWithArgs = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MeshTopology @topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawProceduralIndirectNow(@topology, @bufferWithArgs, @argsOffset);

            return __ret;
        }

        static StackObject* DrawProceduralIndirectNow_58(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @argsOffset = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GraphicsBuffer @bufferWithArgs = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GraphicsBuffer @indexBuffer = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MeshTopology @topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawProceduralIndirectNow(@topology, @indexBuffer, @bufferWithArgs, @argsOffset);

            return __ret;
        }

        static StackObject* DrawProcedural_59(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @instanceCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 @vertexCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.MeshTopology @topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Bounds @bounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawProcedural(@material, @bounds, @topology, @vertexCount, @instanceCount, @camera, @properties, @castShadows, @receiveShadows, @layer);

            return __ret;
        }

        static StackObject* DrawProcedural_60(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 11);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @instanceCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 @indexCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.GraphicsBuffer @indexBuffer = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.MeshTopology @topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Bounds @bounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawProcedural(@material, @bounds, @topology, @indexBuffer, @indexCount, @instanceCount, @camera, @properties, @castShadows, @receiveShadows, @layer);

            return __ret;
        }

        static StackObject* DrawProceduralIndirect_61(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @argsOffset = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.ComputeBuffer @bufferWithArgs = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.MeshTopology @topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Bounds @bounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawProceduralIndirect(@material, @bounds, @topology, @bufferWithArgs, @argsOffset, @camera, @properties, @castShadows, @receiveShadows, @layer);

            return __ret;
        }

        static StackObject* DrawProceduralIndirect_62(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @argsOffset = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.GraphicsBuffer @bufferWithArgs = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.MeshTopology @topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Bounds @bounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawProceduralIndirect(@material, @bounds, @topology, @bufferWithArgs, @argsOffset, @camera, @properties, @castShadows, @receiveShadows, @layer);

            return __ret;
        }

        static StackObject* DrawProceduralIndirect_63(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 11);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @argsOffset = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.ComputeBuffer @bufferWithArgs = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.GraphicsBuffer @indexBuffer = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.MeshTopology @topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Bounds @bounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawProceduralIndirect(@material, @bounds, @topology, @indexBuffer, @bufferWithArgs, @argsOffset, @camera, @properties, @castShadows, @receiveShadows, @layer);

            return __ret;
        }

        static StackObject* DrawProceduralIndirect_64(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 11);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @argsOffset = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.GraphicsBuffer @bufferWithArgs = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.GraphicsBuffer @indexBuffer = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.MeshTopology @topology = (UnityEngine.MeshTopology)typeof(UnityEngine.MeshTopology).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Bounds @bounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawProceduralIndirect(@material, @bounds, @topology, @indexBuffer, @bufferWithArgs, @argsOffset, @camera, @properties, @castShadows, @receiveShadows, @layer);

            return __ret;
        }

        static StackObject* Blit_65(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderTexture @dest = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture @source = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.Blit(@source, @dest);

            return __ret;
        }

        static StackObject* Blit_66(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @destDepthSlice = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @sourceDepthSlice = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RenderTexture @dest = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Texture @source = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.Blit(@source, @dest, @sourceDepthSlice, @destDepthSlice);

            return __ret;
        }

        static StackObject* Blit_67(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @offset = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @scale = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RenderTexture @dest = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Texture @source = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.Blit(@source, @dest, @scale, @offset);

            return __ret;
        }

        static StackObject* Blit_68(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @destDepthSlice = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @sourceDepthSlice = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @offset = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @scale = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.RenderTexture @dest = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Texture @source = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.Blit(@source, @dest, @scale, @offset, @sourceDepthSlice, @destDepthSlice);

            return __ret;
        }

        static StackObject* Blit_69(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @pass = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material @mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RenderTexture @dest = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Texture @source = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.Blit(@source, @dest, @mat, @pass);

            return __ret;
        }

        static StackObject* Blit_70(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @destDepthSlice = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @pass = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Material @mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.RenderTexture @dest = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Texture @source = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.Blit(@source, @dest, @mat, @pass, @destDepthSlice);

            return __ret;
        }

        static StackObject* Blit_71(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material @mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RenderTexture @dest = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Texture @source = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.Blit(@source, @dest, @mat);

            return __ret;
        }

        static StackObject* Blit_72(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @pass = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material @mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Texture @source = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.Blit(@source, @mat, @pass);

            return __ret;
        }

        static StackObject* Blit_73(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @destDepthSlice = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @pass = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Material @mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Texture @source = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.Blit(@source, @mat, @pass, @destDepthSlice);

            return __ret;
        }

        static StackObject* Blit_74(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material @mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture @source = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.Blit(@source, @mat);

            return __ret;
        }

        static StackObject* BlitMultiTap_75(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2[] @offsets = (UnityEngine.Vector2[])typeof(UnityEngine.Vector2[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material @mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RenderTexture @dest = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Texture @source = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.BlitMultiTap(@source, @dest, @mat, @offsets);

            return __ret;
        }

        static StackObject* BlitMultiTap_76(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2[] @offsets = (UnityEngine.Vector2[])typeof(UnityEngine.Vector2[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @destDepthSlice = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Material @mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.RenderTexture @dest = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Texture @source = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.BlitMultiTap(@source, @dest, @mat, @destDepthSlice, @offsets);

            return __ret;
        }

        static StackObject* DrawMesh_77(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @position, @rotation, @material, @layer);

            return __ret;
        }

        static StackObject* DrawMesh_78(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @position, @rotation, @material, @layer, @camera);

            return __ret;
        }

        static StackObject* DrawMesh_79(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @position, @rotation, @material, @layer, @camera, @submeshIndex);

            return __ret;
        }

        static StackObject* DrawMesh_80(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @position, @rotation, @material, @layer, @camera, @submeshIndex, @properties);

            return __ret;
        }

        static StackObject* DrawMesh_81(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @castShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @position, @rotation, @material, @layer, @camera, @submeshIndex, @properties, @castShadows);

            return __ret;
        }

        static StackObject* DrawMesh_82(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @castShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @position, @rotation, @material, @layer, @camera, @submeshIndex, @properties, @castShadows, @receiveShadows);

            return __ret;
        }

        static StackObject* DrawMesh_83(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @position, @rotation, @material, @layer, @camera, @submeshIndex, @properties, @castShadows);

            return __ret;
        }

        static StackObject* DrawMesh_84(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @position, @rotation, @material, @layer, @camera, @submeshIndex, @properties, @castShadows, @receiveShadows);

            return __ret;
        }

        static StackObject* DrawMesh_85(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 11);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @probeAnchor = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @position, @rotation, @material, @layer, @camera, @submeshIndex, @properties, @castShadows, @receiveShadows, @probeAnchor);

            return __ret;
        }

        static StackObject* DrawMesh_86(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Matrix4x4 @matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @matrix, @material, @layer);

            return __ret;
        }

        static StackObject* DrawMesh_87(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Matrix4x4 @matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @matrix, @material, @layer, @camera);

            return __ret;
        }

        static StackObject* DrawMesh_88(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Matrix4x4 @matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @matrix, @material, @layer, @camera, @submeshIndex);

            return __ret;
        }

        static StackObject* DrawMesh_89(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Matrix4x4 @matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @matrix, @material, @layer, @camera, @submeshIndex, @properties);

            return __ret;
        }

        static StackObject* DrawMesh_90(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @castShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Matrix4x4 @matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @matrix, @material, @layer, @camera, @submeshIndex, @properties, @castShadows);

            return __ret;
        }

        static StackObject* DrawMesh_91(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @castShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Matrix4x4 @matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @matrix, @material, @layer, @camera, @submeshIndex, @properties, @castShadows, @receiveShadows);

            return __ret;
        }

        static StackObject* DrawMesh_92(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Matrix4x4 @matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @matrix, @material, @layer, @camera, @submeshIndex, @properties, @castShadows);

            return __ret;
        }

        static StackObject* DrawMesh_93(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Matrix4x4 @matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @matrix, @material, @layer, @camera, @submeshIndex, @properties, @castShadows, @receiveShadows);

            return __ret;
        }

        static StackObject* DrawMesh_94(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @probeAnchor = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Matrix4x4 @matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @matrix, @material, @layer, @camera, @submeshIndex, @properties, @castShadows, @receiveShadows, @probeAnchor);

            return __ret;
        }

        static StackObject* DrawMesh_95(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 11);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @useLightProbes = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform @probeAnchor = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Matrix4x4 @matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @matrix, @material, @layer, @camera, @submeshIndex, @properties, @castShadows, @receiveShadows, @probeAnchor, @useLightProbes);

            return __ret;
        }

        static StackObject* DrawMesh_96(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 11);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.LightProbeUsage @lightProbeUsage = (UnityEngine.Rendering.LightProbeUsage)typeof(UnityEngine.Rendering.LightProbeUsage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform @probeAnchor = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Matrix4x4 @matrix = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMesh(@mesh, @matrix, @material, @layer, @camera, @submeshIndex, @properties, @castShadows, @receiveShadows, @probeAnchor, @lightProbeUsage);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_97(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4[] @matrices = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstanced(@mesh, @submeshIndex, @material, @matrices);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_98(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @count = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Matrix4x4[] @matrices = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstanced(@mesh, @submeshIndex, @material, @matrices, @count);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_99(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @count = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Matrix4x4[] @matrices = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstanced(@mesh, @submeshIndex, @material, @matrices, @count, @properties);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_100(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @count = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Matrix4x4[] @matrices = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstanced(@mesh, @submeshIndex, @material, @matrices, @count, @properties, @castShadows);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_101(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @count = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Matrix4x4[] @matrices = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstanced(@mesh, @submeshIndex, @material, @matrices, @count, @properties, @castShadows, @receiveShadows);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_102(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @count = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Matrix4x4[] @matrices = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstanced(@mesh, @submeshIndex, @material, @matrices, @count, @properties, @castShadows, @receiveShadows, @layer);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_103(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @count = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Matrix4x4[] @matrices = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstanced(@mesh, @submeshIndex, @material, @matrices, @count, @properties, @castShadows, @receiveShadows, @layer, @camera);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_104(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 11);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.LightProbeUsage @lightProbeUsage = (UnityEngine.Rendering.LightProbeUsage)typeof(UnityEngine.Rendering.LightProbeUsage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 @count = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Matrix4x4[] @matrices = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstanced(@mesh, @submeshIndex, @material, @matrices, @count, @properties, @castShadows, @receiveShadows, @layer, @camera, @lightProbeUsage);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_105(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> @matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstanced(@mesh, @submeshIndex, @material, @matrices);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_106(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> @matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstanced(@mesh, @submeshIndex, @material, @matrices, @properties);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_107(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> @matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstanced(@mesh, @submeshIndex, @material, @matrices, @properties, @castShadows);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_108(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> @matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstanced(@mesh, @submeshIndex, @material, @matrices, @properties, @castShadows, @receiveShadows);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_109(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> @matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstanced(@mesh, @submeshIndex, @material, @matrices, @properties, @castShadows, @receiveShadows, @layer);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_110(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> @matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstanced(@mesh, @submeshIndex, @material, @matrices, @properties, @castShadows, @receiveShadows, @layer, @camera);

            return __ret;
        }

        static StackObject* DrawMeshInstanced_111(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.LightProbeUsage @lightProbeUsage = (UnityEngine.Rendering.LightProbeUsage)typeof(UnityEngine.Rendering.LightProbeUsage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> @matrices = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstanced(@mesh, @submeshIndex, @material, @matrices, @properties, @castShadows, @receiveShadows, @layer, @camera, @lightProbeUsage);

            return __ret;
        }

        static StackObject* DrawMeshInstancedIndirect_112(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 12);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.LightProbeUsage @lightProbeUsage = (UnityEngine.Rendering.LightProbeUsage)typeof(UnityEngine.Rendering.LightProbeUsage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 @argsOffset = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.ComputeBuffer @bufferWithArgs = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Bounds @bounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 12);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstancedIndirect(@mesh, @submeshIndex, @material, @bounds, @bufferWithArgs, @argsOffset, @properties, @castShadows, @receiveShadows, @layer, @camera, @lightProbeUsage);

            return __ret;
        }

        static StackObject* DrawMeshInstancedIndirect_113(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 12);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.LightProbeUsage @lightProbeUsage = (UnityEngine.Rendering.LightProbeUsage)typeof(UnityEngine.Rendering.LightProbeUsage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Camera @camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @layer = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean @receiveShadows = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rendering.ShadowCastingMode @castShadows = (UnityEngine.Rendering.ShadowCastingMode)typeof(UnityEngine.Rendering.ShadowCastingMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.MaterialPropertyBlock @properties = (UnityEngine.MaterialPropertyBlock)typeof(UnityEngine.MaterialPropertyBlock).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            System.Int32 @argsOffset = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.GraphicsBuffer @bufferWithArgs = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Bounds @bounds = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 11);
            System.Int32 @submeshIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 12);
            UnityEngine.Mesh @mesh = (UnityEngine.Mesh)typeof(UnityEngine.Mesh).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawMeshInstancedIndirect(@mesh, @submeshIndex, @material, @bounds, @bufferWithArgs, @argsOffset, @properties, @castShadows, @receiveShadows, @layer, @camera, @lightProbeUsage);

            return __ret;
        }

        static StackObject* DrawTexture_114(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material @mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Color @color = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @bottomBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @topBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @rightBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Int32 @leftBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Rect @sourceRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Texture @texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawTexture(@screenRect, @texture, @sourceRect, @leftBorder, @rightBorder, @topBorder, @bottomBorder, @color, @mat);

            return __ret;
        }

        static StackObject* DrawTexture_115(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @color = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @bottomBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @topBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @rightBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @leftBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rect @sourceRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Texture @texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawTexture(@screenRect, @texture, @sourceRect, @leftBorder, @rightBorder, @topBorder, @bottomBorder, @color);

            return __ret;
        }

        static StackObject* DrawTexture_116(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material @mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @bottomBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @topBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @rightBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @leftBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rect @sourceRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Texture @texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawTexture(@screenRect, @texture, @sourceRect, @leftBorder, @rightBorder, @topBorder, @bottomBorder, @mat);

            return __ret;
        }

        static StackObject* DrawTexture_117(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @bottomBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @topBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @rightBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @leftBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Rect @sourceRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Texture @texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawTexture(@screenRect, @texture, @sourceRect, @leftBorder, @rightBorder, @topBorder, @bottomBorder);

            return __ret;
        }

        static StackObject* DrawTexture_118(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material @mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @bottomBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @topBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @rightBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Int32 @leftBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Texture @texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawTexture(@screenRect, @texture, @leftBorder, @rightBorder, @topBorder, @bottomBorder, @mat);

            return __ret;
        }

        static StackObject* DrawTexture_119(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @bottomBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @topBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @rightBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @leftBorder = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Texture @texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawTexture(@screenRect, @texture, @leftBorder, @rightBorder, @topBorder, @bottomBorder);

            return __ret;
        }

        static StackObject* DrawTexture_120(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Material @mat = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Texture @texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawTexture(@screenRect, @texture, @mat);

            return __ret;
        }

        static StackObject* DrawTexture_121(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture @texture = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rect @screenRect = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.DrawTexture(@screenRect, @texture);

            return __ret;
        }

        static StackObject* SetRenderTarget_122(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderTexture @rt = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.SetRenderTarget(@rt);

            return __ret;
        }

        static StackObject* SetRenderTarget_123(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @mipLevel = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RenderTexture @rt = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.SetRenderTarget(@rt, @mipLevel);

            return __ret;
        }

        static StackObject* SetRenderTarget_124(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CubemapFace @face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @mipLevel = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RenderTexture @rt = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.SetRenderTarget(@rt, @mipLevel, @face);

            return __ret;
        }

        static StackObject* SetRenderTarget_125(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RenderBuffer @depthBuffer = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RenderBuffer @colorBuffer = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.SetRenderTarget(@colorBuffer, @depthBuffer);

            return __ret;
        }

        static StackObject* SetRenderTarget_126(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @mipLevel = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RenderBuffer @depthBuffer = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RenderBuffer @colorBuffer = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.SetRenderTarget(@colorBuffer, @depthBuffer, @mipLevel);

            return __ret;
        }

        static StackObject* SetRenderTarget_127(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CubemapFace @face = (UnityEngine.CubemapFace)typeof(UnityEngine.CubemapFace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @mipLevel = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.RenderBuffer @depthBuffer = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.RenderBuffer @colorBuffer = (UnityEngine.RenderBuffer)typeof(UnityEngine.RenderBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Graphics.SetRenderTarget(@colorBuffer, @depthBuffer, @mipLevel, @face);

            return __ret;
        }

        static StackObject* SetRandomWriteTarget_128(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ComputeBuffer @uav = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @index = ptr_of_this_method->Value;


            UnityEngine.Graphics.SetRandomWriteTarget(@index, @uav);

            return __ret;
        }

        static StackObject* SetRandomWriteTarget_129(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GraphicsBuffer @uav = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @index = ptr_of_this_method->Value;


            UnityEngine.Graphics.SetRandomWriteTarget(@index, @uav);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Graphics();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

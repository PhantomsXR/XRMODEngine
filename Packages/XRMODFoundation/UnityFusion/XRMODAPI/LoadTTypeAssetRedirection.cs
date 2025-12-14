// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODAPI.UnityFusion.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using Phantom.XRMOD.XRMODAPI.Runtime;
using Phantom.XRMOD.XRMODPackageTools.Runtime;
using UnityFusion.CLR.Method;
using UnityFusion.CLR.Utils;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using UnityFusion.Runtime.Stack;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Rendering.Universal;
using UnityEngine.U2D;
using UnityEngine.Video;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif

namespace UnityFusion.Runtime.Generated
{
    public class LoadTTypeAssetRedirection
    {
        public unsafe void Register(AppDomain _appDomain)
        {
            Type tmp_APIType = typeof(API);

            var tmp_BindingFlags = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                   BindingFlags.DeclaredOnly;

            var tmp_Args = new Type[] {typeof(System.String)};
            var tmp_LoadAssetAsync =
                tmp_APIType.GetMethod("LoadAssetAsync", tmp_BindingFlags, null, tmp_Args, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_LoadAssetAsync, LoadAssetOfTypeAsync);


            var tmp_LoadAssetsAsync =
                tmp_APIType.GetMethod("LoadAssetsAsync", tmp_BindingFlags, null, new Type[] { }, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_LoadAssetsAsync, LoadAllAssetOfTypeAsync);


            var tmp_LoadAssetsAsyncBatchArgs = new Type[] {typeof(System.String[])};
            var tmp_LoadAssetsAsyncBatch =
                tmp_APIType.GetMethod("LoadAssetsAsync", tmp_BindingFlags, null,
                    tmp_LoadAssetsAsyncBatchArgs, null);
            _appDomain.RegisterCLRMethodRedirection(tmp_LoadAssetsAsyncBatch, LoadAssetsAsyncBatch);
        }

        private unsafe StackObject* LoadAssetsAsyncBatch(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String[] @_assetNames =
                (System.String[]) typeof(System.String[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method,
                    __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);


            var tmp_GenericArgument = __method.GenericArguments;
            if (tmp_GenericArgument == null || tmp_GenericArgument.Length != 1) return __esp;
            var tmp_Type = tmp_GenericArgument[0];


            switch (tmp_Type.TypeForCLR)
            {
                case { } tmp_TType when tmp_TType == typeof(GameObject):
                    return LoadAssetsAsyncBatch<GameObject>(instance_of_this_method, __mStack, __ret, _assetNames);
                case { } tmp_TType when tmp_TType == typeof(Texture2D):
                    return LoadAssetsAsyncBatch<Texture2D>(instance_of_this_method, __mStack, __ret, _assetNames);
                case { } tmp_TType when tmp_TType == typeof(Material):
                    return LoadAssetsAsyncBatch<Material>(instance_of_this_method, __mStack, __ret, _assetNames);
                case { } tmp_TType when tmp_TType == typeof(VideoClip):
                    return LoadAssetsAsyncBatch<VideoClip>(instance_of_this_method, __mStack, __ret, _assetNames);
                case { } tmp_TType when tmp_TType == typeof(AudioClip):
                    return LoadAssetsAsyncBatch<AudioClip>(instance_of_this_method, __mStack, __ret, _assetNames);
                case { } tmp_TType when tmp_TType == typeof(Animation):
                    return LoadAssetsAsyncBatch<Animation>(instance_of_this_method, __mStack, __ret, _assetNames);
                case { } tmp_TType when tmp_TType == typeof(Sprite):
                    return LoadAssetsAsyncBatch<Sprite>(instance_of_this_method, __mStack, __ret, _assetNames);
                case { } tmp_TType when tmp_TType == typeof(SpriteAtlas):
                    return LoadAssetsAsyncBatch<SpriteAtlas>(instance_of_this_method, __mStack, __ret, _assetNames);
                case { } tmp_TType when tmp_TType == typeof(Font):
                    return LoadAssetsAsyncBatch<Font>(instance_of_this_method, __mStack, __ret, _assetNames);
                case { } tmp_TType when tmp_TType == typeof(TextAsset):
                    return LoadAssetsAsyncBatch<TextAsset>(instance_of_this_method, __mStack, __ret, _assetNames);
                case { } tmp_TType when tmp_TType == typeof(Shader):
                    return LoadAssetsAsyncBatch<Shader>(instance_of_this_method, __mStack, __ret, _assetNames);
#if UNITY_6000_0_OR_NEWER
                case { } tmp_TType when tmp_TType == typeof(PhysicsMaterial):
                    return LoadAssetsAsyncBatch<PhysicsMaterial>(instance_of_this_method, __mStack, __ret, _assetNames);
#else
                case { } tmp_TType when tmp_TType == typeof(PhysicMaterial):
                    return LoadAssetsAsyncBatch<PhysicMaterial>(instance_of_this_method, __mStack, __ret, _assetNames);
#endif

                case { } tmp_TType when tmp_TType == typeof(Mesh):
                    return LoadAssetsAsyncBatch<Mesh>(instance_of_this_method, __mStack, __ret, _assetNames);
                case { } tmp_TType when tmp_TType == typeof(ComputeShader):
                    return LoadAssetsAsyncBatch<ComputeShader>(instance_of_this_method, __mStack, __ret, _assetNames);
                case { } tmp_TType when tmp_TType.IsSubclassOf(typeof(ScriptableObject)) ||
                                        tmp_TType == typeof(ScriptableObject):
                    return LoadAssetsAsyncBatch<ScriptableObject>(instance_of_this_method, __mStack, __ret,
                        _assetNames);
                case { } tmp_TType when tmp_TType == typeof(AudioMixer):
                    return LoadAssetsAsyncBatch<AudioMixer>(instance_of_this_method, __mStack, __ret,
                        _assetNames);
                case { } tmp_TType when tmp_TType == typeof(ShaderVariantCollection):
                    return LoadAssetsAsyncBatch<ShaderVariantCollection>(instance_of_this_method, __mStack, __ret,
                        _assetNames);
            }

            return __ret;
        }

        private unsafe StackObject* LoadAllAssetOfTypeAsync(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);


            var tmp_GenericArgument = __method.GenericArguments;

            if (tmp_GenericArgument == null || tmp_GenericArgument.Length != 1) return __esp;
            var tmp_Type = tmp_GenericArgument[0];


            switch (tmp_Type.TypeForCLR)
            {
                case { } tmp_TType when tmp_TType == typeof(GameObject):
                    return LoadAssetsAsync<GameObject>(instance_of_this_method, __mStack, __ret);
                case { } tmp_TType when tmp_TType == typeof(Texture2D):
                    return LoadAssetsAsync<Texture2D>(instance_of_this_method, __mStack, __ret);
                case { } tmp_TType when tmp_TType == typeof(Material):
                    return LoadAssetsAsync<Material>(instance_of_this_method, __mStack, __ret);
                case { } tmp_TType when tmp_TType == typeof(VideoClip):
                    return LoadAssetsAsync<VideoClip>(instance_of_this_method, __mStack, __ret);
                case { } tmp_TType when tmp_TType == typeof(AudioClip):
                    return LoadAssetsAsync<AudioClip>(instance_of_this_method, __mStack, __ret);
                case { } tmp_TType when tmp_TType == typeof(Animation):
                    return LoadAssetsAsync<Animation>(instance_of_this_method, __mStack, __ret);
                case { } tmp_TType when tmp_TType == typeof(Sprite):
                    return LoadAssetsAsync<Sprite>(instance_of_this_method, __mStack, __ret);
                case { } tmp_TType when tmp_TType == typeof(SpriteAtlas):
                    return LoadAssetsAsync<SpriteAtlas>(instance_of_this_method, __mStack, __ret);
                case { } tmp_TType when tmp_TType == typeof(Font):
                    return LoadAssetsAsync<Font>(instance_of_this_method, __mStack, __ret);
                case { } tmp_TType when tmp_TType == typeof(TextAsset):
                    return LoadAssetsAsync<TextAsset>(instance_of_this_method, __mStack, __ret);
                case { } tmp_TType when tmp_TType == typeof(Shader):
                    return LoadAssetsAsync<Shader>(instance_of_this_method, __mStack, __ret);
#if UNITY_6000_0_OR_NEWER
                case { } tmp_TType when tmp_TType == typeof(PhysicsMaterial):
                    return LoadAssetsAsync<PhysicsMaterial>(instance_of_this_method, __mStack, __ret);
#else
                case { } tmp_TType when tmp_TType == typeof(PhysicMaterial):
                    return LoadAssetsAsync<PhysicMaterial>(instance_of_this_method, __mStack, __ret);
#endif
                case { } tmp_TType when tmp_TType == typeof(Mesh):
                    return LoadAssetsAsync<Mesh>(instance_of_this_method, __mStack, __ret);
                case { } tmp_TType when tmp_TType == typeof(ComputeShader):
                    return LoadAssetsAsync<ComputeShader>(instance_of_this_method, __mStack, __ret);
                case { } tmp_TType when tmp_TType == typeof(ScriptableObject):
                    return LoadAssetsAsync<ScriptableObject>(instance_of_this_method, __mStack, __ret);
                case { } tmp_TType when tmp_TType == typeof(AudioMixer):
                    return LoadAssetsAsync<AudioMixer>(instance_of_this_method, __mStack, __ret);
                case { } tmp_TType when tmp_TType == typeof(ShaderVariantCollection):
                    return LoadAssetsAsync<ShaderVariantCollection>(instance_of_this_method, __mStack, __ret);
            }

            return __ret;
        }

        private unsafe StackObject* LoadAssetOfTypeAsync(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_wannaLoadAssetName =
                (System.String) typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method,
                    __domain,
                    __mStack));
            __intp.Free(ptr_of_this_method);


            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method =
                (Phantom.XRMOD.XRMODAPI.Runtime.API) typeof(Phantom.XRMOD.XRMODAPI.Runtime.API).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            var tmp_GenericArgument = __method.GenericArguments;

            if (tmp_GenericArgument == null || tmp_GenericArgument.Length != 1) return __esp;
            var tmp_Type = tmp_GenericArgument[0];

            switch (tmp_Type.TypeForCLR)
            {
                case { } tmp_TType when tmp_TType == typeof(GameObject):
                    return LoadAssetAsync<GameObject>(@instance_of_this_method, @_wannaLoadAssetName, @__mStack,
                        @__ret);
                case { } tmp_TType when tmp_TType == typeof(Texture2D):
                    return LoadAssetAsync<Texture2D>(@instance_of_this_method, @_wannaLoadAssetName, @__mStack, @__ret);
                case { } tmp_TType when tmp_TType == typeof(Material):
                    return LoadAssetAsync<Material>(@instance_of_this_method, @_wannaLoadAssetName, @__mStack, @__ret);
                case { } tmp_TType when tmp_TType == typeof(VideoClip):
                    return LoadAssetAsync<VideoClip>(@instance_of_this_method, @_wannaLoadAssetName, @__mStack, @__ret);
                case { } tmp_TType when tmp_TType == typeof(AudioClip):
                    return LoadAssetAsync<AudioClip>(@instance_of_this_method, @_wannaLoadAssetName, @__mStack, @__ret);
                case { } tmp_TType when tmp_TType == typeof(Animation):
                    return LoadAssetAsync<Animation>(@instance_of_this_method, @_wannaLoadAssetName, @__mStack, @__ret);
                case { } tmp_TType when tmp_TType == typeof(Sprite):
                    return LoadAssetAsync<Sprite>(@instance_of_this_method, @_wannaLoadAssetName, @__mStack, @__ret);
                case { } tmp_TType when tmp_TType == typeof(SpriteAtlas):
                    return LoadAssetAsync<SpriteAtlas>(@instance_of_this_method, @_wannaLoadAssetName, @__mStack,
                        @__ret);
                case { } tmp_TType when tmp_TType == typeof(Font):
                    return LoadAssetAsync<Font>(@instance_of_this_method, @_wannaLoadAssetName, @__mStack, @__ret);
                case { } tmp_TType when tmp_TType == typeof(TextAsset):
                    return LoadAssetAsync<TextAsset>(@instance_of_this_method, @_wannaLoadAssetName, @__mStack, @__ret);
                case { } tmp_TType when tmp_TType == typeof(Shader):
                    return LoadAssetAsync<Shader>(@instance_of_this_method, @_wannaLoadAssetName, @__mStack, @__ret);
#if UNITY_6000_0_OR_NEWER
                case { } tmp_TType when tmp_TType == typeof(PhysicsMaterial):
                    return LoadAssetAsync<PhysicsMaterial>(@instance_of_this_method, @_wannaLoadAssetName, @__mStack,
                        @__ret);
#else
                 case { } tmp_TType when tmp_TType == typeof(PhysicMaterial):
                    return LoadAssetAsync<PhysicMaterial>(@instance_of_this_method, @_wannaLoadAssetName, @__mStack,
                        @__ret);
#endif
                case { } tmp_TType when tmp_TType == typeof(Mesh):
                    return LoadAssetAsync<Mesh>(@instance_of_this_method, @_wannaLoadAssetName, @__mStack, @__ret);
                case { } tmp_TType when tmp_TType == typeof(ComputeShader):
                    return LoadAssetAsync<ComputeShader>(@instance_of_this_method, @_wannaLoadAssetName, @__mStack,
                        @__ret);
                case { } tmp_TType when tmp_TType == typeof(UniversalRenderPipelineAsset):
                    return LoadAssetAsync<UniversalRenderPipelineAsset>(@instance_of_this_method, @_wannaLoadAssetName,
                        @__mStack,
                        @__ret);
                case { } tmp_TType when tmp_TType == typeof(ScriptableObject):
                    return LoadAssetAsync<ScriptableObject>(@instance_of_this_method, @_wannaLoadAssetName, @__mStack,
                        @__ret);
                case { } tmp_TType when tmp_TType == typeof(AudioMixer):
                    return LoadAssetAsync<AudioMixer>(@instance_of_this_method, @_wannaLoadAssetName, @__mStack,
                        @__ret);
                case { } tmp_TType when tmp_TType == typeof(ShaderVariantCollection):
                    return LoadAssetAsync<ShaderVariantCollection>(@instance_of_this_method, @_wannaLoadAssetName,
                        @__mStack,
                        @__ret);
            }

            return __ret;
        }

        private unsafe StackObject* LoadAssetAsync<T>(Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method,
            string _wannaLoadAssetName, AutoList __mStack, StackObject* __ret) where T : UnityEngine.Object
        {
            var tmp_ResultOfThisMethod = instance_of_this_method.LoadAssetAsync<T>(_wannaLoadAssetName);
            object tmp_ObjResultOfThisMethod = tmp_ResultOfThisMethod;
            if (tmp_ObjResultOfThisMethod is CrossBindingAdaptorType tmp_AdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack, tmp_AdaptorType.ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, tmp_ResultOfThisMethod);
        }


        private unsafe StackObject* LoadAssetsAsync<T>(Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method,
            AutoList __mStack, StackObject* __ret) where T : UnityEngine.Object
        {
            var tmp_ResultOfThisMethod = instance_of_this_method.LoadAssetsAsync<T>();
            object tmp_ObjResultOfThisMethod = tmp_ResultOfThisMethod;
            if (tmp_ObjResultOfThisMethod is CrossBindingAdaptorType tmp_AdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack, tmp_AdaptorType.ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, tmp_ResultOfThisMethod);
        }

        private unsafe StackObject* LoadAssetsAsyncBatch<T>(Phantom.XRMOD.XRMODAPI.Runtime.API instance_of_this_method,
            AutoList __mStack, StackObject* __ret, string[] _assetNames) where T : UnityEngine.Object
        {
            var tmp_ResultOfThisMethod = instance_of_this_method.LoadAssetsAsync<T>(_assetNames);
            object tmp_ObjResultOfThisMethod = tmp_ResultOfThisMethod;
            if (tmp_ObjResultOfThisMethod is CrossBindingAdaptorType tmp_AdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack, tmp_AdaptorType.ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, tmp_ResultOfThisMethod);
        }
    }
}
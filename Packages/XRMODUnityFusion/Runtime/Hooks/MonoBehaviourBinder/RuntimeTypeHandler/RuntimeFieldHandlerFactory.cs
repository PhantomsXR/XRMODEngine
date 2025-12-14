// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Runtime.CodeHook.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.U2D;
using UnityEngine.Video;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    public class RuntimeFieldHandlerFactory
    {
        private readonly Dictionary<MonoField.FieldTypeEnum, IRuntimeTypeHandler> handlers;

        private readonly Dictionary<string, IRuntimeAssetTypeHandler> assetReferencesHandler;

        public RuntimeFieldHandlerFactory(IAssetProvider _assetProvider)
        {
            assetReferencesHandler = new()
            {
                {typeof(Texture2D).FullName, new Texture2DsHandler()},
                {typeof(AudioClip).FullName, new AudioClipsHandler()},
                {typeof(Shader).FullName, new ShadersHandler()},
                {typeof(Sprite).FullName, new SpritesHandler()},
                {typeof(Material).FullName, new MaterialsHandler()},
                {typeof(Mesh).FullName, new MeshesHandler()},
                {typeof(VideoClip).FullName, new VideoClipsHandler()},
                {typeof(AnimationClip).FullName, new AnimationClipsHandler()},
                {typeof(ScriptableObject).FullName, new ScriptableObjectsHandler()},
                {typeof(TextAsset).FullName, new TextAssetsHandler()},
                {typeof(RenderTexture).FullName, new RenderTexturesHandler()},
                {typeof(AudioMixer).FullName, new AudioMixersHandler()},
                {typeof(Cubemap).FullName, new CubemapsHandler()},
                {typeof(SpriteAtlas).FullName, new SpriteAtlasesHandler()},
                {typeof(ComputeShader).FullName, new ComputeShadersHandler()},
#if UNITY_6000_0_OR_NEWER
                {typeof(PhysicsMaterial).FullName, new PhysicsMaterialsHandler()},
#else
                {typeof(PhysicMaterial).FullName, new PhysicsMaterialsHandler()},
#endif
                {typeof(PhysicsMaterial2D).FullName, new PhysicsMaterial2DsHandler()},
                {typeof(GameObject).FullName, new GameObjectRefHandler()}
            };
            var tmp_AssetReferenceHandler = new AssetReferenceHandler(_assetProvider, assetReferencesHandler);
            var tmp_AssetReferenceArrayHandler = new AssetReferenceArrayHandler(_assetProvider, assetReferencesHandler);

            handlers = new Dictionary<MonoField.FieldTypeEnum, IRuntimeTypeHandler>()
            {
                {MonoField.FieldTypeEnum.Number, new NumberHandler()},
                {MonoField.FieldTypeEnum.String, new StringHandler()},
                {MonoField.FieldTypeEnum.Bool, new BoolHandler()},
                {MonoField.FieldTypeEnum.GameObject, new GameObjectHandler()},
                {MonoField.FieldTypeEnum.UnityComponent, new ComponentHandler()},
                {MonoField.FieldTypeEnum.Enum, new EnumHandler()},
                {MonoField.FieldTypeEnum.Vector2, new Vector2Handler()},
                {MonoField.FieldTypeEnum.Vector3, new Vector3Handler()},
                {MonoField.FieldTypeEnum.Vector4, new Vector4Handler()},
                {MonoField.FieldTypeEnum.Quaternion, new QuaternionHandler()},
                {MonoField.FieldTypeEnum.Color, new ColorHandler()},
                {MonoField.FieldTypeEnum.LayerMask, new LayerMaskHandler()},
                {MonoField.FieldTypeEnum.Primitives, new PrimitivesHandler()},
                {MonoField.FieldTypeEnum.AnimationCurve, new AnimationCurveHandler()},
                {MonoField.FieldTypeEnum.AnimationCurveArray, new AnimationCurvesHandler()},
                {MonoField.FieldTypeEnum.Components, new ComponentsHandler()},
                {MonoField.FieldTypeEnum.GameObjectArray, new GameObjectsHandler()},
                {MonoField.FieldTypeEnum.Vector2Array, new Vector2sHandler()},
                {MonoField.FieldTypeEnum.Vector3Array, new Vector3sHandler()},
                {MonoField.FieldTypeEnum.Vector4Array, new Vector4sHandler()},
                {MonoField.FieldTypeEnum.QuaternionArray, new QuaternionsHandler()},
                {MonoField.FieldTypeEnum.DataProperty, new DataPropertyHandler()},
                {MonoField.FieldTypeEnum.ColorArray, new ColorsHandler()}, 
                {MonoField.FieldTypeEnum.AssetReferenceArray, tmp_AssetReferenceArrayHandler},
                {MonoField.FieldTypeEnum.AssetReference, tmp_AssetReferenceHandler},
            };
        }

        public IRuntimeTypeHandler Get(MonoField.FieldTypeEnum _type)
        {
            return handlers.TryGetValue(_type, out IRuntimeTypeHandler tmp_Handler)
                ? tmp_Handler
                : new UnSupportHandler();
        }
    }
}
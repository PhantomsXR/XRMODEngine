// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Editor.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Core.Runtime.Attribute;
using Phantom.XRMOD.UnityFusion.Runtime;
using Phantom.XRMOD.UnityFusion.Runtime.CodeHook;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.U2D;
using UnityEngine.UI;
using UnityEngine.Video;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.Runtime.Editor
{
    public interface IEditorTypeHandler
    {
        bool CanHandle(Type _type);
        MonoField.FieldTypeEnum GetFieldType(Type _type);
        void ProcessValue(MonoField _field, object _value);
    }

    #region DataProperty

    public class DataPropertyHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type)
        {
            var tmp_Fields = SharedData.TARGET_MONO.GetType()
                .GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (var tmp_Field in tmp_Fields)
            {
                if (!tmp_Field.IsPublic)
                {
                    bool tmp_HasSerializeFieldAttribute = tmp_Field.IsDefined(typeof(SerializeField), true);
                    var tmp_DontConvertAttribute = tmp_Field.IsDefined(typeof(DontConvertToMonoBinderAttribute), true);
                    if (!tmp_HasSerializeFieldAttribute || tmp_DontConvertAttribute)
                    {
                        continue;
                    }
                }

                bool tmp_DataPropertyAttribute = false;
                tmp_DataPropertyAttribute = tmp_Field.IsDefined(typeof(DataPropertyAttribute), true);
                if (tmp_DataPropertyAttribute)
                {
                    return true;
                }
            }

            return false;
        }

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.DataProperty;

        public void ProcessValue(MonoField _field, object _value)
        {
            var tmp_Settings = new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            };
            _field.Value = JsonConvert.SerializeObject(_value, tmp_Settings);
        }
    }

    #endregion

    #region UnityTypes

    public class Vector3Handler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(Vector3);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.Vector3;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = ((Vector3) _value).Serializer();
        }
    }

    public class Vector2Handler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(Vector2);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.Vector2;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = ((Vector2) _value).Serializer();
        }
    }

    public class Vector4Handler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(Vector4);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.Vector4;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = ((Vector4) _value).Serializer();
        }
    }

    public class QuaternionHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(Quaternion);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.Quaternion;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = ((Quaternion) _value).Serializer();
        }
    }

    public class ColorHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(Color);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.Color;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = ((Color) _value).Serializer();
        }
    }

    public class AnimationCurveHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(AnimationCurve);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AnimationCurve;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = ((AnimationCurve) _value).SerializeAnimationCurve();
        }
    }

    public class LayerMaskHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(LayerMask);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.LayerMask;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = string.Join(",", Utilities.GetLayerNamesFromMask((LayerMask) _value));
        }
    }

    public class NumberHandler : IEditorTypeHandler
    {
        private readonly Type[] numberTypeCollection = new[]
        {
            typeof(byte), typeof(sbyte), typeof(short), typeof(ushort), typeof(int), typeof(uint),
            typeof(long), typeof(ulong), typeof(float), typeof(decimal), typeof(double)
        };


        public bool CanHandle(Type _type) => numberTypeCollection.Contains(_type);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.Number;

        public void ProcessValue(MonoField _field, object _value)
        {
            if (_value == null) return;
            _field.Value = _value.ToString();
        }
    }

    public class StringHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(string);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.String;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = _value.ToString();
        }
    }

    public class BoolHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(bool);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.Bool;

        public void ProcessValue(MonoField _field, object _value)
        {
            if (_value.ToString().ToLower().Equals("null")) return;
            _field.Value = _value.ToString();
        }
    }

    public class EnumHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type.IsEnum;

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.Enum;

        public void ProcessValue(MonoField _field, object _value)
        {
            var tmp_UnderlyingType = _value.GetType().GetEnumUnderlyingType();
            _field.Value = tmp_UnderlyingType == typeof(byte) ? $"{(byte) _value}" : $"{(int) _value}";
        }
    }

    public class GameObjectHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(GameObject);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.GameObject;

        public void ProcessValue(MonoField _field, object _value)
        {
            // Asset reference
            if (_value is GameObject tmp_Value)
            {
                if (EditorTypeHandlerUtility.AddAssetToPackageTools(tmp_Value))
                {
                    _field.Value = tmp_Value.name;
                    _field.FieldType = MonoField.FieldTypeEnum.AssetReference;
                    _field.AssetType = typeof(GameObject).ToString();
                    return;
                }
            }

            _field.GameObject = _value as GameObject;
        }
    }

    #endregion

    #region Component

    public class ComponentHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type)
        {
            return _type.IsSubclassOf(typeof(Component)) || _type == typeof(Component) ||
                   _type.IsSubclassOf(typeof(MonoBehaviour));
        }

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.UnityComponent;

        public void ProcessValue(MonoField _field, object _value)
        {
            if (_value is Component tmp_CmpValue && tmp_CmpValue != null)
                _field.GameObject = tmp_CmpValue.gameObject;
            else
                _field.GameObject = null;
        }
    }

    #endregion

    #region Asset reference

    public class Texture2DHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(Texture2D);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReference;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = ((Texture2D) _value).name;
            _field.AssetType = typeof(Texture2D).ToString();
            EditorTypeHandlerUtility.AddAssetToPackageTools((Texture2D) _value);
        }
    }

    public class SpriteHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(Sprite);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReference;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = ((Sprite) _value).name;
            _field.AssetType = typeof(Sprite).ToString();
            EditorTypeHandlerUtility.AddAssetToPackageTools((Sprite) _value);
        }
    }

    public class TextureHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(Texture);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReference;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = ((Texture) _value).name;
            _field.AssetType = typeof(Texture).ToString();
            EditorTypeHandlerUtility.AddAssetToPackageTools((Texture) _value);
        }
    }

    public class TextAssetHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(TextAsset);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReference;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = ((TextAsset) _value).name;
            _field.AssetType = typeof(TextAsset).ToString();
            EditorTypeHandlerUtility.AddAssetToPackageTools((TextAsset) _value);
        }
    }

    public class SpriteAtlasHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(SpriteAtlas);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReference;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = ((SpriteAtlas) _value).name;
            _field.AssetType = typeof(SpriteAtlas).ToString();
            EditorTypeHandlerUtility.AddAssetToPackageTools((SpriteAtlas) _value);
        }
    }

    public class VideoClipHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(VideoClip);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReference;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = ((VideoClip) _value).name;
            _field.AssetType = typeof(VideoClip).ToString();
            EditorTypeHandlerUtility.AddAssetToPackageTools((VideoClip) _value);
        }
    }

    public class AudioClipHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(AudioClip);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReference;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = ((AudioClip) _value).name;
            _field.AssetType = typeof(AudioClip).ToString();
            EditorTypeHandlerUtility.AddAssetToPackageTools((AudioClip) _value);
        }
    }

    public class AnimationClipHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(AnimationClip);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReference;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = ((AnimationClip) _value).name;
            _field.AssetType = typeof(AnimationClip).ToString();
            EditorTypeHandlerUtility.AddAssetToPackageTools((AnimationClip) _value);
        }
    }

    public class AudioMixerHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(AudioMixer);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReference;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = ((AudioMixer) _value).name;
            _field.AssetType = typeof(AudioMixer).ToString();
            EditorTypeHandlerUtility.AddAssetToPackageTools((AudioMixer) _value);
        }
    }

    public class AudioMixerSnapshotHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(AudioMixerSnapshot);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AudioMixerSnapshot;

        public void ProcessValue(MonoField _field, object _value)
        {
            var tmp_Snapshot = (AudioMixerSnapshot) _value;
            if (tmp_Snapshot)
                _field.Value = tmp_Snapshot.name;
            _field.AssetType = typeof(AudioMixerSnapshot).ToString();
        }
    }

    public class MaterialHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(Material);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReference;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = ((Material) _value).name;
            _field.AssetType = typeof(Material).ToString();
            EditorTypeHandlerUtility.AddAssetToPackageTools((Material) _value);
        }
    }

    public class FontHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(Font);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReference;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = ((Font) _value).name;
            _field.AssetType = typeof(Font).ToString();
            EditorTypeHandlerUtility.AddAssetToPackageTools((Font) _value);
        }
    }

    public class MeshHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(Mesh);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReference;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = ((Mesh) _value).name;
            _field.AssetType = typeof(Mesh).ToString();
            EditorTypeHandlerUtility.AddAssetToPackageTools((Mesh) _value);
        }
    }

    public class ComputeShaderHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(ComputeShader);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReference;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = ((ComputeShader) _value).name;
            _field.AssetType = typeof(ComputeShader).ToString();
            EditorTypeHandlerUtility.AddAssetToPackageTools((ComputeShader) _value);
        }
    }

    public class ShaderHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(Shader);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReference;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = ((Shader) _value).name;
            _field.AssetType = typeof(Shader).ToString();
            EditorTypeHandlerUtility.AddAssetToPackageTools((Shader) _value);
        }
    }

    public class ScriptableObjectHandler : IEditorTypeHandler
    {
        public bool CanHandle(Type _type) => _type == typeof(ScriptableObject);

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReference;

        public void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = ((ScriptableObject) _value).name;
            EditorTypeHandlerUtility.AddAssetToPackageTools((ScriptableObject) _value);
        }
    }

    public class MeshesHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(Mesh);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReferenceArray;


        public override void ProcessValue(MonoField _field, object _value)
        {
            EditorTypeHandlerUtility.SetAssetReferenceArrayField(_value, _field, typeof(Mesh));
        }
    }

    public class VideoClipsHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(VideoClip);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReferenceArray;


        public override void ProcessValue(MonoField _field, object _value)
        {
            EditorTypeHandlerUtility.SetAssetReferenceArrayField(_value, _field, typeof(VideoClip));
        }
    }

    public class AnimationClipsHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(AnimationClip);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReferenceArray;


        public override void ProcessValue(MonoField _field, object _value)
        {
            EditorTypeHandlerUtility.SetAssetReferenceArrayField(_value, _field, typeof(AnimationClip));
        }
    }

    public class ScriptableObjectsHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(ScriptableObject);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) =>
            MonoField.FieldTypeEnum.AssetReferenceArray;


        public override void ProcessValue(MonoField _field, object _value)
        {
            EditorTypeHandlerUtility.SetAssetReferenceArrayField(_value, _field, typeof(ScriptableObject));
        }
    }

    public class Texture2DsHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(Texture2D);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReferenceArray;


        public override void ProcessValue(MonoField _field, object _value)
        {
            EditorTypeHandlerUtility.SetAssetReferenceArrayField(_value, _field, typeof(Texture2D));
        }
    }

    public class AudioClipsHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(AudioClip);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReferenceArray;


        public override void ProcessValue(MonoField _field, object _value)
        {
            EditorTypeHandlerUtility.SetAssetReferenceArrayField(_value, _field, typeof(AudioClip));
        }
    }

    public class ShadersHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(Shader);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReferenceArray;


        public override void ProcessValue(MonoField _field, object _value)
        {
            EditorTypeHandlerUtility.SetAssetReferenceArrayField(_value, _field, typeof(Shader));
        }
    }

    public class SpritesHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(Sprite);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReferenceArray;


        public override void ProcessValue(MonoField _field, object _value)
        {
            EditorTypeHandlerUtility.SetAssetReferenceArrayField(_value, _field, typeof(Sprite));
        }
    }

    public class MaterialsHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(Material);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReferenceArray;


        public override void ProcessValue(MonoField _field, object _value)
        {
            EditorTypeHandlerUtility.SetAssetReferenceArrayField(_value, _field, typeof(Material));
        }
    }

    public class AudioMixersHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(AudioMixer);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AssetReferenceArray;


        public override void ProcessValue(MonoField _field, object _value)
        {
            EditorTypeHandlerUtility.SetAssetReferenceArrayField(_value, _field, typeof(AudioMixer));
        }
    }

    #endregion

    #region Array

    public abstract class ArrayHandler : IEditorTypeHandler
    {
        protected Type elementType;

        public bool CanHandle(Type _type)
        {
            if (!_type.IsArray && !typeof(IList).IsAssignableFrom(_type)) return false;
            elementType = _type.GetElementType() ?? _type.GetGenericArguments()[0];
            return CanHandleArrayType(elementType);
        }

        protected abstract bool CanHandleArrayType(Type _type);

        public abstract MonoField.FieldTypeEnum GetFieldType(Type _type);

        public abstract void ProcessValue(MonoField _field, object _value);
    }

    public class ComponentsHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type.IsSubclassOf(typeof(MonoBehaviour)) || _type.IsSubclassOf(typeof(Component));
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.Components;

        public override void ProcessValue(MonoField _field, object _value)
        {
            GameObject[] tmp_ComponentAttached;
            // Fix issues-89
            if (_value.GetType().IsGenericType)
            {
                var tmp_ComponentArray = _value as IList;
                if (tmp_ComponentArray == null) return;

                tmp_ComponentAttached = new GameObject[tmp_ComponentArray.Count];
                int tmp_Idx = 0;
                foreach (object tmp_Obj in tmp_ComponentArray)
                {
                    tmp_ComponentAttached[tmp_Idx] = tmp_Obj.GetGameObject();
                    tmp_Idx++;
                }
            }
            else
            {
                var tmp_ComponentArray = _value as Component[];
                if (tmp_ComponentArray == null) return;
                tmp_ComponentAttached = tmp_ComponentArray
                    .Select(_component => _component.gameObject).ToArray();
            }

            _field.Components = tmp_ComponentAttached;
        }
    }

    public class GameObjectsHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(GameObject);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.GameObjectArray;

        public override void ProcessValue(MonoField _field, object _value)
        {
            // Asset references
            if (EditorTypeHandlerUtility.SetAssetReferenceArrayField(_value, _field, typeof(GameObject)))
                return;


            GameObject[] tmp_ComponentAttached;
            // Fix issues-89
            if (_value.GetType().IsGenericType)
            {
                var tmp_ComponentArray = _value as IList;
                if (tmp_ComponentArray == null) return;

                tmp_ComponentAttached = new GameObject[tmp_ComponentArray.Count];
                int tmp_Idx = 0;
                foreach (object tmp_Obj in tmp_ComponentArray)
                {
                    tmp_ComponentAttached[tmp_Idx] = tmp_Obj.GetGameObject();
                    tmp_Idx++;
                }
            }
            else
            {
                var tmp_ComponentArray = _value as GameObject[];
                if (tmp_ComponentArray == null) return;
                tmp_ComponentAttached = tmp_ComponentArray;
            }

            _field.GameObjectArray = tmp_ComponentAttached;
        }
    }

    public class StringsHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(string);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.Primitives;


        public override void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = EditorTypeHandlerUtility.MakePrimitiveGenericData<string>(_value);
        }
    }

    public class IntsHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(int);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.Primitives;


        public override void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = EditorTypeHandlerUtility.MakePrimitiveGenericData<int>(_value);
        }
    }

    public class FloatsHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(float);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.Primitives;


        public override void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = EditorTypeHandlerUtility.MakePrimitiveGenericData<float>(_value);
        }
    }

    public class LongsHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(long);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.Primitives;


        public override void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = EditorTypeHandlerUtility.MakePrimitiveGenericData<long>(_value);
        }
    }

    public class ShortsHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(short);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.Primitives;


        public override void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = EditorTypeHandlerUtility.MakePrimitiveGenericData<short>(_value);
        }
    }

    public class BooleansHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(bool);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.Primitives;


        public override void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = EditorTypeHandlerUtility.MakePrimitiveGenericData<bool>(_value);
        }
    }

    public class BytesHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(byte);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.Primitives;


        public override void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = EditorTypeHandlerUtility.MakePrimitiveGenericData<byte>(_value);
        }
    }

    public class UShortsHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(ushort);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.Primitives;


        public override void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = EditorTypeHandlerUtility.MakePrimitiveGenericData<ushort>(_value);
        }
    }

    public class ULongsHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(ulong);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.Primitives;


        public override void ProcessValue(MonoField _field, object _value)
        {
            _field.Value = EditorTypeHandlerUtility.MakePrimitiveGenericData<ulong>(_value);
        }
    }

    public class ColorsHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(Color);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.ColorArray;


        public override void ProcessValue(MonoField _field, object _value)
        {
            _field.ColorArray = _value as Color[];
        }
    }

    public class AnimationCurvesHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(AnimationCurve);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.AnimationCurveArray;


        public override void ProcessValue(MonoField _field, object _value)
        {
            _field.AnimationCurveArray = _value as AnimationCurve[];
        }
    }

    public class Vector2sHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(Vector2);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.Vector2Array;


        public override void ProcessValue(MonoField _field, object _value)
        {
            _field.Vector2Array = _value as Vector2[];
        }
    }

    public class Vector3sHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(Vector3);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.Vector3Array;


        public override void ProcessValue(MonoField _field, object _value)
        {
            _field.Vector3Array = _value as Vector3[];
        }
    }

    public class Vector4sHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(Vector4);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.Vector4Array;


        public override void ProcessValue(MonoField _field, object _value)
        {
            _field.Vector4Array = _value as Vector4[];
        }
    }

    public class QuaternionsHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return _type == typeof(Quaternion);
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.QuaternionArray;


        public override void ProcessValue(MonoField _field, object _value)
        {
            _field.QuaternionArray = _value as Quaternion[];
        }
    }

    #endregion


    public class UnsupportHandler : ArrayHandler
    {
        protected override bool CanHandleArrayType(Type _type)
        {
            return true;
        }

        public override MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.NotSupported;


        public override void ProcessValue(MonoField _field, object _value)
        {
        }
    }
}
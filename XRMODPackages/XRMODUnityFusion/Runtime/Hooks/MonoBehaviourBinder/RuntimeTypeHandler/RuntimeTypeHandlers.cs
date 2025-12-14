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
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.U2D;
using UnityEngine.Video;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    #region DataProperty

    public class DataPropertyHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.DataProperty;

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            if (string.IsNullOrEmpty(_field.Value)) return null;
            _data.BoundData = true;
            return _field.Value;
        }
    }

    #endregion

    #region UnityTypes

    public class Vector3Handler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.Vector3;

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            if (string.IsNullOrEmpty(_field.Value)) return null;
            _data.BoundData = true;
            return JsonUtility.FromJson<SerializableVector3>(_field.Value).ToVector3();
        }
    }

    public class Vector2Handler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.Vector2;

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            if (string.IsNullOrEmpty(_field.Value)) return null;
            _data.BoundData = true;
            return JsonUtility.FromJson<SerializableVector2>(_field.Value).ToVector2();
        }
    }

    public class Vector4Handler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.Vector4;

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            if (string.IsNullOrEmpty(_field.Value)) return null;
            _data.BoundData = true;
            return JsonUtility.FromJson<SerializableVector4>(_field.Value).ToVector4();
        }
    }

    public class QuaternionHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.Quaternion;

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            if (string.IsNullOrEmpty(_field.Value)) return null;
            _data.BoundData = true;
            var tmp_V4 = JsonUtility.FromJson<SerializableVector4>(_field.Value).ToVector4();
            return new Quaternion(tmp_V4.x, tmp_V4.y, tmp_V4.z, tmp_V4.w);
        }
    }

    public class ColorHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.Color;

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            if (string.IsNullOrEmpty(_field.Value)) return null;
            _data.BoundData = true;

            if (ColorUtility.TryParseHtmlString(_field.Value, out var tmp_Color))
                return tmp_Color;

            Debug.LogError("Unavailable color value, correct format: #RRGGBBAA");
            return null;
        }
    }

    public class AnimationCurveHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) =>
            _fieldType == MonoField.FieldTypeEnum.AnimationCurve;


        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            if (string.IsNullOrEmpty(_field.Value)) return null;
            _data.BoundData = true;
            return _field.Value.DeserializeAnimationCurve();
        }
    }

    public class LayerMaskHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.LayerMask;


        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            if (string.IsNullOrEmpty(_field.Value)) return null;
            _data.BoundData = true;
            return LayerMask.GetMask(_field.Value.Split(","));
        }
    }

    public class NumberHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.Number;

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            if (string.IsNullOrEmpty(_field.Value)) return null;
            object tmp_Value = MonoBinderUtils.GetNumberFields(_type, _field);
            if (tmp_Value != null)
            {
                _data.BoundData = true;
            }

            return tmp_Value;
        }
    }

    public class StringHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.String;

        public MonoField.FieldTypeEnum GetFieldType(Type _type) => MonoField.FieldTypeEnum.String;

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            if (string.IsNullOrEmpty(_field.Value)) return null;

            _data.BoundData = true;

            return _field.Value;
        }
    }

    public class BoolHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.Bool;


        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            if (string.IsNullOrEmpty(_field.Value)) return null;
            _data.BoundData = true;
            return _field.Value.ToLower() == "true";
        }
    }

    public class EnumHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.Enum;

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            if (string.IsNullOrEmpty(_field.Value)) return null;
            _data.BoundData = true;
            return int.Parse(_field.Value);
        }
    }

    #endregion

    #region Component

    public class GameObjectHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.GameObject;

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            if (_field.GameObject == null) return null;
            _data.BoundData = true;
            return MonoBinderUtils.GetGameObjectFields(_type, _field);
        }
    }

    public class ComponentHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) =>
            _fieldType == MonoField.FieldTypeEnum.UnityComponent;

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            if (_field.GameObject == null) return null;
            string tmp_ClassPath =
                $"{_data.ClassNamespace + (string.IsNullOrEmpty(_data.ClassName) ? "" : ".")}{_data.ClassName}";
            if (MonoBinderUtils.GetComponent(_field.GameObject, _field, _type, tmp_ClassPath,
                    out var tmp_Obj))
            {
                _data.BoundData = true;
                return tmp_Obj;
            }

            return null;
        }
    }

    #endregion

    #region Asset reference

    public class AssetReferenceHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) =>
            _fieldType == MonoField.FieldTypeEnum.AssetReference;

        private IAssetProvider assetProvider;
        private readonly Dictionary<string, IRuntimeAssetTypeHandler> runtimeTypeHandlers;


        public AssetReferenceHandler(IAssetProvider _assetProvider,
            Dictionary<string, IRuntimeAssetTypeHandler> _runtimeTypeHandlers)
        {
            assetProvider = _assetProvider;
            runtimeTypeHandlers = _runtimeTypeHandlers;
        }

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            var tmp_ProjectName = _data.ClassNamespace.Split(".")[0];
            if (!runtimeTypeHandlers.TryGetValue(_field.AssetType, out IRuntimeAssetTypeHandler tmp_RuntimeTypeHandler))
                return null;
            _data.BoundData = true;
            return tmp_RuntimeTypeHandler.ProcessValue(assetProvider, tmp_ProjectName, _field.Value);
        }
    }

    public class AssetReferenceArrayHandler : IRuntimeTypeHandler
    {
        private readonly Dictionary<string, IRuntimeAssetTypeHandler> runtimeTypeHandlers;

        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) =>
            _fieldType == MonoField.FieldTypeEnum.AssetReferenceArray;

        private readonly IAssetProvider assetProvider;

        public AssetReferenceArrayHandler(IAssetProvider _assetProvider,
            Dictionary<string, IRuntimeAssetTypeHandler> _runtimeTypeHandlers)
        {
            assetProvider = _assetProvider;
            runtimeTypeHandlers = _runtimeTypeHandlers;
        }

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            #region Load Assets

            var tmp_ProjectName = _data.ClassNamespace.Split(".")[0];
            var tmp_LoadAssetNames = JsonConvert.DeserializeObject<List<string>>(_field.Value).ToArray();
            if (!runtimeTypeHandlers.TryGetValue(_field.AssetType, out IRuntimeAssetTypeHandler tmp_RuntimeTypeHandler))
                return null;
            _data.BoundData = true;
            return tmp_RuntimeTypeHandler.ProcessValue(assetProvider, tmp_ProjectName, tmp_LoadAssetNames);

            #endregion
        }
    }

    public class Texture2DsHandler : BaseRuntimeAssetTypeHandler<Texture2D>
    {
        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName,
            string[] _loadAssetNames)
        {
            return _assetProvider.GetAssets<Texture2D>(_projectName, _loadAssetNames);
        }

        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName, string _loadAssetName)
        {
            return _assetProvider.GetAsset<Texture2D>(_projectName, _loadAssetName);
        }
    }

    public class AudioClipsHandler : BaseRuntimeAssetTypeHandler<AudioClip>
    {
        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName,
            string[] _loadAssetNames)
        {
            return _assetProvider.GetAssets<AudioClip>(_projectName, _loadAssetNames);
        }

        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName, string _loadAssetName)
        {
            return _assetProvider.GetAsset<AudioClip>(_projectName, _loadAssetName);
        }
    }

    public class ShadersHandler : BaseRuntimeAssetTypeHandler<Shader>
    {
        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName,
            string[] _loadAssetNames)
        {
            return _assetProvider.GetAssets<Shader>(_projectName, _loadAssetNames);
        }

        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName, string _loadAssetName)
        {
            return _assetProvider.GetAsset<Shader>(_projectName, _loadAssetName);
        }
    }

    public class SpritesHandler : BaseRuntimeAssetTypeHandler<Sprite>
    {
        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName,
            string[] _loadAssetNames)
        {
            return _assetProvider.GetAssets<Sprite>(_projectName, _loadAssetNames);
        }

        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName, string _loadAssetName)
        {
            return _assetProvider.GetAsset<Sprite>(_projectName, _loadAssetName);
        }
    }

    public class MaterialsHandler : BaseRuntimeAssetTypeHandler<Material>
    {
        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName,
            string[] _loadAssetNames)
        {
            return _assetProvider.GetAssets<Material>(_projectName, _loadAssetNames);
        }

        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName, string _loadAssetName)
        {
            return _assetProvider.GetAsset<Material>(_projectName, _loadAssetName);
        }
    }

    public class MeshesHandler : BaseRuntimeAssetTypeHandler<Mesh>
    {
        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName,
            string[] _loadAssetNames)
        {
            return _assetProvider.GetAssets<Mesh>(_projectName, _loadAssetNames);
        }

        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName, string _loadAssetName)
        {
            return _assetProvider.GetAsset<Mesh>(_projectName, _loadAssetName);
        }
    }

    public class VideoClipsHandler : BaseRuntimeAssetTypeHandler<VideoClip>
    {
        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName,
            string[] _loadAssetNames)
        {
            return _assetProvider.GetAssets<VideoClip>(_projectName, _loadAssetNames);
        }

        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName, string _loadAssetName)
        {
            return _assetProvider.GetAsset<VideoClip>(_projectName, _loadAssetName);
        }
    }

    public class AnimationClipsHandler : BaseRuntimeAssetTypeHandler<AnimationClip>
    {
        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName,
            string[] _loadAssetNames)
        {
            return _assetProvider.GetAssets<AnimationClip>(_projectName, _loadAssetNames);
        }

        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName, string _loadAssetName)
        {
            return _assetProvider.GetAsset<AnimationClip>(_projectName, _loadAssetName);
        }
    }

    public class ScriptableObjectsHandler : BaseRuntimeAssetTypeHandler<ScriptableObject>
    {
        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName,
            string[] _loadAssetNames)
        {
            return _assetProvider.GetAssets<ScriptableObject>(_projectName, _loadAssetNames);
        }

        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName, string _loadAssetName)
        {
            return _assetProvider.GetAsset<ScriptableObject>(_projectName, _loadAssetName);
        }
    }

    public class TextAssetsHandler : BaseRuntimeAssetTypeHandler<TextAsset>
    {
        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName,
            string[] _loadAssetNames)
        {
            return _assetProvider.GetAssets<TextAsset>(_projectName, _loadAssetNames);
        }

        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName, string _loadAssetName)
        {
            return _assetProvider.GetAsset<TextAsset>(_projectName, _loadAssetName);
        }
    }

    public class RenderTexturesHandler : BaseRuntimeAssetTypeHandler<RenderTexture>
    {
        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName,
            string[] _loadAssetNames)
        {
            return _assetProvider.GetAssets<RenderTexture>(_projectName, _loadAssetNames);
        }

        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName, string _loadAssetName)
        {
            return _assetProvider.GetAsset<RenderTexture>(_projectName, _loadAssetName);
        }
    }

    public class AudioMixersHandler : BaseRuntimeAssetTypeHandler<AudioMixer>
    {
        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName,
            string[] _loadAssetNames)
        {
            return _assetProvider.GetAssets<AudioMixer>(_projectName, _loadAssetNames);
        }

        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName, string _loadAssetName)
        {
            return _assetProvider.GetAsset<AudioMixer>(_projectName, _loadAssetName);
        }
    }

    public class CubemapsHandler : BaseRuntimeAssetTypeHandler<Cubemap>
    {
        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName,
            string[] _loadAssetNames)
        {
            return _assetProvider.GetAssets<Cubemap>(_projectName, _loadAssetNames);
        }

        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName, string _loadAssetName)
        {
            return _assetProvider.GetAsset<Cubemap>(_projectName, _loadAssetName);
        }
    }

    public class SpriteAtlasesHandler : BaseRuntimeAssetTypeHandler<SpriteAtlas>
    {
        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName,
            string[] _loadAssetNames)
        {
            return _assetProvider.GetAssets<SpriteAtlas>(_projectName, _loadAssetNames);
        }

        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName, string _loadAssetName)
        {
            return _assetProvider.GetAsset<SpriteAtlas>(_projectName, _loadAssetName);
        }
    }

    public class ComputeShadersHandler : BaseRuntimeAssetTypeHandler<ComputeShader>
    {
        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName,
            string[] _loadAssetNames)
        {
            return _assetProvider.GetAssets<ComputeShader>(_projectName, _loadAssetNames);
        }

        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName, string _loadAssetName)
        {
            return _assetProvider.GetAsset<ComputeShader>(_projectName, _loadAssetName);
        }
    }
#if UNITY_6000_0_OR_NEWER
    public class PhysicsMaterialsHandler : BaseRuntimeAssetTypeHandler<PhysicsMaterial>
#else
    public class PhysicsMaterialsHandler : BaseRuntimeAssetTypeHandler<PhysicMaterial>
#endif
    {
        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName,
            string[] _loadAssetNames)
        {
#if UNITY_6000_0_OR_NEWER
            return _assetProvider.GetAssets<PhysicsMaterial>(_projectName, _loadAssetNames);

#else
            return _assetProvider.GetAssets<PhysicMaterial>(_projectName, _loadAssetNames);

#endif
        }

        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName, string _loadAssetName)
        {
#if UNITY_6000_0_OR_NEWER
            return _assetProvider.GetAsset<PhysicsMaterial>(_projectName, _loadAssetName);

#else
            return _assetProvider.GetAsset<PhysicMaterial>(_projectName, _loadAssetName);

#endif
        }
    }

    public class PhysicsMaterial2DsHandler : BaseRuntimeAssetTypeHandler<PhysicsMaterial2D>
    {
        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName,
            string[] _loadAssetNames)
        {
            return _assetProvider.GetAssets<PhysicsMaterial2D>(_projectName, _loadAssetNames);
        }

        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName, string _loadAssetName)
        {
            return _assetProvider.GetAsset<PhysicsMaterial2D>(_projectName, _loadAssetName);
        }
    }

    public class GameObjectRefHandler : BaseRuntimeAssetTypeHandler<GameObject>
    {
        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName,
            string[] _loadAssetNames)
        {
            return _assetProvider.GetAssets<GameObject>(_projectName, _loadAssetNames);
        }

        public override object ProcessValue(IAssetProvider _assetProvider, string _projectName, string _loadAssetName)
        {
            return _assetProvider.GetAsset<GameObject>(_projectName, _loadAssetName);
        }
    }

    #endregion

    #region Array

    public class ComponentsHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.NotSupported;

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            string tmp_ClassPath =
                $"{_data.ClassNamespace + (string.IsNullOrEmpty(_data.ClassName) ? "" : ".")}{_data.ClassName}";
            if (MonoBinderUtils.GetComponents(_field, _type, tmp_ClassPath, out var tmp_Object))
            {
                _data.BoundData = true;
                return tmp_Object;
            }

            return null;
        }
    }

    public class GameObjectsHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) =>
            _fieldType == MonoField.FieldTypeEnum.GameObjectArray;

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            _data.BoundData = true;
            return _field.GameObjectArray;
        }
    }

    public class PrimitivesHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.Primitives;

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            if (string.IsNullOrEmpty(_field.Value)) return null;
            if (_type == typeof(string))
            {
                _data.BoundData = true;
                return JsonUtility.FromJson<GenericPrimitiveObject<string>>(_field.Value).List;
            }

            if (_type == typeof(int))
            {
                _data.BoundData = true;
                return JsonUtility.FromJson<GenericPrimitiveObject<int>>(_field.Value).List;
            }

            if (_type == typeof(float))
            {
                _data.BoundData = true;
                return JsonUtility.FromJson<GenericPrimitiveObject<float>>(_field.Value).List;
            }

            if (_type == typeof(long))
            {
                _data.BoundData = true;
                return JsonUtility.FromJson<GenericPrimitiveObject<long>>(_field.Value).List;
            }

            if (_type == typeof(short))
            {
                _data.BoundData = true;
                return JsonUtility.FromJson<GenericPrimitiveObject<short>>(_field.Value).List;
            }

            if (_type == typeof(bool))
            {
                _data.BoundData = true;
                return JsonUtility.FromJson<GenericPrimitiveObject<bool>>(_field.Value).List;
            }

            if (_type == typeof(byte))
            {
                _data.BoundData = true;
                return JsonUtility.FromJson<GenericPrimitiveObject<byte>>(_field.Value).List;
            }

            if (_type == typeof(ushort))
            {
                _data.BoundData = true;
                return JsonUtility.FromJson<GenericPrimitiveObject<ushort>>(_field.Value).List;
            }

            if (_type == typeof(ulong))
            {
                _data.BoundData = true;
                return JsonUtility.FromJson<GenericPrimitiveObject<ulong>>(_field.Value).List;
            }

            if (_type == typeof(ulong))
            {
                _data.BoundData = true;
                return JsonUtility.FromJson<GenericPrimitiveObject<ulong>>(_field.Value).List;
            }

            return null;
        }
    }


    public class ColorsHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.ColorArray;

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            _data.BoundData = true;
            return _field.ColorArray;
        }
    }

    public class AnimationCurvesHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) =>
            _fieldType == MonoField.FieldTypeEnum.AnimationCurveArray;

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            _data.BoundData = true;
            return _field.AnimationCurveArray;
        }
    }

    public class Vector2sHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.Vector2Array;

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            _data.BoundData = true;
            return _field.Vector2Array;
        }
    }

    public class Vector3sHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.Vector3Array;

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            _data.BoundData = true;
            return _field.Vector3Array;
        }
    }

    public class Vector4sHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.Vector4Array;

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            _data.BoundData = true;
            return _field.Vector4Array;
        }
    }

    public class QuaternionsHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) =>
            _fieldType == MonoField.FieldTypeEnum.QuaternionArray;

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            _data.BoundData = true;
            return _field.QuaternionArray;
        }
    }

    #endregion

    public class UnSupportHandler : IRuntimeTypeHandler
    {
        public bool CanHandle(MonoField.FieldTypeEnum _fieldType) => _fieldType == MonoField.FieldTypeEnum.NotSupported;

        public object ProcessValue(MonoField _field, MonoData _data, Type _type)
        {
            return null;
        }
    }
}
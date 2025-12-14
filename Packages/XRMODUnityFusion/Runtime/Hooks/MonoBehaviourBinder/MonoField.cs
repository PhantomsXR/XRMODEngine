// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the XR-MOD SDK.
// 
// The XR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact nswell@phantomsxr.com for licensing requests.
// ===============================================================================*/

using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.Video;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    [Serializable]
    public class MonoField
    {
        public enum FieldTypeEnum : byte
        {
            Number = 0,
            String = 1,
            Bool = 2,
            GameObject = 3,
            UnityComponent = 4,
            AssetReference = 5,
            Enum = 6,
            Vector2 = 7,
            Vector3 = 8,
            Vector4 = 9,
            Quaternion = 10,
            Color = 11,
            LayerMask = 12,
            NotSupported = 14,
            Primitives = 15,
            ColorArray = 24,
            Vector2Array = 26,
            Vector3Array = 27,
            Vector4Array = 28,
            QuaternionArray = 29,
            AnimationCurve = 30,
            AnimationCurveArray = 31,
            Components = 32,
            GameObjectArray = 33,
            AssetReferenceArray = 34,
            Default = 35,
            DataProperty = 36,
            AudioMixerSnapshot = 37,
        }


        [Tooltip("The name of the key to be assigned")]
        public string FieldName;

        [Tooltip("The value of fieldType of non-GameObject and UnityComponent")]
        public string Value;

        [Tooltip("If fieldType is GameObject or UnityComponent, it can be filled here, otherwise it is invalid")]
        public GameObject GameObject;

        public FieldTypeEnum FieldType = FieldTypeEnum.Default;

        [HideInInspector] public string AssetType;

        [HideInInspector] public Color[] ColorArray;
        [HideInInspector] public Vector2[] Vector2Array;
        [HideInInspector] public Vector3[] Vector3Array;
        [HideInInspector] public Vector4[] Vector4Array;
        [HideInInspector] public Quaternion[] QuaternionArray;
        [HideInInspector] public AnimationCurve[] AnimationCurveArray;
        [HideInInspector] public GameObject[] Components;
        [HideInInspector] public GameObject[] GameObjectArray;


        // [HideInInspector] public Mesh[] MeshArray;
        // [HideInInspector] public Shader[] ShaderArray;
        // [HideInInspector] public Sprite[] SpriteArray;
        // [HideInInspector] public Texture2D[] TextureArray;
        // [HideInInspector] public Material[] MaterialArray;
        // [HideInInspector] public VideoClip[] VideoClipArray;
        // [HideInInspector] public AudioClip[] AudioClipArray;
        // [HideInInspector] public ScriptableObject[] ScriptableObjectArray;
        // [HideInInspector] public AnimationClip[] AnimationClipArray;
    }

    [System.Serializable]
    public class UnityObject<T> where T : Object
    {
        public List<T> List;
        public Type ListType;
    }


    [System.Serializable]
    public class GenericPrimitiveObject<T>
    {
        public List<T> List;
        public string ListType;
    }
}
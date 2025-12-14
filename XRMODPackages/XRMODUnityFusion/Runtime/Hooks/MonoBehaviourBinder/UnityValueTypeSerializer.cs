// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the UnityFusion.Runtime.CodeHook.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    [System.Serializable]
    public class SerializableVector3
    {
        public float x;
        public float y;
        public float z;

        public SerializableVector3(Vector3 vector)
        {
            x = vector.x;
            y = vector.y;
            z = vector.z;
        }

        public Vector3 ToVector3()
        {
            return new Vector3(x, y, z);
        }
    }

    [System.Serializable]
    public class SerializableVector2
    {
        public float x;
        public float y;

        public SerializableVector2(Vector2 vector)
        {
            x = vector.x;
            y = vector.y;
        }

        public Vector2 ToVector2()
        {
            return new Vector2(x, y);
        }
    }

    [System.Serializable]
    public class SerializableVector4
    {
        public float x;
        public float y;
        public float z;
        public float w;

        public SerializableVector4(Vector4 vector)
        {
            x = vector.x;
            y = vector.y;
            z = vector.z;
            w = vector.w;
        }

        public Vector4 ToVector4()
        {
            return new Vector4(x, y, z, w);
        }
    }


    public static class UnityValueTypeSerializer
    {
        public static string Serializer(this Vector2 _vector2)
        {
            return JsonUtility.ToJson(new SerializableVector2(_vector2));
        }

        public static string Serializer(this Vector2[] _vector2)
        {
            List<SerializableVector2> tmp_List = new();

            foreach (Vector2 tmp_Vector2 in _vector2)
            {
                tmp_List.Add(new SerializableVector2(tmp_Vector2));
            }

            return JsonUtility.ToJson(tmp_List);
        }

        public static string Serializer(this Vector3 _vector3)
        {
            return JsonUtility.ToJson(new SerializableVector3(_vector3));
        }

        public static string Serializer(this Vector4 _vector4)
        {
            return JsonUtility.ToJson(new SerializableVector4(_vector4));
        }

        public static string Serializer(this Quaternion _quaternion)
        {
            return JsonUtility.ToJson(
                new SerializableVector4(new Vector4(_quaternion.x, _quaternion.y, _quaternion.z, _quaternion.w)));
        }

        public static string Serializer(this System.Object _object)
        {
            return JsonConvert.SerializeObject(_object);
        }

        public static object Deserializer(this string _jsonData, System.Type _type)
        {
            
            return JsonConvert.DeserializeObject(_jsonData,_type);
        }

        public static string Serializer(this Color _color)
        {
            return $"#{ColorUtility.ToHtmlStringRGBA(_color)}";
        }
    }
}
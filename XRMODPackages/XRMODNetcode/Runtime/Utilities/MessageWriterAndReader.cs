// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.NetcodeModule.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using UnityEngine;

namespace Phantom.XRMOD.NetcodeModule.Runtime
{
    /// <summary>
    /// Binary writer for serializing data packets for network transmission.
    /// </summary>
    /// <remarks>
    /// Provides methods for writing primitives, Unity types (Vector3, Color, etc.), and collections to a binary stream.
    /// Use <see cref="ToArray"/> to get the final byte array for network transmission.
    /// This is a lightweight alternative to MessagePack or other serializers, optimized for Unity types.
    /// </remarks>
    // IL: 简单的二进制读写器（你也可以上 MessagePack/Ceras,但这种最稳）
    public partial class PacketWriter
    {
        private readonly System.IO.MemoryStream ms = new System.IO.MemoryStream();
        private readonly System.IO.BinaryWriter bw;

        /// <summary>
        /// Initializes a new instance of the <see cref="PacketWriter"/> class.
        /// </summary>
        public PacketWriter()
        {
            bw = new System.IO.BinaryWriter(ms);
        }

        public void WriteInt(int v) => bw.Write(v);
        public void WriteLong(long v) => bw.Write(v);
        public void WriteULong(ulong v) => bw.Write(v);
        public void WriteFloat(float v) => bw.Write(v);
        public void WriteDouble(double v) => bw.Write(v);
        public void WriteBool(bool v) => bw.Write(v);
        public void WriteString(string s) => bw.Write(s ?? "");

        public void WriteBytes(byte[] d)
        {
            bw.Write(d?.Length ?? 0);
            if (d is {Length: > 0}) bw.Write(d);
        }

        /// <summary>
        /// Converts the current buffered data into a byte array.
        /// </summary>
        /// <returns>The serialized byte array.</returns>
        public byte[] ToArray() => ms.ToArray();
    }

    public partial class PacketReader
    {
        private readonly System.IO.BinaryReader br;

        /// <summary>
        /// Initializes a new instance of the <see cref="PacketReader"/> class with the specified byte buffer.
        /// </summary>
        /// <param name="_buf">The byte array to read from.</param>
        public PacketReader(byte[] _buf)
        {
            br = new System.IO.BinaryReader(new System.IO.MemoryStream(_buf));
        }

        public int ReadInt() => br.ReadInt32();
        public long ReadLong() => br.ReadInt64();
        public ulong ReadULong() => br.ReadUInt64();
        public float ReadFloat() => br.ReadSingle();
        public double ReadDouble() => br.ReadDouble();
        public bool ReadBool() => br.ReadBoolean();
        public string ReadString() => br.ReadString();

        public byte[] ReadBytes()
        {
            int tmp_Len = br.ReadInt32();
            return tmp_Len > 0 ? br.ReadBytes(tmp_Len) : System.Array.Empty<byte>();
        }
    }

    public partial class PacketWriter
    {
        public void WriteVector2(Vector2 v)
        {
            WriteFloat(v.x);
            WriteFloat(v.y);
        }

        public void WriteVector3(Vector3 v)
        {
            WriteFloat(v.x);
            WriteFloat(v.y);
            WriteFloat(v.z);
        }

        public void WriteVector4(Vector4 v)
        {
            WriteFloat(v.x);
            WriteFloat(v.y);
            WriteFloat(v.z);
            WriteFloat(v.w);
        }

        public void WriteQuaternion(Quaternion q)
        {
            WriteFloat(q.x);
            WriteFloat(q.y);
            WriteFloat(q.z);
            WriteFloat(q.w);
        }

        public void WriteColor(Color c)
        {
            WriteFloat(c.r);
            WriteFloat(c.g);
            WriteFloat(c.b);
            WriteFloat(c.a);
        }

        public void WriteColor32(Color32 c)
        {
            bw.Write(c.r);
            bw.Write(c.g);
            bw.Write(c.b);
            bw.Write(c.a);
        }

        public void WriteVector2Int(Vector2Int v)
        {
            WriteInt(v.x);
            WriteInt(v.y);
        }

        public void WriteVector3Int(Vector3Int v)
        {
            WriteInt(v.x);
            WriteInt(v.y);
            WriteInt(v.z);
        }

        public void WriteRect(Rect r)
        {
            WriteFloat(r.x);
            WriteFloat(r.y);
            WriteFloat(r.width);
            WriteFloat(r.height);
        }

        public void WriteBounds(Bounds b)
        {
            WriteVector3(b.center);
            WriteVector3(b.extents);
        }

        public void WriteMatrix4x4(Matrix4x4 m)
        {
            for (int i = 0; i < 16; i++)
                WriteFloat(m[i]);
        }

        public void WriteRay(Ray r)
        {
            WriteVector3(r.origin);
            WriteVector3(r.direction);
        }
    }

    public partial class PacketReader
    {
        public Vector2 ReadVector2() => new Vector2(ReadFloat(), ReadFloat());

        public Vector3 ReadVector3() => new Vector3(ReadFloat(), ReadFloat(), ReadFloat());

        public Vector4 ReadVector4() => new Vector4(ReadFloat(), ReadFloat(), ReadFloat(), ReadFloat());

        public Quaternion ReadQuaternion() => new Quaternion(ReadFloat(), ReadFloat(), ReadFloat(), ReadFloat());

        public Color ReadColor() => new Color(ReadFloat(), ReadFloat(), ReadFloat(), ReadFloat());

        public Color32 ReadColor32() => new Color32(br.ReadByte(), br.ReadByte(), br.ReadByte(), br.ReadByte());

        public Vector2Int ReadVector2Int() => new Vector2Int(ReadInt(), ReadInt());

        public Vector3Int ReadVector3Int() => new Vector3Int(ReadInt(), ReadInt(), ReadInt());

        public Rect ReadRect() => new Rect(ReadFloat(), ReadFloat(), ReadFloat(), ReadFloat());

        public Bounds ReadBounds() => new Bounds(ReadVector3(), ReadVector3());

        public Matrix4x4 ReadMatrix4x4()
        {
            Matrix4x4 m = new Matrix4x4();
            for (int i = 0; i < 16; i++)
                m[i] = ReadFloat();
            return m;
        }

        public Ray ReadRay() => new Ray(ReadVector3(), ReadVector3());
    }


    public partial class PacketWriter
    {
        // -------- Int / Float / Bool / String --------
        public void WriteIntArray(int[] arr)
        {
            WriteInt(arr?.Length ?? 0);
            if (arr == null) return;
            for (int i = 0; i < arr.Length; i++) WriteInt(arr[i]);
        }

        public void WriteIntList(List<int> list)
        {
            WriteInt(list?.Count ?? 0);
            if (list == null) return;
            for (int i = 0; i < list.Count; i++) WriteInt(list[i]);
        }

        public void WriteFloatArray(float[] arr)
        {
            WriteInt(arr?.Length ?? 0);
            if (arr == null) return;
            for (int i = 0; i < arr.Length; i++) WriteFloat(arr[i]);
        }

        public void WriteFloatList(List<float> list)
        {
            WriteInt(list?.Count ?? 0);
            if (list == null) return;
            for (int i = 0; i < list.Count; i++) WriteFloat(list[i]);
        }

        public void WriteBoolArray(bool[] arr)
        {
            WriteInt(arr?.Length ?? 0);
            if (arr == null) return;
            for (int i = 0; i < arr.Length; i++) WriteBool(arr[i]);
        }

        public void WriteBoolList(List<bool> list)
        {
            WriteInt(list?.Count ?? 0);
            if (list == null) return;
            for (int i = 0; i < list.Count; i++) WriteBool(list[i]);
        }

        public void WriteStringArray(string[] arr)
        {
            WriteInt(arr?.Length ?? 0);
            if (arr == null) return;
            for (int i = 0; i < arr.Length; i++) WriteString(arr[i]);
        }

        public void WriteStringList(List<string> list)
        {
            WriteInt(list?.Count ?? 0);
            if (list == null) return;
            for (int i = 0; i < list.Count; i++) WriteString(list[i]);
        }

        // -------- Vector2 --------
        public void WriteVector2Array(Vector2[] arr)
        {
            WriteInt(arr?.Length ?? 0);
            if (arr == null) return;
            for (int i = 0; i < arr.Length; i++) WriteVector2(arr[i]);
        }

        public void WriteVector2List(List<Vector2> list)
        {
            WriteInt(list?.Count ?? 0);
            if (list == null) return;
            for (int i = 0; i < list.Count; i++) WriteVector2(list[i]);
        }

        // -------- Vector3 --------
        public void WriteVector3Array(Vector3[] arr)
        {
            WriteInt(arr?.Length ?? 0);
            if (arr == null) return;
            for (int i = 0; i < arr.Length; i++) WriteVector3(arr[i]);
        }

        public void WriteVector3List(List<Vector3> list)
        {
            WriteInt(list?.Count ?? 0);
            if (list == null) return;
            for (int i = 0; i < list.Count; i++) WriteVector3(list[i]);
        }

        // -------- Vector4 --------
        public void WriteVector4Array(Vector4[] arr)
        {
            WriteInt(arr?.Length ?? 0);
            if (arr == null) return;
            for (int i = 0; i < arr.Length; i++) WriteVector4(arr[i]);
        }

        public void WriteVector4List(List<Vector4> list)
        {
            WriteInt(list?.Count ?? 0);
            if (list == null) return;
            for (int i = 0; i < list.Count; i++) WriteVector4(list[i]);
        }

        // -------- Quaternion --------
        public void WriteQuaternionArray(Quaternion[] arr)
        {
            WriteInt(arr?.Length ?? 0);
            if (arr == null) return;
            for (int i = 0; i < arr.Length; i++) WriteQuaternion(arr[i]);
        }

        public void WriteQuaternionList(List<Quaternion> list)
        {
            WriteInt(list?.Count ?? 0);
            if (list == null) return;
            for (int i = 0; i < list.Count; i++) WriteQuaternion(list[i]);
        }

        // -------- Color --------
        public void WriteColorArray(Color[] arr)
        {
            WriteInt(arr?.Length ?? 0);
            if (arr == null) return;
            for (int i = 0; i < arr.Length; i++) WriteColor(arr[i]);
        }

        public void WriteColorList(List<Color> list)
        {
            WriteInt(list?.Count ?? 0);
            if (list == null) return;
            for (int i = 0; i < list.Count; i++) WriteColor(list[i]);
        }

        // -------- Color32 --------
        public void WriteColor32Array(Color32[] arr)
        {
            WriteInt(arr?.Length ?? 0);
            if (arr == null) return;
            for (int i = 0; i < arr.Length; i++) WriteColor32(arr[i]);
        }

        public void WriteColor32List(List<Color32> list)
        {
            WriteInt(list?.Count ?? 0);
            if (list == null) return;
            for (int i = 0; i < list.Count; i++) WriteColor32(list[i]);
        }

        // -------- Vector2Int --------
        public void WriteVector2IntArray(Vector2Int[] arr)
        {
            WriteInt(arr?.Length ?? 0);
            if (arr == null) return;
            for (int i = 0; i < arr.Length; i++) WriteVector2Int(arr[i]);
        }

        public void WriteVector2IntList(List<Vector2Int> list)
        {
            WriteInt(list?.Count ?? 0);
            if (list == null) return;
            for (int i = 0; i < list.Count; i++) WriteVector2Int(list[i]);
        }

        // -------- Vector3Int --------
        public void WriteVector3IntArray(Vector3Int[] arr)
        {
            WriteInt(arr?.Length ?? 0);
            if (arr == null) return;
            for (int i = 0; i < arr.Length; i++) WriteVector3Int(arr[i]);
        }

        public void WriteVector3IntList(List<Vector3Int> list)
        {
            WriteInt(list?.Count ?? 0);
            if (list == null) return;
            for (int i = 0; i < list.Count; i++) WriteVector3Int(list[i]);
        }
    }

    public partial class PacketReader
    {
        // -------- Int / Float / Bool / String --------
        public int[] ReadIntArray()
        {
            int len = ReadInt();
            if (len <= 0) return Array.Empty<int>();
            int[] arr = new int[len];
            for (int i = 0; i < len; i++) arr[i] = ReadInt();
            return arr;
        }

        public List<int> ReadIntList()
        {
            int len = ReadInt();
            var list = new List<int>(len);
            for (int i = 0; i < len; i++) list.Add(ReadInt());
            return list;
        }

        public float[] ReadFloatArray()
        {
            int len = ReadInt();
            if (len <= 0) return Array.Empty<float>();
            float[] arr = new float[len];
            for (int i = 0; i < len; i++) arr[i] = ReadFloat();
            return arr;
        }

        public List<float> ReadFloatList()
        {
            int len = ReadInt();
            var list = new List<float>(len);
            for (int i = 0; i < len; i++) list.Add(ReadFloat());
            return list;
        }

        public bool[] ReadBoolArray()
        {
            int len = ReadInt();
            if (len <= 0) return Array.Empty<bool>();
            bool[] arr = new bool[len];
            for (int i = 0; i < len; i++) arr[i] = ReadBool();
            return arr;
        }

        public List<bool> ReadBoolList()
        {
            int len = ReadInt();
            var list = new List<bool>(len);
            for (int i = 0; i < len; i++) list.Add(ReadBool());
            return list;
        }

        public string[] ReadStringArray()
        {
            int len = ReadInt();
            if (len <= 0) return Array.Empty<string>();
            string[] arr = new string[len];
            for (int i = 0; i < len; i++) arr[i] = ReadString();
            return arr;
        }

        public List<string> ReadStringList()
        {
            int len = ReadInt();
            var list = new List<string>(len);
            for (int i = 0; i < len; i++) list.Add(ReadString());
            return list;
        }

        // -------- Vector2 --------
        public Vector2[] ReadVector2Array()
        {
            int len = ReadInt();
            if (len <= 0) return Array.Empty<Vector2>();
            Vector2[] arr = new Vector2[len];
            for (int i = 0; i < len; i++) arr[i] = ReadVector2();
            return arr;
        }

        public List<Vector2> ReadVector2List()
        {
            int len = ReadInt();
            var list = new List<Vector2>(len);
            for (int i = 0; i < len; i++) list.Add(ReadVector2());
            return list;
        }

        // -------- Vector3 --------
        public Vector3[] ReadVector3Array()
        {
            int len = ReadInt();
            if (len <= 0) return Array.Empty<Vector3>();
            Vector3[] arr = new Vector3[len];
            for (int i = 0; i < len; i++) arr[i] = ReadVector3();
            return arr;
        }

        public List<Vector3> ReadVector3List()
        {
            int len = ReadInt();
            var list = new List<Vector3>(len);
            for (int i = 0; i < len; i++) list.Add(ReadVector3());
            return list;
        }

        // -------- Vector4 --------
        public Vector4[] ReadVector4Array()
        {
            int len = ReadInt();
            if (len <= 0) return Array.Empty<Vector4>();
            Vector4[] arr = new Vector4[len];
            for (int i = 0; i < len; i++) arr[i] = ReadVector4();
            return arr;
        }

        public List<Vector4> ReadVector4List()
        {
            int len = ReadInt();
            var list = new List<Vector4>(len);
            for (int i = 0; i < len; i++) list.Add(ReadVector4());
            return list;
        }

        // -------- Quaternion --------
        public Quaternion[] ReadQuaternionArray()
        {
            int len = ReadInt();
            if (len <= 0) return Array.Empty<Quaternion>();
            Quaternion[] arr = new Quaternion[len];
            for (int i = 0; i < len; i++) arr[i] = ReadQuaternion();
            return arr;
        }

        public List<Quaternion> ReadQuaternionList()
        {
            int len = ReadInt();
            var list = new List<Quaternion>(len);
            for (int i = 0; i < len; i++) list.Add(ReadQuaternion());
            return list;
        }

        // -------- Color --------
        public Color[] ReadColorArray()
        {
            int len = ReadInt();
            if (len <= 0) return Array.Empty<Color>();
            Color[] arr = new Color[len];
            for (int i = 0; i < len; i++) arr[i] = ReadColor();
            return arr;
        }

        public List<Color> ReadColorList()
        {
            int len = ReadInt();
            var list = new List<Color>(len);
            for (int i = 0; i < len; i++) list.Add(ReadColor());
            return list;
        }

        // -------- Color32 --------
        public Color32[] ReadColor32Array()
        {
            int len = ReadInt();
            if (len <= 0) return Array.Empty<Color32>();
            Color32[] arr = new Color32[len];
            for (int i = 0; i < len; i++) arr[i] = ReadColor32();
            return arr;
        }

        public List<Color32> ReadColor32List()
        {
            int len = ReadInt();
            var list = new List<Color32>(len);
            for (int i = 0; i < len; i++) list.Add(ReadColor32());
            return list;
        }

        // -------- Vector2Int --------
        public Vector2Int[] ReadVector2IntArray()
        {
            int len = ReadInt();
            if (len <= 0) return Array.Empty<Vector2Int>();
            Vector2Int[] arr = new Vector2Int[len];
            for (int i = 0; i < len; i++) arr[i] = ReadVector2Int();
            return arr;
        }

        public List<Vector2Int> ReadVector2IntList()
        {
            int len = ReadInt();
            var list = new List<Vector2Int>(len);
            for (int i = 0; i < len; i++) list.Add(ReadVector2Int());
            return list;
        }

        // -------- Vector3Int --------
        public Vector3Int[] ReadVector3IntArray()
        {
            int len = ReadInt();
            if (len <= 0) return Array.Empty<Vector3Int>();
            Vector3Int[] arr = new Vector3Int[len];
            for (int i = 0; i < len; i++) arr[i] = ReadVector3Int();
            return arr;
        }

        public List<Vector3Int> ReadVector3IntList()
        {
            int len = ReadInt();
            var list = new List<Vector3Int>(len);
            for (int i = 0; i < len; i++) list.Add(ReadVector3Int());
            return list;
        }
    }

    public partial class PacketWriter
    {
        // -------- Bounds --------
        public void WriteBoundsArray(Bounds[] arr)
        {
            WriteInt(arr?.Length ?? 0);
            if (arr == null) return;
            for (int i = 0; i < arr.Length; i++) WriteBounds(arr[i]);
        }

        public void WriteBoundsList(List<Bounds> list)
        {
            WriteInt(list?.Count ?? 0);
            if (list == null) return;
            for (int i = 0; i < list.Count; i++) WriteBounds(list[i]);
        }

        // -------- Rect --------
        public void WriteRectArray(Rect[] arr)
        {
            WriteInt(arr?.Length ?? 0);
            if (arr == null) return;
            for (int i = 0; i < arr.Length; i++) WriteRect(arr[i]);
        }

        public void WriteRectList(List<Rect> list)
        {
            WriteInt(list?.Count ?? 0);
            if (list == null) return;
            for (int i = 0; i < list.Count; i++) WriteRect(list[i]);
        }

        // -------- Matrix4x4 --------
        public void WriteMatrix4x4Array(Matrix4x4[] arr)
        {
            WriteInt(arr?.Length ?? 0);
            if (arr == null) return;
            for (int i = 0; i < arr.Length; i++) WriteMatrix4x4(arr[i]);
        }

        public void WriteMatrix4x4List(List<Matrix4x4> list)
        {
            WriteInt(list?.Count ?? 0);
            if (list == null) return;
            for (int i = 0; i < list.Count; i++) WriteMatrix4x4(list[i]);
        }

        // -------- Ray --------
        public void WriteRayArray(Ray[] arr)
        {
            WriteInt(arr?.Length ?? 0);
            if (arr == null) return;
            for (int i = 0; i < arr.Length; i++) WriteRay(arr[i]);
        }

        public void WriteRayList(List<Ray> list)
        {
            WriteInt(list?.Count ?? 0);
            if (list == null) return;
            for (int i = 0; i < list.Count; i++) WriteRay(list[i]);
        }
    }

    public partial class PacketReader
    {
        // -------- Bounds --------
        public Bounds[] ReadBoundsArray()
        {
            int len = ReadInt();
            if (len <= 0) return Array.Empty<Bounds>();
            Bounds[] arr = new Bounds[len];
            for (int i = 0; i < len; i++) arr[i] = ReadBounds();
            return arr;
        }

        public List<Bounds> ReadBoundsList()
        {
            int len = ReadInt();
            var list = new List<Bounds>(len);
            for (int i = 0; i < len; i++) list.Add(ReadBounds());
            return list;
        }

        // -------- Rect --------
        public Rect[] ReadRectArray()
        {
            int len = ReadInt();
            if (len <= 0) return Array.Empty<Rect>();
            Rect[] arr = new Rect[len];
            for (int i = 0; i < len; i++) arr[i] = ReadRect();
            return arr;
        }

        public List<Rect> ReadRectList()
        {
            int len = ReadInt();
            var list = new List<Rect>(len);
            for (int i = 0; i < len; i++) list.Add(ReadRect());
            return list;
        }

        // -------- Matrix4x4 --------
        public Matrix4x4[] ReadMatrix4x4Array()
        {
            int len = ReadInt();
            if (len <= 0) return Array.Empty<Matrix4x4>();
            Matrix4x4[] arr = new Matrix4x4[len];
            for (int i = 0; i < len; i++) arr[i] = ReadMatrix4x4();
            return arr;
        }

        public List<Matrix4x4> ReadMatrix4x4List()
        {
            int len = ReadInt();
            var list = new List<Matrix4x4>(len);
            for (int i = 0; i < len; i++) list.Add(ReadMatrix4x4());
            return list;
        }

        // -------- Ray --------
        public Ray[] ReadRayArray()
        {
            int len = ReadInt();
            if (len <= 0) return Array.Empty<Ray>();
            Ray[] arr = new Ray[len];
            for (int i = 0; i < len; i++) arr[i] = ReadRay();
            return arr;
        }

        public List<Ray> ReadRayList()
        {
            int len = ReadInt();
            var list = new List<Ray>(len);
            for (int i = 0; i < len; i++) list.Add(ReadRay());
            return list;
        }
    }
}
// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Avatar.Runtime.
// //
// // The Avatar cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

namespace Phantom.XRMOD.Avatar.Runtime
{
    public static class NetworkSerializerUtility
    {
        public static byte[] SerializePosesCustom(Pose[] poses)
        {
            int sizePerPose = 3 * sizeof(float) + 4 * sizeof(float); // Vector3 (3 floats) + Quaternion (4 floats)
            byte[] data = new byte[poses.Length * sizePerPose];
            int offset = 0;

            foreach (Pose pose in poses)
            {
                // Serialize Vector3 (position)
                Buffer.BlockCopy(BitConverter.GetBytes(pose.position.x), 0, data, offset, sizeof(float));
                offset += sizeof(float);
                Buffer.BlockCopy(BitConverter.GetBytes(pose.position.y), 0, data, offset, sizeof(float));
                offset += sizeof(float);
                Buffer.BlockCopy(BitConverter.GetBytes(pose.position.z), 0, data, offset, sizeof(float));
                offset += sizeof(float);

                // Serialize Quaternion (rotation)
                Buffer.BlockCopy(BitConverter.GetBytes(pose.rotation.x), 0, data, offset, sizeof(float));
                offset += sizeof(float);
                Buffer.BlockCopy(BitConverter.GetBytes(pose.rotation.y), 0, data, offset, sizeof(float));
                offset += sizeof(float);
                Buffer.BlockCopy(BitConverter.GetBytes(pose.rotation.z), 0, data, offset, sizeof(float));
                offset += sizeof(float);
                Buffer.BlockCopy(BitConverter.GetBytes(pose.rotation.w), 0, data, offset, sizeof(float));
                offset += sizeof(float);
            }

            return data;
        }

        public static Pose[] DeserializePosesCustom(byte[] data)
        {
            int sizePerPose = 3 * sizeof(float) + 4 * sizeof(float);
            int numPoses = data.Length / sizePerPose;
            Pose[] poses = new Pose[numPoses];
            int offset = 0;

            for (int i = 0; i < numPoses; i++)
            {
                // Deserialize Vector3 (position)
                float x = BitConverter.ToSingle(data, offset);
                offset += sizeof(float);
                float y = BitConverter.ToSingle(data, offset);
                offset += sizeof(float);
                float z = BitConverter.ToSingle(data, offset);
                offset += sizeof(float);
                Vector3 position = new Vector3(x, y, z);

                // Deserialize Quaternion (rotation)
                float qx = BitConverter.ToSingle(data, offset);
                offset += sizeof(float);
                float qy = BitConverter.ToSingle(data, offset);
                offset += sizeof(float);
                float qz = BitConverter.ToSingle(data, offset);
                offset += sizeof(float);
                float qw = BitConverter.ToSingle(data, offset);
                offset += sizeof(float);
                Quaternion rotation = new Quaternion(qx, qy, qz, qw);

                poses[i] = new Pose(position, rotation);
            }

            return poses;
        }
        
        public static byte[] SerializeAndCompressPoses(Pose[] poses)
        {
            // 自定义序列化Pose数组为字节数组
            byte[] serializedData = SerializePosesCustom(poses);

            // 使用GZip压缩
            using (MemoryStream outputStream = new MemoryStream())
            {
                using (GZipStream gzipStream = new GZipStream(outputStream, CompressionMode.Compress))
                {
                    gzipStream.Write(serializedData, 0, serializedData.Length);
                }
                return outputStream.ToArray();
            }
        }
        
        public static Pose[] DecompressAndDeserializePoses(byte[] compressedData, int originalSize)
        {
            // 解压GZip数据
            using (MemoryStream inputStream = new MemoryStream(compressedData))
            using (GZipStream gzipStream = new GZipStream(inputStream, CompressionMode.Decompress))
            using (MemoryStream outputStream = new MemoryStream())
            {
                gzipStream.CopyTo(outputStream);
                byte[] decompressedData = outputStream.ToArray();

                // 自定义反序列化
                return DeserializePosesCustom(decompressedData);
            }
        }
        
        public static List<int> GetChangedPosesIndices(Pose[] previousPoses, Pose[] currentPoses, float threshold)
        {
            List<int> changedIndices = new List<int>();

            for (int i = 0; i < previousPoses.Length; i++)
            {
                if (Vector3.Distance(previousPoses[i].position, currentPoses[i].position) > threshold ||
                    Quaternion.Angle(previousPoses[i].rotation, currentPoses[i].rotation) > threshold)
                {
                    changedIndices.Add(i);
                }
            }

            return changedIndices;
        }
        
        
        public static byte[] SerializeAndCompressChangedPoses(Pose[] currentPoses, List<int> changedIndices)
        {
            // 自定义序列化变化的Pose及其索引
            using (MemoryStream ms = new MemoryStream())
            {
                using (BinaryWriter writer = new BinaryWriter(ms))
                {
                    // 写入变化的Pose数量
                    writer.Write(changedIndices.Count);

                    // 序列化每个变化的Pose和它的索引
                    foreach (int index in changedIndices)
                    {
                        writer.Write(index);
                
                        Pose pose = currentPoses[index];
                        writer.Write(pose.position.x);
                        writer.Write(pose.position.y);
                        writer.Write(pose.position.z);

                        writer.Write(pose.rotation.x);
                        writer.Write(pose.rotation.y);
                        writer.Write(pose.rotation.z);
                        writer.Write(pose.rotation.w);
                    }
                }

                // 使用GZip压缩
                byte[] serializedData = ms.ToArray();
                using (MemoryStream outputStream = new MemoryStream())
                {
                    using (GZipStream gzipStream = new GZipStream(outputStream, CompressionMode.Compress))
                    {
                        gzipStream.Write(serializedData, 0, serializedData.Length);
                    }
                    return outputStream.ToArray();
                }
            }
        }
    }
}
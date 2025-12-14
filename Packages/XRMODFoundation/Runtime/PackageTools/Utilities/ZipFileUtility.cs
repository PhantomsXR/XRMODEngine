// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PackageTools.Editor.
// //
// // The UnityVisionOSLibTest cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Unity.SharpZipLib.Core;
using Unity.SharpZipLib.Zip;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Runtime
{
    public class ZipFileUtility
    {
        public static void ZipFiles(string[] _sourceFiles, string _zipFilePath, string _password)
        {
            try
            {
                using (FileStream tmp_FsOut = new FileStream(_zipFilePath, FileMode.Create, FileAccess.Write))
                using (ZipOutputStream tmp_ZipStream = new ZipOutputStream(tmp_FsOut))
                {
                    // 设置压缩级别
                    tmp_ZipStream.SetLevel(9);

                    if (!string.IsNullOrEmpty(_password))
                    {
                        // 设置密码
                        tmp_ZipStream.Password = _password;
                    }

                    byte[] tmp_Buffer = new byte[4096];

                    foreach (string tmp_SourceFile in _sourceFiles)
                    {
                        // 如果文件不存在，则跳过
                        if (!File.Exists(tmp_SourceFile))
                        {
                            Debug.LogWarning("File not found: " + tmp_SourceFile);
                            continue;
                        }

                        FileInfo tmp_Fi = new FileInfo(tmp_SourceFile);
                        string tmp_EntryName = Path.GetFileName(tmp_SourceFile);
                        ZipEntry tmp_Entry = new ZipEntry(tmp_EntryName)
                        {
                            DateTime = tmp_Fi.LastWriteTime
                        };
                        tmp_ZipStream.PutNextEntry(tmp_Entry);

                        using (FileStream tmp_FsIn = new FileStream(tmp_SourceFile, FileMode.Open, FileAccess.Read))
                        {
                            StreamUtils.Copy(tmp_FsIn, tmp_ZipStream, tmp_Buffer);
                        }

                        tmp_ZipStream.CloseEntry();
                    }

                    // 释放流
                    tmp_ZipStream.IsStreamOwner = true;
                    tmp_ZipStream.Close();
                }
            }
            catch (System.Exception tmp_Ex)
            {
                Debug.LogError("Error zipping files: " + tmp_Ex.Message);
            }
        }


        public static void UnzipFiles(string _zipFilePath, string _outputPath, string _password = null)
        {
            if (!File.Exists(_zipFilePath))
            {
                Debug.LogError("Zip file not found: " + _zipFilePath);
                return;
            }

            try
            {
                using (ZipInputStream tmp_S = new ZipInputStream(File.OpenRead(_zipFilePath)))
                {
                    if (!string.IsNullOrEmpty(_password))
                    {
                        tmp_S.Password = _password;
                    }

                    while (tmp_S.GetNextEntry() is { } tmp_TheEntry)
                    {
                        if (!tmp_TheEntry.IsFile)
                        {
                            continue; // 跳过目录条目
                        }

                        string tmp_EntryFileName = tmp_TheEntry.Name;
                        string tmp_FullZipToPath = Path.Combine(_outputPath, tmp_EntryFileName);
                        string tmp_DirectoryName = Path.GetDirectoryName(tmp_FullZipToPath);

                        if (!string.IsNullOrEmpty(tmp_DirectoryName))
                        {
                            Directory.CreateDirectory(tmp_DirectoryName);
                        }

                        using FileStream tmp_StreamWriter = File.Create(tmp_FullZipToPath);
                        int tmp_Size = 2048;
                        byte[] tmp_Data = new byte[tmp_Size];
                        while (true)
                        {
                            tmp_Size = tmp_S.Read(tmp_Data, 0, tmp_Data.Length);
                            if (tmp_Size > 0)
                            {
                                tmp_StreamWriter.Write(tmp_Data, 0, tmp_Size);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }
            catch (System.Exception tmp_Ex)
            {
                Debug.LogError("Error unzipping file: " + tmp_Ex.Message);
            }
        }


        public static string CalculateFileMD5(string _filePath)
        {
            if (!File.Exists(_filePath))
            {
                throw new FileNotFoundException("File Not Exist。", _filePath);
            }

            try
            {
                using FileStream tmp_FileStream =
                    new FileStream(_filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
                using MD5 tmp_MD5 = MD5.Create();
                byte[] tmp_HashBytes = tmp_MD5.ComputeHash(tmp_FileStream);

                // 将字节数组转换为十六进制字符串
                StringBuilder tmp_Builder = new StringBuilder();
                foreach (var tmp_HashByte in tmp_HashBytes)
                {
                    // "x2" 表示以两位十六进制格式输出
                    tmp_Builder.Append(tmp_HashByte.ToString("x2"));
                }

                return tmp_Builder.ToString();
            }
            catch (Exception tmp_Ex)
            {
                throw;
            }
        }


        public static string CalculateStringMD5(string _input)
        {
            // 将输入字符串转换为字节数组
            // 推荐使用 UTF8 编码
            byte[] tmp_InputBytes = Encoding.UTF8.GetBytes(_input);

            // 创建 MD5 哈希算法实例
            using MD5 tmp_MD5 = MD5.Create();
            // 计算哈希值
            var tmp_HashBytes = tmp_MD5.ComputeHash(tmp_InputBytes);

            StringBuilder tmp_Sb = new StringBuilder();
            foreach (var tmp_HashByte in tmp_HashBytes)
            {
                // x2 表示十六进制，两位，不足补0
                tmp_Sb.Append(tmp_HashByte.ToString("x2"));
            }

            return tmp_Sb.ToString();
        }

        public static string CombineMD5ByConcatenation(List<string> _dataList)
        {
            StringBuilder tmp_CombinedData = new StringBuilder();
            foreach (string tmp_Data in _dataList)
            {
                tmp_CombinedData.Append(tmp_Data);
            }

            using MD5 tmp_MD5 = MD5.Create();
            byte[] tmp_HashBytes = tmp_MD5.ComputeHash(Encoding.UTF8.GetBytes(tmp_CombinedData.ToString()));
            return BitConverter.ToString(tmp_HashBytes).Replace("-", "").ToLower();
        }
    }
}
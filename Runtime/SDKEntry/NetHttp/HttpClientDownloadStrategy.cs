// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.SDKEntry.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

namespace Phantom.XRMOD.SDKEntry.Runtime
{
    /// <summary>
    /// Implementation of <see cref="IDownloadStrategy"/> using .NET <see cref="HttpClient"/>.
    /// Supports multi-part downloads with Range headers for improved performance.
    /// </summary>
    public class HttpClientDownloadStrategy : IDownloadStrategy
    {
        private readonly HttpClient httpClient;

        public HttpClientDownloadStrategy(HttpClient _httpClient)
        {
            this.httpClient = _httpClient ?? throw new ArgumentNullException(nameof(_httpClient));
        }

        public async Task DownloadFileAsync(string _url, string _destinationPath, IProgress<float> _progress = null)
        {
            using var tmp_Response = await httpClient.GetAsync(_url, HttpCompletionOption.ResponseHeadersRead);
            tmp_Response.EnsureSuccessStatusCode();
            await using var tmp_ContentStream = await tmp_Response.Content.ReadAsStreamAsync();
            await using var tmp_FileStream = new FileStream(_destinationPath, FileMode.Create, FileAccess.Write,
                FileShare.None, 16384);
            var tmp_TotalBytes = tmp_Response.Content.Headers.ContentLength ?? 0;
            long tmp_TotalBytesDownloaded = 0L;
            var tmp_PartSize = 1024 * 1024 * 10;
            var tmp_PartCount = (int) Math.Ceiling(tmp_TotalBytes / (double) tmp_PartSize);
            var tmp_Tasks = new List<Task>();
            for (int i = 0; i < tmp_PartCount; i++)
            {
                var tmp_PartStart = i * tmp_PartSize;
                var tmp_PartEnd = Math.Min(tmp_PartStart + tmp_PartSize - 1, tmp_TotalBytes - 1);

                tmp_Tasks.Add(DownloadPartAsync(_url, tmp_FileStream, tmp_PartStart, tmp_PartEnd, tmp_TotalBytes,
                    tmp_TotalBytesDownloaded, _progress));
            }

            await Task.WhenAll(tmp_Tasks);
        }


        // 下载某一部分并写入文件
        private async Task DownloadPartAsync(string url, FileStream fileStream, long startByte, long endByte,
            long totalBytes, long totalBytesDownloaded, IProgress<float> progress)
        {
            // 创建 Range 请求头
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, url)
            {
                Headers =
                {
                    Range = new System.Net.Http.Headers.RangeHeaderValue(startByte, endByte)
                }
            };

            // 发送请求获取部分内容
            var response = await httpClient.SendAsync(requestMessage, HttpCompletionOption.ResponseHeadersRead);
            response.EnsureSuccessStatusCode();

            // 获取部分数据流
            await using var partStream = await response.Content.ReadAsStreamAsync();

            // 将该部分数据写入文件
            var buffer = new byte[8192];
            int bytesRead;
            while ((bytesRead = await partStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                // 写入文件时，确保写入的是正确的文件偏移位置
                lock (fileStream) // 防止并发写入时出现冲突
                {
                    fileStream.Seek(startByte, SeekOrigin.Begin); // 定位到正确的写入位置
                    fileStream.Write(buffer, 0, bytesRead);
                    startByte += bytesRead;
                }

                // 线程安全更新下载的字节数
                Interlocked.Add(ref totalBytesDownloaded, bytesRead);

                // 报告进度
                if (progress != null)
                {
                    var downloadedPercentage = (float) totalBytesDownloaded / totalBytes;
                    progress.Report(downloadedPercentage); // 更新进度
                }
            }
        }
    }
}
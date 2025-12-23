// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the BaseFeaturesModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Text;
using Phantom.XRMOD.ActionNotification.Runtime;
using GLTFast;
using Phantom.XRMOD.BaseFeatures.Runtime.Models;
using Phantom.XRMOD.GLTFExtension.Runtime;
using UnityEngine;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine.Assertions;

namespace Phantom.XRMOD.BaseFeatures.Runtime
{
    /// <summary>
    /// Command that initializes the GLTF asset loading system.
    /// It subscribes to network mesh acquisition requests and handles shader resource management.
    /// </summary>
    public class BuildGltfLoaderCommand : ICommand, IReleaseCommand
    {
        public BuildGltfLoaderCommand()
        {
            Execute();
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(TryAcquireNetworkMesh,
                nameof(ActionParameterDataType.TryAcquireNetworkMesh));
        }

        public void Release(string _projectName = null)
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(TryAcquireNetworkMesh));
            ReleaseShaders();
        }


        private void ReleaseShaders()
        {
            string[] tmp_ShaderNames =
            {
                "glTF-pbrMetallicRoughness",
                "glTF-pbrMetallicRoughness-Opaque",
                "glTF-pbrSpecularGlossiness",
                "glTF-pbrSpecularGlossiness-Opaque",
                "glTF-pbrSpecularGlossiness-Blend",
                "glTF-unlit",
                "glTF-pbrMetallicRoughness-Blend",
            };
            foreach (string tmp_ShaderName in tmp_ShaderNames)
            {
                var tmp_Shader = Shader.Find($"Shader Graphs/{tmp_ShaderName}");
                if (tmp_Shader)
                    Resources.UnloadAsset(tmp_Shader);
            }
        }

        /// <summary>
        /// Get the mesh file from network
        /// </summary>
        /// <param name="_base">Notification data</param>
        private async void TryAcquireNetworkMesh(BaseNotificationData _base)
        {
            var tmp_GltfFileCacheManager = IocContainer.GetIoc.Resolve<BaseFeatureModel>().GltfFileCacheManager;
            var tmp_LocalPath = tmp_GltfFileCacheManager.GetRecord(new Uri(_base.BaseData));
            var tmp_LoaderGo = new GameObject(nameof(TryAcquireNetworkMesh));
            var tmp_Loader = tmp_LoaderGo.AddComponent<GltfLoader>();
            IDeferAgent tmp_DeferAgent = tmp_LoaderGo.AddComponent<TimeBudgetPerFrameDeferAgent>();
            tmp_Loader.createBoxCollider = false;

            var tmp_IsLoad = await tmp_Loader.Load(string.IsNullOrEmpty(tmp_LocalPath)
                ? _base.BaseData
                : $"file://{tmp_LocalPath}", deferAgent: tmp_DeferAgent);
            if (!tmp_IsLoad) return;
            tmp_Loader.name += tmp_Loader.GetHashCode(); //System.IO.Path.GetFileNameWithoutExtension(_base.BaseData);
            _base.NotificationActWithData?.Invoke(tmp_Loader.gameObject);

            // Caching
            // await IocContainer.GetIoc.Resolve<BaseFeatureModel>().GltfFileCacheManager
            //     .AddNewRecord(new Uri(_base.BaseData), new[] {tmp_Loader.gameObject});
        }
    }
}
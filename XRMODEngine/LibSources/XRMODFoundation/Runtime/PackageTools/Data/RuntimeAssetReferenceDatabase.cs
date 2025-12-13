// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PackageTools.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Audio;
using UnityEngine.U2D;
using UnityEngine.Video;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.XRMODPackageTools.Runtime
{
    public class RuntimeAssetReferenceDatabase : ScriptableObject
    {
        public List<AssetReferenceData> assetReferences;
#if UNITY_EDITOR
        public void AddAssetReference(AssetReferenceData _assetReference)
        {
            Assert.IsNotNull(assetReferences, "assetReferences is null");
            var tmp_Asset = assetReferences.Find(_data => _data.AssetName == _assetReference.AssetName);
            if (tmp_Asset == null)
                assetReferences.Add(_assetReference);
        }

        public bool ExistAssetReference(string _assetName)
        {
            return assetReferences.Exists(_data => _data.AssetName == _assetName);
        }

        public void SetAssetReferences(string _assetName, Object _asset)
        {
            var tmp_Asset = assetReferences.Find(_data => _data.AssetName == _assetName);
            if (tmp_Asset != null)
                tmp_Asset.Asset = _asset;
        }

        public void RemoveAssetReference(AssetReferenceData _assetReference)
        {
            var tmp_Asset = assetReferences.Find(_data => _data.AssetName == _assetReference.AssetName);
            if (tmp_Asset != null)
                assetReferences.Remove(tmp_Asset);
        }
#endif
        public void GetAssetReference(string _assetName, out Object _asset)
        {
            var tmp_Asset = assetReferences.Find(_data => _data.AssetName == _assetName);
            if (tmp_Asset != null && tmp_Asset.Asset != null)
            {
                _asset = tmp_Asset.Asset;
            }
            else
            {
                Debug.LogError($"Could not find asset: {_assetName}");
                _asset = null;
            }
        }

        public void GetAssetReference<T>(string _assetName, out T _asset) where T : Object
        {
            var tmp_Asset = assetReferences.Find(_data => _data.AssetName == _assetName);
            if (tmp_Asset != null && tmp_Asset.Asset != null)
            {
                _asset = tmp_Asset.Asset as T;
            }
            else
            {
                Debug.LogError($"Could not find asset: {_assetName}");
                _asset = null;
            }
        }

        public void GetAssetReferences<T>(string[] _assetName, out T[] _asset) where T : UnityEngine.Object
        {
            var tmp_AssetRefData = assetReferences.Where(_data => _assetName.Contains(_data.AssetName));
            var tmp_ConvertTypes = tmp_AssetRefData.Select(_data => _data.Asset as T);
            _asset = tmp_ConvertTypes.Where(_data => _data != null).ToArray();
        }


        public async Task Initialize(string _projectName)
        {
            try
            {
                foreach (AssetReferenceData tmp_AssetReferenceData in assetReferences)
                {
                    var tmp_Loader = new Dictionary<string, Func<Task<Object>>>()
                    {
                        {
                            typeof(GameObject).FullName, async () =>
                                await BasePackageLoaderUtility.LoadAssetFromPackage<GameObject>(
                                    _projectName, tmp_AssetReferenceData.AssetName)
                        },
                        {
                            typeof(Sprite).FullName, async () =>
                                await BasePackageLoaderUtility.LoadAssetFromPackage<Sprite>(
                                    _projectName, tmp_AssetReferenceData.AssetName)
                        },
                        {
                            typeof(SpriteAtlas).FullName, async () =>
                                await BasePackageLoaderUtility.LoadAssetFromPackage<SpriteAtlas>(
                                    _projectName, tmp_AssetReferenceData.AssetName)
                        },
                        {
                            typeof(Texture2D).FullName, async () =>
                                await BasePackageLoaderUtility.LoadAssetFromPackage<Texture2D>(
                                    _projectName, tmp_AssetReferenceData.AssetName)
                        },
                        {
                            typeof(AudioClip).FullName, async () =>
                                await BasePackageLoaderUtility.LoadAssetFromPackage<AudioClip>(
                                    _projectName, tmp_AssetReferenceData.AssetName)
                        },
                        {
                            typeof(VideoClip).FullName, async () =>
                                await BasePackageLoaderUtility.LoadAssetFromPackage<VideoClip>(
                                    _projectName, tmp_AssetReferenceData.AssetName)
                        },
                        {
                            typeof(Mesh).FullName, async () =>
                                await BasePackageLoaderUtility.LoadAssetFromPackage<Mesh>(
                                    _projectName, tmp_AssetReferenceData.AssetName)
                        },
                        {
                            typeof(AudioMixer).FullName, async () =>
                                await BasePackageLoaderUtility.LoadAssetFromPackage<AudioMixer>(
                                    _projectName, tmp_AssetReferenceData.AssetName)
                        },
                        {
                            typeof(Material).FullName, async () =>
                                await BasePackageLoaderUtility.LoadAssetFromPackage<Material>(
                                    _projectName, tmp_AssetReferenceData.AssetName)
                        },
                        {
                            typeof(Shader).FullName, async () =>
                                await BasePackageLoaderUtility.LoadAssetFromPackage<Shader>(
                                    _projectName, tmp_AssetReferenceData.AssetName)
                        },
                        {
                            typeof(TextAsset).FullName, async () =>
                                await BasePackageLoaderUtility.LoadAssetFromPackage<TextAsset>(
                                    _projectName, tmp_AssetReferenceData.AssetName)
                        },
                        {
#if UNITY_6000_0_OR_NEWER
                            typeof(PhysicsMaterial).FullName, async () =>
                                await BasePackageLoaderUtility.LoadAssetFromPackage<PhysicsMaterial>(
                                    _projectName, tmp_AssetReferenceData.AssetName)
#else
                                    typeof(PhysicMaterial).FullName, async () =>
                                        await BasePackageLoaderUtility.LoadAssetFromPackage<PhysicMaterial>(
                                            _projectName, tmp_AssetReferenceData.AssetName)
#endif
                        },
                        {
                            typeof(Font).FullName, async () =>
                                await BasePackageLoaderUtility.LoadAssetFromPackage<Font>(
                                    _projectName, tmp_AssetReferenceData.AssetName)
                        },
                        {
                            typeof(Texture).FullName, async () =>
                                await BasePackageLoaderUtility.LoadAssetFromPackage<Texture>(
                                    _projectName, tmp_AssetReferenceData.AssetName)
                        },
                        {
                            typeof(ComputeShader).FullName, async () =>
                                await BasePackageLoaderUtility.LoadAssetFromPackage<ComputeShader>(
                                    _projectName, tmp_AssetReferenceData.AssetName)
                        },
                        {
                            typeof(ScriptableObject).FullName, async () =>
                                await BasePackageLoaderUtility.LoadAssetFromPackage<ScriptableObject>(
                                    _projectName, tmp_AssetReferenceData.AssetName)
                        }
                    };

                    if (!tmp_Loader.TryGetValue(tmp_AssetReferenceData.AssetType, out var tmp_Func)) continue;
                    if (tmp_Func != null)
                    {
                        var tmp_Asset = await tmp_Func();
                        tmp_AssetReferenceData.Asset = tmp_Asset;
                    }
                }
            }
            catch (Exception tmp_Exception)
            {
                Debug.Log(tmp_Exception);
                throw;
            }
        }

        private void OnDisable()
        {
            if (assetReferences == null) return;
            foreach (AssetReferenceData tmp_AssetReferenceData in assetReferences)
            {
                tmp_AssetReferenceData.Asset = null;
            }
        }

#if UNITY_EDITOR
        private void OnValidate()
        {
            foreach (AssetReferenceData tmp_AssetReferenceData in assetReferences)
            {
                tmp_AssetReferenceData.Asset = null;
            }

            UnityEditor.EditorUtility.SetDirty(this);
        }
#endif
    }
}
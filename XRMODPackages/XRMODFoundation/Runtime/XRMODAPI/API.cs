/*===============================================================================
Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.

This file is part of the XR-MOD SDK.

The XR-MOD SDK cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Phantom.XRMOD.XRMODPackageTools.Runtime;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Object = UnityEngine.Object;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

namespace Phantom.XRMOD.XRMODAPI.Runtime
{
    /// <summary>
    /// Provides a comprehensive API for interacting with the XRMOD Engine,
    /// covering project management, UI, asset loading, device information, and XR functionalities.
    /// </summary>
    public class API
    {
        private readonly string projectName;
        private readonly GameObject processHolder;
        private static readonly Vector3 _DEFAULT_DIMENSIONS = Vector3.one;
        private GraphicRaycaster graphicRaycaster;

        /// <summary>
        /// Gets the unique process ID for the current project instance.
        /// </summary>
        public string GetProcessId { get; }

        /// <summary>
        /// Gets the transform of the GameObject that acts as a container for processes.
        /// </summary>
        public Transform GetProcessContainer => processHolder.transform;


        /// <summary>
        /// Initializes a new instance of the <see cref="API"/> class.
        /// </summary>
        /// <param name="_projectName">The name of the current project.</param>
        public API(string _projectName)
        {
            projectName = _projectName;
            var tmp_ProjectInfo = TryAcquireProjectInfo();
            if (!string.IsNullOrEmpty(tmp_ProjectInfo))
            {
                GetProcessId = tmp_ProjectInfo.Split(",")[0]
                    .Split(":")[1]
                    .Replace("\"", "");
            }

            processHolder = new GameObject($"PID:{GetProcessId}");
            processHolder.AddComponent<ProcessIdComponent>().InitProcessId(GetProcessId);
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.AddNewProcess),
                new ProcessesArgs()
                {
                    ProjectName = _projectName,
                    ProcessId = GetProcessId
                });
        }

        #region Project or Apps

        /// <summary>
        /// Retrieves all active processes for the current application.
        /// </summary>
        /// <returns>A dictionary where keys are project names and values are lists of process IDs.</returns>
        public Dictionary<string, List<string>> TryAcquireProcesses()
        {
            var tmp_Result = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                nameof(ActionParameterDataType.TryAcquireProjectInfo), new BaseNotificationData());
            try
            {
                if (tmp_Result.Count <= 0) return new Dictionary<string, List<string>>();
                if (tmp_Result[0] is Dictionary<string, List<string>> tmp_AllProcesses)
                {
                    return tmp_AllProcesses;
                }

                return new Dictionary<string, List<string>>();
            }
            catch (Exception)
            {
                return new Dictionary<string, List<string>>();
            }
        }

        /// <summary>
        /// Retrieves current AR Experience project information.
        /// </summary>
        /// <returns>Project information as a string, typically in JSON format.</returns>
        public string TryAcquireProjectInfo()
        {
            var tmp_Result = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                nameof(ActionParameterDataType.TryAcquireProjectInfo), new BaseNotificationData());
            try
            {
                return tmp_Result[0] as string;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Retrieves the temporary cache path for the current application.
        /// </summary>
        /// <returns>The temporary cache path as a string.</returns>
        public string TryAcquireXRMODEngineCachePath()
        {
            var tmp_Result = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                nameof(ActionParameterDataType.TryAcquireTemporaryCachePath), new BaseNotificationData());
            try
            {
                return tmp_Result[0] as string;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }


        /// <summary>
        /// Retrieves the current SDK type.
        /// </summary>
        /// <returns>The current SDK type as a string.</returns>
        public string TryAcquireSdkType()
        {
            var tmp_Result = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                nameof(ActionParameterDataType.TryAcquireSdkType), new BaseNotificationData());
            try
            {
                return tmp_Result[0] as string;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// Retrieves custom configuration data from the SDK (available from SDK 2.0.0-pre.12).
        /// </summary>
        /// <returns>Configuration data as a string, or null if not available.</returns>
        public string TryAcquireLaunchConfig()
        {
            var tmp_Result = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                nameof(ActionParameterDataType.TryAcquireCustomConfig), new BaseNotificationData());
            try
            {
                return tmp_Result[0] as string;
            }
            catch (Exception)
            {
                return null;
            }
        }


        /// <summary>
        /// Changes the current experience space type.
        /// </summary>
        /// <param name="_spaceType">The new space type. See <see cref="SpaceType"/>.</param>
        /// <param name="_dimensions">Optional: The dimensions for the new space. Defaults to <see cref="Vector3.one"/>.</param>
        /// <param name="_boundPosition">Optional: The bound position for the new space. Defaults to <see cref="Vector3.up"/> * 0.5f.</param>
        /// <param name="_cullingMask">Optional: An array of layer names to be used for culling. If null, no culling mask is applied.</param>
        /// <param name="_boundResizeMode">Optional: The bound resize mode. Defaults to <see cref="BoundResizeMode.None"/>.</param>
        public void ChangeSpaceType(SpaceType _spaceType, Vector3? _dimensions = null, Vector3? _boundPosition = null,
            string[] _cullingMask = null,
            BoundResizeMode _boundResizeMode = BoundResizeMode.None)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.SwitchSpaceType),
                new SpaceTypeActionArgs()
                {
                    ProcessId = GetProcessId,
                    ProjectName = projectName,
                    SpaceTypeValue = _spaceType,
                    BoundResizeMode = _boundResizeMode,
                    BoundPosition = _boundPosition ?? Vector3.up * 0.5f,
                    Dimensions = _dimensions ?? _DEFAULT_DIMENSIONS,
                    CullingMask = _cullingMask == null ? null : LayerMask.GetMask(_cullingMask)
                });
        }

        #endregion

        #region UGUI

        /// <summary>
        /// Determines whether a UGUI object is currently being touched by the pointer.
        /// This helps prevent raycast penetration when interacting with UI elements.
        /// </summary>
        /// <example>
        /// <code>
        /// if (api.IsPointerOverUi()) {
        ///     // Do not perform in-world raycast
        ///     return;
        /// }
        /// </code>
        /// </example>
        /// <returns>True if a UGUI object is touched, otherwise False.</returns>
        public bool IsPointerOverUi()
        {
            var tmp_CurrentEventSystem = EventSystem.current;
            if (!tmp_CurrentEventSystem) return false;

            PointerEventData tmp_EventData = new PointerEventData(EventSystem.current)
            {
                pressPosition = Input.mousePosition,
                position = Input.mousePosition
            };

            List<RaycastResult> tmp_List = new List<RaycastResult>();
            if (null == graphicRaycaster)
                graphicRaycaster = Object.FindFirstObjectByType<GraphicRaycaster>();
            
            graphicRaycaster?.Raycast(tmp_EventData, tmp_List);
            return tmp_List.Count > 0;
        }

        #endregion

        #region KV

        /// <summary>
        /// Stores temporary data locally using PlayerPrefs.
        /// </summary>
        /// <param name="_key">The unique key for the data.</param>
        /// <param name="_value">The string data to be saved.</param>
        public void SaveKeyAndValue(string _key, string _value)
        {
            PlayerPrefs.SetString(projectName + _key, _value);
        }

        /// <summary>
        /// Reads data temporarily stored on the device using PlayerPrefs.
        /// </summary>
        /// <param name="_key">The unique key for the data.</param>
        /// <returns>The queried data as a string.</returns>
        public string GetValueByKey(string _key)
        {
            return PlayerPrefs.GetString(projectName + _key);
        }

        /// <summary>
        /// Removes data and its associated key from local temporary storage (PlayerPrefs).
        /// </summary>
        /// <param name="_key">The unique key of the data to be removed.</param>
        public void RemoveKeyAndValue(string _key)
        {
            PlayerPrefs.DeleteKey(_key);
        }

        #endregion

        #region Asset loader

        /// <summary>
        /// Asynchronously loads all assets of a specified type from the current package.
        /// </summary>
        /// <example>
        /// <code>
        /// var textures = await api.LoadAssetsAsync&lt;Texture2D&gt;();
        /// </code>
        /// </example>
        /// <typeparam name="T">The Unity Asset type to load.</typeparam>
        /// <returns>An array of the loaded assets.</returns>
        public async Task<T[]> LoadAssetsAsync<T>() where T : Object
        {
            return await BasePackageLoaderUtility.LoadAssetsFromPackage<T>(projectName);
        }


        /// <summary>
        /// Asynchronously loads specified Unity assets of a given type from the current package.
        /// </summary>
        /// <param name="_assetNames">An array of asset names to load.</param>
        /// <typeparam name="T">The Unity Asset type to load.</typeparam>
        /// <returns>An array of the loaded assets.</returns>
        public async Task<T[]> LoadAssetsAsync<T>(string[] _assetNames) where T : Object
        {
            return await BasePackageLoaderUtility.LoadAssetsFromPackage<T>(projectName, _assetNames);
        }

        /// <summary>
        /// Asynchronously loads a single Unity asset of a specified type from the current package.
        /// </summary>
        /// <param name="_wannaLoadedAssetName">The name of the asset to load.</param>
        /// <typeparam name="T">The Unity Asset type to load.</typeparam>
        /// <returns>The loaded asset.</returns>
        public async Task<T> LoadAssetAsync<T>(string _wannaLoadedAssetName) where T : Object
        {
            return await BasePackageLoaderUtility.LoadAssetFromPackage<T>(projectName, _wannaLoadedAssetName);
        }


        /// <summary>
        /// Asynchronously loads and adds a new Unity scene from the package.
        /// </summary>
        /// <example>
        /// <code>
        /// await api.LoadUnityScene("MainGameScene");
        /// </code>
        /// </example>
        /// <param name="_sceneName">The Unity scene asset name as defined in the PackageTools Content tab.</param>
        /// <exception cref="UnityException">Thrown if the scene fails to load.</exception>
        public async Task LoadUnityScene(string _sceneName)
        {
            try
            {
                string tmp_ProjectNameLower = projectName.ToLower();
                string tmp_DestinationPath =
#if UNITY_EDITOR || UNITY_STANDALONE_OSX || UNITY_STANDALONE_WIN
                    Application.dataPath.Replace("Assets",
                        $"ServerData/{RuntimePlatformHelper.GetPlatformName().ToLower()}/{tmp_ProjectNameLower}/{tmp_ProjectNameLower}_Scene.arexperience");

#else
                    $"{Application.temporaryCachePath}/{tmp_ProjectNameLower}/{tmp_ProjectNameLower}_Scene.arexperience";
#endif

                await BasePackageLoaderUtility.LoadSceneFromBundle(tmp_DestinationPath, _sceneName);

#if UNITY_ANDROID && UNITY_EDITOR
                var tmp_AllRenderers = Object.FindObjectsByType<Renderer>(FindObjectsSortMode.None);
                foreach (Renderer tmp_Renderer in tmp_AllRenderers)
                {
                    foreach (Material tmp_Mat in tmp_Renderer.materials)
                    {
                        tmp_Mat.shader = Shader.Find(tmp_Mat.shader.name);
                    }
                }

                if (RenderSettings.skybox)
                {
                    RenderSettings.skybox.shader = Shader.Find(RenderSettings.skybox.shader.name);
                }

                DynamicGI.UpdateEnvironment();
#endif
            }
            catch (Exception e)
            {
                throw new UnityException("Failed to load asset: " + _sceneName, e);
            }
        }


        /// <summary>
        /// Attempts to acquire and instantiate a GLTF model from a network URL.
        /// </summary>
        /// <param name="_url">The URL of the GLTF file.</param>
        /// <param name="_result">A callback action that is invoked with the loaded GameObject.</param>
        public void TryAcquireNetworkMesh(string _url, Action<GameObject> _result = null)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.TryAcquireNetworkMesh), new BaseNotificationData()
                {
                    BaseData = _url,
                    NotificationActWithData = _resultData =>
                    {
                        if (_resultData is GameObject tmp_GameObject)
                        {
                            _result?.Invoke(tmp_GameObject);
                        }
                    }
                });
        }


        /// <summary>
        /// Downloads a GLTF model from a URL and caches it locally without instantiating it.
        /// </summary>
        /// <param name="_url">The URL of the GLTF file.</param>
        /// <param name="_result">A callback action that is invoked with the local path of the downloaded model.</param>
        public void DownloadNetworkMesh(string _url, Action<string> _result = null)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.DownloadMesh), new BaseNotificationData()
                {
                    BaseData = _url,
                    NotificationActWithData = _resultData =>
                    {
                        if (_resultData is string tmp_LocalPath)
                        {
                            _result?.Invoke(tmp_LocalPath);
                        }
                    }
                });
        }

        /// <summary>
        /// Releases all assets associated with a specified project.
        /// </summary>
        /// <param name="_projectName">The name of the project whose assets will be released. If null or empty, the current project's assets are released.</param>
        public void ReleaseProject(string _projectName = null)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.ReleaseProject),
                new ProcessesArgs()
                {
                    ProjectName = string.IsNullOrEmpty(_projectName) ? projectName : _projectName,
                    ProcessId = GetProcessId
                });
        }

        #endregion

        #region Device

        /// <summary>
        /// Retrieves detailed information about the current device.
        /// </summary>
        /// <returns>A JSON string containing various device specifications.</returns>
        public string GetDeviceInfo()
        {
            DeviceInfo tmp_DeviceInfo = new DeviceInfo()
            {
                deviceModel = SystemInfo.deviceModel,
                deviceName = SystemInfo.deviceName,
                deviceUniqueIdentifier = SystemInfo.deviceUniqueIdentifier,
                graphicsDeviceName = SystemInfo.graphicsDeviceName,
                graphicsDeviceType = SystemInfo.deviceType.ToString(),
                graphicsDeviceVendor = SystemInfo.graphicsDeviceVendor,
                graphicsDeviceVersion = SystemInfo.graphicsDeviceVersion,
                graphicsDeviceID = SystemInfo.graphicsDeviceID,
                graphicsDeviceVendorID = SystemInfo.graphicsDeviceVendorID,
                graphicsMemorySize = SystemInfo.graphicsMemorySize,
                graphicsMultiThreaded = SystemInfo.graphicsMultiThreaded,
                graphicsShaderLevel = SystemInfo.graphicsShaderLevel,
                maxTextureSize = SystemInfo.maxTextureSize,
                npotSupport = SystemInfo.npotSupport.ToString(),
                operatingSystem = SystemInfo.operatingSystem,
                processorCount = SystemInfo.processorCount,
                processorFrequency = SystemInfo.processorFrequency,
                processorType = SystemInfo.processorType,
                supportedRenderTargetCount = SystemInfo.supportedRenderTargetCount,
                supports2DArrayTextures = SystemInfo.supports2DArrayTextures,
                supports3DTextures = SystemInfo.supports3DTextures,
                supportsAccelerometer = SystemInfo.supportsAccelerometer,
                supportsAudio = SystemInfo.supportsAudio,
                supportsComputeShaders = SystemInfo.supportsComputeShaders,
                supportsGyroscope = SystemInfo.supportsGyroscope,
                supportsImageEffects = true,
                supportsLocationService = SystemInfo.supportsLocationService,
                supportsMotionVectors = SystemInfo.supportsMotionVectors,
                supportsVibration = SystemInfo.supportsVibration,
                systemMemorySize = SystemInfo.systemMemorySize,
                unsupportedIdentifier = SystemInfo.unsupportedIdentifier
            };
            return JsonUtility.ToJson(tmp_DeviceInfo);
        }

        /// <summary>
        /// Retrieves the system language of the device.
        /// </summary>
        /// <returns>The system language as a string.</returns>
        public string GetSystemLanguage()
        {
            return Application.systemLanguage.ToString();
        }


        /// <summary>
        /// Checks if the current content is running on a specific platform type.
        /// </summary>
        /// <param name="_platform">The platform category to detect.</param>
        /// <returns>True if it is the specified platform, otherwise False.</returns>
        public bool IsPlatform(PlatformType _platform)
        {
            return RuntimePlatformHelper.IsPlatform(_platform);
        }

        /// <summary>
        /// Sets the screen orientation of the device.
        /// </summary>
        /// <param name="_orientation">The desired screen orientation.</param>
        public void SetScreenOrientation(ScreenOrientation _orientation)
        {
            Screen.orientation = _orientation;
        }

        #endregion
        
        #region XR

        #region Handheld AR API

        /// <summary>
        /// Resizes the AR world scale. This only works in Handheld AR.
        /// </summary>
        /// <param name="_worldScale">The new world scale value.</param>
        public void ResizeARWorldScale(float _worldScale)
        {
#if (UNITY_IOS || UNITY_ANDROID) && HANDHELD_ARMODULE_INSTALL
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.ResizeARWorldScale),
                new ResizeARWorldScaleArgs() {WorldScale = _worldScale});
#endif
        }

        /// <summary>
        /// Controls the life cycle of AR algorithms, allowing multiple algorithms to be mixed. This only works in Handheld AR.
        /// </summary>
        /// <param name="_data">The <see cref="ARAlgorithmArgs"/> data controlling the algorithm's life cycle.</param>
        public void ChangeARAlgorithmLife(ARAlgorithmArgs _data)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.ARAlgorithmLifeCTRL),
                _data);
        }

        /// <summary>
        /// Moves and orients the ARSessionOrigin such that the content appears at the specified raycast hit position. This does not move the content itself. This only works in Handheld AR.
        /// </summary>
        /// <param name="_contentTrans">The transform of the content to be positioned.</param>
        /// <param name="_position">The world position where the content should appear.</param>
        /// <param name="_rotation">The world rotation for the content to appear.</param>
        public void MakeContentAppearAt(Transform _contentTrans, Vector3 _position, Quaternion _rotation)
        {
#if (UNITY_IOS || UNITY_ANDROID) && HANDHELD_ARMODULE_INSTALL
            MakeContentAppearAtArgs tmp_NotificationData = new MakeContentAppearAtArgs()
            {
                Position = _position,
                Rotation = _rotation,
                ContentTrans = _contentTrans
            };

            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.MakeContentAppearAt),
                tmp_NotificationData);
#endif
        }

        /// <summary>
        /// Casts a ray from a point in screen space against trackables (e.g., detected planes). This only works in Handheld AR.
        /// </summary>
        /// <example>
        /// <code>
        /// api.ARRaycast(Input.mousePosition, TrackableTypeEnum.PlaneWithinPolygon, (pose) => {
        ///     Instantiate(prefab, pose.position, pose.rotation);
        /// });
        /// </code>
        /// </example>
        /// <param name="_inputPosition">The input screen point for the raycast.</param>
        /// <param name="_trackableType">The type of trackables to hit. See <see cref="TrackableTypeEnum"/>.</param>
        /// <param name="_callback">A callback action that is invoked with the <see cref="Pose"/> result of the raycast.</param>
        public void ARRaycast(Vector3 _inputPosition,
            TrackableTypeEnum _trackableType = TrackableTypeEnum.PlaneWithinPolygon,
            Action<Pose> _callback = null)
        {
#if (UNITY_IOS || UNITY_ANDROID) && HANDHELD_ARMODULE_INSTALL
            ARRaycastArgs tmp_NotificationData = new ARRaycastArgs();
            tmp_NotificationData.ScreenPoint = _inputPosition;
            tmp_NotificationData.TrackableType = _trackableType;
            tmp_NotificationData.NotificationActWithData = _result =>
            {
                if (_result is not Pose tmp_Pose) return;
                _callback?.Invoke(tmp_Pose);
            };
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.ARRaycast),
                tmp_NotificationData);
#endif
        }

        /// <summary>
        /// Retrieves the current AR frame as a Texture2D. This only works in Handheld AR.
        /// </summary>
        /// <param name="_data">Parameters for acquiring the current frame. See <see cref="TryAcquireCurrentFrameArgs"/>.</param>
        /// <returns>The current AR frame as a Texture2D, or null if not available.</returns>
        public Texture2D TryAcquireCurrentFrame(TryAcquireCurrentFrameArgs _data)
        {
#if (UNITY_IOS || UNITY_ANDROID) && HANDHELD_ARMODULE_INSTALL
            var tmp_Objects = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                nameof(ActionParameterDataType.TryAcquireCurrentFrame), _data);
            if (tmp_Objects == null || tmp_Objects.Count == 0) return null;
            if (tmp_Objects[0] is Texture2D tmp_Texture2D)
                return tmp_Texture2D;
#endif

            return null;
        }

        /// <summary>
        /// Retrieves the AR occlusion frame as a Texture2D. This only works in iOS Handheld AR.
        /// </summary>
        /// <param name="_data">Parameters for acquiring the AR occlusion frame. See <see cref="AROcclusionArgs"/>.</param>
        /// <returns>The AR occlusion frame as a Texture2D, or null if not available.</returns>
        public Texture2D TryAcquireAROcclusionFrame(AROcclusionArgs _data)
        {
#if (UNITY_IOS || UNITY_ANDROID) && HANDHELD_ARMODULE_INSTALL
            var tmp_Objects =
                ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                    nameof(ActionParameterDataType.TryAcquireAROcclusionFrame), _data);
            if (tmp_Objects == null || tmp_Objects.Count == 0) return null;
            if (tmp_Objects[0] is Texture2D tmp_Texture2D)
                return tmp_Texture2D;
#endif
            return null;
        }

        /// <summary>
        /// Retrieves the light estimate value from the AR environment. This only works in Handheld AR.
        /// </summary>
        /// <returns>A <see cref="Light"/> component representing the estimated light, or null if not available.</returns>
        public Light TryAcquireLightEstimateValue()
        {
#if (UNITY_IOS || UNITY_ANDROID) && HANDHELD_ARMODULE_INSTALL
            var tmp_Objects = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                nameof(ActionParameterDataType.TryAcquireLightEstimateValue), null);
            if (tmp_Objects == null || tmp_Objects.Count == 0) return null;
            if (tmp_Objects[0] is Light tmp_Light)
                return tmp_Light;
#endif
            return null;
        }

        /// <summary>
        /// Checks whether the current device supports ARKit or ARCore. This only works in Handheld AR.
        /// </summary>
        /// <returns>True if AR is available, otherwise False.</returns>
        public bool CheckARAvailability()
        {
#if (UNITY_IOS || UNITY_ANDROID) && HANDHELD_ARMODULE_INSTALL
            var tmp_Objects =
                ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                    nameof(ActionParameterDataType.CheckARAvailability), null);
            if (tmp_Objects == null || tmp_Objects.Count == 0) return false;
            if (tmp_Objects[0] is string tmp_Availability)
                return tmp_Availability.Equals("True");
#endif
            return false;
        }

        /// <summary>
        /// Adds new image targets for runtime tracking. This only works in Handheld AR.
        /// </summary>
        /// <param name="_imageData">A list of image data for the track targets. See <see cref="DynamicLibraryArgs.ImageData"/>.</param>
        /// <param name="_callback">An action that is invoked when all processes are completed.</param>
        public void AddNewImageForTracking(List<DynamicLibraryArgs.ImageData> _imageData,
            Action _callback = null)
        {
#if (UNITY_IOS || UNITY_ANDROID) && HANDHELD_ARMODULE_INSTALL
            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.AddNewImageForTracking), new DynamicLibraryArgs()
                {
                    Images = _imageData,
                    NotificationAct = _callback
                });
#endif
        }

        /// <summary>
        /// Checks if a specific AR feature is supported on the current device. This only works in Handheld AR.
        /// </summary>
        /// <param name="_featureName">The name of the AR feature to check.</param>
        /// <returns>True if the feature is available, otherwise False.</returns>
        public bool CheckFeatureAvailability(string _featureName)
        {
#if (UNITY_IOS || UNITY_ANDROID) && HANDHELD_ARMODULE_INSTALL
            var tmp_BaseData = new BaseNotificationData {BaseData = _featureName};
            var tmp_Results =
                ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                    nameof(ActionParameterDataType.CheckARFeaturesAvailability), tmp_BaseData);
            if (tmp_Results == null || tmp_Results.Count == 0) return false;
            if (tmp_Results[0] is string tmp_Availability)
                return tmp_Availability.Equals("True");
#endif
            return true;
        }

        #endregion


        /// <summary>
        /// Retrieves the current SDK version.
        /// </summary>
        /// <returns>The SDK version as a string (e.g., "1.0.0"), or null if not available.</returns>
        public string TryAcquireSDKVersion()
        {
            var tmp_VersionObjects = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                nameof(ActionParameterDataType.TryAcquireSDKVersion),
                null);
            if (tmp_VersionObjects != null && tmp_VersionObjects.Count > 0) return tmp_VersionObjects[0] as string;
            return null;
        }


        /// <summary>
        /// Exits the XR Mod application. This only works on Handheld AR.
        /// </summary>
        public void Exit()
        {
#if HANDHELD_ARMODULE_INSTALL
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.Exit), null);
#endif
        }

        /// <summary>
        /// Retrieves all <see cref="XRMODAnchor"/> components currently in the runtime,
        /// regardless of their active state.
        /// </summary>
        /// <returns>An array of all found <see cref="XRMODAnchor"/> components.</returns>
        public XRMODAnchor[] GetAllAnchors() =>
            Object.FindObjectsByType<XRMODAnchor>(FindObjectsInactive.Include, FindObjectsSortMode.InstanceID);

        /// <summary>
        /// Creates an anchor and places a GameObject at its position.
        /// </summary>
        /// <param name="_createAnchorArgs">The data required to create the anchor. See <see cref="CreateAnchorArgs"/>.</param>
        public void CreateAnchor(CreateAnchorArgs _createAnchorArgs)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.CreateAnchor),
                _createAnchorArgs);
        }


        /// <summary>
        /// Removes a specified anchor by its unique ID.
        /// </summary>
        /// <param name="_anchorId">The <see cref="Guid"/> of the anchor to destroy.</param>
        public void DestroyAnchor(Guid _anchorId)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.DestroyAnchor),
                new DestroyAnchorArgs {AnchorSessionId = _anchorId});
        }

        /// <summary>
        /// Initiates the capture of current environment data.
        /// </summary>
        public void CaptureEnvironment()
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(CaptureEnvironment),
                new BaseNotificationData());
        }

        /// <summary>
        /// Saves all runtime environment maps to disk.
        /// </summary>
        /// <param name="_mapName">The name for the environment map (only supported in Handheld AR).</param>
        public void SaveEnvironmentMapping(string _mapName = default)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.SaveEnvironmentMap),
                new BaseNotificationData()
                {
                    BaseData = _mapName
                });
        }

        /// <summary>
        /// Loads an environment map from disk.
        /// </summary>
        /// <param name="_mapName">The name of the environment map to load (only supported in Handheld AR).</param>
        public void LoadEnvironmentMapping(string _mapName = default)
        {
            var tmp_BaseData = new LoadEnvironmentParameters
            {
                MapName = _mapName,
                ProcessId = GetProcessId
            };

            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.LoadEnvironmentMap),
                new BaseNotificationData()
                {
                    BaseData = JsonUtility.ToJson(tmp_BaseData),
                });
        }

        /// <summary>
        /// Deletes an environment map from disk.
        /// </summary>
        /// <param name="_mapName">The name of the environment map to delete (only supported in Handheld AR - iOS platform).</param>
        public void DeleteEnvironmentMapping(string _mapName = default)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.DeleteEnvironmentMap),
                new BaseNotificationData()
                {
                    BaseData = _mapName
                });
        }


        /// <summary>
        /// Retrieves the current experience <see cref="SpaceType"/>.
        /// </summary>
        /// <returns>The current <see cref="SpaceType"/>, or <see cref="SpaceType.ExclusiveSpace"/> if not determined.</returns>
        public SpaceType GetCurrentExperienceSpaceType()
        {
            var tmp_Result = ActionNotificationCenter.DefaultCenter
                .PostNotificationWithResult(nameof(ActionParameterDataType.GetSpaceType), null).FirstOrDefault();
            return tmp_Result == null ? SpaceType.ExclusiveSpace : Enum.Parse<SpaceType>(tmp_Result.ToString());
        }

        #endregion

        #region Native API

        /// <summary>
        /// Opens a URL using the application's built-in browser.
        /// </summary>
        /// <param name="_data">The data containing the URL and other browser parameters. See <see cref="OpenInBuiltInBrowserArgs"/>.</param>
        public void OpenBuiltInBrowser(OpenInBuiltInBrowserArgs _data)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.OpenBuiltInBrowser), _data);
        }


        /// <summary>
        /// Attempts to acquire application information.
        /// </summary>
        /// <param name="_data">The arguments specifying the type of app information to acquire. See <see cref="TryAcquireAppInfoArgs"/>.</param>
        public void TryAcquireAppInfo(TryAcquireAppInfoArgs _data)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(
                nameof(ActionParameterDataType.TryAcquireAppInfo), _data);
        }


        /// <summary>
        /// Sends a message to the SDK. The message can be a string or JSON.
        /// The `ReceivedMessage` method on the SDK side will receive this message (available from SDK 2.0.0-pre.12).
        /// </summary>
        /// <param name="_data">The message data to send.</param>
        public void SendMessageToSDK(string _data)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.SendMessageToSDK),
                new BaseNotificationData()
                {
                    BaseData = _data,
                    ActionName = nameof(SendMessageToSDK)
                });
        }

        #endregion

        #region Graphices

        /// <summary>
        /// Overrides the current render pipeline at runtime.
        /// </summary>
        /// <param name="_pipelineAsset">The Universal Render Pipeline Asset to apply.</param>
        [Obsolete("Deprecated. Use QualitySettings.renderPipeline instead")]
        public void OverrideRenderPipelineAtRuntime(UniversalRenderPipelineAsset _pipelineAsset)
        {
            if (QualitySettings.renderPipeline == null) return;
            QualitySettings.SetQualityLevel(4, true);
            QualitySettings.renderPipeline = _pipelineAsset;
        }

        private static readonly int _SKYBOX_CUBEMAP_TEX = Shader.PropertyToID("_Tex");

        /// <summary>
        /// Overrides the scene's skybox with a custom material.
        /// This also updates reflection probes and the global environment.
        /// </summary>
        /// <param name="_material">The material to use for the skybox.</param>
        public void OverrideSkyBox(Material _material)
        {
            RenderSettings.skybox = _material;
            RenderSettings.defaultReflectionMode = DefaultReflectionMode.Custom;
            if (_material.HasProperty(_SKYBOX_CUBEMAP_TEX))
            {
                var tmp_Texture = _material.GetTexture(_SKYBOX_CUBEMAP_TEX);

#if UNITY_2022_1_OR_NEWER
                if (tmp_Texture)
                    RenderSettings.customReflectionTexture = tmp_Texture;
#else
            if (tmp_Texture)
                RenderSettings.customReflection = tmp_Texture;
#endif
            }

#if UNITY_6000_0_OR_NEWER
            var tmp_ReflectionProbes = Object.FindObjectsByType<ReflectionProbe>(FindObjectsSortMode.None);
#else
            var tmp_ReflectionProbes = Object.FindObjectsOfType<ReflectionProbe>();
#endif
            foreach (ReflectionProbe tmp_ReflectionProbe in tmp_ReflectionProbes)
            {
                tmp_ReflectionProbe.RenderProbe();
            }

            DynamicGI.UpdateEnvironment();
        }

        #endregion
    }
}
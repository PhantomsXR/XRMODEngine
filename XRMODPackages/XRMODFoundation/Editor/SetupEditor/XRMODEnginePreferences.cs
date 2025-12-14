// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XRMODEngineSettings.Editor.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using Phantom.XRMOD.Core.Runtime;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UIElements;
using Phantom.XRMOD.Core.Runtime.Enums;
using UnityEngine.Assertions;

namespace Phantom.XRMOD.Setup.Editor
{
    public class XRMODEnginePreferences
    {
        [SettingsProvider]
        private static SettingsProvider ProjectHelperSettingsProvider()
        {
            return new SettingsProvider("Project/PhantomsXR/XRMODEngineSDKSettings", SettingsScope.Project)
            {
                label = "XRMOD Setup",
                keywords = new HashSet<string>()
                {
                    "XRMOD",
                    "XRMOD Settings",
                    "XRMOD Setup"
                },
                activateHandler = (searchContext, rootElement) =>
                {
                    rootElement.Add(CreateSettingsUI());
                },
                deactivateHandler = () =>
                {
                    DisposeSerializedObject();
                    ClearDrawerCache();
                }
            };
        }

        private static void DisposeSerializedObject()
        {
            if (_SERIALIZED_OBJECT != null)
            {
                _SERIALIZED_OBJECT.Dispose();
                _SERIALIZED_OBJECT = null;
            }
        }
        
        internal static XRMODSetupConfigure _XRMOD_ENGINE_SETTINGS;
        internal static SDKDeviceType _SELECTED_DEVICE;
        internal static Core.Runtime.EnvironmentType _SELECTED_ENGINE_PLATFORM;
        private static int _TOOLBAR_INDEX = 0;
        private static int _TMP_CACHE_TOOLBAR_INDEX = -1;
        private static XRMODEnginePlatformSettings _XRMOD_ENGINE_PLATFORM_SETTINGS;
        private static SerializedObject _SERIALIZED_OBJECT;

        private static readonly List<ISettingsDrawer> _ENVIRONMENT_SETTINGS_DRAWER = new List<ISettingsDrawer>()
        {
            new AndroidMiniSDKVersionDrawer(),
            new ApiCompatibilityDrawer(),
            new ColorSpaceValidationDrawer(),
            new GameObjectTagsLayersDrawer(),
            new InputSystemDrawer(),
            new RuntimeSceneDrawer(),
            new SDKInformationFixerDrawer(),
            new XRSystemActiveDrawer(),
            new ShadersValidationDrawer(),
            new ScriptingBackendValidationDrawer(), 
        };

        internal static int GetToolbarIndex
        {
            get => EditorPrefs.GetInt($"{GetProjectName()}_{nameof(_TOOLBAR_INDEX)}", 0);
            set
            {
                if (value == _TOOLBAR_INDEX) return;
                _TOOLBAR_INDEX = value;
                EditorPrefs.SetInt($"{GetProjectName()}_{nameof(_TOOLBAR_INDEX)}", value);
            }
        }

        static string GetProjectName()
        {
            string[] tmp_PathSplit = Application.dataPath.Split('/');
            string tmp_ProjectName = tmp_PathSplit[^2];
            return tmp_ProjectName;
        }

        private static VisualElement CreateSettingsUI()
        {
            var tmp_Root = new VisualElement();
            tmp_Root.AddToClassList("root");
            
            // Initial Check
            if (_XRMOD_ENGINE_SETTINGS == null)
            {
                _XRMOD_ENGINE_SETTINGS = AssetDatabase.LoadAssetAtPath<XRMODSetupConfigure>(ConstKey.CONST_SETTING_CONFIGURE_FILE_PATH);
                if (_XRMOD_ENGINE_SETTINGS)
                {
                    _XRMOD_ENGINE_SETTINGS.OnValidate();
                }
                else
                {
                    var tmp_HelpBox = new HelpBox("XR-MOD Engine SDK Settings file not found, Click bottom button to create it!", HelpBoxMessageType.Error);
                    tmp_Root.Add(tmp_HelpBox);
                    var tmp_InitBtn = new Button(() =>
                    {
                        XRMODEngineInitializer.CreateProjectSettings();
                        tmp_Root.Clear();
                        tmp_Root.Add(new Label("Please close and reopen this window to refresh."));
                    }) {text = "Initialize Settings"};
                    tmp_Root.Add(tmp_InitBtn);
                    return tmp_Root;
                }
            }

            // Load UXML
            var tmp_UxmlPath = System.IO.Path.Combine(ConstKey.CONST_PACKAGE_PATH, "Editor/SetupEditor/UI/SetupEditor.uxml");
            var tmp_VisualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>(tmp_UxmlPath);
            if (tmp_VisualTree == null)
            {
                tmp_Root.Add(new Label($"Error: UXML not found at {tmp_UxmlPath}"));
                return tmp_Root;
            }
            tmp_VisualTree.CloneTree(tmp_Root);

            // Bind Header Apply Button
            var tmp_ApplyBtn = tmp_Root.Q<Button>("ApplyButton");
            if (tmp_ApplyBtn != null)
            {
                tmp_ApplyBtn.clicked += ApplyConfigures;
            }

            // Bind Environment Settings
            var tmp_EnvField = tmp_Root.Q<EnumField>("EnvironmentType");
            if (tmp_EnvField != null)
            {
                tmp_EnvField.Init(_XRMOD_ENGINE_SETTINGS.SDKInformation.environmentType);
                tmp_EnvField.RegisterValueChangedCallback(evt =>
                {
                    _XRMOD_ENGINE_SETTINGS.SDKInformation.environmentType = (EnvironmentType) evt.newValue;
                    EditorUtility.SetDirty(_XRMOD_ENGINE_SETTINGS.SDKInformation);
                });
            }

            // Bind SDK Settings
            var tmp_DeviceField = tmp_Root.Q<EnumField>("DeviceType");
            var tmp_PlatformContainer = tmp_Root.Q<VisualElement>("PlatformSettingsContainer");
            
            if (tmp_DeviceField != null)
            {
                tmp_DeviceField.Init((SDKDeviceType) GetToolbarIndex);
                tmp_DeviceField.RegisterValueChangedCallback(evt =>
                {
                    _SELECTED_DEVICE = (SDKDeviceType) evt.newValue;
                    GetToolbarIndex = (int) _SELECTED_DEVICE;
                    RebuildPlatformSettings(tmp_PlatformContainer);
                });
            }
            
            // Initial Build Platform Settings
            _SELECTED_DEVICE = (SDKDeviceType) GetToolbarIndex; 
            RebuildPlatformSettings(tmp_PlatformContainer);

            // Bind Project Environment (Drawers)
            var tmp_DrawersContainer = tmp_Root.Q<VisualElement>("DrawersContainer");
            var tmp_SectionTitle = tmp_Root.Q<Label>("ProjectEnvironmentTitle");
            if (tmp_SectionTitle != null) tmp_SectionTitle.text = "XRMOD Configuration";

            var tmp_FixAllBtn = tmp_Root.Q<Button>("FixAllButton");
            if (tmp_FixAllBtn != null)
            {
                tmp_FixAllBtn.clicked += () =>
                {
                    foreach (var tmp_Drawer in _ENVIRONMENT_SETTINGS_DRAWER)
                    {
                        if (tmp_Drawer is IFixer tmp_Fixer)
                        {
                            tmp_Fixer.DoFix();
                        }
                    }
                    RebuildDrawers(tmp_DrawersContainer);
                };
            }

            if (tmp_DrawersContainer != null)
            {
                // Simulation Toggle (Special Case)
#if HANDHELD_ARMODULE_INSTALL
                // Need a wrapper for simulation to match the style? 
                // Creating a simplified toggle row
                var tmp_SimRow = new VisualElement();
                tmp_SimRow.AddToClassList("validation-row");
                
                var tmp_SimContent = new VisualElement();
                tmp_SimContent.AddToClassList("validation-content");
                tmp_SimRow.Add(tmp_SimContent);

                var tmp_SimToggle = new Toggle("Simulation") { value = _XRMOD_ENGINE_SETTINGS.Simulation };
                tmp_SimToggle.RegisterValueChangedCallback(evt =>
                {
                    _XRMOD_ENGINE_SETTINGS.Simulation = evt.newValue;
                    EditorUtility.SetDirty(_XRMOD_ENGINE_SETTINGS);
                    RebuildDrawers(tmp_DrawersContainer);
                });
                tmp_SimContent.Add(tmp_SimToggle);
                
#endif
                RebuildDrawers(tmp_DrawersContainer);
            }

            return tmp_Root;
        }

        private static readonly Dictionary<ISettingsDrawer, VisualElement> _DRAWER_UI_CACHE = new Dictionary<ISettingsDrawer, VisualElement>();

        private static void ClearDrawerCache()
        {
            _DRAWER_UI_CACHE.Clear();
        }

        public static void AutoCreateConfigureFile(string _DeviceSDKType)
        {
            XRMODEngineInitializer.CreateProjectSettings();

            _XRMOD_ENGINE_SETTINGS =
                AssetDatabase.LoadAssetAtPath<XRMODSetupConfigure>(ConstKey.CONST_SETTING_CONFIGURE_FILE_PATH);

            if (_XRMOD_ENGINE_SETTINGS == null) return;

            bool tmp_Parsed = Enum.TryParse(_DeviceSDKType, out _SELECTED_DEVICE);
            if (tmp_Parsed)
            {
                GetToolbarIndex = (int) _SELECTED_DEVICE;
                _TMP_CACHE_TOOLBAR_INDEX = (int) _SELECTED_DEVICE;
                var tmp_PlatformSuffix = GetToolbarIndex == 1 ? $"_{Extensions.GetHandheldARPlatform}" : string.Empty;
                _XRMOD_ENGINE_PLATFORM_SETTINGS =
                    _XRMOD_ENGINE_SETTINGS.GetPlatformSettings(GetToolbarIndex, $"UnityStandalone{tmp_PlatformSuffix}");
                if (_XRMOD_ENGINE_PLATFORM_SETTINGS == null)
                    XRMODEngineInitializer.AddMissedPlatformSettings(_SELECTED_DEVICE);
                else
                {
                    DisposeSerializedObject();
                    _SERIALIZED_OBJECT = new SerializedObject(_XRMOD_ENGINE_PLATFORM_SETTINGS);
                }

                _XRMOD_ENGINE_PLATFORM_SETTINGS.LaunchPrefab =
                    Resources.Load<GameObject>($"Prefabs/Default{_SELECTED_DEVICE}Launcher");
                _SERIALIZED_OBJECT.ApplyModifiedProperties();
                ApplyConfigures();
            }
            else
            {
                Debug.LogError("Error platform");
            }
        }
        
        // ... (existing RebuildPlatformSettings)

        private static void RebuildPlatformSettings(VisualElement _container)
        {
            if (_container == null) return;
            _container.Clear();

            var tmp_PlatformSuffix = GetToolbarIndex == 1 ? $"_{Extensions.GetHandheldARPlatform}" : "";
            var tmp_Suffix = $"UnityStandalone{tmp_PlatformSuffix}";
            
            _XRMOD_ENGINE_PLATFORM_SETTINGS = _XRMOD_ENGINE_SETTINGS.GetPlatformSettings(GetToolbarIndex, tmp_Suffix);

            if (_XRMOD_ENGINE_PLATFORM_SETTINGS == null)
            {
                XRMODEngineInitializer.AddMissedPlatformSettings(_SELECTED_DEVICE);
                // Try get again
                 _XRMOD_ENGINE_PLATFORM_SETTINGS = _XRMOD_ENGINE_SETTINGS.GetPlatformSettings(GetToolbarIndex, tmp_Suffix);
            }

            if (_XRMOD_ENGINE_PLATFORM_SETTINGS != null)
            {
                DisposeSerializedObject();
                _SERIALIZED_OBJECT = new SerializedObject(_XRMOD_ENGINE_PLATFORM_SETTINGS);

                // Launcher Prefab Field
                var tmp_LauncherField = new ObjectField($"{_SELECTED_DEVICE} Launcher")
                {
                    objectType = typeof(GameObject),
                    value = _XRMOD_ENGINE_PLATFORM_SETTINGS.LaunchPrefab
                };
                tmp_LauncherField.RegisterValueChangedCallback(evt =>
                {
                    _XRMOD_ENGINE_PLATFORM_SETTINGS.LaunchPrefab = (GameObject) evt.newValue;
                    EditorUtility.SetDirty(_XRMOD_ENGINE_PLATFORM_SETTINGS);
                });
                
                var tmp_DefaultBtn = new Button(() =>
                {
                    _XRMOD_ENGINE_PLATFORM_SETTINGS.LaunchPrefab = Resources.Load<GameObject>($"Prefabs/Default{_SELECTED_DEVICE}Launcher");
                    tmp_LauncherField.value = _XRMOD_ENGINE_PLATFORM_SETTINGS.LaunchPrefab;
                    EditorUtility.SetDirty(_XRMOD_ENGINE_PLATFORM_SETTINGS);
                }) { text = "Default"};
                
                // Layout for button next to field
                 var tmp_LauncherContainer = new VisualElement();
                 tmp_LauncherContainer.style.flexDirection = FlexDirection.Row;
                 tmp_LauncherContainer.style.marginBottom = 5;
                 tmp_LauncherField.style.flexGrow = 1;
                 tmp_LauncherContainer.Add(tmp_LauncherField);
                 tmp_LauncherContainer.Add(tmp_DefaultBtn);
                 _container.Add(tmp_LauncherContainer);

                 if (_XRMOD_ENGINE_PLATFORM_SETTINGS.LaunchPrefab == null)
                 {
                     _container.Add(new HelpBox("Your XR launcher does not exist and will error out. You can click `Default` button to use our XR launcher.", HelpBoxMessageType.Error));
                 }

                 // Platform Settings Fields (Version, Symbols)
                 _container.Add(_XRMOD_ENGINE_PLATFORM_SETTINGS.CreatePlatformSettingsUI(_SERIALIZED_OBJECT));
            }
            else
            {
               _container.Add(new Label("Failed to load platform settings."));
            }
        }

        private static void RebuildDrawers(VisualElement _container)
        {
            _container.Clear();

             // Simulation Toggle
#if HANDHELD_ARMODULE_INSTALL
                var tmp_SimContainer = new VisualElement();
                tmp_SimContainer.style.paddingLeft = 10;
                tmp_SimContainer.style.paddingBottom = 5;
                tmp_SimContainer.style.borderBottomWidth = 1;
                tmp_SimContainer.style.borderBottomColor = new Color(0.14f, 0.14f, 0.14f);

                var tmp_SimToggle = new Toggle("Simulation") { value = _XRMOD_ENGINE_SETTINGS.Simulation };
                tmp_SimToggle.RegisterValueChangedCallback(evt =>
                {
                    _XRMOD_ENGINE_SETTINGS.Simulation = evt.newValue;
                    EditorUtility.SetDirty(_XRMOD_ENGINE_SETTINGS);
                    RebuildDrawers(_container);
                });
                tmp_SimContainer.Add(tmp_SimToggle);
                _container.Add(tmp_SimContainer);
#endif

            foreach (var tmp_Drawer in _ENVIRONMENT_SETTINGS_DRAWER)
            {
                if (_DRAWER_UI_CACHE.TryGetValue(tmp_Drawer, out var tmp_CachedElement))
                {
                    // Reuse cached element
                    // Re-trigger check if possible (stored in userData)
                    if (tmp_CachedElement.userData is Action tmp_CheckAction)
                    {
                        tmp_CheckAction.Invoke();
                    }
                    _container.Add(tmp_CachedElement);
                }
                else
                {
                    // Create new
                    var tmp_Element = tmp_Drawer.CreateVisualElement();
                    _DRAWER_UI_CACHE[tmp_Drawer] = tmp_Element;
                    _container.Add(tmp_Element);
                }
            }
        }

        private static void DrawTitleBar()
        {
            EditorGUILayout.BeginHorizontal();
            EditorGUILayout.Space();
            Color tmp_DefaultColor = GUI.backgroundColor;
            GUI.backgroundColor = Color.red;
            if (GUILayout.Button("Apply", GUILayout.Width(60)))
            {
                ApplyConfigures();
            }

            GUI.backgroundColor = tmp_DefaultColor;
            EditorGUILayout.EndHorizontal();
        }

        private static void ApplyConfigures()
        {
            ActivateCorrespondingVersionDll.ActivateDll();

            Utility.CreateLinkXml(_XRMOD_ENGINE_SETTINGS.SDKInformation.currentSDKDeviceType.ToString());
            _XRMOD_ENGINE_SETTINGS.SDKInformation.DeviceLauncher = _XRMOD_ENGINE_PLATFORM_SETTINGS.LaunchPrefab;
            _XRMOD_ENGINE_SETTINGS.SDKInformation.Version =
                $"{_XRMOD_ENGINE_PLATFORM_SETTINGS.Version.x}.{_XRMOD_ENGINE_PLATFORM_SETTINGS.Version.y}.{_XRMOD_ENGINE_PLATFORM_SETTINGS.Version.z}";

            _XRMOD_ENGINE_SETTINGS.SDKInformation.currentSDKDeviceType = _SELECTED_DEVICE;

            var tmp_Platform = GetNamedTarget();
            if (tmp_Platform == NamedBuildTarget.Unknown)
            {
                throw new NotSupportedException("This platform is unavailable.");
            }

            PlayerSettings.SetScriptingDefineSymbols(tmp_Platform,
                _XRMOD_ENGINE_PLATFORM_SETTINGS.ScriptingDefineSymbols);

            if (tmp_Platform == NamedBuildTarget.Standalone)
            {
                PlayerSettings.SetScriptingDefineSymbols(NamedBuildTarget.Server,
                    _XRMOD_ENGINE_PLATFORM_SETTINGS.ScriptingDefineSymbols);
            }


            EditorUtility.SetDirty(_XRMOD_ENGINE_SETTINGS);
            EditorUtility.SetDirty(_XRMOD_ENGINE_PLATFORM_SETTINGS);
            EditorUtility.SetDirty(_XRMOD_ENGINE_SETTINGS.SDKInformation);

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            // XRMODPlayerConfigureUtilities.GraphicsSetup();
            // XRMODPlayerConfigureUtilities.ColorSpaceSetup();
            // XRMODPlayerConfigureUtilities.RuntimeSceneSetup();
            // XRMODPlayerConfigureUtilities.ShaderListSetup();
            // XRMODPlayerConfigureUtilities.TagsAndLayersSetup();
            // XRMODPlayerConfigureUtilities.AndroidMinSDKVersionSetup();
            // XRMODPlayerConfigureUtilities.ApiCompatibilitySetup();
            // XRMODPlayerConfigureUtilities.ScriptingBackedSetup();
            // XRMODPlayerConfigureUtilities.InputSystemSetup();

            foreach (ISettingsDrawer tmp_SettingsDrawer in _ENVIRONMENT_SETTINGS_DRAWER)
            {
                if (tmp_SettingsDrawer is IFixer tmp_Fixer)
                {
                    tmp_Fixer.DoFix();
                }
            }
        }

        internal static NamedBuildTarget GetNamedTarget()
        {
#if UNITY_IOS
            return NamedBuildTarget.iOS;
#elif UNITY_ANDROID
            return NamedBuildTarget.Android;
#elif UNITY_WSA
            return NamedBuildTarget.WindowsStoreApps;
#elif UNITY_WEBGL
            return NamedBuildTarget.WebGL;
#elif UNITY_VISIONOS
            return NamedBuildTarget.VisionOS;
#elif UNITY_STANDALONE && !UNITY_SERVER
            return NamedBuildTarget.Standalone;
#elif UNITY_STANDALONE && UNITY_SERVER
            return NamedBuildTarget.Server;
#else
            return NamedBuildTarget.Unknown;
#endif
        }
    }
}
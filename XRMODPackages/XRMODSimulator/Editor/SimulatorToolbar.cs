using System;
using System.IO;
using System.Reflection;
#if USE_PARREL
using ParrelSync;
#endif
using Phantom.XRMOD.SDKEntry.Runtime;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using Phantom.XRMOD.XRMODSimulator.Runtime;
#if UNITY_6000_0_OR_NEWER
using UnityEditor.Toolbars;
using UnityEditor.Overlays;
#endif
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.XRMODSimulator.Editor
{
    [InitializeOnLoad]
    public class SimulatorToolbar : EditorWindow
    {
        private static bool _ENTER_TEST_MODE;
        private const string _CONST_TEST_MODE_KEY = "TestMode";
        private const string _CONST_TEST_MODE_FOR_MMP_KEY = "TestModeMMP";
        static readonly Type _TOOLBAR_TYPE = typeof(UnityEditor.Editor).Assembly.GetType("UnityEditor.Toolbar");
        static ScriptableObject _CURRENT_TOOLBAR;


        private static Texture2D _BUTTON_ICON_IMG;
        private const string _BUTTON_NAME = "XRMOD_LAUNCH_BUTTON";
        private const string _CONST_LAUNCH_BUTTON_NAME = "Launch XRMOD";

        static SimulatorToolbar()
        {
            LoadSimulatorBtnIcon();
            LoadSimulatorBtnIcon();
#if UNITY_6000_3_OR_NEWER
            MainToolbar.Refresh(_CONST_LAUNCH_BUTTON_NAME);
#else
            EditorApplication.update -= OnUpdate;
            EditorApplication.update += OnUpdate;
#endif
            EditorApplication.playModeStateChanged += CheckAppState;
        }

        private static void LoadSimulatorBtnIcon()
        {
            if (!_BUTTON_ICON_IMG)
                _BUTTON_ICON_IMG =
                    AssetDatabase.LoadAssetAtPath<Texture2D>(
                        "Packages/com.phantomsxr.xrmodsimulator/Editor/Assets/Textures/TestingButton.png");
        }

#if UNITY_6000_3_OR_NEWER
        [MainToolbarElement(path: _CONST_LAUNCH_BUTTON_NAME,
            defaultDockPosition = MainToolbarDockPosition.Right,
            ussName = "XRMOD Launch Button")]
        public static MainToolbarElement ProjectSettingsButton()
        {
            var tmp_Content = new MainToolbarContent(tooltip: "Start XRMOD Simualtor",
                image: _BUTTON_ICON_IMG);
            return new MainToolbarButton(tmp_Content, ToggleTestMode);
        }
#else
        static void OnUpdate()
        {
            // Always re-check for the current toolbar instance and our button presence,
            // so the button is restored after toolbar/UI reloads (e.g., after sleep/wake).
            var tmp_Toolbars = Resources.FindObjectsOfTypeAll(_TOOLBAR_TYPE);
            var tmp_Current = tmp_Toolbars.Length > 0 ? (ScriptableObject) tmp_Toolbars[0] : null;
            if (tmp_Current == null)
            {
                _CURRENT_TOOLBAR = null;
                return;
            }

            if (_CURRENT_TOOLBAR != tmp_Current)
            {
                _CURRENT_TOOLBAR = tmp_Current;
            }

            var tmp_RootField = _CURRENT_TOOLBAR.GetType()
                .GetField("m_Root", BindingFlags.NonPublic | BindingFlags.Instance);
            if (tmp_RootField == null) return;

            var tmp_RawRoot = tmp_RootField.GetValue(_CURRENT_TOOLBAR);
            var tmp_MRoot = tmp_RawRoot as VisualElement;
            if (tmp_MRoot == null) return;
            var tmp_ToolbarZone = tmp_MRoot.Q("ToolbarZoneRightAlign") ??
                                  tmp_MRoot.Q(className: "unity-editor-toolbar__right-align-zone");

            if (tmp_ToolbarZone == null)
            {
                Debug.Log("ToolbarZone not found");
                return;
            }

            // If our button already exists, nothing to do.
            if (tmp_ToolbarZone.Q(_BUTTON_NAME) != null) return;

            // Ensure icon is loaded (domain reloads or editor wake can clear it)
            if (_BUTTON_ICON_IMG == null)
            {
                LoadSimulatorBtnIcon();
            }

            var tmp_LaunchXRMODButton = new VisualElement
            {
                name = _BUTTON_NAME
            };
            tmp_LaunchXRMODButton.AddToClassList("unity-text-element");
            tmp_LaunchXRMODButton.AddToClassList("unity-toolbar-button");
            tmp_LaunchXRMODButton.AddToClassList("unity-editor-toolbar-button");

            var tmp_ImgIcon = new Image {image = _BUTTON_ICON_IMG, tooltip = "Start XRMOD Simualtor"};
            tmp_ImgIcon.AddToClassList("unity_image");
            tmp_ImgIcon.AddToClassList("unity-editor-toolbar-element__icon");
            tmp_LaunchXRMODButton.Add(tmp_ImgIcon);

            // var tmp_SimulatorPlayButton = new Label {text = "Launch XRMOD"};
            // tmp_SimulatorPlayButton.AddToClassList("unity-text-element");
            // tmp_SimulatorPlayButton.AddToClassList("unity-editor-toolbar-element__label");
            // tmp_LaunchXRMODButton.Add(tmp_SimulatorPlayButton);

            tmp_LaunchXRMODButton.RegisterCallback<ClickEvent>(_evt => { ToggleTestMode(); });

            tmp_ToolbarZone.Insert(tmp_ToolbarZone.childCount, tmp_LaunchXRMODButton);
        }

#endif


        private static void CheckAppState(PlayModeStateChange _state)
        {
            switch (_state)
            {
                case PlayModeStateChange.EnteredEditMode:
                case PlayModeStateChange.EnteredPlayMode:
#if USE_MPPM
#if USE_MPPM_2
                    if (Unity.Multiplayer.PlayMode.CurrentPlayer.IsMainEditor)
#else
                    if (Unity.Multiplayer.Playmode.CurrentPlayer.IsMainEditor)
#endif
                    {
                        if (!EditorPrefs.GetBool(_CONST_TEST_MODE_KEY, false)) return;
                        SDKInitialization.Initialize();
                        Object.Instantiate(Resources.Load<GameObject>("Simualtor"));
                    }
                    else
                    {
                        SDKInitialization.Initialize();
                        Object.Instantiate(Resources.Load<GameObject>("Simualtor"));
                    }
#elif USE_PARREL
                    if (!ClonesManager.IsClone())
                    {
                        if (!EditorPrefs.GetBool(_CONST_TEST_MODE_KEY, false)) return;
                        SDKInitialization.Initialize();
                        Object.Instantiate(Resources.Load<GameObject>("Simualtor"));
                    }
                    else
                    {
                        SDKInitialization.Initialize();
                        Object.Instantiate(Resources.Load<GameObject>("Simualtor"));
                    }
#else
                    if (EditorPrefs.GetBool(_CONST_TEST_MODE_KEY, false))
                    {
                        SDKInitialization.Initialize();
                        Object.Instantiate(Resources.Load<GameObject>("Simualtor")); 
                    }
#endif


                    break;
                case PlayModeStateChange.ExitingEditMode:
                case PlayModeStateChange.ExitingPlayMode:
                    EditorApplication.playModeStateChanged -= CheckAppState;
                    EditorPrefs.SetBool(_CONST_TEST_MODE_KEY, false);
                    CleanupSimualtorNecessaryAsset();
                    break;
            }
        }


        private static void CleanupSimualtorNecessaryAsset()
        {
            var tmp_SDKEntryPoint = Object.FindFirstObjectByType<SDKEntryPoint>();
            if (tmp_SDKEntryPoint)
            {
                Object.DestroyImmediate(tmp_SDKEntryPoint.gameObject, true);
            }

            var tmp_Simulator = Object.FindFirstObjectByType<Simulator>();
            if (tmp_Simulator)
                Object.DestroyImmediate(tmp_Simulator.gameObject, true);
        }

        public static void ToggleTestMode()
        {
            CleanupSimualtorNecessaryAsset();

            if (EditorApplication.isPlaying)
            {
                EditorApplication.ExitPlaymode();
                _ENTER_TEST_MODE = false;
            }
            else
            {
                EditorApplication.EnterPlaymode();
                _ENTER_TEST_MODE = true;
            }

            EditorPrefs.SetBool(_CONST_TEST_MODE_KEY, _ENTER_TEST_MODE);
            EditorPrefs.SetBool(_CONST_TEST_MODE_FOR_MMP_KEY, _ENTER_TEST_MODE);
        }
    }
}
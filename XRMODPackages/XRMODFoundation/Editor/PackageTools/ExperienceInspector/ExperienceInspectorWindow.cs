// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PackageTools.Editor.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.IO;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class ExperienceInspectorWindow : EditorWindow
    {
        static ExperienceInspectorWindow _WINDOW;
        private const string _CONST_PACKAGE_PATH = "Packages/com.phantomsxr.foundation";
        private static string _UXML_AND_USS_PATH = $"{_CONST_PACKAGE_PATH}/Editor/PackageTools/ExperienceInspector";
        private const string _CONST_FILE_NAME = "ExperienceInspectorWindow";

        private ExperienceInspectorController _controller;
        
        private VisualElement _dropArea;
        private VisualElement _mainContainer;
        private ListView _assetListView;
        private ScrollView _assetPreviewView;
        private Button _resetButton;
        private Label _previewHintLabel;
        private TwoPaneSplitView _splitView;

        [MenuItem("Tools/XR-MOD/Tools/Experience Inspector")]
        private static void GetWindow()
        {
            if (_WINDOW == null)
            {
                _WINDOW = (ExperienceInspectorWindow) EditorWindow.GetWindow(typeof(ExperienceInspectorWindow));
                _WINDOW.titleContent = new GUIContent("Experience Inspector");
                _WINDOW.minSize = new Vector2(600, 400);
            }

            _WINDOW.Show();
        }

        private void OnEnable()
        {
            _controller = new ExperienceInspectorController();
        }

        private void OnDisable()
        {
            _controller?.UnloadBundle();
        }

        public void CreateGUI()
        {
            var visualTree =
                AssetDatabase.LoadAssetAtPath<VisualTreeAsset>($"{_UXML_AND_USS_PATH}/{_CONST_FILE_NAME}.uxml");
            var styleSheet =
                AssetDatabase.LoadAssetAtPath<StyleSheet>($"{_UXML_AND_USS_PATH}/{_CONST_FILE_NAME}.uss");

            VisualElement root = visualTree.CloneTree();
            root.style.flexGrow = 1;
            root.styleSheets.Add(styleSheet);
            rootVisualElement.Add(root);

            BindElements(root);
            SetupCallbacks();
            
            // Initial State
            SwitchToDropMode();
        }

        private void BindElements(VisualElement root)
        {
            _dropArea = root.Q<VisualElement>("DropArea");
            _mainContainer = root.Q<VisualElement>("MainContainer");
            _splitView = root.Q<TwoPaneSplitView>("SplitView");
            _assetListView = root.Q<ListView>("AssetListView");
            _assetPreviewView = root.Q<ScrollView>("AssetPreviewView");
            _resetButton = root.Q<Button>("ResetButton");
            _previewHintLabel = root.Q<Label>("PreviewHintLabel");

            // Setup ListView
            _assetListView.makeItem = () =>
            {
                var label = new Label();
                label.AddToClassList("asset-list-item");
                return label;
            };
            _assetListView.bindItem = (element, i) =>
            {
                (element as Label).text = _controller.AssetPathList[i];
            };
            _assetListView.selectionType = SelectionType.Single;
        }

        private void SetupCallbacks()
        {
            // Drop Area
            _dropArea.RegisterCallback<DragUpdatedEvent>(evt =>
            {
                DragAndDrop.visualMode = DragAndDropVisualMode.Copy;
                evt.StopPropagation();
            });
            
            _dropArea.RegisterCallback<DragPerformEvent>(evt =>
            {
                DragAndDrop.AcceptDrag();
                foreach (var path in DragAndDrop.paths)
                {
                    if (!string.IsNullOrEmpty(path) && File.Exists(path) &&
                        Path.GetFileName(path).ToLower().EndsWith("arexperience"))
                    {
                        LoadPackage(path);
                        break; // Only load one
                    }
                }
                evt.StopPropagation();
            });

            // Reset Button
            _resetButton.clicked += ResetInspector;

            // List Selection
            _assetListView.onSelectionChange += objects =>
            {
                foreach (var obj in objects)
                {
                    if (obj is string path)
                    {
                        ShowPreview(path);
                    }
                }
            };
        }

        private void LoadPackage(string path)
        {
            if (_controller.LoadBundle(path))
            {
                SwitchToInspectMode();
                _assetListView.itemsSource = _controller.AssetPathList;
                _assetListView.Rebuild();
            }
        }

        private void ShowPreview(string path)
        {
            _previewHintLabel.style.display = DisplayStyle.None;
            _controller.ShowPreview(path, _assetPreviewView);
        }

        private void ResetInspector()
        {
            _controller.UnloadBundle();
            _assetListView.itemsSource = null;
            _assetPreviewView.Clear();
            SwitchToDropMode();
        }

        private void SwitchToDropMode()
        {
            _dropArea.style.display = DisplayStyle.Flex;
            _mainContainer.style.display = DisplayStyle.None;
            _resetButton.style.display = DisplayStyle.None;
        }

        private void SwitchToInspectMode()
        {
            _dropArea.style.display = DisplayStyle.None;
            _mainContainer.style.display = DisplayStyle.Flex;
            _resetButton.style.display = DisplayStyle.Flex;
            _previewHintLabel.style.display = DisplayStyle.Flex;
        }
    }
}
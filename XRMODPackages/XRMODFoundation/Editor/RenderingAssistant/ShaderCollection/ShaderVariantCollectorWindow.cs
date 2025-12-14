// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.RenderAssistant.Editor.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.RenderAssistant.Editor
{
    public class ShaderVariantCollectorWindow : EditorWindow
    {
        private List<ShaderVariantData> _previewData = new List<ShaderVariantData>();
        private MultiColumnListView _listView;
        private Label _statusLabel;
        private VisualElement _dropArea;

        [MenuItem("Tools/XR-MOD/Tools/Shader Variant Collector")]
        public static void ShowWindow()
        {
            var wnd = GetWindow<ShaderVariantCollectorWindow>();
            wnd.titleContent = new GUIContent("Variant Collector");
            wnd.minSize = new Vector2(400, 500);
        }

        public void CreateGUI()
        {
            // --- Root Setup ---
            VisualElement root = rootVisualElement;
            root.style.paddingTop = 10;
            root.style.paddingBottom = 10;
            root.style.paddingLeft = 10;
            root.style.paddingRight = 10;
            root.style.backgroundColor = new Color(0.18f, 0.18f, 0.18f); // Dark theme bg

            // --- Header ---
            Label title = new Label("Shader Variant Collector");
            title.style.fontSize = 20;
            title.style.unityFontStyleAndWeight = FontStyle.Bold;
            title.style.marginBottom = 10;
            title.style.color = new Color(0.9f, 0.9f, 0.9f);
            root.Add(title);

            // --- Drop Area ---
            _dropArea = new VisualElement();
            _dropArea.style.height = 100;
            _dropArea.style.borderTopWidth = 2;
            _dropArea.style.borderBottomWidth = 2;
            _dropArea.style.borderLeftWidth = 2;
            _dropArea.style.borderRightWidth = 2;
            _dropArea.style.borderBottomColor = new Color(0.5f, 0.5f, 0.5f);
            _dropArea.style.borderTopColor = new Color(0.5f, 0.5f, 0.5f);
            _dropArea.style.borderLeftColor = new Color(0.5f, 0.5f, 0.5f);
            _dropArea.style.borderRightColor = new Color(0.5f, 0.5f, 0.5f);
            _dropArea.style.borderTopLeftRadius = 5;
            _dropArea.style.borderBottomRightRadius = 5;
            _dropArea.style.justifyContent = Justify.Center;
            _dropArea.style.alignItems = Align.Center;
            _dropArea.style.backgroundColor = new Color(0.25f, 0.25f, 0.25f);

            Label dropLabel = new Label("Drag Folders or Prefabs Here");
            dropLabel.style.opacity = 0.6f;
            _dropArea.Add(dropLabel);

            // Register Drag Events
            _dropArea.RegisterCallback<DragEnterEvent>(OnDragEnter);
            _dropArea.RegisterCallback<DragLeaveEvent>(OnDragLeave);
            _dropArea.RegisterCallback<DragUpdatedEvent>(OnDragUpdated);
            _dropArea.RegisterCallback<DragPerformEvent>(OnDragPerform);

            root.Add(_dropArea);

            // --- Toolbar ---
            VisualElement toolbar = new VisualElement();
            toolbar.style.flexDirection = FlexDirection.Row;
            toolbar.style.marginTop = 10;
            toolbar.style.marginBottom = 5;

            Button buildBtn = new Button(OnBuildClicked) {text = "Build Collection Asset"};
            buildBtn.style.flexGrow = 1;
            buildBtn.style.height = 30;
            buildBtn.style.backgroundColor = new Color(0.2f, 0.5f, 0.3f);

            Button clearBtn = new Button(OnClearClicked) {text = "Clear"};
            clearBtn.style.width = 60;

            toolbar.Add(buildBtn);
            toolbar.Add(clearBtn);
            root.Add(toolbar);

            // --- Status ---
            _statusLabel = new Label("Ready.");
            _statusLabel.style.fontSize = 11;
            _statusLabel.style.marginBottom = 5;
            root.Add(_statusLabel);

            // --- List View (Preview) ---
            MultiColumnListView colListView = new MultiColumnListView();
            colListView.style.flexGrow = 1;
            colListView.style.backgroundColor = new Color(0.15f, 0.15f, 0.15f);

            // Define Columns
            var colShader = new Column {name = "Shader", title = "Shader", width = 150};
            colShader.makeCell = () => new Label();
            colShader.bindCell = (e, i) => (e as Label).text = _previewData[i].Shader.name;

            var colKeywords = new Column
                {name = "Keywords", title = "Active Keywords", width = 200, stretchable = true};
            colKeywords.makeCell = () => new Label();
            colKeywords.bindCell = (e, i) => (e as Label).text = _previewData[i].KeywordString;

            colListView.columns.Add(colShader);
            colListView.columns.Add(colKeywords);

            colListView.itemsSource = _previewData;
            _listView = colListView;

            root.Add(_listView);
        }

        // --- Drag & Drop Logic ---

        private void OnDragEnter(DragEnterEvent evt)
        {
            _dropArea.style.borderBottomColor = new Color(0.3f, 0.8f, 0.4f); // Green highlight
            _dropArea.style.borderLeftColor = new Color(0.3f, 0.8f, 0.4f); // Green highlight
            _dropArea.style.borderRightColor = new Color(0.3f, 0.8f, 0.4f); // Green highlight
            _dropArea.style.borderTopColor = new Color(0.3f, 0.8f, 0.4f); // Green highlight
            _dropArea.style.backgroundColor = new Color(0.3f, 0.35f, 0.3f);
        }

        private void OnDragLeave(DragLeaveEvent evt)
        {
            ResetDropZoneStyle();
        }

        private void OnDragUpdated(DragUpdatedEvent evt)
        {
            DragAndDrop.visualMode = DragAndDropVisualMode.Copy;
        }

        private void OnDragPerform(DragPerformEvent evt)
        {
            ResetDropZoneStyle();
            DragAndDrop.AcceptDrag();

            // 执行扫描逻辑
            ScanAssets(DragAndDrop.objectReferences);
        }

        private void ResetDropZoneStyle()
        {
            _dropArea.style.borderBottomColor = new Color(0.5f, 0.5f, 0.5f);
            _dropArea.style.borderLeftColor = new Color(0.5f, 0.5f, 0.5f);
            _dropArea.style.borderRightColor = new Color(0.5f, 0.5f, 0.5f);
            _dropArea.style.borderTopColor = new Color(0.5f, 0.5f, 0.5f);
            _dropArea.style.backgroundColor = new Color(0.25f, 0.25f, 0.25f);
        }

        // --- Business Logic Integration ---

        private void ScanAssets(UnityEngine.Object[] objects)
        {
            _statusLabel.text = "Scanning...";

            // 1. 扫描 Material
            var materials = ShaderScanner.ScanForMaterials(objects);

            // 2. 提取 Variants
            var variants = ShaderScanner.ProcessVariants(materials);

            // 3. 更新 UI 数据
            _previewData.Clear();
            _previewData.AddRange(variants);
            _listView.RefreshItems();

            _statusLabel.text = $"Found {materials.Count} Materials, resulting in {variants.Count} Unique Variants.";
        }

        private void OnBuildClicked()
        {
            if (_previewData.Count == 0)
            {
                EditorUtility.DisplayDialog("Error", "No variants to build. Please drag assets first.", "OK");
                return;
            }

            string path = EditorUtility.SaveFilePanelInProject("Save ShaderVariantCollection", "NewShaderVariants",
                "shadervariants", "Please enter a file name");
            if (!string.IsNullOrEmpty(path))
            {
                ShaderCollectionBuilder.CreateCollection(_previewData, path);
                _statusLabel.text = "Build Complete.";
            }
        }

        private void OnClearClicked()
        {
            _previewData.Clear();
            _listView.RefreshItems();
            _statusLabel.text = "Ready.";
        }
    }
}
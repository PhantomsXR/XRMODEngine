// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODLocalization.Editor.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.IO;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.Localization.Editor
{
    public class AITranslationButton : IEditorDraw
    {
        private VisualElement visualElement;
        private ToolbarButton toolbarButton;
        private LocalizationEditorWindow window;

        public AITranslationButton(VisualElement _visualElement, LocalizationEditorWindow _window)
        {
            this.visualElement = _visualElement;
            this.window = _window;
        }


        public void Draw()
        {
            if (toolbarButton != null) return;

            toolbarButton = new ToolbarButton(() =>
            {
                var tmp_FileName = $"{SharedData.Instance.Table.Scope}_{SharedData.Instance.Table.Platform}.csv";
                var tmp_OutputPath = Path.Combine(Application.dataPath.Replace("Assets", ""), "Library",
                    "XRMODLocalization");
                if (!Directory.Exists(tmp_OutputPath))
                    Directory.CreateDirectory(tmp_OutputPath);
                var tmp_FilePath = Path.Combine(tmp_OutputPath, tmp_FileName);
                Utilities.ExportToCsv(SharedData.Instance.Table, tmp_FilePath);
                CsvAITranslator.StartTranslation(tmp_FilePath, () =>
                {
                    Utilities.ImportFromCsv(tmp_FilePath, SharedData.Instance.Table);
                    window.RefreshTableList();
                    File.Delete(tmp_FilePath);
                });
            })
            {
                text = "AI Localization",
                name = "AITranslationButton ",
            };

            visualElement.Add(toolbarButton);

            ReBuild();
        }

        public void ReBuild()
        {
            toolbarButton.style.display = SharedData.Instance.Table ? DisplayStyle.Flex : DisplayStyle.None;
        }
    }
}
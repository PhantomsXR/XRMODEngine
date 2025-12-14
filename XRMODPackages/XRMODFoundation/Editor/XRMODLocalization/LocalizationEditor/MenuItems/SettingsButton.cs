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

using Phantom.XRMOD.Localization.Runtime;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.Localization.Editor
{
    public class SettingsButton : IEditorDraw
    {
        private VisualElement visualElement;
        private ToolbarButton addButton;
        private LocalizationEditorWindow window;

        public SettingsButton(VisualElement _visualElement, LocalizationEditorWindow _window)
        {
            this.visualElement = _visualElement;
            this.window = _window;
        }

        Rect buttonRect;

        public void Draw()
        {
            addButton = new ToolbarButton(() =>
            {
                UnityEditor.PopupWindow.Show(addButton.layout,
                    new SettingsPopup(SharedData.Instance.Database.LocalizatoinSettings, AddLanguageToTable));
            })
            {
                text = "Settings",
                name = "SettingsButton"
            };

            visualElement.Add(addButton);

            ReBuild();
        }

        private void AddLanguageToTable()
        {
            Utilities.AddNewLanguageToAllTables();
            Utilities.ModifyAllTableConfig();
            window.RefreshEntryList();
        }

        public void ReBuild()
        {
        }
    }
}
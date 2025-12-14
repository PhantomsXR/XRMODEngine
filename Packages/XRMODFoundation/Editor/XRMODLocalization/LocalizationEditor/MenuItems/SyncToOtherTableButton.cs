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

using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.Localization.Editor
{
    public class SyncToOtherTableButton : IEditorDraw
    {
        private VisualElement visualElement;
        private ToolbarButton addButton;
        private LocalizationEditorWindow window; 
        public SyncToOtherTableButton(VisualElement _visualElement, LocalizationEditorWindow _window)
        {
            this.visualElement = _visualElement;
            this.window = _window;
        }


        public void Draw()
        {
            if (addButton != null) return;

            addButton = new ToolbarButton(() =>
            {
                Utilities.SyncTableEntries();

                // Edit all value
                EditorUtility.SetDirty(SharedData.Instance.Database);
                LocalizationEditorWindow.NotifyDataChanged();
                window.RefreshEntryList();
            })
            {
                text = "Sync tables",
                name = "SyncTablesButton"
            };

            visualElement.Add(addButton);

            ReBuild();
        }

        public void ReBuild()
        {
            addButton.style.display = SharedData.Instance.Table == null ? DisplayStyle.None : DisplayStyle.Flex;
        }
    }
}

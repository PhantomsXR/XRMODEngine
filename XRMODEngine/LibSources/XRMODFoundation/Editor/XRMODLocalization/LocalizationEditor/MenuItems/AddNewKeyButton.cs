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

using System.Linq;
using Phantom.XRMOD.Localization.Runtime;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.Localization.Editor
{
    public class AddNewKeyButton : IEditorDraw
    {
        private VisualElement visualElement;
        private ToolbarButton addButton;
        private LocalizationEditorWindow window;

        public AddNewKeyButton(VisualElement _visualElement, LocalizationEditorWindow _window)
        {
            this.visualElement = _visualElement;
            this.window = _window;
        }

        internal void Draw()
        {
            if (addButton != null) return;

            addButton = new ToolbarButton(() =>
            {
                Utilities.AddNewKeyEntry();
                EditorUtility.SetDirty(SharedData.Instance.Table);
                LocalizationEditorWindow.NotifyDataChanged();
                window.RefreshEntryList();
            })
            {
                text = "Add Key",
                name = "AddNewKeyButton"
            };

            visualElement.Add(addButton);

            ReBuild();
        }

        public void ReBuild()
        {
            
        }

        void IEditorDraw.Draw()
        {
            Draw();
        }
    }
}

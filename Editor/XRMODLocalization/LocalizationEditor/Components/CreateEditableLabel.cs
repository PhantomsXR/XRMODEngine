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

using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.Localization.Editor
{
    public class CreateEditableLabel
    {
        VisualElement Create(string _originalLabel)
        {
            var tmp_Container = new VisualElement();
            tmp_Container.style.flexDirection = FlexDirection.Row;

            var tmp_Label = new Label(_originalLabel)
            {
                style =
                {
                    unityFontStyleAndWeight = FontStyle.Bold,
                    unityTextAlign = TextAnchor.MiddleCenter,
                    flexGrow = 1
                }
            };

            var tmp_TextField = new TextField()
            {
                value = _originalLabel,
                visible = false,
                style =
                {
                    flexGrow = 1
                }
            };

            tmp_Label.RegisterCallback<MouseDownEvent>(evt =>
            {
                tmp_Label.visible = false;
                tmp_TextField.visible = true;
                tmp_TextField.Focus();
                tmp_TextField.SelectAll();
            });

            void CommitRename()
            {
                string newTitle = tmp_TextField.text.Trim();
                if (!string.IsNullOrEmpty(newTitle))
                {
                    tmp_Label.text = newTitle;
                }

                tmp_TextField.visible = false;
                tmp_Label.visible = true;
            }

            tmp_TextField.RegisterCallback<FocusOutEvent>(_ => CommitRename());
            tmp_TextField.RegisterCallback<KeyDownEvent>(evt =>
            {
                if (evt.keyCode == KeyCode.Return || evt.keyCode == KeyCode.KeypadEnter)
                {
                    CommitRename();
                }
            });

            tmp_Container.Add(tmp_Label);
            tmp_Container.Add(tmp_TextField);

            return tmp_Container;
        }

    }
}
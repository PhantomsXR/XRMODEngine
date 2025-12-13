// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Editor.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.UnityFusion.Editor
{
    public class ComponentHeaderWrapper
    {
        private readonly IMGUIContainer headerElement;
        private readonly Component[] targets;
        private readonly Action wrappedOnGUIHandler;

        private ComponentHeaderWrapper(IMGUIContainer _headerElement, Component[] _targets)
        {
            headerElement = _headerElement;
            targets = _targets;
            wrappedOnGUIHandler = _headerElement.onGUIHandler;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsWrapped(IMGUIContainer _header) =>
            string.Equals(_header.onGUIHandler.Method.Name, nameof(DrawWrappedHeaderGUI));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void Wrap(UnityEditor.Editor _editor, IMGUIContainer _header)
        {
            var tmp_Components = _editor.targets.Cast<Component>().ToArray();
            var tmp_Wrapper = new ComponentHeaderWrapper(_header, tmp_Components);
            _header.onGUIHandler = tmp_Wrapper.DrawWrappedHeaderGUI;
        }

        private void DrawWrappedHeaderGUI()
        {
            for (int tmp_I = targets.Length - 1; tmp_I >= 0; tmp_I--)
            {
                if (!targets[tmp_I])
                {
                    Unwrap();
                    return;
                } 
            }

            var tmp_HeaderRect = headerElement.contentRect;
            bool tmp_HeaderIsSelected = headerElement.focusController.focusedElement == headerElement;

            ComponentHeader.InvokeBeforeHeaderGUI(targets, tmp_HeaderRect, tmp_HeaderIsSelected);
            wrappedOnGUIHandler?.Invoke();
            ComponentHeader.InvokeAfterHeaderGUI(targets, tmp_HeaderRect, tmp_HeaderIsSelected);
        }

        private void Unwrap()
        {
            if (headerElement is not null)
            {
                headerElement.onGUIHandler = wrappedOnGUIHandler;
            }
        }
    }
}
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

using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace Phantom.XRMOD.UnityFusion.Editor
{
    /// <summary>
    /// A method that is called before or after the header GUI of a component is drawn.
    /// </summary>
    /// <param name="_targets"> The components whose headers are being drawn. </param>
    /// <param name="_headerRect"> The position and dimensions of the header GUI. </param>
    /// <param name="_headerIsSelected"> Is the header currently selected in the Inspector or not? </param> 
    /// <returns> The height of the element that this method has drawn before or after the header GUI. </returns>
    public delegate void ComponentHeaderGUIHandler([DisallowNull] Component[] _targets, Rect _headerRect,
        bool _headerIsSelected);

    /// <summary>
    /// A class that contains callbacks
    /// </summary>
    public static class ComponentHeader
    {
        /// <summary>
        /// Callback invoked right before component header GUI is drawn.
        /// </summary>
        public static event ComponentHeaderGUIHandler BeforeHeaderGUI;

        /// <summary>
        /// Callback invoked right after component header GUI has been drawn.
        /// </summary>
        public static event ComponentHeaderGUIHandler AfterHeaderGUI;

        internal static void InvokeBeforeHeaderGUI([DisallowNull] Component[] _targets, Rect _headerRect,
            bool _headerIsSelected)
            => BeforeHeaderGUI?.Invoke(_targets, _headerRect, _headerIsSelected);

        internal static void InvokeAfterHeaderGUI([DisallowNull] Component[] _targets, Rect _headerRect,
            bool _headerIsSelected)
            => AfterHeaderGUI?.Invoke(_targets, _headerRect, _headerIsSelected);
    }
}
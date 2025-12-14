// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UIFramework.Runtime.
// //
// // The RokidPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/
#if USE_XRI

using UnityEngine;

namespace Phantom.XRMOD.XRMODInput.Runtime.Keyboard.KeyFunctions
{
    /// <summary>
    /// Key function used to update the keyboard layout.
    /// </summary>
    [CreateAssetMenu(fileName = "Layout Function", menuName = "XR-MOD/UI/Spatial Keyboard/Layout Key Function", order = 1)]
    public class LayoutFunction : KeyFunction
    {
        /// <inheritdoc />
        public override void ProcessKey(XRKeyboard keyboardContext, XRKeyboardKey key)
        {
            if (keyboardContext != null)
                keyboardContext.UpdateLayout(key.GetEffectiveCharacter());
        }
    }
}

#endif
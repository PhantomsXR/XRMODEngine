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

using System;
using UnityEngine.Events;

namespace Phantom.XRMOD.XRMODInput.Runtime.Keyboard
{
    #region EventArgs

    /// <summary>
    /// Event data associated with a keyboard event.
    /// </summary>
    public class KeyboardBaseEventArgs
    {
        /// <summary>
        /// The XR Keyboard associated with this keyboard event.
        /// </summary>
        public XRKeyboard keyboard { get; set; }
    }

    /// <summary>
    /// Event data associated with a keyboard event that includes text.
    /// </summary>
    public class KeyboardTextEventArgs : KeyboardBaseEventArgs
    {
        /// <summary>
        /// The current keyboard text when this event is fired.
        /// </summary>
        public string keyboardText { get; set; }
    }

    /// <summary>
    /// Event data associated with a keyboard event that includes a keyboard key.
    /// </summary>
    public class KeyboardKeyEventArgs : KeyboardBaseEventArgs
    {
        /// <summary>
        /// The key associated with this event.
        /// </summary>
        public XRKeyboardKey key { get; set; }
    }

    /// <summary>
    /// Event data associated with a keyboard event that includes a bool value.
    /// </summary>
    public class KeyboardBoolEventArgs : KeyboardBaseEventArgs
    {
        /// <summary>
        /// The bool value associated with this event.
        /// </summary>
        public bool value { get; set; }
    }

    /// <summary>
    /// Event data associated with a keyboard event that includes a layout string.
    /// </summary>
    public class KeyboardLayoutEventArgs : KeyboardBaseEventArgs
    {
        /// <summary>
        /// The layout string associated with this event.
        /// </summary>
        public string layout { get; set; }
    }

    /// <summary>
    /// Event data associated with modifiers of the keyboard.
    /// </summary>
    public class KeyboardModifiersEventArgs : KeyboardBaseEventArgs
    {
        /// <summary>
        /// The shift value associated with this event.
        /// </summary>
        public bool shiftValue { get; set; }

        /// <summary>
        /// The caps lock value associated with this event.
        /// </summary>
        public bool capsLockValue { get; set; }
    }

    #endregion

    #region Events

    /// <summary>
    /// <see cref="UnityEvent"/> that Unity invokes on a keyboard.
    /// </summary>
    [Serializable]
    public sealed class KeyboardEvent : UnityEvent<KeyboardBaseEventArgs>
    {
    }

    /// <summary>
    /// <see cref="UnityEvent"/> that includes text that Unity invokes on a keyboard.
    /// </summary>
    [Serializable]
    public sealed class KeyboardTextEvent : UnityEvent<KeyboardTextEventArgs>
    {
    }

    /// <summary>
    /// <see cref="UnityEvent"/> that includes a key that Unity invokes on a keyboard.
    /// </summary>
    [Serializable]
    public sealed class KeyboardKeyEvent : UnityEvent<KeyboardKeyEventArgs>
    {
    }

    /// <summary>
    /// <see cref="UnityEvent"/> that includes a bool value that Unity invokes on a keyboard.
    /// </summary>
    [Serializable]
    public sealed class KeyboardBoolEvent : UnityEvent<KeyboardBoolEventArgs>
    {
    }

    /// <summary>
    /// <see cref="UnityEvent"/> that includes a layout string that Unity invokes on a keyboard.
    /// </summary>
    [Serializable]
    public sealed class KeyboardLayoutEvent : UnityEvent<KeyboardLayoutEventArgs>
    {
    }

    /// <summary>
    /// <see cref="UnityEvent"/> that includes supported keyboard modifiers.
    /// </summary>
    /// <remarks>Currently supported keyboard modifiers include shift and caps lock.</remarks>
    [Serializable]
    public sealed class KeyboardModifiersEvent : UnityEvent<KeyboardModifiersEventArgs>
    {
    }

    #endregion
}
#endif
// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.ActionNotification.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/


namespace Phantom.XRMOD.ActionNotification.Runtime
{
#if UNITY_EDITOR
    /// <summary>
    /// A specialized notification center for use within the Unity Editor.
    /// This allows editor-specific components and tools to communicate via the notification pattern.
    /// </summary>
    public static class EditorNotificationCenter
    {
        private static readonly ActionNotificationCenter _EDITOR_CENTER = new();

        /// <summary>
        /// Gets the editor-specific instance of the notification center.
        /// </summary>
        public static ActionNotificationCenter Center => _EDITOR_CENTER;
    }
#endif
}
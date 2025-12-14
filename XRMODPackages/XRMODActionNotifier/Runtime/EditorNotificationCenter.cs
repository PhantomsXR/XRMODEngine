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
    public static class EditorNotificationCenter
    {
        private static readonly ActionNotificationCenter _EDITOR_CENTER = new();
        public static ActionNotificationCenter Center => _EDITOR_CENTER;
    }
#endif
}
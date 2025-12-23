// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.QuestModule.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.QuestModule.Runtime
{
    /// <summary>
    /// Utility class for handling debug logging with varied levels of verbosity.
    /// </summary>
    public static class PassthroughCameraDebugger
    {
        /// <summary>
        /// Defines available debug levels.
        /// </summary>
        public enum DebuglevelEnum
        {
            /// <summary>
            /// Log everything (Info, Warning, Error).
            /// </summary>
            ALL,
            /// <summary>
            /// Log nothing.
            /// </summary>
            NONE,
            /// <summary>
            /// Log only errors.
            /// </summary>
            ONLY_ERROR,
            /// <summary>
            /// Log only standard messages.
            /// </summary>
            ONLY_LOG,
            /// <summary>
            /// Log only warnings.
            /// </summary>
            ONLY_WARNING
        }

        /// <summary>
        /// Current debug level setting. Defaults to <see cref="DebuglevelEnum.ALL"/>.
        /// </summary>
        public static DebuglevelEnum DebugLevel = DebuglevelEnum.ALL;

        /// <summary>
        /// Send debug information to Unity console based on DebugType and DebugLevel.
        /// </summary>
        /// <param name="mType">The type of log message (Error, Log, Warning).</param>
        /// <param name="message">The message string to log.</param>
        public static void DebugMessage(LogType mType, string message)
        {
            switch (mType)
            {
                case LogType.Error:
                    if (DebugLevel is DebuglevelEnum.ALL or DebuglevelEnum.ONLY_ERROR)
                    {
                        Debug.LogError(message);
                    }

                    break;
                case LogType.Log:
                    if (DebugLevel is DebuglevelEnum.ALL or DebuglevelEnum.ONLY_LOG)
                    {
                        Debug.Log(message);
                    }

                    break;
                case LogType.Warning:
                    if (DebugLevel is DebuglevelEnum.ALL or DebuglevelEnum.ONLY_WARNING)
                    {
                        Debug.LogWarning(message);
                    }

                    break;
            }
        }
    }
}
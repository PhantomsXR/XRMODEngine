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

using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Android;
using PCD = Phantom.XRMOD.QuestModule.Runtime.PassthroughCameraDebugger;

namespace Phantom.XRMOD.QuestModule.Runtime
{
    /// <summary>
    /// Manages permission requests for Passthrough Camera access on Meta Quest.
    /// </summary>
    public class PassthroughCameraPermissions : MonoBehaviour
    {
        /// <summary>
        /// List of additional permissions to request on startup.
        /// <para>Default includes "com.oculus.permission.USE_SCENE".</para>
        /// </summary>
        [SerializeField] public List<string> PermissionRequestsOnStartup = new() {"com.oculus.permission.USE_SCENE"};

        /// <summary>
        /// Required permissions for accessing the Passthrough Camera.
        /// </summary>
        public static readonly string[] CameraPermissions =
        {
            "android.permission.CAMERA", // Required to use WebCamTexture object.
            "horizonos.permission.HEADSET_CAMERA" // Required to access the Passthrough Camera API in Horizon OS v74 and above.
        };

        /// <summary>
        /// Indicates whether camera permissions have been granted.
        /// </summary>
        public static bool? HasCameraPermission { get; private set; }
        private static bool s_askedOnce;

#if UNITY_ANDROID
        /// <summary>
        /// Request camera permission if the permission is not authorized by the user.
        /// <para>
        /// Checks if permissions are already granted. If not, requests them via <see cref="Permission.RequestUserPermissions"/>.
        /// </para>
        /// </summary>
        public void AskCameraPermissions()
        {
            if (s_askedOnce)
            {
                return;
            }

            s_askedOnce = true;
            if (IsAllCameraPermissionsGranted())
            {
                HasCameraPermission = true;
                PCD.DebugMessage(LogType.Log, "PCA: All camera permissions granted.");
            }
            else
            {
                PCD.DebugMessage(LogType.Log, "PCA: Requesting camera permissions.");

                var callbacks = new PermissionCallbacks();
                callbacks.PermissionDenied += PermissionCallbacksPermissionDenied;
                callbacks.PermissionGranted += PermissionCallbacksPermissionGranted;
                callbacks.PermissionDeniedAndDontAskAgain += PermissionCallbacksPermissionDenied;

                // It's important to request all necessary permissions in one request because only one 'PermissionCallbacks' instance is supported at a time.
                var allPermissions = CameraPermissions.Concat(PermissionRequestsOnStartup).ToArray();
                Permission.RequestUserPermissions(allPermissions, callbacks);
            }
        }

        /// <summary>
        /// Permission Granted callback
        /// </summary>
        /// <param name="permissionName">Name of the granted permission.</param>
        private static void PermissionCallbacksPermissionGranted(string permissionName)
        {
            PCD.DebugMessage(LogType.Log, $"PCA: Permission {permissionName} Granted");

            // Only initialize the WebCamTexture object if both permissions are granted
            if (IsAllCameraPermissionsGranted())
            {
                HasCameraPermission = true;
            }
        }

        /// <summary>
        /// Permission Denied callback.
        /// </summary>
        /// <param name="permissionName">Name of the denied permission.</param>
        private static void PermissionCallbacksPermissionDenied(string permissionName)
        {
            PCD.DebugMessage(LogType.Warning, $"PCA: Permission {permissionName} Denied");
            HasCameraPermission = false;
            s_askedOnce = false;
        }

        /// <summary>
        /// Checks if all required camera permissions are authorized.
        /// </summary>
        /// <returns>True if all permissions in <see cref="CameraPermissions"/> are granted.</returns>
        private static bool IsAllCameraPermissionsGranted() =>
            CameraPermissions.All(Permission.HasUserAuthorizedPermission);
#endif
    }
}
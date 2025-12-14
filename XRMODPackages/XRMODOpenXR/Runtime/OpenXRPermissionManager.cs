// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.OpenXRModule.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

#if QUEST_INSTALL || UNITY_OPENXR || ANDROID_XR

using System;
using System.Collections.Generic;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.OpenXRMOD.Runtime.OnEventArgs;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.Events;

namespace Phantom.XRMOD.OpenXRMOD.Runtime
{
    [DefaultExecutionOrder(-9999)]
    public class OpenXRPermissionManager : MonoBehaviour
    {
        const string _CONST_DEFAULT_PERMISSION_ID = "com.oculus.permission.USE_SCENE";

        [SerializeField,
         Tooltip(
             "Enables or disables the processing of permissions on Start. If disabled, permissions will not be processed until the ProcessPermissions method is called.")]
        private bool processPermissionsOnStart = true;

        [SerializeField, Tooltip("The system permissions to request when this component Starts.")]
        List<PermissionRequestGroup> permissionGroups = new List<PermissionRequestGroup>();

        /// <summary>
        /// Current platform permission group to process. This is determined during the <see cref="Awake"/> method using based on <see cref="XRPlatformUnderstanding"/>
        /// </summary>
        PermissionRequestGroup currentPlatformPermissionGroup = new PermissionRequestGroup();

        List<PermissionRequest> persmissions = new List<PermissionRequest>();

        public Action<string> OnPermissionGrantedHandler;
        public Action<string> OnPermissionDeniedHandler;

        /// <summary>
        /// A group of permissions to request based on a specific platform.
        /// </summary>
        [Serializable]
        class PermissionRequestGroup
        {
            [HideInInspector] public string name;

            [Tooltip("The platform type for which these permissions is intended for.")]
            public XRPlatformType platformType;

            public List<PermissionRequest> permissions;
        }

        /// <summary>
        /// A permission request to be made to the Android operating system.
        /// </summary>
        [Serializable]
        class PermissionRequest
        {
            [Tooltip("The Android system permission to request when this component starts.")]
            public string permissionId = _CONST_DEFAULT_PERMISSION_ID;

            [Tooltip("Whether to request permission from the operating system.")]
            public bool enabled = true;

            [HideInInspector] public bool requested = false;

            [HideInInspector] public bool responseReceived = false;

            [HideInInspector] public bool granted = false;

            public UnityEvent<string> onPermissionGranted;

            public UnityEvent<string> onPermissionDenied;
        }

        void Awake()
        {
            if (processPermissionsOnStart)
                ProcessPermissions();
        }

        void OnValidate()
        {
            // Ensure that the permission groups are not empty and that they have at least one permission defined.
            for (int tmp_I = 0; tmp_I < permissionGroups.Count; tmp_I++)
            {
                permissionGroups[tmp_I].name = permissionGroups[tmp_I].platformType.ToString();
            }
        }

        /// <summary>
        /// Process the permissions defined in the <see cref="permissionGroups"/> list.
        /// </summary>
        public void ProcessPermissions()
        {
            persmissions = new List<PermissionRequest>();

#if UNITY_ANDROID

            // Grab the current platform permission group based on the current platform in use.
            currentPlatformPermissionGroup = permissionGroups.Find(g =>
                g.platformType == XRPlatformUnderstanding.CurrentPlatform || g.platformType == XRPlatformType.All);
            if (currentPlatformPermissionGroup == null)
            {
                Debug.LogWarning(
                    $"No permission group found for platform {XRPlatformUnderstanding.CurrentPlatform}. Disabling {nameof(OpenXRPermissionManager)} component.",
                    this);
                enabled = false;
                return;
            }

            // If we have permissions for all platforms, add them to the current platform's permissions.
            if (permissionGroups.Exists(_g => _g.platformType == XRPlatformType.All))
            {
                currentPlatformPermissionGroup.permissions.AddRange(permissionGroups
                    .Find(_g => _g.platformType == XRPlatformType.All).permissions);
            }

            // Loop through the current platform's permissions and add them to the
            // list of permissions to request if they are enabled and not already requested.
            for (int tmp_I = 0; tmp_I < currentPlatformPermissionGroup.permissions.Count; tmp_I++)
            {
                if (!currentPlatformPermissionGroup.permissions[tmp_I].enabled)
                    continue;

                // If permission is not granted and not requested, add it to the list of permissions to request
                if (!Permission.HasUserAuthorizedPermission(
                        currentPlatformPermissionGroup.permissions[tmp_I].permissionId) &&
                    !currentPlatformPermissionGroup.permissions[tmp_I].requested)
                {
                    persmissions.Add(currentPlatformPermissionGroup.permissions[tmp_I]);
                    currentPlatformPermissionGroup.permissions[tmp_I].requested = true;
                }
                else
                {
                    Debug.Log(
                        $"User has permission for: {currentPlatformPermissionGroup.permissions[tmp_I].permissionId}",
                        this);
                }
            }

            // Process permissions that were not already granted
            if (persmissions.Count > 0)
            {
                var tmp_Callbacks = new PermissionCallbacks();
                tmp_Callbacks.PermissionDenied += OnPermissionDenied;
                tmp_Callbacks.PermissionGranted += OnPermissionGranted;

                string[] tmp_Permissions = new string[persmissions.Count];
                for (int tmp_I = 0; tmp_I < persmissions.Count; tmp_I++)
                {
                    tmp_Permissions[tmp_I] = persmissions[tmp_I].permissionId;
                }

                Permission.RequestUserPermissions(tmp_Permissions, tmp_Callbacks);
            }
#endif // UNITY_ANDROID
        }

        void OnPermissionGranted(string _permissionStr)
        {
            var tmp_Permission = persmissions.Find(p => p.permissionId == _permissionStr);
            if (tmp_Permission == null)
            {
                Debug.LogWarning(
                    $"Permission granted callback received for an unexpected permission request, permission ID {_permissionStr}",
                    this);
                return;
            }

            // Enable permission
            tmp_Permission.granted = true;
            tmp_Permission.responseReceived = true;

            Debug.Log($"User granted permission for: {_permissionStr}", this);
            tmp_Permission.onPermissionGranted.Invoke(_permissionStr);
            OnPermissionGrantedHandler?.Invoke(_permissionStr);
        }

        void OnPermissionDenied(string _permissionStr)
        {
            // Find the permission with LINQ
            var tmp_Permission = persmissions.Find(p => p.permissionId == _permissionStr);
            if (tmp_Permission == null)
            {
                Debug.LogWarning(
                    $"Permission denied callback received for an unexpected permission request, permission ID {_permissionStr}",
                    this);
                return;
            }

            // Disable permission
            tmp_Permission.granted = false;
            tmp_Permission.responseReceived = true;

            Debug.LogWarning($"User denied permission for: {_permissionStr}", this);
            tmp_Permission.onPermissionDenied.Invoke(_permissionStr);

            OnPermissionDeniedHandler?.Invoke(_permissionStr);
        }
    }


    public enum XRPlatformType
    {
        Quest,
        AndroidXR,
        Other,
        All
    }
}
#endif
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

using UnityEngine;

namespace Phantom.XRMOD.OpenXRMOD.Runtime
{
#if UNITY_OPENXR
    /// <summary>
    /// Singleton component that controls Application SpaceWarp (ASW) state and updates the application space transform.
    /// Application SpaceWarp allows the app to render at half the display rate while providing a smooth experience.
    /// </summary>
    public class SpacewarpController : MonoBehaviour
    {
        /// <summary>
        /// Singleton instance of the SpacewarpController.
        /// </summary>
        public static SpacewarpController Instance { get; private set; }

        /// <summary>
        /// Current state of Spacewarp (Enabled/Disabled).
        /// </summary>
        public bool EnableSpacewarp = false;

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(gameObject); // 保证单例唯一性
                return;
            }

            Instance = this;
            if (transform.root == null)
                DontDestroyOnLoad(gameObject); // 可选：是否在切换场景时保留
        }

        /// <summary>
        /// Enables or disables Application SpaceWarp.
        /// </summary>
        /// <param name="_enabled">True to enable, false to disable.</param>
        /// <example>
        /// <code>
        /// // Enable Spacewarp
        /// SpacewarpController.Instance.SetSpacewarpEnabled(true);
        /// </code>
        /// </example>
        public void SetSpacewarpEnabled(bool _enabled)
        {
            EnableSpacewarp = _enabled;
            SpacewarpFeature.SetSpacewarp(_enabled);
        }

        void Update()
        {
            if (!EnableSpacewarp)
                return;

            // Update spacewarp with camera position and rotation
            SpacewarpFeature.SetAppSpaceTransform(transform.position, transform.rotation);
        }
    }
#endif
}
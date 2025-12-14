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
    public class SpacewarpController : MonoBehaviour
    {
        public static SpacewarpController Instance { get; private set; }
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
        /// Set Spacewarp state
        /// </summary>
        /// <param name="_enabled"></param>
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
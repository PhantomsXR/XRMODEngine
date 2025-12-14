// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODUtilites.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.XRMODUtilites.Runtime
{
    public class BatchModeUpdateRendererComponentAdapter : MonoBehaviour
    {
        [SerializeField] private Camera camera;

        public Camera Camera
        {
            get => camera;
            set => camera = value;
        }

        void Start()
        {
            if (camera == null)
                camera = GetComponent<Camera>();
        }

        void Update()
        {
            if (Application.isBatchMode && camera)
                camera.Render();
        }
    }
}
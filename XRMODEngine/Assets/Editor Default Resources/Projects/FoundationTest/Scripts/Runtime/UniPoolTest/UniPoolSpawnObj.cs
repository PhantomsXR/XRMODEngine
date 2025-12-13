// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the FoundationTest.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.Core.Runtime;
using UnityEngine;

namespace FoundationTest.Runtime.UniPoolTest
{
    public class UniPoolSpawnObj : XRMODBehaviour
    {
        Renderer meshRenderer = null;

        bool initPassed = false;

        Vector3 velocity = Vector3.up;

        private Transform selfTransform;

        void Start()
        {
            Init();
        }

        void Init()
        {
            meshRenderer = GetComponent<Renderer>();
            initPassed = true;
            selfTransform = transform;
        }


        internal void Setup(Vector3 direction, float speed, Color color)
        {
            if (!initPassed) Init();

            transform.forward = direction;
            velocity = direction * speed;
            meshRenderer.material.color = color;
        }

        public void SetActive(bool status)
        {
            gameObject.SetActive(status);
        }

        private int idx = 0;

        void Update()
        {
            velocity.y += -15f * Time.deltaTime;
            selfTransform.Translate(velocity * Time.deltaTime);
        }
    }
}
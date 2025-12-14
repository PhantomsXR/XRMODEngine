// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODUtilites.Runtime.
// //
// // The UnityVisionOSLibTest cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.Core.Runtime;
using UnityEngine;

namespace Phantom.XRMOD.XRMODUtilites.Runtime
{
    public class StaticBatchElementComponentAdapter : MonoBehaviour
    {
        [SerializeField] private GameObject root;
        [SerializeField] private bool applyToDescendants;


        public BindableProperty<GameObject> Root = new();
        public BindableProperty<bool> ApplyToDescendants = new();

#if UNITY_VISIONOS
        private Unity.PolySpatial.PolySpatialStaticBatchElement staticBatch;

        private void Start()
        {
            staticBatch = gameObject.AddComponent<Unity.PolySpatial.PolySpatialStaticBatchElement>();
            Root.OnValueChanged = _value => { staticBatch.Root = _value; };
            ApplyToDescendants.OnValueChanged = _value => { staticBatch.ApplyToDescendants = _value; };
            Root.Value = root;
            ApplyToDescendants.Value = applyToDescendants;
        }

        private void OnEnable()
        {
            if (staticBatch)
                staticBatch.enabled = true;
        }

        private void OnDisable()
        {
            if (staticBatch)
                staticBatch.enabled = false;
        }
#endif
    }
}
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

using System;
using System.Threading;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

namespace FoundationTest.Runtime.InstanceTest
{
    public class InstantiateAsyncTest : XRMODBehaviour
    {
        [SerializeField] private GameObject instantiateCubePrefab;
        [SerializeField] private GameObject instantiatePrefabIncludeScript;
        [SerializeField] private Transform deactivatedContainer;
        private readonly CancellationToken cancellationToken = CancellationToken.None;
#if UNITY_6000_0_OR_NEWER && (UNITY_6000_0_34||UNITY_6000_1_OR_NEWER)
        private InstantiateParameters instantiateParameters = new InstantiateParameters();
#endif
        public async void Start()
        {
            var tmp_InsGo = await InstantiateAsync(instantiatePrefabIncludeScript,10,deactivatedContainer,Vector3.zero,Quaternion.identity);
            int tmp_Idx = 0;
            foreach (GameObject tmp_O in tmp_InsGo)
            {
                tmp_O.name = $"InstantiateAsync-{tmp_Idx}";
                tmp_Idx++;
            }
// #if UNITY_6000_0_OR_NEWER && (UNITY_6000_0_34||UNITY_6000_1_OR_NEWER)
//             instantiateParameters.parent = transform;
//             instantiateParameters.worldSpace = true;
// #endif
//             var tmp_Sphere1Result = await InstantiateAsync<GameObject>(instantiateCubePrefab);
//             var tmp_Sphere2Result = await InstantiateAsync<GameObject>(instantiateCubePrefab);
// #if UNITY_6000_0_OR_NEWER && (UNITY_6000_0_34||UNITY_6000_1_OR_NEWER)
//             var tmp_Sphere3Result =
//                 await InstantiateAsync<GameObject>(instantiateCubePrefab, instantiateParameters, cancellationToken);
// #endif
//
//             var tmp_Sphere4Result = await InstantiateAsync<GameObject>(instantiateCubePrefab, 1);
//             var tmp_Sphere5Result = await InstantiateAsync<GameObject>(instantiateCubePrefab, 1, transform);
//             var tmp_Sphere6Result =
//                 await InstantiateAsync<GameObject>(instantiateCubePrefab, 1, transform, Vector3.zero,
//                     Quaternion.identity);
//             var tmp_Sphere7Result = await InstantiateAsync<GameObject>(instantiateCubePrefab, 1, transform,
//                 Vector3.zero,
//                 Quaternion.identity,
//                 cancellationToken);
//
//
// #if UNITY_6000_0_OR_NEWER && (UNITY_6000_0_34||UNITY_6000_1_OR_NEWER)
//             instantiateParameters.parent = transform;
//             instantiateParameters.worldSpace = true;
// #endif
//             var tmp_Result1 = await InstantiateAsync<GameObject>(instantiatePrefabIncludeScript);
//             Assert.AreEqual(tmp_Result1.Length, 1);
//
// #if UNITY_6000_0_OR_NEWER && (UNITY_6000_0_34||UNITY_6000_1_OR_NEWER)
//             var tmp_Result2 = await InstantiateAsync<GameObject>(instantiatePrefabIncludeScript, instantiateParameters,
//                 cancellationToken);
//             Assert.AreEqual(tmp_Result2.Length, 1);
//             Assert.AreEqual(tmp_Result2[0].transform.parent, instantiateParameters.parent);
// #endif
//
//             var tmp_Result3 = await InstantiateAsync<GameObject>(instantiatePrefabIncludeScript, 1);
//             Assert.AreEqual(tmp_Result3.Length, 1);
//             var tmp_Result4 = await InstantiateAsync<GameObject>(instantiatePrefabIncludeScript, 1, transform);
//             Assert.AreEqual(tmp_Result4.Length, 1);
//             Assert.AreEqual(tmp_Result4[0].transform.parent, transform);
//
//             var tmp_Result5 = await InstantiateAsync<GameObject>(instantiatePrefabIncludeScript, 1, transform,
//                 Vector3.zero,
//                 Quaternion.identity);
//             Assert.AreEqual(tmp_Result5.Length, 1);
//             Assert.AreEqual(tmp_Result5[0].transform.parent, transform);
//
//             var tmp_Result6 = await InstantiateAsync<GameObject>(instantiatePrefabIncludeScript, 1, transform,
//                 Vector3.zero,
//                 Quaternion.identity,
//                 cancellationToken);
//             Assert.AreEqual(tmp_Result6.Length, 1);
//             Assert.AreEqual(tmp_Result6[0].transform.parent, transform);
        }
    }
}
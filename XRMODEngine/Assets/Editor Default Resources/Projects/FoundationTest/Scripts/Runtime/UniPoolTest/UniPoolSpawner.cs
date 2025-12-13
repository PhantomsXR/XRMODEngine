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
using System.Collections;
using System.Collections.Generic;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime.UniPool;
using UnityEngine;
using UnityEngine.Assertions;
using Random = UnityEngine.Random;

namespace FoundationTest.Runtime.UniPoolTest
{
    public class UniPoolSpawner : XRMODBehaviour
    {
        [SerializeField] Color[] colorList;
        [SerializeField] List<GameObject> prefabList;
        [Range(1, 30), SerializeField] int multiplier = 5;
        [SerializeField] int fillAmount = 0;

        void Start()
        {
            UniPool.Register(SharedData.GetInstance.unipoolPrefab, this.transform);
            UniPool.Fill(SharedData.GetInstance.unipoolPrefab, 2);
            StartCoroutine(WaitToDisplay());

            for (int i = 0, len = prefabList.Count; i < len; ++i)
            {
                UniPool.Register<UniPoolSpawnObj>(prefabList[i]);
            }
            
            if (fillAmount > 0)
            {
                for (int i = 0, len = prefabList.Count; i < len; ++i)
                {
                    UniPool.Fill(prefabList[i], fillAmount);
                }
            }
            
            UniPool.Get(prefabList[0]);
        }

        private IEnumerator WaitToDisplay()
        {
            while (true)
            {
                yield return new WaitForSecondsRealtime(2);
                var tmp_Go = UniPool.Get(SharedData.GetInstance.unipoolPrefab);
                var tmp_To = tmp_Go.GameObject.GetComponent<TargetObject>();
                Assert.IsNotNull(tmp_To);
            }
        }

        void DoSpawn()
        {
            Color color = colorList[Random.Range(0, colorList.Length)];
            Vector3 direction = Random.insideUnitCircle.normalized;
            float speed = Random.Range(10f, 50f);

            PoolCell cell = UniPool.Get(prefabList[Random.Range(0, prefabList.Count)]);
            cell.Transform.position = transform.position;

            UniPoolSpawnObj spawn = cell.GetComponent<UniPoolSpawnObj>();
            if (spawn)
                spawn.Setup(direction, speed, color);

            cell.GameObject.SetActive(true);
            UniPool.Release(cell, Random.Range(3f, 5f));
        }


        void FixedUpdate()
        {
            for (int i = 0; i < multiplier; ++i)
            {
                DoSpawn();
            }
        }
    }
}
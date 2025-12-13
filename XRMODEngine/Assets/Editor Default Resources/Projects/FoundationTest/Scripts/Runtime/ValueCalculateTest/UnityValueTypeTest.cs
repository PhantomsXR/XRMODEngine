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
using Phantom.XRMOD.Core.Runtime;
using Unity.Profiling;
using UnityEngine;

namespace FoundationTest.Runtime
{
    public class UnityValueTypeTest : XRMODBehaviour
    {
        private static ProfilerMarker _TMP_TEST1 = new(nameof(RunTest));

        private void Start()
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            using (_TMP_TEST1.Auto())
            {
                sw.Start();
                RunTest();
                RunTest2();
                RunTest3();
                RunTest4();
                sw.Stop();
                Debug.Log($"Run Test1 to Test4 cost: {sw.ElapsedMilliseconds} ms");
            }
        }

        public void RunTest()
        {
            //Debug.Log("测试Vector3的各种运算");
            Vector3 a = new Vector3(1, 2, 3);
            Vector3 b = Vector3.one;
            _ = (a + b);
            _ = (a - b);
            _ = (a * 2);
            _ = (2 * a);
            _ = (a / 2);
            _ = (-a);
            _ = (a == b);
            _ = (a != b);
            _ = Vector3.Dot(a, b);
            _ = Vector3.Cross(a, b);
            _ = Vector3.Distance(a, b);
            _ = a.magnitude;
            _ = a.normalized;
            _ = a.sqrMagnitude;


            float dot = 0;
            for (int i = 0; i < 500; i++)
            {
                a += Vector3.one;
                dot += Vector3.Dot(a, Vector3.zero);
            }
        }

        public void RunTest2()
        {
            //Debug.Log("测试Vector3的各种运算");
            Quaternion a = new Quaternion(1, 2, 3, 4);
            Quaternion b = Quaternion.identity;
            Vector3 c = new Vector3(2, 3, 4);

            _ = (a * b);
            _ = (a * c);
            _ = (a == b);
            _ = (a != b);
            _ = Quaternion.Dot(a, b);
            _ = Quaternion.Angle(a, b);
            _ = a.eulerAngles;
            _ = Quaternion.Euler(c);
            _ = Quaternion.Euler(2, 3, 4);

            var rot = Quaternion.Euler(c);
            float dot = 0;
            for (int i = 0; i < 500; i++)
            {
                a *= rot;
                dot += Quaternion.Dot(a, b);
            }
        }

        public void RunTest3()
        {
            //Debug.Log("测试Vector2的各种运算");
            Vector2 a = new Vector2(1, 2);
            Vector2 b = Vector2.one;

            _ = (a + b);
            _ = (a - b);
            _ = (a * 2);
            _ = (2 * a);
            _ = (a / 2);
            _ = (-a);
            _ = (a == b);
            _ = (a != b);
            _ = ((Vector3) a);
            _ = ((Vector2) Vector3.one);
            _ = Vector2.Dot(a, b);
            _ = Vector2.Distance(a, b);
            _ = a.magnitude;
            _ = a.normalized;
            _ = a.sqrMagnitude;
            float dot = 0;
            for (int i = 0; i < 500; i++)
            {
                a += Vector2.one;
                dot += Vector2.Dot(a, Vector2.zero);
            }
        }


        public void RunTest4()
        {
            int cnt = 0;
            for (int i = 0; i < 500; i++)
            {
                cnt += i;
            }
        }
    }
}
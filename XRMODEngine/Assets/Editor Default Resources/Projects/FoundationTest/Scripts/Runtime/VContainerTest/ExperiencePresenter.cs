// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the FoundationTest.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using FoundationTest.Runtime.EventReceiver;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using UnityEngine.Assertions;
using VContainer;

namespace FoundationTest.Runtime
{
    public class ExperiencePresenter : XRMODBehaviour
    {
        IService2 service;
        SpawnerTest[] spawners;

        [Inject]
        public void Init([Key("GoodBye")] IService2 _helloWorldService)
        {
            service = _helloWorldService;
            Debug.Log($"<Color=Green>Hello World Service injected</Color>:{_helloWorldService.GetType()}");
        }

        [Inject]
        public void Inject2(SpawnerTest[] _spawners)
        {
            spawners = _spawners;
            Assert.AreEqual(spawners.Length, 1);
        }


        private void Update()
        {
            if (service != null)
                service.ExecuteService2();

            // if (eventReceiverFactory != null)
            //     eventReceiverFactory.Do();
        }
    }
}
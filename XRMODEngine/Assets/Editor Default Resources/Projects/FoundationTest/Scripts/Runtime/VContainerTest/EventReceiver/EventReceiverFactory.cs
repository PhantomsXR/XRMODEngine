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

using System.Collections.Generic;
using FoundationTest.Runtime.Networks;
using UnityEngine;
using UnityEngine.Assertions;
using VContainer;

namespace FoundationTest.Runtime.EventReceiver
{
    public class EventReceiverFactory
    {
        private List<IEventReceiver> eventReceivers;
        private NetworkFactory networkFactory;
        [Inject] public int[] Values;

        [Inject]
        internal void Init(BuildEventReceivers _eventReceivers, NetworkFactory _networkFactory)
        {
            networkFactory = _networkFactory;
            Assert.IsNotNull(networkFactory);
            eventReceivers = _eventReceivers.GetEventReceivers;
            Assert.IsNotNull(eventReceivers);
        }

        internal void Do()
        {
            foreach (var receiver in eventReceivers)
            {
                receiver.DoSomething(networkFactory);
            }

            Assert.AreEqual(Values.Length, 3);
        }
    }
}
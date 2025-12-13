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

using FoundationTest.Runtime.Networks;

namespace FoundationTest.Runtime.EventReceiver
{
    public interface IEventReceiver
    {
        void DoSomething(NetworkFactory _factory);
    }
}
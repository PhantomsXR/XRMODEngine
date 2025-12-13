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

using Phantom.XRMOD.Core.Runtime;

namespace FoundationTest.Runtime.DataBinding
{
    public abstract class TutorialPhase:XRMODBehaviour
    {
        protected TutorialFlowManager flow;
        protected Guider guider; 
        internal virtual void StartPhase(TutorialFlowManager _flow)
        {
            flow = _flow;
           // guider ??= new Guider(flow.hintSystem);
            ExecutePhase();
        }

        protected abstract void ExecutePhase();

        protected void CompletePhase()
        {
            flow.OnPhaseComplete();
        }
    }
}
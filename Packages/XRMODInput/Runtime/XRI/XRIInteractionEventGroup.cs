// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODInput.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Filtering;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace Phantom.XRMOD.XRMODInput.Runtime
{
    public class XRIInteractionEventGroup : MonoBehaviour, IXRSelectFilter, IXRHoverFilter
    {
        private bool canProcess1;
        private bool canProcess2;

        public bool Process(IXRSelectInteractor interactor, IXRSelectInteractable interactable)
        {
            throw new System.NotImplementedException();
        }

        public bool Process(IXRHoverInteractor interactor, IXRHoverInteractable interactable)
        {
            throw new System.NotImplementedException();
        }

        bool IXRHoverFilter.canProcess => canProcess2;

        bool IXRSelectFilter.canProcess => canProcess1;
    }
}
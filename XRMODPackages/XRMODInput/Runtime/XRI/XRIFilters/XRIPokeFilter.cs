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
#if USE_XRI

using System;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Filtering;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace Phantom.XRMOD.XRMODInput.Runtime.XRIFilters
{
    public class XRIPokeFilter : MonoBehaviour, IXRPokeFilter
    {
        public Func<IXRInteractor, IXRInteractable, float, float> PokerFilterProcessValueAction;
        public Func<IXRSelectInteractor, IXRSelectInteractable, bool> PokerFilterProcessAction;

        public float Process(IXRInteractor _interactor, IXRInteractable _interactable, float _interactionStrength)
        {
            return PokerFilterProcessValueAction?.Invoke(_interactor, _interactable, _interactionStrength) ?? 0;
        }


        public bool Process(IXRSelectInteractor _interactor, IXRSelectInteractable _interactable)
        {
            return PokerFilterProcessAction == null || PokerFilterProcessAction.Invoke(_interactor, _interactable);
        }

        public bool canProcess => isActiveAndEnabled;
    }
}
#endif
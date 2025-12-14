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
    public class XRIInteractionStrengthFilter : MonoBehaviour, IXRInteractionStrengthFilter
    {
        public Func<IXRInteractor, IXRInteractable, float, float> InteractionStrengthFilterProcessValueAction;

        public float Process(IXRInteractor _interactor, IXRInteractable _interactable, float _interactionStrength)
        {
            return InteractionStrengthFilterProcessValueAction?.Invoke(_interactor, _interactable,
                _interactionStrength) ?? 0;
        }

        public bool canProcess => isActiveAndEnabled;
    }
}
#endif
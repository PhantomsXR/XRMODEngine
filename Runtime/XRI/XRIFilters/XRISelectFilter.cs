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
    public class XRISelectFilter : MonoBehaviour, IXRSelectFilter
    {
        private Func<IXRSelectInteractor, IXRSelectInteractable, bool> selectFilterProcessAction;

        public void Subscribe(Func<IXRSelectInteractor, IXRSelectInteractable, bool> _processAction)
        {
            selectFilterProcessAction += _processAction;
        }


        public void Unsubscribe(Func<IXRSelectInteractor, IXRSelectInteractable, bool> _processAction)
        {
            selectFilterProcessAction -= _processAction;
        }


        public bool Process(IXRSelectInteractor _interactor, IXRSelectInteractable _interactable)
        {
            return selectFilterProcessAction == null || selectFilterProcessAction.Invoke(_interactor, _interactable);
        }

        public bool canProcess => isActiveAndEnabled;
    }
}
#endif
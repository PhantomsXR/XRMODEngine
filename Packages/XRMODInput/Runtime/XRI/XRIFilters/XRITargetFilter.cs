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
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Filtering;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace Phantom.XRMOD.XRMODInput.Runtime.XRIFilters
{
    public class XRITargetFilter : MonoBehaviour, IXRTargetFilter
    {
        public Action<IXRInteractor> OnLink;
        public Action<IXRInteractor> OnUnlink;
        public Action<IXRInteractor, List<IXRInteractable>, List<IXRInteractable>> TargetProcessAction;

        public void Link(IXRInteractor _interactor)
        {
            OnLink?.Invoke(_interactor);
        }

        public void Unlink(IXRInteractor _interactor)
        {
            OnUnlink?.Invoke(_interactor);
        }

        public void Process(IXRInteractor _interactor, List<IXRInteractable> _targets, List<IXRInteractable> _results)
        {
            TargetProcessAction?.Invoke(_interactor, _targets, _results);
        }

        public bool canProcess => isActiveAndEnabled;
    }
}
#endif
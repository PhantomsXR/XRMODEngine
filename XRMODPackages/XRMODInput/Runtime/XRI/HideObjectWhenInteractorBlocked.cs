// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UXCore.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/
#if USE_XRI

using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals;


namespace Phantom.XRMOD.XRMODInput.Runtime
{
    /// <summary>
    /// Hides the specified GameObject when the associated interactor is blocked by an interaction within its group.
    /// </summary>
    public class HideObjectWhenInteractorBlocked : MonoBehaviour
    {
        [SerializeField]
        [Tooltip("The interactor that this component monitors for blockages.")]
        XRBaseInteractor m_Interactor;

        [SerializeField]
        [Tooltip("The GameObject to hide when the interactor is blocked.")]
        GameObject m_ObjectToHide;

        ICurveInteractionDataProvider m_CurveInteractionDataProvider;
        bool m_HasCurveDataProvider;

        /// <summary>
        /// See <see cref="MonoBehaviour"/>.
        /// </summary>
        void OnEnable()
        {
            if (m_Interactor == null || m_ObjectToHide == null)
                enabled = false;

            m_HasCurveDataProvider = false;
            if (m_Interactor is ICurveInteractionDataProvider provider)
            {
                m_CurveInteractionDataProvider = provider;
                m_HasCurveDataProvider = true;
            }
        }

        /// <summary>
        /// See <see cref="MonoBehaviour"/>.
        /// </summary>
        void Update()
        {
            if (m_HasCurveDataProvider)
                m_ObjectToHide.SetActive(m_CurveInteractionDataProvider.isActive);
            else
                m_ObjectToHide.SetActive(m_Interactor.isActiveAndEnabled && !m_Interactor.IsBlockedByInteractionWithinGroup());
        }
    }
}

#endif
// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UIFramework.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Phantom.XRMOD.UIFramework.Runtime
{
    [ExecuteInEditMode, RequireComponent(typeof(ImageWithIndependentRoundedCorners))]
    public class ListElementShaderBase : UIBehaviour
    {
        [SerializeField] private Vector4 singleElementCorner;
        [SerializeField] private Vector4 firstElementCorner;
        [SerializeField] private Vector4 middleElementCorner;
        [SerializeField] private Vector4 lastElementCorner;

        private ImageWithIndependentRoundedCorners imageWithIndependentRoundedCorners;

#if UNITY_EDITOR
        protected override void OnValidate()
        {
            base.OnValidate();
            if (imageWithIndependentRoundedCorners == null)
                imageWithIndependentRoundedCorners = GetComponent<ImageWithIndependentRoundedCorners>();

            UpdateElement();
        }
#endif

        protected override void OnEnable()
        {
            imageWithIndependentRoundedCorners = GetComponent<ImageWithIndependentRoundedCorners>();
            UpdateElement();
        }

        protected override void Start()
        {
            UpdateElement();
        }

        private void UpdateElement()
        {
            if (imageWithIndependentRoundedCorners == null)
                return;

            Transform parent = transform.parent;

            if (parent == null)
                return;

            int currentSiblingIndex = transform.GetSiblingIndex();
            Transform previousChild = null;
            Transform nextChild = null;

            for (int i = currentSiblingIndex - 1; i >= 0; i--)
            {
                if (parent.GetChild(i) != null && parent.GetChild(i).gameObject.activeSelf)
                {
                    previousChild = parent.GetChild(i);
                    break;
                }
            }

            for (int i = currentSiblingIndex + 1; i < parent.childCount; i++)
            {
                if (parent.GetChild(i) != null && parent.GetChild(i).gameObject.activeSelf)
                {
                    nextChild = parent.GetChild(i);
                    break;
                }
            }

            bool previousChildIsListElement =
                previousChild != null && previousChild.TryGetComponent<ListElementShaderBase>(out _);
            bool nextChildIsListElement = nextChild != null && nextChild.TryGetComponent<ListElementShaderBase>(out _);

            var targetCorner = singleElementCorner;

            if (previousChildIsListElement)
            {
                if (nextChildIsListElement)
                {
                    targetCorner = middleElementCorner;
                }
                else
                {
                    targetCorner = lastElementCorner;
                }
            }
            else
            {
                if (nextChildIsListElement)
                {
                    targetCorner = firstElementCorner;
                }
                else
                {
                    targetCorner = singleElementCorner;
                }
            }

            imageWithIndependentRoundedCorners.r = targetCorner;
        }

        public void SetReferences(Vector4 _newSingleElementCorner, Vector4 _newFirstElementCorner,
            Vector4 _newMiddleElementCorner, Vector4 _newLastElementCorner, List<Image> newAdditionalImages = null)
        {
            singleElementCorner = _newSingleElementCorner;
            firstElementCorner = _newFirstElementCorner;
            middleElementCorner = _newMiddleElementCorner;
            lastElementCorner = _newLastElementCorner;
        }
    }
}
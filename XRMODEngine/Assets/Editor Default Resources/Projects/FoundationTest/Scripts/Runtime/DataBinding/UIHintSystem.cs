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

using System.Collections;
using Phantom.XRMOD.Core.Runtime;
using TMPro;
using UnityEngine;

namespace FoundationTest.Runtime.DataBinding
{
    public class UIHintSystem : XRMODBehaviour
    {
        [SerializeField] private TextMeshProUGUI hintText;
        [SerializeField] private CanvasGroup canvasGroup;

        internal void ShowSpeechBubble(string _text, float _waitTime = 3f)
        {
            StartCoroutine(Show(_text, _waitTime));
        }

        private IEnumerator Show(string _text, float _waitTime = 3f)
        {
            hintText.text = _text;
            LeanTween.alphaCanvas(canvasGroup, 1f, 0.125f);
            yield return new WaitForSeconds(_waitTime);
            LeanTween.alphaCanvas(canvasGroup, 0f, 0.125f);
        }
    }
}
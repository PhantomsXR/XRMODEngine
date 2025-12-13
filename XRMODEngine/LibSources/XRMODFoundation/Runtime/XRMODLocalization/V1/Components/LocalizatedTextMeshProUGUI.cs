// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Localization.Runtime.
// //
// // The Localization cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using TMPro;
using UnityEngine;

namespace Phantom.XRMOD.Localization.Runtime
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class LocalizatedTextMeshProUGUI : BaseLocalizedTextComponent
    {
        private TextMeshProUGUI textMeshProUgui;

        internal override void Start()
        {
            base.Start();
            textMeshProUgui = GetComponent<TextMeshProUGUI>();
        }

        public override void UpdateContent(string _string)
        {
            if (!textMeshProUgui)
            {
                textMeshProUgui = GetComponent<TextMeshProUGUI>();
            }

            textMeshProUgui.text = _string;
        }
    }
}
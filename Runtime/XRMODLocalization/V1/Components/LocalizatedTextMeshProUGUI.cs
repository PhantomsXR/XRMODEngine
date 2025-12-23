/*===============================================================================
Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Localization.Runtime.

The Localization cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using TMPro;
using UnityEngine;

namespace Phantom.XRMOD.Localization.Runtime
{
    /// <summary>
    /// Localizes a <see cref="TextMeshProUGUI"/> component within a UGUI canvas.
    /// Requires a <see cref="TextMeshProUGUI"/> component on the same GameObject.
    /// </summary>
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class LocalizatedTextMeshProUGUI : BaseLocalizedTextComponent
    {
        private TextMeshProUGUI textMeshProUgui;

        protected override void Start()
        {
            base.Start();
            textMeshProUgui = GetComponent<TextMeshProUGUI>();
        }

        /// <summary>
        /// Updates the text content of the <see cref="TextMeshProUGUI"/> component.
        /// </summary>
        /// <param name="_string">The new localized string.</param>
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
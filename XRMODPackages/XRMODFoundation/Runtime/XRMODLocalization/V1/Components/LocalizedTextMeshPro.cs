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
    /// Localizes a <see cref="TextMeshPro"/> component (3D text).
    /// Requires a <see cref="TextMeshPro"/> component on the same GameObject.
    /// </summary>
    [RequireComponent(typeof(TextMeshPro))]
    public class LocalizedTextMeshPro : BaseLocalizedTextComponent
    {
        private TextMeshPro textMeshPro;

        protected override void Start()
        {
            base.Start();
            textMeshPro = GetComponent<TextMeshPro>();
        }

        /// <summary>
        /// Updates the text content of the <see cref="TextMeshPro"/> component.
        /// </summary>
        /// <param name="_string">The new localized string.</param>
        public override void UpdateContent(string _string)
        {
            if (!textMeshPro)
                textMeshPro = GetComponent<TextMeshPro>();
            
            textMeshPro.text = _string;
        }
    }
}
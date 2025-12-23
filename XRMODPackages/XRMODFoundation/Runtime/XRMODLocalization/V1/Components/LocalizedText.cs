/*===============================================================================
Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Localization.Runtime.

The Localization cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using UnityEngine;
using UnityEngine.UI;

namespace Phantom.XRMOD.Localization.Runtime
{
    /// <summary>
    /// Localizes a built-in Unity UGUI <see cref="Text"/> component.
    /// Requires a <see cref="Text"/> component on the same GameObject.
    /// </summary>
    [RequireComponent(typeof(Text))]
    public class LocalizedText : BaseLocalizedTextComponent
    {
        private Text text;

        protected override void Start()
        {
            base.Start();
            text = GetComponent<Text>();
        }

        /// <summary>
        /// Updates the string content of the <see cref="Text"/> component.
        /// </summary>
        /// <param name="_string">The new localized string.</param>
        public override void UpdateContent(string _string)
        {
            if (!text)
            {
                text = GetComponent<Text>();
            }

            text.text = _string;
        }
    }
}
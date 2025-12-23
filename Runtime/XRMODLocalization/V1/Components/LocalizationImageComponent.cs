/*===============================================================================
Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.Localization.Runtime.

The XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using UnityEngine;
using UnityEngine.UI;

namespace Phantom.XRMOD.Localization.Runtime
{
    /// <summary>
    /// Localizes a UGUI <see cref="Image"/> component by updating its <see cref="Sprite"/>.
    /// Requires an <see cref="Image"/> component on the same GameObject.
    /// </summary>
    [RequireComponent(typeof(Image))]
    public class LocalizationImageComponent : BaseLocalizedImageComponent
    {
        private Image image;

        protected override void Start()
        {
            base.Start();
            image = GetComponent<Image>();
        }

        /// <summary>
        /// Sets the localization key and registers this component with the <see cref="LocalizationManager"/> for image updates.
        /// </summary>
        /// <param name="_key">The unique localization key.</param>
        public override void SetKey(string _key)
        {
            base.SetKey(_key);
            LocalizationManager.Instance.AddImage(this, localizationScope);
        }

        /// <summary>
        /// Updates the <see cref="Sprite"/> of the <see cref="Image"/> component.
        /// </summary>
        /// <param name="_value">The new localized <see cref="Sprite"/>.</param>
        public override void UpdateContent(Sprite _value)
        {
            if (image == null)
                image = GetComponent<Image>();

            image.sprite = _value;
        }
    }
}
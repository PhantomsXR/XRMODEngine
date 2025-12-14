// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Localization.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;
using UnityEngine.UI;

namespace Phantom.XRMOD.Localization.Runtime
{
    [RequireComponent(typeof(Image))]
    public class LocalizationImageComponent : BaseLocalizedImageComponent
    {
        private Image image;

        protected override void Start()
        {
            base.Start();
            image = GetComponent<Image>();
        }

        public override void SetKey(string _key)
        {
            base.SetKey(_key);
            LocalizationManager.Instance.AddImage(this, localizationScope);
        }

        public override void UpdateContent(Sprite _value)
        {
            if (image == null)
                image = GetComponent<Image>();

            image.sprite = _value;
        }
    }
}
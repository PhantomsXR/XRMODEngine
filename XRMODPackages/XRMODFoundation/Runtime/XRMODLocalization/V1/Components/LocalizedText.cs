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

using System.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Phantom.XRMOD.Localization.Runtime
{
    [RequireComponent(typeof(Text))]
    public class LocalizedText : BaseLocalizedTextComponent
    {
        private Text text;

        internal override void Start()
        {
            base.Start();
            text = GetComponent<Text>();
        }

        public override void UpdateContent(string _stirng)
        {
            if (!text)
            {
                text = GetComponent<Text>();
            }

            text.text = _stirng;
        }
    }
}
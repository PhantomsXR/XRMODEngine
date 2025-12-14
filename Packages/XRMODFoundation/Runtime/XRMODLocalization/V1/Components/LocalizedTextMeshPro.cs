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

namespace Phantom.XRMOD.Localization.Runtime
{
    [RequireComponent(typeof(TextMeshPro))]
    public class LocalizedTextMeshPro : BaseLocalizedTextComponent
    {
        private TextMeshPro textMeshPro;

        internal override void Start()
        {
            base.Start();
            textMeshPro = GetComponent<TextMeshPro>();
        }

        public override void UpdateContent(string _string)
        {
            if (!textMeshPro)
                textMeshPro = GetComponent<TextMeshPro>();
            textMeshPro.text = _string;
        }
    }
}
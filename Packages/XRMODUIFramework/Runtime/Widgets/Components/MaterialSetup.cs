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

using UnityEngine;
using UnityEngine.UI;

namespace Phantom.XRMOD.UIFramework.Runtime
{
    public class MaterialSetup : MonoBehaviour
    {
        private static readonly int _PROPS = Shader.PropertyToID("_WidthHeightRadius");
        private static readonly int _PROP_OUTER_UV = Shader.PropertyToID("_OuterUV");


        public float Radius = 40f;
        internal Material MaterialTemplate;

        private Material material;
        private Vector4 outerUV = new(0, 0, 1, 1);

        [HideInInspector, SerializeField] private MaskableGraphic image;

        private void OnValidate()
        {
            Validate();
            Refresh();
        }

        private void OnDestroy()
        {
            if (image != null)
            {
                //This makes so that when the component is removed, the UI material returns to null
                image.material = null;

                if (material)
                    DestroyHelper.Destroy(material);
            }

            image = null;
            material = null;
        }

        private void OnEnable()
        {
            //You can only add either ImageWithRoundedCorners or ImageWithIndependentRoundedCorners
            //It will replace the other component when added into the object.
            var tmp_Other = GetComponent<ImageWithIndependentRoundedCorners>();
            if (tmp_Other != null)
            {
                Radius = tmp_Other.r.x; //When it does, transfer the radius value to this script
                DestroyHelper.Destroy(tmp_Other);
            }

            Validate();
            Refresh();
        }

        private void OnRectTransformDimensionsChange()
        {
            if (enabled && material != null)
            {
                Refresh();
            }
        }

        public void Validate()
        {
            if (material == null)
            {
                if (material == null && MaterialTemplate)
                {
                    material = new Material(MaterialTemplate);
                }
            }

            if (image == null)
            {
                TryGetComponent(out image);
            }

            if (image != null && material)
            {
                image.material = material;
            }

            if (image is Image uiImage && uiImage.sprite != null)
            {
                outerUV = UnityEngine.Sprites.DataUtility.GetOuterUV(uiImage.sprite);
            }
        }

        public void Refresh()
        {
            if (material == null) return;
            var rect = ((RectTransform) transform).rect;
            //Multiply radius value by 2 to make the radius value appear consistent with ImageWithIndependentRoundedCorners script.
            //Right now, the ImageWithIndependentRoundedCorners appears to have double the radius than this.
            material.SetVector(_PROPS, new Vector4(rect.width, rect.height, Radius * 2, 0));
            material.SetVector(_PROP_OUTER_UV, outerUV);
        }
    }
}
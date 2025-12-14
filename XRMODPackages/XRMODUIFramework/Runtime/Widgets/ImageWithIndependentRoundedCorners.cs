// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UIFramework.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.UIFramework.Runtime;
using UnityEngine;
using UnityEngine.UI;

namespace Phantom.XRMOD.UIFramework.Runtime
{
    [ExecuteInEditMode] //Required to do validation with OnEnable()
    [DisallowMultipleComponent] //You can only have one of these in every object
    [RequireComponent(typeof(RectTransform))]
    public class ImageWithIndependentRoundedCorners : MonoBehaviour
    {
        private static readonly int prop_halfSize = Shader.PropertyToID("_halfSize");
        private static readonly int prop_radiuses = Shader.PropertyToID("_r");
        private static readonly int prop_rect2props = Shader.PropertyToID("_rect2props");
        private static readonly int prop_OuterUV = Shader.PropertyToID("_OuterUV");

        // Vector2.right rotated clockwise by 45 degrees
        private static readonly Vector2 wNorm = new Vector2(.7071068f, -.7071068f);

        // Vector2.right rotated counter-clockwise by 45 degrees
        private static readonly Vector2 hNorm = new Vector2(.7071068f, .7071068f);

        public Vector4 r = new Vector4(40f, 40f, 40f, 40f);
        private Material material;
        private Vector4 outerUV = new Vector4(0, 0, 1, 1);

        // xy - position,
        // zw - halfSize
        [HideInInspector, SerializeField] private Vector4 rect2props;
        [HideInInspector, SerializeField] private MaskableGraphic image;


        private const string _CONST_SHADER_NAME = "Shader Graphs/IndependentRoundedCornersUI";

        private void OnValidate()
        {
            Validate();
            Refresh();
        }

        private void OnEnable()
        {
            //You can only add either ImageWithRoundedCorners or ImageWithIndependentRoundedCorners
            //It will replace the other component when added into the object.
            var other = GetComponent<ImageWithRoundedCorners>();
            if (other != null)
            {
                r = Vector4.one * other.radius; //When it does, transfer the radius value to this script
                DestroyHelper.Destroy(other);
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

        private void OnDestroy()
        {
            if (image != null)
            {
                image.material =
                    null; //This makes so that when the component is removed, the UI material returns to null
            }

            DestroyHelper.Destroy(material);
            image = null;
            material = null;
        }

        public void Validate()
        {
            if (material == null)
            {
                material = new Material(Shader.Find(_CONST_SHADER_NAME));
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
            var rect = ((RectTransform) transform).rect;
            RecalculateProps(rect.size);
            material.SetVector(prop_rect2props, rect2props);
            material.SetVector(prop_halfSize, rect.size * .5f);
            material.SetVector(prop_radiuses, r);
            material.SetVector(prop_OuterUV, outerUV);
        }

        private void RecalculateProps(Vector2 size)
        {
            // Vector that goes from left to right sides of rect2
            var aVec = new Vector2(size.x, -size.y + r.x + r.z);

            // Project vector aVec to wNorm to get magnitude of rect2 width vector
            var halfWidth = Vector2.Dot(aVec, wNorm) * .5f;
            rect2props.z = halfWidth;


            // Vector that goes from bottom to top sides of rect2
            var bVec = new Vector2(size.x, size.y - r.w - r.y);

            // Project vector bVec to hNorm to get magnitude of rect2 height vector
            var halfHeight = Vector2.Dot(bVec, hNorm) * .5f;
            rect2props.w = halfHeight;


            // Vector that goes from left to top sides of rect2
            var efVec = new Vector2(size.x - r.x - r.y, 0);

            // Vector that goes from point E to point G, which is top-left of rect2
            var egVec = hNorm * Vector2.Dot(efVec, hNorm);

            // Position of point E relative to center of coord system
            var ePoint = new Vector2(r.x - (size.x / 2), size.y / 2);

            // Origin of rect2 relative to center of coord system
            // ePoint + egVec == vector to top-left corner of rect2
            // wNorm * halfWidth + hNorm * -halfHeight == vector from top-left corner to center
            var origin = ePoint + egVec + wNorm * halfWidth + hNorm * -halfHeight;
            rect2props.x = origin.x;
            rect2props.y = origin.y;
        }
    }
}

/// <summary>
/// Display Vector4 as 4 separate fields for each corners.
/// It's way easier to use than w,x,y,z in Vector4.
/// </summary>
#if UNITY_EDITOR
[UnityEditor.CustomEditor(typeof(ImageWithIndependentRoundedCorners))]
public class Vector4Editor : UnityEditor.Editor
{
    public override void OnInspectorGUI()
    {
        //DrawDefaultInspector();

        serializedObject.Update();

        UnityEditor.SerializedProperty tmp_Vector4Prop = serializedObject.FindProperty("r");

        UnityEditor.EditorGUILayout.PropertyField(tmp_Vector4Prop.FindPropertyRelative("x"),
            new GUIContent("Top Left Corner"));
        UnityEditor.EditorGUILayout.PropertyField(tmp_Vector4Prop.FindPropertyRelative("y"),
            new GUIContent("Top Right Corner"));
        UnityEditor.EditorGUILayout.PropertyField(tmp_Vector4Prop.FindPropertyRelative("w"),
            new GUIContent("Bottom Left Corner"));
        UnityEditor.EditorGUILayout.PropertyField(tmp_Vector4Prop.FindPropertyRelative("z"),
            new GUIContent("Bottom Right Corner"));

        serializedObject.ApplyModifiedProperties();
    }
}
#endif
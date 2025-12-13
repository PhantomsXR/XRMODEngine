/*===============================================================================
Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.

This file is part of the Phantom.XRMOD.PackageTools.Editor.

The XR-MOD cannot be copied, distributed, or made available to
third-parties for commercial purposes without written permission of PhantomsXR Ltd.

Contact nswell@phantomsxr.com for licensing requests.
===============================================================================*/

using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.XRMODPackageTools.Editor.Previewers
{
    public class GameObjectPreview : BaseAssetPreview
    {
        private PreviewRenderUtility _previewUtility;
        private GameObject _previewInstance;
        private Vector2 _previewRotation = new Vector2(120, -20);

        public override void DrawPreview(VisualElement container, Object asset)
        {
            _previewUtility = new PreviewRenderUtility();
            _previewUtility.cameraFieldOfView = 30f;

            if (asset is Material mat)
            {
                var sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                sphere.GetComponent<Renderer>().sharedMaterial = mat;
                _previewInstance = sphere;
            }
            else if (asset is GameObject go)
            {
                _previewInstance = (GameObject) Object.Instantiate(go);
            }

            if (_previewInstance == null) return;

            SetupPreviewScene(_previewInstance);

            var previewElement = new IMGUIContainer(() =>
            {
                float fallbackWidth = EditorGUIUtility.currentViewWidth * 0.5f;
                float width = container.resolvedStyle.width;
                if (width < 1) width = fallbackWidth;

                float height = Mathf.Min(400, width * 0.75f);
                // Ensure we have a valid rect
                Rect r = GUILayoutUtility.GetRect(width, height, GUILayout.ExpandWidth(true));

                Event evt = Event.current;
                if (evt.type == EventType.MouseDrag && r.Contains(evt.mousePosition))
                {
                    _previewRotation += evt.delta;
                    evt.Use();
                    container.MarkDirtyRepaint();
                }

                if (_previewUtility == null) return;

                _previewUtility.BeginPreview(r, GUIStyle.none);

                _previewUtility.camera.transform.position = Vector3.zero;
                _previewUtility.camera.nearClipPlane = 0.001f;
                _previewUtility.camera.farClipPlane = 1000f;
                Quaternion rot = Quaternion.Euler(_previewRotation.y, -_previewRotation.x, 0);
                Vector3 dir = rot * Vector3.forward;
                _previewUtility.camera.transform.position = -dir * 5f;
                _previewUtility.camera.transform.LookAt(Vector3.zero);

                _previewUtility.Render(true);
                Texture tex = _previewUtility.EndPreview();
                if (tex != null)
                    GUI.DrawTexture(r, tex, ScaleMode.ScaleToFit, false);
            });

            previewElement.style.flexGrow = 1;
            previewElement.style.minHeight = 200;
            previewElement.style.marginBottom = 10;
            container.Add(previewElement);
        }

        private void SetupPreviewScene(GameObject previewGO)
        {
            _previewUtility.AddSingleGO(previewGO);
            _previewUtility.camera.transform.position = new Vector3(0, 0, -5);
            _previewUtility.camera.transform.LookAt(Vector3.zero);
            _previewUtility.lights[0].intensity = 1.2f;
            _previewUtility.lights[0].transform.rotation = Quaternion.Euler(50f, 50f, 0f);
            _previewUtility.lights[1].intensity = 0.5f;
        }

        public override void Cleanup()
        {
            if (_previewInstance != null)
            {
                Object.DestroyImmediate(_previewInstance);
                _previewInstance = null;
            }

            if (_previewUtility != null)
            {
                _previewUtility.Cleanup();
                _previewUtility = null;
            }
        }
    }
}

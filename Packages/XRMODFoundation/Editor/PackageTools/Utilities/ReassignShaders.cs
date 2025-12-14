// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PackageTools.Editor.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class ShaderReassignTool : UnityEditor.Editor
    {
        [MenuItem("Tools/XR-MOD/Tools/Shader Reassign")]
        private static void ReassignShaders()
        {
            GameObject[] tmp_SelectedObjects =
                FindObjectsByType<GameObject>(FindObjectsInactive.Include, FindObjectsSortMode.None);
            if (tmp_SelectedObjects.Length == 0)
            {
                return;
            }

            int tmp_UpdatedCount = 0;
            foreach (GameObject tmp_Obj in tmp_SelectedObjects)
            {
                if (tmp_Obj == null) continue;
                Renderer[] tmp_Renderers = tmp_Obj.GetComponentsInChildren<Renderer>() ??
                                           throw new ArgumentNullException($"Object is null");
                foreach (Renderer tmp_Renderer in tmp_Renderers)
                {
                    foreach (Material tmp_Material in tmp_Renderer.sharedMaterials)
                    {
                        if (tmp_Material != null)
                        {
                            Shader tmp_Shader = Shader.Find(tmp_Material.shader.name);
                            if (tmp_Shader != null)
                            {
                                tmp_Material.shader = tmp_Shader;
                                tmp_UpdatedCount++;
                            }
                            else
                            {
                                Debug.LogWarning($"Shader '{tmp_Material.shader.name}' not found.");
                            }
                        }
                    }
                }
            }

            Debug.Log($"{tmp_UpdatedCount} shaders have been fixed.");
        }
    }
}
// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XRMODEngineSettings.Editor.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEditor;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.Setup.Editor
{
    public class InputSystemDrawer : AbstractDrawer, IFixer
    {
        private const string _CONST_INPUT_SYSTEM_ERROR =
            "You need set Active Input Handling to Both. Project Setting->Player->Others Settings->Active Input Handling";

        public override VisualElement CreateVisualElement()
        {
            return DrawUtility.CreateSettingStateUI("InputSystem", _CONST_INPUT_SYSTEM_ERROR, () => CheckInputSystem(),
                CheckedTexture,
                ErrorTexture, FixInputSystem);
        }

        private void FixInputSystem()
        {
            try
            {
                var tmp_ProjectSettings = AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/ProjectSettings.asset")[0];
                var tmp_SerializedObject = new SerializedObject(tmp_ProjectSettings);
                var tmp_Property = tmp_SerializedObject.FindProperty("activeInputHandler");
                if (tmp_Property != null)
                {
                    tmp_Property.intValue = 2; // Both
                    tmp_SerializedObject.ApplyModifiedProperties();
                    
                    if (EditorUtility.DisplayDialog("Restart Required", 
                            "Active Input Handling changed to 'Both'. Unity must restart to apply changes.", 
                            "Restart Now", "Later"))
                    {
                        EditorApplication.OpenProject(System.Environment.CurrentDirectory);
                    }
                }
                else
                {
                    // Fallback for older versions or unexpected structure
                    EditorUtility.DisplayDialog("Tips", _CONST_INPUT_SYSTEM_ERROR, "OK");
                }
            }
            catch(System.Exception)
            {
                EditorUtility.DisplayDialog("Tips", _CONST_INPUT_SYSTEM_ERROR, "OK");
            }
        }

        private bool CheckInputSystem()
        {
#if ENABLE_INPUT_SYSTEM && ENABLE_LEGACY_INPUT_MANAGER
            return true;
#else
            try
            {
                var tmp_Assets = AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/ProjectSettings.asset");
                if (tmp_Assets == null || tmp_Assets.Length == 0) return false;
                
                using (var tmp_SerializedObject = new SerializedObject(tmp_Assets[0]))
                {
                    var tmp_Property = tmp_SerializedObject.FindProperty("activeInputHandler");
                    // 0: Legacy, 1: New, 2: Both
                    return tmp_Property != null && tmp_Property.intValue == 2;
                }
            }
            catch
            {
                return false;
            }
#endif
        }

        void IFixer.DoFix()
        {
            FixInputSystem();
        }
    }
}
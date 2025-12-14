// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XRMODEngineSettings.Editor.
// //
// // The ARMOD-DevelopmentKit cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.Setup.Editor
{
    public class ShadersValidationDrawer : AbstractDrawer, IFixer
    {
        private const string PLATFORM_HELP = "Missing essential Shader will not allow to use some functions correctly.";
        private const string _CONST_POINT_CLOUD = "Shaders/pointCloud";
        private const string _CONST_SHADER_COLLECTION = "glTFShaderVariants";

        public override VisualElement CreateVisualElement()
        {
            return DrawUtility.CreateSettingStateUI("Shaders", PLATFORM_HELP, () => ShadersValidation(), CheckedTexture,
                ErrorTexture, FixError);
        }

        private void FixError()
        {
            using (var tmp_GraphicsObject = GetGraphicsSettingsObject())
            {
                if (tmp_GraphicsObject == null) return;
                var tmp_AlwaysIncludedShadersProperty = tmp_GraphicsObject.FindProperty("m_AlwaysIncludedShaders");
                // var tmp_PreloadedShadersProperty = tmp_GraphicsObject.FindProperty("m_PreloadedShaders");

                if (!IsShaderExist(_CONST_POINT_CLOUD, tmp_AlwaysIncludedShadersProperty))
                {
                    var tmp_Idx = tmp_AlwaysIncludedShadersProperty.arraySize;
                    tmp_AlwaysIncludedShadersProperty.InsertArrayElementAtIndex(tmp_Idx);
                    var tmp_ArrayElem = tmp_AlwaysIncludedShadersProperty.GetArrayElementAtIndex(tmp_Idx);
                    tmp_ArrayElem.objectReferenceValue = GetShader(_CONST_POINT_CLOUD);
                    tmp_GraphicsObject.ApplyModifiedProperties();
                }
            }
        }

        private bool ShadersValidation()
        {
#if (UNITY_IOS || UNITY_ANDROID) && HANDHELD_ARMODULE_INSTALL
            using (var tmp_GraphicsObject = GetGraphicsSettingsObject())
            {
                if (tmp_GraphicsObject == null) return true;
                var tmp_AlwaysIncludedShadersProperty = tmp_GraphicsObject.FindProperty("m_AlwaysIncludedShaders");
                return IsShaderExist(_CONST_POINT_CLOUD, tmp_AlwaysIncludedShadersProperty);
            }
#else
            return true;
#endif
        }

        private SerializedObject GetGraphicsSettingsObject()
        {
            var tmp_GraphicsSettingsObj =
                AssetDatabase.LoadAssetAtPath<GraphicsSettings>("ProjectSettings/GraphicsSettings.asset");
            if (tmp_GraphicsSettingsObj == null) return null;
            return new SerializedObject(tmp_GraphicsSettingsObj);
        }

        private Shader GetShader(string _shaderName) => Resources.Load<Shader>(_shaderName);

        private bool IsShaderExist(string _shaderName, SerializedProperty _property)
        {
            var tmp_Shader = GetShader(_shaderName);
            if (tmp_Shader == null || _property == null) return false;

            for (int i = 0; i < _property.arraySize; ++i)
            {
                var arrayElem = _property.GetArrayElementAtIndex(i);
                if (tmp_Shader != arrayElem.objectReferenceValue) continue;
                return true;
            }

            return false;
        }

        void IFixer.DoFix()
        {
            FixError();
        }
    }
}
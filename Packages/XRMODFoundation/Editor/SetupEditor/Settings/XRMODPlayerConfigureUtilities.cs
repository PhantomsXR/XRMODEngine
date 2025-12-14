// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XRMODInitializer.Editor.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

namespace Phantom.XRMOD.Setup.Editor
{
    [Obsolete("Deprecated.", true)]
    public class XRMODPlayerConfigureUtilities
    {
        private static BuildTarget GetBuildTarget() => EditorUserBuildSettings.activeBuildTarget;

        private static BuildTargetGroup GetBuildTargetGroup()
            => BuildPipeline.GetBuildTargetGroup(EditorUserBuildSettings.activeBuildTarget);

        private static readonly string[] _TAGS =
            {"UICamera", "ARSessionOrigin", "ARSession", "Enemy", "Item", "Projectile", "NPC", "Fx"};

        private static readonly Dictionary<int, string> _LAYERS = new()
        {
            {6, "Enemy"},
            {7, "Player"},
            {10, "Item"},
            {11, "NPC"},
            {12, "Projectile"},
            {13, "Other"},
            {14, "Teleport"},
            {15, "Grab"},
            {17, "Interactable"},
        };

        private const string _CONST_POINT_CLOUD = "Shaders/pointCloud";

        public static void GraphicsSetup()
        {
            PlayerSettings.SetUseDefaultGraphicsAPIs(GetBuildTarget(), false);
            PlayerSettings.SetGraphicsAPIs(GetBuildTarget(), new GraphicsDeviceType[1]
            {
                GraphicsDeviceType.OpenGLES3
            });
        }

        public static void AndroidMinSDKVersionSetup()
        {
            PlayerSettings.Android.minSdkVersion = AndroidSdkVersions.AndroidApiLevel29;
        }

        public static void ApiCompatibilitySetup()
        {
            PlayerSettings.SetApiCompatibilityLevel(GetBuildTargetGroup(), ApiCompatibilityLevel.NET_Unity_4_8);
        }

        public static void ColorSpaceSetup()
        {
            PlayerSettings.colorSpace = ColorSpace.Linear;
        }

        public static void TagsAndLayersSetup()
        {
            var tmp_Tags = UnityEditorInternal.InternalEditorUtility.tags.ToList();
            var tmp_Layers = UnityEditorInternal.InternalEditorUtility.layers.ToList();

            foreach (string tmp_Tag in _TAGS)
            {
                if (tmp_Tags.Contains(tmp_Tag))
                {
                    continue;
                }

                UnityEditorInternal.InternalEditorUtility.AddTag(tmp_Tag);
            }


            //Modify layers
            var tmp_TagManager =
                new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/TagManager.asset")[0]);
            SerializedProperty tmp_SerializedLayers = tmp_TagManager.FindProperty("layers");

            if (tmp_SerializedLayers == null || !tmp_SerializedLayers.isArray) return;

            foreach (var tmp_Element in _LAYERS)
            {
                if (tmp_Layers.Contains(tmp_Element.Value))
                {
                    continue;
                }

                SerializedProperty tmp_LayerProperties = tmp_SerializedLayers.GetArrayElementAtIndex(tmp_Element.Key);
                tmp_LayerProperties.stringValue = tmp_Element.Value;
            }

            tmp_TagManager.ApplyModifiedProperties();
        }

        public static void InputSystemSetup()
        {
            var tmp_ProjectSettings =
                new SerializedObject(AssetDatabase.LoadAllAssetsAtPath("ProjectSettings/ProjectSettings.asset")[0]);
            tmp_ProjectSettings.FindProperty("activeInputHandler").intValue = 2;
            tmp_ProjectSettings.ApplyModifiedProperties();
        }

        public static void RuntimeSceneSetup()
        {
        }

        public static void ScriptingBackedSetup()
        {
            PlayerSettings.SetScriptingBackend(GetBuildTargetGroup(), ScriptingImplementation.IL2CPP);

#if UNITY_ANDROID
            PlayerSettings.SetIl2CppCompilerConfiguration(GetBuildTargetGroup(), Il2CppCompilerConfiguration.Release);
#elif UNITY_WSA
            PlayerSettings.SetIl2CppCompilerConfiguration(GetBuildTargetGroup(),Il2CppCompilerConfiguration.Release);
#elif UNITY_WEBGL
            PlayerSettings.SetIl2CppCompilerConfiguration(GetBuildTargetGroup(),Il2CppCompilerConfiguration.Release);
#else
#endif
        }

        public static void ShaderListSetup()
        {
            var tmp_GraphicsSettingsObj =
                AssetDatabase.LoadAssetAtPath<GraphicsSettings>("ProjectSettings/GraphicsSettings.asset");
            var tmp_GraphicsObject = new SerializedObject(tmp_GraphicsSettingsObj);
            var tmp_Shader = Resources.Load<Shader>(_CONST_POINT_CLOUD);

            if (tmp_Shader == null) return;

            var tmp_AlwaysIncludedShadersProperty = tmp_GraphicsObject.FindProperty("m_AlwaysIncludedShaders");
            for (int i = 0; i < tmp_GraphicsObject.FindProperty("m_AlwaysIncludedShaders").arraySize; ++i)
            {
                var arrayElem = tmp_AlwaysIncludedShadersProperty.GetArrayElementAtIndex(i);
                if (tmp_Shader != arrayElem.objectReferenceValue) continue;
            }

            var tmp_Idx = tmp_AlwaysIncludedShadersProperty.arraySize;
            tmp_AlwaysIncludedShadersProperty.InsertArrayElementAtIndex(tmp_Idx);
            var tmp_ArrayElem = tmp_AlwaysIncludedShadersProperty.GetArrayElementAtIndex(tmp_Idx);
            tmp_ArrayElem.objectReferenceValue = tmp_Shader;
            tmp_GraphicsObject.ApplyModifiedProperties();
        }
    }
}
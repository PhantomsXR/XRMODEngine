// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UIFramework.Editor.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;

namespace Phantom.XRMOD.UIFramework.Editor
{
    using UnityEngine;
    using UnityEditor;

    [Obsolete("Removed", true)]
    public class CurveToClipUtility : EditorWindow
    {
        private AnimationCurve curve = AnimationCurve.Linear(0, 0, 1, 1);
        private string propertyName = "m_LocalScale.x";
        private string clipName = "NewCurveClip";

        private static void OpenWindow()
        {
            GetWindow<CurveToClipUtility>("Curve To Clip");
        }

        private void OnGUI()
        {
            GUILayout.Label("🎬 Curve → AnimationClip", EditorStyles.boldLabel);

            curve = EditorGUILayout.CurveField("Animation Curve", curve);
            propertyName = EditorGUILayout.TextField("Property Name", propertyName);
            clipName = EditorGUILayout.TextField("Clip Name", clipName);

            EditorGUILayout.HelpBox(
                "⚡ Property Name Example：\n" +
                "- m_LocalPosition.x\n" +
                "- m_LocalScale.y\n" +
                "- m_LocalRotation.z\n" +
                "- m_LocalEulerAnglesRaw.y\n" +
                "- material._Color.r\n",
                MessageType.Info
            );

            if (GUILayout.Button("生成并保存 AnimationClip"))
            {
                CreateAndSaveClip(curve, propertyName, clipName);
            }
        }

        private void CreateAndSaveClip(AnimationCurve curve, string property, string name)
        {
            AnimationClip clip = new AnimationClip();
            clip.legacy = false; // Animator 可用

            // 绑定曲线到 Transform（缺省路径 = 当前 GameObject）
            clip.SetCurve("", typeof(Transform), property, curve);

            string path = EditorUtility.SaveFilePanelInProject(
                "Save AnimationClip",
                name,
                "anim",
                "Please select the save path"
            );

            if (!string.IsNullOrEmpty(path))
            {
                AssetDatabase.CreateAsset(clip, path);
                AssetDatabase.SaveAssets();
                EditorUtility.DisplayDialog("Success", $"Saved AnimationClip at: {path}", "OK");
            }
        }
    }
}
// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UIFramework.Editor.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

#if USE_TIMELINE
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.Timeline;

namespace Phantom.XRMOD.UIFramework.Editor
{
    [MenuEntry("Tools/Reverse Animation Track")]
    class TimelineTrackReverseClipMenu : ClipAction
    {
        public override ActionValidity Validate(IEnumerable<TimelineClip> _timelineClips)
        {
            return ActionValidity.Valid;
        }

        public override bool Execute(IEnumerable<TimelineClip> _timelineClips)
        {
            // 获取当前 Timeline 中的选中 clip
            TimelineClip[] tmp_SelectedClips = _timelineClips.ToArray();

            if (tmp_SelectedClips.Length == 0)
            {
                Debug.LogWarning("No clip selected.");
                return false;
            }

            foreach (var tmp_Clip in tmp_SelectedClips)
            {
                // 只处理动画片段（AnimationPlayableAsset）
                if (tmp_Clip.asset is AnimationPlayableAsset tmp_AnimPlayable)
                {
                    AnimationClip tmp_OriginalClip = tmp_AnimPlayable.clip;

                    if (tmp_OriginalClip == null)
                    {
                        Debug.LogWarning("Clip has no AnimationClip.");
                        continue;
                    }

                    // 创建倒放的 AnimationClip
                    AnimationClip tmp_ReversedClip =
                        CreateReversedAnimationClip(tmp_OriginalClip, tmp_Clip.displayName);
                    if (tmp_ReversedClip == null) continue;

                    // 替换 clip 内容
                    Undo.RecordObject(tmp_Clip.asset, "Reverse Animation Clip");
                    tmp_AnimPlayable.clip = tmp_ReversedClip;
                }
                else
                {
                    Debug.LogWarning("Selected clip is not an AnimationPlayableAsset.");
                }
            }

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            return true;
        }


        AnimationClip CreateReversedAnimationClip(AnimationClip _original, string _name)
        {
            string tmp_Path = AssetDatabase.GetAssetPath(_original);

            AnimationClip tmp_NewClip = new AnimationClip();
            EditorUtility.CopySerialized(_original, tmp_NewClip);

            float tmp_ClipLength = _original.length;
            var tmp_Bindings = AnimationUtility.GetCurveBindings(_original);

            foreach (var tmp_Binding in tmp_Bindings)
            {
                AnimationCurve tmp_Curve = AnimationUtility.GetEditorCurve(_original, tmp_Binding);
                Keyframe[] tmp_Keys = tmp_Curve.keys;

                for (int tmp_Idx = 0; tmp_Idx < tmp_Keys.Length; tmp_Idx++)
                {
                    tmp_Keys[tmp_Idx].time = tmp_ClipLength - tmp_Keys[tmp_Idx].time;
                }

                System.Array.Sort(tmp_Keys, (_a, _b) => _a.time.CompareTo(_b.time));
                AnimationCurve tmp_ReversedCurve = new AnimationCurve(tmp_Keys);
                tmp_NewClip.SetCurve(tmp_Binding.path, tmp_Binding.type, tmp_Binding.propertyName, tmp_ReversedCurve);
            }

            tmp_NewClip.name = $"{_name}_Reversed.anim";

            AssetDatabase.AddObjectToAsset(tmp_NewClip, tmp_Path);
            AssetDatabase.Refresh();

            return tmp_NewClip;
        }


        [MenuItem("Assets/Tools/Sub-Asset/Delete", true)]
        private static bool ValidateDeleteSubAsset()
        {
            var obj = Selection.activeObject;
            if (obj == null)
                return false;

            string path = AssetDatabase.GetAssetPath(obj);
            if (string.IsNullOrEmpty(path))
                return false;

            // 确保它是嵌套资源而不是主资源
            return AssetDatabase.IsSubAsset(obj);
        }

        [MenuItem("Assets/Tools/Sub-Asset/Delete")]
        private static void DeleteSubAsset()
        {
            var obj = Selection.activeObject;

            if (obj == null)
            {
                Debug.LogWarning("No object selected.");
                return;
            }

            string path = AssetDatabase.GetAssetPath(obj);
            if (string.IsNullOrEmpty(path))
            {
                Debug.LogWarning("Object has no asset path.");
                return;
            }

            // 删除对象
            Object.DestroyImmediate(obj, true);
            AssetDatabase.ImportAsset(path);
            AssetDatabase.SaveAssets();

            Debug.Log($"Deleted sub-asset from: {path}");
        }
    }
}

#endif
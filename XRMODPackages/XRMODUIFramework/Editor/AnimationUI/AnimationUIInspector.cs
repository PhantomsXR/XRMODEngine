// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UIFramework.Editor.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.UIFramework.Runtime;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace Phantom.XRMOD.UIFramework.Editor
{
    [CustomEditor(typeof(AnimationUI))]
    public class AnimationUIInspector : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            AnimationUI tmp_AnimationUI = (AnimationUI) target;
            if (tmp_AnimationUI.AnimationSequence == null) //Prevent error when adding component
            {
                DrawDefaultInspector();
                return;
            }

            #region buttons

            if (!tmp_AnimationUI.IsPlayingInEditMode)
            {
                if (GUILayout.Button("Preview Animation"))
                {
                    tmp_AnimationUI.PreviewAnimation();
                }
            }
            else
            {
                Color tmp_DefaultGUIColor = GUI.backgroundColor;
                GUI.backgroundColor = Color.red;
                if (GUILayout.Button("Stop Animation"))
                {
                    tmp_AnimationUI.IsPlayingInEditMode = false;
                }

                GUI.backgroundColor = tmp_DefaultGUIColor;
            }

            GUILayout.BeginHorizontal();
            if (GUILayout.Button("Preview Start"))
            {
                tmp_AnimationUI.PreviewStart();
            }
            else if (GUILayout.Button("Preview End"))
            {
                tmp_AnimationUI.PreviewEnd();
            }

            GUILayout.EndHorizontal();

            #endregion buttons

            #region timing

            tmp_AnimationUI.InitTime();
            // animationUI.CurrentTime
            float tmp_SliderValue = GUILayout.HorizontalSlider(tmp_AnimationUI.CurrentTime,
                0, tmp_AnimationUI.TotalDuration, GUILayout.ExpandWidth(true), GUILayout.Height(20));
            if (!Mathf.Approximately(tmp_SliderValue, tmp_AnimationUI.CurrentTime)) //Happens when dragging progess bar
            {
                tmp_AnimationUI.CurrentTime = tmp_SliderValue;
                if (!tmp_AnimationUI.IsPlayingInEditMode) tmp_AnimationUI.UpdateBySlider();
            }

            Color tmp_DefaultColor = GUI.backgroundColor;
            GUI.backgroundColor = new Color(0.2f, 1, 0.2f);
            Rect tmp_Position = GUILayoutUtility.GetLastRect();
            EditorGUI.ProgressBar(tmp_Position, tmp_AnimationUI.CurrentTime / tmp_AnimationUI.TotalDuration,
                Mathf.Clamp((Mathf.Round(tmp_AnimationUI.CurrentTime * 100) / 100), 0, 100)
                + "/" + tmp_AnimationUI.TotalDuration + " Seconds, [" +
                (Mathf.Round(tmp_AnimationUI.CurrentTime / tmp_AnimationUI.TotalDuration * 10000) / 100) + "%]"
            );
            GUI.backgroundColor = tmp_DefaultColor;

            tmp_AnimationUI.PlayOnStart = GUILayout.Toggle(tmp_AnimationUI.PlayOnStart, new GUIContent("PlayOnStart"));

            DrawDefaultInspector();
            if (GUILayout.Button("Reverse Sequence"))
            {
                System.Array.Reverse(tmp_AnimationUI.AnimationSequence);
            }

            #endregion timing

            #region List

            float tmp_CurrentTime = 0;

            Rect tmp_Rect = GUILayoutUtility.GetLastRect();

            if (tmp_AnimationUI.AnimationSequence.Length > 0)
                if (tmp_AnimationUI.AnimationSequence[0].PropertyRectY < 115)
                    return; // prevent drawing the white element progress when list is not expanded

            foreach (Sequence tmp_Sequence in tmp_AnimationUI.AnimationSequence)
            {
                Rect tmp_CurrentRect = new Rect(tmp_Rect.x, tmp_Sequence.PropertyRectY - 3, 5,
                    tmp_Sequence.PropertyRectHeight + 2);
                if (tmp_AnimationUI.CurrentTime >= tmp_Sequence.StartTime)
                {
                    float tmp_CurrentSideLoadingRectHeight = (tmp_Sequence.Duration == 0)
                        ? tmp_CurrentRect.height
                        : Mathf.Lerp(0, tmp_CurrentRect.height,
                            (tmp_AnimationUI.CurrentTime - tmp_Sequence.StartTime) / tmp_Sequence.Duration);
                    Rect tmp_SideLoadingRect = new Rect(tmp_CurrentRect.x, tmp_CurrentRect.y, tmp_CurrentRect.width,
                        tmp_CurrentSideLoadingRectHeight);
                    EditorGUI.DrawRect(tmp_SideLoadingRect, new Color(0.2f, 1, 0.2f, 0.4f));
                }


                tmp_Sequence.AtTime = "At " + tmp_CurrentTime + "s";
                tmp_Sequence.StartTime = tmp_CurrentTime;

                if (tmp_Sequence.Duration < 0) tmp_Sequence.Duration = 0; // Clamp
                if (tmp_Sequence.SequenceType == Sequence.Type.Animation)
                {
                    if (tmp_Sequence.TargetComp != null)
                    {
                        tmp_Sequence.AtTime += " [" + tmp_Sequence.TargetComp.name + "]";
                        if (tmp_Sequence.TargetType == Sequence.ObjectType.Automatic)
                        {
                            if (tmp_Sequence.TargetComp.GetComponent<CanvasGroup>() != null)
                            {
                                tmp_Sequence.TargetType = Sequence.ObjectType.CanvasGroup;
                                tmp_Sequence.AtTime += " [CanvasGroup]";
                            }
                            else if (tmp_Sequence.TargetComp.GetComponent<Camera>() != null)
                            {
                                tmp_Sequence.TargetType = Sequence.ObjectType.Camera;
                                tmp_Sequence.AtTime += " [Camera]";
                            }
                            else if (tmp_Sequence.TargetComp.GetComponent<RectTransform>() != null)
                            {
                                tmp_Sequence.TargetType = Sequence.ObjectType.RectTransform;
                                tmp_Sequence.AtTime += " [RectTransform]";
                            }
                            else if (tmp_Sequence.TargetComp.transform != null)
                            {
                                tmp_Sequence.TargetType = Sequence.ObjectType.Transform;
                                tmp_Sequence.AtTime += " [Transform]";
                            }
                        }
                        else if (tmp_Sequence.TargetType == Sequence.ObjectType.RectTransform)
                        {
                            if (tmp_Sequence.TargetComp.GetComponent<RectTransform>() != null)
                                tmp_Sequence.AtTime += " [RectTransform]";
                            else
                            {
                                tmp_Sequence.TargetComp = null;
                                // sequence.AtTime += " [Unassigned] [RectTransform]";
                            }
                        }
                        else if (tmp_Sequence.TargetType == Sequence.ObjectType.Image)
                        {
                            if (tmp_Sequence.TargetComp.GetComponent<Image>() != null)
                                tmp_Sequence.AtTime += " [Image]";
                            else
                            {
                                tmp_Sequence.TargetComp = null;
                                // sequence.AtTime += " [Unassigned] [Image]";
                            }
                        }
                        else if (tmp_Sequence.TargetType == Sequence.ObjectType.Transform)
                        {
                            if (tmp_Sequence.TargetComp.transform != null) tmp_Sequence.AtTime += " [Transform]";
                            else
                            {
                                tmp_Sequence.TargetComp = null;
                            }
                        }
                        else if (tmp_Sequence.TargetType == Sequence.ObjectType.CanvasGroup)
                        {
                            if (tmp_Sequence.TargetComp.GetComponent<CanvasGroup>() != null)
                                tmp_Sequence.AtTime += " [CanvasGroup]";
                            else
                            {
                                tmp_Sequence.TargetComp = null;
                            }
                        }
                        else if (tmp_Sequence.TargetType == Sequence.ObjectType.Camera)
                        {
                            if (tmp_Sequence.TargetComp.GetComponent<Camera>() != null)
                                tmp_Sequence.AtTime += " [Camera]";
                            else
                            {
                                tmp_Sequence.TargetComp = null;
                            }
                        }
                        else if (tmp_Sequence.TargetType == Sequence.ObjectType.TextMeshPro)
                        {
                            if (tmp_Sequence.TargetComp.GetComponent<TMP_Text>() != null)
                                tmp_Sequence.AtTime += " [TextMeshPro]";
                            else
                            {
                                tmp_Sequence.TargetComp = null;
                            }
                        }
                        // else if (tmp_Sequence.TargetType == Sequence.ObjectType.UnityEventDynamic)
                        // {
                        //     tmp_Sequence.AtTime += " [UnityEvent]";
                        // }
                    }
                    else // if TargetComp isn't assigned in inspector
                    {
                        if (tmp_Sequence.TargetType == Sequence.ObjectType.Automatic)
                            tmp_Sequence.AtTime += " [Unassigned] [Animation]";
                        else if (tmp_Sequence.TargetType == Sequence.ObjectType.RectTransform)
                            tmp_Sequence.AtTime += " [Unassigned] [RectTransform]";
                        else if (tmp_Sequence.TargetType == Sequence.ObjectType.Transform)
                            tmp_Sequence.AtTime += " [Unassigned] [Transform]";
                        else if (tmp_Sequence.TargetType == Sequence.ObjectType.Image)
                            tmp_Sequence.AtTime += " [Unassigned] [Image]";
                        else if (tmp_Sequence.TargetType == Sequence.ObjectType.CanvasGroup)
                            tmp_Sequence.AtTime += " [Unassigned] [CanvasGroup]";
                        else if (tmp_Sequence.TargetType == Sequence.ObjectType.Camera)
                            tmp_Sequence.AtTime += " [Unassigned] [Camera]";
                        else if (tmp_Sequence.TargetType == Sequence.ObjectType.TextMeshPro)
                            tmp_Sequence.AtTime += " [Unassigned] [TextMeshPro]";
                        // else if (tmp_Sequence.TargetType == Sequence.ObjectType.UnityEventDynamic)
                        //     tmp_Sequence.AtTime += " [UnityEvent]";
                    }
                }

                else if (tmp_Sequence.SequenceType == Sequence.Type.Wait)
                {
                    tmp_CurrentTime += tmp_Sequence.Duration;
                    tmp_Sequence.AtTime += " [Wait " + tmp_Sequence.Duration + "s]";
                }
                else if (tmp_Sequence.SequenceType == Sequence.Type.SetActiveAllInput)
                {
                    tmp_Sequence.Duration = 0;
                    tmp_Sequence.AtTime += " [SetActiveAllInput to " + tmp_Sequence.IsActivating + "]";
                }
                else if (tmp_Sequence.SequenceType == Sequence.Type.SetActive)
                {
                    tmp_Sequence.Duration = 0;
                    if (tmp_Sequence.Target != null)
                    {
                        tmp_Sequence.AtTime += " [" + tmp_Sequence.Target.name + "] [SetActive to " +
                                               tmp_Sequence.IsActivating +
                                               "]";
                    }
                    else // if Target isn't assigned in inspector
                    {
                        tmp_Sequence.AtTime += " [Unassigned] [SetActive to " + tmp_Sequence.IsActivating + "]";
                    }
                }
                else if (tmp_Sequence.SequenceType == Sequence.Type.SFX)
                {
                    tmp_Sequence.Duration = 0;
                    if ((tmp_Sequence.SFXFile != null) && (tmp_Sequence.PlaySFXBy == Sequence.SFXMethod.File))
                        tmp_Sequence.AtTime += " [" + tmp_Sequence.SFXFile.name + "] [SFX]";
                    else if ((tmp_Sequence.SFXFile == null) && (tmp_Sequence.PlaySFXBy == Sequence.SFXMethod.File))
                        tmp_Sequence.AtTime += " [Unassigned] [SFX]";
                    else
                        tmp_Sequence.AtTime += " [" + tmp_Sequence.SFXIndex.ToString() + "] [SFX]";
                }
                // else if (tmp_Sequence.SequenceType == Sequence.Type.LoadScene)
                // {
                //     tmp_Sequence.Duration = 0;
                //     if (tmp_Sequence.SceneToLoad != null || tmp_Sequence.SceneToLoad != "")
                //         tmp_Sequence.AtTime += " [" + tmp_Sequence.SceneToLoad + "] [LoadScene]";
                //     else
                //         tmp_Sequence.AtTime += " [Unassigned] [LoadScene]";
                // }
                // else if (tmp_Sequence.SequenceType == Sequence.Type.UnityEvent)
                // {
                //     tmp_Sequence.Duration = 0;
                //     tmp_Sequence.AtTime += " [UnityEvent]";
                // }


                #region preview element

                if (tmp_Sequence.TriggerStart)
                {
                    tmp_Sequence.TriggerStart = false;
                    tmp_AnimationUI.CurrentTime = tmp_Sequence.StartTime;
                    if (!tmp_AnimationUI.IsPlayingInEditMode) tmp_AnimationUI.UpdateBySlider();
                }
                else if (tmp_Sequence.TriggerEnd)
                {
                    tmp_Sequence.TriggerEnd = false;
                    tmp_AnimationUI.CurrentTime = tmp_Sequence.StartTime + tmp_Sequence.Duration;
                    if (!tmp_AnimationUI.IsPlayingInEditMode) tmp_AnimationUI.UpdateBySlider();
                }

                #endregion preview element
            }

            #endregion List
        }
    }
}
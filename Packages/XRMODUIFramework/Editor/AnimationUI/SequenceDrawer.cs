// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UIExtension.Editor.
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
    [CustomPropertyDrawer(typeof(Sequence))]
    public class SequenceDrawer : PropertyDrawer
    {
        private readonly float height = EditorGUIUtility.standardVerticalSpacing + EditorGUIUtility.singleLineHeight;
        private readonly float buttonWidth = 38;

        Rect backgroundRectExtra = new Rect(19, -3, 33, 2);

        public override float GetPropertyHeight(SerializedProperty _property, GUIContent _label)
        {
            if (!_property.FindPropertyRelative("IsUnfolded").boolValue)
            {
                _property.FindPropertyRelative("PropertyRectHeight").floatValue = height;
                return height;
            }


            Sequence.Type tmp_SequenceType =
                (Sequence.Type) _property.FindPropertyRelative("SequenceType").enumValueIndex;
            Sequence.ObjectType tmp_TargetType =
                (Sequence.ObjectType) _property.FindPropertyRelative("TargetType").enumValueIndex;
            if (tmp_SequenceType == Sequence.Type.Animation)
            {
                Sequence.ObjectType tmp_ObjectType =
                    (Sequence.ObjectType) _property.FindPropertyRelative("TargetType").enumValueIndex;
                float totalHeight = 0;

                // if (tmp_ObjectType == Sequence.ObjectType.UnityEventDynamic)
                // {
                //     totalHeight = height * 5 +
                //                   EditorGUI.GetPropertyHeight(_property.FindPropertyRelative("EventDynamic")) +
                //                   EditorGUIUtility.standardVerticalSpacing;
                //
                //     _property.FindPropertyRelative("PropertyRectHeight").floatValue = totalHeight;
                //     return totalHeight;
                // }

                if (_property.FindPropertyRelative("TargetComp").GetSerializedValue<Component>() == null)
                    return height * 6;

                if (tmp_ObjectType == Sequence.ObjectType.RectTransform)
                {
                    Sequence.RtTask tmp_RTTask =
                        (Sequence.RtTask) _property.FindPropertyRelative("TargetRtTask").enumValueFlag;
                    if (tmp_RTTask.HasFlag(Sequence.RtTask.AnchoredPosition)) totalHeight += height * 3;
                    if (tmp_RTTask.HasFlag(Sequence.RtTask.LocalScale)) totalHeight += height * 3;
                    if (tmp_RTTask.HasFlag(Sequence.RtTask.LocalEulerAngles)) totalHeight += height * 3;
                    if (tmp_RTTask.HasFlag(Sequence.RtTask.SizeDelta)) totalHeight += height * 3;
                    if (tmp_RTTask.HasFlag(Sequence.RtTask.AnchorMax)) totalHeight += height * 3;
                    if (tmp_RTTask.HasFlag(Sequence.RtTask.AnchorMin)) totalHeight += height * 3;
                    if (tmp_RTTask.HasFlag(Sequence.RtTask.Pivot)) totalHeight += height * 3;
                }
                else if (tmp_ObjectType == Sequence.ObjectType.Transform)
                {
                    Sequence.TransTask tmp_TransTask =
                        (Sequence.TransTask) _property.FindPropertyRelative("TargetTransTask").enumValueFlag;
                    if (tmp_TransTask.HasFlag(Sequence.TransTask.LocalPosition)) totalHeight += height * 3;
                    if (tmp_TransTask.HasFlag(Sequence.TransTask.LocalScale)) totalHeight += height * 3;
                    if (tmp_TransTask.HasFlag(Sequence.TransTask.LocalEulerAngles)) totalHeight += height * 3;
                }
                else if (tmp_ObjectType == Sequence.ObjectType.Image)
                {
                    Sequence.ImgTask tmp_ImgTask =
                        (Sequence.ImgTask) _property.FindPropertyRelative("TargetImgTask").enumValueFlag;
                    if (tmp_ImgTask.HasFlag(Sequence.ImgTask.Color)) totalHeight += height * 3;
                    if (tmp_ImgTask.HasFlag(Sequence.ImgTask.FillAmount)) totalHeight += height * 3;
                }
                else if (tmp_ObjectType == Sequence.ObjectType.CanvasGroup)
                {
                    Sequence.CgTask tmp_CgTask =
                        (Sequence.CgTask) _property.FindPropertyRelative("TargetCgTask").enumValueFlag;
                    if (tmp_CgTask.HasFlag(Sequence.CgTask.Alpha)) totalHeight += height * 3;
                }
                else if (tmp_ObjectType == Sequence.ObjectType.Camera)
                {
                    Sequence.CamTask tmp_CamTask =
                        (Sequence.CamTask) _property.FindPropertyRelative("TargetCamTask").enumValueFlag;
                    if (tmp_CamTask.HasFlag(Sequence.CamTask.BackgroundColor)) totalHeight += height * 3;
                    if (tmp_CamTask.HasFlag(Sequence.CamTask.OrthographicSize)) totalHeight += height * 3;
                }
                else if (tmp_ObjectType == Sequence.ObjectType.TextMeshPro)
                {
                    Sequence.TextMeshProTask tmp_TextMeshProTask =
                        (Sequence.TextMeshProTask) _property.FindPropertyRelative("TargetTextMeshProTask")
                            .enumValueFlag;
                    if (tmp_TextMeshProTask.HasFlag(Sequence.TextMeshProTask.Color)) totalHeight += height * 3;
                    if (tmp_TextMeshProTask.HasFlag(Sequence.TextMeshProTask.MaxVisibleCharacters))
                        totalHeight += height * 3;
                }


                _property.FindPropertyRelative("PropertyRectHeight").floatValue = height * 6 + totalHeight;
                return height * 6 + totalHeight + 1;
            }

            #region others

            else if (tmp_SequenceType == Sequence.Type.Wait)
            {
                _property.FindPropertyRelative("PropertyRectHeight").floatValue = height * 3;
                return height * 3;
            }
            else if (tmp_SequenceType == Sequence.Type.SetActiveAllInput)
            {
                _property.FindPropertyRelative("PropertyRectHeight").floatValue = height * 3;
                return height * 3;
            }
            else if (tmp_SequenceType == Sequence.Type.SetActive)
            {
                _property.FindPropertyRelative("PropertyRectHeight").floatValue = height * 4;
                return height * 4;
            }
            else if (tmp_SequenceType == Sequence.Type.SFX)
            {
                _property.FindPropertyRelative("PropertyRectHeight").floatValue = height * 4;
                return height * 4;
            }
            // else if (tmp_SequenceType == Sequence.Type.LoadScene)
            // {
            //     _property.FindPropertyRelative("PropertyRectHeight").floatValue = height * 3;
            //     return height * 3;
            // }
            // else if (tmp_SequenceType == Sequence.Type.UnityEvent)
            // {
            //     _property.FindPropertyRelative("PropertyRectHeight").floatValue = height +
            //         (EditorGUI.GetPropertyHeight(_property.FindPropertyRelative("Event")) +
            //          EditorGUIUtility.singleLineHeight);
            //     return height + (EditorGUI.GetPropertyHeight(_property.FindPropertyRelative("Event")) +
            //                      EditorGUIUtility.singleLineHeight);
            // }

            _property.FindPropertyRelative("PropertyRectHeight").floatValue = height * 7;
            return height * 7; //Not gonna happen

            #endregion others
        }


        public override void OnGUI(Rect _position, SerializedProperty _property, GUIContent _label)
        {
            _property.FindPropertyRelative("PropertyRectY").floatValue = _position.y;

            Rect tmp_NextPosition = new Rect(_position.x, _position.y, _position.width, height);

            Rect tmp_BackgroundRect = new Rect(backgroundRectExtra.x, _position.y + backgroundRectExtra.y,
                _position.width + backgroundRectExtra.width,
                GetPropertyHeight(_property, _label) + backgroundRectExtra.height);

            Sequence.Type tmp_SequenceType =
                (Sequence.Type) _property.FindPropertyRelative("SequenceType").enumValueIndex;

            #region label

            // if (tmp_SequenceType == Sequence.Type.Animation)
            // {
            //     EditorGUI.DrawRect(tmp_BackgroundRect, new Color(1, 0, 0, 0.1f));
            //     Special labeling case for UnityEvent
            //     if ((Sequence.ObjectType) _property.FindPropertyRelative("TargetType").enumValueIndex ==
            //         Sequence.ObjectType.UnityEventDynamic)
            //     {
            //         float tmp_Time = _property.FindPropertyRelative("StartTime").floatValue;
            //     
            //         _property.FindPropertyRelative("IsUnfolded").boolValue //Fix for when the label is wrong
            //             = EditorGUI.Foldout(tmp_NextPosition, _property.FindPropertyRelative("IsUnfolded").boolValue,
            //                 $"At {tmp_Time}s [UnityEventDynamic]");
            //     }
            // }
            // else if (tmp_SequenceType == Sequence.Type.Wait)
            if (tmp_SequenceType == Sequence.Type.Wait)
                EditorGUI.DrawRect(tmp_BackgroundRect, new Color(0, 0, 1, 0.1f));
            else if (tmp_SequenceType == Sequence.Type.SetActive)
                EditorGUI.DrawRect(tmp_BackgroundRect, new Color(0, 1, 0, 0.1f));
            else if (tmp_SequenceType == Sequence.Type.SetActiveAllInput)
                EditorGUI.DrawRect(tmp_BackgroundRect, new Color(1, 0, 1, 0.1f));
            else if (tmp_SequenceType == Sequence.Type.SFX)
                EditorGUI.DrawRect(tmp_BackgroundRect, new Color(1, 1, 0, 0.1f));
            // else if (tmp_SequenceType == Sequence.Type.LoadScene)
            //     EditorGUI.DrawRect(tmp_BackgroundRect, new Color(0.6f, 0.3f, 0f, 0.1f));
            // else if (tmp_SequenceType == Sequence.Type.UnityEvent)
            // {
            //     float tmp_Time = _property.FindPropertyRelative("StartTime").floatValue;
            //     EditorGUI.DrawRect(tmp_BackgroundRect, new Color(0, 1, 1, 0.1f));
            //     _property.FindPropertyRelative("IsUnfolded").boolValue //Fix for when the label is wrong
            //         = EditorGUI.Foldout(tmp_NextPosition, _property.FindPropertyRelative("IsUnfolded").boolValue,
            //             $"At {tmp_Time}s [UnityEvent]");
            // }
            //
            // if (tmp_SequenceType != Sequence.Type.UnityEvent )
            // {
            //     _property.FindPropertyRelative("IsUnfolded").boolValue
            //         = EditorGUI.Foldout(tmp_NextPosition, _property.FindPropertyRelative("IsUnfolded").boolValue,
            //             _label);
            // }
            
            _property.FindPropertyRelative("IsUnfolded").boolValue
                = EditorGUI.Foldout(tmp_NextPosition, _property.FindPropertyRelative("IsUnfolded").boolValue,
                    _label);

            #endregion label

            #region preview button

            // if (tmp_SequenceType != Sequence.Type.LoadScene)
            //     if (GUI.Button(
            //             new Rect(_position.x + _position.width - buttonWidth * 2, _position.y - 3, buttonWidth,
            //                 height),
            //             "Start"))
            //     {
            //         _property.FindPropertyRelative("TriggerStart").boolValue = true;
            //     }
            //     else if (GUI.Button(
            //                  new Rect(_position.x + _position.width - buttonWidth, _position.y - 3, buttonWidth,
            //                      height), "End"))
            //     {
            //         _property.FindPropertyRelative("TriggerEnd").boolValue = true;
            //     }

            #endregion preview button

            if (!_property.FindPropertyRelative("IsUnfolded").boolValue) return;


            // Type
            tmp_NextPosition.y += height;
            EditorGUI.PropertyField(tmp_NextPosition, _property.FindPropertyRelative("SequenceType"),
                new GUIContent("Type"));
            //
            if (tmp_SequenceType == Sequence.Type.Animation)
            {
                #region setup animation

                tmp_NextPosition.y += height;
                EditorGUI.PropertyField(
                    new Rect(tmp_NextPosition.x, tmp_NextPosition.y, tmp_NextPosition.width * (0.61f),
                        tmp_NextPosition.height),
                    _property.FindPropertyRelative("EaseType"), new GUIContent("Ease")
                );

                EditorGUI.PropertyField(
                    new Rect(tmp_NextPosition.x + tmp_NextPosition.width * (0.61f), tmp_NextPosition.y,
                        tmp_NextPosition.width * (0.39f), tmp_NextPosition.height),
                    _property.FindPropertyRelative("EasePower"), GUIContent.none
                );

                tmp_NextPosition.y += height;
                EditorGUI.PropertyField(
                    new Rect(tmp_NextPosition.x, tmp_NextPosition.y, tmp_NextPosition.width, tmp_NextPosition.height),
                    _property.FindPropertyRelative("Duration")
                );
                // EditorGUI.LabelField(new Rect(nextPosition.x+nextPosition.width-10, nextPosition.y, 10, nextPosition.height),
                //     "s"
                // );

                tmp_NextPosition.y += height;
                EditorGUI.PropertyField(
                    new Rect(tmp_NextPosition.x, tmp_NextPosition.y, tmp_NextPosition.width * (0.61f),
                        tmp_NextPosition.height),
                    _property.FindPropertyRelative("TargetType"), new GUIContent("Target")
                );

                Sequence.ObjectType tmp_ObjectType =
                    (Sequence.ObjectType) _property.FindPropertyRelative("TargetType").enumValueIndex;
                // if (tmp_ObjectType == Sequence.ObjectType.UnityEventDynamic)
                // {
                //     tmp_NextPosition.y += height;
                //     EditorGUI.PropertyField(tmp_NextPosition, _property.FindPropertyRelative("EventDynamic"));
                //     return;
                // }

                EditorGUI.PropertyField(
                    new Rect(tmp_NextPosition.x + tmp_NextPosition.width * (0.61f), tmp_NextPosition.y,
                        tmp_NextPosition.width * (0.39f), tmp_NextPosition.height),
                    _property.FindPropertyRelative("TargetComp"), GUIContent.none
                );

                #endregion setup animation


                //objectType, sequenceType
                tmp_NextPosition.y += height;

                if (_property.FindPropertyRelative("TargetComp").GetSerializedValue<Component>() == null) return;

                if (tmp_ObjectType == Sequence.ObjectType.RectTransform)
                {
                    EditorGUI.PropertyField(tmp_NextPosition, _property.FindPropertyRelative("TargetRtTask"),
                        new GUIContent("Task"));

                    void DrawRtTask(string _name)
                    {
                        tmp_NextPosition.y += height;
                        EditorGUI.LabelField(
                            new Rect(tmp_NextPosition.x, tmp_NextPosition.y, tmp_NextPosition.width, height),
                            new GUIContent(_name)
                        );

                        tmp_NextPosition.y += height;
                        if (GUI.Button(
                                new Rect(tmp_NextPosition.x, tmp_NextPosition.y, tmp_NextPosition.width / 4 - 5,
                                    height),
                                "Set Start"))
                        {
                            if (_name == "AnchoredPosition")
                                _property.FindPropertyRelative(_name + "Start").vector3Value =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<RectTransform>()
                                        .anchoredPosition;
                            else if (_name == "LocalScale")
                                _property.FindPropertyRelative(_name + "Start").vector3Value =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<RectTransform>()
                                        .localScale;
                            else if (_name == "LocalEulerAngles")
                                _property.FindPropertyRelative(_name + "Start").vector3Value =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<RectTransform>()
                                        .localEulerAngles;
                            else if (_name == "SizeDelta")
                                _property.FindPropertyRelative(_name + "Start").vector3Value =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<RectTransform>()
                                        .sizeDelta;
                            else if (_name == "AnchorMin")
                                _property.FindPropertyRelative(_name + "Start").vector3Value =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<RectTransform>()
                                        .anchorMin;
                            else if (_name == "AnchorMax")
                                _property.FindPropertyRelative(_name + "Start").vector3Value =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<RectTransform>()
                                        .anchorMax;
                            else if (_name == "Pivot")
                                _property.FindPropertyRelative(_name + "Start").vector3Value =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<RectTransform>()
                                        .pivot;
                        }

                        EditorGUI.PropertyField(
                            new Rect(tmp_NextPosition.x + tmp_NextPosition.width / 4, tmp_NextPosition.y,
                                tmp_NextPosition.width * 3 / 4, height),
                            _property.FindPropertyRelative(_name + "Start"), GUIContent.none
                        );

                        tmp_NextPosition.y += height;
                        if (GUI.Button(
                                new Rect(tmp_NextPosition.x, tmp_NextPosition.y, tmp_NextPosition.width / 4 - 5,
                                    height),
                                "Set End"))
                        {
                            if (_name == "AnchoredPosition")
                                _property.FindPropertyRelative(_name + "End").vector3Value =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<RectTransform>()
                                        .anchoredPosition;
                            else if (_name == "LocalScale")
                                _property.FindPropertyRelative(_name + "End").vector3Value =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<RectTransform>()
                                        .localScale;
                            else if (_name == "LocalEulerAngles")
                                _property.FindPropertyRelative(_name + "End").vector3Value =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<RectTransform>()
                                        .localEulerAngles;
                            else if (_name == "SizeDelta")
                                _property.FindPropertyRelative(_name + "End").vector3Value =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<RectTransform>()
                                        .sizeDelta;
                            else if (_name == "AnchorMin")
                                _property.FindPropertyRelative(_name + "End").vector3Value =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<RectTransform>()
                                        .anchorMin;
                            else if (_name == "AnchorMax")
                                _property.FindPropertyRelative(_name + "End").vector3Value =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<RectTransform>()
                                        .anchorMax;
                            else if (_name == "Pivot")
                                _property.FindPropertyRelative(_name + "End").vector3Value =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<RectTransform>()
                                        .pivot;
                        }

                        EditorGUI.PropertyField(
                            new Rect(tmp_NextPosition.x + tmp_NextPosition.width / 4, tmp_NextPosition.y,
                                tmp_NextPosition.width * 3 / 4, height),
                            _property.FindPropertyRelative(_name + "End"), GUIContent.none
                        );
                    }

                    Sequence.RtTask tmp_RTTask =
                        (Sequence.RtTask) _property.FindPropertyRelative("TargetRtTask").enumValueFlag;
                    if (tmp_RTTask.HasFlag(Sequence.RtTask.AnchoredPosition)) DrawRtTask("AnchoredPosition");
                    if (tmp_RTTask.HasFlag(Sequence.RtTask.LocalScale)) DrawRtTask("LocalScale");
                    if (tmp_RTTask.HasFlag(Sequence.RtTask.LocalEulerAngles)) DrawRtTask("LocalEulerAngles");
                    if (tmp_RTTask.HasFlag(Sequence.RtTask.SizeDelta)) DrawRtTask("SizeDelta");
                    if (tmp_RTTask.HasFlag(Sequence.RtTask.AnchorMin)) DrawRtTask("AnchorMin");
                    if (tmp_RTTask.HasFlag(Sequence.RtTask.AnchorMax)) DrawRtTask("AnchorMax");
                    if (tmp_RTTask.HasFlag(Sequence.RtTask.Pivot)) DrawRtTask("Pivot");
                }

                else if (tmp_ObjectType == Sequence.ObjectType.Transform)
                {
                    EditorGUI.PropertyField(tmp_NextPosition, _property.FindPropertyRelative("TargetTransTask"),
                        new GUIContent("Task"));

                    void DrawTransTask(string _name)
                    {
                        tmp_NextPosition.y += height;
                        EditorGUI.LabelField(
                            new Rect(tmp_NextPosition.x, tmp_NextPosition.y, tmp_NextPosition.width, height),
                            new GUIContent(_name)
                        );

                        tmp_NextPosition.y += height;
                        if (GUI.Button(
                                new Rect(tmp_NextPosition.x, tmp_NextPosition.y, tmp_NextPosition.width / 4 - 5,
                                    height),
                                "Set Start"))
                        {
                            if (_name == "LocalPosition")
                                _property.FindPropertyRelative(_name + "Start").vector3Value =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<Transform>()
                                        .localPosition;
                            else if (_name == "LocalScale")
                                _property.FindPropertyRelative(_name + "Start").vector3Value =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<Transform>()
                                        .localScale;
                            else if (_name == "LocalEulerAngles")
                                _property.FindPropertyRelative(_name + "Start").vector3Value =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<Transform>()
                                        .localEulerAngles;
                        }

                        EditorGUI.PropertyField(
                            new Rect(tmp_NextPosition.x + tmp_NextPosition.width / 4, tmp_NextPosition.y,
                                tmp_NextPosition.width * 3 / 4, height),
                            _property.FindPropertyRelative(_name + "Start"), GUIContent.none
                        );

                        tmp_NextPosition.y += height;
                        if (GUI.Button(
                                new Rect(tmp_NextPosition.x, tmp_NextPosition.y, tmp_NextPosition.width / 4 - 5,
                                    height),
                                "Set End"))
                        {
                            if (_name == "LocalPosition")
                                _property.FindPropertyRelative(_name + "End").vector3Value =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<Transform>()
                                        .localPosition;
                            else if (_name == "LocalScale")
                                _property.FindPropertyRelative(_name + "End").vector3Value =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<Transform>()
                                        .localScale;
                            else if (_name == "LocalEulerAngles")
                                _property.FindPropertyRelative(_name + "End").vector3Value =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<Transform>()
                                        .localEulerAngles;
                        }

                        EditorGUI.PropertyField(
                            new Rect(tmp_NextPosition.x + tmp_NextPosition.width / 4, tmp_NextPosition.y,
                                tmp_NextPosition.width * 3 / 4, height),
                            _property.FindPropertyRelative(_name + "End"), GUIContent.none
                        );
                    }

                    Sequence.TransTask tmp_TransTask =
                        (Sequence.TransTask) _property.FindPropertyRelative("TargetTransTask").enumValueFlag;
                    if (tmp_TransTask.HasFlag(Sequence.TransTask.LocalPosition)) DrawTransTask("LocalPosition");
                    if (tmp_TransTask.HasFlag(Sequence.TransTask.LocalScale)) DrawTransTask("LocalScale");
                    if (tmp_TransTask.HasFlag(Sequence.TransTask.LocalEulerAngles)) DrawTransTask("LocalEulerAngles");
                }

                else if (tmp_ObjectType == Sequence.ObjectType.Image)
                {
                    EditorGUI.PropertyField(tmp_NextPosition, _property.FindPropertyRelative("TargetImgTask"),
                        new GUIContent("Task"));

                    void DrawImgTask(string _name)
                    {
                        tmp_NextPosition.y += height;
                        EditorGUI.LabelField(
                            new Rect(tmp_NextPosition.x, tmp_NextPosition.y, tmp_NextPosition.width, height),
                            new GUIContent(_name)
                        );

                        tmp_NextPosition.y += height;
                        if (GUI.Button(
                                new Rect(tmp_NextPosition.x, tmp_NextPosition.y, tmp_NextPosition.width / 4 - 5,
                                    height),
                                "Set Start"))
                        {
                            if (_name == "Color")
                                _property.FindPropertyRelative(_name + "Start").colorValue =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<RectTransform>()
                                        .GetComponent<Image>().color;
                            else if (_name == "FillAmount")
                                _property.FindPropertyRelative(_name + "Start").floatValue =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<RectTransform>()
                                        .GetComponent<Image>().fillAmount;
                        }

                        EditorGUI.PropertyField(
                            new Rect(tmp_NextPosition.x + tmp_NextPosition.width / 4, tmp_NextPosition.y,
                                tmp_NextPosition.width * 3 / 4, height),
                            _property.FindPropertyRelative(_name + "Start"), GUIContent.none
                        );

                        tmp_NextPosition.y += height;
                        if (GUI.Button(
                                new Rect(tmp_NextPosition.x, tmp_NextPosition.y, tmp_NextPosition.width / 4 - 5,
                                    height),
                                "Set End"))
                        {
                            if (_name == "Color")
                                _property.FindPropertyRelative(_name + "End").colorValue =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<RectTransform>()
                                        .GetComponent<Image>().color;
                            else if (_name == "FillAmount")
                                _property.FindPropertyRelative(_name + "End").floatValue =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<RectTransform>()
                                        .GetComponent<Image>().fillAmount;
                        }

                        EditorGUI.PropertyField(
                            new Rect(tmp_NextPosition.x + tmp_NextPosition.width / 4, tmp_NextPosition.y,
                                tmp_NextPosition.width * 3 / 4, height),
                            _property.FindPropertyRelative(_name + "End"), GUIContent.none
                        );
                    }

                    Sequence.ImgTask tmp_ImgTask =
                        (Sequence.ImgTask) _property.FindPropertyRelative("TargetImgTask").enumValueFlag;
                    if (tmp_ImgTask.HasFlag(Sequence.ImgTask.Color)) DrawImgTask("Color");
                    if (tmp_ImgTask.HasFlag(Sequence.ImgTask.FillAmount)) DrawImgTask("FillAmount");
                }

                else if (tmp_ObjectType == Sequence.ObjectType.CanvasGroup)
                {
                    EditorGUI.PropertyField(tmp_NextPosition, _property.FindPropertyRelative("TargetCgTask"),
                        new GUIContent("Task"));

                    void DrawCgTask(string _name)
                    {
                        tmp_NextPosition.y += height;
                        EditorGUI.LabelField(
                            new Rect(tmp_NextPosition.x, tmp_NextPosition.y, tmp_NextPosition.width, height),
                            new GUIContent(_name)
                        );

                        tmp_NextPosition.y += height;
                        if (GUI.Button(
                                new Rect(tmp_NextPosition.x, tmp_NextPosition.y, tmp_NextPosition.width / 4 - 5,
                                    height),
                                "Set Start"))
                        {
                            if (_name == "Alpha")
                                _property.FindPropertyRelative(_name + "Start").floatValue =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<RectTransform>()
                                        .GetComponent<CanvasGroup>().alpha;
                        }

                        EditorGUI.PropertyField(
                            new Rect(tmp_NextPosition.x + tmp_NextPosition.width / 4, tmp_NextPosition.y,
                                tmp_NextPosition.width * 3 / 4, height),
                            _property.FindPropertyRelative(_name + "Start"), GUIContent.none
                        );

                        tmp_NextPosition.y += height;
                        if (GUI.Button(
                                new Rect(tmp_NextPosition.x, tmp_NextPosition.y, tmp_NextPosition.width / 4 - 5,
                                    height),
                                "Set End"))
                        {
                            if (_name == "Alpha")
                                _property.FindPropertyRelative(_name + "End").floatValue =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<RectTransform>()
                                        .GetComponent<CanvasGroup>().alpha;
                        }

                        EditorGUI.PropertyField(
                            new Rect(tmp_NextPosition.x + tmp_NextPosition.width / 4, tmp_NextPosition.y,
                                tmp_NextPosition.width * 3 / 4, height),
                            _property.FindPropertyRelative(_name + "End"), GUIContent.none
                        );
                    }

                    Sequence.CgTask tmp_CgTask =
                        (Sequence.CgTask) _property.FindPropertyRelative("TargetCgTask").enumValueFlag;
                    if (tmp_CgTask.HasFlag(Sequence.CgTask.Alpha)) DrawCgTask("Alpha");
                }

                else if (tmp_ObjectType == Sequence.ObjectType.Camera)
                {
                    EditorGUI.PropertyField(tmp_NextPosition, _property.FindPropertyRelative("TargetCamTask"),
                        new GUIContent("Task"));

                    void DrawCamTask(string _name)
                    {
                        tmp_NextPosition.y += height;
                        EditorGUI.LabelField(
                            new Rect(tmp_NextPosition.x, tmp_NextPosition.y, tmp_NextPosition.width, height),
                            new GUIContent(_name)
                        );

                        tmp_NextPosition.y += height;
                        if (GUI.Button(
                                new Rect(tmp_NextPosition.x, tmp_NextPosition.y, tmp_NextPosition.width / 4 - 5,
                                    height),
                                "Set Start"))
                        {
                            if (_name == "BackgroundColor")
                                _property.FindPropertyRelative(_name + "Start").colorValue =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<Transform>()
                                        .GetComponent<Camera>().backgroundColor;
                            else if (_name == "OrthographicSize")
                                _property.FindPropertyRelative(_name + "Start").floatValue =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<Transform>()
                                        .GetComponent<Camera>().orthographicSize;
                        }

                        EditorGUI.PropertyField(
                            new Rect(tmp_NextPosition.x + tmp_NextPosition.width / 4, tmp_NextPosition.y,
                                tmp_NextPosition.width * 3 / 4, height),
                            _property.FindPropertyRelative(_name + "Start"), GUIContent.none
                        );

                        tmp_NextPosition.y += height;
                        if (GUI.Button(
                                new Rect(tmp_NextPosition.x, tmp_NextPosition.y, tmp_NextPosition.width / 4 - 5,
                                    height),
                                "Set End"))
                        {
                            if (_name == "BackgroundColor")
                                _property.FindPropertyRelative(_name + "End").colorValue =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<Transform>()
                                        .GetComponent<Camera>().backgroundColor;
                            else if (_name == "OrthographicSize")
                                _property.FindPropertyRelative(_name + "End").floatValue =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<Transform>()
                                        .GetComponent<Camera>().orthographicSize;
                        }

                        EditorGUI.PropertyField(
                            new Rect(tmp_NextPosition.x + tmp_NextPosition.width / 4, tmp_NextPosition.y,
                                tmp_NextPosition.width * 3 / 4, height),
                            _property.FindPropertyRelative(_name + "End"), GUIContent.none
                        );
                    }

                    Sequence.CamTask tmp_CamTask =
                        (Sequence.CamTask) _property.FindPropertyRelative("TargetCamTask").enumValueFlag;
                    if (tmp_CamTask.HasFlag(Sequence.CamTask.BackgroundColor)) DrawCamTask("BackgroundColor");
                    if (tmp_CamTask.HasFlag(Sequence.CamTask.OrthographicSize)) DrawCamTask("OrthographicSize");
                }
                else if (tmp_ObjectType == Sequence.ObjectType.TextMeshPro)
                {
                    EditorGUI.PropertyField(tmp_NextPosition, _property.FindPropertyRelative("TargetTextMeshProTask"),
                        new GUIContent("Task"));

                    void DrawTextMeshProTask(string _name)
                    {
                        tmp_NextPosition.y += height;
                        EditorGUI.LabelField(
                            new Rect(tmp_NextPosition.x, tmp_NextPosition.y, tmp_NextPosition.width, height),
                            new GUIContent(_name)
                        );

                        tmp_NextPosition.y += height;
                        if (GUI.Button(
                                new Rect(tmp_NextPosition.x, tmp_NextPosition.y, tmp_NextPosition.width / 4 - 5,
                                    height),
                                "Set Start"))
                        {
                            if (_name == "TextMeshProColor")
                                _property.FindPropertyRelative(_name + "Start").colorValue =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<Transform>()
                                        .GetComponent<TMP_Text>().color;
                            else if (_name == "MaxVisibleCharacters")
                            {
                                int tmp_MaxVisibleCharactersStart = _property.FindPropertyRelative("TargetComp")
                                    .GetSerializedValue<Transform>().GetComponent<TMP_Text>().maxVisibleCharacters;
                                int tmp_MaxCharacters = _property.FindPropertyRelative("TargetComp")
                                    .GetSerializedValue<Transform>().GetComponent<TMP_Text>().text.Length;
                                _property.FindPropertyRelative(_name + "Start").intValue =
                                    Mathf.Clamp(tmp_MaxVisibleCharactersStart, 0, tmp_MaxCharacters + 1);
                            }
                        }

                        EditorGUI.PropertyField(
                            new Rect(tmp_NextPosition.x + tmp_NextPosition.width / 4, tmp_NextPosition.y,
                                tmp_NextPosition.width * 3 / 4, height),
                            _property.FindPropertyRelative(_name + "Start"), GUIContent.none
                        );

                        tmp_NextPosition.y += height;
                        if (GUI.Button(
                                new Rect(tmp_NextPosition.x, tmp_NextPosition.y, tmp_NextPosition.width / 4 - 5,
                                    height),
                                "Set End"))
                        {
                            if (_name == "TextMeshProColor")
                                _property.FindPropertyRelative(_name + "End").colorValue =
                                    _property.FindPropertyRelative("TargetComp").GetSerializedValue<Transform>()
                                        .GetComponent<TMP_Text>().color;
                            else if (_name == "MaxVisibleCharacters")
                            {
                                int tmp_MaxVisibleCharactersEnd = _property.FindPropertyRelative("TargetComp")
                                    .GetSerializedValue<Transform>().GetComponent<TMP_Text>().maxVisibleCharacters;
                                int tmp_MaxCharacters = _property.FindPropertyRelative("TargetComp")
                                    .GetSerializedValue<Transform>().GetComponent<TMP_Text>().text.Length;
                                _property.FindPropertyRelative(_name + "End").intValue =
                                    Mathf.Clamp(tmp_MaxVisibleCharactersEnd, 0, tmp_MaxCharacters + 1);
                            }
                        }

                        EditorGUI.PropertyField(
                            new Rect(tmp_NextPosition.x + tmp_NextPosition.width / 4, tmp_NextPosition.y,
                                tmp_NextPosition.width * 3 / 4, height),
                            _property.FindPropertyRelative(_name + "End"), GUIContent.none
                        );
                    }

                    Sequence.TextMeshProTask tmp_TextMeshProTask =
                        (Sequence.TextMeshProTask) _property.FindPropertyRelative("TargetTextMeshProTask")
                            .enumValueFlag;
                    if (tmp_TextMeshProTask.HasFlag(Sequence.TextMeshProTask.Color))
                        DrawTextMeshProTask("TextMeshProColor");
                    if (tmp_TextMeshProTask.HasFlag(Sequence.TextMeshProTask.MaxVisibleCharacters))
                        DrawTextMeshProTask("MaxVisibleCharacters");
                }
            }

            #region others

            else if (tmp_SequenceType == Sequence.Type.Wait)
            {
                tmp_NextPosition.y += height;
                EditorGUI.PropertyField(tmp_NextPosition, _property.FindPropertyRelative("Duration"));
            }
            else if (tmp_SequenceType == Sequence.Type.SetActiveAllInput)
            {
                tmp_NextPosition.y += height;
                EditorGUI.PropertyField(tmp_NextPosition, _property.FindPropertyRelative("IsActivating"));
            }
            else if (tmp_SequenceType == Sequence.Type.SetActive)
            {
                tmp_NextPosition.y += height;
                EditorGUI.PropertyField(tmp_NextPosition, _property.FindPropertyRelative("Target"),
                    new GUIContent("GameObject"));
                tmp_NextPosition.y += height;
                EditorGUI.PropertyField(tmp_NextPosition, _property.FindPropertyRelative("IsActivating"));
            }
            else if (tmp_SequenceType == Sequence.Type.SFX)
            {
                tmp_NextPosition.y += height;
                EditorGUI.PropertyField(tmp_NextPosition, _property.FindPropertyRelative("PlaySFXBy"));

                tmp_NextPosition.y += height;
                EditorGUI.PropertyField(tmp_NextPosition,
                    (Sequence.SFXMethod) _property.FindPropertyRelative("PlaySFXBy").enumValueIndex ==
                    Sequence.SFXMethod.File
                        ? _property.FindPropertyRelative("SFXFile")
                        : _property.FindPropertyRelative("SFXIndex"));
            }
            // else if (tmp_SequenceType == Sequence.Type.LoadScene)
            // {
            //     tmp_NextPosition.y += height;
            //     EditorGUI.PropertyField(tmp_NextPosition, _property.FindPropertyRelative("SceneToLoad"));
            // }
            // else if (tmp_SequenceType == Sequence.Type.UnityEvent)
            // {
            //     tmp_NextPosition.y += height;
            //     EditorGUI.PropertyField(tmp_NextPosition, _property.FindPropertyRelative("Event"));
            // }

            #endregion others
        }
    }
}
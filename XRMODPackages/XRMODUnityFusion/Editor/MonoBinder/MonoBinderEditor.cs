// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the XR-MOD SDK.
// 
// The XR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact nswell@phantomsxr.com for licensing requests.
// ===============================================================================*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.UnityFusion.Runtime.CodeHook;
using UnityEditor;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.U2D;
using UnityEngine.Video;
using Phantom.XRMOD.Core.Runtime; 
using Phantom.XRMOD.UnityFusion.Runtime;
using Phantom.XRMOD.XRMODPackageTools.Editor;
using Phantom.XRMOD.XRMODPackageTools.Runtime;
using UnityEditorInternal;
using Object = UnityEngine.Object;
using Utility = Phantom.XRMOD.XRMODPackageTools.Editor.Utility;

namespace Phantom.XRMOD.Runtime.Editor
{
    [CustomEditor(typeof(MonoBinder)), CanEditMultipleObjects]
    public partial class MonoBinderEditor : UnityEditor.Editor
    {
        [RuntimeInitializeOnLoadMethod]
        private static void RunInEditor()
        {
            EditorNotificationCenter.Center.AddObserver(ModifyTemplateScript, "ModifyTemplateMonoBinder");
        }

        private ReorderableList reorderableList;
        private MonoBinderFieldEditor monoBinderFieldEditor;

        private SerializedProperty scriptListProperty;

        private static readonly List<IEditorTypeHandler> _ALL_TYPE_HANDLERS = new List<IEditorTypeHandler>()
        {
            // Unity type
            new AnimationCurveHandler(),
            new DataPropertyHandler(),
            new Vector2Handler(),
            new Vector3Handler(),
            new Vector4Handler(),
            new QuaternionHandler(),
            new ColorHandler(),
            new ScriptableObjectHandler(),
            new LayerMaskHandler(),
            new NumberHandler(),
            new StringHandler(),
            new BoolHandler(),
            new EnumHandler(),
            new ComponentHandler(),
            new AnimationCurvesHandler(),
            new ColorsHandler(),
            new Vector2sHandler(),
            new Vector3sHandler(),
            new Vector4sHandler(),
            new QuaternionsHandler(),
            new GameObjectHandler(),


            // Unity asset type
            new AnimationClipHandler(),
            new Texture2DHandler(),
            new SpriteHandler(),
            new TextureHandler(),
            new TextAssetHandler(),
            new SpriteAtlasHandler(),
            new VideoClipHandler(),
            new AudioClipHandler(),
            new AudioMixerHandler(),
            new AudioMixerSnapshotHandler(),
            new MaterialHandler(),
            new MeshHandler(),
            new ShaderHandler(),
            new FontHandler(),
            new ComputeShaderHandler(),
            new ComponentsHandler(),
            new Texture2DsHandler(),
            new GameObjectsHandler(),
            new AudioClipsHandler(),
            new ShadersHandler(),
            new SpritesHandler(),
            new MaterialsHandler(),
            new AudioMixersHandler(),
            new MeshesHandler(),
            new VideoClipsHandler(),
            new AnimationClipsHandler(),
            new ScriptableObjectsHandler(),

            new StringsHandler(),
            new IntsHandler(),
            new FloatsHandler(),
            new LongsHandler(),
            new ShortsHandler(),
            new UShortsHandler(),
            new BooleansHandler(),
            new BytesHandler(),
            new ULongsHandler(),


            new UnsupportHandler()
        };

        private void OnEnable()
        {
            SharedData.MONO_BINDER = target as MonoBinder;
            monoBinderFieldEditor = CreateInstance<MonoBinderFieldEditor>();
            scriptListProperty = serializedObject.FindProperty(nameof(MonoBinder.ScriptList));
            reorderableList = new ReorderableList(serializedObject, scriptListProperty, true, true, true, true)
            {
                drawElementCallback = DrawScriptListItems,
                drawHeaderCallback = DrawHeader,
                elementHeightCallback = ElementHeightCallback,
                onChangedCallback = _list =>
                {
                    if (_list.count == 0)
                        scriptListProperty.ClearArray();
                },
                onRemoveCallback = _list =>
                {
                    monoBinderFieldEditor.RemoveElement(_list.index);
                    scriptListProperty.DeleteArrayElementAtIndex(_list.index);
                }
            };
        }

        #region ReorderableList Callbacks

        private float ElementHeightCallback(int _index)
        {
            float tmp_RectHeightOffset = 0;
            float tmp_ArrayRectHeightOffset = 0;
            SerializedProperty tmp_Element = reorderableList.serializedProperty.GetArrayElementAtIndex(_index);
            var tmp_FieldsProperty = tmp_Element.FindPropertyRelative("Fields");
            if (tmp_FieldsProperty.arraySize > 0)
            {
                for (int tmp_Idx = 0; tmp_Idx < tmp_FieldsProperty.arraySize; tmp_Idx++)
                {
                    var tmp_Field = tmp_FieldsProperty.GetArrayElementAtIndex(tmp_Idx);
                    var tmp_FieldType = tmp_Field.FindPropertyRelative("FieldType");
                    var tmp_EnumIdx = (MonoField.FieldTypeEnum) tmp_FieldType.enumValueFlag;
                    switch (tmp_EnumIdx)
                    {
                        case MonoField.FieldTypeEnum.ColorArray:
                        case MonoField.FieldTypeEnum.Components:
                        case MonoField.FieldTypeEnum.Vector2Array:
                        case MonoField.FieldTypeEnum.Vector3Array:
                        case MonoField.FieldTypeEnum.Vector4Array:
                        case MonoField.FieldTypeEnum.QuaternionArray:
                        case MonoField.FieldTypeEnum.AnimationCurveArray:
                        case MonoField.FieldTypeEnum.GameObjectArray:
                            var tmp_ArrayProperty = tmp_Field.FindPropertyRelative($"{tmp_EnumIdx}");
                            if (tmp_ArrayProperty.isExpanded && tmp_Element.isExpanded && tmp_FieldsProperty.isExpanded)
                            {
                                tmp_ArrayRectHeightOffset +=
                                    EditorGUI.GetPropertyHeight(tmp_ArrayProperty) - reorderableList.footerHeight;
                                tmp_ArrayRectHeightOffset += EditorGUIUtility.standardVerticalSpacing * 2;

                                if (tmp_FieldsProperty.arraySize == 1)
                                {
                                    tmp_ArrayRectHeightOffset += 38;
                                    tmp_ArrayRectHeightOffset += reorderableList.headerHeight;
                                }
                            }
                            else if (tmp_Element.isExpanded && tmp_FieldsProperty.isExpanded)
                            {
                                var tmp_RowCount = tmp_FieldsProperty.arraySize * 38;
                                tmp_RectHeightOffset = tmp_RowCount + reorderableList.footerHeight;
                            }

                            break;
                        default:
                            if (tmp_Element.isExpanded && tmp_FieldsProperty.isExpanded)
                            {
                                var tmp_RowCount = tmp_FieldsProperty.arraySize * 38;
                                tmp_RectHeightOffset = tmp_RowCount + reorderableList.footerHeight;
                            }

                            break;
                    }
                }

                tmp_RectHeightOffset += tmp_ArrayRectHeightOffset;
            }
            else if (tmp_Element.isExpanded && tmp_FieldsProperty.isExpanded)
            {
                tmp_RectHeightOffset += EditorGUIUtility.singleLineHeight;
            }

            if (tmp_Element.isExpanded)
            {
                return EditorGUI.GetPropertyHeight(tmp_Element) - 50 + tmp_RectHeightOffset;
            }

            return EditorGUI.GetPropertyHeight(tmp_Element) + tmp_RectHeightOffset;
        }

        private void DrawHeader(Rect _rect)
        {
            EditorGUI.LabelField(_rect, $"MonoScripts(Count:{scriptListProperty.arraySize})");
        }

        private void DrawScriptListItems(Rect _rect, int _index, bool _isactive, bool _isfocused)
        {
            if (reorderableList.serializedProperty.arraySize == 0) return;

            SerializedProperty element = reorderableList.serializedProperty.GetArrayElementAtIndex(_index);
            var tmp_IndentLevel = EditorGUI.indentLevel;
            var tmp_ClassNameSpaceProperty = element.FindPropertyRelative("ClassNamespace");
            var tmp_ClassNameProperty = element.FindPropertyRelative("ClassName");
            var tmp_FieldsProperty = element.FindPropertyRelative("Fields");

            var tmp_ClassNamespaceStr = tmp_ClassNameSpaceProperty.stringValue;
            var tmp_ClassNameStr = tmp_ClassNameProperty.stringValue;


            monoBinderFieldEditor.EnsureReorderableList(_rect, _index, tmp_FieldsProperty);

            if (string.IsNullOrEmpty(tmp_ClassNamespaceStr))
                tmp_ClassNamespaceStr = "Missing Namespace";

            if (string.IsNullOrEmpty(tmp_ClassNameStr))
                tmp_ClassNameStr = "Missing Class Name";

            var tmp_Title = $"{tmp_ClassNamespaceStr}.{tmp_ClassNameStr}";

            float tmp_OffsetOfIcon = 9;
            if (tmp_Title.Contains("Missing"))
            {
                GUIContent tmp_WarningIcon = EditorGUIUtility.IconContent("console.warnicon");
                EditorGUI.LabelField(new Rect(_rect.x, _rect.y, _rect.width,
                    EditorGUIUtility.singleLineHeight), tmp_WarningIcon);
                tmp_OffsetOfIcon = 28;
            }

            _rect.x += tmp_OffsetOfIcon;
            _rect.width -= tmp_OffsetOfIcon;

            element.isExpanded = EditorGUI.Foldout(new Rect(_rect.x, _rect.y, _rect.width,
                EditorGUIUtility.singleLineHeight), element.isExpanded, tmp_Title);


            if (element.isExpanded)
            {
                EditorGUI.PropertyField(
                    new Rect(_rect.x, _rect.y + Utilities.MakeSureHeight, _rect.width,
                        EditorGUIUtility.singleLineHeight),
                    tmp_ClassNameSpaceProperty
                );

                EditorGUI.PropertyField(
                    new Rect(_rect.x, _rect.y + Utilities.MakeSureHeight * 2, _rect.width,
                        EditorGUIUtility.singleLineHeight),
                    tmp_ClassNameProperty
                );

                tmp_FieldsProperty.isExpanded = EditorGUI.Foldout(new Rect(_rect.x,
                    _rect.y + Utilities.MakeSureHeight * 3,
                    _rect.width,
                    EditorGUIUtility.singleLineHeight), tmp_FieldsProperty.isExpanded, "Fields");
                if (tmp_FieldsProperty.isExpanded)
                {
                    _rect.y += Utilities.MakeSureHeight * 4;
                    monoBinderFieldEditor.DrawLayout(_rect, _index);
                }
            }

            EditorGUI.indentLevel = tmp_IndentLevel;
        }

        #endregion

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            reorderableList.DoLayoutList();
            serializedObject.ApplyModifiedProperties();
        }

        /// <summary>
        /// Scans the target MonoBehaviour, reflects its serializable fields, 
        /// and converts them into MonoField data within the MonoBinder.
        /// </summary>
        private static async Task GrabFieldsType(MonoBinder _monoBinder)
        {
            try
            {
                if (SharedData.TARGET_MONO == null || !SharedData.TARGET_MONO.enabled || _monoBinder == null ||
                    !_monoBinder.enabled) return;
                foreach (MonoData tmp_MonoData in _monoBinder.ScriptList)
                {
                    var tmp_FullNamespace = $"{tmp_MonoData.ClassNamespace}.{tmp_MonoData.ClassName}";
                    if (SharedData.TARGET_MONO == null ||
                        tmp_FullNamespace != SharedData.TARGET_MONO.GetType().FullName) continue;
                    tmp_MonoData.Fields.Clear();

                    Type tmp_Type = SharedData.TARGET_MONO.GetType();
                    var tmp_AllFields = tmp_MonoData.Fields.Select(_monoField => _monoField.FieldName).ToList();

                    var tmp_Members = new List<MemberInfo>();
                    var tmp_FieldInfos =
                        tmp_Type.GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                    foreach (FieldInfo tmp_FieldInfo in tmp_FieldInfos)
                    {
                        if (tmp_FieldInfo.IsPublic)
                        {
                            tmp_Members.Add(tmp_FieldInfo);
                            continue;
                        }

                        var tmp_HasSerializeAttribute = tmp_FieldInfo.IsDefined(typeof(SerializeField), true);

                        var tmp_DontConvertAttribute =
                            tmp_FieldInfo.IsDefined(typeof(DontConvertToMonoBinderAttribute), true);

                        if (tmp_HasSerializeAttribute && !tmp_DontConvertAttribute)
                        {
                            tmp_Members.Add(tmp_FieldInfo);
                        }
                    }


                    foreach (MemberInfo tmp_Info in tmp_Members)
                    {
                        EditorUtility.DisplayProgressBar("Converting",
                            $"Converting {tmp_Type.Name}.{tmp_Info.Name}({tmp_Members.ToList().IndexOf(tmp_Info)}/{tmp_Members.Count})",
                            tmp_Members.ToList().IndexOf(tmp_Info) / (float) tmp_Members.Count);

                        if (!tmp_AllFields.Contains(tmp_Info.Name))
                        {
                            MonoField tmp_MonoField = new MonoField
                            {
                                FieldName = tmp_Info.Name
                            };

                            Type tmp_PropertyType = (tmp_Info is PropertyInfo tmp_PropertyInfo)
                                ? tmp_PropertyInfo.PropertyType
                                : ((FieldInfo) tmp_Info).FieldType;

                            // Skip
                            if (EditorTypeHandlerUtility.SkipConvert((FieldInfo) tmp_Info))
                            {
                                continue;
                            } 
                            IEditorTypeHandler tmp_Handler = _ALL_TYPE_HANDLERS.FirstOrDefault(_typeHandler =>
                                _typeHandler.CanHandle(tmp_PropertyType));
                            if (tmp_Handler != null)
                            {
                                tmp_MonoField.FieldType = tmp_Handler.GetFieldType(tmp_PropertyType);
                                tmp_Handler.ProcessValue(tmp_MonoField,
                                    ((FieldInfo) tmp_Info).GetValue(SharedData.TARGET_MONO));
                            }

                            //SetMonoFieldType(tmp_MonoField, tmp_PropertyType);
                            //CopyDataToMonoField(ref tmp_MonoField, tmp_Info, SharedData.TARGET_MONO);
                            tmp_MonoData.Fields.Add(tmp_MonoField);
                        }

                        await Task.Delay(1);
                    }

                    // Since the resource needs to be load, it is processed last.
                    var tmp_NonSortData = tmp_MonoData.Fields.Where(_item =>
                        !(_item.FieldType is MonoField.FieldTypeEnum.AssetReference ||
                          _item.FieldType is MonoField.FieldTypeEnum.AssetReferenceArray)).ToList();

                    var tmp_NeedSortData = tmp_MonoData.Fields.Where(_item =>
                        _item.FieldType is MonoField.FieldTypeEnum.AssetReference
                            or MonoField.FieldTypeEnum.AssetReferenceArray).ToList();

                    var tmp_SortedData = tmp_NonSortData.Concat(tmp_NeedSortData).ToList();
                    tmp_MonoData.Fields = tmp_SortedData;

                    await Task.Delay(5);
                    EditorUtility.ClearProgressBar();
                }
            }
            catch (Exception tmp_E)
            {
                Debug.LogError(tmp_E);
                EditorUtility.ClearProgressBar();
            }
            finally
            {
                EditorUtility.ClearProgressBar();
            }
        }

        private static void ModifyTemplateScript(BaseNotificationData _data)
        {
            //Get all monoBinder scripts from prefab,
            //then change the script's field of namespace to specify project name
            var tmp_Data = _data.BaseData.Split('|'); //Path|ProjectName
            var tmp_PrefabPath = tmp_Data[0];
            if (Directory.Exists(tmp_PrefabPath))
            {
                var tmp_Files =
                    Directory.GetFiles(Path.Combine(Application.dataPath.Replace("Assets", ""), tmp_PrefabPath),
                        "*.prefab", SearchOption.TopDirectoryOnly);
                foreach (string tmp_File in tmp_Files)
                {
                    var tmp_Prefab = AssetDatabase.LoadAssetAtPath<GameObject>(ShortenPath(tmp_File));

                    List<MonoBinder> tmp_MonoBinders = new List<MonoBinder>();
                    tmp_MonoBinders.AddRange(tmp_Prefab.GetComponents<MonoBinder>());
                    tmp_MonoBinders.AddRange(tmp_Prefab.GetComponentsInChildren<MonoBinder>());

                    foreach (MonoBinder tmp_MonoBinder in tmp_MonoBinders)
                    {
                        foreach (MonoData tmp_MonoData in tmp_MonoBinder.ScriptList)
                        {
                            tmp_MonoData.ClassNamespace = tmp_Data[1];
                        }
                    }
                }
            }
        }

        private static string ShortenPath(string _fullPath)
        {
            int tmp_SubStringStartPos = _fullPath.IndexOf("Assets", StringComparison.Ordinal);
            return _fullPath.Substring(tmp_SubStringStartPos, _fullPath.Length - tmp_SubStringStartPos);
        }
    }
}
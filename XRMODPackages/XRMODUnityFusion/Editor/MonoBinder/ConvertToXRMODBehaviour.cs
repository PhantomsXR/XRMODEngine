// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Runtime.CodeHook.Editor.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.UnityFusion.Runtime.CodeHook;
using Phantom.XRMOD.XRMODPackageTools.Editor;
using TMPro;
using Unity.AI.Navigation;
using UnityEditor;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;
using UnityEngine.Assertions;
using UnityEngine.Audio;
using UnityEngine.Rendering;
using UnityEngine.U2D;
using UnityEngine.UI;
using UnityEngine.Video;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.Runtime.Editor
{
    public partial class MonoBinderEditor
    {
        [MenuItem("CONTEXT/MonoBinder/Convert To XRMODBehaviour")]
        private static void ConvertToXRMODBehaviour(MenuCommand _command)
        {
            if (_command.context is not MonoBinder tmp_Behaviour) return;
            var tmp_Target = tmp_Behaviour.gameObject;
            foreach (MonoData tmp_MonoData in tmp_Behaviour.ScriptList)
            {
                var tmp_ComponentName =
                    $"{tmp_MonoData.ClassNamespace}.{tmp_MonoData.ClassName}, {Utilities.GetFirstTwoNameParts(tmp_MonoData.ClassNamespace)}";
                var tmp_ComponentType = Type.GetType(tmp_ComponentName);

                if (tmp_ComponentType == null)
                {
                    Debug.LogError(
                        $"Add Component:{tmp_ComponentName} is failed. Because {tmp_ComponentName} is not a valid type.");
                    continue;
                }

                if (!tmp_Target.TryGetComponent(tmp_ComponentType, out var tmp_AddedComponent))
                {
                    tmp_AddedComponent = tmp_Target.AddComponent(tmp_ComponentType);
                }

                (tmp_AddedComponent as XRMODBehaviour).enabled = false;
                foreach (MonoField tmp_MonoField in tmp_MonoData.Fields)
                {
                    var tmp_FieldInfo = tmp_ComponentType.GetField(tmp_MonoField.FieldName,
                        BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

                    if (tmp_FieldInfo == null || (!tmp_FieldInfo.IsDefined(typeof(SerializeField), true)
                                                  && (tmp_FieldInfo.IsPrivate || tmp_FieldInfo.IsFamily ||
                                                      tmp_FieldInfo.IsAssembly ||
                                                      tmp_FieldInfo.IsFamilyAndAssembly ||
                                                      tmp_FieldInfo.IsFamilyOrAssembly))) continue;

                    switch (tmp_MonoField.FieldType)
                    {
                        case MonoField.FieldTypeEnum.Number:
                            if (tmp_FieldInfo.FieldType == typeof(float))
                                tmp_FieldInfo.SetValue(tmp_AddedComponent, float.Parse(tmp_MonoField.Value));
                            else
                                tmp_FieldInfo.SetValue(tmp_AddedComponent, int.Parse(tmp_MonoField.Value));

                            break;
                        case MonoField.FieldTypeEnum.String:
                            tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_MonoField.Value);
                            break;
                        case MonoField.FieldTypeEnum.Bool:
                            tmp_FieldInfo.SetValue(tmp_AddedComponent, bool.Parse(tmp_MonoField.Value));
                            break;
                        case MonoField.FieldTypeEnum.GameObject:
                            tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_MonoField.GameObject);
                            break;
                        case MonoField.FieldTypeEnum.UnityComponent:
                            var tmp_Value = Utilities.GetComponent(tmp_MonoField.GameObject, tmp_MonoField.FieldName,
                                tmp_FieldInfo);
                            tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_Value);
                            break;
                        case MonoField.FieldTypeEnum.Vector2:
                            var tmp_Vector2 = JsonUtility.FromJson<SerializableVector2>(tmp_MonoField.Value)
                                .ToVector2();
                            tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_Vector2);

                            break;
                        case MonoField.FieldTypeEnum.Vector3:
                            var tmp_Vector3 = JsonUtility.FromJson<SerializableVector3>(tmp_MonoField.Value)
                                .ToVector3();
                            tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_Vector3);
                            break;
                        case MonoField.FieldTypeEnum.Vector4:
                            var tmp_Vector4 = JsonUtility.FromJson<SerializableVector4>(tmp_MonoField.Value)
                                .ToVector4();
                            tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_Vector4);
                            break;
                        case MonoField.FieldTypeEnum.Quaternion:
                            var tmp_V4 = JsonUtility.FromJson<SerializableVector4>(tmp_MonoField.Value)
                                .ToVector4();
                            var tmp_Quat = new Quaternion(tmp_V4.x, tmp_V4.y, tmp_V4.z, tmp_V4.w);
                            tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_Quat);
                            break;
                        case MonoField.FieldTypeEnum.Color:
                            if (string.IsNullOrEmpty(tmp_MonoField.Value)) continue;
                            if (ColorUtility.TryParseHtmlString(tmp_MonoField.Value, out var tmp_Color))
                                tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_Color);
                            else
                            {
                                Debug.LogError("Unavailable color value, correct format: #RRGGBBAA");
                            }

                            break;
                        case MonoField.FieldTypeEnum.LayerMask:
                            if (string.IsNullOrEmpty(tmp_MonoField.Value)) continue;
                            LayerMask tmp_Mask = new LayerMask
                            {
                                value = LayerMask.GetMask(tmp_MonoField.Value.Split(","))
                            };
                            MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent, tmp_Mask);
                            break;
                        case MonoField.FieldTypeEnum.AnimationCurve:
                            if (string.IsNullOrEmpty(tmp_MonoField.Value)) continue;
                            tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_MonoField.Value.DeserializeAnimationCurve());
                            break;
                        case MonoField.FieldTypeEnum.AssetReference:
                        {
                            var tmp_ProjectName = tmp_MonoData.ClassNamespace.Split(".")[0];
                            var tmp_AllProjectCache = AssetDatabase.LoadAssetAtPath<AllProjectsCache>(
                                "Assets/Editor Default Resources/PackageToolsCache/Data/AllProjectsCache.asset");
                            var tmp_Project = tmp_AllProjectCache.ProjectCacheDataList.Find(_project =>
                                _project.Project.DisplayName == tmp_ProjectName);
                            Assert.IsNotNull(tmp_Project, $"{tmp_ProjectName}->Project not found");

                            var tmp_ContentModel = tmp_Project.DetailCacheData.Groups.Select(_group =>
                                    _group.Assets.Find(_content => _content.DisplayName == tmp_MonoField.Value))
                                .FirstOrDefault();


                            if (tmp_ContentModel.Type == typeof(Texture2D).FullName)
                            {
                                var tmp_LoadAsset =
                                    AssetDatabase.LoadAssetAtPath<Texture2D>(tmp_ContentModel.AssetPathInUnity);
                                tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_LoadAsset);
                            }
                            else if (tmp_ContentModel.Type == typeof(Sprite).FullName)
                            {
                                var tmp_LoadAsset =
                                    AssetDatabase.LoadAssetAtPath<Sprite>(tmp_ContentModel.AssetPathInUnity);
                                tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_LoadAsset);
                            }
                            else if (tmp_ContentModel.Type == typeof(AudioClip).FullName)
                            {
                                var tmp_LoadAsset =
                                    AssetDatabase.LoadAssetAtPath<AudioClip>(tmp_ContentModel.AssetPathInUnity);
                                tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_LoadAsset);
                            }
                            else if (tmp_ContentModel.Type == typeof(VideoClip).FullName)
                            {
                                var tmp_LoadAsset =
                                    AssetDatabase.LoadAssetAtPath<VideoClip>(tmp_ContentModel.AssetPathInUnity);
                                tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_LoadAsset);
                            }
                            else if (tmp_ContentModel.Type == typeof(TextAsset).FullName)
                            {
                                var tmp_LoadAsset =
                                    AssetDatabase.LoadAssetAtPath<TextAsset>(tmp_ContentModel.AssetPathInUnity);
                                tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_LoadAsset);
                            }
                            else if (tmp_ContentModel.Type == typeof(GameObject).FullName)
                            {
                                var tmp_LoadAsset =
                                    AssetDatabase.LoadAssetAtPath<GameObject>(tmp_ContentModel.AssetPathInUnity);
                                tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_LoadAsset);
                            }
                            else if (tmp_ContentModel.Type == typeof(Mesh).FullName)
                            {
                                var tmp_LoadAsset =
                                    AssetDatabase.LoadAssetAtPath<Mesh>(tmp_ContentModel.AssetPathInUnity);
                                tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_LoadAsset);
                            }
                            else if (tmp_ContentModel.Type == typeof(PhysicsMaterial2D).FullName)
                            {
                                var tmp_LoadAsset =
                                    AssetDatabase.LoadAssetAtPath<PhysicsMaterial2D>(tmp_ContentModel.AssetPathInUnity);
                                tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_LoadAsset);
                            }
#if UNITY_6000_0_OR_NEWER
                            else if (tmp_ContentModel.Type == typeof(PhysicsMaterial).FullName)
                            {
                                var tmp_LoadAsset =
                                    AssetDatabase.LoadAssetAtPath<PhysicsMaterial>(tmp_ContentModel.AssetPathInUnity);
                                tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_LoadAsset);
                            }
#else
                            else if (tmp_ContentModel.Type == typeof(PhysicMaterial).FullName)
                            {
                                var tmp_LoadAsset =
                                    AssetDatabase.LoadAssetAtPath<PhysicMaterial>(tmp_ContentModel.AssetPathInUnity);
                                tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_LoadAsset);
                            }
#endif


                            else if (tmp_ContentModel.Type == typeof(ComputeShader).FullName)
                            {
                                var tmp_LoadAsset =
                                    AssetDatabase.LoadAssetAtPath<ComputeShader>(tmp_ContentModel.AssetPathInUnity);
                                tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_LoadAsset);
                            }
                            else if (tmp_ContentModel.Type == typeof(AudioMixer).FullName)
                            {
                                var tmp_LoadAsset =
                                    AssetDatabase.LoadAssetAtPath<AudioMixer>(tmp_ContentModel.AssetPathInUnity);
                                tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_LoadAsset);
                            }
                            else if (tmp_ContentModel.Type == typeof(Animator).FullName)
                            {
                                var tmp_LoadAsset =
                                    AssetDatabase.LoadAssetAtPath<Animator>(tmp_ContentModel.AssetPathInUnity);
                                tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_LoadAsset);
                            }
                            else if (tmp_ContentModel.Type == typeof(RenderTexture).FullName)
                            {
                                var tmp_LoadAsset =
                                    AssetDatabase.LoadAssetAtPath<RenderTexture>(tmp_ContentModel.AssetPathInUnity);
                                tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_LoadAsset);
                            }
                            else if (tmp_ContentModel.Type == typeof(Shader).FullName)
                            {
                                var tmp_LoadAsset =
                                    AssetDatabase.LoadAssetAtPath<Shader>(tmp_ContentModel.AssetPathInUnity);
                                tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_LoadAsset);
                            }
                            else if (tmp_ContentModel.Type == typeof(Material).FullName)
                            {
                                var tmp_LoadAsset =
                                    AssetDatabase.LoadAssetAtPath<Material>(tmp_ContentModel.AssetPathInUnity);
                                tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_LoadAsset);
                            }
                            else if (tmp_ContentModel.Type == typeof(Cubemap).FullName)
                            {
                                var tmp_LoadAsset =
                                    AssetDatabase.LoadAssetAtPath<Cubemap>(tmp_ContentModel.AssetPathInUnity);
                                tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_LoadAsset);
                            }
                            else if (tmp_ContentModel.Type == typeof(SpriteAtlas).FullName)
                            {
                                var tmp_LoadAsset =
                                    AssetDatabase.LoadAssetAtPath<SpriteAtlas>(tmp_ContentModel.AssetPathInUnity);
                                tmp_FieldInfo.SetValue(tmp_AddedComponent, tmp_LoadAsset);
                            }
                        }


                            break;
                        case MonoField.FieldTypeEnum.Enum:
                            if (string.IsNullOrEmpty(tmp_MonoField.Value)) continue;
                            var tmp_EnumIdx = int.Parse(tmp_MonoField.Value);
                            var tmp_EnumType = tmp_FieldInfo.GetValue(tmp_AddedComponent).GetType();
                            var tmp_EnumNames = Enum.GetNames(tmp_EnumType);
                            tmp_FieldInfo.SetValue(tmp_AddedComponent,
                                Enum.Parse(tmp_EnumType, tmp_EnumNames[tmp_EnumIdx]));
                            break;
                        case MonoField.FieldTypeEnum.NotSupported:
                            break;
                        case MonoField.FieldTypeEnum.Primitives:
                            if (string.IsNullOrEmpty(tmp_MonoField.Value)) continue;
                            object tmp_Obj = null;
                            // ReSharper disable once ConvertTypeCheckToNullCheck
                            if (tmp_MonoField.Value.Contains(typeof(string).ToString()))
                                tmp_Obj = JsonUtility.FromJson<GenericPrimitiveObject<string>>(tmp_MonoField.Value)
                                    .List.ToArray();
#pragma warning disable CS0184
                            else if (tmp_MonoField.Value.Contains(typeof(int).ToString()))
#pragma warning restore CS0184
                                tmp_Obj = JsonUtility.FromJson<GenericPrimitiveObject<int>>(tmp_MonoField.Value).List
                                    .ToArray();
#pragma warning disable CS0184
                            else if (tmp_MonoField.Value.Contains(typeof(bool).ToString()))
#pragma warning disable CS0184
                                tmp_Obj = JsonUtility.FromJson<GenericPrimitiveObject<bool>>(tmp_MonoField.Value).List
                                    .ToArray();
#pragma warning disable CS0184
                            else if (tmp_MonoField.Value.Contains(typeof(float).ToString()))
#pragma warning disable CS0184
                                tmp_Obj = JsonUtility.FromJson<GenericPrimitiveObject<float>>(tmp_MonoField.Value).List
                                    .ToArray();
                            MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent, tmp_Obj);
                            break;
                        case MonoField.FieldTypeEnum.ColorArray:
                            MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                tmp_MonoField.ColorArray);
                            break;
                        case MonoField.FieldTypeEnum.Vector2Array:
                            MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                tmp_MonoField.Vector2Array);

                            break;
                        case MonoField.FieldTypeEnum.Vector3Array:
                            MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                tmp_MonoField.Vector3Array);

                            break;
                        case MonoField.FieldTypeEnum.Vector4Array:
                            MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                tmp_MonoField.Vector4Array);

                            break;
                        case MonoField.FieldTypeEnum.QuaternionArray:
                            MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                tmp_MonoField.QuaternionArray);

                            break;

                        case MonoField.FieldTypeEnum.AnimationCurveArray:
                            MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                tmp_MonoField.AnimationCurveArray);

                            break;
                        case MonoField.FieldTypeEnum.Components:
                            List<Component> tmp_ObjectsComponents = new();

                            var tmp_IsListType = typeof(IList).IsAssignableFrom(tmp_FieldInfo.FieldType) &&
                                                 tmp_FieldInfo.FieldType.IsGenericType;
                            var tmp_CastType =
                                tmp_FieldInfo.FieldType.IsArray || tmp_FieldInfo.FieldType.IsGenericType
                                    ? tmp_FieldInfo.FieldType.IsGenericType
                                        ? tmp_FieldInfo.FieldType.GenericTypeArguments[0]
                                        : tmp_FieldInfo.FieldType.GetElementType()
                                    : tmp_FieldInfo.FieldType;
                            object tmp_Result = null;
                            foreach (var tmp_GameObject in tmp_MonoField.Components)
                            {
                                var tmp_Components = tmp_GameObject.GetComponents(tmp_CastType);
                                tmp_ObjectsComponents.AddRange(tmp_Components);
                            }

                            if (tmp_ObjectsComponents is {Count: > 0})
                            {
                                if (tmp_CastType == typeof(MeshFilter))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<MeshFilter>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(MeshRenderer))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<MeshRenderer>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(SkinnedMeshRenderer))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<SkinnedMeshRenderer>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(TextMeshPro))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<TextMeshPro>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(Transform))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<Transform>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(LineRenderer))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<LineRenderer>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(TrailRenderer))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<TrailRenderer>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(MonoBehaviour))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<MonoBehaviour>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(SpriteRenderer))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<SpriteRenderer>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(SortingGroup))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<SortingGroup>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(ReflectionProbe))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<ReflectionProbe>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(NavMeshAgent))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<NavMeshAgent>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(NavMeshObstacle))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<NavMeshObstacle>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(NavMeshLink))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<NavMeshLink>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(Image))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<Image>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(Text))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<Text>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(Slider))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<Slider>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(Button))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<Button>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(RawImage))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<RawImage>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(CanvasGroup))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<CanvasGroup>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(Canvas))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<Canvas>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(CanvasScaler))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<CanvasScaler>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(GridLayout))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<GridLayout>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(ContentSizeFitter))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<ContentSizeFitter>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(HorizontalLayoutGroup))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<HorizontalLayoutGroup>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(RectTransform))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<RectTransform>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(VerticalLayoutGroup))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<VerticalLayoutGroup>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(LayoutElement))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<LayoutElement>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(Toggle))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<Toggle>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(ToggleGroup))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<ToggleGroup>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(Scrollbar))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<Scrollbar>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(RectMask2D))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<RectMask2D>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(Slider))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<Slider>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(Selectable))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<Selectable>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(Mask))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<Mask>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(ScrollRect))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<ScrollRect>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(TMP_InputField))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<TMP_InputField>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(InputField))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<InputField>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(Dropdown))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<Dropdown>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(TMP_Dropdown))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<TMP_Dropdown>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(AudioSource))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<AudioSource>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(VideoPlayer))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<VideoPlayer>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(Light))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<Light>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(Rigidbody))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<Rigidbody>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(BoxCollider))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<BoxCollider>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(SphereCollider))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<SphereCollider>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(CapsuleCollider))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<CapsuleCollider>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(MeshCollider))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<MeshCollider>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(CharacterController))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<CharacterController>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(Joint))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<Joint>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(FixedJoint))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<FixedJoint>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(CharacterJoint))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<CharacterJoint>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(SpringJoint))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<SpringJoint>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(HingeJoint))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<HingeJoint>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(AimConstraint))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<AimConstraint>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(Animation))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<Animation>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(Animator))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<Animator>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(BillboardRenderer))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<BillboardRenderer>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(Grid))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<Grid>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(LookAtConstraint))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<LookAtConstraint>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(ParentConstraint))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<ParentConstraint>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(PositionConstraint))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<PositionConstraint>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(RotationConstraint))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<RotationConstraint>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(ScaleConstraint))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<ScaleConstraint>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(SpriteMask))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<SpriteMask>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(WindZone))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<WindZone>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(LightProbeProxyVolume))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<LightProbeProxyVolume>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                                else if (tmp_CastType == typeof(LightProbeGroup))
                                {
                                    var tmp_Casted = tmp_ObjectsComponents.Cast<LightProbeGroup>();
                                    tmp_Result = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
                                }
                            }

                            MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                tmp_Result);
                            break;
                        case MonoField.FieldTypeEnum.GameObjectArray:
                            MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                tmp_MonoField.GameObjectArray);

                            break;
                        case MonoField.FieldTypeEnum.AssetReferenceArray:
                        {
                            try
                            {
                                var tmp_ProjectName = tmp_MonoData.ClassNamespace.Split(".")[0];
                                var tmp_AllProjectCache = AssetDatabase.LoadAssetAtPath<AllProjectsCache>(
                                    "Assets/Editor Default Resources/PackageToolsCache/Data/AllProjectsCache.asset");
                                var tmp_Project = tmp_AllProjectCache.ProjectCacheDataList.Find(_project =>
                                    _project.Project.DisplayName == tmp_ProjectName);
                                Assert.IsNotNull(tmp_Project, $"{tmp_ProjectName}->Project not found");

                                var tmp_DeserializeData = JsonConvert.DeserializeObject(tmp_MonoField.Value);
                                if (tmp_DeserializeData is JArray tmp_Array)
                                {
                                    List<Object> tmp_Objects = new List<Object>();
                                    foreach (var tmp_AssetName in tmp_Array)
                                    { 
                                        var tmp_ContentModel = tmp_Project.DetailCacheData.Groups.Select(_group =>
                                                _group.Assets.Find(_content => _content.DisplayName == tmp_AssetName.ToString()))
                                            .FirstOrDefault();
                                        
                                        var tmp_Asset =
                                            AssetDatabase.LoadAssetAtPath<Object>(tmp_ContentModel
                                                .AssetPathInUnity);
                                        tmp_Objects.Add(tmp_Asset);
                                    }

                                    if (tmp_Objects[0] is GameObject)
                                    {
                                        MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                            tmp_Objects.OfType<GameObject>().ToArray());
                                    }
                                    else if (tmp_Objects[0] is Sprite)
                                    {
                                        MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                            tmp_Objects.OfType<Sprite>().ToArray());
                                    }
                                    else if (tmp_Objects[0] is AudioClip)
                                    {
                                        MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                            tmp_Objects.OfType<AudioClip>().ToArray());
                                    }
                                    else if (tmp_Objects[0] is VideoClip)
                                    {
                                        MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                            tmp_Objects.OfType<VideoClip>().ToArray());
                                    }
                                    else if (tmp_Objects[0] is VideoClip)
                                    {
                                        MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                            tmp_Objects.OfType<VideoClip>().ToArray());
                                    }
                                    else if (tmp_Objects[0] is TextAsset)
                                    {
                                        MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                            tmp_Objects.OfType<VideoClip>().ToArray());
                                    }
                                    else if (tmp_Objects[0] is Texture2D)
                                    {
                                        MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                            tmp_Objects.OfType<Texture2D>().ToArray());
                                    }
                                    else if (tmp_Objects[0] is Material)
                                    {
                                        MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                            tmp_Objects.OfType<Material>().ToArray());
                                    }
                                    else if (tmp_Objects[0] is Mesh)
                                    {
                                        MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                            tmp_Objects.OfType<Mesh>().ToArray());
                                    }
                                    else if (tmp_Objects[0] is RenderTexture)
                                    {
                                        MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                            tmp_Objects.OfType<RenderTexture>().ToArray());
                                    }
                                    else if (tmp_Objects[0] is AnimationClip)
                                    {
                                        MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                            tmp_Objects.OfType<AnimationClip>().ToArray());
                                    }
                                    else if (tmp_Objects[0] is AudioMixer)
                                    {
                                        MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                            tmp_Objects.OfType<AudioMixer>().ToArray());
                                    }
                                    else if (tmp_Objects[0] is Cubemap)
                                    {
                                        MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                            tmp_Objects.OfType<Cubemap>().ToArray());
                                    }
                                    else if (tmp_Objects[0] is Shader)
                                    {
                                        MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                            tmp_Objects.OfType<Shader>().ToArray());
                                    }
                                    else if (tmp_Objects[0] is SpriteAtlas)
                                    {
                                        MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                            tmp_Objects.OfType<SpriteAtlas>().ToArray());
                                    }
                                    else if (tmp_Objects[0] is Animator)
                                    {
                                        MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                            tmp_Objects.OfType<Animator>().ToArray());
                                    }
                                    else if (tmp_Objects[0] is ComputeShader)
                                    {
                                        MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                            tmp_Objects.OfType<ComputeShader>().ToArray());
                                    }
#if UNITY_6000_0_OR_NEWER
                                    else if (tmp_Objects[0] is PhysicsMaterial)
                                    {
                                        MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                            tmp_Objects.OfType<PhysicsMaterial>().ToArray());
                                    }
#else
                                    else if (tmp_Objects[0] is PhysicMaterial)
                                    {
                                        MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                            tmp_Objects.OfType<PhysicMaterial>().ToArray());
                                    }
#endif

                                    else if (tmp_Objects[0] is PhysicsMaterial2D)
                                    {
                                        MakeSureValueFactory.MakeSureValue(ref tmp_FieldInfo, tmp_AddedComponent,
                                            tmp_Objects.OfType<PhysicsMaterial2D>().ToArray());
                                    }
                                }
                            }
                            catch (Exception _exception)
                            {
                                Debug.LogError(_exception);
                            }
                        }
                            break;
                        case MonoField.FieldTypeEnum.Default:
                            break;
                        case MonoField.FieldTypeEnum.DataProperty:
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }
        }
    }
}
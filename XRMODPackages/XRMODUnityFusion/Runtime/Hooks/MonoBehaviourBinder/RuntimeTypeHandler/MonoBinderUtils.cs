// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Runtime.CodeHook.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using TMPro;
using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Animations;
using UnityEngine.Assertions;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityFusion.Reflection;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    public static class MonoBinderUtils
    {
        private const BindingFlags _CONST_ALL_BINDING_FLAGS = BindingFlags.NonPublic | BindingFlags.Public
            | BindingFlags.Instance |
            BindingFlags.Static;

        public static bool GetComponent(GameObject _go, MonoField _field, Type _reflectionType,
            string _classPath,
            out object _obj)
        {
            _obj = null;
            GameObject tmp_GO = _go;
            if (string.IsNullOrEmpty(_field.Value) && tmp_GO == null) return true;
            if (tmp_GO == null)
                tmp_GO = GetGameObjectFields(_reflectionType, _field);

            if (tmp_GO == null)
                return true;

            var tmp_FieldInfo = _reflectionType?.GetField(_field.FieldName, _CONST_ALL_BINDING_FLAGS);
            if (tmp_FieldInfo != null)
            {
                string tmp_FieldTypeName = tmp_FieldInfo.FieldType.Name;
                if (tmp_FieldInfo.FieldType is UnityFusionType)
                {
                    var tmp_Components = tmp_GO.GetComponents<CrossBindingAdaptorType>();
                    foreach (CrossBindingAdaptorType tmp_CrossBindingAdaptorType in tmp_Components)
                    {
                        if (tmp_CrossBindingAdaptorType.ILInstance.Type.Name == tmp_FieldTypeName
                            || tmp_CrossBindingAdaptorType.ILInstance.Type.BaseType.Name == tmp_FieldTypeName)
                        {
                            _obj = tmp_CrossBindingAdaptorType.ILInstance;
                            break;
                        }
                    }

                    return true;
                }
                else
                {
                    var tmp_Components = tmp_GO.GetComponents<Component>().ToList();

                    var tmp_Component =
                        tmp_Components.Find(_component =>
                        {
                            if (_component == null) return false;

                            return _component.GetType().Name == tmp_FieldTypeName
                                   || _component.GetType().IsAssignableFrom(tmp_FieldInfo.FieldType)
                                   || tmp_FieldInfo.FieldType.IsInstanceOfType(_component);
                        });

                    if (!tmp_Component) return false;
                    _obj = tmp_Component;
                    return true;
                }
            }
            else
            {
                var tmp_PropertyInfo = _reflectionType?.GetProperty(_field.FieldName, _CONST_ALL_BINDING_FLAGS);

                if (tmp_PropertyInfo != null)
                {
                    string tmp_PropertyTypeName = tmp_PropertyInfo.PropertyType.Name;
                    if (tmp_PropertyInfo.PropertyType is UnityFusionType)
                    {
                        var tmp_Components = tmp_GO.GetComponents<CrossBindingAdaptorType>();
                        foreach (CrossBindingAdaptorType tmp_CrossBindingAdaptorType in
                                 tmp_Components)
                        {
                            if (tmp_CrossBindingAdaptorType.ILInstance.Type.Name !=
                                tmp_PropertyTypeName) continue;
                            _obj = tmp_CrossBindingAdaptorType.ILInstance;
                            break;
                        }
                    }
                    else
                    {
                        var tmp_Component = tmp_GO.GetComponents<Component>().ToList()
                            .Find(_component =>
                                _component.GetType().ToString().Contains(tmp_PropertyTypeName));
                        if (!tmp_Component) return false;
                        _obj = tmp_Component;
                        return true;
                    }
                }
                else
                {
                    Debug.LogError(
                        $"Auto binding {_go.name} was error:{_classPath}.{_field.FieldName} assignment error:{_field.FieldName} was not exist!");
                }
            }

            return false;
        }


        public static bool GetComponents(MonoField _field, Type _reflectionType,
            string _classPath,
            out object _obj)
        {
            List<ILTypeInstance> tmp_Objects = new();
            List<Component> tmp_ObjectsComponents = new();
            _obj = null;
            bool tmp_IsListType = false;
            Type tmp_CastType = null;

            foreach (GameObject tmp_GameObject in _field.Components)
            {
                if (string.IsNullOrEmpty(_field.Value) && tmp_GameObject == null) return true;
                Assert.IsNotNull(tmp_GameObject, "Element is Empty");

                if (tmp_GameObject == null)
                    return true;

                var tmp_FieldInfo = _reflectionType?.GetField(_field.FieldName, _CONST_ALL_BINDING_FLAGS);
                try
                {
                    if (tmp_FieldInfo != null)
                    {
                        tmp_IsListType = typeof(IList).IsAssignableFrom(tmp_FieldInfo.FieldType) &&
                                         tmp_FieldInfo.FieldType.IsGenericType;
                        tmp_CastType = tmp_FieldInfo.FieldType.IsArray || tmp_IsListType
                            ? tmp_FieldInfo.FieldType.IsGenericType
                                ? tmp_FieldInfo.FieldType.GenericTypeArguments[0]
                                : tmp_FieldInfo.FieldType.GetElementType()
                            : tmp_FieldInfo.FieldType;
                        string tmp_FieldTypeName = tmp_CastType.Name;
                        if (tmp_CastType is UnityFusionType tmp_FusionType)
                        {
                            var tmp_CrossBindingAdaptorTypes = tmp_GameObject.GetComponents<CrossBindingAdaptorType>();
                            var tmp_Adapters = tmp_CrossBindingAdaptorTypes.Where(_apterType =>
                                {
                                    var tmp_ILType = _apterType.ILInstance.Type;
                                    return tmp_ILType.Name == tmp_FieldTypeName ||
                                           tmp_ILType.ReflectionType.IsSubclassOf(tmp_FusionType);
                                })
                                .Select(_adapterType => _adapterType.ILInstance).ToList();
                            tmp_Objects.AddRange(tmp_Adapters);
                        }
                        else if (tmp_CastType.GetInterfaces().Contains(typeof(CrossBindingAdaptorType)))
                        {
                            var tmp_CrossBindingAdaptorTypes = tmp_GameObject.GetComponents<CrossBindingAdaptorType>();
                            var tmp_Adapters = tmp_CrossBindingAdaptorTypes.Where(_apterType =>
                                {
                                    var tmp_ILType = _apterType.ILInstance.Type;
                                    return tmp_ILType.TypeForCLR.Name == tmp_FieldTypeName;
                                })
                                .Select(_adapterType => _adapterType.ILInstance).ToList();
                            tmp_Objects.AddRange(tmp_Adapters);
                        }
                        else
                        {
                            // Builtin component types
                            var tmp_Components = tmp_GameObject.GetComponents(tmp_CastType);
                            if (tmp_Components.Length > 0)
                            {
                                tmp_ObjectsComponents.AddRange(tmp_Components);
                                tmp_CastType = tmp_Components[0].GetType();
                            }
                        }
                    }
                    else
                    {
                        // For properties
                        var tmp_PropertyInfo = _reflectionType?.GetProperty(_field.FieldName,
                            BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance |
                            BindingFlags.Static);
                        if (tmp_PropertyInfo != null)
                        {
                            tmp_CastType = tmp_PropertyInfo.PropertyType;

                            tmp_IsListType = typeof(IList).IsAssignableFrom(tmp_CastType) && tmp_CastType.IsGenericType;

                            string tmp_PropertyTypeName = tmp_CastType.Name;
                            if (tmp_CastType is UnityFusionType)
                            {
                                var tmp_Components = tmp_GameObject.GetComponents<CrossBindingAdaptorType>();

                                tmp_Objects.AddRange(tmp_Components.Where(_component =>
                                        _component.ILInstance.Type.Name == tmp_PropertyTypeName)
                                    .Select(_component => _component.ILInstance)
                                    .ToList());
                            }
                            else
                            {
                                tmp_ObjectsComponents.AddRange(tmp_GameObject.GetComponents(tmp_CastType));
                            }
                        }
                        else
                        {
                            Debug.LogError(
                                $"Auto binding {tmp_GameObject.name} was error:{_classPath}.{_field.FieldName} assignment error:{_field.FieldName} was not exist!");
                        }
                    }
                }
                catch (Exception tmp_Exception)
                {
                    Debug.LogError(tmp_Exception);
                }
            }


            if (tmp_Objects is {Count: > 0})
            {
                _obj = tmp_IsListType ? tmp_Objects : tmp_Objects.ToArray();
                return true;
            }

            if (tmp_ObjectsComponents is not {Count: > 0}) return false;
            if (tmp_CastType == typeof(MeshFilter))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<MeshFilter>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(MeshRenderer))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<MeshRenderer>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(SkinnedMeshRenderer))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<SkinnedMeshRenderer>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(TextMeshPro))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<TextMeshPro>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(Transform))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<Transform>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(LineRenderer))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<LineRenderer>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(TrailRenderer))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<TrailRenderer>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(SpriteRenderer))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<SpriteRenderer>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(SortingGroup))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<SortingGroup>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(ReflectionProbe))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<ReflectionProbe>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(NavMeshAgent))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<NavMeshAgent>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(NavMeshObstacle))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<NavMeshObstacle>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(NavMeshLink))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<NavMeshLink>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(Image))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<Image>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(Text))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<Text>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(Slider))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<Slider>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(Button))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<Button>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(RawImage))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<RawImage>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(CanvasGroup))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<CanvasGroup>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(Canvas))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<Canvas>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(CanvasScaler))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<CanvasScaler>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(GridLayout))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<GridLayout>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(ContentSizeFitter))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<ContentSizeFitter>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(HorizontalLayoutGroup))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<HorizontalLayoutGroup>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(RectTransform))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<RectTransform>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(VerticalLayoutGroup))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<VerticalLayoutGroup>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(LayoutElement))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<LayoutElement>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(Toggle))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<Toggle>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(ToggleGroup))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<ToggleGroup>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(Scrollbar))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<Scrollbar>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(RectMask2D))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<RectMask2D>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(Slider))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<Slider>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(Selectable))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<Selectable>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(Mask))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<Mask>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(ScrollRect))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<ScrollRect>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(TMP_InputField))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<TMP_InputField>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(InputField))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<InputField>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(Dropdown))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<Dropdown>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(TMP_Dropdown))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<TMP_Dropdown>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(AudioSource))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<AudioSource>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(VideoPlayer))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<VideoPlayer>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(Light))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<Light>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(Rigidbody))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<Rigidbody>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(BoxCollider))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<BoxCollider>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(SphereCollider))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<SphereCollider>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(CapsuleCollider))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<CapsuleCollider>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(MeshCollider))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<MeshCollider>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(CharacterController))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<CharacterController>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(Joint))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<Joint>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(FixedJoint))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<FixedJoint>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(CharacterJoint))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<CharacterJoint>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(SpringJoint))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<SpringJoint>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(HingeJoint))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<HingeJoint>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(AimConstraint))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<AimConstraint>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(Animation))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<Animation>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(Animator))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<Animator>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(BillboardRenderer))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<BillboardRenderer>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(Grid))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<Grid>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(LookAtConstraint))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<LookAtConstraint>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(ParentConstraint))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<ParentConstraint>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(PositionConstraint))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<PositionConstraint>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(RotationConstraint))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<RotationConstraint>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(ScaleConstraint))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<ScaleConstraint>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(SpriteMask))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<SpriteMask>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(WindZone))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<WindZone>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(LightProbeProxyVolume))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<LightProbeProxyVolume>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(LightProbeGroup))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<LightProbeGroup>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
            else if (tmp_CastType == typeof(MonoBehaviour))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<MonoBehaviour>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
#if USE_AUDIO_MODULE
            else if (tmp_CastType == typeof(Phantom.XRMOD.AudioModule.Runtime.AudioEmitter))
            {
                var tmp_Casted = tmp_ObjectsComponents.Cast<Phantom.XRMOD.AudioModule.Runtime.AudioEmitter>();
                _obj = tmp_IsListType ? tmp_Casted.ToList() : tmp_Casted.ToArray();
            }
#endif

            return true;
        }

        public static GameObject GetGameObjectFields(Type _reflectionType, MonoField _field)
        {
            GameObject tmp_GO = _field.GameObject;
            if (_field.Value.ToLower().Equals("null") && tmp_GO == null) return null;
            if (tmp_GO == null)
            {
                try
                {
                    tmp_GO = _field.Value == "$(this)" ? tmp_GO : GameObject.Find(_field.FieldName);
                    if (tmp_GO == null) // Find the parent object
                    {
                        tmp_GO = FindSubGameObject(_field);
                        return tmp_GO;
                    }
                }
                catch (Exception tmp_Exception) // If an null exception is raised, find the parent object
                {
                    tmp_GO = FindSubGameObject(_field);
                    if (tmp_GO == null)
                    {
                        Debug.LogError(tmp_Exception.Message);
                        return tmp_GO;
                    }
                }
            }

            return tmp_GO;
        }

        public static object GetNumberFields(Type _reflectionType, MonoField _field)
        {
            object tmp_Obj = null;
            var tmp_FieldType = _reflectionType.GetField(_field.FieldName, _CONST_ALL_BINDING_FLAGS)
                ?.FieldType ?? _reflectionType.GetProperty(_field.FieldName, _CONST_ALL_BINDING_FLAGS)
                ?.PropertyType;

            Assert.IsNotNull(tmp_FieldType);

            if (tmp_FieldType.FullName == typeof(SByte).FullName)
            {
                tmp_Obj = SByte.Parse(_field.Value);
            }
            else if (tmp_FieldType.FullName == typeof(Byte).FullName)
            {
                tmp_Obj = Byte.Parse(_field.Value);
            }
            else if (tmp_FieldType.FullName == typeof(Int16).FullName)
            {
                tmp_Obj = Int16.Parse(_field.Value);
            }
            else if (tmp_FieldType.FullName == typeof(Int32).FullName)
            {
                tmp_Obj = Int32.Parse(_field.Value);
            }
            else if (tmp_FieldType.FullName == typeof(Int64).FullName)
            {
                tmp_Obj = Int64.Parse(_field.Value);
            }
            else if (tmp_FieldType.FullName == typeof(UInt16).FullName)
            {
                tmp_Obj = UInt16.Parse(_field.Value);
            }
            else if (tmp_FieldType.FullName == typeof(UInt32).FullName)
            {
                tmp_Obj = UInt32.Parse(_field.Value);
            }
            else if (tmp_FieldType.FullName == typeof(UInt64).FullName)
            {
                tmp_Obj = UInt64.Parse(_field.Value);
            }
            else if (tmp_FieldType.FullName == typeof(Single).FullName)
            {
                tmp_Obj = Single.Parse(_field.Value);
            }
            else if (tmp_FieldType.FullName == typeof(Decimal).FullName)
            {
                tmp_Obj = Decimal.Parse(_field.Value);
            }
            else if (tmp_FieldType.FullName == typeof(Double).FullName)
            {
                tmp_Obj = Double.Parse(_field.Value);
            }

            return tmp_Obj;
        }

        public static GameObject FindSubGameObject(MonoField _field)
        {
            if (_field.Value.Contains("/"))
            {
                try
                {
                    var tmp_Parent =
                        GameObject.Find(_field.Value.Substring(0, _field.Value.IndexOf("/", StringComparison.Ordinal)));
                    var tmp_Child =
                        tmp_Parent.transform.Find(
                            _field.Value.Substring(_field.Value.IndexOf("/", StringComparison.Ordinal) + 1)).gameObject;
                    return tmp_Child;
                }
                catch (Exception tmp_Exception)
                {
                    Debug.LogError(
                        $"Auto binding was error:{_field.Value} not exist or hidden,can not to find - Skipped\n{tmp_Exception.Message}");
                }
            }
            else
            {
                Debug.LogError(
                    $"Auto binding was error:{_field.Value} not exist or hidden,can not to find - Skipped");
            }

            return null;
        }
    }
}
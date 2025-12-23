using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using Phantom.XRMOD.Core.Runtime;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;
using UnityFusion.CLRBinding.Adapter;

namespace Phantom.XRMOD.UnityFusion.Editor
{
    [CustomEditor(typeof(XRMODBehaviourAdapter.Adapter), true)]
    public class UnityFusionBehaviourInspector : UnityEditor.Editor
    {
        // private foldouts
        private readonly Dictionary<string, bool> foldouts = new();
        private XRMODBehaviourAdapter.Adapter adapter;

        private void OnEnable()
        {
            adapter = target as XRMODBehaviourAdapter.Adapter;
            if (adapter == null) return;

            var tmp_ILInstance = adapter.ILInstance;
            if (tmp_ILInstance == null) return;

            var tmp_DisplayName = ObjectNames.NicifyVariableName(tmp_ILInstance.Type.ReflectionType.Name);
            ComponentNameUtils.SetName(adapter, $"{tmp_DisplayName} (UnityFusion Runtime)");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            if (adapter == null || adapter.ILInstance == null)
            {
                EditorGUILayout.HelpBox("Missing UnityFusion instance.", MessageType.Warning);
                return;
            }

            var _instance = adapter.ILInstance;
            var _fields = _instance.Type.ReflectionType.GetFields(
                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

            foreach (var _field in _fields)
            {
                bool tmp_ShouldDraw =
                    _field.IsPublic ||
                    _field.IsDefined(typeof(SerializeField), true) ||
                    _field.IsDefined(typeof(DataPropertyAttribute), true);

                if (!tmp_ShouldDraw) continue;
                DrawField(_field, _instance);
            }

            serializedObject.ApplyModifiedProperties();
        }

        // --- helpers ---------------------------------------------------------

        // 生成唯一折叠键：不受显示名、大小写、Nicify 影响
        private static string GetUniqueFoldoutKey(FieldInfo _field)
        {
            // 安全的唯一键，不使用 MetadataToken，兼容 UnityFusion / ILRuntime
            string tmp_Decl = _field.DeclaringType?.FullName ?? "UnknownType";
            string tmp_Name = _field.Name;
            string tmp_Type = _field.FieldType?.FullName ?? "UnknownFieldType";
            return $"{tmp_Decl}::{tmp_Name}::{tmp_Type}";
        }


        private static string GetDisplayName(FieldInfo _field)
        {
            // 用 Nicify 仅做显示
            return ObjectNames.NicifyVariableName(_field.Name);
        }

        // --- draw ------------------------------------------------------------

        private void DrawField(FieldInfo _field, object _instance)
        {
            var tmp_DisplayName = GetDisplayName(_field);
            var tmp_FoldoutKey = GetUniqueFoldoutKey(_field);
            var tmp_Value = _field.GetValue(_instance);
            var tmp_Type = _field.FieldType;
            string tmp_FullName = tmp_Type.FullName;

            if (tmp_Value == null)
            {
                var tmp_Color = GUI.color;
                GUI.color = Color.red;
                EditorGUILayout.LabelField(tmp_DisplayName, "NULL*");
                GUI.color = tmp_Color;
                return;
            }

            try
            {
                // 🔹 Step 1：类型匹配容错（兼容 UnityFusion ILRuntimeType）
                Type tmp_RealType = tmp_Value.GetType();
                bool tmp_IsBoxedValue = tmp_RealType.IsPrimitive || tmp_RealType == typeof(string);

                // ✅ int / float / bool / string (含封装类型)
                if ((tmp_Type == typeof(int) || tmp_RealType == typeof(int)) && tmp_FullName != "UnityEngine.LayerMask")
                {
                    int tmp_New =
                        Convert.ToInt32(EditorGUILayout.IntField(tmp_DisplayName, Convert.ToInt32(tmp_Value)));
                    _field.SetValue(_instance, tmp_New);
                }
                else if (tmp_Type == typeof(float) || tmp_RealType == typeof(float) || tmp_RealType == typeof(double))
                {
                    float tmp_New =
                        Convert.ToSingle(EditorGUILayout.FloatField(tmp_DisplayName, Convert.ToSingle(tmp_Value)));
                    _field.SetValue(_instance, tmp_New);
                }
                else if (tmp_Type == typeof(bool) || tmp_RealType == typeof(bool))
                {
                    bool tmp_New =
                        Convert.ToBoolean(EditorGUILayout.Toggle(tmp_DisplayName, Convert.ToBoolean(tmp_Value)));
                    _field.SetValue(_instance, tmp_New);
                }
                else if (tmp_Type == typeof(string) || tmp_RealType == typeof(string))
                {
                    string tmp_New = EditorGUILayout.TextField(tmp_DisplayName, Convert.ToString(tmp_Value));
                    _field.SetValue(_instance, tmp_New);
                }
                // ✅ Vector / Color
                else if (tmp_FullName == "UnityEngine.Vector2")
                {
                    Vector2 tmp_New = EditorGUILayout.Vector2Field(tmp_DisplayName, ToVector2(tmp_Value));
                    _field.SetValue(_instance, tmp_New);
                }
                else if (tmp_FullName == "UnityEngine.Vector3")
                {
                    Vector3 tmp_New = EditorGUILayout.Vector3Field(tmp_DisplayName, ToVector3(tmp_Value));
                    _field.SetValue(_instance, tmp_New);
                }
                else if (tmp_FullName == "UnityEngine.Vector4")
                {
                    Vector3 tmp_New = EditorGUILayout.Vector4Field(tmp_DisplayName, ToVector4(tmp_Value));
                    _field.SetValue(_instance, tmp_New);
                }
                else if (tmp_FullName == "UnityEngine.Quaternion")
                {
                    Quaternion tmp_New =
                        Quaternion.Euler(EditorGUILayout.Vector3Field(tmp_DisplayName,
                            ToQuaternion(tmp_Value).eulerAngles));
                    _field.SetValue(_instance, tmp_New);
                }
                else if (tmp_FullName == "UnityEngine.Color")
                {
                    Color tmp_New = EditorGUILayout.ColorField(tmp_DisplayName, ToColor(tmp_Value));
                    _field.SetValue(_instance, tmp_New);
                }
                else if (tmp_FullName == "UnityEngine.LayerMask")
                {
                    if (tmp_Value is LayerMask)
                    {
                        LayerMask tmp_Cur = ToLayerMask(tmp_Value);
                        LayerMask tmp_New = EditorGUILayout.LayerField(tmp_DisplayName, tmp_Cur);
                        _field.SetValue(_instance, tmp_New);
                    }
                    else
                    {
                        var tmp_MaskValue = EditorGUILayout.MaskField("Layer Mask", (int) tmp_Value,
                            InternalEditorUtility.layers);
                        _field.SetValue(_instance, tmp_MaskValue);
                    }
                }
                else if (tmp_FullName == "UnityEngine.AnimationCurve")
                {
                    AnimationCurve tmp_New = EditorGUILayout.CurveField(tmp_DisplayName, ToCurve(tmp_Value));
                    _field.SetValue(_instance, tmp_New);
                }
                // ✅ Enum（安全转换）
                else if (tmp_Type.IsEnum)
                {
                    // 🧩 获取枚举底层类型（可能是 byte, short, int...）
                    var tmp_UnderType = Enum.GetUnderlyingType(tmp_Type);
                    object tmp_ConvertedValue = tmp_Value;

                    // ✅ 仅在类型不匹配时才进行转换，避免 Byte→Byte 抛异常
                    if (tmp_Value.GetType() != tmp_UnderType)
                    {
                        try
                        {
                            tmp_ConvertedValue = Convert.ChangeType(tmp_Value, tmp_UnderType);
                        }
                        catch
                        {
                            // fallback 安全转换
                            tmp_ConvertedValue = System.Convert.ToInt64(tmp_Value);
                        }
                    }

                    // ✅ 生成枚举对象（类型安全）
                    var tmp_EnumObj = (Enum) Enum.ToObject(tmp_Type, tmp_ConvertedValue);

                    // ✅ 绘制 Enum Popup
                    var tmp_NewEnum = EditorGUILayout.EnumPopup(tmp_DisplayName, tmp_EnumObj);

                    // ✅ 获取更新后的底层值，再安全写回
                    var tmp_NewUnderlying = System.Convert.ChangeType(tmp_NewEnum, tmp_UnderType);
                    _field.SetValue(_instance, tmp_NewUnderlying);
                }
                // ✅ Unity Object / MonoBehaviour / Adapter
                else if (typeof(UnityEngine.Object).IsAssignableFrom(tmp_Type) ||
                         tmp_Type == typeof(MonoBehaviour) ||
                         tmp_Type.IsSubclassOf(typeof(MonoBehaviour)) ||
                         tmp_Type == typeof(XRMODBehaviourAdapter.Adapter))
                {
                    var tmp_New = EditorGUILayout.ObjectField(tmp_DisplayName, tmp_Value as UnityEngine.Object,
                        tmp_Type, true);
                    _field.SetValue(_instance, tmp_New);
                }
                // ✅ Array / List
                else if (tmp_Type.IsArray || typeof(IList).IsAssignableFrom(tmp_Type))
                {
                    DrawArrayOrList(tmp_FoldoutKey, tmp_DisplayName, tmp_Value);
                }
                // ✅ 自动识别 boxed primitive（ILRuntime/UnityFusion）
                else if (tmp_IsBoxedValue)
                {
                    var tmp_Converted = Convert.ToString(tmp_Value);
                    string tmp_New = EditorGUILayout.TextField(tmp_DisplayName, tmp_Converted);
                    // 自动转回原类型
                    object tmp_Final = Convert.ChangeType(tmp_New, tmp_RealType);
                    _field.SetValue(_instance, tmp_Final);
                }
                else
                { 
                    // 其他非原生类型（结构体/复杂类型）
                    EditorGUILayout.LabelField(tmp_DisplayName, $"({tmp_Type.Name}) {tmp_Value}");
                }
            }
            catch (Exception tmp_Exception)
            {
                EditorGUILayout.HelpBox($"Error drawing field {tmp_DisplayName}: {tmp_Exception.Message}",
                    MessageType.Error);
            }
        }


        private void DrawArrayOrList(string _foldoutKey, string _displayName, object _value)
        {
            if (_value == null)
            {
                var tmp_Color = GUI.color;
                GUI.color = Color.red;
                EditorGUILayout.LabelField(_displayName, "NULL*");
                GUI.color = tmp_Color;
                return;
            }

            if (!(_value is IList tmp_List)) return;

            // ★ 用唯一 foldoutKey 控制状态，不再用显示名，杜绝大小写冲突 & Nicify 碰撞
            foldouts.TryAdd(_foldoutKey, false);
            foldouts[_foldoutKey] = EditorGUILayout.BeginFoldoutHeaderGroup(foldouts[_foldoutKey], _displayName);

            if (foldouts[_foldoutKey])
            {
                if (tmp_List.Count == 0)
                {
                    EditorGUILayout.LabelField("Empty", EditorStyles.centeredGreyMiniLabel);
                }
                else
                {
                    for (int tmp_Idx = 0; tmp_Idx < tmp_List.Count; tmp_Idx++)
                    {
                        var tmp_Element = tmp_List[tmp_Idx];
                        var tmp_Type = tmp_Element?.GetType();

                        if (tmp_Element == null)
                        {
                            var tmp_Color = GUI.color;
                            GUI.color = Color.red;
                            EditorGUILayout.LabelField($"[{tmp_Idx}]", "NULL*");
                            GUI.color = tmp_Color;
                            continue;
                        }

                        if (tmp_Type == typeof(int))
                            tmp_List[tmp_Idx] = EditorGUILayout.IntField($"[{tmp_Idx}]", (int) tmp_Element);
                        else if (tmp_Type == typeof(float))
                            tmp_List[tmp_Idx] = EditorGUILayout.FloatField($"[{tmp_Idx}]", (float) tmp_Element);
                        else if (tmp_Type == typeof(bool))
                            tmp_List[tmp_Idx] = EditorGUILayout.Toggle($"[{tmp_Idx}]", (bool) tmp_Element);
                        else if (tmp_Type == typeof(string))
                            tmp_List[tmp_Idx] = EditorGUILayout.TextField($"[{tmp_Idx}]", (string) tmp_Element);
                        else if (tmp_Type == typeof(Vector2))
                            tmp_List[tmp_Idx] = EditorGUILayout.Vector2Field($"[{tmp_Idx}]", (Vector2) tmp_Element);
                        else if (tmp_Type == typeof(Vector3))
                            tmp_List[tmp_Idx] = EditorGUILayout.Vector3Field($"[{tmp_Idx}]", (Vector3) tmp_Element);
                        else if (tmp_Type == typeof(Vector4))
                            tmp_List[tmp_Idx] = EditorGUILayout.Vector4Field($"[{tmp_Idx}]", (Vector4) tmp_Element);
                        else if (tmp_Type == typeof(Color))
                            tmp_List[tmp_Idx] = EditorGUILayout.ColorField($"[{tmp_Idx}]", (Color) tmp_Element);
                        else if (typeof(UnityEngine.Object).IsAssignableFrom(tmp_Type))
                            tmp_List[tmp_Idx] = EditorGUILayout.ObjectField($"[{tmp_Idx}]",
                                tmp_Element as UnityEngine.Object, tmp_Type, true);
                        else
                            EditorGUILayout.LabelField($"[{tmp_Idx}]", tmp_Element.ToString());
                    }
                }
            }

            EditorGUILayout.EndFoldoutHeaderGroup();
        }

        private static Vector2 ToVector2(object val)
        {
            if (val is Vector2 v2) return v2;
            try
            {
                return (Vector2) Convert.ChangeType(val, typeof(Vector2));
            }
            catch
            {
                return default;
            }
        }

        private static Vector3 ToVector3(object val)
        {
            if (val is Vector3 v3) return v3;
            try
            {
                // UnityFusion 代理类型一般有 ToVector3()/ToUnityValue() 方法
                var method = val.GetType().GetMethod("ToVector3") ?? val.GetType().GetMethod("ToUnityValue");
                if (method != null) return (Vector3) method.Invoke(val, null);
            }
            catch
            {
            }

            return default;
        }

        private static Vector4 ToVector4(object val)
        {
            if (val is Vector4 v4) return v4;
            return default;
        }

        private static Quaternion ToQuaternion(object val)
        {
            if (val is Quaternion q) return q;
            try
            {
                var method = val.GetType().GetMethod("ToQuaternion") ?? val.GetType().GetMethod("ToUnityValue");
                if (method != null) return (Quaternion) method.Invoke(val, null);
            }
            catch
            {
            }

            return Quaternion.identity;
        }

        private static Color ToColor(object val)
        {
            if (val is Color c) return c;
            try
            {
                var method = val.GetType().GetMethod("ToColor") ?? val.GetType().GetMethod("ToUnityValue");
                if (method != null) return (Color) method.Invoke(val, null);
            }
            catch
            {
            }

            return Color.white;
        }

        private static LayerMask ToLayerMask(object val)
        {
            if (val is LayerMask m) return m;
            if (val is int i) return i;
            try
            {
                return (int) Convert.ChangeType(val, typeof(int));
            }
            catch
            {
                return default;
            }
        }

        private static AnimationCurve ToCurve(object val)
        {
            if (val is AnimationCurve c) return c;
            try
            {
                var method = val.GetType().GetMethod("ToUnityValue");
                if (method != null) return (AnimationCurve) method.Invoke(val, null);
            }
            catch
            {
            }

            return new AnimationCurve();
        }
    }
}
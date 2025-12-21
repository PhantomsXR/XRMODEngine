using UnityEditor;
using UnityEngine;
using Phantom.XRMOD.Models.Runtime;

namespace Phantom.XRMOD.Models.Editor
{
    [CustomPropertyDrawer(typeof(DashboardConfig))]
    public class DashboardConfigDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect _position, SerializedProperty _property, GUIContent _label)
        {
            EditorGUI.BeginProperty(_position, _label, _property);

            // Create a foldout for the class
            _property.isExpanded =
                EditorGUI.Foldout(
                    new Rect(_position.x, _position.y, _position.width, EditorGUIUtility.singleLineHeight),
                    _property.isExpanded, _label, true);

            if (_property.isExpanded)
            {
                // Indent child properties
                EditorGUI.indentLevel++;

                // Find properties
                var tmp_BackendTypeProp = _property.FindPropertyRelative("backendType");
                var tmp_DashboardGatewayProp = _property.FindPropertyRelative("dashboardGateway");
                var tmp_ExceptionCollectorUrlProp = _property.FindPropertyRelative("exceptionCollectorUrl");
                var tmp_TokenProp = _property.FindPropertyRelative("token");
                var tmp_AppKeyProp = _property.FindPropertyRelative("appKey");
                var tmp_TimeoutProp = _property.FindPropertyRelative("timeout");
                var tmp_MaximumDownloadSizeProp = _property.FindPropertyRelative("maximumDownloadSize");

                float tmp_Y = _position.y + EditorGUIUtility.singleLineHeight +
                              EditorGUIUtility.standardVerticalSpacing;

                // Backend Type
                tmp_Y += DrawProperty(ref _position, tmp_BackendTypeProp, tmp_Y);

                bool tmp_IsSupabase = tmp_BackendTypeProp.enumValueIndex == (int) BackendType.Supabase;

                tmp_Y += DrawProperty(ref _position, tmp_DashboardGatewayProp, tmp_Y);
                
                // Conditionally draw legacy fields
                if (!tmp_IsSupabase)
                {
                    tmp_Y += DrawProperty(ref _position, tmp_ExceptionCollectorUrlProp, tmp_Y);
                    tmp_Y += DrawProperty(ref _position, tmp_TokenProp, tmp_Y);
                }
                else
                {
                    tmp_Y += DrawProperty(ref _position, tmp_AppKeyProp, tmp_Y);
                }

                // Remaining fields
                tmp_Y += DrawProperty(ref _position, tmp_TimeoutProp, tmp_Y);
                tmp_Y += DrawProperty(ref _position, tmp_MaximumDownloadSizeProp, tmp_Y);

                EditorGUI.indentLevel--;
            }

            EditorGUI.EndProperty();
        }

        private float DrawProperty(ref Rect _position, SerializedProperty _prop, float _y)
        {
            float tmp_Height = EditorGUI.GetPropertyHeight(_prop);
            Rect tmp_Rect = new Rect(_position.x, _y, _position.width, tmp_Height);
            EditorGUI.PropertyField(tmp_Rect, _prop, true);
            return tmp_Height + EditorGUIUtility.standardVerticalSpacing;
        }

        public override float GetPropertyHeight(SerializedProperty _property, GUIContent _label)
        {
            if (!_property.isExpanded)
            {
                return EditorGUIUtility.singleLineHeight;
            }

            float tmp_TotalHeight = EditorGUIUtility.singleLineHeight + EditorGUIUtility.standardVerticalSpacing;

            var tmp_BackendTypeProp = _property.FindPropertyRelative("backendType");
            tmp_TotalHeight += EditorGUI.GetPropertyHeight(tmp_BackendTypeProp) +
                               EditorGUIUtility.standardVerticalSpacing;

            bool tmp_IsSupabase = tmp_BackendTypeProp.enumValueIndex == (int) BackendType.Supabase;

            if (!tmp_IsSupabase)
            {
                tmp_TotalHeight += EditorGUI.GetPropertyHeight(_property.FindPropertyRelative("dashboardGateway")) +
                                   EditorGUIUtility.standardVerticalSpacing;
                tmp_TotalHeight += EditorGUI.GetPropertyHeight(_property.FindPropertyRelative("token")) +
                                   EditorGUIUtility.standardVerticalSpacing;
            }

            tmp_TotalHeight += EditorGUI.GetPropertyHeight(_property.FindPropertyRelative("exceptionCollectorUrl")) +
                               EditorGUIUtility.standardVerticalSpacing;
            tmp_TotalHeight += EditorGUI.GetPropertyHeight(_property.FindPropertyRelative("appKey")) +
                               EditorGUIUtility.standardVerticalSpacing;
            tmp_TotalHeight += EditorGUI.GetPropertyHeight(_property.FindPropertyRelative("timeout")) +
                               EditorGUIUtility.standardVerticalSpacing;
            tmp_TotalHeight += EditorGUI.GetPropertyHeight(_property.FindPropertyRelative("maximumDownloadSize")) +
                               EditorGUIUtility.standardVerticalSpacing;

            return tmp_TotalHeight;
        }
    }
}
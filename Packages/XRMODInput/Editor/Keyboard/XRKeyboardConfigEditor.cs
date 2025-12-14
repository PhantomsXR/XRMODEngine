// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UIFramework.Editor.
// //
// // The RokidPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/
#if USE_XRI

using Phantom.XRMOD.XRMODInput.Runtime.Keyboard;
using UnityEditor.XR.Interaction.Toolkit;
using UnityEngine;
using EditorGUILayout = UnityEditor.EditorGUILayout;
using SerializedProperty = UnityEditor.SerializedProperty;

namespace Phantom.XRMOD.XRMODInput.Editor.Keyboard
{
    /// <summary>
    /// Custom editor for an <see cref="XRKeyboardConfig"/>.
    /// </summary>
    [UnityEditor.CustomEditor(typeof(XRKeyboardConfig), true), UnityEditor.CanEditMultipleObjects]
    public class XRKeyboardConfigEditor : BaseInteractionEditor
    {
        /// <summary><see cref="UnityEditor.SerializedProperty"/> of the <see cref="SerializeField"/> backing <see cref="XRKeyboardConfig.defaultKeyFunction"/>.</summary>
        protected SerializedProperty m_DefaultKeyFunction;
        /// <summary><see cref="SerializedProperty"/> of the <see cref="SerializeField"/> backing <see cref="XRKeyboardConfig.keyMappings"/>.</summary>
        protected SerializedProperty m_KeyMappings;

        /// <summary>
        /// See <see cref="Editor"/>.
        /// </summary>
        protected virtual void OnEnable()
        {
            m_DefaultKeyFunction = serializedObject.FindProperty("m_DefaultKeyFunction");
            m_KeyMappings = serializedObject.FindProperty("m_KeyMappings");
        }

        /// <inheritdoc />
        protected override void DrawInspector()
        {
            DrawScript();
            EditorGUILayout.PropertyField(m_DefaultKeyFunction);
            EditorGUILayout.PropertyField(m_KeyMappings);
        }
    }
}

#endif
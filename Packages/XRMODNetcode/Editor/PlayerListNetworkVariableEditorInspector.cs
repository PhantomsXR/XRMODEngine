// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Assembly-CSharp.
// //
// // The SlingshotMatch cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.NetcodeModule.Runtime;
using UnityEditor; 

namespace Phantom.XRMOD.NetcodeModule.Editor
{
    [CustomEditor(typeof(PlayerListNetworkVariable))]
    public class PlayerListNetworkVariableEditorInspector : UnityEditor.Editor
    {
        private PlayerListNetworkVariable holder;

        private void OnEnable()
        {
            holder = (PlayerListNetworkVariable) target;
        }

        public override void OnInspectorGUI()
        {
            DrawDefaultInspector();

            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Player List (Runtime)", EditorStyles.boldLabel);

            if (holder.PlayerList == null)
            {
                EditorGUILayout.HelpBox("PlayerList is not initialized.", MessageType.Info);
                return;
            }

            int tmp_Count = holder.PlayerList.Count;

            if (tmp_Count == 0)
            {
                EditorGUILayout.HelpBox("No players in the list.", MessageType.Info);
            }
            else
            {
                for (int tmp_Index = 0; tmp_Index < tmp_Count; tmp_Index++)
                {
                    var tmp_Player = holder.PlayerList[tmp_Index];

                    EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField($"Index {tmp_Index}", EditorStyles.boldLabel);
                    EditorGUILayout.LabelField("ClientId", tmp_Player.ClientId.ToString());
                    EditorGUILayout.LabelField("PlayerObject", tmp_Player.PlayerObject.ToString());
                    EditorGUILayout.EndHorizontal();
                }
            }
        }
    }
}
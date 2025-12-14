// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.NetcodeModule.Editor.
// //
// // The SlingshotMatch cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using System.Linq;
using Phantom.XRMOD.NetcodeModule.Runtime;
using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.NetcodeModule.Editor
{
    [CustomEditor(typeof(PlayerScoreListNetworkVariable))]
    public class PlayerScoreListEditorInspector : UnityEditor.Editor
    {
        private Dictionary<ulong, int> scoreDict = new Dictionary<ulong, int>();
        PlayerScoreListNetworkVariable playerListNetworkVariable;

        private void OnEnable()
        {
            scoreDict.Clear();
            playerListNetworkVariable = (PlayerScoreListNetworkVariable) target;
            var tmp_PlayerIds = playerListNetworkVariable.GetPlayerScoreList.Keys.ToArray();
            var tmp_PlayerScores = playerListNetworkVariable.GetPlayerScoreList.Values.ToArray();
            for (int tmp_Idx = 0; tmp_Idx < tmp_PlayerIds.Length; tmp_Idx++)
            {
                scoreDict.TryAdd(tmp_PlayerIds[tmp_Idx], tmp_PlayerScores[tmp_Idx]);
            }
        }

        public override void OnInspectorGUI()
        {
            // 默认 Inspector（显示其他字段）
            DrawDefaultInspector();

            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Player Score List (Runtime)", EditorStyles.boldLabel);

            if (playerListNetworkVariable.PlayerScoreList == null) return;
            if (playerListNetworkVariable.PlayerScoreList.Count == 0)
            {
                EditorGUILayout.HelpBox("No players in the list.", MessageType.Info);
            }
            else
            {
                // 显示 KeyValue 对
                foreach (KeyValuePair<ulong, int> tmp_KV in scoreDict)
                {
                    EditorGUILayout.BeginHorizontal();
                    EditorGUILayout.LabelField($"PlayerID: {tmp_KV.Key}");
                    EditorGUILayout.LabelField($"Score: {tmp_KV.Value}");
                    EditorGUILayout.EndHorizontal();
                }
            }
        }
    }
}
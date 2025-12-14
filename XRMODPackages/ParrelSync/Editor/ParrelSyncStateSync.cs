using UnityEditor;
using UnityEngine;
using System.IO;

namespace ParrelSync
{
    [InitializeOnLoad]
    public class ParrelSyncStateSync
    {
        private const string StateFileName = "ParrelSyncState.json";
        private static string StateFilePath => Path.Combine("ProjectSettings", StateFileName);

        [System.Serializable]
        private class EditorState
        {
            public bool isPlaying;
            public bool isPaused;
        }

        static ParrelSyncStateSync()
        {
            if (ClonesManager.IsClone())
            {
                EditorApplication.update += CheckState;
            }
            else
            {
                EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
                EditorApplication.pauseStateChanged += OnPauseStateChanged;
            }
        }

        // Main Project Logic
        private static void OnPlayModeStateChanged(PlayModeStateChange state)
        {
            WriteState();
        }

        private static void OnPauseStateChanged(PauseState state)
        {
            WriteState();
        }

        private static void WriteState()
        {
            var state = new EditorState
            {
                isPlaying = EditorApplication.isPlaying,
                isPaused = EditorApplication.isPaused
            };

            string json = JsonUtility.ToJson(state);
            try
            {
                File.WriteAllText(StateFilePath, json);
            }
            catch (System.Exception e)
            {
                Debug.LogError($"[ParrelSync] Failed to write state: {e.Message}");
            }
        }

        // Clone Project Logic
        private static double lastCheckTime;
        private const double CheckInterval = 0.5f;

        private static void CheckState()
        {
            if (EditorApplication.timeSinceStartup - lastCheckTime < CheckInterval)
                return;

            lastCheckTime = EditorApplication.timeSinceStartup;

            if (!File.Exists(StateFilePath))
                return;

            try
            {
                string json = File.ReadAllText(StateFilePath);
                var targetState = JsonUtility.FromJson<EditorState>(json);

                if (targetState == null) return;

                // Sync Play State
                if (targetState.isPlaying != EditorApplication.isPlaying)
                {
                    EditorApplication.isPlaying = targetState.isPlaying;
                }

                // Sync Pause State
                // Only sync pause if we are playing, or if we are supposed to be playing
                if (EditorApplication.isPlaying && targetState.isPaused != EditorApplication.isPaused)
                {
                    EditorApplication.isPaused = targetState.isPaused;
                }
            }
            catch (System.Exception e)
            {
                Debug.LogWarning($"[ParrelSync] Failed to read state: {e.Message}");
            }
        }
    }
}

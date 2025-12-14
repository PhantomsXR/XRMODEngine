using System;
using System.Reflection;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditorInternal;
using UnityEngine;

namespace Phantom.XRMOD.Runtime.Editor
{
    /// <summary>
    /// Provides functionality to redirect Unity Console log clicks to custom stack trace locations.
    /// Also includes a menu item to toggle this feature.
    /// </summary>
    public static class LogRedirection
    {
        private static readonly Regex _CONST_REGEX = new(@"\(at (.+)\:(\d+)\)\r?\n");

        private static readonly Regex _CONST_VIRT_REGEX =
            new(@"IL_[0-9a-f]+: .*\r?\n.* \(at .+:\d+\)", RegexOptions.Multiline);

        private const string _CONST_ENABLE_LOG_REDIRECTION_KEY = "UnityFusionLogRedirection.Enabled";
        private const string _CONST_MENU_ITEM_PATH = "Tools/XR-MOD/Enable UnityFusion Trace";

        /// <summary>
        /// Gets or sets a value indicating whether log redirection is enabled.
        /// Stored in EditorPrefs and defaults to true.
        /// </summary>
        private static bool IsLogRedirectionEnabled
        {
            get => EditorPrefs.GetBool(_CONST_ENABLE_LOG_REDIRECTION_KEY, true);
            set => EditorPrefs.SetBool(_CONST_ENABLE_LOG_REDIRECTION_KEY, value);
        }

        /// <summary>
        /// Initializes the menu item state when the editor loads or scripts are reloaded.
        /// </summary>
        [InitializeOnLoadMethod]
        private static void InitLogRedirectionMenuItem()
        {
            Menu.SetChecked(_CONST_MENU_ITEM_PATH, IsLogRedirectionEnabled);
        }

        /// <summary>
        /// Toggles the log redirection feature on or off.
        /// </summary>
        [MenuItem(_CONST_MENU_ITEM_PATH, false, 10000)]
        private static void ToggleLogRedirection()
        {
            IsLogRedirectionEnabled = !IsLogRedirectionEnabled;
            Menu.SetChecked(_CONST_MENU_ITEM_PATH, IsLogRedirectionEnabled);
        }

        /// <summary>
        /// Callback for opening assets from the Unity Console.
        /// Redirects log clicks to custom stack trace locations if the feature is enabled.
        /// </summary>
        /// <param name="_instanceID">The instance ID of the object.</param>
        /// <param name="_line">The line number.</param>
        /// <returns>True if the log was handled by this method, false otherwise.</returns>
        [OnOpenAsset(0)]
        public static bool OpenLog(int _instanceID, int _line)
        {
            if (!IsLogRedirectionEnabled)
            {
                return false; // Do not handle if disabled, let Unity's default behavior take over.
            }

            string tmp_SelectedStackTrace = GetSelectedStackTrace();
            if (string.IsNullOrEmpty(tmp_SelectedStackTrace))
            {
                return false;
            }

            if (!tmp_SelectedStackTrace.Contains("UnityFusion StackTrace"))
            {
                Match tmp_VirtMatch = _CONST_VIRT_REGEX.Match(tmp_SelectedStackTrace);
                if (!tmp_VirtMatch.Success) return false;
                var tmp_LineMatch = new Regex(@" \(at (.+)\:(\d+)\)");
                var tmp_LineMatchResult = tmp_LineMatch.Match(tmp_VirtMatch.Groups[0].Value);
                if (!tmp_LineMatchResult.Success) return false;
                InternalEditorUtility.OpenFileAtLineExternal(tmp_LineMatchResult.Groups[1].Value,
                    int.Parse(tmp_LineMatchResult.Groups[2].Value));
                return true;
            }

            Match tmp_Match = _CONST_REGEX.Match(tmp_SelectedStackTrace);
            if (!tmp_Match.Success) return false;
            InternalEditorUtility.OpenFileAtLineExternal(tmp_Match.Groups[1].Value,
                int.Parse(tmp_Match.Groups[2].Value));
            return true;
        }

        /// <summary>
        /// Retrieves the currently selected stack trace from the Unity Console window.
        /// </summary>
        /// <returns>The selected stack trace string, or null if not found.</returns>
        private static string GetSelectedStackTrace()
        {
            Assembly tmp_EditorWindowAssembly = typeof(EditorWindow).Assembly;
            Type tmp_ConsoleWindowType = tmp_EditorWindowAssembly.GetType("UnityEditor.ConsoleWindow");
            if (tmp_ConsoleWindowType == null) return null;

            FieldInfo tmp_ConsoleWindowFieldInfo =
                tmp_ConsoleWindowType.GetField("ms_ConsoleWindow", BindingFlags.Static | BindingFlags.NonPublic);
            if (tmp_ConsoleWindowFieldInfo == null) return null;

            EditorWindow tmp_ConsoleWindow = tmp_ConsoleWindowFieldInfo.GetValue(null) as EditorWindow;
            if (tmp_ConsoleWindow == null) return null;

            // Only redirect if the Console window is currently focused
            if (tmp_ConsoleWindow != EditorWindow.focusedWindow) return null;

            FieldInfo tmp_ActiveTextFieldInfo =
                tmp_ConsoleWindowType.GetField("m_ActiveText", BindingFlags.Instance | BindingFlags.NonPublic);
            if (tmp_ActiveTextFieldInfo == null) return null;

            return (string) tmp_ActiveTextFieldInfo.GetValue(tmp_ConsoleWindow);
        }
    }
}
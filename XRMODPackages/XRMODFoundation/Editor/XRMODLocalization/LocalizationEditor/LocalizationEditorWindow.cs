// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODLocalization.Editor.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using Phantom.XRMOD.Localization.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.Localization.Editor
{
    public class LocalizationEditorWindow : EditorWindow
    {
        internal static LocalizationEditorWindow _WINDOW;

        private VisualElement tableDetailContainer;
        private IEditorDraw leftPane;
        private IEditorDraw rightPane;

        private IEditorDraw settingsButton;

        // private IEditorDraw addTableButton;
        private IEditorDraw aiTranslationButton;
        private IEditorDraw syncContentToAllTableButton;
        private const string _CONST_PREF_KEY = "LocalizationEditor_LastDbPath";

        // Save/dirty state
        private bool _hasUnsavedChanges = false;
        private ToolbarButton _saveToolbarButton;

        // Snapshots for revert (discard) behavior
        private LocalizationDatabase _snapshottedDb;
        private Dictionary<Object, string> _snapshots = new Dictionary<Object, string>();
        private HashSet<LocalizationTable> _snapshotTables = new HashSet<LocalizationTable>();

        [MenuItem("Tools/XR-MOD/Tools/Localization/Database Editor")]
        public static void ShowWindow()
        {
            if (_WINDOW != null) return;
            _WINDOW = GetWindow<LocalizationEditorWindow>();
            _WINDOW.titleContent = new GUIContent("Localization Editor");
        }

        public static void OpenWithDatabase(LocalizationDatabase _db)
        {
            if (SharedData.Instance.Database != null && SharedData.Instance.Database == _db) return;
            SharedData.Instance.Table = null;
            SharedData.Instance.Database = _db;
            // Capture clean snapshot for the opened DB
            if (_WINDOW != null)
            {
                _WINDOW.CaptureSnapshots();
            }
            ShowWindow();
            _WINDOW.RefreshTableList();
        }

        private void OnEnable()
        {
            ReloadDb();
        }

        private void OnDisable()
        {
            // Prompt to save or discard when closing the window if there are changes
            if (_hasUnsavedChanges && SharedData.Instance.Database != null)
            {
                int option = EditorUtility.DisplayDialogComplex(
                    "Unsaved Changes",
                    "Save changes to the Localization Database before closing?",
                    "Save",
                    "Don't Save",
                    "Cancel");

                if (option == 0)
                {
                    // Save
                    DoSave();
                }
                else if (option == 1)
                {
                    // Discard
                    RevertSnapshots();
                }
                else if (option == 2)
                {
                    // Cancel close: immediately reopen window to emulate cancel
                    EditorApplication.delayCall += ShowWindow;
                }
            }

            SharedData.Instance.Table = null;
            SharedData.Instance.Database = null;
            _WINDOW = null;
        }

        private void ReloadDb()
        {
            if (SharedData.Instance.Database != null) return;
            string tmp_Path = EditorPrefs.GetString($"{Application.productName}_{_CONST_PREF_KEY}", "");
            if (string.IsNullOrEmpty(tmp_Path)) return;
            var tmp_DB = AssetDatabase.LoadAssetAtPath<LocalizationDatabase>(tmp_Path);
            if (tmp_DB == null) return;
            SharedData.Instance.Database = tmp_DB;
            // Capture clean snapshot when loading a DB
            CaptureSnapshots();

            if (SharedData.Instance.Database.LocalizatoinSettings == null)
            {
                var tmp_SupportLanguageSettings = CreateInstance<LocalizatoinSettings>();
                tmp_SupportLanguageSettings.name = nameof(LocalizatoinSettings);
                Utilities.CreateAndAttachTable(SharedData.Instance.Database, tmp_SupportLanguageSettings);
            }

            RefreshTableList();
        }

        private static void PersistenceEditingDb()
        {
            if (SharedData.Instance.Database == null) return;
            string tmp_SavePath = AssetDatabase.GetAssetPath(SharedData.Instance.Database);
            EditorPrefs.SetString($"{Application.productName}_{_CONST_PREF_KEY}", tmp_SavePath);
        }

        private void CreateGUI()
        {
            ReloadDb();

            var tmp_Root = rootVisualElement;
            tmp_Root.styleSheets.Add(
                AssetDatabase.LoadAssetAtPath<StyleSheet>(
                    "Packages/com.phantomsxr.foundation/Editor/XRMODLocalization/Assets/LocalizationEditorWindow.uss"));

            Toolbar(tmp_Root);

            // ==== Split View ====
            var tmp_SplitView = new TwoPaneSplitView(0, 200, TwoPaneSplitViewOrientation.Horizontal);
            tmp_Root.Add(tmp_SplitView);

            // ==== Left Panel: Table List ====
            DrawLeftPane(tmp_SplitView);

            // ==== Right Panel: Table Details ====
            DrawRightPane(tmp_SplitView);

            RefreshTableList();
        }

        private void OnGUI()
        {
            // Handle Cmd/Ctrl + S (Unity dispatches Validate/ExecuteCommand with commandName == "Save")
            var e = Event.current;
            if (e == null) return;
            if (e.type == EventType.ValidateCommand && e.commandName == "Save")
            {
                // If we have unsaved changes, consume so the global save doesn't run first
                if (_hasUnsavedChanges)
                {
                    e.Use();
                }
            }
            else if (e.type == EventType.ExecuteCommand && e.commandName == "Save")
            {
                if (_hasUnsavedChanges)
                {
                    DoSave();
                    e.Use();
                }
            }
        }

        private void DrawRightPane(TwoPaneSplitView _splitView)
        {
            var tmp_RightPane = new VisualElement
            {
                name = "RightPane",
                style =
                {
                    flexGrow = 1
                }
            };

            rightPane = new RightEditorPanel(tmp_RightPane, this);
            rightPane.Draw();
            _splitView.Add(tmp_RightPane);
            rightPane.ReBuild();
        }

        private void DrawLeftPane(TwoPaneSplitView _splitView)
        {
            var tmp_LeftPane = new VisualElement
            {
                name = "LeftPane",
                style =
                {
                    flexGrow = 1
                }
            };
            leftPane = new LeftEditorPane(tmp_LeftPane, this);
            leftPane.Draw();
            _splitView.Add(tmp_LeftPane);
        }

        private void Toolbar(VisualElement _root)
        {
            // === Toolbar ===
            var tmp_Toolbar = new Toolbar();
            tmp_Toolbar.Clear();

            var tmp_ToolbarMenuButton = new ToolbarMenu() {text = "File"};
            tmp_ToolbarMenuButton.menu.AppendAction("Open", _data =>
            {
                string tmp_Path = EditorUtility.OpenFilePanel("Select LocalizationDatabase", "Assets", "asset");

                if (string.IsNullOrEmpty(tmp_Path) || !tmp_Path.StartsWith(Application.dataPath)) return;
                string tmp_RelativePath = "Assets" + tmp_Path.Substring(Application.dataPath.Length);
                var tmp_LoadedDb = AssetDatabase.LoadAssetAtPath<LocalizationDatabase>(tmp_RelativePath);
                if (tmp_LoadedDb != null)
                {
                    SharedData.Instance.Database = tmp_LoadedDb;
                    CaptureSnapshots();
                    RefreshTableList();
                    tableDetailContainer?.Clear();
                }
                else
                {
                    Debug.LogWarning("Selected file is not a LocalizationDatabase.");
                }

                var tmp_WorldPos = tmp_ToolbarMenuButton.worldBound.position;
                var tmp_ScreenPos = GUIUtility.GUIToScreenPoint(tmp_WorldPos);
            });
            tmp_ToolbarMenuButton.menu.AppendSeparator();

            // Save action (manual)
            tmp_ToolbarMenuButton.menu.AppendAction("Save", _data =>
                {
                    DoSave();
                },
                _action => _hasUnsavedChanges
                    ? DropdownMenuAction.Status.Normal
                    : DropdownMenuAction.Status.Disabled);
            tmp_Toolbar.Add(tmp_ToolbarMenuButton);

            tmp_ToolbarMenuButton.menu.AppendAction("Import CSV", _data =>
                {
                    if (SharedData.Instance.Table == null) return;
                    var tmp_FilePath = EditorUtility.OpenFilePanel("Select LocalizationDatabase", "Assets", "csv");
                    Utilities.ImportFromCsv(tmp_FilePath, SharedData.Instance.Table);
                    RefreshEntryList();
                },
                _action => SharedData.Instance.Table != null
                    ? DropdownMenuAction.Status.Normal
                    : DropdownMenuAction.Status.Disabled);
            tmp_Toolbar.Add(tmp_ToolbarMenuButton);


            tmp_ToolbarMenuButton.menu.AppendAction("Export CSV", _data =>
                {
                    if (SharedData.Instance.Database == null) return;
                    var tmp_Folder = EditorUtility.OpenFolderPanel("Export CSVs", "", "");
                    if (string.IsNullOrEmpty(tmp_Folder)) return;

                    foreach (var t in SharedData.Instance.Database.Tables)
                    {
                        // prefer table name; fallback to scope_platform
                        var fileName = string.IsNullOrEmpty(t.name)
                            ? $"{t.Scope}_{t.Platform}.csv"
                            : $"{t.name}.csv";
                        var path = Path.Combine(tmp_Folder, fileName);
                        Utilities.ExportToCsv(t, path);
                    }
                },
                _action => SharedData.Instance.Database != null && SharedData.Instance.Database.Tables.Count > 0
                    ? DropdownMenuAction.Status.Normal
                    : DropdownMenuAction.Status.Disabled);
            tmp_Toolbar.Add(tmp_ToolbarMenuButton);
            tmp_Toolbar.Add(new ToolbarSpacer());
            settingsButton ??= new SettingsButton(tmp_Toolbar, this);
            settingsButton.Draw();


            var tmp_Spacer = new VisualElement
            {
                style =
                {
                    flexGrow = 1
                }
            };
            tmp_Toolbar.Add(tmp_Spacer);

            aiTranslationButton ??= new AITranslationButton(tmp_Toolbar, this);
            aiTranslationButton.Draw();

            syncContentToAllTableButton ??= new SyncToOtherTableButton(tmp_Toolbar, this);
            syncContentToAllTableButton.Draw();
            _root.Add(tmp_Toolbar);

            UpdateSaveUI();
        }

        internal void RefreshTableList()
        {
            leftPane?.ReBuild();
            rightPane?.ReBuild();
            aiTranslationButton?.ReBuild();
            syncContentToAllTableButton?.ReBuild();
            PersistenceEditingDb();
            UpdateSaveUI();
        }

        internal void RefreshEntryList()
        {
            rightPane?.ReBuild();
            UpdateSaveUI();
        }

        internal void SetSelectedTable(LocalizationTable _table)
        {
            SharedData.Instance.Table = _table;
            rightPane?.ReBuild();
            aiTranslationButton?.ReBuild();
            syncContentToAllTableButton?.ReBuild();
            UpdateSaveUI();
        }

        private void UpdateSaveUI()
        {
            // Update window title and save button state based on dirty flag
            if (titleContent == null) titleContent = new GUIContent("Localization Editor");
            var baseTitle = "Localization Editor";
            titleContent.text = _hasUnsavedChanges ? baseTitle + "*" : baseTitle;
            if (_saveToolbarButton != null)
            {
                _saveToolbarButton.SetEnabled(_hasUnsavedChanges);
            }
        }

        private void DoSave()
        {
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();
            _hasUnsavedChanges = false;
            UpdateSaveUI();
            // Update snapshots to new saved state
            CaptureSnapshots();
        }

        internal static void NotifyDataChanged()
        {
            if (_WINDOW == null) return;
            _WINDOW._hasUnsavedChanges = true;
            _WINDOW.UpdateSaveUI();
        }

        private void CaptureSnapshots()
        {
            _snapshots.Clear();
            _snapshotTables.Clear();
            _snapshottedDb = SharedData.Instance.Database;
            if (_snapshottedDb == null) return;

            // Database
            _snapshots[_snapshottedDb] = EditorJsonUtility.ToJson(_snapshottedDb, true);

            // Settings (may be null)
            if (_snapshottedDb.LocalizatoinSettings != null)
            {
                _snapshots[_snapshottedDb.LocalizatoinSettings] =
                    EditorJsonUtility.ToJson(_snapshottedDb.LocalizatoinSettings, true);
            }

            // Each table
            foreach (var t in _snapshottedDb.Tables)
            {
                if (t == null) continue;
                _snapshotTables.Add(t);
                _snapshots[t] = EditorJsonUtility.ToJson(t, true);
            }
        }

        private void RevertSnapshots()
        {
            if (_snapshottedDb == null) return;

            // Remove any newly created tables not present in snapshot
            var currentTables = new List<LocalizationTable>(_snapshottedDb.Tables);
            foreach (var t in currentTables)
            {
                if (t == null) continue;
                if (!_snapshotTables.Contains(t))
                {
                    _snapshottedDb.Tables.Remove(t);
                    // Also destroy the sub-asset instance if it was created during this session
                    Object.DestroyImmediate(t, true);
                }
            }

            // Restore serialized state for tracked objects
            foreach (var kv in _snapshots)
            {
                var obj = kv.Key;
                if (obj == null) continue;
                EditorJsonUtility.FromJsonOverwrite(kv.Value, obj);
                EditorUtility.ClearDirty(obj);
            }

            _hasUnsavedChanges = false;
            UpdateSaveUI();
            // Refresh UI
            RefreshTableList();
        }
    }
}

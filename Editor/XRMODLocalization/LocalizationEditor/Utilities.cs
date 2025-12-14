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
using System.IO;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Phantom.XRMOD.Localization.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.Localization.Editor
{
    public static class Utilities
    {
        static string Escape(string s) => "\"" + s.Replace("\"", "\"\"") + "\"";

        internal static void CreateAndAttachTable(LocalizationDatabase _db, LocalizatoinSettings _asset)
        {
            // Add to main asset as sub-asset
            AssetDatabase.AddObjectToAsset(_asset, _db);
            _db.LocalizatoinSettings = _asset;
            AssetDatabase.Refresh();
        }

        internal static void AddNewKeyEntry()
        {
            foreach (var tmp_Table in SharedData.Instance.Database.Tables)
            {
                List<SystemLanguageTextPair> tmp_Pairs = new List<SystemLanguageTextPair>();
                foreach (var tmp_Language in SharedData.Instance.Database.LocalizatoinSettings.SupportLanguages)
                {
                    tmp_Pairs.Add(new SystemLanguageTextPair()
                    {
                        Language = tmp_Language,
                        Text = null
                    });
                }

                var tmp_NewKeyEntry = new LocalizationEntry {Key = "NewKey", Translations = tmp_Pairs};
                tmp_Table.Entries.Add(tmp_NewKeyEntry);
            }

            EditorUtility.SetDirty(SharedData.Instance.Database);
            LocalizationEditorWindow.NotifyDataChanged();
        }

        internal static void AddNewKeyEntry(LocalizationTable _table)
        {
            List<SystemLanguageTextPair> tmp_Pairs = new List<SystemLanguageTextPair>();
            foreach (var tmp_Language in SharedData.Instance.Database.LocalizatoinSettings.SupportLanguages)
            {
                tmp_Pairs.Add(new SystemLanguageTextPair()
                {
                    Language = tmp_Language,
                    Text = null
                });
            }

            var tmp_NewKeyEntry = new LocalizationEntry {Key = "NewKey", Translations = tmp_Pairs};
            _table.Entries.Add(tmp_NewKeyEntry);
            EditorUtility.SetDirty(SharedData.Instance.Database);
            LocalizationEditorWindow.NotifyDataChanged();
        }

        internal static void SyncAllEntries(LocalizationTable _table)
        {
            var tmp_RefTable = SharedData.Instance.Database.Tables[0];
            for (int tmp_RefId = 0; tmp_RefId < tmp_RefTable.Entries.Count; tmp_RefId++)
            {
                var tmp_Translations = new List<SystemLanguageTextPair>();
                tmp_Translations.AddRange(tmp_RefTable.Entries[tmp_RefId].Translations);
                _table.Entries.Add(new LocalizationEntry()
                {
                    Key = tmp_RefTable.Entries[tmp_RefId].Key,
                    Translations = tmp_Translations,
                });
            }

            EditorUtility.SetDirty(_table);
            LocalizationEditorWindow.NotifyDataChanged();
        }

        internal static void RemoveKeyEntry(int _id)
        {
            foreach (var tmp_Table in SharedData.Instance.Database.Tables)
            {
                tmp_Table.Entries.RemoveAt(_id);
            }

            EditorUtility.SetDirty(SharedData.Instance.Database);
            LocalizationEditorWindow.NotifyDataChanged();
        }

        internal static void SetKeyEntryLockState(int _id, bool _lockState = true)
        {
            var tmp_Entries = SharedData.Instance.Table.Entries;
            if (_id >= tmp_Entries.Count) return;
            SharedData.Instance.Table.Entries[_id].Sync = _lockState;
        }

        internal static void SyncTableEntries()
        {
            foreach (var tmp_Table in SharedData.Instance.Database.Tables)
            {
                if (tmp_Table == SharedData.Instance.Table) continue;
                for (int tmp_Idx = 0; tmp_Idx < tmp_Table.Entries.Count; tmp_Idx++)
                {
                    var tmp_Entry = SharedData.Instance.Table.Entries[tmp_Idx];
                    if (tmp_Entry.Sync || tmp_Table.Entries[tmp_Idx].Sync) continue;
                    for (int tmp_TextParId = 0; tmp_TextParId < tmp_Entry.Translations.Count; tmp_TextParId++)
                    {
                        tmp_Table.Entries[tmp_Idx].Translations[tmp_TextParId].Text =
                            tmp_Entry.Translations[tmp_TextParId].Text;
                    }
                }
            }
        }

        internal static void AddNewLanguageToAllTables()
        {
            foreach (var tmp_Table in SharedData.Instance.Database.Tables)
            {
                foreach (var tmp_Language in SharedData.Instance.Database.LocalizatoinSettings.SupportLanguages)
                {
                    foreach (var tmp_TableEntry in tmp_Table.Entries)
                    {
                        if (tmp_TableEntry.Translations.Exists(_lang => _lang.Language == tmp_Language)) continue;
                        tmp_TableEntry.Translations.Add(new SystemLanguageTextPair
                        {
                            Language = tmp_Language,
                            Text = null
                        });
                    }
                }
            }

            EditorUtility.SetDirty(SharedData.Instance.Database);
            LocalizationEditorWindow.NotifyDataChanged();
        }

        internal static void ModifyAllTableConfig()
        {
            foreach (var tmp_Table in SharedData.Instance.Database.Tables)
            {
                tmp_Table.Scope = SharedData.Instance.Database.LocalizatoinSettings.LocalizationScope;
            }
        }

        internal static void AddNewTable(LocalizationDatabase _database)
        {
            if (_database == null) return;

            var tmp_NewTable = ScriptableObject.CreateInstance<LocalizationTable>();
            tmp_NewTable.name = $"NewTable_{_database.Tables.Count}";
            tmp_NewTable.Scope = _database.Tables[0].Scope;
            tmp_NewTable.Platform = _database.Tables[0].Platform;
            AssetDatabase.AddObjectToAsset(tmp_NewTable, _database);
            SyncAllEntries(tmp_NewTable);

            _database.Tables.Add(tmp_NewTable);
            EditorUtility.SetDirty(_database);
            LocalizationEditorWindow.NotifyDataChanged();
        }

        internal static void DeleteTable(LocalizationDatabase _database, LocalizationTable _table)
        {
            if (!EditorUtility.DisplayDialog("Confirm Delete",
                    $"Are you sure you want to delete table: {_table.name}?",
                    "Delete", "Cancel")) return;
            _database.Tables.Remove(_table);
            Object.DestroyImmediate(_table, true);
            EditorUtility.SetDirty(_database);
            LocalizationEditorWindow.NotifyDataChanged();
        }


        internal static void ExportToCsv(LocalizationTable _table, string _outputPath)
        {
            if (string.IsNullOrEmpty(_outputPath)) return;

            var tmp_Languages = _table.Entries
                .SelectMany(e => e.Translations.Select(t => t.Language))
                .Distinct()
                .ToList();

            StringBuilder tmp_Sb = new();
            tmp_Sb.Append("Key");
            foreach (var tmp_Lang in tmp_Languages)
                tmp_Sb.Append($",{tmp_Lang}");
            tmp_Sb.AppendLine();

            foreach (var tmp_Entry in _table.Entries)
            {
                tmp_Sb.Append($"{tmp_Entry.Key}");
                foreach (var tmp_Lang in tmp_Languages)
                {
                    var tmp_Val = tmp_Entry.Translations.FirstOrDefault(_t => _t.Language == tmp_Lang)?.Text ?? "";
                    tmp_Sb.Append($",{Escape(tmp_Val)}");
                }

                tmp_Sb.AppendLine();
            }

            File.WriteAllText(_outputPath, tmp_Sb.ToString(), Encoding.UTF8);
        }

        internal static void ImportFromCsv(string _filePath, LocalizationTable _table)
        {
            if (!File.Exists(_filePath))
            {
                Debug.LogError($"CSV file not exist：{_filePath}");
                return;
            }

            string[] tmp_Lines = File.ReadAllLines(_filePath);
            var tmp_ParsedLines = ParseCSVUtility.ParseCsv(tmp_Lines);
            if (tmp_ParsedLines.Count < 2)
            {
                Debug.LogWarning("CSV syntax error");
                return;
            }

            string[] tmp_Headers = tmp_ParsedLines[0];

            var tmp_LangMap = new Dictionary<int, SystemLanguage>();
            for (int tmp_Idx = 0; tmp_Idx < tmp_Headers.Length; tmp_Idx++)
            {
                if (Enum.TryParse(tmp_Headers[tmp_Idx], out SystemLanguage tmp_Lang))
                {
                    tmp_LangMap[tmp_Idx] = tmp_Lang;
                }
            }

            _table.Entries.Clear();
            for (int tmp_Idx = 1; tmp_Idx < tmp_ParsedLines.Count; tmp_Idx++)
            {
                string[] tmp_Fields = tmp_ParsedLines[tmp_Idx];
                if (tmp_Fields.Length == 0 || string.IsNullOrEmpty(tmp_Fields[0])) continue;
                LocalizationEntry tmp_Entry = new LocalizationEntry()
                {
                    Key = tmp_Fields[0],
                    Translations = new List<SystemLanguageTextPair>()
                };

                foreach (KeyValuePair<int, SystemLanguage> tmp_Pair in tmp_LangMap)
                {
                    int tmp_ColIdx = tmp_Pair.Key;
                    SystemLanguage tmp_Lang = tmp_Pair.Value;
                    string tmp_Text = tmp_ColIdx < tmp_Fields.Length ? tmp_Fields[tmp_ColIdx] : "";
                    tmp_Entry.Translations.Add(new SystemLanguageTextPair()
                    {
                        Language = tmp_Lang,
                        Text = tmp_Text
                    });
                }

                _table.Entries.Add(tmp_Entry);
            }

            EditorUtility.SetDirty(_table);
            LocalizationEditorWindow.NotifyDataChanged();

            SyncTableEntries();
        }

        internal static bool IsClickBlank(object _target)
        {
            // Treat clicks inside any row item as NOT blank. Only clicks on the
            // empty area outside rows (e.g., scroll view background) are blank.
            if (_target is not VisualElement ve) return false;

            bool IsRowElement(VisualElement e)
            {
                // Check common UITK row class names for ListView/MultiColumnListView
                foreach (var cls in e.GetClasses())
                {
                    if (cls.Contains("collection-view__item") ||
                        cls.Contains("list-view__item") ||
                        cls.Contains("multi-column-list-view__row") ||
                        cls.Contains("multi-column-collection-view__row") ||
                        cls.Contains("collection-view__item--")) // includes alternative background
                    {
                        return true;
                    }
                }
                return false;
            }

            // Walk up the hierarchy; if any ancestor is a row, it's not blank
            var cur = ve;
            while (cur != null)
            {
                if (IsRowElement(cur)) return false;
                cur = cur.parent;
            }

            // No row ancestor found => consider it blank area
            return true;
        }

        internal static Texture2D SyncIconTexture => AssetDatabase.LoadAssetAtPath<Texture2D>(
            "Packages/com.phantomsxr.foundation/Editor/XRMODLocalization/Assets/SyncIcon.png");

        internal static Texture2D UnSyncIconTexture => AssetDatabase.LoadAssetAtPath<Texture2D>(
            "Packages/com.phantomsxr.foundation/Editor/XRMODLocalization/Assets/UnSyncIcon.png");

        internal static Texture2D MenuIconTexture => AssetDatabase.LoadAssetAtPath<Texture2D>(
            "Packages/com.phantomsxr.foundation/Editor/XRMODLocalization/Assets/MenuIcon.png");
    }
}

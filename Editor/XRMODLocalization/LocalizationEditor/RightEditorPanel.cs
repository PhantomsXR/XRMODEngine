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
using System.Runtime.InteropServices;
using Phantom.XRMOD.Localization.Runtime;
using UnityEditor;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.Localization.Editor
{
    public class RightEditorPanel : IEditorDraw
    {
        private MultiColumnListView tableMCLV;
        private VisualElement rightPane;
        private LocalizationEditorWindow editorWindow;
        private LocalizationTable table;

        private int currentSelectedIndex = -1;
        // Track last built language columns to avoid unnecessary column rebuilds
        private List<string> _builtLanguages = new List<string>();

        private const int _CONST_COLUMN_WIDTH = 130;
        private const int _CONST_COLUMN_HEIGHT = 30;

        private VisualElement hintLabel;

        private class TextFieldContext
        {
            public int Row;
            public LocalizationTable Table;
            public string LanguageStr; // null for Key column
        }

        public RightEditorPanel(VisualElement _rightPane, LocalizationEditorWindow _editorWindow)
        {
            this.rightPane = _rightPane;
            editorWindow = _editorWindow;
        }

        public void Draw()
        {
            table = SharedData.Instance.Table;
            OnCreateUI();
        }

        private void OnCreateUI()
        {
            tableMCLV = new MultiColumnListView
            {
                name = "Right Pane Table",
                style =
                {
                    flexGrow = 1,
                    display = DisplayStyle.None,
                },
                reorderable = false,
                selectionType = SelectionType.Single,
                showAlternatingRowBackgrounds = AlternatingRowBackground.All,
                fixedItemHeight = _CONST_COLUMN_HEIGHT + 5,
                columns =
                {
                    resizable = true,
                    stretchMode = Columns.StretchMode.Grow
                }
            };
            tableMCLV.columns.Clear();
            tableMCLV.AddManipulator(new ContextualMenuManipulator(_evt =>
            {
                _evt.menu.AppendAction("Add Column", AddColumnAction);

                _evt.menu.AppendAction(GetColumnSyncState() ? "Sync" : "UnSync", (_data) =>
                {
                    Utilities.SetKeyEntryLockState(currentSelectedIndex, !table.Entries[currentSelectedIndex].Sync);
                    editorWindow.RefreshEntryList();
                }, currentSelectedIndex == -1 ? DropdownMenuAction.Status.Disabled : DropdownMenuAction.Status.Normal);
                _evt.menu.AppendSeparator();

                _evt.menu.AppendAction("Remove Column", (_data) =>
                {
                    Utilities.RemoveKeyEntry(currentSelectedIndex);
                    editorWindow.RefreshTableList();
                }, currentSelectedIndex == -1 ? DropdownMenuAction.Status.Disabled : DropdownMenuAction.Status.Normal);
            }));
            tableMCLV.selectedIndicesChanged += TableMCLVOnselectionChanged;
            rightPane.Add(tableMCLV);


            hintLabel = new VisualElement()
            {
                style = {display = DisplayStyle.None}
            };
            hintLabel.AddToClassList("select-table");

            var tmp_HintLabel = new Label()
            {
                text = "Select a table please",
            };
            hintLabel.Add(tmp_HintLabel);

            rightPane.Add(hintLabel);

            if (table != null)
            {
                BuildColumns();
                hintLabel.style.display = DisplayStyle.None;
                tableMCLV.style.display = DisplayStyle.Flex;
            }
            else
            {
                hintLabel.style.display = DisplayStyle.Flex;
                tableMCLV.style.display = DisplayStyle.None;
            }
        }

        private void TableMCLVOnselectionChanged(IEnumerable<int> _obj)
        {
            foreach (int tmp_I in _obj)
            {
                currentSelectedIndex = tmp_I;
            }
        }


        private void BuildColumns()
        {
            // Preserve current stretch mode (user may have set Resize to fit)
            var prevStretchMode = tableMCLV.columns.stretchMode;
            tableMCLV.columns.Clear();
            if (table == null) return;
            tableMCLV.columns.Clear();


            tableMCLV.columns.Add(new Column()
            {
                title = "",
                resizable = false,
                width = 16,
                makeCell = () =>
                {
                    var tmp_Image = new Image
                    {
                        name = "MenuIcon",
                        image = Utilities.MenuIconTexture,
                        scaleMode = ScaleMode.ScaleToFit,
                        style =
                        {
                            width = 16,
                            height = 16,
                            alignSelf = Align.Center,
                            marginLeft = StyleKeyword.Auto,
                            marginRight = StyleKeyword.Auto,
                        }
                    };

                    var tmp_Container = new VisualElement
                    {
                        pickingMode = PickingMode.Ignore,
                        style =
                        {
                            flexGrow = 1,
                            flexDirection = FlexDirection.Row,
                            justifyContent = Justify.Center,
                            alignItems = Align.Center,
                        }
                    };
                    tmp_Container.Add(tmp_Image);
                    return tmp_Container;
                },
                bindCell = (_element, _i) =>
                {
                    if (table == null) return;
                    if (_i < 0 || _i >= table.Entries.Count) return;
                    _element.Q<Image>("MenuIcon").image = table.Entries[_i].Sync
                        ? Utilities.UnSyncIconTexture
                        : Utilities.SyncIconTexture;
                }
            });

            tableMCLV.RegisterCallback<MouseDownEvent>(_evt =>
            {
                if (_evt.target is not VisualElement tmp_Element) return;
                if (Utilities.IsClickBlank(tmp_Element))
                {
                    currentSelectedIndex = -1;
                    tableMCLV.ClearSelection();
                }
            });

            tableMCLV.RegisterCallback<MouseUpEvent>(_evt =>
            {
                if (_evt.target is not VisualElement tmp_Element) return;
                if (Utilities.IsClickBlank(tmp_Element))
                {
                    currentSelectedIndex = -1;
                    tableMCLV.ClearSelection();
                }
            });

            tableMCLV.columns.Add(new Column()
            {
                title = "Key",
                width = _CONST_COLUMN_WIDTH,
                resizable = false,
                makeCell = MakeKeyHeaderCell(),
                bindCell = BindKeyHeaderCell()
            });

            HashSet<string> tmp_LanguageSet = new HashSet<string>();
            foreach (var tmp_Entry in table.Entries)
            {
                foreach (var tmp_Pair in tmp_Entry.Translations)
                {
                    tmp_LanguageSet.Add(tmp_Pair.Language.ToString());
                }
            }

            // Build columns for each language
            foreach (var tmp_LangStr in tmp_LanguageSet)
            {
                var tmp_LanguageStr = tmp_LangStr;
                var tmp_Column = new Column()
                {
                    name = tmp_LanguageStr,
                    title = tmp_LanguageStr,
                    width = _CONST_COLUMN_WIDTH,
                    makeCell = MakeLanguageKeyCell(tmp_LanguageStr),
                    bindCell = BindLanguageKeyCell(tmp_LanguageStr)
                };
                tableMCLV.columns.Add(tmp_Column);
            }

            // Record built languages to detect future schema changes
            _builtLanguages = new List<string>(tmp_LanguageSet);
            _builtLanguages.Sort(StringComparer.Ordinal);

            // Restore stretch mode preference
            tableMCLV.columns.stretchMode = prevStretchMode;
        }


        private void AddColumnAction(DropdownMenuAction _obj)
        {
            Utilities.AddNewKeyEntry();
            EditorUtility.SetDirty(SharedData.Instance.Table);
            LocalizationEditorWindow.NotifyDataChanged();
            editorWindow.RefreshEntryList();
        }

        private Func<VisualElement> MakeLanguageKeyCell(string _languageStr)
        {
            return () =>
            {
                var tf = new TextField()
                {
                    name = _languageStr,
                    style = { height = _CONST_COLUMN_HEIGHT }
                };

                tf.RegisterValueChangedCallback(evt =>
                {
                    if (tf.userData is not TextFieldContext ctx) return;
                    if (ctx.Table == null) return;
                    if (ctx.Table.Entries == null) return;
                    if (ctx.Row < 0 || ctx.Row >= ctx.Table.Entries.Count) return;

                    var entry = ctx.Table.Entries[ctx.Row];
                    var translation = entry.Translations.Find(t => t.Language.ToString() == ctx.LanguageStr);
                    if (translation == null) return;
                    translation.Text = evt.newValue;
                    EditorUtility.SetDirty(ctx.Table);
                    LocalizationEditorWindow.NotifyDataChanged();
                });

                return tf;
            };
        }

        private Action<VisualElement, int> BindLanguageKeyCell(string _languageStr)
        {
            return (_ve, _i) =>
            {
                if (table == null) return;
                if (_i < 0 || _i >= table.Entries.Count) return;
                if (_ve is not TextField tf) return;

                var entry = table.Entries[_i];
                var translation = entry.Translations.Find(t => t.Language.ToString() == _languageStr);

                // Update context for this recycled element
                tf.userData = new TextFieldContext
                {
                    Row = _i,
                    Table = table,
                    LanguageStr = _languageStr
                };

                // Avoid triggering callbacks during binding
                tf.SetValueWithoutNotify(translation != null ? translation.Text : "");
            };
        }

        private Func<VisualElement> MakeKeyHeaderCell()
        {
            return () =>
            {
                var tf = new TextField()
                {
                    name = $"Key-{tableMCLV.columns.Count - 1}",
                    style = { height = _CONST_COLUMN_HEIGHT }
                };

                tf.RegisterValueChangedCallback(evt =>
                {
                    if (tf.userData is not TextFieldContext ctx) return;
                    if (SharedData.Instance?.Database?.Tables == null) return;
                    foreach (var t in SharedData.Instance.Database.Tables)
                    {
                        if (t.Entries.Count == 0) break;
                        if (ctx.Row < 0 || ctx.Row >= t.Entries.Count) continue;
                        t.Entries[ctx.Row].Key = evt.newValue;
                    }
                    EditorUtility.SetDirty(SharedData.Instance.Database);
                    LocalizationEditorWindow.NotifyDataChanged();
                });

                return tf;
            };
        }

        private Action<VisualElement, int> BindKeyHeaderCell()
        {
            return (_ve, _i) =>
            {
                if (table == null) return;
                if (_i < 0 || _i >= table.Entries.Count) return;
                if (_ve is not TextField tf) return;

                // Update context for this recycled element
                tf.userData = new TextFieldContext
                {
                    Row = _i,
                    Table = table,
                    LanguageStr = null
                };

                tf.SetValueWithoutNotify(table.Entries[_i].Key);
            };
        }

        private bool GetColumnSyncState()
        {
            if (currentSelectedIndex == -1) return true;
            if (table == null) return true;
            if (currentSelectedIndex < 0 || currentSelectedIndex >= table.Entries.Count) return true;
            return table.Entries[currentSelectedIndex].Sync;
        }

        public void ReBuild()
        {
            table = SharedData.Instance.Table;
            // Rebuild columns only if schema (language set) changed
            bool needRebuildColumns = false;
            if (table == null)
            {
                needRebuildColumns = false;
            }
            else
            {
                var newLangSet = new HashSet<string>();
                foreach (var e in table.Entries)
                {
                    foreach (var p in e.Translations)
                    {
                        newLangSet.Add(p.Language.ToString());
                    }
                }

                var newLangs = new List<string>(newLangSet);
                newLangs.Sort(StringComparer.Ordinal);

                if (_builtLanguages == null || _builtLanguages.Count != newLangs.Count)
                {
                    needRebuildColumns = true;
                }
                else
                {
                    for (int i = 0; i < newLangs.Count; i++)
                    {
                        if (!string.Equals(_builtLanguages[i], newLangs[i], StringComparison.Ordinal))
                        {
                            needRebuildColumns = true;
                            break;
                        }
                    }
                }
            }

            if (needRebuildColumns)
            {
                BuildColumns();
            }
            if (!table)
            {
                tableMCLV.columns.Clear();
                tableMCLV.Clear();
                hintLabel.style.display = DisplayStyle.Flex;
                tableMCLV.style.display = DisplayStyle.None;
                return;
            }

            tableMCLV!.itemsSource = table.Entries;
            hintLabel.style.display = DisplayStyle.None;
            tableMCLV.style.display = DisplayStyle.Flex;
            tableMCLV!.Rebuild();

            // Auto resize columns to fit content when a table is (re)selected
            AutoResizeColumnsToFitContent();
        }

        private void AutoResizeColumnsToFitContent()
        {
            if (table == null || tableMCLV == null) return;

            // Use EditorStyles to estimate text width
            var style = new GUIStyle(EditorStyles.label);
            float Measure(string s)
            {
                if (string.IsNullOrEmpty(s)) return 0f;
                return style.CalcSize(new GUIContent(s)).x;
            }

            // Precompute max widths per column
            const float padding = 28f; // account for TextField paddings and margins
            float keyMax = Measure("Key");
            var langMax = new Dictionary<string, float>(StringComparer.Ordinal);

            foreach (var e in table.Entries)
            {
                if (e == null) continue;
                keyMax = Mathf.Max(keyMax, Measure(e.Key));
                foreach (var p in e.Translations)
                {
                    var lang = p.Language.ToString();
                    var w = Measure(p.Text);
                    if (!langMax.TryGetValue(lang, out var cur) || w > cur)
                        langMax[lang] = w;
                }
            }

            // Apply widths to columns (skip the icon column)
            foreach (var col in tableMCLV.columns)
            {
                if (col == null) continue;
                // Skip the first icon column (empty title)
                if (string.IsNullOrEmpty(col.title)) continue;

                float target = 120f;
                if (string.Equals(col.title, "Key", StringComparison.Ordinal))
                {
                    target = keyMax + padding;
                }
                else if (langMax.TryGetValue(col.title, out var lw))
                {
                    // include header text width as well
                    target = Mathf.Max(lw, Measure(col.title)) + padding;
                }

                // Clamp to sane bounds
                target = Mathf.Clamp(target, 80f, 200f);
                col.width = target;
            }
        }
    }
}

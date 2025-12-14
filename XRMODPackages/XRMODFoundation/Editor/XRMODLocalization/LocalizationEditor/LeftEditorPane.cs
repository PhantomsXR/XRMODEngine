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

using System.Linq;
using Phantom.XRMOD.Localization.Runtime;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.Localization.Editor
{
    public class LeftEditorPane : IEditorDraw
    {
        private MultiColumnListView tableMCLV;
        private LocalizationDatabase database;
        private VisualElement leftPane;
        private LocalizationEditorWindow editorWindow;

        public LeftEditorPane(VisualElement _leftPane,
            LocalizationEditorWindow _editorWindow)
        {
            database = SharedData.Instance.Database;
            this.leftPane = _leftPane;
            editorWindow = _editorWindow;
        }

        public void Draw()
        {
            tableMCLV = new MultiColumnListView
            {
                name = "Left Pane Table",
                style =
                {
                    flexGrow = 1,
                },

                reorderable = false,
                selectionType = SelectionType.Single,
                showAlternatingRowBackgrounds = AlternatingRowBackground.All,
                columns =
                {
                    resizable = true,
                    stretchMode = Columns.StretchMode.GrowAndFill
                }
            };
            tableMCLV.columns.Clear();

            tableMCLV.columns.Add(new Column()
            {
                title = "Table Name",
                width = 200,
                makeCell = () =>
                {
                    var tmp_Label = new Label
                    {
                        name = "TableNameLabel",
                        style =
                        {
                            flexGrow = 1,
                            alignSelf = new StyleEnum<Align>(Align.Center),
                            unityTextAlign = new StyleEnum<TextAnchor>(TextAnchor.MiddleLeft),
                            paddingLeft = 6
                        }
                    };

                    var tmp_TextField = new TextField()
                    {
                        name = "TableNameTextField",
                        value = tmp_Label.text,
                        style =
                        {
                            flexGrow = 1,
                            display = DisplayStyle.None,
                            visibility = Visibility.Hidden,
                        }
                    };

                    var tmp_Container = new VisualElement
                    {
                        style =
                        {
                            flexGrow = 1,
                            flexDirection = FlexDirection.Row,
                            alignItems = Align.Center,
                        }
                    };


                    void CommitRename()
                    {
                        string tmp_NewValue = tmp_TextField.text.Trim();
                        if (!string.IsNullOrEmpty(tmp_NewValue))
                        {
                            tmp_Label.text = tmp_NewValue;
                            if (tmp_TextField.userData is LocalizationTable tmp_Table)
                            {
                                tmp_Table.name = tmp_NewValue;
                                EditorUtility.SetDirty(tmp_Table);
                                LocalizationEditorWindow.NotifyDataChanged();
                                editorWindow.RefreshTableList();
                            }
                        }

                        tmp_TextField.style.display = DisplayStyle.None;
                        tmp_TextField.style.visibility = Visibility.Hidden;
                        tmp_Label.style.display = DisplayStyle.Flex;
                        tmp_Label.style.visibility = Visibility.Visible;
                    }

                    tmp_TextField.RegisterCallback<FocusOutEvent>(_ => CommitRename());
                    tmp_TextField.RegisterCallback<KeyDownEvent>(evt =>
                    {
                        if (evt.keyCode == KeyCode.Return || evt.keyCode == KeyCode.KeypadEnter)
                        {
                            CommitRename();
                        }
                    });

                    tmp_Container.Add(tmp_Label);
                    tmp_Container.Add(tmp_TextField);

                    return tmp_Container;
                },
                bindCell = (_ve, i) =>
                {
                    if (database == null || database.Tables.Count == 0) return;
                    var tmp_Table = database.Tables[i];
                    _ve.AddManipulator(new ContextualMenuManipulator(_evt =>
                    {
                        _evt.menu.AppendAction("Rename", _data =>
                        {
                            var tmp_Label = _ve.Q<Label>("TableNameLabel");
                            var tmp_TextField = _ve.Q<TextField>("TableNameTextField");
                            tmp_Label.style.display = DisplayStyle.None;
                            tmp_TextField.style.display = DisplayStyle.Flex;
                            tmp_TextField.style.visibility = Visibility.Visible;
                            tmp_Label.style.visibility = Visibility.Hidden;
                            tmp_TextField.value = tmp_Label.text;
                            tmp_TextField.Focus();
                            tmp_TextField.SelectAll();
                            tmp_TextField.userData = tmp_Table;
                        });
                        _evt.menu.AppendAction("Add New Table",
                            _data =>
                            {
                                Utilities.AddNewTable(database);
                                ReBuild();
                            });
                        _evt.menu.AppendSeparator();
                        _evt.menu.AppendAction("Delete",
                            _data =>
                            {
                                Utilities.DeleteTable(database, tmp_Table);
                                ReBuild();
                            });
                    }));

                    var tmp_Label = _ve.Q<Label>("TableNameLabel");
                    if (tmp_Label == null) return;
                    tmp_Label.text = tmp_Table.name;
                    tmp_Label.userData = tmp_Table;
                }
            });


            tableMCLV.selectionChanged += _selected =>
            {
                var tmp_SelectedTable = _selected.FirstOrDefault() as LocalizationTable;
                if (tmp_SelectedTable != null)
                {
                    editorWindow.SetSelectedTable(tmp_SelectedTable);
                }
            };
            tableMCLV.AddManipulator(new ContextualMenuManipulator(_evt =>
            {
                _evt.menu.AppendAction("Add New Table",
                    _data =>
                    {
                        Utilities.AddNewTable(database);
                        ReBuild();
                    });
            }));
            leftPane.Add(tableMCLV);
        }

        public void ReBuild()
        {
            tableMCLV.ClearSelection();
            database = SharedData.Instance.Database;
            if (database != null && database.Tables.Count > 0)
            {
                tableMCLV.itemsSource = database.Tables;
                tableMCLV.Rebuild();
                tableMCLV.focusable = true;
            }
        }
    }
}

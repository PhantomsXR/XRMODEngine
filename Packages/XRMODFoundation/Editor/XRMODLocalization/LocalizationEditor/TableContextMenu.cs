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

using Phantom.XRMOD.Localization.Runtime;
using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.Localization.Editor
{
    public class TableContextMenu
    {
        private LocalizationTable table;
        private LocalizationDatabase database;
        private LocalizationEditorWindow editorWindow;

        public TableContextMenu(LocalizationTable _table, LocalizationDatabase _database,
            LocalizationEditorWindow _editorWindow)
        {
            table = _table;
            database = _database;
            editorWindow = _editorWindow;
        }

        internal void Draw()
        {
            var tmp_Menu = new GenericMenu();

            tmp_Menu.AddItem(new GUIContent($"Delete '{table.name}'"), false, () =>
            {
                if (!EditorUtility.DisplayDialog("Confirm Delete",
                        $"Are you sure you want to delete table: {table.name}?",
                        "Delete", "Cancel")) return;
                database.Tables.Remove(table);
                Object.DestroyImmediate(table, true);
                EditorUtility.SetDirty(database);
                LocalizationEditorWindow.NotifyDataChanged();

                editorWindow.RefreshTableList();
            });

            // 计算右键点击位置
            if (Event.current == null) return;
            Vector2 tmp_MousePos = GUIUtility.GUIToScreenPoint(Event.current.mousePosition);
            tmp_Menu.DropDown(new Rect(tmp_MousePos, Vector2.zero));
        }
    }
}

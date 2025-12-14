// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the XR-MOD SDK.
// 
// The XR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact nswell@phantomsxr.com for licensing requests.
// ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class ContentView : VisualElement
    {
        public static ContentTreeRenderer TreeRenderer;
        private readonly List<MultiColumnHeaderState.Column> nameColumnList = new();

        public new class UxmlFactory : UxmlFactory<ContentView, VisualElement.UxmlTraits>
        {
        }


        public ContentView()
        {
            BuildTreeView();
            DrawContentList();
        }


        internal void DrawContentList()
        {
            IMGUIContainer tmp_IMGUIContainer = new IMGUIContainer(() =>
            {
                var tmp_Rect = EditorGUILayout.GetControlRect(false, layout.height);
                TreeRenderer.OnGUI(tmp_Rect);
            });

            Add(tmp_IMGUIContainer);
            AddToClassList("full-vertical-view");
            tmp_IMGUIContainer.AddToClassList("full-vertical-view");
        }

        private void BuildTreeView()
        {
            var tmp_IconColumn = new MultiColumnHeaderState.Column()
            {
                headerContent = new GUIContent(EditorGUIUtility.FindTexture("AlphabeticalSorting"), ""),
                contextMenuText = "AssetType",
                headerTextAlignment = TextAlignment.Left,
                sortedAscending = true,
                sortingArrowAlignment = TextAlignment.Right,
                width = 30,
                minWidth = 30,
                maxWidth = 30,
                autoResize = false,
                allowToggleVisibility = true,
                canSort = false,
            };

            var tmp_NameColumn = new MultiColumnHeaderState.Column()
            {
                headerContent = new GUIContent("Asset Name"),
                headerTextAlignment = TextAlignment.Left,
                sortedAscending = true,
                sortingArrowAlignment = TextAlignment.Right,
                width = 200,
                minWidth = 60,
                autoResize = false,
                allowToggleVisibility = false,
                canSort = false
            };

            var tmp_FullPathColumn = new MultiColumnHeaderState.Column()
            {
                headerContent = new GUIContent("Asset Path"),
                headerTextAlignment = TextAlignment.Left,
                sortedAscending = false,
                sortingArrowAlignment = TextAlignment.Left,
                width = 1000,
                minWidth = 60,
                autoResize = true
            };

            nameColumnList.Add(tmp_IconColumn);
            nameColumnList.Add(tmp_NameColumn);
            nameColumnList.Add(tmp_FullPathColumn);

            var tmp_HeaderState = new MultiColumnHeaderState(nameColumnList.ToArray());

            var tmp_MultiColumnHeader = new MultiColumnHeader(tmp_HeaderState);
            tmp_MultiColumnHeader.sortingChanged += _header =>
            {
                var tmp_DetailCacheData = PackageToolsEditor.ALL_PROJECT_CACHE.GetEditingProjectData().DetailCacheData;

                foreach (var group in tmp_DetailCacheData.Groups)
                {
                    switch (_header.sortedColumnIndex)
                    {
                        // Sort with AssetType
                        case 0 when _header.IsSortedAscending(0):
                            group.Assets.Sort((_a, _b) =>
                            {
                                int tmp_TypeComparison = string.Compare(_a.Type.Split(".").Last(),
                                    _b.Type.Split(".").Last(),
                                    StringComparison.Ordinal);
                                return tmp_TypeComparison != 0
                                    ? tmp_TypeComparison // Type不同，直接用Type的比较结果
                                    : string.Compare(_a.DisplayName, _b.DisplayName,
                                        StringComparison.Ordinal); // Type相同，再比较AssetPathInUnity
                            });

                            break;

                        case 0:
                            group.Assets.Sort((_a, _b) =>
                            {
                                int tmp_TypeComparison = string.Compare(_a.Type.Split(".").Last(),
                                    _b.Type.Split(".").Last(),
                                    StringComparison.Ordinal);
                                return tmp_TypeComparison != 0
                                    ? tmp_TypeComparison // Type不同，直接用Type的比较结果
                                    : string.Compare(_b.DisplayName, _a.DisplayName,
                                        StringComparison.Ordinal); // Type相同，再比较AssetPathInUnity
                            });
                            break;
                    }
                }


                int tmp_StartId = 0;
                foreach (var group in tmp_DetailCacheData.Groups)
                {
                    group.Id = tmp_StartId++;
                    foreach (var asset in group.Assets)
                    {
                        asset.Id = tmp_StartId++;
                    }
                }

                TreeRenderer.Reload();
                TreeRenderer.Repaint();
            };
#if UNITY_6000_1_OR_NEWER
            var tmp_TreeViewState = new TreeViewState<int>();
#else
            var tmp_TreeViewState = new TreeViewState();
#endif
            TreeRenderer =
                new ContentTreeRenderer(tmp_TreeViewState, tmp_MultiColumnHeader, PackageToolsEditor.ALL_PROJECT_CACHE);
            ReBuildContentsType();
            TreeRenderer.Reload();
        }

        private void ReBuildContentsType()
        {
            var tmp_Groups = PackageToolsEditor.ALL_PROJECT_CACHE.GetEditingProjectData().DetailCacheData
                .Groups;
            if (tmp_Groups == null) return;
            
            foreach (var group in tmp_Groups)
            {
                foreach (ContentModel tmp_ContentModel in group.Assets)
                {
                    var tmp_ContentObj = AssetDatabase.LoadAssetAtPath(tmp_ContentModel.AssetPathInUnity, typeof(object));
                    if (tmp_ContentObj != null)
                    {
                        if (!EditorUtility.IsPersistent(tmp_ContentObj)) continue;
                        // 传入进来的是Object，用GetType会把Sprite认为是Texture2D导致类型拿错。
                        string tmp_TypeName = tmp_ContentObj.GetType().FullName;
                        var tmp_Assets = AssetDatabase.LoadAllAssetRepresentationsAtPath(tmp_ContentModel.AssetPathInUnity);
                        foreach (var tmp_Asset in tmp_Assets)
                        {
                            if (tmp_Asset is not Sprite) continue;
                            tmp_TypeName = typeof(Sprite).FullName;
                        }

                        tmp_ContentModel.Type = tmp_TypeName;
                    }
                    else
                    {
                        Debug.LogWarning($"Content not found: {tmp_ContentModel.AssetPathInUnity}");
                    }
                }
            }
        }
    }
}
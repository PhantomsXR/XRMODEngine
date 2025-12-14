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
using System.IO;
using System.Linq;
using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
#if UNITY_6000_1_OR_NEWER
    public class ContentTreeRenderer : TreeView<int>
#else
    public class ContentTreeRenderer : TreeView
#endif

    {
        private const float _CONST_CONST_ROW_HEIGHTS = 20f;
        public Action AddedNewElement;
        public Action RemovedElement;
        public readonly bool CanDragAndDrop = true;

        private readonly AllProjectsCache allProjectsCache;
        private ProjectCacheData projectCacheData;
        private List<GroupModel> groups;

        enum ColumnsType
        {
            Icon1,
            Name,
            AssetPath,
        }

#if UNITY_6000_1_OR_NEWER
        public ContentTreeRenderer(TreeViewState<int> _state) : base(_state)
        {
        }
#else
        public ContentTreeRenderer(TreeViewState _state) : base(_state)
        {
        }
#endif


#if UNITY_6000_1_OR_NEWER
        public ContentTreeRenderer(TreeViewState<int> _state, MultiColumnHeader _multiColumnHeader,
            AllProjectsCache _allProjectsCache) :
            base(_state, _multiColumnHeader)
#else
        public ContentTreeRenderer(TreeViewState _state, MultiColumnHeader _multiColumnHeader,
            AllProjectsCache _allProjectsCache) :
            base(_state, _multiColumnHeader)
#endif


        {
            allProjectsCache = _allProjectsCache;
            showBorder = true;
            rowHeight = _CONST_CONST_ROW_HEIGHTS;
            showAlternatingRowBackgrounds = true;
            customFoldoutYOffset = (_CONST_CONST_ROW_HEIGHTS - EditorGUIUtility.singleLineHeight) * 0.5f;
            UpdateContentList();
            EditorNotificationCenter.Center.AddObserver(_ =>
            {
                UpdateContentList();
                Reload();
            }, nameof(EditingProjectCommand));
        }

        private void UpdateContentList()
        {
            projectCacheData = allProjectsCache.GetEditingProjectData();
            if (projectCacheData)
            {
                groups = projectCacheData.DetailCacheData.Groups ?? new List<GroupModel>();
                //Fix Asset's path
                projectCacheData.DetailCacheData.ChangeAssetsPath(projectCacheData.Project.DisplayName);
                ReupdateContentId();
            }
            else
                groups = new List<GroupModel>();
        }
#if UNITY_6000_1_OR_NEWER
        protected override TreeViewItem<int> BuildRoot()
        {
            var tmp_Root = new TreeViewItem<int>
            {
                id = -1, depth = -1, displayName = "Root",
                children = new List<TreeViewItem<int>>()
            };
#else
        protected override TreeViewItem BuildRoot()
        {
            var tmp_Root = new TreeViewItem
            {
                id = -1, depth = -1, displayName = "Root",
                children = new List<TreeViewItem>()
            };
#endif

            foreach (var tmp_Group in groups)
            {
                if (tmp_Group == null) continue;
                var tmp_GroupTreeView = CreateGroupTreeViewItem(tmp_Group);
                tmp_Root.AddChild(tmp_GroupTreeView);
                
                if (tmp_Group.Assets == null) continue;
                foreach (var tmp_Asset in tmp_Group.Assets)
                {
                    if (tmp_Asset == null) continue;
                    var tmp_AssetTreeViewItem = CreateContentTreeViewItem(tmp_Asset);
                    tmp_GroupTreeView.AddChild(tmp_AssetTreeViewItem);
                }
            }

            SetupDepthsFromParentsAndChildren(tmp_Root);

            return tmp_Root;
        }

        protected override void RowGUI(RowGUIArgs _args)
        {
            if (_args.item is GroupTreeViewItem tmp_GroupTreeViewItem)
            {
                var tmp_CellRect = _args.GetCellRect(1);
                CenterRectUsingSingleLineHeight(ref tmp_CellRect);
                var tmp_ColumnIndex = _args.GetColumn(1);

                switch ((ColumnsType) tmp_ColumnIndex)
                {
                    case ColumnsType.Icon1:
                        EditorGUI.LabelField(tmp_CellRect,
                            new GUIContent(EditorGUIUtility.FindTexture("d_GameObject Icon"), ""));
                        break;
                    case ColumnsType.Name:
                        EditorGUI.LabelField(tmp_CellRect, tmp_GroupTreeViewItem.displayName);
                        break;
                    case ColumnsType.AssetPath:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
            else if (_args.item is ContentTreeViewItem tmp_ContentTreeViewItem)
            {
                for (int tmp_Idx = 0; tmp_Idx < _args.GetNumVisibleColumns(); ++tmp_Idx)
                {
                    var tmp_CellRect = _args.GetCellRect(tmp_Idx);
                    CenterRectUsingSingleLineHeight(ref tmp_CellRect);
                    var tmp_ColumnIndex = _args.GetColumn(tmp_Idx);
                    Object tmp_Asset = AssetDatabase.LoadAssetAtPath(
                        tmp_ContentTreeViewItem.ContentModel.AssetPathInUnity,
                        typeof(object));

                    tmp_CellRect.xMin += GetContentIndent(_args.item);

                    switch ((ColumnsType) tmp_ColumnIndex)
                    {
                        case ColumnsType.Icon1:
                            if (tmp_Asset)
                            {
                                Texture tmp_Icon = EditorGUIUtility.ObjectContent(tmp_Asset, tmp_Asset.GetType())
                                    .image;
                                Rect tmp_IconRect = new Rect(tmp_CellRect.x + 6, tmp_CellRect.y + 3, 12, 12);
                                GUI.DrawTexture(tmp_IconRect, tmp_Icon, ScaleMode.ScaleToFit);
                            }
                            else
                            {
                                Texture tmp_Icon = EditorGUIUtility.FindTexture("console.erroricon.sml");
                                Rect tmp_IconRect = new Rect(tmp_CellRect.x + 6, tmp_CellRect.y + 3, 12, 12);
                                GUI.DrawTexture(tmp_IconRect, tmp_Icon, ScaleMode.ScaleToFit);
                            }

                            break;
                        case ColumnsType.Name:
                            if (tmp_Asset == null)
                            {
                                EditorGUI.DrawRect(tmp_CellRect, new Color(1f, 0f, 0f));
                            }

                            EditorGUI.LabelField(tmp_CellRect,
                                tmp_Asset == null
                                    ? $"{_args.item.displayName}(Asset Missing)"
                                    : _args.item.displayName);
                            break;
                        case ColumnsType.AssetPath:
                            EditorGUI.LabelField(tmp_CellRect,
                                tmp_ContentTreeViewItem.ContentModel.AssetPathInUnity);

                            break;
                    }
                }
            }
        }

#if UNITY_6000_1_OR_NEWER
        TreeViewItem<int> CreateContentTreeViewItem(ContentModel _model)

#else
        TreeViewItem CreateContentTreeViewItem(ContentModel _model)
#endif
        {
            return new ContentTreeViewItem
            {
                id = _model.Id,
                displayName = _model.DisplayName,
                depth = 1,
                ContentModel = _model
            };
        }

#if UNITY_6000_1_OR_NEWER
        TreeViewItem<int> CreateGroupTreeViewItem(GroupModel _model)
#else
        TreeViewItem CreateGroupTreeViewItem(GroupModel _model)
#endif
        {
            return new GroupTreeViewItem()
            {
                id = _model.Id,
                displayName = _model.DisplayName,
                depth = 0
            };
        }

        protected override void ContextClickedItem(int _id)
        {
            base.ContextClickedItem(_id);
            
            GroupModel tmp_Group = null;
            ContentModel tmp_Asset = null;

            foreach (var g in groups)
            {
                if (g.Id == _id)
                {
                    tmp_Group = g;
                    break;
                }
                var asset = g.Assets.FirstOrDefault(a => a.Id == _id);
                if (asset != null)
                {
                    tmp_Asset = asset;
                    tmp_Group = g; // Parent group
                    break;
                }
            }

            GenericMenu tmp_Menu = new GenericMenu();
            if (tmp_Asset != null)
            {
                tmp_Menu.AddItem(new GUIContent("Ping Object"), false, () =>
                {
                    var tmp_Object = AssetDatabase.LoadAssetAtPath(tmp_Asset.AssetPathInUnity, typeof(Object));
                    EditorGUIUtility.PingObject(tmp_Object);
                });

                tmp_Menu.AddItem(new GUIContent("Short Name"), false, () =>
                {
                    tmp_Asset.DisplayName = Path.GetFileNameWithoutExtension(tmp_Asset.DisplayName);
                    RenameEnded(new RenameEndedArgs
                    {
                        newName = Path.GetFileNameWithoutExtension(tmp_Asset.DisplayName), itemID = tmp_Asset.Id,
                        acceptedRename = true
                    });
                });

                tmp_Menu.AddItem(new GUIContent("Rename"), false, () =>
                {
                    if (BeginRename(FindItem(_id, rootItem)))
                    {
                        Reload();
                    }
                });
                tmp_Menu.AddSeparator("");
            }
            else if (tmp_Group != null)
            {
                 tmp_Menu.AddItem(new GUIContent("Rename"), false, () =>
                {
                    if (BeginRename(FindItem(_id, rootItem)))
                    {
                        Reload();
                    }
                });
                tmp_Menu.AddSeparator("");
            }

            GenericCreateProjectMenu(tmp_Menu);
            tmp_Menu.AddSeparator("");
            tmp_Menu.AddItem(new GUIContent("Remove"), false, () =>
            {
                var tmp_ElementIDs = GetSelection();
                
                // Simple removal logic: find what to remove
                List<GroupModel> groupsToRemove = new List<GroupModel>();
                List<ContentModel> assetsToRemove = new List<ContentModel>();

                foreach (var id in tmp_ElementIDs)
                {
                    var g = groups.FirstOrDefault(x => x.Id == id);
                    if (g != null)
                    {
                        groupsToRemove.Add(g);
                        continue;
                    }

                    foreach (var group in groups)
                    {
                        var a = group.Assets.FirstOrDefault(x => x.Id == id);
                        if (a != null)
                        {
                            assetsToRemove.Add(a);
                            break;
                        }
                    }
                }

                if (groupsToRemove.Count > 0)
                {
                    string tmp_Title = groupsToRemove.Count == 1 ? "Remove Group" : "Remove Groups";
                    string tmp_Message = groupsToRemove.Count == 1
                        ? $"Remove group '{groupsToRemove[0].DisplayName}' and all its assets?"
                        : $"Remove {groupsToRemove.Count} selected groups and all their assets?";

                    bool tmp_Confirmed = EditorUtility.DisplayDialog(tmp_Title, tmp_Message, "Remove", "Cancel");
                    if (!tmp_Confirmed) return;

                    foreach (var g in groupsToRemove)
                    {
                        groups.Remove(g);
                    }
                }
                
                // Remove individual assets (if their group wasn't already removed)
                foreach (var a in assetsToRemove)
                {
                    // Find parent group again to be safe
                    foreach (var group in groups)
                    {
                        if (group.Assets.Contains(a))
                        {
                            group.Assets.Remove(a);
                            break;
                        }
                    }
                }

                RemovedElement?.Invoke();

                ReupdateContentId();
                Reload();
            });
            tmp_Menu.ShowAsContext();
            Event.current.Use();
        }

        protected override void ContextClicked()
        {
            base.ContextClicked();
            if (EditorApplication.isCompiling) return;
            GenericMenu tmp_Menu = new GenericMenu();
            GenericCreateProjectMenu(tmp_Menu);
            tmp_Menu.ShowAsContext();
            Event.current.Use();
        }

        private void GenericCreateProjectMenu(GenericMenu _menu)
        {
            _menu.AddItem(new GUIContent("Create Group"), false,
                () =>
                {
                    groups.Add(new GroupModel()
                    {
                        Id = GenerateContentIndex,
                        DisplayName = "Group",
                        GroupName = "Group",
                        ItemType = ItemType.GroupSection,
                        Assets = new List<ContentModel>()
                    });
                    EditorUtility.SetDirty(projectCacheData);
                    Reload();
                });
        }

        /// <summary>
        ///  重新更新列表ID
        /// </summary>
        private void ReupdateContentId()
        {
            // 重新更新ID
            int tmp_StartId = 0;
            foreach (var group in groups)
            {
                group.Id = tmp_StartId++;
                foreach (var asset in group.Assets)
                {
                    asset.Id = tmp_StartId++;
                }
            }
        }

        public override void OnGUI(Rect _rect)
        {
            base.OnGUI(_rect);
        }

        protected override bool CanStartDrag(CanStartDragArgs _args)
        {
            if (_args.draggedItem is ContentTreeViewItem)
                return true;
            return false;
        }


        protected override void SetupDragAndDrop(SetupDragAndDropArgs _args)
        {
            DragAndDrop.PrepareStartDrag();
            var tmp_SortedDraggedIDs = SortItemIDsInRowOrder(_args.draggedItemIDs);
            DragAndDrop.paths = null;
            DragAndDrop.objectReferences = null;
            DragAndDrop.SetGenericData("ContentTreeRenderer", tmp_SortedDraggedIDs);
            DragAndDrop.StartDrag("ContentTreeRenderer");
        }

        protected override DragAndDropVisualMode HandleDragAndDrop(DragAndDropArgs _args)
        {
            if (!CanDragAndDrop)
                return DragAndDropVisualMode.None;

            // ----------------------------
            //  Internal Drag and Drop
            // ----------------------------
            var tmp_DraggedIDs = DragAndDrop.GetGenericData("ContentTreeRenderer") as List<int>;
            if (tmp_DraggedIDs != null && tmp_DraggedIDs.Count > 0)
            {
                // Valid Drop Target: Group or Asset (which implies its parent Group)
                GroupModel tmp_TargetGroup = null;
                if (_args.parentItem is GroupTreeViewItem)
                {
                    tmp_TargetGroup = groups.FirstOrDefault(g => g.Id == _args.parentItem.id);
                }
                else if (_args.parentItem is ContentTreeViewItem)
                {
                    // Find the group that contains this asset
                    foreach (var g in groups)
                    {
                        if (g.Assets.Any(a => a.Id == _args.parentItem.id))
                        {
                            tmp_TargetGroup = g;
                            break;
                        }
                    }
                }

                if (tmp_TargetGroup == null)
                    return DragAndDropVisualMode.Rejected;

                if (!_args.performDrop)
                    return DragAndDropVisualMode.Move;

                // Perform Drop
                bool tmp_Changed = false;
                foreach (var tmp_Id in tmp_DraggedIDs)
                {
                    // Find source group and asset
                    GroupModel tmp_SourceGroup = null;
                    ContentModel tmp_AssetToMove = null;

                    foreach (var g in groups)
                    {
                        var a = g.Assets.FirstOrDefault(x => x.Id == tmp_Id);
                        if (a != null)
                        {
                            tmp_SourceGroup = g;
                            tmp_AssetToMove = a;
                            break;
                        }
                    }

                    if (tmp_SourceGroup != null && tmp_AssetToMove != null && tmp_SourceGroup != tmp_TargetGroup)
                    {
                        // Check if already exists in target
                        if (!tmp_TargetGroup.Assets.Any(a => a.DisplayName == tmp_AssetToMove.DisplayName))
                        {
                            tmp_SourceGroup.Assets.Remove(tmp_AssetToMove);
                            tmp_AssetToMove.GroupName = tmp_TargetGroup.DisplayName;
                            tmp_TargetGroup.Assets.Add(tmp_AssetToMove);
                            tmp_Changed = true;
                        }
                    }
                }

                if (tmp_Changed)
                {
                    ReupdateContentId();
                    Reload();
                    // Notify change if needed, e.g. AddedNewElement?.Invoke(); or just ensure data is saved
                    EditorUtility.SetDirty(projectCacheData); 
                }

                return DragAndDropVisualMode.Move;
            }

            // ----------------------------
            //  From Project Drag Asset
            // ----------------------------

            if (!_args.performDrop)
            {
                // Only allow linking when hovering over a valid group item
                if (_args.parentItem is GroupTreeViewItem)
                    return DragAndDropVisualMode.Link;
                return DragAndDropVisualMode.Rejected;
            }

            DragAndDrop.visualMode = DragAndDropVisualMode.Link;
            DragAndDrop.AcceptDrag();

            // Must drop onto a group item
            if (_args.parentItem == null || !(_args.parentItem is GroupTreeViewItem))
            {
                EditorUtility.DisplayDialog("Add Asset Failed", "You must put the asset into the group.",
                    "Ok");
                return DragAndDropVisualMode.Rejected;
            }

            bool tmp_AddedSuccessed = false;
            var targetGroup = groups.FirstOrDefault(g => g.Id == _args.parentItem.id);
            if (targetGroup == null) return DragAndDropVisualMode.Rejected;

            foreach (Object tmp_DraggedObject in DragAndDrop.objectReferences)
            {
                if (tmp_DraggedObject is DefaultAsset)
                    continue;

                string tmp_AssetPath = AssetDatabase.GetAssetPath(tmp_DraggedObject);

                // Check if exists in this group
                var tmp_Exists = targetGroup.Assets.Exists(_c => _c.DisplayName == tmp_DraggedObject.name);
                if (tmp_Exists)
                {
                    EditorUtility.DisplayDialog("Already In Package Error",
                        $"The '{tmp_DraggedObject.name}' asset is already in this Group. Do not add it repeatedly", "OK");
                    break;
                }

                string tmp_TypeName = tmp_DraggedObject.GetType().FullName;

                if (tmp_DraggedObject.GetType() != typeof(SceneAsset))
                {
                    // 修正 Sprite 类型识别
                    var tmp_Assets = AssetDatabase.LoadAllAssetsAtPath(tmp_AssetPath);
                    foreach (var tmp_Asset in tmp_Assets)
                    {
                        if (tmp_Asset is Sprite)
                        {
                            tmp_TypeName = typeof(Sprite).FullName;
                            break;
                        }
                    }
                }

                var tmp_Content = new ContentModel
                {
                    Id = 0, // Will be updated
                    GroupName = targetGroup.DisplayName,
                    DisplayName = tmp_DraggedObject.name,
                    ItemType = ItemType.AssetSection,
                    AssetPathInUnity = tmp_AssetPath,
                    Type = tmp_TypeName
                };
                targetGroup.Assets.Add(tmp_Content);

                AddedNewElement?.Invoke();
                tmp_AddedSuccessed = true;
            }

            if (!tmp_AddedSuccessed)
                return DragAndDropVisualMode.Generic;

            ReupdateContentId();
            Reload();

            return DragAndDropVisualMode.Generic;
        }

        protected override void RenameEnded(RenameEndedArgs _args)
        {
            base.RenameEnded(_args);
            if (!_args.acceptedRename) return;
            
            foreach (var tmp_Group in groups)
            {
                if (tmp_Group.Id == _args.itemID)
                {
                    tmp_Group.DisplayName = _args.newName;
                    tmp_Group.GroupName = _args.newName;
                    // Update all assets in this group to have new group name? 
                    // Usually yes, but ContentModel.GroupName might be redundant if nested. 
                    // Keeping it for compatibility.
                    foreach(var tmp_Asset in tmp_Group.Assets)
                    {
                        tmp_Asset.GroupName = _args.newName;
                    }
                    break;
                }
                
                var tmp_DefaultAssset = tmp_Group.Assets.FirstOrDefault(a => a.Id == _args.itemID);
                if (tmp_DefaultAssset != null)
                {
                    tmp_DefaultAssset.DisplayName = _args.newName;
                    break;
                }
            }

            Reload();
        }
#if UNITY_6000_1_OR_NEWER
        protected override bool CanRename(TreeViewItem<int> _item)

#else
        protected override bool CanRename(TreeViewItem item)
#endif
        {
            return true;
        }

        /// <summary>
        /// Generate the content item index id。
        /// Avoid drag-and-drop new object to contents view after the item is removed to generate the wrong id
        /// </summary>
        private int GenerateContentIndex 
        {
            get 
            {
                int maxId = 0;
                foreach(var g in groups)
                {
                    if (g.Id > maxId) maxId = g.Id;
                    foreach(var a in g.Assets)
                    {
                        if (a.Id > maxId) maxId = a.Id;
                    }
                }
                return maxId + 1;
            }
        }
    }
}

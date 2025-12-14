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
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    [System.Serializable]
    public class ProjectDetailCacheData
    {
        public int Id;
        public Configures Configures;
        public BuildSettingData BuildSettingData; 
        [HideInInspector]public List<ContentModel> Contents;
        public List<GroupModel> Groups = new List<GroupModel>();
        [SerializeField] private List<string> Blocks;
        public string SubPath = string.Empty;
        public List<string> GetBlock => Blocks;

        public string GetProjectPath()
        {
            return $"{Application.dataPath.Replace("/Assets", "")}/{SubPath}";
        }


        public void AddContentElement(ContentModel _content)
        {
            if (Groups.Count == 0)
            {
                Groups.Add(new GroupModel
                {
                    Id = 0,
                    DisplayName = "Default Group",
                    GroupName = "Default Group",
                    ItemType = ItemType.GroupSection,
                    Assets = new List<ContentModel>()
                });
            }

            var tmp_Group = Groups.Find(_g => _g.GroupName == _content.GroupName);
            if (tmp_Group == null)
            {
                tmp_Group = new GroupModel
                {
                    Id = Groups.Count,
                    DisplayName = _content.GroupName,
                    GroupName = _content.GroupName,
                    ItemType = ItemType.GroupSection,
                    Assets = new List<ContentModel>()
                };
                Groups.Add(tmp_Group);
            }

            if (tmp_Group.Assets.Contains(_content)) return;
            tmp_Group.Assets.Add(_content);
        }

        public void RemoveContentElement(ContentModel _content)
        {
            foreach (var tmp_Group in Groups)
            {
                if (tmp_Group.Assets.Contains(_content))
                {
                    tmp_Group.Assets.Remove(_content);
                    return;
                }
            }
        }


        public ContentModel ContentFind(int _id)
        {
            foreach (var tmp_Group in Groups)
            {
                var tmp_Content = tmp_Group.Assets.FirstOrDefault(_element => _element.Id == _id);
                if (tmp_Content != null) return tmp_Content;
            }

            return null;
        }


        public void CheckAndMigrate()
        {
            if (Contents != null && Contents.Count > 0 && (Groups == null || Groups.Count == 0))
            {
                Groups ??= new List<GroupModel>();

                // Migration
                foreach (var tmp_Content in Contents)
                {
                    if (tmp_Content.ItemType == ItemType.GroupSection)
                    {
                        var tmp_Group = Groups.Find(_g => _g.GroupName == tmp_Content.GroupName);
                        if (tmp_Group != null)
                        {
                            tmp_Group.DisplayName = tmp_Content.DisplayName;
                            continue;
                        }
                        
                        Groups.Add(new GroupModel
                        {
                            Id = Groups.Count,
                            DisplayName = tmp_Content.DisplayName,
                            GroupName = tmp_Content.GroupName,
                            ItemType = ItemType.GroupSection,
                            Assets = new List<ContentModel>()
                        });
                    }
                    else
                    {
                        var tmp_Group = Groups.Find(_g => _g.GroupName == tmp_Content.GroupName);
                        if (tmp_Group == null)
                        {
                            tmp_Group = new GroupModel
                            {
                                Id = Groups.Count,
                                DisplayName = tmp_Content.GroupName,
                                GroupName = tmp_Content.GroupName,
                                ItemType = ItemType.GroupSection,
                                Assets = new List<ContentModel>()
                            };
                            Groups.Add(tmp_Group);
                        }

                        tmp_Group.Assets.Add(tmp_Content);
                    }
                }

                Contents.Clear();
            }
        }

        public void ChangeAssetsPath(string _projectName)
        {
            CheckAndMigrate();

            foreach (var tmp_Group in Groups)
            {
                foreach (ContentModel tmp_Content in tmp_Group.Assets)
                {
                    var tmp_Obj = AssetDatabase.LoadAssetAtPath<Object>(tmp_Content.AssetPathInUnity);
                    if (tmp_Obj) continue;
                    var tmp_Idx = tmp_Content.AssetPathInUnity.IndexOf(_projectName, StringComparison.Ordinal);
                    if (tmp_Idx == -1) continue;
                    int tmp_StartIdx = _projectName.Length + tmp_Idx + 1;
                    var tmp_TempPath =
                        tmp_Content.AssetPathInUnity.Substring(tmp_StartIdx,
                            tmp_Content.AssetPathInUnity.Length - tmp_StartIdx);
                    tmp_Content.AssetPathInUnity = Path.Combine(SubPath, tmp_TempPath);
                }
            }
        }

        public void AddBlockElement(string _element)
        {
            Blocks.Add(_element);
        }

        public void RemoveBlockElement(string _element)
        {
            Blocks.Remove(_element);
        }

        public void RemoveBlockElement(int _idx)
        {
            Blocks.RemoveAt(_idx);
        }


        public ContentModel Find(int _id)
        {
            return Contents.Find(_item => _item.Id == _id);
        }
    }

    [System.Serializable]
    public struct SerializableKeyValuePair
    {
        // Key：对应原 Dictionary 的 string 键
        public string Key;

        // Value：对应原 Dictionary 的 List<ContentModel> 值
        public List<ContentModel> Value;
    }
}
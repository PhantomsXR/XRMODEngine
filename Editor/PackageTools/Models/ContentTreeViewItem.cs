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

using UnityEditor.IMGUI.Controls;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
#if UNITY_6000_1_OR_NEWER
    public class ContentTreeViewItem : TreeViewItem<int>
    {
        public ContentModel ContentModel { get; set; }
    }

    public class GroupTreeViewItem : TreeViewItem<int>
    {
    }
#else
    public class ContentTreeViewItem : TreeViewItem
    {
        public ContentModel ContentModel { get; set; }
    }

    public class GroupTreeViewItem : TreeViewItem
    {
    }
#endif

    public enum ItemType
    {
        GroupSection,
        AssetSection,
    }
}
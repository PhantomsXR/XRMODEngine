// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Nin1.FriendsSystem.Runtime.
// //
// // The Nin1 cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using Unity.Services.Friends.Models;
using UnityEngine;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public class RelationshipsViewDataOnly : IRelationshipsView
    {
        public ILocalPlayerView LocalPlayerView { get; set; }
        public IRelationshipBarView RelationshipBarView { get; set; }
        public IAddFriendView AddFriendView { get; set; }
        public IFriendsListView FriendsListView { get; set; }
        public IRequestListView RequestListView { get; set; }
        public IBlockedListView BlockListView { get; set; }

        public void Init()
        {
            LocalPlayerView = new LocalPlayerView();
            RelationshipBarView = new RelationshipBarView();
            AddFriendView = new AddFriendView();
            FriendsListView = new FriendsListView();
            RequestListView = new RequestListView();
            BlockListView = new BlockedListView();
        }
    }
}
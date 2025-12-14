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
using Newtonsoft.Json;
using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEngine;
using UnityEngine.Serialization;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public class FriendsListView : IFriendsListView
    {
        [System.Serializable]
        public class FriendList
        {
            public List<FriendsEntryData> FriendsEntryData = new();
        }

        private FriendList friendList  = new();

        public void Show()
        {
          
        }

        private void PostFriendListData()
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(NotificationActionEnum.ShowFriendList),
                new BaseNotificationData()
                {
                    BaseData = JsonConvert.SerializeObject(friendList)
                });
        }

        public void Hide()
        {
        }

        public void Refresh()
        {
            PostFriendListData();
        }

        public Action<string> onRemove { get; set; }
        public Action<string> onBlock { get; set; }

        public void BindList(List<FriendsEntryData> _friendEntryDatas)
        {
            friendList.FriendsEntryData = _friendEntryDatas;
        }
    }
}
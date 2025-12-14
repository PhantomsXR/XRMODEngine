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
using Unity.Services.Friends;
using Unity.Services.Friends.Models;
using UnityEngine;

namespace Phantom.XRMOD.GameServices.Runtime
{
    [System.Serializable]
    public class FriendPlayerProfileList
    {
        public List<PlayerProfile> FriendRequestData = new();
    }

    public class RequestListView : IRequestListView
    {
        private FriendPlayerProfileList friendPlayerProfileList = new();


        private void PostFriendListData()
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(NotificationActionEnum.ShowRequestList),
                new BaseNotificationData()
                {
                    BaseData = JsonConvert.SerializeObject(friendPlayerProfileList)
                });
        }


        public void Show()
        {
            PostFriendListData();
        }

        public void Hide()
        {
        }

        public void Refresh()
        {
            var tmp_Members = Utilities.GetNonBlockedMembers(FriendsService.Instance.IncomingFriendRequests);
            foreach (Member tmp_Member in tmp_Members)
            {
                friendPlayerProfileList.FriendRequestData.Add(new PlayerProfile("", tmp_Member.Profile.Name,
                    tmp_Member.Id));
            }

            PostFriendListData();
        }

        public Action<string> onAccept { get; set; }
        public Action<string> onDecline { get; set; }
        public Action<string> onBlock { get; set; }

        public void BindList(List<PlayerProfile> playerProfiles)
        {
            friendPlayerProfileList.FriendRequestData = playerProfiles;
        }
    }
}
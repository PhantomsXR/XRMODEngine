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
using Phantom.XRMOD.ActionNotification.Runtime;
using Unity.Services.Friends.Models;
using UnityEngine;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public class LocalPlayerView : ILocalPlayerView
    {
        private void PostFriendRequestData(string _requestMsg)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(NotificationActionEnum.AddFriendRequest),
                new BaseNotificationData()
                {
                    BaseData = _requestMsg
                });
        }

        public Action<(Availability, string)> OnPresenceChanged { get; set; }

        public void Refresh(string _profileImg, string _name, string _activity,
            Availability _presenceAvailabilityOptions)
        {
            PostFriendRequestData(JsonUtility.ToJson(new FriendsEntryData
            {
                Name = _name,
                Id = string.Empty,
                Availability = _presenceAvailabilityOptions,
                Activity = _activity,
                Avatar = _profileImg
            }));
        }
    }
}
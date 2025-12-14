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
using UnityEngine;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public class AddFriendView : IAddFriendView
    {
        private void PostFriendRequestData(string _requestMsg)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(NotificationActionEnum.AddFriendRequest),
                new BaseNotificationData()
                {
                    BaseData = _requestMsg
                });
        }

        public void FriendRequestSuccess()
        {
            PostFriendRequestData("Friend request sent!");
            #if UNITY_EDITOR
            Debug.Log("Friend request sent!");
            #endif
        }

        public void FriendRequestFailed()
        {
            PostFriendRequestData("Friend request failed!");
#if UNITY_EDITOR
            Debug.Log("Friend request failed!");
#endif
        }

        public Action<string> onFriendRequestSent { get; set; }

        public void Show()
        {
        }

        public void Hide()
        {
        }
    }
}
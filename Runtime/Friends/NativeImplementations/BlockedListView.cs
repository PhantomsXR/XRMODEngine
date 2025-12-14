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

namespace Phantom.XRMOD.GameServices.Runtime
{
    public class BlockedListView : IBlockedListView
    {
        private FriendPlayerProfileList friendPlayerProfileList = new();
        public void Show()
        {
            throw new NotImplementedException();
        }

        public void Hide()
        {
            throw new NotImplementedException();
        }

        public void Refresh()
        {
        }

        public Action<string> onUnblock { get; set; }

        public void BindList(List<PlayerProfile> playerProfiles)
        {
            friendPlayerProfileList.FriendRequestData = playerProfiles;
        }
    }
}
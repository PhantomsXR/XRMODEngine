using System;
using System.Collections.Generic;


namespace Phantom.XRMOD.GameServices.Runtime
{
    public interface IBlockedListView : IListView
    {
        Action<string> onUnblock { get; set; }
        void BindList(List<PlayerProfile> playerProfiles);
    }

}


using System;
using System.Collections.Generic;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public interface IRequestListView : IListView
    {
        Action<string> onAccept { get; set; }
        Action<string> onDecline { get; set; }
        Action<string> onBlock { get; set; }
        void BindList(List<PlayerProfile> playerProfiles);
    }
}

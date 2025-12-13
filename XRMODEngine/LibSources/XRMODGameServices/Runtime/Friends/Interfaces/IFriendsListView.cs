using System;
using System.Collections.Generic;

namespace Phantom.XRMOD.GameServices.Runtime
{

    public interface IFriendsListView : IListView
    {
        Action<string> onRemove { get; set; }
        Action<string> onBlock { get; set; }
        void BindList(List<FriendsEntryData> friendEntryDatas);
    }

}


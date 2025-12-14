using System;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public interface IRelationshipBarView
    {
        Action onShowAddFriend { get; set; }
        void Refresh();
    }


}


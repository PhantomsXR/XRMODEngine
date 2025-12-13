using System;
using Unity.Services.Friends.Models;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public interface ILocalPlayerView
    {
        Action<(Availability, string)> OnPresenceChanged { get; set; }
        void Refresh(string _profileImg,string _name, string _activity, Availability _presenceAvailabilityOptions);
    }
}
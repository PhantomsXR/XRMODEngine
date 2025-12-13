using System.Collections;
using System.Collections.Generic;
using System.Text;
using Unity.Services.Friends.Models; 

namespace Phantom.XRMOD.GameServices.Runtime
{
    [System.Serializable]
    public struct FriendsEntryData
    {
        public string Name;
        public string Id;
        public Availability Availability;
        public string Activity;
        public string Avatar;
        
        public override string ToString()
        {
            StringBuilder tmp_Sb = new StringBuilder("FriendEntryData: \n");
            tmp_Sb.Append(Name);
            tmp_Sb.Append(" : ");
            tmp_Sb.AppendLine(Id);
            tmp_Sb.Append(Availability);
            tmp_Sb.Append(" : ");
            tmp_Sb.AppendLine(Activity);
            return tmp_Sb.ToString();
        }
    }
}
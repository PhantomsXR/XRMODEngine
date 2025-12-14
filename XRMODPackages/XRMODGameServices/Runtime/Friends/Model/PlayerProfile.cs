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

using UnityEngine;

namespace Phantom.XRMOD.GameServices.Runtime
{
    [System.Serializable]
    public class PlayerProfile
    {
        [field: SerializeField] public string ProfileImg { get; private set; }
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public string Id { get; private set; }

        public PlayerProfile(string _profileImg, string _name, string _id)
        {
            ProfileImg = _profileImg;
            Name = _name;
            Id = _id;
        }

        public override string ToString()
        {
            return $"{Name} , Id :{Id}, ProfileImg:{ProfileImg}";
        }
    }
}
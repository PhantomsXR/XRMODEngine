// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the LeaderboardSystem.Runtime.
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
    [System.Serializable]
    public class LeaderboardScore
    {
        public string PlayerId;
        public string PlayerName;
        public int Rank;
        public double Score;
        public string Tier;
        public DateTime UpdatedTime;
        public string Metadata;
    }


    [System.Serializable]
    public class LeaderboardScores
    {
        public List<LeaderboardScore> LeaderboardList = new List<LeaderboardScore>();
    }
}
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

namespace Phantom.XRMOD.GameServices.Runtime
{
    [System.Serializable]
    public class AddOrUpdateScoreArgs : BaseLeaderboardArgs
    {
        /// <summary>
        /// Player Name
        /// </summary>
        public string UserName = string.Empty;
        
        /// <summary>
        /// Player Score
        /// </summary>
        public float Score;
    }

    [System.Serializable]
    public class GetScoreListArgs : BaseLeaderboardArgs
    {
        /// <summary>
        /// Page index
        /// </summary>
        public int Offset = 0;
        
        /// <summary>
        /// Num of page
        /// </summary>
        public int Limit = 10;
    }

    [System.Serializable]
    public class GetPlayerScoreArgs : BaseLeaderboardArgs
    {
    }

    [System.Serializable]
    public  class BaseLeaderboardArgs
    {
        /// <summary>
        ///  leaderboard id
        /// </summary>
        public string LeaderboardId;
    }
}
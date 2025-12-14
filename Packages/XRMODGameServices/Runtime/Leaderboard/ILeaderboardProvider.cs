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

using System.Threading.Tasks;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public interface ILeaderboardProvider
    {
        /// <summary>
        /// If user exist and leaderboard already will update the score for it, otherwise will auto create.
        /// </summary>
        /// <param name="_userName">User's name(ID)</param>
        /// <param name="_leaderboardId">The leaderboard id</param>
        /// <param name="_score">submit socre</param>
        /// <returns>List of <see cref="LeaderboardScores"/></returns>
        Task<LeaderboardScore> AddOrUpdateScore(string _userName, string _leaderboardId, float _score);

        /// <summary>
        /// Players can get the scores from a specified leaderboard with the GetScoresAsync method.
        /// You should create your leaderboard first and then substitute the leaderboardId for your own ID. 
        /// </summary>
        /// <param name="_leaderboardId">The leaderboard id</param>
        /// <param name="_offset">Offsetis the number of entries to skip when retrieving the leaderboard scores and defaults to 0.</param>
        /// <param name="_limit">Limit is the number of leaderboard scores to return and defaults to 10.</param>
        /// <returns>List of <see cref="LeaderboardScores"/></returns>
        Task<LeaderboardScores> GetScoreList(string _leaderboardId, int _offset = 0, int _limit = 10);

        /// <summary>
        /// Get the score for the player.
        /// </summary>
        /// <param name="_leaderboardId">The leaderboard id</param>
        /// <returns>The player score information, more detail <see cref="LeaderboardScore"/></returns>
        Task<LeaderboardScore> GetPlayerScore(string _leaderboardId);
    }
}
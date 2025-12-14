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
using Unity.Services.Leaderboards;
using Unity.Services.Leaderboards.Models;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public class UnityLeaderboardProvider : ILeaderboardProvider
    {
        public async Task<LeaderboardScore> AddOrUpdateScore(string _userName, string _leaderboardId, float _score)
        {
            var tmp_Response = await LeaderboardsService.Instance.AddPlayerScoreAsync(_leaderboardId, _score);
            return new LeaderboardScore
            {
                PlayerId = tmp_Response.PlayerId,
                PlayerName = tmp_Response.PlayerName,
                Rank = tmp_Response.Rank,
                Score = tmp_Response.Score,
                Tier = tmp_Response.Tier,
                UpdatedTime = tmp_Response.UpdatedTime,
                Metadata = tmp_Response.Metadata
            };
        }
        
        public async Task<LeaderboardScores> GetScoreList(string _leaderboardId, int _offset = 0, int _limit = 10)
        {
            var tmp_Response = await LeaderboardsService.Instance.GetScoresAsync(_leaderboardId, new GetScoresOptions()
            {
                Offset = _offset,
                Limit = _limit
            });
            LeaderboardScores tmp_LeaderboardScores = new LeaderboardScores();
            foreach (LeaderboardEntry tmp_LeaderboardEntry in tmp_Response.Results)
            {
                LeaderboardScore tmp_Score = new LeaderboardScore
                {
                    PlayerId = tmp_LeaderboardEntry.PlayerId,
                    PlayerName = tmp_LeaderboardEntry.PlayerName,
                    Rank = tmp_LeaderboardEntry.Rank,
                    Score = tmp_LeaderboardEntry.Score,
                    Tier = tmp_LeaderboardEntry.Tier,
                    UpdatedTime = tmp_LeaderboardEntry.UpdatedTime,
                    Metadata = tmp_LeaderboardEntry.Metadata
                };
                tmp_LeaderboardScores.LeaderboardList.Add(tmp_Score);
            }

            return tmp_LeaderboardScores;
        }
        
        public async Task<LeaderboardScore> GetPlayerScore(string _leaderboardId)
        {
            var tmp_ResultOfLeaderboard = await LeaderboardsService.Instance.GetPlayerScoreAsync(_leaderboardId);
            return new LeaderboardScore
            {
                PlayerId = tmp_ResultOfLeaderboard.PlayerId,
                PlayerName = tmp_ResultOfLeaderboard.PlayerName,
                Rank = tmp_ResultOfLeaderboard.Rank,
                Score = tmp_ResultOfLeaderboard.Score,
                Tier = tmp_ResultOfLeaderboard.Tier,
                UpdatedTime = tmp_ResultOfLeaderboard.UpdatedTime,
                Metadata = tmp_ResultOfLeaderboard.Metadata
            };
        }
    }
}
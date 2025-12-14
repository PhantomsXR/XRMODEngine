using System.Threading.Tasks;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public class LeaderboardSystemManager
    {
        private ILeaderboardProvider leaderboardProvider;
        private static LeaderboardSystemManager _INSTANCE;

        public static LeaderboardSystemManager GetInstance => _INSTANCE ?? new LeaderboardSystemManager();

        private LeaderboardSystemManager()
        {
#if USE_UNITY_LEADERBOARD
            leaderboardProvider = new UnityLeaderboardProvider();
#endif
        }

        /// <summary>
        /// To add or update an entry for the player in the specified leaderboard.
        /// </summary>
        /// <param name="_addOrUpdateScoreArgs"><see cref="AddOrUpdateScoreArgs"/></param>
        /// <returns>Added score data <see cref="LeaderboardScore"/></returns>
        public async Task<LeaderboardScore> AddOrUpdateScore(AddOrUpdateScoreArgs _addOrUpdateScoreArgs)
        {
            var tmp_Leaderboard = await leaderboardProvider.AddOrUpdateScore(
                _leaderboardId: _addOrUpdateScoreArgs.LeaderboardId,
                _score: _addOrUpdateScoreArgs.Score, _userName: _addOrUpdateScoreArgs.UserName);
            return tmp_Leaderboard;
        }

        /// <summary>
        /// Players can get the scores from a specified leaderboard with the GetScoresAsync method.
        /// You should create your leaderboard first and then substitute the leaderboardId for your own ID. 
        /// </summary>
        /// <param name="_getScoreListArgs">Require parameter. <see cref="GetScoreListArgs"/></param>
        /// <returns>List of <see cref="LeaderboardScores"/></returns>
        public async Task<LeaderboardScores> GetScoreList(GetScoreListArgs _getScoreListArgs)
        {
            return await leaderboardProvider.GetScoreList(_getScoreListArgs.LeaderboardId, _getScoreListArgs.Offset,
                _getScoreListArgs.Limit);
        }


        /// <summary>
        /// Get the score for the player.
        /// </summary>
        /// <param name="_getPlayerScoreArgs">Request player score args. <see cref="GetPlayerScoreArgs"/></param>
        /// <returns>The player score information, more detail <see cref="LeaderboardScore"/></returns>
        public async Task<LeaderboardScore> GetPlayerScore(GetPlayerScoreArgs _getPlayerScoreArgs)
        {
            return await leaderboardProvider.GetPlayerScore(_getPlayerScoreArgs.LeaderboardId);
        }
    }
}
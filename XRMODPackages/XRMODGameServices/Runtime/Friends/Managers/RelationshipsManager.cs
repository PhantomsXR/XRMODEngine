using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.Services.Authentication;
using Unity.Services.Friends;
using Unity.Services.Friends.Exceptions;
using Unity.Services.Friends.Models;
using UnityEngine;

namespace Phantom.XRMOD.GameServices.Runtime
{
    /// <summary>
    /// Manages relationships between players, including friends, friend requests, and blocking.
    /// Wraps Unity's Friends Service.
    /// </summary>
    public class RelationshipsManager : IDisposable
    {
        private static RelationshipsManager _RELATIONSHIPS_MANAGER;

        /// <summary>
        /// Singleton instance of RelationshipsManager.
        /// </summary>
        public static RelationshipsManager GetInstance => _RELATIONSHIPS_MANAGER ??= new();


        public IRelationshipsView relationshipsView;

        readonly List<FriendsEntryData> friendsEntryData = new List<FriendsEntryData>();
        private readonly List<PlayerProfile> requestsEntryData = new List<PlayerProfile>();
        readonly List<PlayerProfile> blockEntryData = new List<PlayerProfile>();

        ILocalPlayerView localPlayerView;
        IAddFriendView addFriendView;
        IFriendsListView friendsListView;
        IRequestListView requestListView;
        IBlockedListView blockListView;

        PlayerProfile signInedPlayerProfile;
        private UserInfoModel userDataModel;

        private RelationshipsManager()
        {
        }

        // Fired after Friends service initializes and the local player presence is set.
        public event Action FriendSignedIn;

        public async void Dispose()
        {
            await SetPresence(Availability.Offline);
        }

        /// <summary>
        /// Initializes the Friend provider with user data.
        /// Sets up the service, binds views, and signs in the local player.
        /// </summary>
        /// <param name="_data">The user data model for the local player.</param>
        public async void InitFriendProvider(UserInfoModel _data)
        {
            try
            {
                await FriendsService.Instance.InitializeAsync();
                userDataModel = _data;
                relationshipsView ??= new RelationshipsViewDataOnly();
                if (relationshipsView == null) return;
                relationshipsView.Init();
                ViewInit();
                await SignInAsync();
                // Notify listeners that Friends service sign-in is complete
                FriendSignedIn?.Invoke();
                SubscribeToFriendsEventCallbacks();
                RefreshAll();
                Debug.Log("Friend System Initialized");
            }
            catch (Exception tmp_Exception)
            {
                Debug.LogError(tmp_Exception);
            }
        }

        void ViewInit()
        {
            localPlayerView = relationshipsView.LocalPlayerView;
            addFriendView = relationshipsView.AddFriendView;

            //Bind Lists
            friendsListView = relationshipsView.FriendsListView;
            friendsListView.BindList(friendsEntryData);
            requestListView = relationshipsView.RequestListView;
            requestListView.BindList(requestsEntryData);
            blockListView = relationshipsView.BlockListView;
            blockListView.BindList(blockEntryData);

            //Bind Friends SDK Callbacks
            addFriendView.onFriendRequestSent += AddFriendAsync;
            friendsListView.onRemove += RemoveFriendAsync;
            friendsListView.onBlock += BlockFriendAsync;
            requestListView.onAccept += AcceptRequestAsync;
            requestListView.onDecline += DeclineRequestAsync;
            requestListView.onBlock += BlockFriendAsync;
            blockListView.onUnblock += UnblockFriendAsync;
            localPlayerView.OnPresenceChanged += SetPresenceAsync;
        }

        async Task SignInAsync()
        {
            var tmp_PlayerID = AuthenticationService.Instance.PlayerId;
            var tmp_PlayerName = AuthenticationService.Instance.PlayerName;
            signInedPlayerProfile =
                new PlayerProfile(GetPlayerNameFirstWord(tmp_PlayerName), tmp_PlayerName, tmp_PlayerID);
            await SetPresence(Availability.Online, $"In Home|{userDataModel.user_avatar}");
            localPlayerView.Refresh(signInedPlayerProfile.ProfileImg, signInedPlayerProfile.Name, "In Home",
                Availability.Online);
            RefreshAll();
        }

        string GetPlayerNameFirstWord(string _playerName)
        {
            if (string.IsNullOrEmpty(_playerName)) return "N";
            return _playerName[0].ToString();
        }

        public void RefreshAll()
        {
            RefreshFriends();
            RefreshRequests();
            RefreshBlocks();
        }

        public async void BlockFriendAsync(string _id)
        {
            await BlockFriend(_id);
            RefreshAll();
        }

        public async void UnblockFriendAsync(string _id)
        {
            await UnblockFriend(_id);
            RefreshBlocks();
            RefreshFriends();
        }

        public async void RemoveFriendAsync(string _id)
        {
            await RemoveFriend(_id);
            RefreshFriends();
        }

        public async void AcceptRequestAsync(string _name)
        {
            await AcceptRequest(_name);
            RefreshRequests();
            RefreshFriends();
        }

        public async void DeclineRequestAsync(string _id)
        {
            await DeclineRequest(_id);
            RefreshRequests();
        }

        public async void SetPresenceAsync((Availability presence, string activity) _status)
        {
            await SetPresence(_status.presence, _status.activity);
            // localPlayerView.Refresh(signInedPlayerProfile.ProfileImg, signInedPlayerProfile.Name, _status.activity,
            //     _status.presence);
        }

        public async void AddFriendAsync(string _name)
        {
            var tmp_Success = await SendFriendRequest(_name);
            if (tmp_Success)
            {
                addFriendView.FriendRequestSuccess();
                //If the added friend has also requested friendship, he is already a friend, just refresh the views.
                if (requestsEntryData.Find(_entry => _entry.Name == _name) != null)
                    RefreshAll();
            }
            else
            {
                addFriendView.FriendRequestFailed();
            }
        }

        public void RefreshFriends()
        {
            friendsEntryData.Clear();

            var tmp_Friends = GetFriends();
            foreach (var tmp_Friend in tmp_Friends)
            {
                string tmp_ActivityText;
                var tmp_Info = new FriendsEntryData
                {
                    Name = tmp_Friend.Profile.Name,
                    Id = tmp_Friend.Id,
                    Availability = tmp_Friend.Presence.Availability
                };

                if (tmp_Friend.Presence.Availability == Availability.Offline ||
                    tmp_Friend.Presence.Availability == Availability.Invisible)
                {
                    tmp_ActivityText =
                        $"{tmp_Friend.Presence.LastSeen.ToShortDateString()} {tmp_Friend.Presence.LastSeen.ToLongTimeString()}";
                }
                else
                {
                    var tmp_Status = tmp_Friend.Presence.GetActivity<Activity>().Status;
                    var tmp_UserData = tmp_Status.Split("|");
                    tmp_ActivityText = tmp_UserData.Length > 1 ? tmp_UserData[0] : tmp_Status;
                    tmp_Info.Avatar = tmp_UserData.Length >= 2 ? tmp_UserData[1] : "";
                }

                tmp_Info.Activity = tmp_ActivityText;
                friendsEntryData.Add(tmp_Info);
            }

            relationshipsView.RelationshipBarView.Refresh();
            relationshipsView.FriendsListView.Refresh();
        }

        public void RefreshRequests()
        {
            requestsEntryData.Clear();
            var tmp_Requests = GetRequests();

            foreach (var tmp_Request in tmp_Requests)
            {
                requestsEntryData.Add(new PlayerProfile("", tmp_Request.Profile.Name, tmp_Request.Id));
            }

            relationshipsView.RequestListView.Refresh();
            relationshipsView.RelationshipBarView.Refresh();
        }

        public void RefreshBlocks()
        {
            blockEntryData.Clear();
            foreach (var tmp_Block in FriendsService.Instance.Blocks)
            {
                blockEntryData.Add(new PlayerProfile("", tmp_Block.Member.Profile.Name, tmp_Block.Member.Id));
            }

            relationshipsView.BlockListView.Refresh();
            relationshipsView.RelationshipBarView.Refresh();
        }

        async Task<bool> SendFriendRequest(string _playerName)
        {
            try
            {
                // We add the friend by name in this sample but you can also add a friend by ID using AddFriendAsync
                var tmp_Relationship = await FriendsService.Instance.AddFriendByNameAsync(_playerName);
                Debug.Log($"Friend request sent to {_playerName}.");
                // If both players send friend request to each other, their relationship is changed to Friend.
                return tmp_Relationship.Type is RelationshipType.FriendRequest or RelationshipType.Friend;
            }
            catch (FriendsServiceException tmp_E)
            {
                Debug.Log($"Failed to Request {_playerName} - {tmp_E}.");
                return false;
            }
        }

        async Task RemoveFriend(string _playerId)
        {
            try
            {
                await FriendsService.Instance.DeleteFriendAsync(_playerId);
                Debug.Log($"{_playerId} was removed from the friends list.");
            }
            catch (FriendsServiceException e)
            {
                Debug.Log($"Failed to remove {_playerId}. - {e}");
            }
        }

        async Task BlockFriend(string _playerId)
        {
            try
            {
                await FriendsService.Instance.AddBlockAsync(_playerId);
                Debug.Log($"{_playerId} was blocked.");
            }
            catch (FriendsServiceException tmp_E)
            {
                Debug.Log($"Failed to block {_playerId}. - {tmp_E}");
            }
        }

        async Task UnblockFriend(string _playerId)
        {
            try
            {
                await FriendsService.Instance.DeleteBlockAsync(_playerId);
                Debug.Log($"{_playerId} was unblocked.");
            }
            catch (FriendsServiceException e)
            {
                Debug.Log($"Failed to unblock {_playerId} - {e}.");
            }
        }

        async Task AcceptRequest(string _playerName)
        {
            try
            {
                await SendFriendRequest(_playerName);
                Debug.Log($"Friend request from {_playerName} was accepted.");
            }
            catch (FriendsServiceException e)
            {
                Debug.Log($"Failed to accept request from {_playerName}. - {e}");
            }
        }

        async Task DeclineRequest(string _playerId)
        {
            try
            {
                await FriendsService.Instance.DeleteIncomingFriendRequestAsync(_playerId);
                Debug.Log($"Friend request from {_playerId} was declined.");
            }
            catch (FriendsServiceException tmp_E)
            {
                Debug.Log($"Failed to decline request from {_playerId}. - {tmp_E}");
            }
        }

        /// <summary>
        /// Get an amount of friends (including presence data).
        /// </summary>
        /// <returns>List of friends.</returns>
        public List<Member> GetFriends()
        {
            return Utilities.GetNonBlockedMembers(FriendsService.Instance.Friends);
        }

        /// <summary>
        /// Get an amount of Requests. The friends SDK maintains relationships unless explicitly deleted, even those
        /// towards blocked players. We don't want to show blocked players' requests, so we filter them out.
        /// </summary>
        /// <returns>List of players.</returns>
        public List<Member> GetRequests()
        {
            return Utilities.GetNonBlockedMembers(FriendsService.Instance.IncomingFriendRequests);
        }

        public void ChangeAvailability(Availability _availability, string _status)
        {
            SetPresenceAsync((_availability, _status));
        }

        private async Task SetPresence(Availability _presenceAvailabilityOptions,
            string _activityStatus = "")
        {
            var tmp_Activity = new Activity {Status = _activityStatus};
            try
            {
                await FriendsService.Instance.SetPresenceAsync(_presenceAvailabilityOptions, tmp_Activity);
                Debug.Log($"Availability changed to {_presenceAvailabilityOptions}.");
            }
            catch (FriendsServiceException e)
            {
                Debug.Log($"Failed to set the presence to {_presenceAvailabilityOptions} - {e}");
            }
        }

        void SubscribeToFriendsEventCallbacks()
        {
            try
            {
                FriendsService.Instance.RelationshipAdded += e =>
                {
                    RefreshRequests();
                    RefreshFriends();
                    Debug.Log($"create {e.Relationship} EventReceived");
                };
                FriendsService.Instance.MessageReceived += _e =>
                {
                    RefreshRequests();
                    Debug.Log("MessageReceived EventReceived");
                };
                FriendsService.Instance.PresenceUpdated += _e =>
                {
                    RefreshFriends();
                    Debug.Log("PresenceUpdated EventReceived");
                };
                FriendsService.Instance.RelationshipDeleted += _e =>
                {
                    RefreshFriends();
                    Debug.Log($"Delete {_e.Relationship} EventReceived");
                };
            }
            catch (FriendsServiceException tmp_E)
            {
                Debug.Log(
                    "An error occurred while performing the action. HttpCode: " + tmp_E.StatusCode +
                    ", FriendsErrorCode: " + tmp_E.ErrorCode + ", Message: " + tmp_E.Message);
            }
        }
    }
}
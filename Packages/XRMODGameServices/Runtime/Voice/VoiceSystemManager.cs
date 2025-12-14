// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Assembly-CSharp.
// //
// // The Nin1 cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine.Assertions;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public enum JoinChannelType
    {
        Group,
        Echo,
        Positional
    }

    public class VoiceSystemManager : IVoiceProvider, ITextMessage
    {
        private IVoiceProvider voiceProvider;

        private static VoiceSystemManager _INSTANCE;

        public static VoiceSystemManager GetInstance => _INSTANCE ??= new VoiceSystemManager();
        public string ChannelName;

        public bool Initialized { get; private set; }

        private VoiceSystemManager()
        {
#if USE_VIVOX
            voiceProvider = new VivoxProvider();
#elif USE_AGORA_RTC
            voiceProvider = new AgoraOfficialSDKProvider();
#elif USE_PHOTON_VOICE
            voiceProvider = new PhotonVoice.PhotonVoiceProvider();
#endif
            Assert.IsNotNull(voiceProvider, "Voice provider is empty.");
        }


        public void Initialize(string _configuration, Voice3DProperties _voice3DProperties)
        {
            if (Initialized) return;
            voiceProvider.Initialize(_configuration, _voice3DProperties);
            Initialized = true;
        }

        public void DeInitialize()
        {
            voiceProvider.DeInitialize();
        }

        /// <summary>
        /// Join voice channel by channel name
        /// </summary>
        /// <param name="_channelName">will join channel's name</param>
        /// <param name="_joinChannelType">The channel type is indicated by the method used to initiate the channel join.
        /// JoinEchoChannelAsync joins an echo channel, JoinGroupChannelAsyc joins a group channel,
        /// and JoinPositionalChannelAsync joins a positional channel.
        /// </param>
        public void JoinVoiceChannel(string _channelName, JoinChannelType _joinChannelType)
        {
            if (voiceProvider == null || !Initialized) return;
            voiceProvider.JoinVoiceChannel(_channelName, _joinChannelType);
            ChannelName = _channelName;
        }

        /// <summary>
        /// Leave current voice channel
        /// </summary>
        public void LeaveVoiceChannel()
        {
            if (voiceProvider == null || !Initialized) return;
            voiceProvider.LeaveVoiceChannel();
            ChannelName = string.Empty;
        }

        /// <summary>
        /// Create a new voice channel by channel name
        /// </summary>
        /// <param name="_channelName">will create channel's name</param>
        /// <param name="_joinChannelType">The channel type is indicated by the method used to initiate the channel join.
        /// JoinEchoChannelAsync joins an echo channel, JoinGroupChannelAsyc joins a group channel,
        /// and JoinPositionalChannelAsync joins a positional channel.
        /// </param>
        public void CreateVoiceChannel(string _channelName, JoinChannelType _joinChannelType)
        {
            if (voiceProvider == null || !Initialized) return;
            voiceProvider.CreateVoiceChannel(_channelName, _joinChannelType);
        }

        /// <summary>
        /// Mute self microphone
        /// </summary>
        /// <param name="_muted">Muted state, True is muted otherwise is unmuted</param>
        public void MuteSelfMicrophone(bool _muted)
        {
            if (voiceProvider == null || !Initialized) return;
            voiceProvider.MuteSelfMicrophone(_muted);
        }


        /// <summary>
        /// Mute other user microphone
        /// </summary>
        /// <param name="_muted">Muted state, True is muted otherwise is unmuted</param>
        /// <param name="_channelId">Channel name</param>
        /// <param name="_userId">Mute target</param>
        public void MuteOtherMicrophone(bool _muted, string _channelId, string _userId)
        {
            if (voiceProvider == null || !Initialized) return;
            voiceProvider.MuteOtherMicrophone(_muted, _channelId, _userId);
        }


        /// <summary>
        /// "Block" a user, bidirectionally muting audio/text between that player and the local user.
        /// </summary>
        /// <param name="_block">Block state, True is blocked otherwise is unblock</param>
        /// <param name="_channelId">Channel name</param>
        /// <param name="_userId">The userid to bidirectionally mute or unmute</param>
        public void BlockUser(bool _block, string _channelId, string _userId)
        {
            if (voiceProvider == null || !Initialized) return;
            voiceProvider.BlockUser(_block, _channelId, _userId);
        }

        /// <summary>
        /// All participant
        /// </summary>
        /// <returns><see cref="VoiceParticipant"/></returns>
        public List<VoiceParticipant> GetParticipants()
        {
            if (voiceProvider == null || !Initialized) return new List<VoiceParticipant>();
            return voiceProvider.GetParticipants();
        }

        /// <summary>
        /// Get single participant by user id/name
        /// </summary>
        /// <param name="_userId">The user id or user name</param>
        /// <returns><see cref="VoiceParticipant"/></returns>
        public VoiceParticipant GetParticipant(string _userId)
        {
            if (voiceProvider == null || !Initialized) return null;
            return voiceProvider.GetParticipant(_userId);
        }

        /// <summary>
        /// You can send a message to a player with playerId being the playerId of
        /// the player that the message should be sent to, and message being the message that should be sent.
        /// </summary>
        /// <param name="_userId">The user id or user name</param>
        /// <param name="_message">The direct message </param>
        /// <returns></returns>
        public Task SendDirectTextMessage(string _userId, string _message)
        {
            if (voiceProvider == null || !Initialized) return null;
            return ((ITextMessage) voiceProvider).SendDirectTextMessage(_userId, _message);
        }

        /// <summary>
        /// Access the history of a direct message conversation between two players
        /// </summary>
        /// <param name="_userId">The user id or user name</param>
        /// <returns></returns>
        public Task<List<TextMessage>> FetchDirectTextMessageHistory(string _userId)
        {
            if (voiceProvider == null || !Initialized) return null;
            return ((ITextMessage) voiceProvider).FetchDirectTextMessageHistory(_userId);
        }

        /// <summary>
        /// Edit the text of messages they have sent.
        /// with the messageId being the ID of the message to change,
        /// and newMessage being the updated text of the message.
        /// </summary>
        /// <param name="_message">The old message</param>
        /// <param name="_editedMessageText">NewMessage being the updated text of the message.</param>
        /// <returns></returns>
        public Task EditDirectedTextMessage(TextMessage _message, string _editedMessageText)
        {
            if (voiceProvider == null || !Initialized) return null;
            return ((ITextMessage) voiceProvider).EditDirectedTextMessage(_message, _editedMessageText);
        }

        /// <summary>
        /// Delete the message by message id
        /// </summary>
        /// <param name="_messageId">The message id</param>
        /// <returns></returns>
        public Task DeletingDirectTextMessage(string _messageId)
        {
            if (voiceProvider == null || !Initialized) return null;
            return ((ITextMessage) voiceProvider).DeletingDirectTextMessage(_messageId);
        }
    }
}
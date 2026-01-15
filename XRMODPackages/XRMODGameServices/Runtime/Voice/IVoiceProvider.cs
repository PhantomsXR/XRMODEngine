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
using System.Threading;
using System.Threading.Tasks;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public interface IVoiceProvider
    {
        void Initialize(string _configuration, Voice3DProperties _voice3DProperties);
        void DeInitialize();

        /// <summary>
        /// Asynchronously initialize the voice provider with retry configuration support.
        /// </summary>
        /// <param name="_configuration">Voice provider configuration</param>
        /// <param name="_voice3DProperties">3D voice properties</param>
        /// <param name="_retryConfig">Retry configuration for handling failures</param>
        /// <param name="_cancellationToken">Cancellation token to cancel the operation</param>
        /// <returns>Task representing the async initialization operation</returns>
        Task InitializeAsync(string _configuration, Voice3DProperties _voice3DProperties, 
                           RetryConfiguration _retryConfig, CancellationToken _cancellationToken);

        /// <summary>
        /// Join voice channel by channel name
        /// </summary>
        /// <param name="_channelName">will join channel's name</param>
        /// <param name="_joinChannelType">The channel type is indicated by the method used to initiate the channel join.
        /// JoinEchoChannelAsync joins an echo channel, JoinGroupChannelAsyc joins a group channel,
        /// and JoinPositionalChannelAsync joins a positional channel.
        /// </param>
        void JoinVoiceChannel(string _channelName, JoinChannelType _joinChannelType);

        /// <summary>
        /// Leave current voice channel
        /// </summary>
        void LeaveVoiceChannel();

        /// <summary>
        /// Create a new voice channel by channel name
        /// </summary>
        /// <param name="_channelName">will create channel's name</param>
        /// <param name="_joinChannelType">The channel type is indicated by the method used to initiate the channel join.
        /// JoinEchoChannelAsync joins an echo channel, JoinGroupChannelAsyc joins a group channel,
        /// and JoinPositionalChannelAsync joins a positional channel.
        /// </param>
        void CreateVoiceChannel(string _channelName, JoinChannelType _joinChannelType);

        /// <summary>
        /// Mute self microphone
        /// </summary>
        /// <param name="_muted">Muted state, True is muted otherwise is unmuted</param>
        void MuteSelfMicrophone(bool _muted);

        /// <summary>
        /// Mute other user microphone
        /// </summary>
        /// <param name="_muted">Muted state, True is muted otherwise is unmuted</param>
        /// <param name="_channelId">Channel name</param>
        /// <param name="_userId">Mute target</param>
        void MuteOtherMicrophone(bool _muted, string _channleId, string _userId);


        /// <summary>
        /// "Block" a user, bidirectionally muting audio/text between that player and the local user.
        /// </summary>
        /// <param name="_block">Block state, True is blocked otherwise is unblock</param>
        /// <param name="_channelId">Channel name</param>
        /// <param name="_userId">The userid to bidirectionally mute or unmute</param>
        void BlockUser(bool _block, string _channelId, string _userId);

        /// <summary>
        /// All participant
        /// </summary>
        /// <returns></returns>
        List<VoiceParticipant> GetParticipants();

        VoiceParticipant GetParticipant(string _userId);
    }
}
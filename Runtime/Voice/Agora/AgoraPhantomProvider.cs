// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.VoiceModule.Runtime.
// //
// // The Nin1 cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

#if USE_AGORA_RTC && !USE_AGORA_OFFICIAL
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

namespace Phantom.XRMOD.GameServices.Runtime
{
    internal class AgoraPhantomProvider : IVoiceProvider
    {
        private string token;
        private string userAccount;

        private ConfigurationArgs agoraConfiguration;

        private readonly List<uint> blockList = new();
        private List<VoiceParticipant> voiceParticipants = new();

        private const string _CONST_ON_USER_OFFLINE = "OnUserOffline";
        private const string _CONST_ON_USER_JOINED = "OnUserJoined";
        private const string _CONST_ON_JOIN_CHANNEL = "OnJoinChannelSuccess";
        private const string _CONST_ON_ERROR = "OnError";
        private const string _CONST_ON_REJOIN_CHANNEL = "OnRejoinChannelSuccess";
        private Voice3DProperties voice3DProperties;

        public void Initialize(string _configuration, Voice3DProperties _voice3DProperties)
        {
            voice3DProperties = _voice3DProperties;
            agoraConfiguration = JsonConvert.DeserializeObject<ConfigurationArgs>(_configuration);
            AgoraWrapperAPI.initRtcEngine(agoraConfiguration.AppId);
            AgoraWrapperAPI.InitAgoraWrapperAPI(AgoraWrapperAPICallback);
            userAccount =  AuthenticationManager.GetUserInfo().username;
        }

        private void AgoraWrapperAPICallback(string _data)
        {
            var tmp_Data = JsonConvert.DeserializeObject<AgoraCallbackParam>(_data);
            switch (tmp_Data.@event)
            {
                case _CONST_ON_JOIN_CHANNEL:
                case _CONST_ON_USER_JOINED:
                case _CONST_ON_REJOIN_CHANNEL:
                    var tmp_ConnectionData = JsonConvert.DeserializeObject<AgoraConnectionParam>(tmp_Data.data);
                    AgoraUtility.AddParticipant(tmp_ConnectionData.uid, ref voiceParticipants);
                    break;

                case _CONST_ON_USER_OFFLINE:
                    var tmp_OfflineConnectionData = JsonConvert.DeserializeObject<AgoraConnectionParam>(tmp_Data.data);
                    var tmp_Participant =
                        voiceParticipants.Find(_participant =>
                            _participant.UserId == tmp_OfflineConnectionData.uid.ToString());
                    if (tmp_Participant != null)
                        voiceParticipants.Remove(tmp_Participant);
                    break;
                case _CONST_ON_ERROR:
                    var tmp_ErrorData = JsonConvert.DeserializeObject<AgoraErrorParam>(tmp_Data.data);
                    Debug.LogError($"Agora error:{tmp_ErrorData.errorCode}");
                    break;
            }
        }

        public void DeInitialize()
        {
            LeaveVoiceChannel();
            AgoraWrapperAPI.DeinitAgoraWrapperAPI();
        }

        public void JoinVoiceChannel(string _channelName, JoinChannelType _joinChannelType)
        {
            if (!string.IsNullOrEmpty(token))
            {
                var tmp_UserId = int.Parse(userAccount.Split("#")[1]);
                AgoraWrapperAPI.joinChannel(_channelName, token, (uint) tmp_UserId, string.Empty);
            }
            else
            {
                AgoraUtility.RequestNewToken(_channelName, userAccount,
                    (_token) =>
                    {
                        token = _token;
                        JoinVoiceChannel(_channelName,_joinChannelType);
                    });
            }
        }

        public void LeaveVoiceChannel()
        {
            token = string.Empty;
            blockList.Clear();
            voiceParticipants.Clear();
            AgoraWrapperAPI.leaveChannel();
        }

        public void CreateVoiceChannel(string _channelName, JoinChannelType _joinChannelType)
        {
            AgoraUtility.RequestNewToken(_channelName, userAccount, (_token) => { JoinVoiceChannel(_channelName,_joinChannelType); });
        }

        public void MuteSelfMicrophone(bool _muted)
        {
            AgoraWrapperAPI.muteLocalAudioStream(_muted);
        }

        public void MuteOtherMicrophone(bool _muted, string _channleName, string _userName)
        {
            var tmp_UserId = uint.Parse(userAccount.Split("#")[1]);
            AgoraWrapperAPI.muteRemoteAudioStream(tmp_UserId, _muted);
        }

        public void BlockUser(bool _block, string _channelName, string _userName)
        {
            var tmp_UserId = uint.Parse(userAccount.Split("#")[1]);


            if (_block)
            {
                if (voiceParticipants.FindIndex(_participant => _participant.UserId == _userName) >= 0 &&
                    !blockList.Contains(tmp_UserId))
                {
                    blockList.Add(tmp_UserId);
                }

                AgoraWrapperAPI.SetSubscribeAudioBlocklist(blockList.ToArray());
            }
            else
            {
                if (blockList.Contains(tmp_UserId))
                    blockList.Remove(tmp_UserId);
                AgoraWrapperAPI.SetSubscribeAudioBlocklist(blockList.ToArray());
            }
        }

        public List<VoiceParticipant> GetParticipants()
        {
            return voiceParticipants;
        }

        public VoiceParticipant GetParticipant(string _userId)
        {
            return voiceParticipants.Find(_participant => _participant.DisplayName == _userId);
        }
    }
}

#endif
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

#if USE_AGORA_RTC
using System.Collections.Generic;
#if USE_AGORA_OFFICIAL || UNITY_EDITOR
using Agora.Rtc;
using Newtonsoft.Json;
using Phantom.XRMOD.ActionNotification.Runtime;
#endif
using Unity.Services.Authentication;
using UnityEngine;


namespace Phantom.XRMOD.GameServices.Runtime
{
    public class AgoraOfficialSDKProvider : IVoiceProvider
    {
#if USE_AGORA_OFFICIAL || UNITY_EDITOR
        private string token;
        private string userAccount;

        private IRtcEngine _rtcEngine = null;

        private ConfigurationArgs agoraConfiguration;
        private List<VoiceParticipant> _voiceParticipants = new();
        private List<uint> _participantList = new();
        private List<uint> blockList = new();

#else
        private AgoraPhantomProvider _rtcEngine = null;
#endif

        public void Initialize(string _configuration)
        {
#if USE_AGORA_OFFICIAL || UNITY_EDITOR
            agoraConfiguration = JsonConvert.DeserializeObject<ConfigurationArgs>(_configuration);
            UserEventHandler tmp_Handler = new UserEventHandler(this);
            RtcEngineContext tmp_Context = new RtcEngineContext
            {
                appId = agoraConfiguration.AppId,
                channelProfile = CHANNEL_PROFILE_TYPE.CHANNEL_PROFILE_LIVE_BROADCASTING,
                audioScenario = AUDIO_SCENARIO_TYPE.AUDIO_SCENARIO_GAME_STREAMING,
                areaCode = AREA_CODE.AREA_CODE_GLOB
            };
            _rtcEngine = RtcEngine.CreateAgoraRtcEngine();
            _rtcEngine.Initialize(tmp_Context);
            _rtcEngine.InitEventHandler(tmp_Handler);
            SetBasicConfiguration();
            userAccount = AuthenticationService.Instance.PlayerName;
#else
            _rtcEngine = new AgoraPhantomProvider();
            _rtcEngine.Initialize(_configuration);
#endif

            Debug.Log("Agora initialized");
        }

        public void DeInitialize()
        {
            if (_rtcEngine == null) return;
#if USE_AGORA_OFFICIAL || UNITY_EDITOR
            _rtcEngine.InitEventHandler(null);
            _rtcEngine.LeaveChannel();
            _rtcEngine.Dispose();
#else
            _rtcEngine.DeInitialize();
#endif
        }

        public void JoinVoiceChannel(string _channelName)
        {
#if USE_AGORA_OFFICIAL || UNITY_EDITOR
            _rtcEngine.EnableAudio();
            _rtcEngine.SetClientRole(CLIENT_ROLE_TYPE.CLIENT_ROLE_BROADCASTER);
            if (!string.IsNullOrEmpty(token))
            {
                var tmp_UserId = int.Parse(userAccount.Split("#")[1]);
                _ = _rtcEngine.JoinChannel(token, _channelName, string.Empty, (uint) tmp_UserId);
            }
            else
            {
                AgoraUtility.RequestNewToken(_channelName, userAccount,
                    (_token) =>
                    {
                        token = _token;
                        JoinVoiceChannel(_channelName);
                    });
            }
#else
            _rtcEngine.JoinVoiceChannel(_channelName);
#endif
        }

        public void LeaveVoiceChannel()
        {
#if USE_AGORA_OFFICIAL || UNITY_EDITOR
            _rtcEngine.LeaveChannel();
            token = null;
#else
            _rtcEngine.LeaveVoiceChannel();
#endif
        }

        public void CreateVoiceChannel(string _channelName)
        {
#if USE_AGORA_OFFICIAL || UNITY_EDITOR
            AgoraUtility.RequestNewToken(_channelName, userAccount, (_token) =>
            {
                token = _token;
                JoinVoiceChannel(_channelName);
            });
#else
            _rtcEngine.CreateVoiceChannel(_channelName);
#endif
        }

        public void MuteSelfMicrophone(bool _muted)
        {
#if USE_AGORA_OFFICIAL || UNITY_EDITOR
            _rtcEngine.MuteLocalAudioStream(_muted);
#else
            _rtcEngine.MuteSelfMicrophone(_muted);
#endif
        }

        public void MuteOtherMicrophone(bool _muted, string _channleId, string _userId)
        {
#if USE_AGORA_OFFICIAL || UNITY_EDITOR
            var tmp_Uid = uint.Parse(_userId);
            if (_participantList.Contains(tmp_Uid))
            {
                Debug.Log(_rtcEngine.MuteRemoteAudioStream(tmp_Uid, _muted));
            }
#else
            _rtcEngine.MuteOtherMicrophone(_muted, _channleId, _userId);
#endif
        }

        public void BlockUser(bool _block, string _channelId, string _userId)
        {
#if USE_AGORA_OFFICIAL || UNITY_EDITOR
            var tmp_Uid = uint.Parse(_userId);

            if (_block)
            {
                if (_participantList.Contains(tmp_Uid) && !blockList.Contains(tmp_Uid))
                {
                    blockList.Add(tmp_Uid);
                }

                _rtcEngine.SetSubscribeAudioBlocklist(blockList.ToArray(), blockList.Count);
            }
            else
            {
                if (blockList.Contains(tmp_Uid))
                    blockList.Remove(tmp_Uid);
                _rtcEngine.SetSubscribeAudioBlocklist(blockList.ToArray(), blockList.Count);
            }
#else
            _rtcEngine.BlockUser(_block, _channelId, _userId);
#endif
        }


        public List<VoiceParticipant> GetParticipants()
        {
#if USE_AGORA_OFFICIAL || UNITY_EDITOR
            return _voiceParticipants;
#else
            return _rtcEngine.GetParticipants();
#endif
        }

#if USE_AGORA_OFFICIAL || UNITY_EDITOR
        /// <summary>
        /// Set the configuration for Rtc engine.
        /// </summary>
        private void SetBasicConfiguration()
        {
            _rtcEngine.EnableAudio();
            _rtcEngine.SetChannelProfile(CHANNEL_PROFILE_TYPE.CHANNEL_PROFILE_LIVE_BROADCASTING);
            _rtcEngine.SetClientRole(CLIENT_ROLE_TYPE.CLIENT_ROLE_BROADCASTER);
            if (Application.platform == RuntimePlatform.VisionOS)
            {
                _rtcEngine.SetParameters("che.audio.restartWhenInterrupted", true);
            }
        }
#endif


#if USE_AGORA_OFFICIAL || UNITY_EDITOR
        private class UserEventHandler : IRtcEngineEventHandler
        {
            private readonly AgoraOfficialSDKProvider audioSample;


            internal UserEventHandler(AgoraOfficialSDKProvider _audioSample)
            {
                this.audioSample = _audioSample;
            }

            public override void OnError(int _err, string _msg)
            {
                Debug.LogError($"OnError err: {_err}, msg: {_msg}");
            }

            public override async void OnJoinChannelSuccess(RtcConnection _connection, int _elapsed)
            {
                int tmp_Build = 0;
                Debug.Log($"sdk version: ${audioSample._rtcEngine.GetVersion(ref tmp_Build)}");
                Debug.Log($"OnJoinChannelSuccess->{_connection.localUid},{_connection.channelId}");
                AddParticipant(_connection.localUid);
            }

            public override void OnRejoinChannelSuccess(RtcConnection _connection, int _elapsed)
            {
                Debug.Log("OnRejoinChannelSuccess");
            }

            public override void OnLeaveChannel(RtcConnection _connection, RtcStats _stats)
            {
                Debug.Log("OnLeaveChannel");
            }

            public override void OnClientRoleChanged(RtcConnection _connection, CLIENT_ROLE_TYPE _oldRole,
                CLIENT_ROLE_TYPE _newRole, ClientRoleOptions _newRoleOptions)
            {
                Debug.Log("OnClientRoleChanged");
            }

            public override void OnUserJoined(RtcConnection _connection, uint _uid, int _elapsed)
            {
                Debug.Log($"OnUserJoined uid: ${_uid} elapsed: ${_elapsed}");
                if (audioSample._participantList.Contains(_uid)) return;
                AddParticipant(_uid);
            }

            public override void OnUserOffline(RtcConnection _connection, uint _uid, USER_OFFLINE_REASON_TYPE _reason)
            {
                var tmp_Participant =
                    audioSample._voiceParticipants.Find(_participant => _participant.DisplayName == _uid.ToString());
                if (tmp_Participant != null)
                    audioSample._voiceParticipants.Remove(tmp_Participant);
                Debug.Log($"OnUserOffLine uid: ${_uid}, reason: ${(int) _reason}");
            }

            public override void OnUserInfoUpdated(uint _uid, UserInfo _info)
            {
                if (audioSample._participantList.Contains(_uid)) return;
                AddParticipant(_uid);
            }


            public override void OnLocalUserRegistered(uint _uid, string _userAccount)
            {
                if (audioSample._participantList.Contains(_uid)) return;
                audioSample._participantList.Add(_uid);
            }

            public override void OnAudioPublishStateChanged(string _channel, STREAM_PUBLISH_STATE _oldState,
                STREAM_PUBLISH_STATE _newState,
                int _elapseSinceLastState)
            {
                Debug.Log($"{_channel}->{_oldState}:{_newState}-{_elapseSinceLastState}");
            }

            private void NotificationSender(string _action, BaseNotificationData _data)
            {
                ActionNotificationCenter.DefaultCenter.PostNotification(_action, _data);
            }

            private void AddParticipant(uint _remoteUid)
            {
                var tmp_VoiceParticipant = new VoiceParticipant
                {
                    UserId = _remoteUid.ToString(),
                    DisplayName = _remoteUid.ToString(),
                };

                var tmp_Participant =
                    audioSample._voiceParticipants.Find(_participant =>
                        _participant.UserId == _remoteUid.ToString());
                if (tmp_Participant != null) return;
                audioSample._voiceParticipants.Add(tmp_VoiceParticipant);
                audioSample._participantList.Add(_remoteUid);
                NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY, new VoiceNotificationDataArgs()
                {
                    VoiceParticipant = tmp_VoiceParticipant,
                    VoiceNotificationKey = VoiceNotificationKey.OnParticipantAdded
                });
            }
        }
#endif
    }
}
#endif
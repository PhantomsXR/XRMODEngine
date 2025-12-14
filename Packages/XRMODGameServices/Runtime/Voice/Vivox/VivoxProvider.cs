#if USE_VIVOX
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Phantom.XRMOD.ActionNotification.Runtime;
using Unity.Services.Authentication;
using Unity.Services.Vivox;
using UnityEngine;
using UnityEngine.Assertions;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public class VivoxProvider : IVoiceProvider, ITextMessage
    {
        private string joinedChannelName;
        private List<VivoxParticipant> vivoxParticipants = new();
        private readonly List<VoiceParticipant> voiceParticipants = new();
        private bool isInitialized;
        private Voice3DProperties voice3DProperties;
        private MonoBehaviour coroutineBehaviour;
        private IEnumerator updateParticipantList;

        // private int currentRetryCount = 3; // Counter for the current number of attempts
        private CancellationTokenSource cancellationTokenSource;

        public async void Initialize(string _configuration, Voice3DProperties _voice3DProperties)
        {
            if (isInitialized) return;
            coroutineBehaviour = Object.FindAnyObjectByType<XRMODGameServicesManager>();
            updateParticipantList = UpdateParticipantList();
            voice3DProperties = _voice3DProperties;
            VivoxService.Instance.ParticipantAddedToChannel += OnParticipantAdded;
            VivoxService.Instance.ParticipantRemovedFromChannel += OnParticipantRemoved;
            VivoxService.Instance.AvailableInputDevicesChanged += OnAvailableInputDevicesChanged;
            VivoxService.Instance.EffectiveInputDeviceChanged += OnEffectiveInputDeviceChanged;
            VivoxService.Instance.AvailableOutputDevicesChanged += OnAvailableOutputDevicesChanged;
            VivoxService.Instance.EffectiveOutputDeviceChanged += OnEffectiveOutputDeviceChanged;
            VivoxService.Instance.ConnectionRecovering += OnConnectionRecovering;
            VivoxService.Instance.ConnectionRecovered += OnConnectionRecovered;
            VivoxService.Instance.ConnectionFailedToRecover += OnConnectionFailedToRecover;
            VivoxService.Instance.ChannelJoined += OnChannelJoined;
            VivoxService.Instance.ChannelLeft += OnChannelLeft;
            VivoxService.Instance.ChannelMessageReceived += OnChannelMessageReceived;
            VivoxService.Instance.ChannelMessageEdited += OnChannelMessageEdited;
            VivoxService.Instance.ChannelMessageDeleted += OnChannelMessageDeleted;
            VivoxService.Instance.DirectedMessageReceived += OnDirectedMessageReceived;
            VivoxService.Instance.DirectedMessageDeleted += OnDirectedMessageDeleted;
            VivoxService.Instance.DirectedMessageEdited += OnDirectedMessageEdited;

            VivoxService.Instance.LoggedIn += LoggedIn;
            VivoxService.Instance.LoggedOut += LoggedOut;

            await VivoxService.Instance.InitializeAsync();
            await LoginToVivox();

            coroutineBehaviour.StartCoroutine(updateParticipantList);
            isInitialized = true;

            Debug.Log("Voice System Initialized");
        }


        public async void DeInitialize()
        {
            coroutineBehaviour.StopCoroutine(updateParticipantList);
            await VivoxService.Instance.LogoutAsync();
        }

        private void OnDirectedMessageEdited(VivoxMessage _obj)
        {
            NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY, new VoiceNotificationDataArgs
            {
                VoiceEventKey = VoiceNotificationKey.OnDirectedMessageEdited,
                Message = WrapMessage(_obj)
            });
        }


        private void OnDirectedMessageDeleted(VivoxMessage _obj)
        {
            NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY, new VoiceNotificationDataArgs
            {
                VoiceEventKey = VoiceNotificationKey.OnDirectedMessageDeleted,
                Message = WrapMessage(_obj)
            });
        }

        private void OnDirectedMessageReceived(VivoxMessage _obj)
        {
            NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY, new VoiceNotificationDataArgs
            {
                VoiceEventKey = VoiceNotificationKey.OnDirectedMessageReceived,
                Message = WrapMessage(_obj)
            });
        }

        private void OnChannelMessageDeleted(VivoxMessage _obj)
        {
            NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY, new VoiceNotificationDataArgs
            {
                VoiceEventKey = VoiceNotificationKey.OnChannelMessageDeleted,
                Message = WrapMessage(_obj)
            });
        }

        private void OnChannelMessageEdited(VivoxMessage _obj)
        {
            NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY, new VoiceNotificationDataArgs
            {
                VoiceEventKey = VoiceNotificationKey.OnChannelMessageEdited,
                Message = WrapMessage(_obj)
            });
        }

        private void OnChannelMessageReceived(VivoxMessage _obj)
        {
            NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY, new VoiceNotificationDataArgs
            {
                VoiceEventKey = VoiceNotificationKey.OnChannelMessageReceived,
                Message = WrapMessage(_obj)
            });
        }

        private void OnChannelLeft(string _obj)
        {
            NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY, new VoiceNotificationDataArgs
            {
                VoiceEventKey = VoiceNotificationKey.OnChannelLeft,
                BaseData = _obj
            });
        }

        private void OnChannelJoined(string _obj)
        {
            NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY, new VoiceNotificationDataArgs
            {
                VoiceEventKey = VoiceNotificationKey.OnChannelJoined,
                BaseData = _obj
            });
        }

        private void OnConnectionFailedToRecover()
        {
            NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY,
                new VoiceNotificationDataArgs
                {
                    VoiceEventKey = VoiceNotificationKey.OnConnectionFailedToRecover
                });
        }

        private void OnConnectionRecovered()
        {
            NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY, new VoiceNotificationDataArgs
            {
                VoiceEventKey = VoiceNotificationKey.OnConnectionRecovered
            });
        }

        private void OnConnectionRecovering()
        {
            NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY, new VoiceNotificationDataArgs
            {
                VoiceEventKey = VoiceNotificationKey.OnConnectionRecovering
            });
        }

        private void OnEffectiveOutputDeviceChanged()
        {
            NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY,
                new VoiceNotificationDataArgs
                {
                    VoiceEventKey = VoiceNotificationKey.OnEffectiveOutputDeviceChanged
                });
        }

        private void OnAvailableOutputDevicesChanged()
        {
            NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY,
                new VoiceNotificationDataArgs
                {
                    VoiceEventKey = VoiceNotificationKey.OnAvailableOutputDevicesChanged
                });
        }

        private void OnEffectiveInputDeviceChanged()
        {
            NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY,
                new VoiceNotificationDataArgs
                {
                    VoiceEventKey = VoiceNotificationKey.OnEffectiveInputDeviceChanged
                });
        }

        private void OnAvailableInputDevicesChanged()
        {
            NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY,
                new VoiceNotificationDataArgs
                {
                    VoiceEventKey = VoiceNotificationKey.OnAvailableInputDevicesChanged
                });
        }

        private void OnParticipantRemoved(VivoxParticipant _vivoxParticipant)
        {
            if (!vivoxParticipants.Contains(_vivoxParticipant)) return;
            var tmp_WrapParticipant = WrapParticipant(_vivoxParticipant);
            vivoxParticipants.Remove(_vivoxParticipant);
            voiceParticipants.Remove(tmp_WrapParticipant);
            NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY, new VoiceNotificationDataArgs()
            {
                VoiceParticipant = tmp_WrapParticipant,
                VoiceEventKey = VoiceNotificationKey.OnParticipantRemoved
            });
        }

        private void OnParticipantAdded(VivoxParticipant _vivoxParticipant)
        {
            if (vivoxParticipants.Contains(_vivoxParticipant)) return;
            var tmp_WrapParticipant = WrapParticipant(_vivoxParticipant);
            vivoxParticipants.Add(_vivoxParticipant);
            voiceParticipants.Add(tmp_WrapParticipant);
            NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY, new VoiceNotificationDataArgs()
            {
                VoiceParticipant = tmp_WrapParticipant,
                VoiceEventKey = VoiceNotificationKey.OnParticipantAdded
            });
        }


        public async void JoinVoiceChannel(string _channelName, JoinChannelType _joinChannelType)
        {
            joinedChannelName = _channelName;
            switch (_joinChannelType)
            {
                case JoinChannelType.Group:
                    await VivoxService.Instance.JoinGroupChannelAsync(_channelName, ChatCapability.TextAndAudio);
                    break;
                case JoinChannelType.Echo:
                    await VivoxService.Instance.JoinEchoChannelAsync(_channelName, ChatCapability.TextAndAudio);
                    break;
                case JoinChannelType.Positional:
                    Assert.IsNotNull(voice3DProperties, "Voice 3D properties not set");
                    Channel3DProperties tmp_Props = new Channel3DProperties(voice3DProperties.AudibleDistance,
                        voice3DProperties.ConversationalDistance, voice3DProperties.AudioFadeIntensityByDistance,
                        (AudioFadeModel) voice3DProperties.AudioFadeModel);
                    await VivoxService.Instance.JoinPositionalChannelAsync(_channelName, ChatCapability.AudioOnly,
                        tmp_Props);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(_joinChannelType), _joinChannelType, null);
            }
        }

        public async void LeaveVoiceChannel()
        {
            await VivoxService.Instance.LeaveChannelAsync(joinedChannelName);
            joinedChannelName = null;
        }

        public void CreateVoiceChannel(string _channelName, JoinChannelType _joinChannelType)
        {
            JoinVoiceChannel(_channelName, _joinChannelType);
        }

        public void MuteSelfMicrophone(bool _muted)
        {
            if (_muted)
                VivoxService.Instance.MuteInputDevice();
            else
                VivoxService.Instance.UnmuteInputDevice();
        }

        public void MuteOtherMicrophone(bool _muted, string _channleName, string _userName)
        {
            var tmp_VivoxParticipant = VivoxService.Instance.ActiveChannels[_channleName]
                .First(_participant => _participant.PlayerId == _userName);
            if (_muted)
                tmp_VivoxParticipant.MutePlayerLocally();
            else
                tmp_VivoxParticipant.UnmutePlayerLocally();
        }

        public void BlockUser(bool _block, string _channelName, string _userName)
        {
            if (_block)
                VivoxService.Instance.BlockPlayerAsync(_userName);
            else
                VivoxService.Instance.UnblockPlayerAsync(_userName);
        }

        public List<VoiceParticipant> GetParticipants()
        {
            return voiceParticipants;
        }

        public VoiceParticipant GetParticipant(string _userId)
        {
            return voiceParticipants.Find(_participant =>
                _participant.DisplayName == _userId || _participant.UserId == _userId);
        }


        #region Text Message

        public async Task SendDirectTextMessage(string _userId, string _message)
        {
            await VivoxService.Instance.SendDirectTextMessageAsync(_userId, _message);
        }

        public async Task<List<TextMessage>> FetchDirectTextMessageHistory(string _userId)
        {
            List<TextMessage> tmp_HistoryTextMessages = new();
            var tmp_HistoryMessages = await VivoxService.Instance.GetDirectTextMessageHistoryAsync(_userId, 10);
            foreach (VivoxMessage tmp_Message in tmp_HistoryMessages)
            {
                tmp_HistoryTextMessages.Add(WrapMessage(tmp_Message));
            }

            return tmp_HistoryTextMessages;
        }

        public async Task EditDirectedTextMessage(TextMessage _message, string _editedMessageText)
        {
            await VivoxService.Instance.EditDirectTextMessageAsync(_message.MessageId, _editedMessageText);
        }

        public async Task DeletingDirectTextMessage(string _messageId)
        {
            await VivoxService.Instance.DeleteDirectTextMessageAsync(_messageId);
        }

        #endregion


        #region Helper

        private void NotificationSender(string _action, BaseNotificationData _data)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(_action, _data);
        }

        private VoiceParticipant WrapParticipant(VivoxParticipant _vivoxParticipant)
        {
            var tmp_VoiceParticipant = new VoiceParticipant
            {
                DisplayName = _vivoxParticipant.DisplayName,
                UserId = _vivoxParticipant.PlayerId,
                URI = _vivoxParticipant.URI,
                ChannelName = _vivoxParticipant.ChannelName,
                ChannelURI = _vivoxParticipant.ChannelURI,
                SpeechDetected = _vivoxParticipant.SpeechDetected,
                IsMuted = _vivoxParticipant.IsMuted,
                IsSelf = _vivoxParticipant.IsSelf,
                LocalVolume = _vivoxParticipant.LocalVolume,
                AudioEnergy = _vivoxParticipant.AudioEnergy,
            };

            _vivoxParticipant.ParticipantSpeechDetected += () =>
            {
                tmp_VoiceParticipant.SpeechDetected = _vivoxParticipant.SpeechDetected;
                tmp_VoiceParticipant.OnParticipantSpeechDetected();
            };
            _vivoxParticipant.ParticipantMuteStateChanged += () =>
            {
                tmp_VoiceParticipant.IsMuted = _vivoxParticipant.IsMuted;
                tmp_VoiceParticipant.OnParticipantMuteStateChanged();
            };
            _vivoxParticipant.ParticipantAudioEnergyChanged += () =>
            {
                tmp_VoiceParticipant.AudioEnergy = _vivoxParticipant.AudioEnergy;
                tmp_VoiceParticipant.OnParticipantAudioEnergyChanged();
            };

            tmp_VoiceParticipant.OnSetOutputVolume = VivoxService.Instance.SetOutputDeviceVolume;

            tmp_VoiceParticipant.OnSetLocalVolume = _vivoxParticipant.SetLocalVolume;
            tmp_VoiceParticipant.OnMuteUserLocally = tmp_VoiceParticipant.OnMuteUserLocally;
            tmp_VoiceParticipant.OnUnmuteUserLocally = tmp_VoiceParticipant.OnUnmuteUserLocally;
            return tmp_VoiceParticipant;
        }


        private TextMessage WrapMessage(VivoxMessage _vivoxMessage)
        {
            var tmp_TextMessage = new TextMessage
            {
                MessageText = _vivoxMessage.MessageText,
                ChannelName = _vivoxMessage.ChannelName,
                MessageId = _vivoxMessage.MessageId,
                ReceivedTime = _vivoxMessage.ReceivedTime,
                FromSelf = _vivoxMessage.FromSelf,
                Language = _vivoxMessage.Language,
                IsRead = _vivoxMessage.IsRead,
                IsTranscribedMessage = _vivoxMessage.IsTranscribedMessage,
                RecipientPlayerId = _vivoxMessage.RecipientPlayerId,
                SenderDisplayName = _vivoxMessage.SenderDisplayName,
                SenderPlayerId = _vivoxMessage.SenderPlayerId,
                OnSetMessageAsReadAsync = _vivoxMessage.SetMessageAsReadAsync
            };
            return tmp_TextMessage;
        }

        private async Task LoginToVivox()
        {
            try
            {
                LoginOptions tmp_Options = new LoginOptions
                {
                    DisplayName = AuthenticationSystemManager.GetUserInfo().player_name,
                    PlayerId = AuthenticationService.Instance.PlayerId,
                    EnableTTS = true,
                    ParticipantUpdateFrequency = ParticipantPropertyUpdateFrequency.TenPerSecond,
                };

                if (VivoxService.Instance.IsLoggedIn) return;

                await VivoxService.Instance.LoginAsync(tmp_Options);
            }
            catch (Exception tmp_Exception)
            {
                NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY, new VoiceNotificationDataArgs
                {
                    VoiceEventKey = VoiceNotificationKey.OnLoginFailed
                });
            }
        }

        private void LoggedOut()
        {
            NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY, new VoiceNotificationDataArgs
            {
                VoiceEventKey = VoiceNotificationKey.OnLoggedOut
            });
        }

        private void LoggedIn()
        { 
            if (cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
                cancellationTokenSource.Dispose();
                cancellationTokenSource = null;
            }

            NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY, new VoiceNotificationDataArgs
            {
                VoiceEventKey = VoiceNotificationKey.OnLogged
            });
        }

        private IEnumerator UpdateParticipantList()
        {
            while (true)
            {
                for (int tmp_Idx = 0; tmp_Idx < vivoxParticipants.Count; tmp_Idx++)
                {
                    voiceParticipants[tmp_Idx].AudioEnergy = vivoxParticipants[tmp_Idx].AudioEnergy;
                    voiceParticipants[tmp_Idx].SpeechDetected = vivoxParticipants[tmp_Idx].SpeechDetected;
                    voiceParticipants[tmp_Idx].IsMuted = vivoxParticipants[tmp_Idx].IsMuted;
                    voiceParticipants[tmp_Idx].LocalVolume = vivoxParticipants[tmp_Idx].LocalVolume;
                    voiceParticipants[tmp_Idx].IsSelf = vivoxParticipants[tmp_Idx].IsMuted;
                }

                yield return null;
            }
        }

        #endregion
    }
}

#endif
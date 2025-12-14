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

using System;
using System.Collections.Generic;
using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEngine;
using UnityEngine.Networking;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public static class AgoraUtility
    {
        private const string _CONST_GENERATE_API_GATEWAY = "https://phantomsxr.com/api/v2/client/getagoratoken";

        /// <summary>
        /// Request a token with the channel name.
        /// </summary>
        /// <param name="_channelName">Will join channel's name</param>
        internal static void RequestNewToken(string _channelName, string _userAccount,
            Action<string> _onSucessed = null)
        {
            var tmp_SafeUserName = _userAccount.Split("#")[1]; //userAccount.Replace("#", "-");
            string tmp_EncodedString =
                $"{_CONST_GENERATE_API_GATEWAY}?channel_name={_channelName}&user_info={tmp_SafeUserName}";
            var tmp_UWebRequest = UnityWebRequest.Get(tmp_EncodedString);
            tmp_UWebRequest.SendWebRequest().completed += _operation =>
            {
                switch (tmp_UWebRequest.result)
                {
                    case UnityWebRequest.Result.ConnectionError:
                    case UnityWebRequest.Result.ProtocolError:
                    case UnityWebRequest.Result.DataProcessingError:
                        Debug.LogError(tmp_UWebRequest.error);
                        break;
                    case UnityWebRequest.Result.Success:
                        var tmp_WebResponse = JsonUtility.FromJson<WebResponse>(tmp_UWebRequest.downloadHandler.text);
                        _onSucessed?.Invoke(tmp_WebResponse.data.token);
                        break;
                    default:
                        Debug.LogError("Unknown error");
                        break;
                }
            };
        }


        internal static void AddParticipant(uint _remoteUid, ref List<VoiceParticipant> _voiceParticipants)
        {
            // In here remoteUid is uint type, not username#1234
            var tmp_VoiceParticipant = new VoiceParticipant
            {
                UserId = _remoteUid.ToString(),
                DisplayName = _remoteUid.ToString()
            };

            var tmp_Participant = _voiceParticipants.Find(_participant => _participant.UserId == _remoteUid.ToString());
            if (tmp_Participant != null) return;
            _voiceParticipants.Add(tmp_VoiceParticipant);
            NotificationSender(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY, new VoiceNotificationDataArgs()
            {
                VoiceParticipant = tmp_VoiceParticipant,
                VoiceEventKey = VoiceNotificationKey.OnParticipantAdded
            });
        }


        internal static void NotificationSender(string _action, BaseNotificationData _data)
        {
            ActionNotificationCenter.DefaultCenter.PostNotification(_action, _data);
        }
    }
}
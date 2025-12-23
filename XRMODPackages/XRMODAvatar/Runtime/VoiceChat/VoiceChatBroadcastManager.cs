// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODAvatar.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.GameServices.Runtime;
using Unity.Netcode;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.XRMODAvatar.Runtime
{
    /// <summary>
    /// Distributes voice chat events (like participant joined/removed) to the relevant networked players.
    /// </summary>
    public class VoiceChatBroadcastManager : MonoBehaviour
    {
        private void Awake()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(OnVoiceEvent,
                VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY);
        }

        private void OnDestroy()
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(VoiceModuleNotifyActionKey.CONST_VOICE_EVENT_KEY,
                OnVoiceEvent);
        }


        private void OnVoiceEvent(BaseNotificationData _obj)
        {
            if (_obj is not VoiceNotificationDataArgs tmp_Args) return;
            switch (tmp_Args.VoiceEventKey)
            {
                case VoiceNotificationKey.OnParticipantAdded:
                    if (tmp_Args.VoiceParticipant.IsSelf)
                    {
                        var tmp_LocalPlayerObj = NetworkManager.Singleton.LocalClient.PlayerObject;
                        var tmp_PlayerVoiceChat = tmp_LocalPlayerObj.GetComponent<PlayerVoiceChat>();
                        tmp_PlayerVoiceChat.SetVoiceId(tmp_Args.VoiceParticipant.DisplayName);
                    }
                    else
                    {
                        foreach (PlayerVoiceChat tmp_PlayerVoiceChat in Object.FindObjectsByType<PlayerVoiceChat>(
                                     FindObjectsInactive.Include,
                                     FindObjectsSortMode.None))
                        {
                            if (tmp_PlayerVoiceChat.GetPlayerVoiceId == tmp_Args.VoiceParticipant.DisplayName)
                            {
                                tmp_PlayerVoiceChat.SetUpPlayerVoice();
                            }
                        }
                    }

                    break;
                case VoiceNotificationKey.OnParticipantRemoved:
                    break;
            }
        }
    }
}
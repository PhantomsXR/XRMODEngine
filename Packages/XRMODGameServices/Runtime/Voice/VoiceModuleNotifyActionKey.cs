// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.VoiceModule.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.ActionNotification.Runtime;
using UnityEngine.Serialization;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public enum VoiceNotificationKey
    {
        OnParticipantAdded,
        OnParticipantRemoved,
        OnDirectedMessageEdited,
        OnDirectedMessageDeleted,
        OnDirectedMessageReceived,
        OnChannelMessageDeleted,
        OnChannelMessageEdited,
        OnChannelMessageReceived,
        OnChannelLeft,
        OnChannelJoined,
        OnConnectionFailedToRecover,
        OnConnectionRecovered,
        OnConnectionRecovering,
        OnEffectiveOutputDeviceChanged,
        OnAvailableOutputDevicesChanged,
        OnEffectiveInputDeviceChanged,
        OnAvailableInputDevicesChanged,
        OnLoginFailed,
        OnLogged,
        OnLoggedOut,
    }

    public class VoiceModuleNotifyActionKey
    {
        public const string CONST_VOICE_EVENT_KEY = "OnVoiceEvent";

        internal const string CONST_ON_PARTICIPANT_REMOVED = "OnParticipantRemoved";
        internal const string CONST_ON_DIRECTED_MESSAGE_EDITED = "OnDirectedMessageEdited";
        internal const string CONST_ON_DIRECTED_MESSAGE_DELETED = "OnDirectedMessageDeleted";
        internal const string CONST_ON_DIRECTED_MESSAGE_RECEIVED = "OnDirectedMessageReceived";
        internal const string CONST_ON_CHANNEL_MESSAGE_DELETED = "OnChannelMessageDeleted";
        internal const string CONST_ON_CHANNEL_MESSAGE_EDITED = "OnChannelMessageEdited";
        internal const string CONST_ON_CHANNEL_MESSAGE_RECEIVED = "OnChannelMessageReceived";
        internal const string CONST_ON_CHANNEL_LEFT = "OnChannelLeft";
        internal const string CONST_ON_CHANNEL_JOINED = "OnChannelJoined";
        internal const string CONST_ON_CONNECTION_FAILED_TO_RECOVER = "OnConnectionFailedToRecover";
        internal const string CONST_ON_CONNECTION_RECOVERED = "OnConnectionRecovered";
        internal const string CONST_ON_CONNECTION_RECOVERING = "OnConnectionRecovering";
        internal const string CONST_ON_EFFECTIVE_OUTPUT_DEVICE_CHANGED = "OnEffectiveOutputDeviceChanged";
        internal const string CONST_ON_AVAILABLE_OUTPUT_DEVICES_CHANGED = "OnAvailableOutputDevicesChanged";
        internal const string CONST_ON_EFFECTIVE_INPUT_DEVICE_CHANGED = "OnEffectiveInputDeviceChanged";
        internal const string CONST_ON_AVAILABLE_INPUT_DEVICES_CHANGED = "OnAvailableInputDevicesChanged";
        internal const string CONST_ON_PARTICIPANT_ADDED = "OnParticipantAdded";
    }


    public class VoiceNotificationDataArgs : BaseNotificationData
    {
        public VoiceParticipant VoiceParticipant;
        public TextMessage Message;
        public VoiceNotificationKey VoiceEventKey;
    }
}
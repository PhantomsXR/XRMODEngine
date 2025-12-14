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

using System;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public class VoiceParticipant
    {
        /// <summary>
        /// An event that fires if the mute state of the participant changes.
        /// </summary>
        public Action ParticipantMuteStateChanged;

        /// <summary>
        /// An event that fires if the Participant's speech detected status changes.
        /// </summary>
        public Action ParticipantSpeechDetected;

        /// <summary>
        /// An event that fires if the Participants audio energy changes.
        /// </summary>
        public Action ParticipantAudioEnergyChanged;

        /// <summary>
        /// The DisplayName of the participant.
        /// </summary>
        public string DisplayName;

        /// <summary>
        /// The UserId and unique identifier of a Vivox channel participant.
        /// This will be either a Unity Authentication Service UserId if the Authentication package is in use, or a unique GUID assigned by Vivox during the account creation process.
        /// </summary>
        public string UserId;

        /// <summary>
        /// The Vivox universal resource identifier of this participant.
        /// </summary>
        public string URI;

        /// <summary>
        /// The unique identifier of the channel that this participant is associated with.
        /// </summary>
        public string ChannelName;

        /// <summary>
        /// The universal resource identifier of the channel this participant is associated with.
        /// </summary>
        public string ChannelURI;

        /// <summary>
        /// Whether or not the AudioEnergy has surpassed the threshold to be considered speech.
        /// </summary>
        public bool SpeechDetected;

        /// <summary>
        /// Whether or not this participant is muted.
        /// </summary>
        public bool IsMuted;

        /// <summary>
        /// Whether or not this participant is the logged in user.
        /// </summary>
        public bool IsSelf;

        /// <summary>
        /// The volume of a participant only for the local user in a given channel.
        /// </summary>
        public int LocalVolume;

        /// <summary>
        /// The AudioEnergy of the participant.
        /// This can be used to create a voice activity meter for participants in a channel.
        /// </summary>
        public double AudioEnergy;

        public void SetLocalVolume(int _volume)
        {
            OnSetLocalVolume?.Invoke(_volume);
        }

        public void SetOutputVolume(int _volume)
        {
            OnSetOutputVolume?.Invoke(_volume);
        }

        public void MuteUserLocally()
        {
            OnMuteUserLocally?.Invoke();
        }

        public void UnmuteUserLocally()
        {
            OnUnmuteUserLocally?.Invoke();
        }


        internal void OnParticipantMuteStateChanged()
        {
            ParticipantMuteStateChanged?.Invoke();
        }

        internal void OnParticipantSpeechDetected()
        {
            ParticipantSpeechDetected?.Invoke();
        }

        internal void OnParticipantAudioEnergyChanged()
        {
            ParticipantAudioEnergyChanged?.Invoke();
        }

        internal Action<int> OnSetLocalVolume;
        internal Action<int> OnSetOutputVolume;
        internal Action OnMuteUserLocally;
        internal Action OnUnmuteUserLocally;
    }
}
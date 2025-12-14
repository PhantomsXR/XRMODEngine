// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the VoiceManager.Runtime.
// //
// // The Nin1 cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

#if USE_PHOTON_VOICE
using System.Threading.Tasks;
using Photon.Voice.Unity;
using UnityEngine;
using System.Collections.Generic;

namespace Phantom.XRMOD.GameServices.Runtime
{
    public class PhotonVoiceProvider : IVoiceProvider
    {
        private Recorder recorder;
        private readonly List<VoiceParticipant> voiceParticipants = new();

        private void InitializeComponents()
        {
            if (!recorder)
                recorder = Object.FindObjectOfType<Recorder>();
        }

        public async Task Initialize()
        {
            await Task.Yield();
            InitializeComponents();
        }

        public void Initialize(string _configuration, Voice3DProperties _voice3DProperties)
        {
            
        }

        public void DeInitialize()
        {
        }

        public void JoinVoiceChannel(string _channelName, JoinChannelType _joinChannelType)
        {
            InitializeComponents();
            recorder.RecordingEnabled = true;
            recorder.TransmitEnabled = true;
        }

        public void LeaveVoiceChannel()
        {
            InitializeComponents();
            recorder.RecordingEnabled = false;
            recorder.TransmitEnabled = false;
        }

        public void CreateVoiceChannel(string _channelName, JoinChannelType _joinChannelType)
        {
            InitializeComponents();
            JoinVoiceChannel(_channelName, _joinChannelType);
        }

        public void MuteSelfMicrophone(bool _muted)
        {
            InitializeComponents();
            recorder.RecordingEnabled = _muted;
            recorder.TransmitEnabled = _muted;
        }

        public void MuteOtherMicrophone(bool _muted, string _channleId, string _userId)
        {
        }

        public void BlockUser(bool _block, string _channelId, string _userId)
        {
        }

        public void MuteOtherMicrophone(bool _muted, string _userId)
        {
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
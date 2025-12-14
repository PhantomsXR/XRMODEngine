// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.GameServices.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine.Serialization;

namespace Phantom.XRMOD.GameServices.Runtime
{
    /// <summary>
    /// The distance model for a positional channel, which determines the algorithm to use when computing attenuation.
    /// </summary>
    public enum VoiceAudioFadeModel
    {
        /// <summary>
        /// Fades voice quickly at first, buts slows down as you get further from conversational distance.
        /// </summary>
        InverseByDistance = 1,

        /// <summary>
        /// Fades voice slowly at first, but speeds up as you get further from conversational distance.
        /// </summary>
        LinearByDistance = 2,

        /// <summary>
        /// Voice within conversational distance is louder, but fades quickly beyond it.
        /// </summary>
        ExponentialByDistance = 3
    }

    [System.Serializable]
    public class Voice3DProperties
    {
        public int AudibleDistance = 50;
        public int ConversationalDistance = 1;
        public float AudioFadeIntensityByDistance = 1f;
        public VoiceAudioFadeModel AudioFadeModel = VoiceAudioFadeModel.ExponentialByDistance;
    }
}
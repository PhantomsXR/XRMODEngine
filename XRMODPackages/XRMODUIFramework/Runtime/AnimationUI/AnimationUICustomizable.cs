// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UIExtension.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;

namespace Phantom.XRMOD.UIFramework.Runtime
{
    public static class AnimationUICustomizable
    {
        public static void SetActiveAllInput(bool _isActivating)
        {
            Debug.Log("Set Active All Input");
            // Please modify this line to use your own Singleton class.
            // Singleton.Instance.Game.SetActiveAllInput(isActivating);
        }

        public static void PlaySound(AudioClip _sfxFile)
        {
            Debug.Log("SFX by file");
            // Please modify this line to use your own Singleton class.
            // Singleton.Instance.Audio.PlaySound(_SFXFile);
        }

        public static void PlaySound(int _index)
        {
            Debug.Log("SFX by index");
            // Please modify this line to use your own Singleton class.
            // Singleton.Instance.Audio.PlaySound(_index);
        }
    }
}
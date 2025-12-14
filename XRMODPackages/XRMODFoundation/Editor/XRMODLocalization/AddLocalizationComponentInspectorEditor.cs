// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODLocalization.Editor.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.Localization.Runtime;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace Phantom.XRMOD.Localization.Editor
{
    public class AddLocalizationComponentInspectorEditor : UnityEditor.Editor
    {
        [MenuItem("CONTEXT/TextMeshProUGUI/Localized/Add Localization Component")]
        private static void AddLocalizationForTextMeshProUGUI(MenuCommand _command)
        {
            if (_command.context is not TextMeshProUGUI tmp_Context) return;
            var tmp_LocalizationComp = tmp_Context.gameObject.AddComponent<LocalizedTextWithArgs>();
            tmp_LocalizationComp.LocalizationKey = tmp_Context.text;
        }


        [MenuItem("CONTEXT/Text/Localized/Add Localization Component")]
        private static void AddLocalizationForUGUIText(MenuCommand _command)
        {
            if (_command.context is not Text tmp_Context) return;
            var tmp_LocalizationComp = tmp_Context.gameObject.AddComponent<LocalizedTextWithArgs>();
            tmp_LocalizationComp.LocalizationKey = tmp_Context.text;
        }


        [MenuItem("CONTEXT/TextMeshPro/Localized/Add Localization Component")]
        private static void AddLocalizationForTextMeshPro(MenuCommand _command)
        {
            if (_command.context is not TextMeshPro tmp_Context) return;
            var tmp_LocalizationComp = tmp_Context.gameObject.AddComponent<LocalizedTextWithArgs>();
            tmp_LocalizationComp.LocalizationKey = tmp_Context.text;
        }


        [MenuItem("CONTEXT/AudioSource/Localized/Add Localization Component")]
        private static void AddLocalizationForAudioSource(MenuCommand _command)
        {
            if (_command.context is not AudioSource tmp_Context) return;
            tmp_Context.gameObject.AddComponent<LocalizedAudio>();
        }

        [MenuItem("CONTEXT/Renderer/Localized/Add Localization Component")]
        private static void AddLocalizationForRenderer(MenuCommand _command)
        {
            if (_command.context is not Renderer tmp_Context) return;
            tmp_Context.gameObject.AddComponent<LocalizedRendererTexture>();
        }

        [MenuItem("CONTEXT/VideoPlayer/Localized/Add Localization Component")]
        private static void AddLocalizationForVideoPlayer(MenuCommand _command)
        {
            if (_command.context is not VideoPlayer tmp_Context) return;
            tmp_Context.gameObject.AddComponent<LocalizedVideo>();
        }

        [MenuItem("CONTEXT/Image/Localized/Add Localization Component")]
        private static void AddLocalizationForUIImage(MenuCommand _command)
        {
            if (_command.context is not Image tmp_Context) return;
            tmp_Context.gameObject.AddComponent<LocalizedImage>();
        }

        [MenuItem("CONTEXT/RawImage/Localized/Add Localization Component")]
        private static void AddLocalizationForUIRawImage(MenuCommand _command)
        {
            if (_command.context is not RawImage tmp_Context) return;
            tmp_Context.gameObject.AddComponent<LocalizedRawImage>();
        }

#if USE_AUDIO_MODULE
        [MenuItem("CONTEXT/AudioEmitter/Localized/Add Localization Component")]
        private static void AddLocalizationForAudioEmit(MenuCommand _command)
        {
            if (_command.context is not Phantom.XRMOD.AudioModule.Runtime.AudioEmitter tmp_Context) return;
            tmp_Context.gameObject.AddComponent<LocalizationAudioModuleComponent>();
        }
#endif
    }
}
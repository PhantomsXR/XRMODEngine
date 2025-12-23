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

using Phantom.XRMOD.GameServices.Runtime;
using Phantom.XRMOD.UIFramework.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

namespace Phantom.XRMOD.XRMODAvatar.PlayerNameTag
{
    /// <summary>
    /// Manages the floating name tag and voice chat indicators above a player's head.
    /// Handles billboard rotation towards the camera and updates based on player state.
    /// </summary>
    public class PlayerNameTag : MonoBehaviour
    {
        [SerializeField] private bool worldUp;


        [Header("Base UserInfo")] [SerializeField]
        private TMP_Text playerNameText;

        [SerializeField] private Image deviceIconImage;
        [SerializeField] private TextMeshProUGUI readyTextMeshProUGUI;
        [SerializeField] private GameObject gameObjectToHide;
        [SerializeField] private TimelinePlayController readyAnimator;

        [SerializeField] private float maxDistanceThreshold = 4.5f;
        [SerializeField] private float minDistanceThreshold = .5f;
        [SerializeField] private float nameTagOffsetHeight = .3f;


        [Header("Voice Chat")] [SerializeField]
        private Button microphoneMuteButton;

        [SerializeField] private Image voiceChatFillImage;
        [SerializeField] private Image microphoneIconImage;
        [SerializeField] private Sprite mutedSprite;
        [SerializeField] private Sprite unmutedSprite;
        [SerializeField] private GameObject connectingAnimObject;
        [SerializeField] private ParticleSystem[] voiceParticles;


        private Camera camera;
        private AvatarPlayerSharedData avatarPlayerSharedData;

        private bool emittingVoice;
        private bool isHidden;

        private void Awake()
        {
            camera = Camera.main;
            avatarPlayerSharedData = GetComponentInParent<AvatarPlayerSharedData>();
            Assert.IsNotNull(avatarPlayerSharedData, "AvatarPlayerStateData not found");


            avatarPlayerSharedData.selfMutedProperty.Subscribe(OnMicrophoneStateChanged);
            avatarPlayerSharedData.playerVoiceIdProperty.Subscribe(OnPlayerVoiceIdPropertyChanged);
            avatarPlayerSharedData.playerNameProperty.Subscribe(OnPlayerNameChanged);
            avatarPlayerSharedData.playerDeviceProperty.Subscribe(OnDeviceTypePropertyChanged);
            avatarPlayerSharedData.readyStateProperty.Subscribe(OnPlayerReadyStateChanged);
            microphoneMuteButton.onClick.AddListener(SquelchPressed);

            avatarPlayerSharedData.UpdateBatchOptimization.RegisterUpdate(DoBatchUpdate);
            avatarPlayerSharedData.UpdateBatchOptimization.RegisterLateUpdate(DoBatchLateUpdate);

            avatarPlayerSharedData.Player.OnSpawned.AddListener(OnSpawnedToSetup);

            connectingAnimObject.SetActive(true);
            gameObjectToHide.SetActive(false);
            microphoneMuteButton.interactable = false; 
        }

        private void OnPlayerReadyStateChanged(bool _obj)
        {
            readyTextMeshProUGUI.text = _obj ? "READY" : string.Empty;
            readyAnimator.Play();
        }

        private void OnSpawnedToSetup(bool _isOwner)
        { 
            if (_isOwner)
            {
                // Set the player name from local
                if (!AuthenticationSystemManager.IsSignedIn) return;
                var tmp_UserInfo = AuthenticationSystemManager.GetUserInfo();
                avatarPlayerSharedData.Player.SetPlayerName(tmp_UserInfo.player_name);
            }
            else
            {
                // Snapshot sync
                avatarPlayerSharedData.SyncSharedDataSnapshot();
                gameObjectToHide.SetActive(true);
            }
        }


        private void OnDestroy()
        {
            avatarPlayerSharedData.UpdateBatchOptimization.UnregisterUpdate(DoBatchUpdate);
            avatarPlayerSharedData.UpdateBatchOptimization.UnregisterLateUpdate(DoBatchLateUpdate);

            avatarPlayerSharedData.selfMutedProperty.Unsubscribe(OnMicrophoneStateChanged);
            avatarPlayerSharedData.playerVoiceIdProperty.Unsubscribe(OnPlayerVoiceIdPropertyChanged);
            avatarPlayerSharedData.playerNameProperty.Unsubscribe(OnPlayerNameChanged);
            avatarPlayerSharedData.playerDeviceProperty.Unsubscribe(OnDeviceTypePropertyChanged);
            avatarPlayerSharedData.readyStateProperty.Unsubscribe(OnPlayerReadyStateChanged);
        }

        private void DoBatchUpdate()
        {
            UpdateVoice(avatarPlayerSharedData.PlayerVoiceChat.GetVoiceAudioEnergy);
            UpdateMinimizedState();
        }

        private void DoBatchLateUpdate()
        {
            UpdatePosition();
            UpdateRotation();
        }

        private void UpdatePosition()
        {
            transform.position = avatarPlayerSharedData.GetHeadTransform.position + Vector3.up * nameTagOffsetHeight;
        }

        private void UpdateRotation()
        {
            var tmp_Dir = camera.transform.position - transform.position;
            if (tmp_Dir == Vector3.zero) return;
            Quaternion tmp_LookRot = Quaternion.LookRotation(tmp_Dir).normalized;
            if (tmp_LookRot == Quaternion.identity) return;
            if (worldUp)
            {
                Vector3 tmp_Offset = tmp_LookRot.eulerAngles;
                tmp_Offset.x = tmp_Offset.z = 0;
                tmp_LookRot = Quaternion.Euler(tmp_Offset);
            }

            transform.rotation = tmp_LookRot;
        }

        private void OnPlayerVoiceIdPropertyChanged(string _obj)
        {
            if (string.IsNullOrEmpty(_obj)) return;

            connectingAnimObject.SetActive(false);
            microphoneMuteButton.interactable = true;
        }

        private void OnDeviceTypePropertyChanged(string _obj)
        {
            if (string.IsNullOrEmpty(_obj)) return;
        }

        private void OnPlayerNameChanged(string _playerName)
        {
            if (string.IsNullOrEmpty(_playerName)) return;
            playerNameText.text = _playerName;
            playerNameText.rectTransform.sizeDelta =
                new Vector2(playerNameText.preferredWidth, playerNameText.rectTransform.sizeDelta.y);
        }

        private void SquelchPressed()
        {
            avatarPlayerSharedData.PlayerVoiceChat?.ToggleSquelch();
        }

        private void OnMicrophoneStateChanged(bool _isMuted)
        {
            microphoneIconImage.sprite = _isMuted ? mutedSprite : unmutedSprite;
        }


        private void UpdateVoice(float _energy)
        {
            voiceChatFillImage.fillAmount = _energy;
            switch (_energy)
            {
                case >= 0.001f when !emittingVoice:
                {
                    emittingVoice = true;
                    foreach (var tmp_VoiceParticle in voiceParticles)
                    {
                        var tmp_Emission = tmp_VoiceParticle.emission;
                        tmp_Emission.rateOverTime = Mathf.Lerp(1, 2, _energy);
                        tmp_VoiceParticle.Emit(1);
                        tmp_VoiceParticle.Play();
                    }

                    break;
                }
                case <= 0.001f when emittingVoice:
                {
                    emittingVoice = false;
                    foreach (var tmp_VoiceParticle in voiceParticles)
                    {
                        tmp_VoiceParticle.Stop(false, ParticleSystemStopBehavior.StopEmitting);
                    }

                    break;
                }
            }
        }

        private void UpdateMinimizedState()
        {
            var tmp_ViewerDistance = Vector3.Distance(transform.position, camera.transform.position);
            if (tmp_ViewerDistance < minDistanceThreshold || tmp_ViewerDistance > maxDistanceThreshold)
            {
                ToggleHiddenState(true);
            }
            else
            {
                ToggleHiddenState(false);
            }
        }

        private void ToggleHiddenState(bool _toggle)
        {
            if (isHidden == _toggle) return;
            isHidden = _toggle;
            gameObjectToHide.SetActive(!_toggle);
        }
    }
}
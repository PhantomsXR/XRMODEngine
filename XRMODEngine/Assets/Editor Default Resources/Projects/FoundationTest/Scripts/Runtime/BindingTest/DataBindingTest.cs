// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the FoundationTest.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LitJson;
using Phantom.XRMOD.Core.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.Video;

namespace FoundationTest.Runtime
{
    public class DataBindingTest : XRMODBehaviour
    {
        public int ValueInt;
        public string ValueString;
        public Sprite RuntimeLoadSpriteTest;
        public AudioClip RuntimeLoadAudioClipTest;
        public List<LineRenderer> LineRenderers;
        [SerializeField] private List<LineRenderer> lineRenderers;
        public GameObject[] EmptyArray;
        [SerializeField] private GameObject[] emptyArray;
        public List<GameObject> EmptyList;
        [SerializeField] private List<GameObject> emptyList;
        [HideInInspector] public List<Transform> Transforms;
        [HideInInspector] public List<Sprite> Sprites;
        [HideInInspector] public List<Button> Buttons;
        [HideInInspector] public List<Image> Images;
        [HideInInspector] public List<RectTransform> RectTransforms;
        [HideInInspector] public List<Canvas> Canvass;
        [HideInInspector] public List<CanvasGroup> CanvasGroups;
        [HideInInspector] public List<Toggle> Toggles;
        [HideInInspector] public List<ToggleGroup> ToggleGroups;
        [HideInInspector] public List<Dropdown> Dropdowns;
        [HideInInspector] public List<TextMeshPro> TextMeshPros;
        [HideInInspector] public List<TextMeshProUGUI> TextMeshProUGUIs;
        [HideInInspector] public List<RawImage> RawImages;
        [HideInInspector] public List<Slider> Sliders;
        [HideInInspector] public List<Scrollbar> Scrollbars;
        [HideInInspector] public List<InputField> InputFields;
        [HideInInspector] public List<ParticleSystem> ParticleSystems;
        [HideInInspector] public List<BoxCollider> BoxColliders;
        [HideInInspector] public List<SphereCollider> SphereColliders;
        [HideInInspector] public List<MeshCollider> MeshColliders;
        [HideInInspector] public List<CapsuleCollider> CapsuleCollider;
        [HideInInspector] public List<CharacterController> CharacterControllers;
        [HideInInspector] public List<Animation> Animations;
        [HideInInspector] public List<Animator> Animators;
        [HideInInspector] public List<Quaternion> Quaternions;
        [HideInInspector] public List<Vector3> Vector3s;
        [HideInInspector] public List<MeshFilter> MeshFilters;
        [HideInInspector] public List<MeshRenderer> MeshRenderers;
        [HideInInspector] public List<AudioSource> AudioSources;
        [HideInInspector] public List<AudioClip> AudioClips;
        [HideInInspector] public List<Light> Lights;
        [HideInInspector] public List<SortingGroup> SortingGroups;
        [HideInInspector] public List<SpriteRenderer> SpriteRenderers;
        [HideInInspector] public List<VideoPlayer> VideoPlayer;
        [HideInInspector] public List<Camera> Camera;


        [SerializeField] private GameObject uniPoolTestGo;

        private async void Start()
        {
            Assert.IsNotNull(RuntimeLoadSpriteTest, "RuntimeLoadSpriteTest != null");
            Assert.IsNotNull(RuntimeLoadAudioClipTest, "RuntimeLoadAudioClipTest != null");
            Assert.AreEqual(LineRenderers.Count, 6);
            Assert.AreEqual(LineRenderers.Count, lineRenderers.Count);
            Assert.AreEqual(ValueInt, 1);
            Assert.AreEqual(ValueString, nameof(DataBindingTest));
            Assert.AreEqual(EmptyArray.Length, 6);
            Assert.AreEqual(EmptyList.Count, EmptyArray.Length);
            // Assert.AreEqual(Camera.Count, 0);
            // Assert.AreEqual(VideoPlayer.Count, 0);
            // Assert.AreEqual(SpriteRenderers.Count, 0);
            // Assert.AreEqual(SortingGroups.Count, 0);
            // Assert.AreEqual(Lights.Count, 0);
            // Assert.AreEqual(AudioClips.Count, 0);
            // Assert.AreEqual(AudioSources.Count, 0);
            // Assert.AreEqual(MeshRenderers.Count, 0);
            // Assert.AreEqual(MeshFilters.Count, 0);
            // Assert.AreEqual(Vector3s.Count, 0);
            // Assert.AreEqual(Quaternions.Count, 0);
            // Assert.AreEqual(Animators.Count, 0);
            // Assert.AreEqual(Animations.Count, 0);
            // Assert.AreEqual(CharacterControllers.Count, 0);
            // Assert.AreEqual(CapsuleCollider.Count, 0);
            // Assert.AreEqual(MeshColliders.Count, 0);
            // Assert.AreEqual(SphereColliders.Count, 0);
            // Assert.AreEqual(BoxColliders.Count, 0);
            // Assert.AreEqual(ParticleSystems.Count, 0);
            // Assert.AreEqual(InputFields.Count, 0);
            // Assert.AreEqual(Scrollbars.Count, 0);
            // Assert.AreEqual(Sliders.Count, 0);
            // Assert.AreEqual(RawImages.Count, 0);
            // Assert.AreEqual(TextMeshProUGUIs.Count, 0);
            // Assert.AreEqual(TextMeshPros.Count, 0);
            // Assert.AreEqual(Dropdowns.Count, 0);
            // Assert.AreEqual(ToggleGroups.Count, 0);
            // Assert.AreEqual(Toggles.Count, 0);
            // Assert.AreEqual(CanvasGroups.Count, 0);
            // Assert.AreEqual(Canvass.Count, 0);
            // Assert.AreEqual(Images.Count, 0);
            // Assert.AreEqual(Sprites.Count, 0);
            // Assert.AreEqual(Buttons.Count, 0);
            // Assert.AreEqual(Transforms.Count, 0);
            // Assert.AreEqual(RectTransforms.Count, 0);

            Debug.Log($"<color=green>{nameof(DataBindingTest)} Test passed!</color>");


            await Task.Delay(5000);

            uniPoolTestGo.SetActive(true);
        }
    }
}
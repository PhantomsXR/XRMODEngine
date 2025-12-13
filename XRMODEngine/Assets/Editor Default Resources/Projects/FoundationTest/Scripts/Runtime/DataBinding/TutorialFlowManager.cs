// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the FoundationTest.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using System.Threading.Tasks;
using Phantom.XRMOD.AudioModule.Runtime;
using Phantom.XRMOD.Core.Runtime;
using UnityEngine;
using UnityEngine.Assertions;

namespace FoundationTest.Runtime.DataBinding
{
    public class TutorialFlowManager : XRMODBehaviour
    {
        [SerializeField] private List<TutorialPhase> phases;
        [SerializeField] private List<Transform> targets;
        [SerializeField] private TutorialPhase[] phasesArray;
        [SerializeField] internal UIHintSystem hintSystem;
        [SerializeField] private AudioEmitter[] audioEmitterArray;
        [SerializeField] private List<AudioEmitter> audioEmitters;

        private int currentPhaseIndex = -1;
        private AudioClip phaseIntroAudioClip;

        private void Start()
        {
            StartNextPhase();
        }

        private async void StartNextPhase()
        {
            Assert.IsNotNull(phases, "Phases is null");
            Assert.IsNotNull(phasesArray, "PhasesArray is null");
            Assert.IsNotNull(targets, "Targets is null");
            Assert.IsNotNull(hintSystem, "HintSystem is null");
            currentPhaseIndex++;
            if (currentPhaseIndex >= phases.Count)
            {
                OnTutorialComplete();
                return;
            }

            phases[currentPhaseIndex].StartPhase(this);
            Assert.AreEqual(phases.Count, 4);
            Assert.AreEqual(audioEmitterArray.Length, 1);
            Assert.AreEqual(audioEmitters.Count, 1);
            Assert.AreEqual(audioEmitters.Count, audioEmitterArray.Length);

            audioEmitterArray[0].Play();
            await Task.Delay(1000);
            audioEmitters[0].Play();
            Debug.Log($"<color=green>{nameof(TutorialFlowManager)} Test passed!</color>");
        }

        internal void OnTutorialComplete()
        {
        }

        internal void OnPhaseComplete()
        {
            StartNextPhase();
        }
    }
}
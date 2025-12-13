// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the FoundationTest.Runtime.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Threading.Tasks;
using LitJson;
using Phantom.XRMOD.AudioModule.Runtime;
using UnityEngine;
using UnityEngine.Assertions;
using Phantom.XRMOD.XRMODAPI.Runtime;
using Phantom.XRMOD.Localization.Runtime;
using Phantom.XRMOD.XRMODInput.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine.Video;
using VContainer.Unity;
using Object = UnityEngine.Object;

namespace FoundationTest.Runtime
{
    public class SharedData : IDisposable
    {
        private static SharedData _SHARED_DATA;
        public static SharedData GetInstance => _SHARED_DATA ??= new SharedData();

        // Add your fields below.
        // e.g. public string HelloText = "Hello Text";
        // e.g. public BindableProperty<string> HelloTextBindable = new  BindableProperty<string>();

        /// <summary>
        /// XRMOD Engine API.
        /// </summary>   
        internal readonly API XRMODAPI;

        /// <summary>
        /// Localization system
        /// </summary>
        internal LocalizationManager localizationManager = LocalizationManager.Instance;

        internal GameObject unipoolPrefab;

        private SharedData()
        {
            XRMODAPI = new API(nameof(FoundationTest));
            PrepareAssets();
        }


        private async void PrepareAssets()
        {
            var tmp_LocalizationTableAsset = await XRMODAPI.LoadAssetAsync<TextAsset>("LocalizationTable");
            Assert.IsNotNull(tmp_LocalizationTableAsset, "Localization table asset can not empty.");
            localizationManager.Initialized(nameof(FoundationTest), tmp_LocalizationTableAsset.bytes,
                Application.systemLanguage.ToString(),
                LocalizationScope.InExperiences);
        }

        public class TestData
        {
            public string Name;
            public int Health;
        }

        internal async void LoadAssets()
        {
            // Load your assets in here
            Assert.AreEqual(XRMODAPI.GetCurrentExperienceSpaceType().ToString(), "ExclusiveSpace");
            var tmp_FoundationTestPrefab = await XRMODAPI.LoadAssetAsync<GameObject>("FoundationTestPrefab");
            Object.Instantiate(tmp_FoundationTestPrefab, XRMODAPI.GetProcessContainer);

            var tmp_AudioClipData =
                await XRMODAPI.LoadAssetsAsync<ScriptableObject>(new[] {"AudioClipData 1", "AudioClipData 2"});
            foreach (var t in tmp_AudioClipData)
            {
                Debug.Log((t as AudioClipData).GetAudioClip().name);
            }

            var tmp_TestDataJson = await XRMODAPI.LoadAssetAsync<TextAsset>("TestData");
            Assert.AreEqual(JsonMapper.ToObject<TestData>(tmp_TestDataJson.text).Health, 100);


            var tmp_TutorialFlowManager = await XRMODAPI.LoadAssetAsync<GameObject>("TutorialFlowManager");
            Object.Instantiate(tmp_TutorialFlowManager, XRMODAPI.GetProcessContainer);

            var tmp_PlayerBase = await XRMODAPI.LoadAssetAsync<GameObject>("PlayerBase");
            Object.Instantiate(tmp_PlayerBase, XRMODAPI.GetProcessContainer);

            unipoolPrefab = await XRMODAPI.LoadAssetAsync<GameObject>("UniPoolSphere");

            await Task.Delay(1000);
            var tmp_PlayerPrefab = await XRMODAPI.LoadAssetAsync<GameObject>("Player");
            var tmp_PlayerInstance = Object.Instantiate(tmp_PlayerPrefab);
            tmp_PlayerInstance.GetComponent<PlayerBase>().Init();

            await Task.Delay(2000);
            await XRMODAPI.LoadUnityScene("EmptyScene");
            await XRMODAPI.LoadUnityScene("LargeScene");
            await XRMODAPI.LoadUnityScene("ScriptBindingScene");

            await Task.Delay(5000);

            var tmp_AgentPrefab = await XRMODAPI.LoadAssetAsync<GameObject>("Agent");
            var tmp_GoapSystemPrefab = await XRMODAPI.LoadAssetAsync<GameObject>("GoapSystemPrefab");
            Object.Instantiate(tmp_GoapSystemPrefab);
            for (int i = 0; i < 1; i++)
            {
                Object.Instantiate(tmp_AgentPrefab);
            }

#if ROKID_INSTALL
            await Task.Delay(5000);
            UniversalXRInput.GetInstance.SwitchInput(InputType.ThreeDofRay);
            if (XRMODAPI.IsPlatform(PlatformType.RokidStudio))
            {
                await Task.Delay(15000);
                UniversalXRInput.GetInstance.SwitchInput(InputType.NatureHands);
            }

            Debug.Log(
                $"TouchPadSize:{Phantom.XRMOD.RokidModule.Runtime.RokidNativeAPI.GetInstance.PhoneScreenWidth},{Phantom.XRMOD.RokidModule.Runtime.RokidNativeAPI.GetInstance.PhoneScreenHeight}");
            Phantom.XRMOD.RokidModule.Runtime.RokidNativeAPI.GetInstance.SetSystemScreenOrientation(ScreenOrientation
                .LandscapeLeft);
            Phantom.XRMOD.RokidModule.Runtime.RokidNativeAPI.GetInstance.SetUnityScreenOrientation(ScreenOrientation
                .LandscapeLeft);
            Debug.Log(
                $"TouchPadSize:{Phantom.XRMOD.RokidModule.Runtime.RokidNativeAPI.GetInstance.PhoneScreenWidth},{Phantom.XRMOD.RokidModule.Runtime.RokidNativeAPI.GetInstance.PhoneScreenHeight}");
#endif


            Debug.Log("All Done");

#if UNITY_EDITOR
            await Task.Delay(5000);
            UnityEditor.EditorApplication.isPlaying = false;
#endif
        }

        /// <summary>
        /// Exit current experience(or quit app)
        /// </summary>
        /// <param name="_quitApplication">True to quit app</param>
        internal void Exit(bool _quitApplication = false)
        {
            if (!_quitApplication)
                XRMODAPI.ReleaseProject(nameof(FoundationTest));
            else
                Application.Quit();
        }

        public void Dispose()
        {
            localizationManager = null;
        }
    }
}
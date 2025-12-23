using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using Phantom.XRMOD.SDKEntry.Runtime.Logic;
using UnityEngine.XR.ARFoundation;

// ReSharper disable once CheckNamespace
namespace Phantom.XRMOD.SDKEntry.Runtime
{
    /// <summary>
    /// The main entry point for the XRMOD SDK.
    /// Handles the SDK lifecycle, scene events, and kernel updates.
    /// </summary>
    public partial class SDKEntryPoint : MonoBehaviour
    {
        private SDKKernel sdkKernel;
        private bool awakeInvoked;

        #region Unity Callback

        /// <summary>
        /// Setup this game object not destroy on load new scene
        /// </summary>
        private void Awake()
        {
            awakeInvoked = true;
            DontDestroyOnLoad(this);

            try
            {
                sdkKernel = new SDKKernel();
                sdkKernel.Initialize();
            }
            catch (Exception tmp_Exception)
            {
                enabled = false;
                Debug.LogError($"[XRMOD] SDKEntryPoint initialized failed:{tmp_Exception}");
                throw;
            }

            // Entry main scene
            SceneManager.sceneLoaded += OnSceneLoad;
            SceneManager.LoadScene(nameof(SceneTags.Main), LoadSceneMode.Single);
        }


        /// <summary>
        /// Update event for XR-MOD hot-codes
        /// </summary>
        private void Update()
        {
            sdkKernel?.OnUpdate();
        }

        private void OnDestroy()
        {
            sdkKernel?.Dispose();
        }

        #endregion

 
        /// <summary>
        /// It will executed after scene loaded
        /// </summary>
        /// <param name="_scene">Load scene</param>
        /// <param name="_sceneMode">Load mode</param>
        private void OnSceneLoad(Scene _scene, LoadSceneMode _sceneMode)
        {
            switch (_scene.name)
            {
                case nameof(SceneTags.Main):
                    new SceneInitialization().Executed();
                    break;
                case nameof(SceneTags.Clear):
                    new SceneDeactivated().Executed();
                    SceneManager.sceneLoaded -= OnSceneLoad;
                    LoaderUtility.Deinitialize();
                    break;
                case nameof(SceneTags.Initilizer): break;
            }
        }
    }
}
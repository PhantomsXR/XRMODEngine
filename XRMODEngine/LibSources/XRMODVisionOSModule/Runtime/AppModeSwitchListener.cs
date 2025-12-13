using System;
using Unity.PolySpatial;
using UnityEngine;

namespace Phantom.XRMOD.VisionOSModule.Runtime
{
    public class AppModeSwitchListener : MonoBehaviour
    {
        [Header("Metal configuration")] 
        [SerializeField] private GameObject metalEventSystem;

        [Header("Reality kit configuration")] [SerializeField]
        private GameObject realitykitEventSystem;

        [SerializeField] private GameObject[] realitykitControllers;

        private VolumeCamera volumeCamera;

        private void Awake()
        {
            volumeCamera = FindFirstObjectByType<VolumeCamera>();
            volumeCamera.WindowStateChanged.AddListener(WindowStateChangedCallback);
        }

        private void WindowStateChangedCallback(VolumeCamera _volumeCamera, VolumeCamera.WindowState _windowState)
        {
            if (_volumeCamera.WindowConfiguration.Mode == VolumeCamera.PolySpatialVolumeCameraMode.Metal)
            {
                UpdateRealityInput(false);
                UpdateMetalInput(true);
            }
            else
            {
                UpdateRealityInput(true);
                UpdateMetalInput(false);
            }
        }

        private void UpdateRealityInput(bool _state)
        {
            realitykitEventSystem.SetActive(_state);
            foreach (var tmp_Controller in realitykitControllers)
            {
                tmp_Controller.SetActive(_state);
            }
        }

        private void UpdateMetalInput(bool _state)
        {
            metalEventSystem.SetActive(_state);
        }
    }
}
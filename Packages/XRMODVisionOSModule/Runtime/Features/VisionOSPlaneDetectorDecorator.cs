using System.Linq;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.VisionOSModule.Runtime.Models;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.XR.ARFoundation;

namespace Phantom.XRMOD.VisionOSModule.Runtime
{
    public class VisionOSPlaneDetectorDecorator : BaseVisionOSFeatureDecorator
    {
        private ARPlaneManager planeManager;
        private ARContextDataModel arContextData;
        private OnEventPlaneEventArgs onEventPlaneEventArgs;

        public override bool SupportThisFeature()
        {
            return planeManager != null && planeManager.subsystem.running;
        }

        public override void StartAlgorithm()
        {
            base.StartAlgorithm();
            onEventPlaneEventArgs = new OnEventPlaneEventArgs();

            arContextData = IocContainer.GetIoc.Resolve<ARContextDataModel>();
            var tmp_ARComponent = IocContainer.GetIoc.Resolve<ARComponentModel>();

            Assert.IsNotNull(tmp_ARComponent.XROriginGameObject);
            planeManager = tmp_ARComponent.XROriginGameObject.AddComponent<ARPlaneManager>();
            tmp_ARComponent.ARPlaneManager = planeManager;
            planeManager.enabled = false;


            if (planeManager)
            {
                planeManager.planesChanged += OnPlanesChanged;
            }

            planeManager.requestedDetectionMode = arContextData.PlaneDetectionMode;
            planeManager.planePrefab = arContextData.PlaneVisualizer;
            planeManager.enabled = true;
        }

        public override void PauseAlgorithm()
        {
            if (!planeManager && planeManager.descriptor == null)
            {
                Debug.LogError("Plane detection manager not exist!");
                return;
            }

            planeManager.enabled = false;
        }

        public override void StopAlgorithm()
        {
            if (planeManager == null || planeManager.descriptor == null) return;
            planeManager.planesChanged -= OnPlanesChanged;
            planeManager.enabled = false;
            planeManager.subsystem?.Stop();
            planeManager.subsystem?.Destroy();
            Object.Destroy(planeManager);
            planeManager = null;
            onEventPlaneEventArgs = null;
        }

        private void OnPlanesChanged(ARPlanesChangedEventArgs _obj)
        {
            onEventPlaneEventArgs.Added = _obj.added.Select(_plane => _plane.transform).ToList();
            onEventPlaneEventArgs.Removed = _obj.removed.Select(_plane => _plane.transform).ToList();
            onEventPlaneEventArgs.Updated = _obj.updated.Select(_plane => _plane.transform).ToList();
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                onEventPlaneEventArgs);
        }
    }
}
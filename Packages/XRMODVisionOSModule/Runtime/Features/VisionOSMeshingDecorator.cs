// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.VisionOSModule.Runtime.
// //
// // The AVPPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.VisionOSModule.Runtime.Models;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.XR.ARFoundation;

namespace Phantom.XRMOD.VisionOSModule.Runtime
{
    public class VisionOSMeshingDecorator : BaseVisionOSFeatureDecorator
    {
        private const string _CONST_MESHING_NAME = "Camera Offset/MeshManager";
        private OnEventMeshEventArgs onEventMeshEventArgs;
        private ARMeshManager arMeshManager;

        public override bool SupportThisFeature()
        {
            return true;
        }

        public override void StartAlgorithm()
        {
            base.StartAlgorithm();
            onEventMeshEventArgs = new OnEventMeshEventArgs();

            var tmp_ARComponent = IocContainer.GetIoc.Resolve<ARComponentModel>();
            var tmp_MeshingGameObject = tmp_ARComponent.XROrigin.transform.Find(_CONST_MESHING_NAME);
            tmp_MeshingGameObject.gameObject.SetActive(false);
            Assert.IsNotNull(tmp_MeshingGameObject);
            tmp_ARComponent.ARMeshManager = tmp_MeshingGameObject.GetComponent<ARMeshManager>();
            arMeshManager = tmp_ARComponent.ARMeshManager;
            arMeshManager.meshPrefab =
                IocContainer.GetIoc.Resolve<ARContextDataModel>().MeshVisualizer.GetComponent<MeshFilter>();
            arMeshManager.meshesChanged += OnMeshesChanged;
            arMeshManager.gameObject.SetActive(true);
        }

        private void OnMeshesChanged(ARMeshesChangedEventArgs _obj)
        {
            onEventMeshEventArgs.Added = _obj.added;
            onEventMeshEventArgs.Updated = _obj.updated;
            onEventMeshEventArgs.Removed = _obj.removed;
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                onEventMeshEventArgs);
        }

        public override void PauseAlgorithm()
        {
            IocContainer.GetIoc.Resolve<ARComponentModel>().ARMeshManager.gameObject.SetActive(false);
        }

        public override void StopAlgorithm()
        {
            onEventMeshEventArgs = null;
            arMeshManager.meshesChanged -= OnMeshesChanged;
            var tmp_ARMeshManagerComponent = IocContainer.GetIoc.Resolve<ARComponentModel>().ARMeshManager;
            tmp_ARMeshManagerComponent.DestroyAllMeshes();
            tmp_ARMeshManagerComponent.gameObject.SetActive(false);
            tmp_ARMeshManagerComponent.meshPrefab = null;
        }
    }
}
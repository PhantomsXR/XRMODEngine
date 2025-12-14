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

using System.Linq;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.VisionOSModule.Runtime.ExtensionComponents;
using Phantom.XRMOD.VisionOSModule.Runtime.Models;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.XR.ARFoundation;

namespace Phantom.XRMOD.VisionOSModule.Runtime
{
    public class VisionOSAnchorCreatorDecorator : BaseVisionOSFeatureDecorator
    {
        private GameObject extensionGameObject;
        private ARAnchorManager arAnchorManager;
        private ARRaycastManager arRaycastManager;
        private AnchorManagerExtension anchorManagerExtension;
        private OnEventAnchorEventArgs onEventAnchorEventArgs;

        private void OnAnchorsChanged(ARAnchorsChangedEventArgs _obj)
        {
            onEventAnchorEventArgs.Added = _obj.added.Select(_anchor => _anchor.transform).ToList();
            onEventAnchorEventArgs.Removed = _obj.removed.Select(_anchor => _anchor.transform).ToList();
            onEventAnchorEventArgs.Updated = _obj.updated.Select(_anchor => _anchor.transform).ToList();

            for (int tmp_Idx = 0; tmp_Idx < onEventAnchorEventArgs.Added.Count; tmp_Idx++)
            {
                var tmp_Anchor = onEventAnchorEventArgs.Added[tmp_Idx].gameObject;

                if (!tmp_Anchor.GetComponent<XRMODAnchor>())
                    tmp_Anchor.AddComponent<XRMODAnchor>();
            }

            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                onEventAnchorEventArgs);
        }

        public override void StartAlgorithm()
        {
            base.StartAlgorithm();
            onEventAnchorEventArgs = new OnEventAnchorEventArgs();

            ARComponentModel tmp_ARComponent = IocContainer.GetIoc.Resolve<ARComponentModel>();

            Assert.IsNotNull(tmp_ARComponent.XROriginGameObject);
            arAnchorManager = tmp_ARComponent.XROriginGameObject.AddComponent<ARAnchorManager>();
            tmp_ARComponent.ARAnchorManager = arAnchorManager;

            arRaycastManager = IocContainer.GetIoc.Resolve<ARComponentModel>().ARRaycastManager;

            extensionGameObject = new GameObject(ConstKey.CONST_GAME_OBJECT_NAME);
            anchorManagerExtension = extensionGameObject.AddComponent<AnchorManagerExtension>();


            if (arAnchorManager)
                arAnchorManager.enabled = false;

            if (arRaycastManager)
                arRaycastManager.enabled = false;

            if (anchorManagerExtension)
                anchorManagerExtension.enabled = false;

            if (arAnchorManager)
            {
                arAnchorManager.anchorsChanged += OnAnchorsChanged;
                arAnchorManager.enabled = true;
            }

            if (arRaycastManager)
                arRaycastManager.enabled = true;

            if (anchorManagerExtension)
                anchorManagerExtension.enabled = true;
        }

        public override void PauseAlgorithm()
        {
            anchorManagerExtension.enabled = false;

            if (arAnchorManager || arAnchorManager.descriptor != null)
            {
                arAnchorManager.enabled = false;
            }

            if (!arRaycastManager && arRaycastManager.descriptor == null) return;
            arRaycastManager.enabled = false;
        }

        public override void StopAlgorithm()
        {
            onEventAnchorEventArgs = null;

            if (arAnchorManager)
                arAnchorManager.anchorsChanged -= OnAnchorsChanged;


            if (arAnchorManager || arAnchorManager.descriptor != null)
            {
                arAnchorManager.anchorPrefab = null;
                arAnchorManager.enabled = false;
                arAnchorManager.subsystem?.Stop();
                arAnchorManager.subsystem?.Destroy();
                arAnchorManager.DestroyWithPlatform();
            }


            if (anchorManagerExtension)
            {
                anchorManagerExtension.enabled = false;
                anchorManagerExtension.RemoveAllAnchors();
                anchorManagerExtension.gameObject.DestroyWithPlatform();
            }

            if (arRaycastManager == null || arRaycastManager.descriptor == null) return;
            arRaycastManager.enabled = false;
            arRaycastManager.DestroyWithPlatform();
        }

        public override bool SupportThisFeature()
        {
            return arAnchorManager.descriptor != null;
        }
    }
}
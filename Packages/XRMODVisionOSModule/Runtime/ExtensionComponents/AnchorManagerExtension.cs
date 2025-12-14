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

using System;
using System.Collections.Generic;
using System.Linq;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.VisionOSModule.Runtime.Models;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

namespace Phantom.XRMOD.VisionOSModule.Runtime.ExtensionComponents
{
    public class AnchorManagerExtension : MonoBehaviour
    {
        private RaycastHit hits;

        private readonly List<ARAnchor> arAnchors = new List<ARAnchor>();

        private void Start()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(StartCreateAnchor,
                nameof(ActionParameterDataType.CreateAnchor));
            ActionNotificationCenter.DefaultCenter.AddObserver(DestroySpecifiedAnchorByAnchorId,
                nameof(ActionParameterDataType.DestroyAnchor));
        }

        public void RemoveAllAnchors()
        {
            foreach (var tmp_Anchor in arAnchors)
            {
                if (tmp_Anchor == null) continue;
                if (tmp_Anchor.gameObject.TryGetComponent(typeof(AREnvironmentProbe), out _)) continue;
                tmp_Anchor.gameObject.DestroyWithPlatform();
            }

            arAnchors.Clear();
        }

        private void DestroySpecifiedAnchorByAnchorId(BaseNotificationData _notifyData)
        {
            if (_notifyData is not DestroyAnchorArgs tmp_Args) return;
            var tmp_Anchor = arAnchors.FirstOrDefault(_anchor => _anchor.sessionId == tmp_Args.AnchorSessionId);
            if (!tmp_Anchor || tmp_Anchor == default) return;
            arAnchors.Remove(tmp_Anchor);
            tmp_Anchor.gameObject.DestroyWithPlatform();
        }

        private void StartCreateAnchor(BaseNotificationData _notifyData)
        {
            if (!(_notifyData is CreateAnchorArgs tmp_Data)) return;
            if (!IsRunning()) return;

            var tmp_Anchor = CreateAnchor(tmp_Data);
            if (tmp_Anchor)
            {
                var tmp_XRMODAnchor = tmp_Anchor.gameObject.AddComponent<XRMODAnchor>();
                tmp_XRMODAnchor.Uuid = tmp_Anchor.sessionId;

                arAnchors.Add(tmp_Anchor);
                tmp_Data.NotificationAct?.Invoke();
                tmp_Data.NotificationActWithData?.Invoke(tmp_Anchor.gameObject);
            }
        }

        private ARAnchor CreateAnchor(CreateAnchorArgs _createAnchorData)
        {
            if (!IsRunning()) return null;


            if (!_createAnchorData.Content) return null;
            GameObject tmp_NewAnchor = new GameObject();
            tmp_NewAnchor.transform.SetParent(_createAnchorData.Content.transform.parent);
            tmp_NewAnchor.transform.SetLocalPositionAndRotation(_createAnchorData.Position,
                _createAnchorData.Rotation);

            ARAnchor tmp_Anchor = tmp_NewAnchor.AddComponent<ARAnchor>();
            tmp_NewAnchor.name = $"Anchor-{tmp_Anchor.sessionId}";

            var tmp_VirtualTrans = _createAnchorData.Content.transform;
            tmp_VirtualTrans.SetParent(tmp_NewAnchor.transform);
            tmp_VirtualTrans.position = tmp_Anchor.transform.position + _createAnchorData.Offset;
            return tmp_Anchor;
        }

        [Obsolete]
        private GameObject InstantiatePrefab(Transform _transform, GameObject _prefab)
        {
            var tmp_InstantiateData = new InstantiateArgs()
            {
                Prefab = _prefab,
                Parent = _transform
            };
            var tmp_Results = ActionNotificationCenter.DefaultCenter.PostNotificationWithResult(
                nameof(ActionParameterDataType.Instantiate), tmp_InstantiateData);
            return tmp_Results?[0] as GameObject;
        }

        private void OnDisable()
        {
            //RemoveAllAnchors();

            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.CreateAnchor));
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.DestroyAnchor));
        }


        private bool IsRunning()
        {
#if UNITY_EDITOR
            return true;
#else
            var tmp_ARAnchorManager = IocContainer.GetIoc.Resolve<ARComponentModel>().ARAnchorManager;
            return tmp_ARAnchorManager.subsystem != null && tmp_ARAnchorManager.subsystem.running;
#endif
        }
    }
}
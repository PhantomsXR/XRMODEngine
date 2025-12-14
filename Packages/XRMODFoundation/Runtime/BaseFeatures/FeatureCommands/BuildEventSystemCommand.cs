// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the BaseFeaturesModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.BaseFeatures.Runtime.Models;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.UI;
using Phantom.XRMOD.Core.Runtime;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.BaseFeatures.Runtime
{
    public class BuildEventSystemCommand : ICommand, IReleaseCommand
    {
        readonly BaseFeatureModel baseFeatureModel = IocContainer.GetIoc.Resolve<BaseFeatureModel>();


        public void Execute()
        {
            if (baseFeatureModel.EventSystem) return;
            baseFeatureModel.EventSystem = Object.FindObjectOfType<EventSystem>();
            if (baseFeatureModel.EventSystem) return;
            baseFeatureModel.EventSystem = new GameObject("EventSystem-AutoCreate",
                new[] {typeof(EventSystem), typeof(InputSystemUIInputModule)}).GetComponent<EventSystem>();
        }

        public void Release(string _projectName = null)
        {
            if (!baseFeatureModel.EventSystem) return;
            baseFeatureModel.EventSystem.gameObject.SetActive(false);
        }
    }
}
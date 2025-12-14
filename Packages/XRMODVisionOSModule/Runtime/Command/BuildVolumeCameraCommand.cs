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
using System.Threading.Tasks;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.Models.Runtime;
using Phantom.XRMOD.VisionOSModule.Runtime.Models;
using Unity.PolySpatial;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.SceneManagement;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.VisionOSModule.Runtime
{
    public class BuildVolumeCameraCommand : ICommand, IReleaseCommand
    {
        private VolumeCameraWindowConfiguration bounded;
        private VolumeCameraWindowConfiguration unBounded;
        private VolumeCameraWindowConfiguration metal;

        public BuildVolumeCameraCommand()
        {
            var tmp_VolumeCam = Object.FindAnyObjectByType<VolumeCamera>();
            if (!tmp_VolumeCam)
            {
                var tmp_VolumeCamGo = new GameObject("VolumeCam");
                tmp_VolumeCam = tmp_VolumeCamGo.AddComponent<VolumeCamera>();
            }

            bounded =
                Resources.Load<VolumeCameraWindowConfiguration>("Configures/Bounded_VolumeCameraWindowConfiguration");
            Assert.IsNotNull(bounded, "bounded configuration not found");
            unBounded =
                Resources.Load<VolumeCameraWindowConfiguration>("Configures/Unbounded_VolumeCameraWindowConfiguration");
            Assert.IsNotNull(unBounded, "unBounded configuration not found");

            metal =
                Resources.Load<VolumeCameraWindowConfiguration>("Configures/Metal_VolumeCameraWindowConfiguration");
            Assert.IsNotNull(metal, "metal configuration not found");

            if (tmp_VolumeCam.WindowConfiguration == null)
                tmp_VolumeCam.WindowConfiguration = bounded;
            IocContainer.GetIoc.Resolve<ARComponentModel>().VolumeCamera = tmp_VolumeCam;
            Assert.IsNotNull(IocContainer.GetIoc.Resolve<ARComponentModel>().VolumeCamera);
        }

        public void Execute()
        {
            ActionNotificationCenter.DefaultCenter.AddObserver(OnSwitchSpaceType,
                nameof(ActionParameterDataType.SwitchSpaceType));
        }

        private void OnSwitchSpaceType(BaseNotificationData _data)
        {
            if (_data is not SpaceTypeActionArgs tmp_Data) return;
            IocContainer.GetIoc.Resolve<ARContextDataModel>().SpaceType = tmp_Data.SpaceTypeValue;
            var tmp_VolumeCam = IocContainer.GetIoc.Resolve<ARComponentModel>().VolumeCamera;
            switch (tmp_Data.SpaceTypeValue)
            {
                case SpaceType.SharedSpace:
                    tmp_VolumeCam.WindowConfiguration = bounded;
                    if (tmp_Data.BoundPosition.HasValue)
                        tmp_VolumeCam.transform.position = tmp_Data.BoundPosition.Value;

                    if (tmp_Data.Dimensions.HasValue)
                        tmp_VolumeCam.Dimensions = tmp_Data.Dimensions.Value;

                    if (tmp_Data.BoundResizeMode != BoundResizeMode.None)
                    {
                        if (tmp_VolumeCam.TryGetComponent<VolumeCameraResizeListener>(out var tmp_Listener))
                        {
                            tmp_Listener.Mode = tmp_Data.BoundResizeMode;
                        }
                        else
                        {
                            tmp_VolumeCam.gameObject.AddComponent<VolumeCameraResizeListener>().Mode =
                                tmp_Data.BoundResizeMode;
                        }
                    }

                    // Fix gitlab-#60: Not relocating will result in inaccurate Camera data being obtained when returning to unbounded.
                    IocContainer.GetIoc.Resolve<ARComponentModel>().ARCamera.transform
                        .SetLocalPositionAndRotation(Vector3.zero, Quaternion.identity);
                    break;
                case SpaceType.ExclusiveSpace:
                    tmp_VolumeCam.WindowConfiguration = unBounded;
                    break;
                case SpaceType.Metal:
                    tmp_VolumeCam.WindowConfiguration = metal;
                    try
                    {
                        if (IocContainer.GetIoc.Resolve<RuntimeExperienceConfig>().CurrentConfigures.Value
                            .MRPassthrough)
                        {
                            if (Camera.main != null)
                            {
                                Camera.main.clearFlags = CameraClearFlags.SolidColor;
                                Camera.main.backgroundColor = new Color(0, 0, 0, 0);
                            }
                            else
                            {
                                Camera.main.clearFlags = CameraClearFlags.Skybox;
                            }
                        }
                    }
                    catch (Exception tmp_Exception)
                    {
                        Debug.LogError(tmp_Exception);
                        throw;
                    }

                    break;
                case SpaceType.CustomProfile:
                    throw new NotSupportedException("Custom Profile are not supported yet.");
                default:
                    throw new ArgumentOutOfRangeException();
            }

            if (tmp_Data.CullingMask.HasValue)
                tmp_VolumeCam.CullingMask = tmp_Data.CullingMask.Value;
        }

        public void Release(string _projectName = null)
        {
            ActionNotificationCenter.DefaultCenter.RemoveObserver(nameof(ActionParameterDataType.SwitchSpaceType));
        }
    }
}
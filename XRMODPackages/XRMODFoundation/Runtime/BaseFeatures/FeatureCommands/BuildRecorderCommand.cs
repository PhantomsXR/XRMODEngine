// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the BaseFeaturesModule.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Models.Runtime;
//using Recorders.Runtime;
using UnityEngine;
using Phantom.XRMOD.Core.Runtime;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.BaseFeatures.Runtime
{
    [Obsolete("Deprecated. Use platform builtin record instead.",true)]
    public class BuildRecorderCommand : AbstractCommand, ICommand, IReleaseCommand
    {
        private const string _CONST_RECORDER_OBJECT = "Recorder";

        public void Execute()
        {
            base.Initializer();
            // if (Config.Algorithm == AlgorithmType.Classic3D || !Config.UseMediaRecorder) return;
            // var tmp_XRFrameGrabber = Object.FindObjectOfType<XRFrameGrabber>();
            // if (!tmp_XRFrameGrabber) return;
            // BaseContextDataModel.XRFrameGrabber = tmp_XRFrameGrabber.gameObject;
            // tmp_XRFrameGrabber.SaveImageCallback = SaveMediaCallback;
            //
            //
            // BaseContextDataModel.RecorderGo = new GameObject(_CONST_RECORDER_OBJECT);
            // XRVideoRecorder tmp_Recorder = BaseContextDataModel.RecorderGo.AddComponent<XRVideoRecorder>();
            // if (tmp_Recorder)
            //     tmp_Recorder.SaveVideoCallback = SaveMediaCallback;
            //
            // tmp_Recorder.FrameRate = 30;
            // switch (Config.MediaResolution)
            // {
            //     case MediaResolution.Normal:
            //         BaseContextDataModel.PhotoSize.x = Screen.width / 2;
            //         BaseContextDataModel.PhotoSize.y = Screen.height / 2;
            //         break;
            //     case MediaResolution.HD:
            //         BaseContextDataModel.PhotoSize.x = Screen.width;
            //         BaseContextDataModel.PhotoSize.y = Screen.height;
            //         break;
            // }
            //
            // tmp_Recorder.VideoWidth = BaseContextDataModel.PhotoSize.x;
            // tmp_Recorder.VideoHeight = BaseContextDataModel.PhotoSize.y;
            // tmp_Recorder.RecordMicrophone = Config.UseMicrophone;
            //
            // ActionNotificationCenter.DefaultCenter.AddObserver(StartVideoRecorder,
            //     nameof(ActionParameterDataType.StartVideoRecording));
            // ActionNotificationCenter.DefaultCenter.AddObserver(StopVideoRecorder,
            //     nameof(ActionParameterDataType.StopVideoRecording));
            // ActionNotificationCenter.DefaultCenter.AddObserver(TakePhoto,
            //     nameof(ActionParameterDataType.TakePhoto));
        }

        public void Release(string _projectName = null)
        {
            // if (Config is not {UseMediaRecorder: true}) return;
            //BaseContextDataModel.XRFrameGrabber.DestroyWithPlatform();
            BaseContextDataModel.RecorderGo.DestroyWithPlatform();
        }

        private void SaveMediaCallback(bool _success, string _savePath)
        {
            var tmp_SaveData = new SaveMediaNotificationData();
            tmp_SaveData.MediaSavePath = _savePath;
            ActionNotificationCenter.DefaultCenter.PostNotification(nameof(ActionParameterDataType.OnEvent),
                tmp_SaveData);
        }


        private void StartVideoRecorder(BaseNotificationData _data)
        {
            // BaseContextDataModel.RecorderGo.GetComponent<XRVideoRecorder>().StartRecording();
        }

        private void StopVideoRecorder(BaseNotificationData _data)
        {
            // BaseContextDataModel.RecorderGo.GetComponent<XRVideoRecorder>().StopRecording();
        }

        private void TakePhoto(BaseNotificationData _data)
        {
            // BaseContextDataModel.XRFrameGrabber.GetComponent<XRFrameGrabber>()
            //     .TakePhoto(BaseContextDataModel.PhotoSize.x, BaseContextDataModel.PhotoSize.y);
        }
    }
}
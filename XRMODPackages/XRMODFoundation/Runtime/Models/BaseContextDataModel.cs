// // /*===============================================================================
// // Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantoms.Models.Runtime.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.UnityFusion.Runtime;
using UnityEngine;
using Phantom.XRMOD.Core.Runtime;

namespace Phantom.XRMOD.Models.Runtime
{
    public class BaseContextDataModel : IModel, IReleaseCommand
    {
        public Camera MainCamera;

        /// <summary>
        /// The script running environment
        /// </summary>
        public BindableProperty<CodesHook> CodeHook { get; private set; }

        /// <summary>
        /// For hold the multiplayer manager
        /// </summary>
        public GameObject MultiplayerGo { get; set; }

        public GameObject ConsoleGo;

        public GameObject VisualScriptingGo;

        public Vector2Int PhotoSize;

        public GameObject RecorderGo { get; set; }

        public GameObject XRFrameGrabber { get; set; }

        /// <summary>
        ///  Current fetch experience project uid
        /// </summary>
        public string ExperienceUid;

        /// <summary>
        /// Current fetch experience detail information
        /// </summary>
        public ExperienceInfoData ExperienceInfo { get; set; }

        /// <summary>
        /// The global space type
        /// </summary>
        public SpaceType AppSpaceType;

        public class ExperienceInfoData
        {
            public string ProjectUid;
            public string AppUid;
            public string UserUid;
            public string Platform;
        }

        public BaseContextDataModel()
        {
            Initialize();
        }

        public void Initialize()
        {
            CleanAlreadyGameObject();

            PhotoSize = Vector2Int.zero;
            ExperienceInfo = null;
            ExperienceUid = null;
            CodeHook = new BindableProperty<CodesHook>();
        }


        public void Release(string _projectName = null)
        {
            CleanAlreadyGameObject();

            // Release last, otherwise some resources cannot be released correctly
            // if (CodeHook.Value != null)
            // {
            //     CodeHook.Value.Dispose();
            //     CodeHook.Value = null;
            // }
        }

        private void CleanAlreadyGameObject()
        {
            if (ConsoleGo)
                ConsoleGo.DestroyWithPlatform();

            if (RecorderGo)
                RecorderGo.DestroyWithPlatform();

            if (VisualScriptingGo)
                VisualScriptingGo.DestroyWithPlatform();

            if (XRFrameGrabber)
                XRFrameGrabber.DestroyWithPlatform();

            if (MultiplayerGo)
                MultiplayerGo.DestroyWithPlatform();
        }
    }
}
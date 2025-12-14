// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODLocalization.Editor.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;

namespace Phantom.XRMOD.Localization.Editor
{
    [System.Serializable]
    public class OpenAIMessage
    {
        public string role;
        public string content;
    }

    [System.Serializable]
    public class OpenAIRequest
    {
        public string model = "gpt-4o-mini";
        public float temperature = 0.3f;
        public List<OpenAIMessage> messages = new();
    }

    [System.Serializable]
    public class OpenAIResponse
    {
        public List<Choice> choices;
        [System.Serializable]
        public class Choice
        {
            public OpenAIMessage message;
        }
    }

}
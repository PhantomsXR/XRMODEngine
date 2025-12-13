// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the FoundationTest.Runtime.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

namespace FoundationTest.Runtime.DataBinding
{
    public class Guider
    {
        private UIHintSystem hintSystem;

        public Guider(UIHintSystem _hintSystem)
        {
            hintSystem = _hintSystem;
        }

        public void Say(string _text, float _waitTime = 3f)
        {
            hintSystem.ShowSpeechBubble(_text, _waitTime);
        }

        public void Cheer(string _text, float _waitTime = 3f)
        {
            hintSystem.ShowSpeechBubble(_text, _waitTime);
        }
    }
}
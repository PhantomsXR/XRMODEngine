// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the XR-MOD SDK.
// 
// The XR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact nswell@phantomsxr.com for licensing requests.
// ===============================================================================*/

using System.Collections.Generic;
using UnityEngine;

namespace Action_Notification_Manager.Editor
{
    //[CreateAssetMenu(menuName = "XR-MOD/ANM/ActionKey")]
    public class ActionParamaterData : ScriptableObject
    {
        public List<string> ObserverKeys = new List<string>();
    }
}
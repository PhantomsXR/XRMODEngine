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

using System;
using System.Collections.Generic;

namespace Phantom.XRMOD.ActionNotification.Runtime
{
    public class LoadObjectArgs:BaseNotificationData
    {
        public string ProjectName;
        public List<string> LoadObjectName;
        public Type LoadObjectType;
    }
}
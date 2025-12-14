// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Runtime.CodeHook.
// //
// // The QuestPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    public interface IRuntimeTypeHandler
    {
        bool CanHandle(MonoField.FieldTypeEnum _fieldType); 
        object ProcessValue(MonoField _field, MonoData _data,Type _type);
    }
}
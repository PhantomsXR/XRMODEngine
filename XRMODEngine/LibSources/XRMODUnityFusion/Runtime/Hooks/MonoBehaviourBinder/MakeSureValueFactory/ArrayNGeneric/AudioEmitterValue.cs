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

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Phantom.XRMOD.UnityFusion.Runtime.CodeHook
{
    public class AudioEmitterValue : ArrayAndGenericMixMakeSureAction
    {
#if USE_AUDIO_MODULE
        public override bool MakeSureValue(ref FieldInfo _fieldInfo, object _target, object _value)
        {
            List<object> tmp_ConvertObj = new();
            if (!base.MakeSureValue(ref _fieldInfo, _target, _value))
            {
                if (_value is IList tmp_List)
                {
                    foreach (var tmp_O in tmp_List)
                    {
                        if (tmp_O is Phantom.XRMOD.AudioModule.Runtime.AudioEmitter tmp_Instance)
                        {
                            tmp_ConvertObj.Add(tmp_Instance);
                        }
                    }
                }
            }
            else
            {
                foreach (object tmp_O in convertedArray)
                {
                    if (tmp_O is Phantom.XRMOD.AudioModule.Runtime.AudioEmitter tmp_Instance)
                    {
                        tmp_ConvertObj.Add(tmp_Instance);
                    }
                }
            }

            _fieldInfo.SetValue(_target,
                isGenericList
                    ? tmp_ConvertObj.Cast<Phantom.XRMOD.AudioModule.Runtime.AudioEmitter>().ToList()
                    : tmp_ConvertObj.Cast<Phantom.XRMOD.AudioModule.Runtime.AudioEmitter>().ToArray());

            return true;
        }
#endif
    }
}
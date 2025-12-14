// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Setup.Editor.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using System.Linq;
using Phantom.XRMOD.Setup.Editor;
using UnityEditor;
using UnityEditor.Build;
using UnityEngine;

namespace Phantom.XRMOD.Setup
{
    public class ActivateCorrespondingVersionDll
    {
        internal static void ActivateDll()
        {
            string tmp_UnityVersion = Application.unityVersion;
            AddDefineSymbol(tmp_UnityVersion.Contains("6000") ? "UNITY_6000_0_OR_NEW" : "UNITY_2022_0_OR_NEW");
        }


        private static void AddDefineSymbol(string _symbol)
        {
            // 获取当前已有的 Script Define Symbols
            string[] tmp_Defines = PlayerSettings.GetScriptingDefineSymbols(XRMODEnginePreferences.GetNamedTarget())
                .Split(";");
            // 如果已经有该 define，跳过
            if (tmp_Defines.Contains(_symbol))
            {
                return;
            }

            List<string> tmp_DefineList = new();
            tmp_DefineList.AddRange(tmp_Defines);
            tmp_DefineList.Add(_symbol);
            PlayerSettings.SetScriptingDefineSymbols(XRMODEnginePreferences.GetNamedTarget(), tmp_DefineList.ToArray());
        }
    }
}
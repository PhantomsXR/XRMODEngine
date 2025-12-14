// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.Setup.Editor.
// //
// // The WhackAMole cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.IO;
using Phantom.XRMOD.Core.Runtime;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Phantom.XRMOD.Setup.Editor
{
    public class SDKInformationFixerDrawer : AbstractDrawer, IFixer
    {
        private const string _CONST_MISSING_PROMPT =
            "The XRMOD engine will not work properly without SDK Information config.";

        private const string _CONST_OLD_GUID = "366f65a33b24340908627dbc480a4c61";
        private const string _CONST_OLD_1_GUID = "1dee0dfc0346409c80b59c8110f6dee4";
        private const string _CONST_OLD_2_GUID = "f82efca942b6046ff8f19408b4a45358";
        private const string _CONST_NEW_GUID = "81930fe1b17374183aaf953fc2f422e2";

        public override VisualElement CreateVisualElement()
        {
            return DrawUtility.CreateSettingStateUI("SDK Information", _CONST_MISSING_PROMPT, () => IsNeedToFix(),
                CheckedTexture,
                ErrorTexture,
                FixError);
        }

        private void FixError()
        {
            var tmp_FilePath = Path.Combine(Application.dataPath, "XR/Resources/SDKInformation.asset");
            var tmp_AllText = File.ReadAllText(tmp_FilePath);
            tmp_AllText = tmp_AllText.Replace(_CONST_OLD_GUID, _CONST_NEW_GUID)
                .Replace(_CONST_OLD_1_GUID, _CONST_NEW_GUID)
                .Replace(_CONST_OLD_2_GUID, _CONST_NEW_GUID)
                .Replace("-264888889","11500000")
                .Replace("773222995", "11500000");
            File.WriteAllText(tmp_FilePath, tmp_AllText);
            AssetDatabase.Refresh();

            var tmp_SDKInformation =
                AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/XR/Resources/SDKInformation.asset");

            var tmp_Configure = AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/XR/XRMODSetupConfigure.asset");
            var tmp_SerObj = new SerializedObject(tmp_Configure);
            var tmp_SDKInformationField = tmp_SerObj.FindProperty("SDKInformation");
            tmp_SDKInformationField.objectReferenceValue = tmp_SDKInformation;
            tmp_SerObj.ApplyModifiedProperties();
        }

        void IFixer.DoFix()
        {
            FixError();
        }

        bool IsNeedToFix()
        {
            var tmp_SDKInformationAsset =
                File.Exists(Path.Combine(Application.dataPath, "XR/Resources/SDKInformation.asset"));
            var tmp_Validation =
                AssetDatabase.LoadAssetAtPath<ScriptableObject>("Assets/XR/Resources/SDKInformation.asset");

            return tmp_SDKInformationAsset && tmp_Validation;
        }

        public static Dictionary<string, string> ParseYAML(string _yaml)
        {
            var tmp_Dict = new Dictionary<string, string>();
            var tmp_Lines = _yaml.Split(new[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var tmp_Line in tmp_Lines)
            {
                if (tmp_Line.TrimStart().StartsWith("#")) continue;
                var tmp_Index = tmp_Line.IndexOf(':');
                if (tmp_Index < 0) continue;

                var tmp_Key = tmp_Line.Substring(0, tmp_Index).Trim();
                var tmp_Value = tmp_Line.Substring(tmp_Index + 1).Trim();
                tmp_Dict[tmp_Key] = tmp_Value;
            }

            return tmp_Dict;
        }
    }
}
// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.VisionOSModule.Editor.
// //
// // The AVPPlatform cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact info@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.IO;
using System.Text;
using UnityEditor;
using UnityEditor.Callbacks;

namespace Phantom.XRMOD.VisionOSModule.Editor
{
    public class VisionOSBuildProcess
    {
        private static string _UNITY_USES_WEBCAM = "UNITY_USES_WEBCAM 1";
        private static string _UNITY_USES_MICROPHONE = "UNITY_USES_MICROPHONE 1";
        private static string _UNITY_USES_IAD = "UNITY_USES_IAD 1";
        private static string _UNITY_USES_LOCATION = "UNITY_USES_LOCATION 1";


        private static string _UNITY_USES_WEBCAM_OFF = "UNITY_USES_WEBCAM 0";
        private static string _UNITY_USES_MICROPHONE_OFF = "UNITY_USES_MICROPHONE 0";
        private static string _UNITY_USES_IAD_OFF = "UNITY_USES_IAD 0";
        private static string _UNITY_USES_LOCATION_OFF = "UNITY_USES_LOCATION 0";

        [PostProcessBuild(callbackOrder: int.MaxValue)]
        private static void BuildVisionOSProcess(BuildTarget _target, string _pathToBuiltProject)
        {
            if (_target == BuildTarget.VisionOS)
            {
                ModifyPreprocessorFile(_pathToBuiltProject);
            }
        }

        private static void ModifyPreprocessorFile(string _pathToBuiltProject)
        {
            var tmp_PreprocessorFilePath = Path.Combine(_pathToBuiltProject, "Classes/Preprocessor.h");
            var tmp_PreprocessorText = File.ReadAllText(tmp_PreprocessorFilePath);
            string tmp_PreprocessorTextReplaced =
                tmp_PreprocessorText.Replace(_UNITY_USES_LOCATION, _UNITY_USES_LOCATION_OFF);

            tmp_PreprocessorTextReplaced = tmp_PreprocessorTextReplaced
                .Replace(_UNITY_USES_MICROPHONE, _UNITY_USES_MICROPHONE_OFF);

            tmp_PreprocessorTextReplaced =
                tmp_PreprocessorTextReplaced.Replace(_UNITY_USES_IAD, _UNITY_USES_IAD_OFF);

            tmp_PreprocessorTextReplaced =
                tmp_PreprocessorTextReplaced.Replace(_UNITY_USES_WEBCAM, _UNITY_USES_WEBCAM_OFF);

            File.WriteAllText(tmp_PreprocessorFilePath, tmp_PreprocessorTextReplaced, Encoding.UTF8);
        }
    }
}
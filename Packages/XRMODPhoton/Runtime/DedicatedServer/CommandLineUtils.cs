// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PhotonModule.Runtime.
// //
// // The Snake cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    public class CommandLineUtils
    {
        /// <summary>
        /// Signal if the executable was started in Headless mode by using the "-batchmode -nographics" command-line arguments
        /// <see cref="https://docs.unity3d.com/Manual/PlayerCommandLineArguments.html"/>
        /// </summary>
        /// <returns>True if in "Headless Mode", false otherwise</returns>
        public static bool IsHeadlessMode()
        {
            return Environment.CommandLine.Contains("-batchmode") && Environment.CommandLine.Contains("-nographics");
        }

        /// <summary>
        /// Get a list tuple of arguments starting with a specific prefix.
        /// </summary>
        /// <param name="_prefix">Prefix tested on each argument</param>
        /// <returns>List of tuples with argument name and argument value</returns>
        public static List<(string, string)> GetArgumentList(string _prefix)
        {
            var tmp_Output = new List<(string, string)>();

            var tmp_Args = Environment.GetCommandLineArgs();

            for (int i = 0; i < tmp_Args.Length; i++)
            {
                if (tmp_Args[i].Trim().StartsWith(_prefix) && tmp_Args.Length > i + 1)
                {
                    var tmp_Key = tmp_Args[i].Trim().Replace(_prefix, "");
                    var tmp_Value = tmp_Args[i + 1];

                    tmp_Output.Add((tmp_Key, tmp_Value));
                }
            }

            return tmp_Output;
        }

        /// <summary>
        /// Get the value of a specific command-line argument passed when starting the executable
        /// </summary>
        /// <example>
        /// Starting the binary with: "./my-game.exe -map street -type hide-and-seek"
        /// and calling `var mapValue = HeadlessUtils.GetArg("-map", "-m")` will return the string "street"
        /// </example>
        /// <param name="keys">List of possible keys for the argument</param>
        /// <returns>The string value of the argument if the at least 1 key was found, null otherwise</returns>
        public static bool TryGetArg(out string _argValue, params string[] _argNames)
        {
            var tmp_Args = Environment.GetCommandLineArgs();
            _argValue = null;

            for (int i = 0; i < tmp_Args.Length; i++)
            {
                foreach (var tmp_ArgName in _argNames)
                {
                    if (tmp_Args[i].Equals(tmp_ArgName) && tmp_Args.Length > i + 1)
                    {
                        _argValue = tmp_Args[i + 1];
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
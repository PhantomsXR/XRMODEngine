// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PhotonModule.Runtime.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

namespace Phantom.XRMOD.PhotonModule.Runtime
{
    public static class JsonMinifier
    {
        public static string Minify(this string _jsonString)
        {
            bool tmp_InString = false;
            bool tmp_InSingleLineComment = false;
            bool tmp_InMultiLineComment = false;

            int tmp_StringLength = _jsonString.Length;
            char tmp_PreviousChar = '\0';

            System.Text.StringBuilder tmp_MinifiedJson = new System.Text.StringBuilder(tmp_StringLength);

            for (int i = 0; i < tmp_StringLength; i++)
            {
                var tmp_CurrentChar = _jsonString[i];

                if (tmp_InSingleLineComment)
                {
                    if (tmp_CurrentChar == '\n' || tmp_CurrentChar == '\r')
                    {
                        tmp_InSingleLineComment = false;
                        tmp_MinifiedJson.Append(tmp_CurrentChar);
                    }

                    continue;
                }

                if (tmp_InMultiLineComment)
                {
                    if (tmp_PreviousChar == '*' && tmp_CurrentChar == '/')
                    {
                        tmp_InMultiLineComment = false;
                    }

                    continue;
                }

                if (tmp_InString)
                {
                    if (tmp_CurrentChar == '"' && tmp_PreviousChar != '\\')
                    {
                        tmp_InString = false;
                    }

                    tmp_MinifiedJson.Append(tmp_CurrentChar);
                    tmp_PreviousChar = tmp_CurrentChar;
                    continue;
                }

                if (tmp_CurrentChar == '/')
                {
                    if (i < tmp_StringLength - 1)
                    {
                        char tmp_NextChar = _jsonString[i + 1];
                        if (tmp_NextChar == '/')
                        {
                            tmp_InSingleLineComment = true;
                            continue;
                        }
                        else if (tmp_NextChar == '*')
                        {
                            tmp_InMultiLineComment = true;
                            i++;
                            continue;
                        }
                    }
                }

                if (!char.IsWhiteSpace(tmp_CurrentChar))
                {
                    if (tmp_CurrentChar == '"')
                    {
                        tmp_InString = true;
                    }

                    tmp_MinifiedJson.Append(tmp_CurrentChar);
                }

                tmp_PreviousChar = tmp_CurrentChar;
            }

            return tmp_MinifiedJson.ToString();
        }
    }
}
// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.XRMODLocalization.Editor.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using System.Text;

namespace Phantom.XRMOD.Localization.Editor
{
    public class ParseCSVUtility
    {
        public static List<string[]> ParseCsv(string[] _lines)
        {
            List<string[]> tmp_Result = new();

            foreach (string tmp_Line in _lines)
            {
                List<string> tmp_Row = new();
                StringBuilder tmp_Field = new();
                bool tmp_InQuotes = false;
                int i = 0;

                while (i < tmp_Line.Length)
                {
                    char tmp_C = tmp_Line[i];

                    if (tmp_InQuotes)
                    {
                        if (tmp_C == '"')
                        {
                            if (i + 1 < tmp_Line.Length && tmp_Line[i + 1] == '"')
                            {
                                tmp_Field.Append('"');
                                i += 2;
                            }
                            else
                            {
                                tmp_InQuotes = false;
                                i++;
                            }
                        }
                        else
                        {
                            tmp_Field.Append(tmp_C);
                            i++;
                        }
                    }
                    else
                    {
                        if (tmp_C == '"')
                        {
                            tmp_InQuotes = true;
                            i++;
                        }
                        else if (tmp_C == ',')
                        {
                            tmp_Row.Add(tmp_Field.ToString());
                            tmp_Field.Clear();
                            i++;
                        }
                        else
                        {
                            tmp_Field.Append(tmp_C);
                            i++;
                        }
                    }
                }

                tmp_Row.Add(tmp_Field.ToString()); // 最后一个字段
                tmp_Result.Add(tmp_Row.ToArray());
            }

            return tmp_Result;
        }


        public static string[] ParseCsv(string _line)
        {
            return SplitCsvLine(_line);
        }


        public static string[] SplitCsvLine(string _line)
        {
            var tmp_Values = new List<string>();
            bool tmp_InQuotes = false;
            var tmp_Sb = new System.Text.StringBuilder();

            for (int tmp_I = 0; tmp_I < _line.Length; tmp_I++)
            {
                char c = _line[tmp_I];
                switch (c)
                {
                    case '\"' when tmp_InQuotes && tmp_I + 1 < _line.Length && _line[tmp_I + 1] == '\"':
                        tmp_Sb.Append('\"');
                        tmp_I++; 
                        break;
                    case '\"':
                        tmp_InQuotes = !tmp_InQuotes;
                        break;
                    case ',' when !tmp_InQuotes:
                        tmp_Values.Add(tmp_Sb.ToString());
                        tmp_Sb.Clear();
                        break;
                    default:
                        tmp_Sb.Append(c);
                        break;
                }
            }

            tmp_Values.Add(tmp_Sb.ToString());
            return tmp_Values.ToArray();
        }
    }
}
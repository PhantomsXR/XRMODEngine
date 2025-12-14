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

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Unity.EditorCoroutines.Editor;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;

namespace Phantom.XRMOD.Localization.Editor
{
    public class CsvAITranslator
    {
        private static string promptTemplate;

        static string BuildPrompt(List<LocalizationRow> _rows, List<string> _languageTargets)
        {
            promptTemplate =
                AssetDatabase
                    .LoadAssetAtPath<TextAsset>(
                        "Packages/com.phantomsxr.foundation/Editor/XRMODLocalization/Assets/AITranslationPrompt.txt")
                    .text;
            string tmp_Header = "Key," + string.Join(",", _languageTargets);
            List<string> tmp_BodyLines = new();
            if (tmp_BodyLines == null) throw new ArgumentNullException(nameof(tmp_BodyLines));

            foreach (var tmp_Row in _rows)
            {
                List<string> tmp_Line = new() {tmp_Row.Key};
                foreach (var tmp_Lang in _languageTargets)
                    tmp_Line.Add(tmp_Row.Fields.GetValueOrDefault(tmp_Lang, ""));
                tmp_BodyLines.Add(string.Join(",", tmp_Line));
            }

            var tmp_ColumData = string.Join("\n", tmp_BodyLines);
            return promptTemplate.Replace("#YOUR LOCALIZATION TABLE#", $"{tmp_Header}\n{tmp_ColumData}");
        }


        static IEnumerator PostToGPT(string _prompt, Action<string> _onComplete)
        {
            var tmp_RequestData = new OpenAIRequest
            {
                messages = new() {new OpenAIMessage {role = "user", content = _prompt}}
            };
            string tmp_Json = JsonUtility.ToJson(tmp_RequestData);

            using UnityWebRequest tmp_Req = new UnityWebRequest("https://api.openai.com/v1/chat/completions", "POST");
            byte[] tmp_BodyRaw = System.Text.Encoding.UTF8.GetBytes(tmp_Json);
            tmp_Req.uploadHandler = new UploadHandlerRaw(tmp_BodyRaw);
            tmp_Req.downloadHandler = new DownloadHandlerBuffer();
            tmp_Req.SetRequestHeader("Content-Type", "application/json");
            tmp_Req.SetRequestHeader("Authorization", $"Bearer {XRMODLocalizationSettings.instance.APIKey}");

            yield return tmp_Req.SendWebRequest();

            if (tmp_Req.result == UnityWebRequest.Result.Success)
            {
                var tmp_Response = JsonUtility.FromJson<OpenAIResponse>(tmp_Req.downloadHandler.text);
                _onComplete?.Invoke(tmp_Response.choices[0].message.content);
            }
            else
            {
                Debug.LogError("GPT request failed:" + tmp_Req.error);
            }
        }

        static IEnumerator TranslateInBatches(List<LocalizationRow> _allRows, List<string> _targetLanguages,
            int _batchSize, Action _onComplete = null)
        {
            for (int tmp_I = 0; tmp_I < _allRows.Count; tmp_I += _batchSize)
            {
                var tmp_Batch = _allRows.Skip(tmp_I).Take(_batchSize).ToList();

                var tmp_RowsToTranslate =
                    tmp_Batch.Where(_row => _row.Fields.TryGetValue("ChineseSimplified", out string tmp_Zh)
                                            && !string.IsNullOrWhiteSpace(tmp_Zh)).ToList();


                string tmp_Prompt = BuildPrompt(tmp_Batch, _targetLanguages);
                bool tmp_IsDone = false;
                yield return PostToGPT(tmp_Prompt, (_resultText) =>
                {
                    try
                    {
                        var tmp_Parsed = ParseGPTResult(_resultText);

                        foreach (var tmp_Row in tmp_RowsToTranslate)
                        {
                            if (!tmp_Parsed.TryGetValue(tmp_Row.Key, out var tmp_LangDict)) continue;
                            foreach (var tmp_Lang in _targetLanguages)
                            {
                                if (tmp_LangDict.TryGetValue(tmp_Lang, out string tmp_TranslatedText))
                                {
                                    tmp_Row.Fields[tmp_Lang] = tmp_TranslatedText;
                                }
                            }
                        }
                    }
                    catch (Exception tmp_Ex)
                    {
                        Debug.LogError($"❌{tmp_Ex.Message}");
                    }

                    tmp_IsDone = true;
                });

                while (!tmp_IsDone)
                    yield return null;

                yield return new WaitForSeconds(2f);
            }

            _onComplete?.Invoke();
        }


        static Dictionary<string, Dictionary<string, string>> ParseGPTResult(string _resultText)
        {
            var tmp_CleanedLines = new List<string>();
            var tmp_Lines = _resultText.Split(new[] {'\n', '\r'}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var tmp_Line in tmp_Lines)
            {
                tmp_CleanedLines.Add(tmp_Line.Trim());
            }

            if (tmp_CleanedLines.Count == 0)
                throw new Exception("The formatted CSV content is not found, the GPT return format may change");

            var tmp_Result = new Dictionary<string, Dictionary<string, string>>();

            string[] tmp_Headers = SplitCsvLine(tmp_CleanedLines[0]);
            for (int i = 1; i < tmp_CleanedLines.Count; i++)
            {
                var tmp_Cells = SplitCsvLine(tmp_CleanedLines[i]);
                if (tmp_Cells.Length != tmp_Headers.Length) continue;

                string tmp_Key = tmp_Cells[0];
                var tmp_FieldDict = new Dictionary<string, string>();

                for (int j = 1; j < tmp_Headers.Length; j++)
                {
                    tmp_FieldDict[tmp_Headers[j]] = tmp_Cells[j];
                }

                tmp_Result[tmp_Key] = tmp_FieldDict;
            }

            return tmp_Result;
        }


        static string[] SplitCsvLine(string _line)
        {
            var tmp_Values = new List<string>();
            bool tmp_InQuotes = false;
            var tmp_Sb = new System.Text.StringBuilder();

            for (int tmp_I = 0; tmp_I < _line.Length; tmp_I++)
            {
                char tmp_C = _line[tmp_I];

                switch (tmp_C)
                {
                    // 处理转义双引号 ("")
                    case '\"' when tmp_InQuotes && tmp_I + 1 < _line.Length && _line[tmp_I + 1] == '\"':
                        tmp_Sb.Append('\"');
                        tmp_I++; // skip one
                        break;
                    case '\"':
                        tmp_InQuotes = !tmp_InQuotes;
                        break;
                    case ',' when !tmp_InQuotes:
                        tmp_Values.Add(tmp_Sb.ToString());
                        tmp_Sb.Clear();
                        break;
                    default:
                        tmp_Sb.Append(tmp_C);
                        break;
                }
            }

            tmp_Values.Add(tmp_Sb.ToString());
            return tmp_Values.ToArray();
        }


        public static void StartTranslation(string _filePath, Action _onComplete)
        {
            var (tmp_Rows, tmp_Langs) = LoadCSV(_filePath);
            EditorCoroutineUtility.StartCoroutineOwnerless(TranslateInBatches(tmp_Rows, tmp_Langs, 100,
                () =>
                {
                    SaveCsv(_filePath, tmp_Rows, tmp_Langs);
                    _onComplete?.Invoke();
                }));
        }

        private static (List<LocalizationRow> rows, List<string> languageColumns) LoadCSV(string _path)
        {
            var tmp_Rows = new List<LocalizationRow>();
            var tmp_LanguageColumns = new List<string>();

            if (!File.Exists(_path))
            {
                Debug.LogError("The CSV file does not exist:" + _path);
                return (tmp_Rows, tmp_LanguageColumns);
            }

            var tmp_Lines = File.ReadAllLines(_path, Encoding.UTF8);
            if (tmp_Lines.Length < 2)
            {
                Debug.LogError("CSV file content insufficient");
                return (tmp_Rows, tmp_LanguageColumns);
            }

            // 第一行为 header
            var tmp_Headers = tmp_Lines[0].Split(',');
            if (tmp_Headers.Length < 2 || tmp_Headers[0] != "Key")
            {
                Debug.LogError("CSV file format error: The first column must be Key");
                return (tmp_Rows, tmp_LanguageColumns);
            }

            tmp_LanguageColumns = new List<string>(tmp_Headers);
            tmp_LanguageColumns.RemoveAt(0);

            for (int i = 1; i < tmp_Lines.Length; i++)
            {
                var tmp_Line = tmp_Lines[i];
                var tmp_Columns = tmp_Line.Split(',');

                if (tmp_Columns.Length == 0 || string.IsNullOrWhiteSpace(tmp_Columns[0]))
                    continue;

                var row = new LocalizationRow {Key = tmp_Columns[0]};

                for (int j = 1; j < tmp_Headers.Length && j < tmp_Columns.Length; j++)
                {
                    row.Fields[tmp_Headers[j]] = tmp_Columns[j];
                }

                tmp_Rows.Add(row);
            }

            return (tmp_Rows, tmp_LanguageColumns);
        }

        private static void SaveCsv(string _path, List<LocalizationRow> _rows, List<string> _languageColumns)
        {
            using var tmp_Writer = new StreamWriter(_path, false, Encoding.UTF8);

            // 写 header
            var tmp_Headers = new List<string> {"Key"};
            tmp_Headers.AddRange(_languageColumns);
            tmp_Writer.WriteLine(string.Join(",", tmp_Headers));

            // 写内容
            foreach (var tmp_Row in _rows)
            {
                var tmp_Line = new List<string> {tmp_Row.Key};
                foreach (var tmp_Lang in _languageColumns)
                {
                    tmp_Row.Fields.TryGetValue(tmp_Lang, out string tmp_Value);
                    tmp_Line.Add(tmp_Value ?? "");
                }

                tmp_Writer.WriteLine(string.Join(",", tmp_Line));
            }
        }
    }
}
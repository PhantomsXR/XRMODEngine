using System.IO;
using System.Text;
using UnityEngine;
using UnityEditor;

namespace FoundationTest.Editor
{
    //[CustomEditor(typeof(TextAsset))]
    public class CsvInspector : UnityEditor.Editor
    {
        private string[,] csvData;
        private Vector2 scrollPos;
        private bool isDirty = false;

        public override void OnInspectorGUI()
        {
            TextAsset textAsset = (TextAsset) target;
            var tmp_AssetPath = AssetDatabase.GetAssetPath(textAsset);
            if (!tmp_AssetPath.EndsWith(".csv"))
            {
                base.OnInspectorGUI();
                return;
            }

            if (csvData == null)
            {
                csvData = ParseCSV(textAsset.text);
            }

            if (csvData == null)
            {
                EditorGUILayout.LabelField("CSV 解析失败。");
                return;
            }

            scrollPos = EditorGUILayout.BeginScrollView(scrollPos);

            int rows = csvData.GetLength(0);
            int cols = csvData.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                EditorGUILayout.BeginHorizontal();
                for (int j = 0; j < cols; j++)
                {
                    string original = csvData[i, j];
                    string updated = EditorGUILayout.TextField(original, GUILayout.Width(120));
                    if (original != updated)
                    {
                        csvData[i, j] = updated;
                        isDirty = true;
                    }
                }

                EditorGUILayout.EndHorizontal();
            }

            EditorGUILayout.EndScrollView();

            EditorGUILayout.Space(10);

            EditorGUI.BeginDisabledGroup(!isDirty);
            if (GUILayout.Button("保存 CSV 文件"))
            {
                SaveCSV(textAsset);
                isDirty = false;
            }

            EditorGUI.EndDisabledGroup();
        }

        private string[,] ParseCSV(string text)
        {
            var lines = text.Split(new[] {"\r\n", "\n"}, System.StringSplitOptions.RemoveEmptyEntries);
            if (lines.Length == 0) return null;

            int cols = lines[0].Split(',').Length;
            int rows = lines.Length;

            var result = new string[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var cells = lines[i].Split(',');
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = j < cells.Length ? cells[j] : "";
                }
            }

            return result;
        }

        private void SaveCSV(TextAsset asset)
        {
            string assetPath = AssetDatabase.GetAssetPath(asset);

            StringBuilder sb = new StringBuilder();
            int rows = csvData.GetLength(0);
            int cols = csvData.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    sb.Append(csvData[i, j]);
                    if (j < cols - 1) sb.Append(",");
                }

                sb.AppendLine();
            }

            File.WriteAllText(assetPath, sb.ToString(), Encoding.UTF8);
            AssetDatabase.Refresh();
            Debug.Log($"CSV 文件已保存：{assetPath}");
        }
    }
}
// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PackageTools.Editor.
// //
// // The Snake cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;

namespace Phantom.XRMOD.UnityFusion.Editor
{
    public class FindMissingScriptsUtility
    {
        [MenuItem("Tools/XR-MOD//Tools/Fix XRMOD Scripts Missing",priority = 97)]
        static void FindMissingScriptsMenuItem()
        {
            string[] tmp_PrefabPaths = AssetDatabase.GetAllAssetPaths()
                .Where(_path => _path.EndsWith(".prefab", System.StringComparison.OrdinalIgnoreCase)).ToArray();
            
            foreach (string tmp_PrefabPath in tmp_PrefabPaths)
            {
                GameObject tmp_Prefab = AssetDatabase.LoadAssetAtPath<GameObject>(tmp_PrefabPath);
                FixMissingScripts(tmp_Prefab);
            }

            var tmp_SDKInfo = File.ReadAllText(Path.Combine(Application.dataPath, "XR/Resources/SDKInformation.asset"));
            tmp_SDKInfo = tmp_SDKInfo.Replace("f82efca942b6046ff8f19408b4a45358", "366f65a33b24340908627dbc480a4c61");
            tmp_SDKInfo = tmp_SDKInfo.Replace("-264888889", "773222995");
            File.WriteAllText(Path.Combine(Application.dataPath, "XR/Resources/SDKInformation.asset"), tmp_SDKInfo);
            AssetDatabase.Refresh();
        }

        private static void FixMissingScripts(GameObject obj)
        {
            foreach (Component component in obj.GetComponentsInChildren<Component>(includeInactive:true))
            {
                if (component == null)
                {
                    var tmp_TargetPath = AssetDatabase.GetAssetPath(obj);
                    tmp_TargetPath = tmp_TargetPath.Replace("Assets", Application.dataPath); 
                    if (File.Exists($"{tmp_TargetPath}"))
                    {
                        var tmp_MetaData = File.ReadAllText($"{tmp_TargetPath}");
                        tmp_MetaData = tmp_MetaData.Replace("ea3532afe7eb7451b801ba78a08a9fad",
                            "d4693dad2f205416d91c259338d750af");
                        tmp_MetaData = tmp_MetaData.Replace("ea3532afe7eb7451b801ba78a08a9fad",
                            "97b473716bb7b42df9db8364c573e021");
                        tmp_MetaData = tmp_MetaData.Replace("d4693dad2f205416d91c259338d750af",
                            "97b473716bb7b42df9db8364c573e021");
                        tmp_MetaData = tmp_MetaData.Replace("a28e343f648045aea913d9e51e93867d",
                            "6ca6b00c9b57e444baf9b3d17ea3de3d");
                        tmp_MetaData = tmp_MetaData.Replace("7669274c4fa244cf956ac1ee7f6dafbe",
                            "880e3dd65ac4a42529610d1bb6dedea5");
                        
                        
                        var tmp_EditedMetaData = tmp_MetaData.Replace("759573810", "11500000");
                        File.WriteAllText($"{tmp_TargetPath}", tmp_EditedMetaData);
                        AssetDatabase.Refresh();
                        AssetDatabase.ImportAsset($"{tmp_TargetPath}.prefab");
                        Debug.Log($"Missing Component in {obj.name}");
                    }
                }
            }
        }
    }
}
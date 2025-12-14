// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UIExtension.Editor.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;

namespace Phantom.XRMOD.UIFramework.Editor
{
    public static class SerializedPropertyExtensions
    {
        public static T GetSerializedValue<T>(this SerializedProperty _property)
        {
            object tmp_Object = _property.serializedObject.targetObject;
            string[] tmp_PropertyNames = _property.propertyPath.Split('.');

            List<string> tmp_PropertyNamesClean = new List<String>();

            for (int tmp_Idx = 0; tmp_Idx < tmp_PropertyNames.Count(); tmp_Idx++)
            {
                if (tmp_PropertyNames[tmp_Idx] == "Array")
                {
                    if (tmp_Idx != (tmp_PropertyNames.Count() - 1) && tmp_PropertyNames[tmp_Idx + 1].StartsWith("data"))
                    {
                        int tmp_Pos = int.Parse(tmp_PropertyNames[tmp_Idx + 1].Split('[', ']')[1]);
                        tmp_PropertyNamesClean.Add($"-GetArray_{tmp_Pos}");
                        tmp_Idx++;
                    }
                    else
                        tmp_PropertyNamesClean.Add(tmp_PropertyNames[tmp_Idx]);
                }
                else
                    tmp_PropertyNamesClean.Add(tmp_PropertyNames[tmp_Idx]);
            }

            // Get the last object of the property path.
            foreach (string tmp_Path in tmp_PropertyNamesClean)
            {
                if (tmp_Path.StartsWith("-GetArray"))
                {
                    string[] tmp_Split = tmp_Path.Split('_');
                    int tmp_Index = int.Parse(tmp_Split[tmp_Split.Count() - 1]);
                    IList tmp_List = (IList) tmp_Object;
                    if (tmp_List != null) tmp_Object = tmp_List[tmp_Index];
                }
                else
                {
                    if (tmp_Object != null)
                        tmp_Object = tmp_Object.GetType()
                            .GetField(tmp_Path,
                                System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Public |
                                System.Reflection.BindingFlags.Instance)
                            ?.GetValue(tmp_Object);
                }
            }

            return (T) tmp_Object;
        }
    }
}
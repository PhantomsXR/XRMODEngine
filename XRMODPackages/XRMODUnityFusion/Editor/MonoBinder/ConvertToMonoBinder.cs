// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Runtime.CodeHook.Editor.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System.Collections.Generic;
using System.Threading.Tasks;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.UnityFusion.Runtime.CodeHook;
using UnityEditor;

namespace Phantom.XRMOD.Runtime.Editor
{
    public partial class MonoBinderEditor
    {
        [CustomEditor(typeof(XRMODBehaviour), true), CanEditMultipleObjects]
        public class MonoBehaviourEditor : UnityEditor.Editor
        {
            [MenuItem("CONTEXT/XRMODBehaviour/Convert To MonoBinder")]
            private static async void ConvertToAdapter(MenuCommand _command)
            {
                if (_command.context is not XRMODBehaviour tmp_Behaviour) return;
                var tmp_Target = tmp_Behaviour.gameObject;
                SharedData.TARGET_MONO = tmp_Behaviour;
                SharedData.TARGET_MONO.enabled = true;
                if (!EditorUtility.DisplayDialog("Convert to MonoBinder",
                        "Convert to MonoBinder will remove this script! Are you sure?", "Ok", "Cancel")) return;
                if (!tmp_Target) return;
                if (!tmp_Target.TryGetComponent(out MonoBinder tmp_MonoBinder))
                {
                    tmp_MonoBinder = tmp_Target.AddComponent<MonoBinder>();
                }

                var tmp_MonoType = tmp_Behaviour.GetType();
                tmp_MonoBinder.ScriptList ??= new List<MonoData>();

                var tmp_IndexOfScript =
                    tmp_MonoBinder.ScriptList.FindIndex(_data => _data.ClassName.Equals(tmp_MonoType.Name));

                if (tmp_IndexOfScript >= 0)
                {
                    // EditorUtility.DisplayDialog("Error", $"Script {tmp_MonoType.Name} is invalid!", "OK");
                    tmp_MonoBinder.ScriptList.RemoveAt(tmp_IndexOfScript);
                    tmp_MonoBinder.ScriptList.Insert(tmp_IndexOfScript, new MonoData()
                    {
                        ClassName = tmp_MonoType.Name,
                        ClassNamespace = tmp_MonoType.Namespace
                    });
                }
                else
                {
                    tmp_MonoBinder.ScriptList.Add(new MonoData()
                    {
                        ClassName = tmp_MonoType.Name,
                        ClassNamespace = tmp_MonoType.Namespace
                    });
                }


                await Task.Delay(50);
                await GrabFieldsType(tmp_MonoBinder);
                await Task.Delay(150);

                if (SharedData.TARGET_MONO)
                    SharedData.TARGET_MONO.enabled = false;
                SharedData.TARGET_MONO = null;
            }
        }
    }
}
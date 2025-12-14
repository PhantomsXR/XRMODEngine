// // /*===============================================================================
// // Copyright (C) 2022 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the XRMODEngineSettings.Editor.
// //
// // The ARMOD-SDK cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEditor;
using UnityEditor.XR.Management;
using UnityEditor.XR.Management.Metadata;
using UnityEngine.UIElements;
using UnityEngine.XR.Management;

namespace Phantom.XRMOD.Setup.Editor
{
    public class SimulationDrawer : AbstractDrawer, IFixer
    {
        private const string _CONST_HELP = "You have turned on simulation but haven't set up Plug-in yet.";

        public override VisualElement CreateVisualElement()
        {
            return DrawUtility.CreateSettingStateUI("Simulation", _CONST_HELP, () => CheckSimulation(), CheckedTexture, ErrorTexture,
                ActivePlugin);
        }

        private bool CheckSimulation()
        {
            var tmp_BuiltTargetGroup = BuildPipeline.GetBuildTargetGroup(Utility.GetSimulationTarget());
            string tmp_LoaderTypeName = "UnityEngine.XR.Simulation.SimulationLoader";
            return XRPackageMetadataStore.IsLoaderAssigned(tmp_LoaderTypeName, tmp_BuiltTargetGroup);
        }

        private void ActivePlugin()
        {
            var tmp_BuiltTargetGroup = BuildPipeline.GetBuildTargetGroup(Utility.GetSimulationTarget());
            EditorBuildSettings.TryGetConfigObject(XRGeneralSettings.k_SettingsKey,
                out XRGeneralSettingsPerBuildTarget tmp_BuildTargetSettings);
            var tmp_Settings = tmp_BuildTargetSettings.SettingsForBuildTarget(tmp_BuiltTargetGroup);

            string tmp_LoaderTypeName = "UnityEngine.XR.Simulation.SimulationLoader";

            XRPackageMetadataStore.AssignLoader(tmp_Settings.Manager, tmp_LoaderTypeName, tmp_BuiltTargetGroup);
        }

        void IFixer.DoFix()
        {
#if HANDHELD_ARMODULE_INSTALL
            ActivePlugin();
#endif
        }
    }
}
// /*===============================================================================
// Copyright (C) 2020 PhantomsXR Ltd. All Rights Reserved.
// 
// This file is part of the XR-MOD SDK.
// 
// The XR-MOD SDK cannot be copied, distributed, or made available to
// third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// 
// Contact nswell@phantomsxr.com for licensing requests.
// ===============================================================================*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.XRMODPackageTools.Editor.Filter;
using Phantom.XRMOD.XRMODPackageTools.Runtime;
using UnityEditor;
using UnityEditor.Build.Pipeline;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;
using Phantom.XRMOD.XRMODUtilites.Runtime;
using Object = UnityEngine.Object;

namespace Phantom.XRMOD.XRMODPackageTools.Editor
{
    public class BuildView : VisualElement
    {
        private static ProjectDetailCacheData projectDetailCacheData;
        private ProjectModel projectModel;

        private const string CONST_BUILD_PLATFORM_NAME = "Build Platform";
        private const string CONST_BUILD_GROUP_NAME = "Platform Group";
        private const string CONST_COMPRESSION_TYPE_NAME = "Compression Type";
        private const string CONST_ERROR_TITLE = "ERROR";


        public new class UxmlFactory : UxmlFactory<BuildView, VisualElement.UxmlTraits>
        {
        }

        public BuildView()
        {
            style.width = resolvedStyle.width;
            EditorNotificationCenter.Center.AddObserver(_data => { UpdateData(); },
                nameof(RefreshCommand));
            if (InitData())
            {
                InitElements();
            }
        }

        private void InitElements()
        {
            BuildPlatformEnumList();
            MakeHorizontalButtonList();
        }

        private void BuildPlatformEnumList()
        {
            var tmp_BuildPlatformEnumField =
                new EnumField(CONST_BUILD_PLATFORM_NAME,
                        Utility.GetBuildTargetViaSDKDeviceType(projectDetailCacheData.Configures.SDKDeviceType))
                    {name = "buildtarget"};
            var tmp_PlatformGroupEnumField =
                new EnumField(CONST_BUILD_GROUP_NAME,
                        Utility.GetBuildTargetGroupViaSDKDeviceType(projectDetailCacheData.Configures.SDKDeviceType
                        ))
                    {name = "buildtargetgroup"};
            var tmp_CompressionTypeEnumField = new EnumField(CONST_COMPRESSION_TYPE_NAME,
                projectDetailCacheData.BuildSettingData.BuildCompression) {name = "compressiontype"};


            Add(tmp_BuildPlatformEnumField);
            Add(tmp_PlatformGroupEnumField);
            Add(tmp_CompressionTypeEnumField);

            tmp_BuildPlatformEnumField.RegisterCallback<ChangeEvent<Enum>>(_evt =>
            {
                if (Enum.TryParse(_evt.newValue.ToString(), out BuildTarget tmp_Result))
                {
                    projectDetailCacheData.BuildSettingData.BuildTarget = tmp_Result;
                }
            });

            tmp_PlatformGroupEnumField.RegisterCallback<ChangeEvent<Enum>>(_evt =>
            {
                if (Enum.TryParse(_evt.newValue.ToString(), out BuildTargetGroup tmp_Result))
                {
                    projectDetailCacheData.BuildSettingData.BuildTargetGroup = tmp_Result;
                }
            });

            tmp_CompressionTypeEnumField.RegisterCallback<ChangeEvent<Enum>>(_evt =>
            {
                if (Enum.TryParse(_evt.newValue.ToString(), out BuildCompressionType tmp_Result))
                {
                    projectDetailCacheData.BuildSettingData.BuildCompression = tmp_Result;
                }
            });
        }

        private void MakeHorizontalButtonList()
        {
            var tmp_BuildButton = new Button(async () => { StartBuildExperience(); })
                {text = "Build Experience", name = "builbutton"};
            tmp_BuildButton.AddToClassList("build-button");

            var tmp_DropdownButton = new VisualElement();
            var tmp_DropdownButtonImg = new VisualElement();
            tmp_DropdownButtonImg.AddToClassList("dropdown-button-image");

            tmp_DropdownButton.Add(tmp_DropdownButtonImg);
            tmp_DropdownButton.AddManipulator(new Clickable(OpenDropdownMenu));
            tmp_DropdownButton.AddToClassList("unity-button");
            tmp_DropdownButton.AddToClassList("dropdown-button");


            var tmp_HorizontalVisualElement = new VisualElement();
            tmp_HorizontalVisualElement.style.flexDirection = new StyleEnum<FlexDirection>(FlexDirection.RowReverse);
            tmp_HorizontalVisualElement.Add(tmp_DropdownButton);
            tmp_HorizontalVisualElement.Add(tmp_BuildButton);
            tmp_HorizontalVisualElement.AddToClassList("horizontal-button");
            Add(tmp_HorizontalVisualElement);
        }

        private void OpenDropdownMenu()
        {
            GenericMenu tmp_Menu = new GenericMenu();
            tmp_Menu.AddItem(new GUIContent("Build (MonoBinder Convert)"), false,
                () => { StartBuildExperience(true); });

            tmp_Menu.AddSeparator("");

            tmp_Menu.AddItem(new GUIContent("Show in file browser"), false, async () =>
            {
                var tmp_Path = Path.Combine(Application.dataPath.Replace("Assets", ""),
                    $"ServerData/{RuntimePlatformHelper.GetPlatformName().ToLower()}" +
                    $"/{projectModel.DisplayName.ToLower()}/{projectModel.DisplayName.ToLower()}.json");
                if (File.Exists(tmp_Path))
                    EditorUtility.RevealInFinder(tmp_Path);
                else
                    EditorUtility.DisplayDialog(CONST_ERROR_TITLE, "You haven't built an AR-Experience", "Ok");
            });


            tmp_Menu.AddItem(new GUIContent("Refresh"), false, RefreshAppDomain);

            tmp_Menu.ShowAsContext();
        }

        private async void StartBuildExperience(bool _autoMonoBinderConvert = false)
        {
            if (!EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo()) return;
            if (projectDetailCacheData.Configures)
                EditorUtility.SetDirty(projectDetailCacheData.Configures);
            if (projectDetailCacheData.BuildSettingData)
                EditorUtility.SetDirty(projectDetailCacheData.BuildSettingData);
            AssetDatabase.SaveAssets();
            projectModel.IsBuilding = true;
            projectDetailCacheData.BuildSettingData.AutoConvertOptions = _autoMonoBinderConvert;
            BuildDll();

            await Task.Delay(500);
            ExecuteBuildAssetBundle();

            projectModel.IsBuilding = false;
        }

        private bool InitData()
        {
            var tmp_EditingProjectData = PackageToolsEditor.ALL_PROJECT_CACHE.GetEditingProjectData();
            if (!tmp_EditingProjectData) return false;
            projectModel = tmp_EditingProjectData.Project;
            projectDetailCacheData = tmp_EditingProjectData.DetailCacheData;
            return true;
        }

        private void UpdateData()
        {
            InitData();

            //Reset data
            var tmp_BuildTarget = this.Q<EnumField>("buildtarget");
            if (tmp_BuildTarget != null)
                tmp_BuildTarget.value = projectDetailCacheData.BuildSettingData.BuildTarget;

            var tmp_BuildGroup = this.Q<EnumField>("buildtargetgroup");
            if (tmp_BuildGroup != null)
                tmp_BuildGroup.value = projectDetailCacheData.BuildSettingData.BuildTargetGroup;

            var tmp_BuildCompression = this.Q<EnumField>("compressiontype");
            if (tmp_BuildCompression != null)
                tmp_BuildCompression.value = projectDetailCacheData.BuildSettingData.BuildCompression;
        }

        private static async void RefreshAppDomain()
        {
            try
            {
                await EditorNotificationCenter.Center.PostNotificationAsync("AutoInjectPostProcessor",
                    new BaseNotificationData());

                string tmp_ProjectAutoGenerationPath =
                    Path.Combine(projectDetailCacheData.GetProjectPath(), "AutomaticGenerated");
                if (!Directory.Exists(tmp_ProjectAutoGenerationPath))
                    Directory.CreateDirectory(tmp_ProjectAutoGenerationPath);
                if (string.IsNullOrEmpty(projectDetailCacheData.Configures.DomainName)) return;
                var tmp_SourceFilePath = Path.Combine(Utility.GetScriptAssembliesFolder,
                    new DirectoryInfo(projectDetailCacheData.GetProjectPath()).Name);

                Utility.CopyFileToProject($"{tmp_SourceFilePath}.runtime.dll", tmp_ProjectAutoGenerationPath,
                    "bytes");
                Utility.CopyFileToProject($"{tmp_SourceFilePath}.runtime.pdb",
                    tmp_ProjectAutoGenerationPath, "bytes");
            }
            catch (Exception e)
            {
                Debug.LogError(e);
                throw; // TODO handle exception
            }
        }

        private async void ExecuteBuildAssetBundle()
        {
            var tmp_ProjectName = new DirectoryInfo(projectDetailCacheData.GetProjectPath()).Name;


            ProcessShareData.GetInstance.projectName = tmp_ProjectName;
            ProcessShareData.GetInstance.projectDetailCacheData = projectDetailCacheData;
            ProcessShareData.GetInstance.projectPath = projectDetailCacheData.GetProjectPath();

            var tmp_Command = new CreateAutomaticGeneratedFolderCommand();
            tmp_Command
                .SetNext(new CreateSaveBundleFolderCommand())
                .SetNext(new CreateARPropertyFileCommand())
                .SetNext(new CreateScriptCommand())
                .SetNext(new CreateLocalizationDataCommand())
                .SetNext(new CreateRuntimeAssetReferenceDatabaseCommand())
                .SetNext(new CreateContentRecordsCommand())
                .SetNext(new CreateBuildCompressionCommand())
                .SetNext(new CreateRuntimeAssetCommand());
            await tmp_Command.Execute(); 
            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();


            var tmp_StateCode = BundlePacker.ScriptableBuildPipeline(projectModel.DisplayName.ToLower(),
                ProcessShareData.GetInstance.addressableName,
                ProcessShareData.GetInstance.tempAssetsPath,
                projectDetailCacheData.BuildSettingData.BuildTarget,
                projectDetailCacheData.BuildSettingData.BuildTargetGroup,
                ProcessShareData.GetInstance.buildCompression,
                ProcessShareData.GetInstance.saveBundlePath
            );


            if (tmp_StateCode == ReturnCode.UnsavedChanges)
            {
                EditorUtility.DisplayDialog("ERROR", "Your Scene was changed,But you not saved changes", "OK");
            }

            AssetDatabase.Refresh();

            if (Event.current is {rawType: EventType.Repaint})
                GUIUtility.ExitGUI();

            ProcessShareData.GetInstance.Dispose();
        }

        private async void BuildDll()
        {
            var tmp_Group = BuildPipeline.GetBuildTargetGroup(projectDetailCacheData.BuildSettingData.BuildTarget);

            UnityEditor.Build.Player.ScriptCompilationSettings tmp_ScriptCompilationSettings =
                new UnityEditor.Build.Player.ScriptCompilationSettings();
            tmp_ScriptCompilationSettings.group = tmp_Group;
            tmp_ScriptCompilationSettings.target = projectDetailCacheData.BuildSettingData.BuildTarget;

            var tmp_SourceFilePath = Path.Combine(Utility.GetScriptAssembliesFolder, "Runtime");
            Directory.CreateDirectory(tmp_SourceFilePath);
            UnityEditor.Build.Player.ScriptCompilationResult tmp_ScriptCompilationResult =
                UnityEditor.Build.Player.PlayerBuildInterface.CompilePlayerScripts(tmp_ScriptCompilationSettings,
                    tmp_SourceFilePath);

            await EditorNotificationCenter.Center.PostNotificationAsync("AutoInjectPostProcessor",
                new BaseNotificationData());
#if UNITY_2022
            UnityEditor.EditorUtility.ClearProgressBar();
#endif
        }
    }
}
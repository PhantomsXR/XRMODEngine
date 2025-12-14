// // /*===============================================================================
// // Copyright (C) 2023 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the com.Phantoms.UnityFusion.Editor.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
#if USE_GOAP
using Goap.Agent.Core;
using Goap.Runtime;
#endif
using JetBrains.Annotations;
using UnityEditor;
using UnityEngine;
using UnityFusion.CLRBinding.Adapter;
using UnityFusion.Runtime.Enviorment;

public class CLRCodeHelperEditor : EditorWindow
{
    private static CLRCodeHelperEditor _CLR_CODE_WINDOW;
    private ILCodeBaseCollection ilCodeBaseCollection;

    private string scriptAssembliesPath;
    private Assembly assembly;
    private string typeFullName;
    private string savePath;
    private Vector2 scrollViewPos;
    private int selectId;
    private string searchText;
    private bool toggleAll;
    private bool unToggleAll;

    [MenuItem("Tools/UnityFusion/CLR Helper")]
    private static void GetILCodeWindow()
    {
        _CLR_CODE_WINDOW = GetWindow<CLRCodeHelperEditor>();
        _CLR_CODE_WINDOW.Show();
        MakeSureData();
        _CLR_CODE_WINDOW.scriptAssembliesPath = Application.dataPath.Replace("Assets", "Library/ScriptAssemblies");
        _CLR_CODE_WINDOW.GetAssemblies();
        _CLR_CODE_WINDOW.GetAllTypes();
    }

    private void OnGUI()
    {
        if (_CLR_CODE_WINDOW == null)
        {
            GetILCodeWindow();
        }

        if (ilCodeBaseCollection == null) return;


        // Assemblies selection
        selectId = ilCodeBaseCollection.CurrentSelectAssemblyIdx;
        ilCodeBaseCollection.CurrentSelectAssemblyIdx = EditorGUILayout.Popup(new GUIContent("Assembly"),
            ilCodeBaseCollection.CurrentSelectAssemblyIdx, ilCodeBaseCollection.AllAssemblies.ToArray());

        searchText = EditorGUILayout.TextField("Search", searchText);

        if (selectId != ilCodeBaseCollection.CurrentSelectAssemblyIdx)
        {
            selectId = ilCodeBaseCollection.CurrentSelectAssemblyIdx;
            GetAllTypes();
        }

        List<ILCodeBaseCollection.AllTypesInAssembly> tmp_TempTypes =
            new List<ILCodeBaseCollection.AllTypesInAssembly>();
        if (!string.IsNullOrEmpty(searchText))
        {
            tmp_TempTypes = ilCodeBaseCollection.TypesInAssembly
                .Where(_data => _data.TypeInAssembly.ToLower().Contains(searchText.ToLower())).ToList();
        }
        else
        {
            tmp_TempTypes = ilCodeBaseCollection.TypesInAssembly;
        }

        GUILayout.BeginHorizontal();
        toggleAll = GUILayout.Button("Toggle All");
        unToggleAll = GUILayout.Button("UnToggle All");
        GUILayout.EndHorizontal();
        // Types in the assembly
        scrollViewPos = EditorGUILayout.BeginScrollView(scrollViewPos);
        for (int tmp_Idx = 0; tmp_Idx < tmp_TempTypes.Count; tmp_Idx++)
        {
            var tmp_Type = tmp_TempTypes[tmp_Idx];
            tmp_Type.Toggled = EditorGUILayout.ToggleLeft(tmp_Type.TypeInAssembly, tmp_Type.Toggled);
            if (toggleAll)
            {
                tmp_Type.Toggled = !tmp_Type.Toggled;
            }

            if (unToggleAll)
            {
                tmp_Type.Toggled = false;
            }
        }

        EditorGUILayout.EndScrollView();

        EditorGUILayout.BeginHorizontal();


        DrawDropdown();

        if (GUILayout.Button("Show in file browser"))
        {
            EditorUtility.RevealInFinder(savePath);
        }

        EditorGUILayout.EndHorizontal();

        if (EditorUtility.IsDirty(ilCodeBaseCollection))
        {
            EditorUtility.SetDirty(ilCodeBaseCollection);
            AssetDatabase.SaveAssets();
        }
    }

    private void GenerateCLR()
    {
        savePath = EditorUtility.SaveFolderPanel("Save generated code", "Assets", "");
        if (string.IsNullOrEmpty(savePath)) return;

        List<Type> tmp_AllTypes = new List<Type>();
        foreach (var tmp_Assembly in ilCodeBaseCollection.TypesInAssembly.Where(_x => _x.Toggled))
        {
            var tmp_Type = assembly.GetType(tmp_Assembly.TypeInAssembly);
            tmp_AllTypes.Add(tmp_Type);
        }

        UnityFusion.Runtime.CLRBinding.BindingCodeGenerator.GenerateBindingCode(tmp_AllTypes, savePath);
    }

    void GenerateCLRBindingByAnalysis(string _dllPath)
    {
        savePath = EditorUtility.SaveFolderPanel("Save generated code", "Assets", "");
        if (string.IsNullOrEmpty(savePath)) return;

        //用新的分析热更dll调用引用来生成绑定代码
        UnityFusion.Runtime.Enviorment.AppDomain tmp_Domain = new UnityFusion.Runtime.Enviorment.AppDomain();
        using var tmp_Fs = new FileStream(_dllPath, FileMode.Open, FileAccess.Read);
        tmp_Domain.LoadAssembly(tmp_Fs);

        //Crossbind Adapter is needed to generate the correct binding code
        InitUnityFusion(tmp_Domain);

        UnityFusion.Runtime.CLRBinding.BindingCodeGenerator.GenerateBindingCode(tmp_Domain, savePath);
    }

    private void GenerateAdapter()
    {
        savePath = EditorUtility.SaveFolderPanel("Save generated code", "Assets", "");
        if (string.IsNullOrEmpty(savePath)) return;
        try
        {
            List<Type> tmp_AllTypes = new List<Type>();
            foreach (var tmp_Assembly in ilCodeBaseCollection.TypesInAssembly.Where(_x => _x.Toggled))
            {
                if (tmp_Assembly.TypeInAssembly.Contains("UnityFusion")) continue;
                var tmp_Type = assembly.GetType(tmp_Assembly.TypeInAssembly);
                tmp_AllTypes.Add(tmp_Type);
            }


            foreach (var tmp_Assembly in ilCodeBaseCollection.TypesInAssembly.Where(_x => _x.Toggled))
            {
                var tmp_Type = assembly.GetType(tmp_Assembly.TypeInAssembly);


                using System.IO.StreamWriter tmp_SW =
                    new System.IO.StreamWriter($"{savePath}/{tmp_Type.Name}_Adapter.cs");
                tmp_SW.WriteLine(
                    UnityFusion.Runtime.Enviorment.CrossBindingCodeGenerator.GenerateCrossBindingAdapterCode(
                        tmp_Type,
                        "UnityFusion.CLRBinding.Adapter"));
            }
        }
        catch (Exception tmp_Exception)
        {
            Debug.LogError(tmp_Exception);
        }
    }


    private void GenerateCLRViaStr()
    {
        savePath = EditorUtility.SaveFolderPanel("Save generated code", "Assets", "");
        if (string.IsNullOrEmpty(savePath)) return;

        List<Type> tmp_AllTypes = new List<Type>()
        {
        };
        UnityFusion.Runtime.CLRBinding.BindingCodeGenerator.GenerateBindingCode(tmp_AllTypes, savePath);
    }

    private void GetAllTypes()
    {
        ilCodeBaseCollection.TypesInAssembly.Clear();
        var tmp_AssemblyPath = Path.Combine(scriptAssembliesPath,
            ilCodeBaseCollection.AllAssemblies[ilCodeBaseCollection.CurrentSelectAssemblyIdx]);

        if (!File.Exists(tmp_AssemblyPath))
        {
            tmp_AssemblyPath = Path.Combine(EditorApplication.applicationPath, "Contents/Managed/UnityEngine",
                ilCodeBaseCollection.AllAssemblies[ilCodeBaseCollection.CurrentSelectAssemblyIdx]);
        }


        if (!File.Exists(tmp_AssemblyPath))
        {
            tmp_AssemblyPath = Path.Combine($"{Application.dataPath}/Photon/Fusion/Assemblies",
                ilCodeBaseCollection.AllAssemblies[ilCodeBaseCollection.CurrentSelectAssemblyIdx]);
        }


        assembly = Assembly.LoadFrom(tmp_AssemblyPath);
        var tmp_Types = assembly.GetTypes().Where(_x => (_x.IsClass || _x.IsInterface || _x.IsValueType) && _x.IsPublic)
            .ToList();
        foreach (Type tmp_Type in tmp_Types)
        {
            if (tmp_Type.FullName == null
                || tmp_Type.FullName.Contains("+")
                || tmp_Type.FullName.Contains("~")
                || tmp_Type.FullName.Contains("`1")
                || tmp_Type.FullName.Contains("Burst")) continue;

            ilCodeBaseCollection.TypesInAssembly.Add(new ILCodeBaseCollection.AllTypesInAssembly()
            {
                TypeInAssembly = tmp_Type.FullName,
                Toggled = false
            });
        }
    }

    private void GetAssemblies()
    {
        // Get package manager assembly files path
        ilCodeBaseCollection.AllAssemblies = Directory.GetFiles(scriptAssembliesPath, "*.dll").ToList();
        // Get built-in assembly files path
        var tmp_BuiltinAssembliesPath = Path.Combine(EditorApplication.applicationPath, "Contents/Managed/UnityEngine");
        var tmp_AllBuiltinAssembliesPath = Directory.GetFiles(tmp_BuiltinAssembliesPath, "*.dll").ToList();
        ilCodeBaseCollection.AllAssemblies.AddRange(tmp_AllBuiltinAssembliesPath);
        if (Directory.Exists($"{Application.dataPath}/Photon/Fusion/Assemblies"))
        {
            ilCodeBaseCollection.AllAssemblies.AddRange(Directory
                .GetFiles($"{Application.dataPath}/Photon/Fusion/Assemblies", "*.dll").ToList());
        }

        for (int tmp_Idx = 0; tmp_Idx < ilCodeBaseCollection.AllAssemblies.Count; tmp_Idx++)
        {
            var tmp_FileNameOfAssembly = Path.GetFileName(ilCodeBaseCollection.AllAssemblies[tmp_Idx]);

            // Ignore the editor assemblies
            if (tmp_FileNameOfAssembly.Contains("Editor")) continue;
            if (tmp_FileNameOfAssembly.Contains("UnityFusion")) continue;
            if (tmp_FileNameOfAssembly.Contains("Test")) continue;
            if (tmp_FileNameOfAssembly.Contains("Obfuscator")) continue;
            ilCodeBaseCollection.AllAssemblies[tmp_Idx] =
                Path.GetFileName(ilCodeBaseCollection.AllAssemblies[tmp_Idx]);
        }
    }

    private static void MakeSureData()
    {
        var tmp_FilePath = "Assets/Editor Default Resources/SDK Settings/ILCodeBaseCollection.asset";
        _CLR_CODE_WINDOW.ilCodeBaseCollection = AssetDatabase.LoadAssetAtPath<ILCodeBaseCollection>(tmp_FilePath);

        if (_CLR_CODE_WINDOW.ilCodeBaseCollection != null) return;

        _CLR_CODE_WINDOW.ilCodeBaseCollection = ScriptableObject.CreateInstance<ILCodeBaseCollection>();
        AssetDatabase.CreateAsset(_CLR_CODE_WINDOW.ilCodeBaseCollection, tmp_FilePath);
        AssetDatabase.Refresh();
        AssetDatabase.SaveAssets();
    }

    private void DrawDropdown()
    {
        if (EditorGUILayout.DropdownButton(new GUIContent("Generate"), FocusType.Keyboard))
        {
            GenericMenu tmp_Menu = new GenericMenu();
            tmp_Menu.AddItem(new GUIContent("Generate CLR"), false, HandleCLRGenerate, "");
            tmp_Menu.AddItem(new GUIContent("Generate Adapter"), false, HandleAdapterGenerate, "");
            tmp_Menu.AddItem(new GUIContent("Generate CLR via Analysis"), false, HandleAnalysisGenerate, "");
            tmp_Menu.AddItem(new GUIContent("Generate CLR via String"), false, _obj => { GenerateCLRViaStr(); }, "");
            tmp_Menu.ShowAsContext();
        }

        void HandleCLRGenerate(object _parameter)
        {
            GenerateCLR();
        }

        void HandleAdapterGenerate(object _param)
        {
            GenerateAdapter();
        }

        void HandleAnalysisGenerate(object _param)
        {
            GenerateCLRBindingByAnalysis($"{scriptAssembliesPath}/{ilCodeBaseCollection.AllAssemblies[selectId]}");
        }
    }


    static void InitUnityFusion(UnityFusion.Runtime.Enviorment.AppDomain _domain)
    {
        //这里需要注册所有热更DLL中用到的跨域继承Adapter，否则无法正确抓取引用
        _domain.RegisterCrossBindingAdaptor(new AsyncStateMachineClassInheritanceAdaptor());
        _domain.RegisterCrossBindingAdaptor(new CoroutineAdapter());
        _domain.RegisterCrossBindingAdaptor(new XRMODBehaviourAdapter());
        _domain.RegisterCrossBindingAdaptor(new BaseNotificationDataAdapter());
        _domain.RegisterCrossBindingAdaptor(new ExceptionAdapter());
        _domain.RegisterCrossBindingAdaptor(new IComparer_1_TransformAdapter());
        _domain.RegisterCrossBindingAdaptor(new UIBehaviourAdaptor());
        _domain.RegisterCrossBindingAdaptor(new ScriptableObjectAdapter());
        _domain.RegisterCrossBindingAdaptor(new MonoBehaviourAdapter());
#if USE_GOAP
        _domain.RegisterCrossBindingAdaptor(new GoapConfigInitializerBaseAdapter());
        _domain.RegisterCrossBindingAdaptor(new WorldKeyBaseAdapter());
        _domain.RegisterCrossBindingAdaptor(new TargetKeyBaseAdapter());
        _domain.RegisterCrossBindingAdaptor(new LocalTargetSensorBaseAdapter());
        _domain.RegisterCrossBindingAdaptor(new LocalWorldSensorBaseAdapter());
        _domain.RegisterCrossBindingAdaptor(new GoalBaseAdapter());
        _domain.RegisterCrossBindingAdaptor(new IActionDataAdapter());
        _domain.RegisterCrossBindingAdaptor(new GlobalWorldSensorBaseAdapter());
        _domain.RegisterCrossBindingAdaptor(new MultiSensorBaseAdapter());
        _domain.RegisterCrossBindingAdaptor(new CapabilityFactoryBaseAdapter());
        _domain.RegisterCrossBindingAdaptor(new ScriptableCapabilityFactoryBaseAdapter());
        _domain.RegisterCrossBindingAdaptor(new MonoCapabilityFactoryBaseAdapter());
        _domain.RegisterCrossBindingAdaptor(new AgentTypeFactoryBaseAdapter());
        _domain.RegisterCrossBindingAdaptor(new GoapActionBaseAdapter());
        _domain.RegisterCrossBindingAdaptor(new GoapActionBase2Adapter());
        _domain.RegisterCrossBindingAdaptor(new ITargetAdapter());
        _domain.RegisterCrossBindingAdaptor(new IActionPropertiesAdapter());
#endif
        _domain.RegisterCrossBindingAdaptor(new SelectableAdapter());
        _domain.RegisterCrossBindingAdaptor(new MaskableGraphicAdapter());
        _domain.RegisterValueTypeBinder(typeof(Vector3), new Vector3Binder());
        _domain.RegisterValueTypeBinder(typeof(Vector2), new Vector2Binder());
        _domain.RegisterValueTypeBinder(typeof(Quaternion), new QuaternionBinder());
    }
}
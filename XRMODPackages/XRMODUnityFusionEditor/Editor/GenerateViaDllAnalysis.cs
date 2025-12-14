// // /*===============================================================================
// // Copyright (C) 2024 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Editor.
// //
// // The  XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEditor;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Transformers;
using UnityFusion.CLRBinding.Adapter;

public class GenerateViaDllAnalysis
{
    [MenuItem("Tools/UnityFusion/Generate CLR Binding Code by Analysis")]
    // ReSharper disable once InconsistentNaming
    static void GenerateCLRBindingByAnalysis()
    {
        string tmp_DllPath = EditorUtility.OpenFilePanel("Select the dll", "", "dll,bytes");

        if (string.IsNullOrEmpty(tmp_DllPath)) return;
        string tmp_ScriptFolderPath = EditorUtility.SaveFolderPanel("Saved Script folder", "", "");

        //用新的分析热更dll调用引用来生成绑定代码
        UnityFusion.Runtime.Enviorment.AppDomain tmp_Domain = new UnityFusion.Runtime.Enviorment.AppDomain();
        using System.IO.FileStream tmp_Fs =
            new System.IO.FileStream(tmp_DllPath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
        tmp_Domain.LoadAssembly(tmp_Fs);

        //Crossbind Adapter is needed to generate the correct binding code
        InitUnityFusion(tmp_Domain);

        UnityFusion.Runtime.CLRBinding.BindingCodeGenerator.GenerateBindingCode(tmp_Domain, tmp_ScriptFolderPath);
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
        _domain.RegisterCrossBindingAdaptor(new IInjectorAdapter());
#if USE_GOAP
        _domain.RegisterCrossBindingAdaptor(new GoapConfigInitializerBaseAdapter());

        _domain.RegisterCrossBindingAdaptor(new GoapActionBase2Adapter());
        _domain.RegisterCrossBindingAdaptor(new GoapActionBaseAdapter());
        _domain.RegisterCrossBindingAdaptor(new AgentTypeFactoryBaseAdapter());
        _domain.RegisterCrossBindingAdaptor(new CapabilityFactoryBaseAdapter());
        _domain.RegisterCrossBindingAdaptor(new MonoCapabilityFactoryBaseAdapter());
        _domain.RegisterCrossBindingAdaptor(new ScriptableCapabilityFactoryBaseAdapter());

        _domain.RegisterCrossBindingAdaptor(new GoalBaseAdapter());
        _domain.RegisterCrossBindingAdaptor(new GlobalWorldSensorBaseAdapter());

        _domain.RegisterCrossBindingAdaptor(new WorldKeyBaseAdapter());
        _domain.RegisterCrossBindingAdaptor(new TargetKeyBaseAdapter());

        _domain.RegisterCrossBindingAdaptor(new LocalTargetSensorBaseAdapter());
        _domain.RegisterCrossBindingAdaptor(new LocalWorldSensorBaseAdapter());
        _domain.RegisterCrossBindingAdaptor(new MultiSensorBaseAdapter());

        _domain.RegisterCrossBindingAdaptor(new IActionAdapter());
        _domain.RegisterCrossBindingAdaptor(new IActionPropertiesAdapter());
        _domain.RegisterCrossBindingAdaptor(new IGoapActionAdapter());
        _domain.RegisterCrossBindingAdaptor(new ITargetAdapter());
        _domain.RegisterCrossBindingAdaptor(new IActionDataAdapter());

#endif

#if USE_XRI
        _domain.RegisterCrossBindingAdaptor(new XRBaseGrabTransformerAdapter());
#endif


        _domain.RegisterValueTypeBinder(typeof(Vector3), new Vector3Binder());
        _domain.RegisterValueTypeBinder(typeof(Vector2), new Vector2Binder());
        _domain.RegisterValueTypeBinder(typeof(Quaternion), new QuaternionBinder());
    }
}
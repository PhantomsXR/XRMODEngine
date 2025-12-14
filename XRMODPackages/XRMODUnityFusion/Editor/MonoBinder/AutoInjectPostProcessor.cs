// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.Editor.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Phantom.XRMOD.ActionNotification.Runtime;
using Phantom.XRMOD.XRMODPackageTools.Editor;
using UnityEditor;
using UnityEngine;
using MethodAttributes = Mono.Cecil.MethodAttributes;
using ParameterAttributes = Mono.Cecil.ParameterAttributes;


namespace Phantom.XRMOD.Runtime.Editor
{
    public static class AutoInjectPostProcessor
    {
        [InitializeOnLoadMethod]
        private static void RegisterAutoInject()
        {
            EditorNotificationCenter.Center.AddAsyncObserver(BuidInject, nameof(AutoInjectPostProcessor));
            EditorNotificationCenter.Center.AddAsyncObserver(PlayModeInject, "PlayModeInjectPostProcessor");
        }
 
        private static Task<object> BuidInject(BaseNotificationData _baseNotification)
        {
            var tmp_EditingProjectData = PackageToolsEditor.ALL_PROJECT_CACHE.GetEditingProjectData();
            if (!tmp_EditingProjectData) Task.FromResult<object>(null);

            var tmp_ProjectDetailCacheData = tmp_EditingProjectData.DetailCacheData;
            var tmp_DllName = $"{new DirectoryInfo(tmp_ProjectDetailCacheData.GetProjectPath()).Name}.Runtime.dll";
            var tmp_DllPath = Path.Combine(Utility.GetScriptAssembliesFolder, "Runtime", tmp_DllName);

            var tmp_InjectWorkSpacePath = Path.Combine(Utility.GetScriptAssembliesFolder, "Runtime", "InjectWorkSpace");

            if (!Directory.Exists(tmp_InjectWorkSpacePath))
            {
                Directory.CreateDirectory(tmp_InjectWorkSpacePath);
            }

            File.Copy(tmp_DllPath, Path.Combine(tmp_InjectWorkSpacePath, tmp_DllName), true);

            var tmp_PdbFilePath = Path.ChangeExtension(tmp_DllPath, "pdb");
            File.Copy(tmp_PdbFilePath, Path.Combine(tmp_InjectWorkSpacePath, Path.ChangeExtension(tmp_DllName, "pdb")),
                true);

            var tmp_SourceFilePath = Path.Combine(tmp_InjectWorkSpacePath, tmp_DllName);
            InjectCodeIntoMethods(tmp_SourceFilePath, tmp_SourceFilePath);
            return Task.FromResult<object>(null);
        }

        private static async Task<object> PlayModeInject(BaseNotificationData _baseNotification)
        {
            var tmp_EditingProjectData = PackageToolsEditor.ALL_PROJECT_CACHE.GetEditingProjectData();
            if (!tmp_EditingProjectData) return await Task.FromResult<bool>(false);

            var tmp_ProjectDetailCacheData = tmp_EditingProjectData.DetailCacheData;
            var tmp_DllPath = Path.Combine(Utility.GetScriptAssembliesFolder,
                $"{new DirectoryInfo(tmp_ProjectDetailCacheData.GetProjectPath()).Name}.Runtime.dll");

            var tmp_OutDllPath = Path.Combine(Utility.GetScriptAssembliesFolder, "Editor",
                $"{new DirectoryInfo(tmp_ProjectDetailCacheData.GetProjectPath()).Name}.Runtime.dll");

            InjectCodeIntoMethods(tmp_DllPath, tmp_OutDllPath);
            return await Task.FromResult<bool>(true);
        }

        static void InjectCodeIntoMethods(string _dllPath, string _outDllPath)
        {
            var tmp_Resolver = new DefaultAssemblyResolver();
            tmp_Resolver.AddSearchDirectory(Path.GetDirectoryName(_dllPath));

            var tmp_ReaderParams = new ReaderParameters
            {
                ReadSymbols = true,
                SymbolReaderProvider = new PortablePdbReaderProvider(),
                AssemblyResolver = tmp_Resolver,
            };
            bool tmp_HasInjected = false;
            var tmp_Assembly = AssemblyDefinition.ReadAssembly(_dllPath, tmp_ReaderParams);
            var tmp_Module = tmp_Assembly.MainModule;
            foreach (var tmp_Type in tmp_Module.Types)
            {
                foreach (var tmp_Field in tmp_Type.Fields)
                {
                    if (tmp_Field.CustomAttributes.All(_attr => _attr.AttributeType.Name != "DataPropertyAttribute"))
                        continue;
                    tmp_HasInjected = true;
                    // 注意：字段类型可能是引用，需要 Resolve() 得到真正定义
                    TypeDefinition tmp_TargetType = null;
                    var tmp_FieldType = tmp_Field.FieldType;
                    if (tmp_FieldType is GenericInstanceType tmp_GenericInstanceType &&
                        tmp_FieldType.FullName.StartsWith("System.Collections.Generic.List"))
                    {
                        tmp_TargetType = tmp_GenericInstanceType.GenericArguments[0].Resolve();
                    }
                    else if (tmp_FieldType is ArrayType tmp_ArrayType)
                    {
                        tmp_TargetType = tmp_ArrayType.ElementType.Resolve();
                    }
                    else
                    {
                        tmp_TargetType = tmp_Field.FieldType.Resolve();
                    }

                    if (tmp_TargetType == null) continue;
                    InjectDeserializationMethod(tmp_Type, tmp_Field.FieldType, tmp_Module, tmp_Field.Name);
                }
            }

            if (tmp_HasInjected)
            {
                if (File.Exists(_outDllPath))
                {
                    File.Delete(_outDllPath);
                    File.Delete(Path.ChangeExtension(_outDllPath, "pdb"));
                }

                var tmp_SymbolStream = File.Create(Path.ChangeExtension(_outDllPath, ".pdb"));
                var tmp_WriterParams = new WriterParameters
                {
                    WriteSymbols = true,
                    SymbolStream = tmp_SymbolStream,
                    SymbolWriterProvider = new PortablePdbWriterProvider(),
                };

                tmp_Assembly.Write(_outDllPath, tmp_WriterParams);
                tmp_SymbolStream.Dispose();
            }
        }

        static void InjectDeserializationMethod(TypeDefinition _type, TypeReference _fieldType,
            ModuleDefinition _module, string _fieldName)
        {
            var tmp_InjectMethodName = $"DeserializedDataProperty_{_fieldName}";
            // 删除已有方法，确保不重复注入
            var tmp_Existing =
                _type.Methods.FirstOrDefault(_m => _m.Name == tmp_InjectMethodName);
            if (tmp_Existing != null)
                _type.Methods.Remove(tmp_Existing);

            // 定义方法：internal ThisType DeserializedDataProperty(string _data)
            var tmp_Method = new MethodDefinition(tmp_InjectMethodName,
                MethodAttributes.HideBySig | MethodAttributes.Assembly,
                _module.ImportReference(_fieldType)); // 👈 设置返回类型为 ThisType

            var tmp_StringType = _module.TypeSystem.String;
            tmp_Method.Parameters.Add(new ParameterDefinition("_data", ParameterAttributes.None, tmp_StringType));
            tmp_Method.Body.InitLocals = true;

            var tmp_IL = tmp_Method.Body.GetILProcessor();

            // 添加局部变量: var tmp = default(type);
            var tmp_TMPVar = new VariableDefinition(_type);
            tmp_Method.Body.Variables.Add(tmp_TMPVar);

            // 找到 JsonConvert.DeserializeObject<T>(string)
            var tmp_JsonConvertType = typeof(LitJson.JsonMapper);
            var tmp_DeserializeMethod = tmp_JsonConvertType
                .GetMethods(BindingFlags.Public | BindingFlags.Static)
                .First(_m =>
                    _m.Name == "ToObject" &&
                    _m.IsGenericMethod &&
                    _m.GetParameters().Length == 1 &&
                    _m.GetParameters()[0].ParameterType == typeof(string));


            var tmp_DeserializeRef = _module.ImportReference(tmp_DeserializeMethod);
            var tmp_GenericDeserialize = new GenericInstanceMethod(tmp_DeserializeRef);
            tmp_GenericDeserialize.GenericArguments.Add(_module.ImportReference(_fieldType)); // ✅ 用字段类型


            // IL 构造
            tmp_IL.Append(tmp_IL.Create(OpCodes.Ldarg_1)); // _data
            tmp_IL.Append(tmp_IL.Create(OpCodes.Call, tmp_GenericDeserialize)); // DeserializeObject<type>(_data)
            tmp_IL.Append(tmp_IL.Create(OpCodes.Ret)); // 返回结果

            // 添加调试信息（SequencePoint）
            var tmp_Doc = new Document($"{tmp_InjectMethodName}.cs");
            tmp_Method.DebugInformation.SequencePoints.Add(new SequencePoint(tmp_Method.Body.Instructions[0], tmp_Doc)
            {
                StartLine = 1,
                StartColumn = 1,
                EndLine = 1,
                EndColumn = 40
            });
            tmp_Method.DebugInformation.Scope = new ScopeDebugInformation(
                tmp_Method.Body.Instructions.First(),
                tmp_Method.Body.Instructions.Last()
            );

            _type.Methods.Add(tmp_Method);
        }
    }
}
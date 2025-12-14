using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using UnityFusion.CLR.TypeSystem;
using UnityFusion.CLR.Method;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using UnityFusion.Runtime.Stack;
using UnityFusion.Reflection;
using UnityFusion.CLR.Utils;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;
#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif

namespace UnityFusion.Runtime.Generated
{
    unsafe class UnityEngine_Shader_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Shader);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("Find", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Find_0);
            args = new Type[]{};
            method = type.GetMethod("get_maximumChunksOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maximumChunksOverride_1);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_maximumChunksOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maximumChunksOverride_2);
            args = new Type[]{};
            method = type.GetMethod("get_maximumLOD", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maximumLOD_3);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_maximumLOD", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maximumLOD_4);
            args = new Type[]{};
            method = type.GetMethod("get_globalMaximumLOD", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_globalMaximumLOD_5);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_globalMaximumLOD", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_globalMaximumLOD_6);
            args = new Type[]{};
            method = type.GetMethod("get_isSupported", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isSupported_7);
            args = new Type[]{};
            method = type.GetMethod("get_globalRenderPipeline", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_globalRenderPipeline_8);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("set_globalRenderPipeline", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_globalRenderPipeline_9);
            args = new Type[]{};
            method = type.GetMethod("get_enabledGlobalKeywords", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_enabledGlobalKeywords_10);
            args = new Type[]{};
            method = type.GetMethod("get_globalKeywords", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_globalKeywords_11);
            args = new Type[]{};
            method = type.GetMethod("get_keywordSpace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_keywordSpace_12);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("EnableKeyword", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EnableKeyword_13);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("DisableKeyword", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DisableKeyword_14);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("IsKeywordEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsKeywordEnabled_15);
            args = new Type[]{typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType()};
            method = type.GetMethod("EnableKeyword", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EnableKeyword_16);
            args = new Type[]{typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType()};
            method = type.GetMethod("DisableKeyword", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DisableKeyword_17);
            args = new Type[]{typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType(), typeof(System.Boolean)};
            method = type.GetMethod("SetKeyword", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetKeyword_18);
            args = new Type[]{typeof(UnityEngine.Rendering.GlobalKeyword).MakeByRefType()};
            method = type.GetMethod("IsKeywordEnabled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsKeywordEnabled_19);
            args = new Type[]{};
            method = type.GetMethod("get_renderQueue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_renderQueue_20);
            args = new Type[]{};
            method = type.GetMethod("WarmupAllShaders", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WarmupAllShaders_21);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("PropertyToID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PropertyToID_22);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetDependency", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetDependency_23);
            args = new Type[]{};
            method = type.GetMethod("get_passCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_passCount_24);
            args = new Type[]{};
            method = type.GetMethod("get_subshaderCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_subshaderCount_25);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetPassCountInSubshader", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPassCountInSubshader_26);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Rendering.ShaderTagId)};
            method = type.GetMethod("FindPassTagValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindPassTagValue_27);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(UnityEngine.Rendering.ShaderTagId)};
            method = type.GetMethod("FindPassTagValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindPassTagValue_28);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Rendering.ShaderTagId)};
            method = type.GetMethod("FindSubshaderTagValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindSubshaderTagValue_29);
            args = new Type[]{typeof(System.String), typeof(System.Int32)};
            method = type.GetMethod("SetGlobalInt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalInt_30);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SetGlobalInt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalInt_31);
            args = new Type[]{typeof(System.String), typeof(System.Single)};
            method = type.GetMethod("SetGlobalFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalFloat_32);
            args = new Type[]{typeof(System.Int32), typeof(System.Single)};
            method = type.GetMethod("SetGlobalFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalFloat_33);
            args = new Type[]{typeof(System.String), typeof(System.Int32)};
            method = type.GetMethod("SetGlobalInteger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalInteger_34);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SetGlobalInteger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalInteger_35);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Vector4)};
            method = type.GetMethod("SetGlobalVector", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalVector_36);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Vector4)};
            method = type.GetMethod("SetGlobalVector", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalVector_37);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Color)};
            method = type.GetMethod("SetGlobalColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalColor_38);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Color)};
            method = type.GetMethod("SetGlobalColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalColor_39);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("SetGlobalMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalMatrix_40);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("SetGlobalMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalMatrix_41);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Texture)};
            method = type.GetMethod("SetGlobalTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalTexture_42);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Texture)};
            method = type.GetMethod("SetGlobalTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalTexture_43);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rendering.RenderTextureSubElement)};
            method = type.GetMethod("SetGlobalTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalTexture_44);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.RenderTexture), typeof(UnityEngine.Rendering.RenderTextureSubElement)};
            method = type.GetMethod("SetGlobalTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalTexture_45);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.ComputeBuffer)};
            method = type.GetMethod("SetGlobalBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalBuffer_46);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.ComputeBuffer)};
            method = type.GetMethod("SetGlobalBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalBuffer_47);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GraphicsBuffer)};
            method = type.GetMethod("SetGlobalBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalBuffer_48);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer)};
            method = type.GetMethod("SetGlobalBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalBuffer_49);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SetGlobalConstantBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalConstantBuffer_50);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.ComputeBuffer), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SetGlobalConstantBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalConstantBuffer_51);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SetGlobalConstantBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalConstantBuffer_52);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.GraphicsBuffer), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SetGlobalConstantBuffer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalConstantBuffer_53);
            args = new Type[]{typeof(System.String), typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("SetGlobalFloatArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalFloatArray_54);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("SetGlobalFloatArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalFloatArray_55);
            args = new Type[]{typeof(System.String), typeof(System.Single[])};
            method = type.GetMethod("SetGlobalFloatArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalFloatArray_56);
            args = new Type[]{typeof(System.Int32), typeof(System.Single[])};
            method = type.GetMethod("SetGlobalFloatArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalFloatArray_57);
            args = new Type[]{typeof(System.String), typeof(System.Collections.Generic.List<UnityEngine.Vector4>)};
            method = type.GetMethod("SetGlobalVectorArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalVectorArray_58);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.Vector4>)};
            method = type.GetMethod("SetGlobalVectorArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalVectorArray_59);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Vector4[])};
            method = type.GetMethod("SetGlobalVectorArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalVectorArray_60);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Vector4[])};
            method = type.GetMethod("SetGlobalVectorArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalVectorArray_61);
            args = new Type[]{typeof(System.String), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>)};
            method = type.GetMethod("SetGlobalMatrixArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalMatrixArray_62);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>)};
            method = type.GetMethod("SetGlobalMatrixArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalMatrixArray_63);
            args = new Type[]{typeof(System.String), typeof(UnityEngine.Matrix4x4[])};
            method = type.GetMethod("SetGlobalMatrixArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalMatrixArray_64);
            args = new Type[]{typeof(System.Int32), typeof(UnityEngine.Matrix4x4[])};
            method = type.GetMethod("SetGlobalMatrixArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetGlobalMatrixArray_65);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetGlobalInt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalInt_66);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetGlobalInt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalInt_67);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetGlobalFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalFloat_68);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetGlobalFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalFloat_69);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetGlobalInteger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalInteger_70);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetGlobalInteger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalInteger_71);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetGlobalVector", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalVector_72);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetGlobalVector", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalVector_73);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetGlobalColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalColor_74);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetGlobalColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalColor_75);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetGlobalMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalMatrix_76);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetGlobalMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalMatrix_77);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetGlobalTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalTexture_78);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetGlobalTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalTexture_79);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetGlobalFloatArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalFloatArray_80);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetGlobalFloatArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalFloatArray_81);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetGlobalVectorArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalVectorArray_82);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetGlobalVectorArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalVectorArray_83);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetGlobalMatrixArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalMatrixArray_84);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetGlobalMatrixArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalMatrixArray_85);
            args = new Type[]{typeof(System.String), typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("GetGlobalFloatArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalFloatArray_86);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<System.Single>)};
            method = type.GetMethod("GetGlobalFloatArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalFloatArray_87);
            args = new Type[]{typeof(System.String), typeof(System.Collections.Generic.List<UnityEngine.Vector4>)};
            method = type.GetMethod("GetGlobalVectorArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalVectorArray_88);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.Vector4>)};
            method = type.GetMethod("GetGlobalVectorArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalVectorArray_89);
            args = new Type[]{typeof(System.String), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>)};
            method = type.GetMethod("GetGlobalMatrixArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalMatrixArray_90);
            args = new Type[]{typeof(System.Int32), typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>)};
            method = type.GetMethod("GetGlobalMatrixArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetGlobalMatrixArray_91);
            args = new Type[]{};
            method = type.GetMethod("GetPropertyCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPropertyCount_92);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("FindPropertyIndex", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindPropertyIndex_93);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetPropertyName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPropertyName_94);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetPropertyNameId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPropertyNameId_95);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetPropertyType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPropertyType_96);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetPropertyDescription", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPropertyDescription_97);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetPropertyFlags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPropertyFlags_98);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetPropertyAttributes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPropertyAttributes_99);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetPropertyDefaultFloatValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPropertyDefaultFloatValue_100);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetPropertyDefaultVectorValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPropertyDefaultVectorValue_101);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetPropertyRangeLimits", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPropertyRangeLimits_102);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetPropertyDefaultIntValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPropertyDefaultIntValue_103);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetPropertyTextureDimension", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPropertyTextureDimension_104);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("GetPropertyTextureDefaultName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPropertyTextureDefaultName_105);
            args = new Type[]{typeof(System.Int32), typeof(System.String).MakeByRefType(), typeof(System.Int32).MakeByRefType()};
            method = type.GetMethod("FindTextureStack", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindTextureStack_106);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Shader[s]);


        }


        static StackObject* Find_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.Find(@name);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_maximumChunksOverride_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Shader.maximumChunksOverride;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maximumChunksOverride_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.Shader.maximumChunksOverride = value;

            return __ret;
        }

        static StackObject* get_maximumLOD_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maximumLOD;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maximumLOD_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maximumLOD = value;

            return __ret;
        }

        static StackObject* get_globalMaximumLOD_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Shader.globalMaximumLOD;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_globalMaximumLOD_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.Shader.globalMaximumLOD = value;

            return __ret;
        }

        static StackObject* get_isSupported_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isSupported;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_globalRenderPipeline_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Shader.globalRenderPipeline;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_globalRenderPipeline_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @value = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.globalRenderPipeline = value;

            return __ret;
        }

        static StackObject* get_enabledGlobalKeywords_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Shader.enabledGlobalKeywords;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_globalKeywords_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.Shader.globalKeywords;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_keywordSpace_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.keywordSpace;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* EnableKeyword_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @keyword = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.EnableKeyword(@keyword);

            return __ret;
        }

        static StackObject* DisableKeyword_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @keyword = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.DisableKeyword(@keyword);

            return __ret;
        }

        static StackObject* IsKeywordEnabled_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @keyword = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.IsKeywordEnabled(@keyword);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* EnableKeyword_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.GlobalKeyword @keyword = (UnityEngine.Rendering.GlobalKeyword)typeof(UnityEngine.Rendering.GlobalKeyword).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);


            UnityEngine.Shader.EnableKeyword(in @keyword);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @keyword;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @keyword;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @keyword);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @keyword;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @keyword);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Rendering.GlobalKeyword[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @keyword;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* DisableKeyword_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.GlobalKeyword @keyword = (UnityEngine.Rendering.GlobalKeyword)typeof(UnityEngine.Rendering.GlobalKeyword).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);


            UnityEngine.Shader.DisableKeyword(in @keyword);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @keyword;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @keyword;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @keyword);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @keyword;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @keyword);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Rendering.GlobalKeyword[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @keyword;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* SetKeyword_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.GlobalKeyword @keyword = (UnityEngine.Rendering.GlobalKeyword)typeof(UnityEngine.Rendering.GlobalKeyword).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);


            UnityEngine.Shader.SetKeyword(in @keyword, @value);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @keyword;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @keyword;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @keyword);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @keyword;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @keyword);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Rendering.GlobalKeyword[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @keyword;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* IsKeywordEnabled_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.GlobalKeyword @keyword = (UnityEngine.Rendering.GlobalKeyword)typeof(UnityEngine.Rendering.GlobalKeyword).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);


            var result_of_this_method = UnityEngine.Shader.IsKeywordEnabled(in @keyword);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @keyword;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @keyword;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @keyword);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @keyword;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @keyword);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Rendering.GlobalKeyword[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @keyword;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_renderQueue_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.renderQueue;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* WarmupAllShaders_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.Shader.WarmupAllShaders();

            return __ret;
        }

        static StackObject* PropertyToID_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.PropertyToID(@name);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetDependency_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetDependency(@name);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_passCount_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.passCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_subshaderCount_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.subshaderCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetPassCountInSubshader_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @subshaderIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPassCountInSubshader(@subshaderIndex);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* FindPassTagValue_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ShaderTagId @tagName = (UnityEngine.Rendering.ShaderTagId)typeof(UnityEngine.Rendering.ShaderTagId).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @passIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindPassTagValue(@passIndex, @tagName);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* FindPassTagValue_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ShaderTagId @tagName = (UnityEngine.Rendering.ShaderTagId)typeof(UnityEngine.Rendering.ShaderTagId).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @passIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @subshaderIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindPassTagValue(@subshaderIndex, @passIndex, @tagName);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* FindSubshaderTagValue_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.ShaderTagId @tagName = (UnityEngine.Rendering.ShaderTagId)typeof(UnityEngine.Rendering.ShaderTagId).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @subshaderIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindSubshaderTagValue(@subshaderIndex, @tagName);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetGlobalInt_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalInt(@name, @value);

            return __ret;
        }

        static StackObject* SetGlobalInt_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalInt(@nameID, @value);

            return __ret;
        }

        static StackObject* SetGlobalFloat_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalFloat(@name, @value);

            return __ret;
        }

        static StackObject* SetGlobalFloat_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalFloat(@nameID, @value);

            return __ret;
        }

        static StackObject* SetGlobalInteger_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalInteger(@name, @value);

            return __ret;
        }

        static StackObject* SetGlobalInteger_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalInteger(@nameID, @value);

            return __ret;
        }

        static StackObject* SetGlobalVector_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4 @value = (UnityEngine.Vector4)typeof(UnityEngine.Vector4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalVector(@name, @value);

            return __ret;
        }

        static StackObject* SetGlobalVector_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4 @value = (UnityEngine.Vector4)typeof(UnityEngine.Vector4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalVector(@nameID, @value);

            return __ret;
        }

        static StackObject* SetGlobalColor_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalColor(@name, @value);

            return __ret;
        }

        static StackObject* SetGlobalColor_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalColor(@nameID, @value);

            return __ret;
        }

        static StackObject* SetGlobalMatrix_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 @value = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalMatrix(@name, @value);

            return __ret;
        }

        static StackObject* SetGlobalMatrix_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 @value = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalMatrix(@nameID, @value);

            return __ret;
        }

        static StackObject* SetGlobalTexture_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture @value = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalTexture(@name, @value);

            return __ret;
        }

        static StackObject* SetGlobalTexture_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Texture @value = (UnityEngine.Texture)typeof(UnityEngine.Texture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalTexture(@nameID, @value);

            return __ret;
        }

        static StackObject* SetGlobalTexture_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.RenderTextureSubElement @element = (UnityEngine.Rendering.RenderTextureSubElement)typeof(UnityEngine.Rendering.RenderTextureSubElement).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RenderTexture @value = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalTexture(@name, @value, @element);

            return __ret;
        }

        static StackObject* SetGlobalTexture_45(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.RenderTextureSubElement @element = (UnityEngine.Rendering.RenderTextureSubElement)typeof(UnityEngine.Rendering.RenderTextureSubElement).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.RenderTexture @value = (UnityEngine.RenderTexture)typeof(UnityEngine.RenderTexture).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalTexture(@nameID, @value, @element);

            return __ret;
        }

        static StackObject* SetGlobalBuffer_46(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ComputeBuffer @value = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalBuffer(@name, @value);

            return __ret;
        }

        static StackObject* SetGlobalBuffer_47(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.ComputeBuffer @value = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalBuffer(@nameID, @value);

            return __ret;
        }

        static StackObject* SetGlobalBuffer_48(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GraphicsBuffer @value = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalBuffer(@name, @value);

            return __ret;
        }

        static StackObject* SetGlobalBuffer_49(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GraphicsBuffer @value = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalBuffer(@nameID, @value);

            return __ret;
        }

        static StackObject* SetGlobalConstantBuffer_50(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @size = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @offset = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ComputeBuffer @value = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalConstantBuffer(@name, @value, @offset, @size);

            return __ret;
        }

        static StackObject* SetGlobalConstantBuffer_51(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @size = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @offset = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.ComputeBuffer @value = (UnityEngine.ComputeBuffer)typeof(UnityEngine.ComputeBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalConstantBuffer(@nameID, @value, @offset, @size);

            return __ret;
        }

        static StackObject* SetGlobalConstantBuffer_52(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @size = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @offset = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GraphicsBuffer @value = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalConstantBuffer(@name, @value, @offset, @size);

            return __ret;
        }

        static StackObject* SetGlobalConstantBuffer_53(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @size = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @offset = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GraphicsBuffer @value = (UnityEngine.GraphicsBuffer)typeof(UnityEngine.GraphicsBuffer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalConstantBuffer(@nameID, @value, @offset, @size);

            return __ret;
        }

        static StackObject* SetGlobalFloatArray_54(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @values = (System.Collections.Generic.List<System.Single>)typeof(System.Collections.Generic.List<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalFloatArray(@name, @values);

            return __ret;
        }

        static StackObject* SetGlobalFloatArray_55(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @values = (System.Collections.Generic.List<System.Single>)typeof(System.Collections.Generic.List<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalFloatArray(@nameID, @values);

            return __ret;
        }

        static StackObject* SetGlobalFloatArray_56(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single[] @values = (System.Single[])typeof(System.Single[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalFloatArray(@name, @values);

            return __ret;
        }

        static StackObject* SetGlobalFloatArray_57(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single[] @values = (System.Single[])typeof(System.Single[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalFloatArray(@nameID, @values);

            return __ret;
        }

        static StackObject* SetGlobalVectorArray_58(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector4> @values = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalVectorArray(@name, @values);

            return __ret;
        }

        static StackObject* SetGlobalVectorArray_59(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector4> @values = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalVectorArray(@nameID, @values);

            return __ret;
        }

        static StackObject* SetGlobalVectorArray_60(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4[] @values = (UnityEngine.Vector4[])typeof(UnityEngine.Vector4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalVectorArray(@name, @values);

            return __ret;
        }

        static StackObject* SetGlobalVectorArray_61(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4[] @values = (UnityEngine.Vector4[])typeof(UnityEngine.Vector4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalVectorArray(@nameID, @values);

            return __ret;
        }

        static StackObject* SetGlobalMatrixArray_62(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> @values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalMatrixArray(@name, @values);

            return __ret;
        }

        static StackObject* SetGlobalMatrixArray_63(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> @values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalMatrixArray(@nameID, @values);

            return __ret;
        }

        static StackObject* SetGlobalMatrixArray_64(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4[] @values = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.SetGlobalMatrixArray(@name, @values);

            return __ret;
        }

        static StackObject* SetGlobalMatrixArray_65(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4[] @values = (UnityEngine.Matrix4x4[])typeof(UnityEngine.Matrix4x4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.SetGlobalMatrixArray(@nameID, @values);

            return __ret;
        }

        static StackObject* GetGlobalInt_66(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.GetGlobalInt(@name);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetGlobalInt_67(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @nameID = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Shader.GetGlobalInt(@nameID);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetGlobalFloat_68(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.GetGlobalFloat(@name);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetGlobalFloat_69(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @nameID = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Shader.GetGlobalFloat(@nameID);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetGlobalInteger_70(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.GetGlobalInteger(@name);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetGlobalInteger_71(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @nameID = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Shader.GetGlobalInteger(@nameID);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetGlobalVector_72(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.GetGlobalVector(@name);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalVector_73(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @nameID = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Shader.GetGlobalVector(@nameID);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalColor_74(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.GetGlobalColor(@name);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalColor_75(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @nameID = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Shader.GetGlobalColor(@nameID);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalMatrix_76(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.GetGlobalMatrix(@name);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalMatrix_77(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @nameID = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Shader.GetGlobalMatrix(@nameID);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalTexture_78(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.GetGlobalTexture(@name);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalTexture_79(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @nameID = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Shader.GetGlobalTexture(@nameID);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalFloatArray_80(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.GetGlobalFloatArray(@name);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalFloatArray_81(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @nameID = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Shader.GetGlobalFloatArray(@nameID);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalVectorArray_82(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.GetGlobalVectorArray(@name);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalVectorArray_83(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @nameID = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Shader.GetGlobalVectorArray(@nameID);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalMatrixArray_84(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Shader.GetGlobalMatrixArray(@name);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalMatrixArray_85(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @nameID = ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Shader.GetGlobalMatrixArray(@nameID);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetGlobalFloatArray_86(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @values = (System.Collections.Generic.List<System.Single>)typeof(System.Collections.Generic.List<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.GetGlobalFloatArray(@name, @values);

            return __ret;
        }

        static StackObject* GetGlobalFloatArray_87(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Single> @values = (System.Collections.Generic.List<System.Single>)typeof(System.Collections.Generic.List<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.GetGlobalFloatArray(@nameID, @values);

            return __ret;
        }

        static StackObject* GetGlobalVectorArray_88(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector4> @values = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.GetGlobalVectorArray(@name, @values);

            return __ret;
        }

        static StackObject* GetGlobalVectorArray_89(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector4> @values = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.GetGlobalVectorArray(@nameID, @values);

            return __ret;
        }

        static StackObject* GetGlobalMatrixArray_90(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> @values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Shader.GetGlobalMatrixArray(@name, @values);

            return __ret;
        }

        static StackObject* GetGlobalMatrixArray_91(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Matrix4x4> @values = (System.Collections.Generic.List<UnityEngine.Matrix4x4>)typeof(System.Collections.Generic.List<UnityEngine.Matrix4x4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @nameID = ptr_of_this_method->Value;


            UnityEngine.Shader.GetGlobalMatrixArray(@nameID, @values);

            return __ret;
        }

        static StackObject* GetPropertyCount_92(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPropertyCount();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* FindPropertyIndex_93(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @propertyName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FindPropertyIndex(@propertyName);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetPropertyName_94(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @propertyIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPropertyName(@propertyIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPropertyNameId_95(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @propertyIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPropertyNameId(@propertyIndex);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetPropertyType_96(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @propertyIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPropertyType(@propertyIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPropertyDescription_97(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @propertyIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPropertyDescription(@propertyIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPropertyFlags_98(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @propertyIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPropertyFlags(@propertyIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPropertyAttributes_99(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @propertyIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPropertyAttributes(@propertyIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPropertyDefaultFloatValue_100(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @propertyIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPropertyDefaultFloatValue(@propertyIndex);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetPropertyDefaultVectorValue_101(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @propertyIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPropertyDefaultVectorValue(@propertyIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPropertyRangeLimits_102(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @propertyIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPropertyRangeLimits(@propertyIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPropertyDefaultIntValue_103(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @propertyIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPropertyDefaultIntValue(@propertyIndex);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetPropertyTextureDimension_104(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @propertyIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPropertyTextureDimension(@propertyIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPropertyTextureDefaultName_105(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @propertyIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPropertyTextureDefaultName(@propertyIndex);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* FindTextureStack_106(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @layerIndex = __intp.RetriveInt32(ptr_of_this_method, __mStack);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @stackName = (System.String)typeof(System.String).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @propertyIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Shader instance_of_this_method = (UnityEngine.Shader)typeof(UnityEngine.Shader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.FindTextureStack(@propertyIndex, out @stackName, out @layerIndex);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        ___dst->ObjectType = ObjectTypes.Integer;
                        ___dst->Value = @layerIndex;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @layerIndex;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @layerIndex);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @layerIndex;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @layerIndex);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Int32[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @layerIndex;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @stackName;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @stackName;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @stackName);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @stackName;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @stackName);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.String[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @stackName;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }





    }
}

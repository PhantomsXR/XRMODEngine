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
    unsafe class UnityEngine_LightProbes_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.LightProbes);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_lightProbesUpdated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_lightProbesUpdated_0);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_lightProbesUpdated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_lightProbesUpdated_1);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_tetrahedralizationCompleted", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_tetrahedralizationCompleted_2);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_tetrahedralizationCompleted", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_tetrahedralizationCompleted_3);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_needsRetetrahedralization", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_needsRetetrahedralization_4);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_needsRetetrahedralization", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_needsRetetrahedralization_5);
            args = new Type[]{};
            method = type.GetMethod("Tetrahedralize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Tetrahedralize_6);
            args = new Type[]{};
            method = type.GetMethod("TetrahedralizeAsync", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TetrahedralizeAsync_7);
            args = new Type[]{typeof(UnityEngine.Vector3), typeof(UnityEngine.Renderer), typeof(UnityEngine.Rendering.SphericalHarmonicsL2).MakeByRefType()};
            method = type.GetMethod("GetInterpolatedProbe", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetInterpolatedProbe_8);
            args = new Type[]{typeof(UnityEngine.Vector3[]), typeof(UnityEngine.Rendering.SphericalHarmonicsL2[]), typeof(UnityEngine.Vector4[])};
            method = type.GetMethod("CalculateInterpolatedLightAndOcclusionProbes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CalculateInterpolatedLightAndOcclusionProbes_9);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Vector3>), typeof(System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2>), typeof(System.Collections.Generic.List<UnityEngine.Vector4>)};
            method = type.GetMethod("CalculateInterpolatedLightAndOcclusionProbes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CalculateInterpolatedLightAndOcclusionProbes_10);
            args = new Type[]{};
            method = type.GetMethod("get_positions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_positions_11);
            args = new Type[]{};
            method = type.GetMethod("get_bakedProbes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_bakedProbes_12);
            args = new Type[]{typeof(UnityEngine.Rendering.SphericalHarmonicsL2[])};
            method = type.GetMethod("set_bakedProbes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_bakedProbes_13);
            args = new Type[]{};
            method = type.GetMethod("get_count", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_count_14);
            args = new Type[]{};
            method = type.GetMethod("get_cellCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cellCount_15);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.LightProbes[s]);


        }


        static StackObject* add_lightProbesUpdated_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.LightProbes.lightProbesUpdated += value;

            return __ret;
        }

        static StackObject* remove_lightProbesUpdated_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.LightProbes.lightProbesUpdated -= value;

            return __ret;
        }

        static StackObject* add_tetrahedralizationCompleted_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.LightProbes.tetrahedralizationCompleted += value;

            return __ret;
        }

        static StackObject* remove_tetrahedralizationCompleted_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.LightProbes.tetrahedralizationCompleted -= value;

            return __ret;
        }

        static StackObject* add_needsRetetrahedralization_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.LightProbes.needsRetetrahedralization += value;

            return __ret;
        }

        static StackObject* remove_needsRetetrahedralization_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.LightProbes.needsRetetrahedralization -= value;

            return __ret;
        }

        static StackObject* Tetrahedralize_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.LightProbes.Tetrahedralize();

            return __ret;
        }

        static StackObject* TetrahedralizeAsync_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            UnityEngine.LightProbes.TetrahedralizeAsync();

            return __ret;
        }

        static StackObject* GetInterpolatedProbe_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.SphericalHarmonicsL2 @probe = (UnityEngine.Rendering.SphericalHarmonicsL2)typeof(UnityEngine.Rendering.SphericalHarmonicsL2).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Renderer @renderer = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);


            UnityEngine.LightProbes.GetInterpolatedProbe(@position, @renderer, out @probe);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @probe;
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
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @probe;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @probe);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @probe;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @probe);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Rendering.SphericalHarmonicsL2[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @probe;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* CalculateInterpolatedLightAndOcclusionProbes_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4[] @occlusionProbes = (UnityEngine.Vector4[])typeof(UnityEngine.Vector4[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Rendering.SphericalHarmonicsL2[] @lightProbes = (UnityEngine.Rendering.SphericalHarmonicsL2[])typeof(UnityEngine.Rendering.SphericalHarmonicsL2[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3[] @positions = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.LightProbes.CalculateInterpolatedLightAndOcclusionProbes(@positions, @lightProbes, @occlusionProbes);

            return __ret;
        }

        static StackObject* CalculateInterpolatedLightAndOcclusionProbes_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Vector4> @occlusionProbes = (System.Collections.Generic.List<UnityEngine.Vector4>)typeof(System.Collections.Generic.List<UnityEngine.Vector4>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2> @lightProbes = (System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2>)typeof(System.Collections.Generic.List<UnityEngine.Rendering.SphericalHarmonicsL2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<UnityEngine.Vector3> @positions = (System.Collections.Generic.List<UnityEngine.Vector3>)typeof(System.Collections.Generic.List<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.LightProbes.CalculateInterpolatedLightAndOcclusionProbes(@positions, @lightProbes, @occlusionProbes);

            return __ret;
        }

        static StackObject* get_positions_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbes instance_of_this_method = (UnityEngine.LightProbes)typeof(UnityEngine.LightProbes).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.positions;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_bakedProbes_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbes instance_of_this_method = (UnityEngine.LightProbes)typeof(UnityEngine.LightProbes).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.bakedProbes;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_bakedProbes_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rendering.SphericalHarmonicsL2[] @value = (UnityEngine.Rendering.SphericalHarmonicsL2[])typeof(UnityEngine.Rendering.SphericalHarmonicsL2[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.LightProbes instance_of_this_method = (UnityEngine.LightProbes)typeof(UnityEngine.LightProbes).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.bakedProbes = value;

            return __ret;
        }

        static StackObject* get_count_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbes instance_of_this_method = (UnityEngine.LightProbes)typeof(UnityEngine.LightProbes).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.count;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_cellCount_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LightProbes instance_of_this_method = (UnityEngine.LightProbes)typeof(UnityEngine.LightProbes).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.cellCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }





    }
}

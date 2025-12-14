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
    unsafe class UnityEngine_Splines_SplineInstantiate_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Splines.SplineInstantiate);
            args = new Type[]{};
            method = type.GetMethod("get_Container", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Container_0);
            args = new Type[]{typeof(UnityEngine.Splines.SplineContainer)};
            method = type.GetMethod("set_Container", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Container_1);
            args = new Type[]{};
            method = type.GetMethod("get_itemsToInstantiate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_itemsToInstantiate_2);
            args = new Type[]{typeof(UnityEngine.Splines.SplineInstantiate.InstantiableItem[])};
            method = type.GetMethod("set_itemsToInstantiate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_itemsToInstantiate_3);
            args = new Type[]{};
            method = type.GetMethod("get_InstantiateMethod", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_InstantiateMethod_4);
            args = new Type[]{typeof(UnityEngine.Splines.SplineInstantiate.Method)};
            method = type.GetMethod("set_InstantiateMethod", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_InstantiateMethod_5);
            args = new Type[]{};
            method = type.GetMethod("get_CoordinateSpace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_CoordinateSpace_6);
            args = new Type[]{typeof(UnityEngine.Splines.SplineInstantiate.Space)};
            method = type.GetMethod("set_CoordinateSpace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_CoordinateSpace_7);
            args = new Type[]{};
            method = type.GetMethod("get_MinSpacing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MinSpacing_8);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_MinSpacing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MinSpacing_9);
            args = new Type[]{};
            method = type.GetMethod("get_MaxSpacing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MaxSpacing_10);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_MaxSpacing", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MaxSpacing_11);
            args = new Type[]{};
            method = type.GetMethod("get_UpAxis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_UpAxis_12);
            args = new Type[]{typeof(UnityEngine.Splines.SplineComponent.AlignAxis)};
            method = type.GetMethod("set_UpAxis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_UpAxis_13);
            args = new Type[]{};
            method = type.GetMethod("get_ForwardAxis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ForwardAxis_14);
            args = new Type[]{typeof(UnityEngine.Splines.SplineComponent.AlignAxis)};
            method = type.GetMethod("set_ForwardAxis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ForwardAxis_15);
            args = new Type[]{};
            method = type.GetMethod("get_MinPositionOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MinPositionOffset_16);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_MinPositionOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MinPositionOffset_17);
            args = new Type[]{};
            method = type.GetMethod("get_MaxPositionOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MaxPositionOffset_18);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_MaxPositionOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MaxPositionOffset_19);
            args = new Type[]{};
            method = type.GetMethod("get_PositionSpace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_PositionSpace_20);
            args = new Type[]{typeof(UnityEngine.Splines.SplineInstantiate.OffsetSpace)};
            method = type.GetMethod("set_PositionSpace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_PositionSpace_21);
            args = new Type[]{};
            method = type.GetMethod("get_MinRotationOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MinRotationOffset_22);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_MinRotationOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MinRotationOffset_23);
            args = new Type[]{};
            method = type.GetMethod("get_MaxRotationOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MaxRotationOffset_24);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_MaxRotationOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MaxRotationOffset_25);
            args = new Type[]{};
            method = type.GetMethod("get_RotationSpace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_RotationSpace_26);
            args = new Type[]{typeof(UnityEngine.Splines.SplineInstantiate.OffsetSpace)};
            method = type.GetMethod("set_RotationSpace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_RotationSpace_27);
            args = new Type[]{};
            method = type.GetMethod("get_MinScaleOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MinScaleOffset_28);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_MinScaleOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MinScaleOffset_29);
            args = new Type[]{};
            method = type.GetMethod("get_MaxScaleOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MaxScaleOffset_30);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_MaxScaleOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MaxScaleOffset_31);
            args = new Type[]{};
            method = type.GetMethod("get_ScaleSpace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ScaleSpace_32);
            args = new Type[]{typeof(UnityEngine.Splines.SplineInstantiate.OffsetSpace)};
            method = type.GetMethod("set_ScaleSpace", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ScaleSpace_33);
            args = new Type[]{};
            method = type.GetMethod("get_Seed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Seed_34);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_Seed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Seed_35);
            args = new Type[]{};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_36);
            args = new Type[]{};
            method = type.GetMethod("SetDirty", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDirty_37);
            args = new Type[]{};
            method = type.GetMethod("Randomize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Randomize_38);
            args = new Type[]{};
            method = type.GetMethod("UpdateInstances", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UpdateInstances_39);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Splines.SplineInstantiate());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Splines.SplineInstantiate[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_Container_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Container;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_Container_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineContainer @value = (UnityEngine.Splines.SplineContainer)typeof(UnityEngine.Splines.SplineContainer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Container = value;

            return __ret;
        }

        static StackObject* get_itemsToInstantiate_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.itemsToInstantiate;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_itemsToInstantiate_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate.InstantiableItem[] @value = (UnityEngine.Splines.SplineInstantiate.InstantiableItem[])typeof(UnityEngine.Splines.SplineInstantiate.InstantiableItem[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.itemsToInstantiate = value;

            return __ret;
        }

        static StackObject* get_InstantiateMethod_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.InstantiateMethod;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_InstantiateMethod_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate.Method @value = (UnityEngine.Splines.SplineInstantiate.Method)typeof(UnityEngine.Splines.SplineInstantiate.Method).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.InstantiateMethod = value;

            return __ret;
        }

        static StackObject* get_CoordinateSpace_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CoordinateSpace;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_CoordinateSpace_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate.Space @value = (UnityEngine.Splines.SplineInstantiate.Space)typeof(UnityEngine.Splines.SplineInstantiate.Space).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CoordinateSpace = value;

            return __ret;
        }

        static StackObject* get_MinSpacing_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MinSpacing;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_MinSpacing_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MinSpacing = value;

            return __ret;
        }

        static StackObject* get_MaxSpacing_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MaxSpacing;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_MaxSpacing_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MaxSpacing = value;

            return __ret;
        }

        static StackObject* get_UpAxis_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.UpAxis;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_UpAxis_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineComponent.AlignAxis @value = (UnityEngine.Splines.SplineComponent.AlignAxis)typeof(UnityEngine.Splines.SplineComponent.AlignAxis).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UpAxis = value;

            return __ret;
        }

        static StackObject* get_ForwardAxis_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ForwardAxis;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_ForwardAxis_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineComponent.AlignAxis @value = (UnityEngine.Splines.SplineComponent.AlignAxis)typeof(UnityEngine.Splines.SplineComponent.AlignAxis).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ForwardAxis = value;

            return __ret;
        }

        static StackObject* get_MinPositionOffset_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MinPositionOffset;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_MinPositionOffset_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MinPositionOffset = value;

            return __ret;
        }

        static StackObject* get_MaxPositionOffset_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MaxPositionOffset;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_MaxPositionOffset_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MaxPositionOffset = value;

            return __ret;
        }

        static StackObject* get_PositionSpace_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.PositionSpace;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_PositionSpace_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate.OffsetSpace @value = (UnityEngine.Splines.SplineInstantiate.OffsetSpace)typeof(UnityEngine.Splines.SplineInstantiate.OffsetSpace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PositionSpace = value;

            return __ret;
        }

        static StackObject* get_MinRotationOffset_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MinRotationOffset;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_MinRotationOffset_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MinRotationOffset = value;

            return __ret;
        }

        static StackObject* get_MaxRotationOffset_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MaxRotationOffset;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_MaxRotationOffset_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MaxRotationOffset = value;

            return __ret;
        }

        static StackObject* get_RotationSpace_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.RotationSpace;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_RotationSpace_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate.OffsetSpace @value = (UnityEngine.Splines.SplineInstantiate.OffsetSpace)typeof(UnityEngine.Splines.SplineInstantiate.OffsetSpace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RotationSpace = value;

            return __ret;
        }

        static StackObject* get_MinScaleOffset_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MinScaleOffset;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_MinScaleOffset_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MinScaleOffset = value;

            return __ret;
        }

        static StackObject* get_MaxScaleOffset_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MaxScaleOffset;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_MaxScaleOffset_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MaxScaleOffset = value;

            return __ret;
        }

        static StackObject* get_ScaleSpace_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ScaleSpace;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_ScaleSpace_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate.OffsetSpace @value = (UnityEngine.Splines.SplineInstantiate.OffsetSpace)typeof(UnityEngine.Splines.SplineInstantiate.OffsetSpace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ScaleSpace = value;

            return __ret;
        }

        static StackObject* get_Seed_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Seed;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_Seed_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Seed = value;

            return __ret;
        }

        static StackObject* Clear_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Clear();

            return __ret;
        }

        static StackObject* SetDirty_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetDirty();

            return __ret;
        }

        static StackObject* Randomize_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Randomize();

            return __ret;
        }

        static StackObject* UpdateInstances_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInstantiate instance_of_this_method = (UnityEngine.Splines.SplineInstantiate)typeof(UnityEngine.Splines.SplineInstantiate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UpdateInstances();

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Splines.SplineInstantiate();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

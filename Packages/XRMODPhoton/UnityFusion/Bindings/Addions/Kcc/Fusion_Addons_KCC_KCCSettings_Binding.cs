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
    unsafe class Fusion_Addons_KCC_KCCSettings_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.KCC.KCCSettings);
            args = new Type[]{typeof(Fusion.Addons.KCC.KCCSettings)};
            method = type.GetMethod("CopyFromOther", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyFromOther_0);

            field = type.GetField("MaxNestedStages", flag);
            app.RegisterCLRFieldGetter(field, get_MaxNestedStages_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_MaxNestedStages_0, null);
            field = type.GetField("ExtrapolationDeltaTimeThreshold", flag);
            app.RegisterCLRFieldGetter(field, get_ExtrapolationDeltaTimeThreshold_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_ExtrapolationDeltaTimeThreshold_1, null);
            field = type.GetField("Shape", flag);
            app.RegisterCLRFieldGetter(field, get_Shape_2);
            app.RegisterCLRFieldSetter(field, set_Shape_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Shape_2, AssignFromStack_Shape_2);
            field = type.GetField("IsTrigger", flag);
            app.RegisterCLRFieldGetter(field, get_IsTrigger_3);
            app.RegisterCLRFieldSetter(field, set_IsTrigger_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsTrigger_3, AssignFromStack_IsTrigger_3);
            field = type.GetField("Radius", flag);
            app.RegisterCLRFieldGetter(field, get_Radius_4);
            app.RegisterCLRFieldSetter(field, set_Radius_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Radius_4, AssignFromStack_Radius_4);
            field = type.GetField("Height", flag);
            app.RegisterCLRFieldGetter(field, get_Height_5);
            app.RegisterCLRFieldSetter(field, set_Height_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_Height_5, AssignFromStack_Height_5);
            field = type.GetField("Extent", flag);
            app.RegisterCLRFieldGetter(field, get_Extent_6);
            app.RegisterCLRFieldSetter(field, set_Extent_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_Extent_6, AssignFromStack_Extent_6);
            field = type.GetField("ColliderLayer", flag);
            app.RegisterCLRFieldGetter(field, get_ColliderLayer_7);
            app.RegisterCLRFieldSetter(field, set_ColliderLayer_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_ColliderLayer_7, AssignFromStack_ColliderLayer_7);
            field = type.GetField("CollisionLayerMask", flag);
            app.RegisterCLRFieldGetter(field, get_CollisionLayerMask_8);
            app.RegisterCLRFieldSetter(field, set_CollisionLayerMask_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_CollisionLayerMask_8, AssignFromStack_CollisionLayerMask_8);
            field = type.GetField("Features", flag);
            app.RegisterCLRFieldGetter(field, get_Features_9);
            app.RegisterCLRFieldSetter(field, set_Features_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_Features_9, AssignFromStack_Features_9);
            field = type.GetField("InputAuthorityBehavior", flag);
            app.RegisterCLRFieldGetter(field, get_InputAuthorityBehavior_10);
            app.RegisterCLRFieldSetter(field, set_InputAuthorityBehavior_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_InputAuthorityBehavior_10, AssignFromStack_InputAuthorityBehavior_10);
            field = type.GetField("StateAuthorityBehavior", flag);
            app.RegisterCLRFieldGetter(field, get_StateAuthorityBehavior_11);
            app.RegisterCLRFieldSetter(field, set_StateAuthorityBehavior_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_StateAuthorityBehavior_11, AssignFromStack_StateAuthorityBehavior_11);
            field = type.GetField("ProxyInterpolationMode", flag);
            app.RegisterCLRFieldGetter(field, get_ProxyInterpolationMode_12);
            app.RegisterCLRFieldSetter(field, set_ProxyInterpolationMode_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_ProxyInterpolationMode_12, AssignFromStack_ProxyInterpolationMode_12);
            field = type.GetField("ForcePredictedLookRotation", flag);
            app.RegisterCLRFieldGetter(field, get_ForcePredictedLookRotation_13);
            app.RegisterCLRFieldSetter(field, set_ForcePredictedLookRotation_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_ForcePredictedLookRotation_13, AssignFromStack_ForcePredictedLookRotation_13);
            field = type.GetField("AllowClientTeleports", flag);
            app.RegisterCLRFieldGetter(field, get_AllowClientTeleports_14);
            app.RegisterCLRFieldSetter(field, set_AllowClientTeleports_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_AllowClientTeleports_14, AssignFromStack_AllowClientTeleports_14);
            field = type.GetField("Processors", flag);
            app.RegisterCLRFieldGetter(field, get_Processors_15);
            app.RegisterCLRFieldSetter(field, set_Processors_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_Processors_15, AssignFromStack_Processors_15);
            field = type.GetField("MaxPenetrationSteps", flag);
            app.RegisterCLRFieldGetter(field, get_MaxPenetrationSteps_16);
            app.RegisterCLRFieldSetter(field, set_MaxPenetrationSteps_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_MaxPenetrationSteps_16, AssignFromStack_MaxPenetrationSteps_16);
            field = type.GetField("CCDRadiusMultiplier", flag);
            app.RegisterCLRFieldGetter(field, get_CCDRadiusMultiplier_17);
            app.RegisterCLRFieldSetter(field, set_CCDRadiusMultiplier_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_CCDRadiusMultiplier_17, AssignFromStack_CCDRadiusMultiplier_17);
            field = type.GetField("AntiJitterDistance", flag);
            app.RegisterCLRFieldGetter(field, get_AntiJitterDistance_18);
            app.RegisterCLRFieldSetter(field, set_AntiJitterDistance_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_AntiJitterDistance_18, AssignFromStack_AntiJitterDistance_18);
            field = type.GetField("PredictionCorrectionSpeed", flag);
            app.RegisterCLRFieldGetter(field, get_PredictionCorrectionSpeed_19);
            app.RegisterCLRFieldSetter(field, set_PredictionCorrectionSpeed_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_PredictionCorrectionSpeed_19, AssignFromStack_PredictionCorrectionSpeed_19);
            field = type.GetField("NetworkedInteractions", flag);
            app.RegisterCLRFieldGetter(field, get_NetworkedInteractions_20);
            app.RegisterCLRFieldSetter(field, set_NetworkedInteractions_20);
            app.RegisterCLRFieldBinding(field, CopyToStack_NetworkedInteractions_20, AssignFromStack_NetworkedInteractions_20);
            field = type.GetField("CompressNetworkPosition", flag);
            app.RegisterCLRFieldGetter(field, get_CompressNetworkPosition_21);
            app.RegisterCLRFieldSetter(field, set_CompressNetworkPosition_21);
            app.RegisterCLRFieldBinding(field, CopyToStack_CompressNetworkPosition_21, AssignFromStack_CompressNetworkPosition_21);
            field = type.GetField("ForceSingleOverlapQuery", flag);
            app.RegisterCLRFieldGetter(field, get_ForceSingleOverlapQuery_22);
            app.RegisterCLRFieldSetter(field, set_ForceSingleOverlapQuery_22);
            app.RegisterCLRFieldBinding(field, CopyToStack_ForceSingleOverlapQuery_22, AssignFromStack_ForceSingleOverlapQuery_22);
            field = type.GetField("SuppressConvexMeshColliders", flag);
            app.RegisterCLRFieldGetter(field, get_SuppressConvexMeshColliders_23);
            app.RegisterCLRFieldSetter(field, set_SuppressConvexMeshColliders_23);
            app.RegisterCLRFieldBinding(field, CopyToStack_SuppressConvexMeshColliders_23, AssignFromStack_SuppressConvexMeshColliders_23);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.KCCSettings());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.KCCSettings[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* CopyFromOther_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCSettings @other = (Fusion.Addons.KCC.KCCSettings)typeof(Fusion.Addons.KCC.KCCSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCSettings instance_of_this_method = (Fusion.Addons.KCC.KCCSettings)typeof(Fusion.Addons.KCC.KCCSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyFromOther(@other);

            return __ret;
        }


        static object get_MaxNestedStages_0(ref object o)
        {
            return Fusion.Addons.KCC.KCCSettings.MaxNestedStages;
        }

        static StackObject* CopyToStack_MaxNestedStages_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCSettings.MaxNestedStages;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_ExtrapolationDeltaTimeThreshold_1(ref object o)
        {
            return Fusion.Addons.KCC.KCCSettings.ExtrapolationDeltaTimeThreshold;
        }

        static StackObject* CopyToStack_ExtrapolationDeltaTimeThreshold_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCSettings.ExtrapolationDeltaTimeThreshold;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_Shape_2(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).Shape;
        }

        static StackObject* CopyToStack_Shape_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).Shape;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Shape_2(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).Shape = (Fusion.Addons.KCC.EKCCShape)v;
        }

        static StackObject* AssignFromStack_Shape_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.EKCCShape @Shape = (Fusion.Addons.KCC.EKCCShape)typeof(Fusion.Addons.KCC.EKCCShape).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Fusion.Addons.KCC.KCCSettings)o).Shape = @Shape;
            return ptr_of_this_method;
        }

        static object get_IsTrigger_3(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).IsTrigger;
        }

        static StackObject* CopyToStack_IsTrigger_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).IsTrigger;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsTrigger_3(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).IsTrigger = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsTrigger_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsTrigger = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCSettings)o).IsTrigger = @IsTrigger;
            return ptr_of_this_method;
        }

        static object get_Radius_4(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).Radius;
        }

        static StackObject* CopyToStack_Radius_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).Radius;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Radius_4(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).Radius = (System.Single)v;
        }

        static StackObject* AssignFromStack_Radius_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @Radius = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCSettings)o).Radius = @Radius;
            return ptr_of_this_method;
        }

        static object get_Height_5(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).Height;
        }

        static StackObject* CopyToStack_Height_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).Height;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Height_5(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).Height = (System.Single)v;
        }

        static StackObject* AssignFromStack_Height_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @Height = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCSettings)o).Height = @Height;
            return ptr_of_this_method;
        }

        static object get_Extent_6(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).Extent;
        }

        static StackObject* CopyToStack_Extent_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).Extent;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Extent_6(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).Extent = (System.Single)v;
        }

        static StackObject* AssignFromStack_Extent_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @Extent = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCSettings)o).Extent = @Extent;
            return ptr_of_this_method;
        }

        static object get_ColliderLayer_7(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).ColliderLayer;
        }

        static StackObject* CopyToStack_ColliderLayer_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).ColliderLayer;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_ColliderLayer_7(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).ColliderLayer = (System.Int32)v;
        }

        static StackObject* AssignFromStack_ColliderLayer_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @ColliderLayer = ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCSettings)o).ColliderLayer = @ColliderLayer;
            return ptr_of_this_method;
        }

        static object get_CollisionLayerMask_8(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).CollisionLayerMask;
        }

        static StackObject* CopyToStack_CollisionLayerMask_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).CollisionLayerMask;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_CollisionLayerMask_8(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).CollisionLayerMask = (UnityEngine.LayerMask)v;
        }

        static StackObject* AssignFromStack_CollisionLayerMask_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.LayerMask @CollisionLayerMask = (UnityEngine.LayerMask)typeof(UnityEngine.LayerMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCSettings)o).CollisionLayerMask = @CollisionLayerMask;
            return ptr_of_this_method;
        }

        static object get_Features_9(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).Features;
        }

        static StackObject* CopyToStack_Features_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).Features;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Features_9(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).Features = (Fusion.Addons.KCC.EKCCFeatures)v;
        }

        static StackObject* AssignFromStack_Features_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.EKCCFeatures @Features = (Fusion.Addons.KCC.EKCCFeatures)typeof(Fusion.Addons.KCC.EKCCFeatures).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Fusion.Addons.KCC.KCCSettings)o).Features = @Features;
            return ptr_of_this_method;
        }

        static object get_InputAuthorityBehavior_10(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).InputAuthorityBehavior;
        }

        static StackObject* CopyToStack_InputAuthorityBehavior_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).InputAuthorityBehavior;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_InputAuthorityBehavior_10(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).InputAuthorityBehavior = (Fusion.Addons.KCC.EKCCAuthorityBehavior)v;
        }

        static StackObject* AssignFromStack_InputAuthorityBehavior_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.EKCCAuthorityBehavior @InputAuthorityBehavior = (Fusion.Addons.KCC.EKCCAuthorityBehavior)typeof(Fusion.Addons.KCC.EKCCAuthorityBehavior).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Fusion.Addons.KCC.KCCSettings)o).InputAuthorityBehavior = @InputAuthorityBehavior;
            return ptr_of_this_method;
        }

        static object get_StateAuthorityBehavior_11(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).StateAuthorityBehavior;
        }

        static StackObject* CopyToStack_StateAuthorityBehavior_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).StateAuthorityBehavior;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_StateAuthorityBehavior_11(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).StateAuthorityBehavior = (Fusion.Addons.KCC.EKCCAuthorityBehavior)v;
        }

        static StackObject* AssignFromStack_StateAuthorityBehavior_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.EKCCAuthorityBehavior @StateAuthorityBehavior = (Fusion.Addons.KCC.EKCCAuthorityBehavior)typeof(Fusion.Addons.KCC.EKCCAuthorityBehavior).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Fusion.Addons.KCC.KCCSettings)o).StateAuthorityBehavior = @StateAuthorityBehavior;
            return ptr_of_this_method;
        }

        static object get_ProxyInterpolationMode_12(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).ProxyInterpolationMode;
        }

        static StackObject* CopyToStack_ProxyInterpolationMode_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).ProxyInterpolationMode;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ProxyInterpolationMode_12(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).ProxyInterpolationMode = (Fusion.Addons.KCC.EKCCInterpolationMode)v;
        }

        static StackObject* AssignFromStack_ProxyInterpolationMode_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.EKCCInterpolationMode @ProxyInterpolationMode = (Fusion.Addons.KCC.EKCCInterpolationMode)typeof(Fusion.Addons.KCC.EKCCInterpolationMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Fusion.Addons.KCC.KCCSettings)o).ProxyInterpolationMode = @ProxyInterpolationMode;
            return ptr_of_this_method;
        }

        static object get_ForcePredictedLookRotation_13(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).ForcePredictedLookRotation;
        }

        static StackObject* CopyToStack_ForcePredictedLookRotation_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).ForcePredictedLookRotation;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_ForcePredictedLookRotation_13(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).ForcePredictedLookRotation = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_ForcePredictedLookRotation_13(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @ForcePredictedLookRotation = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCSettings)o).ForcePredictedLookRotation = @ForcePredictedLookRotation;
            return ptr_of_this_method;
        }

        static object get_AllowClientTeleports_14(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).AllowClientTeleports;
        }

        static StackObject* CopyToStack_AllowClientTeleports_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).AllowClientTeleports;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_AllowClientTeleports_14(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).AllowClientTeleports = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_AllowClientTeleports_14(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @AllowClientTeleports = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCSettings)o).AllowClientTeleports = @AllowClientTeleports;
            return ptr_of_this_method;
        }

        static object get_Processors_15(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).Processors;
        }

        static StackObject* CopyToStack_Processors_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).Processors;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Processors_15(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).Processors = (UnityEngine.Object[])v;
        }

        static StackObject* AssignFromStack_Processors_15(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Object[] @Processors = (UnityEngine.Object[])typeof(UnityEngine.Object[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCSettings)o).Processors = @Processors;
            return ptr_of_this_method;
        }

        static object get_MaxPenetrationSteps_16(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).MaxPenetrationSteps;
        }

        static StackObject* CopyToStack_MaxPenetrationSteps_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).MaxPenetrationSteps;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_MaxPenetrationSteps_16(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).MaxPenetrationSteps = (System.Int32)v;
        }

        static StackObject* AssignFromStack_MaxPenetrationSteps_16(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @MaxPenetrationSteps = ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCSettings)o).MaxPenetrationSteps = @MaxPenetrationSteps;
            return ptr_of_this_method;
        }

        static object get_CCDRadiusMultiplier_17(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).CCDRadiusMultiplier;
        }

        static StackObject* CopyToStack_CCDRadiusMultiplier_17(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).CCDRadiusMultiplier;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_CCDRadiusMultiplier_17(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).CCDRadiusMultiplier = (System.Single)v;
        }

        static StackObject* AssignFromStack_CCDRadiusMultiplier_17(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @CCDRadiusMultiplier = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCSettings)o).CCDRadiusMultiplier = @CCDRadiusMultiplier;
            return ptr_of_this_method;
        }

        static object get_AntiJitterDistance_18(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).AntiJitterDistance;
        }

        static StackObject* CopyToStack_AntiJitterDistance_18(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).AntiJitterDistance;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AntiJitterDistance_18(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).AntiJitterDistance = (UnityEngine.Vector2)v;
        }

        static StackObject* AssignFromStack_AntiJitterDistance_18(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector2 @AntiJitterDistance = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCSettings)o).AntiJitterDistance = @AntiJitterDistance;
            return ptr_of_this_method;
        }

        static object get_PredictionCorrectionSpeed_19(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).PredictionCorrectionSpeed;
        }

        static StackObject* CopyToStack_PredictionCorrectionSpeed_19(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).PredictionCorrectionSpeed;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_PredictionCorrectionSpeed_19(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).PredictionCorrectionSpeed = (System.Single)v;
        }

        static StackObject* AssignFromStack_PredictionCorrectionSpeed_19(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @PredictionCorrectionSpeed = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCSettings)o).PredictionCorrectionSpeed = @PredictionCorrectionSpeed;
            return ptr_of_this_method;
        }

        static object get_NetworkedInteractions_20(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).NetworkedInteractions;
        }

        static StackObject* CopyToStack_NetworkedInteractions_20(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).NetworkedInteractions;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_NetworkedInteractions_20(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).NetworkedInteractions = (System.Int32)v;
        }

        static StackObject* AssignFromStack_NetworkedInteractions_20(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @NetworkedInteractions = ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCSettings)o).NetworkedInteractions = @NetworkedInteractions;
            return ptr_of_this_method;
        }

        static object get_CompressNetworkPosition_21(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).CompressNetworkPosition;
        }

        static StackObject* CopyToStack_CompressNetworkPosition_21(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).CompressNetworkPosition;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_CompressNetworkPosition_21(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).CompressNetworkPosition = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_CompressNetworkPosition_21(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @CompressNetworkPosition = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCSettings)o).CompressNetworkPosition = @CompressNetworkPosition;
            return ptr_of_this_method;
        }

        static object get_ForceSingleOverlapQuery_22(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).ForceSingleOverlapQuery;
        }

        static StackObject* CopyToStack_ForceSingleOverlapQuery_22(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).ForceSingleOverlapQuery;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_ForceSingleOverlapQuery_22(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).ForceSingleOverlapQuery = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_ForceSingleOverlapQuery_22(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @ForceSingleOverlapQuery = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCSettings)o).ForceSingleOverlapQuery = @ForceSingleOverlapQuery;
            return ptr_of_this_method;
        }

        static object get_SuppressConvexMeshColliders_23(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCSettings)o).SuppressConvexMeshColliders;
        }

        static StackObject* CopyToStack_SuppressConvexMeshColliders_23(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCSettings)o).SuppressConvexMeshColliders;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SuppressConvexMeshColliders_23(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCSettings)o).SuppressConvexMeshColliders = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SuppressConvexMeshColliders_23(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SuppressConvexMeshColliders = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCSettings)o).SuppressConvexMeshColliders = @SuppressConvexMeshColliders;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Addons.KCC.KCCSettings();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

#if FUSION2 && XRMOD_INSTALL

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
    unsafe class Fusion_Addons_KCC_KCCShapeCastInfo_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.KCC.KCCShapeCastInfo);
            args = new Type[]{typeof(UnityEngine.RaycastHit)};
            method = type.GetMethod("AddHit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddHit_0);
            args = new Type[]{};
            method = type.GetMethod("Sort", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Sort_1);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("Reset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Reset_2);
            args = new Type[]{typeof(Fusion.Addons.KCC.KCC)};
            method = type.GetMethod("DumpHits", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DumpHits_3);

            field = type.GetField("Position", flag);
            app.RegisterCLRFieldGetter(field, get_Position_0);
            app.RegisterCLRFieldSetter(field, set_Position_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Position_0, AssignFromStack_Position_0);
            field = type.GetField("Radius", flag);
            app.RegisterCLRFieldGetter(field, get_Radius_1);
            app.RegisterCLRFieldSetter(field, set_Radius_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Radius_1, AssignFromStack_Radius_1);
            field = type.GetField("Height", flag);
            app.RegisterCLRFieldGetter(field, get_Height_2);
            app.RegisterCLRFieldSetter(field, set_Height_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Height_2, AssignFromStack_Height_2);
            field = type.GetField("Extent", flag);
            app.RegisterCLRFieldGetter(field, get_Extent_3);
            app.RegisterCLRFieldSetter(field, set_Extent_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Extent_3, AssignFromStack_Extent_3);
            field = type.GetField("Direction", flag);
            app.RegisterCLRFieldGetter(field, get_Direction_4);
            app.RegisterCLRFieldSetter(field, set_Direction_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Direction_4, AssignFromStack_Direction_4);
            field = type.GetField("MaxDistance", flag);
            app.RegisterCLRFieldGetter(field, get_MaxDistance_5);
            app.RegisterCLRFieldSetter(field, set_MaxDistance_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_MaxDistance_5, AssignFromStack_MaxDistance_5);
            field = type.GetField("LayerMask", flag);
            app.RegisterCLRFieldGetter(field, get_LayerMask_6);
            app.RegisterCLRFieldSetter(field, set_LayerMask_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_LayerMask_6, AssignFromStack_LayerMask_6);
            field = type.GetField("TriggerInteraction", flag);
            app.RegisterCLRFieldGetter(field, get_TriggerInteraction_7);
            app.RegisterCLRFieldSetter(field, set_TriggerInteraction_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_TriggerInteraction_7, AssignFromStack_TriggerInteraction_7);
            field = type.GetField("AllHits", flag);
            app.RegisterCLRFieldGetter(field, get_AllHits_8);
            app.RegisterCLRFieldSetter(field, set_AllHits_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_AllHits_8, AssignFromStack_AllHits_8);
            field = type.GetField("AllHitCount", flag);
            app.RegisterCLRFieldGetter(field, get_AllHitCount_9);
            app.RegisterCLRFieldSetter(field, set_AllHitCount_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_AllHitCount_9, AssignFromStack_AllHitCount_9);
            field = type.GetField("ColliderHits", flag);
            app.RegisterCLRFieldGetter(field, get_ColliderHits_10);
            app.RegisterCLRFieldSetter(field, set_ColliderHits_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_ColliderHits_10, AssignFromStack_ColliderHits_10);
            field = type.GetField("ColliderHitCount", flag);
            app.RegisterCLRFieldGetter(field, get_ColliderHitCount_11);
            app.RegisterCLRFieldSetter(field, set_ColliderHitCount_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_ColliderHitCount_11, AssignFromStack_ColliderHitCount_11);
            field = type.GetField("TriggerHits", flag);
            app.RegisterCLRFieldGetter(field, get_TriggerHits_12);
            app.RegisterCLRFieldSetter(field, set_TriggerHits_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_TriggerHits_12, AssignFromStack_TriggerHits_12);
            field = type.GetField("TriggerHitCount", flag);
            app.RegisterCLRFieldGetter(field, get_TriggerHitCount_13);
            app.RegisterCLRFieldSetter(field, set_TriggerHitCount_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_TriggerHitCount_13, AssignFromStack_TriggerHitCount_13);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.KCCShapeCastInfo());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.KCCShapeCastInfo[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);

        }


        static StackObject* AddHit_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RaycastHit @raycastHit = (UnityEngine.RaycastHit)typeof(UnityEngine.RaycastHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCShapeCastInfo instance_of_this_method = (Fusion.Addons.KCC.KCCShapeCastInfo)typeof(Fusion.Addons.KCC.KCCShapeCastInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddHit(@raycastHit);

            return __ret;
        }

        static StackObject* Sort_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCShapeCastInfo instance_of_this_method = (Fusion.Addons.KCC.KCCShapeCastInfo)typeof(Fusion.Addons.KCC.KCCShapeCastInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Sort();

            return __ret;
        }

        static StackObject* Reset_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @deep = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCShapeCastInfo instance_of_this_method = (Fusion.Addons.KCC.KCCShapeCastInfo)typeof(Fusion.Addons.KCC.KCCShapeCastInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Reset(@deep);

            return __ret;
        }

        static StackObject* DumpHits_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCC @kcc = (Fusion.Addons.KCC.KCC)typeof(Fusion.Addons.KCC.KCC).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCShapeCastInfo instance_of_this_method = (Fusion.Addons.KCC.KCCShapeCastInfo)typeof(Fusion.Addons.KCC.KCCShapeCastInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DumpHits(@kcc);

            return __ret;
        }


        static object get_Position_0(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCShapeCastInfo)o).Position;
        }

        static StackObject* CopyToStack_Position_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCShapeCastInfo)o).Position;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Position_0(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).Position = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_Position_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @Position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).Position = @Position;
            return ptr_of_this_method;
        }

        static object get_Radius_1(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCShapeCastInfo)o).Radius;
        }

        static StackObject* CopyToStack_Radius_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCShapeCastInfo)o).Radius;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Radius_1(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).Radius = (System.Single)v;
        }

        static StackObject* AssignFromStack_Radius_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @Radius = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).Radius = @Radius;
            return ptr_of_this_method;
        }

        static object get_Height_2(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCShapeCastInfo)o).Height;
        }

        static StackObject* CopyToStack_Height_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCShapeCastInfo)o).Height;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Height_2(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).Height = (System.Single)v;
        }

        static StackObject* AssignFromStack_Height_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @Height = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).Height = @Height;
            return ptr_of_this_method;
        }

        static object get_Extent_3(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCShapeCastInfo)o).Extent;
        }

        static StackObject* CopyToStack_Extent_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCShapeCastInfo)o).Extent;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Extent_3(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).Extent = (System.Single)v;
        }

        static StackObject* AssignFromStack_Extent_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @Extent = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).Extent = @Extent;
            return ptr_of_this_method;
        }

        static object get_Direction_4(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCShapeCastInfo)o).Direction;
        }

        static StackObject* CopyToStack_Direction_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCShapeCastInfo)o).Direction;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Direction_4(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).Direction = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_Direction_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @Direction = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).Direction = @Direction;
            return ptr_of_this_method;
        }

        static object get_MaxDistance_5(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCShapeCastInfo)o).MaxDistance;
        }

        static StackObject* CopyToStack_MaxDistance_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCShapeCastInfo)o).MaxDistance;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_MaxDistance_5(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).MaxDistance = (System.Single)v;
        }

        static StackObject* AssignFromStack_MaxDistance_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @MaxDistance = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).MaxDistance = @MaxDistance;
            return ptr_of_this_method;
        }

        static object get_LayerMask_6(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCShapeCastInfo)o).LayerMask;
        }

        static StackObject* CopyToStack_LayerMask_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCShapeCastInfo)o).LayerMask;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LayerMask_6(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).LayerMask = (UnityEngine.LayerMask)v;
        }

        static StackObject* AssignFromStack_LayerMask_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.LayerMask @LayerMask = (UnityEngine.LayerMask)typeof(UnityEngine.LayerMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).LayerMask = @LayerMask;
            return ptr_of_this_method;
        }

        static object get_TriggerInteraction_7(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCShapeCastInfo)o).TriggerInteraction;
        }

        static StackObject* CopyToStack_TriggerInteraction_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCShapeCastInfo)o).TriggerInteraction;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TriggerInteraction_7(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).TriggerInteraction = (UnityEngine.QueryTriggerInteraction)v;
        }

        static StackObject* AssignFromStack_TriggerInteraction_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.QueryTriggerInteraction @TriggerInteraction = (UnityEngine.QueryTriggerInteraction)typeof(UnityEngine.QueryTriggerInteraction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).TriggerInteraction = @TriggerInteraction;
            return ptr_of_this_method;
        }

        static object get_AllHits_8(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCShapeCastInfo)o).AllHits;
        }

        static StackObject* CopyToStack_AllHits_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCShapeCastInfo)o).AllHits;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AllHits_8(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).AllHits = (Fusion.Addons.KCC.KCCShapeCastHit[])v;
        }

        static StackObject* AssignFromStack_AllHits_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.KCCShapeCastHit[] @AllHits = (Fusion.Addons.KCC.KCCShapeCastHit[])typeof(Fusion.Addons.KCC.KCCShapeCastHit[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).AllHits = @AllHits;
            return ptr_of_this_method;
        }

        static object get_AllHitCount_9(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCShapeCastInfo)o).AllHitCount;
        }

        static StackObject* CopyToStack_AllHitCount_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCShapeCastInfo)o).AllHitCount;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_AllHitCount_9(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).AllHitCount = (System.Int32)v;
        }

        static StackObject* AssignFromStack_AllHitCount_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @AllHitCount = ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).AllHitCount = @AllHitCount;
            return ptr_of_this_method;
        }

        static object get_ColliderHits_10(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCShapeCastInfo)o).ColliderHits;
        }

        static StackObject* CopyToStack_ColliderHits_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCShapeCastInfo)o).ColliderHits;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ColliderHits_10(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).ColliderHits = (Fusion.Addons.KCC.KCCShapeCastHit[])v;
        }

        static StackObject* AssignFromStack_ColliderHits_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.KCCShapeCastHit[] @ColliderHits = (Fusion.Addons.KCC.KCCShapeCastHit[])typeof(Fusion.Addons.KCC.KCCShapeCastHit[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).ColliderHits = @ColliderHits;
            return ptr_of_this_method;
        }

        static object get_ColliderHitCount_11(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCShapeCastInfo)o).ColliderHitCount;
        }

        static StackObject* CopyToStack_ColliderHitCount_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCShapeCastInfo)o).ColliderHitCount;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_ColliderHitCount_11(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).ColliderHitCount = (System.Int32)v;
        }

        static StackObject* AssignFromStack_ColliderHitCount_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @ColliderHitCount = ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).ColliderHitCount = @ColliderHitCount;
            return ptr_of_this_method;
        }

        static object get_TriggerHits_12(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCShapeCastInfo)o).TriggerHits;
        }

        static StackObject* CopyToStack_TriggerHits_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCShapeCastInfo)o).TriggerHits;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TriggerHits_12(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).TriggerHits = (Fusion.Addons.KCC.KCCShapeCastHit[])v;
        }

        static StackObject* AssignFromStack_TriggerHits_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.KCCShapeCastHit[] @TriggerHits = (Fusion.Addons.KCC.KCCShapeCastHit[])typeof(Fusion.Addons.KCC.KCCShapeCastHit[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).TriggerHits = @TriggerHits;
            return ptr_of_this_method;
        }

        static object get_TriggerHitCount_13(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCShapeCastInfo)o).TriggerHitCount;
        }

        static StackObject* CopyToStack_TriggerHitCount_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCShapeCastInfo)o).TriggerHitCount;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_TriggerHitCount_13(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).TriggerHitCount = (System.Int32)v;
        }

        static StackObject* AssignFromStack_TriggerHitCount_13(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @TriggerHitCount = ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCShapeCastInfo)o).TriggerHitCount = @TriggerHitCount;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Addons.KCC.KCCShapeCastInfo();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @maxHits = ptr_of_this_method->Value;


            var result_of_this_method = new Fusion.Addons.KCC.KCCShapeCastInfo(@maxHits);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
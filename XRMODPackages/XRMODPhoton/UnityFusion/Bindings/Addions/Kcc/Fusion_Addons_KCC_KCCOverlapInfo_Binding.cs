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
    unsafe class Fusion_Addons_KCC_KCCOverlapInfo_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.KCC.KCCOverlapInfo);
            args = new Type[]{typeof(UnityEngine.Collider)};
            method = type.GetMethod("AddHit", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddHit_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("ToggleConvexMeshColliders", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToggleConvexMeshColliders_1);
            args = new Type[]{};
            method = type.GetMethod("AllHitsWithinExtent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AllHitsWithinExtent_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("Reset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Reset_3);
            args = new Type[]{typeof(Fusion.Addons.KCC.KCCOverlapInfo)};
            method = type.GetMethod("CopyFromOther", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyFromOther_4);
            args = new Type[]{typeof(Fusion.Addons.KCC.KCC)};
            method = type.GetMethod("DumpHits", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DumpHits_5);

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
            field = type.GetField("LayerMask", flag);
            app.RegisterCLRFieldGetter(field, get_LayerMask_4);
            app.RegisterCLRFieldSetter(field, set_LayerMask_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_LayerMask_4, AssignFromStack_LayerMask_4);
            field = type.GetField("TriggerInteraction", flag);
            app.RegisterCLRFieldGetter(field, get_TriggerInteraction_5);
            app.RegisterCLRFieldSetter(field, set_TriggerInteraction_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_TriggerInteraction_5, AssignFromStack_TriggerInteraction_5);
            field = type.GetField("AllHits", flag);
            app.RegisterCLRFieldGetter(field, get_AllHits_6);
            app.RegisterCLRFieldSetter(field, set_AllHits_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_AllHits_6, AssignFromStack_AllHits_6);
            field = type.GetField("AllHitCount", flag);
            app.RegisterCLRFieldGetter(field, get_AllHitCount_7);
            app.RegisterCLRFieldSetter(field, set_AllHitCount_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_AllHitCount_7, AssignFromStack_AllHitCount_7);
            field = type.GetField("ColliderHits", flag);
            app.RegisterCLRFieldGetter(field, get_ColliderHits_8);
            app.RegisterCLRFieldSetter(field, set_ColliderHits_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_ColliderHits_8, AssignFromStack_ColliderHits_8);
            field = type.GetField("ColliderHitCount", flag);
            app.RegisterCLRFieldGetter(field, get_ColliderHitCount_9);
            app.RegisterCLRFieldSetter(field, set_ColliderHitCount_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_ColliderHitCount_9, AssignFromStack_ColliderHitCount_9);
            field = type.GetField("TriggerHits", flag);
            app.RegisterCLRFieldGetter(field, get_TriggerHits_10);
            app.RegisterCLRFieldSetter(field, set_TriggerHits_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_TriggerHits_10, AssignFromStack_TriggerHits_10);
            field = type.GetField("TriggerHitCount", flag);
            app.RegisterCLRFieldGetter(field, get_TriggerHitCount_11);
            app.RegisterCLRFieldSetter(field, set_TriggerHitCount_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_TriggerHitCount_11, AssignFromStack_TriggerHitCount_11);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.KCCOverlapInfo());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.KCCOverlapInfo[s]);

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
            UnityEngine.Collider @collider = (UnityEngine.Collider)typeof(UnityEngine.Collider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCOverlapInfo instance_of_this_method = (Fusion.Addons.KCC.KCCOverlapInfo)typeof(Fusion.Addons.KCC.KCCOverlapInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddHit(@collider);

            return __ret;
        }

        static StackObject* ToggleConvexMeshColliders_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @convex = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCOverlapInfo instance_of_this_method = (Fusion.Addons.KCC.KCCOverlapInfo)typeof(Fusion.Addons.KCC.KCCOverlapInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ToggleConvexMeshColliders(@convex);

            return __ret;
        }

        static StackObject* AllHitsWithinExtent_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCOverlapInfo instance_of_this_method = (Fusion.Addons.KCC.KCCOverlapInfo)typeof(Fusion.Addons.KCC.KCCOverlapInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AllHitsWithinExtent();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Reset_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @deep = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCOverlapInfo instance_of_this_method = (Fusion.Addons.KCC.KCCOverlapInfo)typeof(Fusion.Addons.KCC.KCCOverlapInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Reset(@deep);

            return __ret;
        }

        static StackObject* CopyFromOther_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCOverlapInfo @other = (Fusion.Addons.KCC.KCCOverlapInfo)typeof(Fusion.Addons.KCC.KCCOverlapInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCOverlapInfo instance_of_this_method = (Fusion.Addons.KCC.KCCOverlapInfo)typeof(Fusion.Addons.KCC.KCCOverlapInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyFromOther(@other);

            return __ret;
        }

        static StackObject* DumpHits_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCC @kcc = (Fusion.Addons.KCC.KCC)typeof(Fusion.Addons.KCC.KCC).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCOverlapInfo instance_of_this_method = (Fusion.Addons.KCC.KCCOverlapInfo)typeof(Fusion.Addons.KCC.KCCOverlapInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DumpHits(@kcc);

            return __ret;
        }


        static object get_Position_0(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapInfo)o).Position;
        }

        static StackObject* CopyToStack_Position_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapInfo)o).Position;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Position_0(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).Position = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_Position_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @Position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).Position = @Position;
            return ptr_of_this_method;
        }

        static object get_Radius_1(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapInfo)o).Radius;
        }

        static StackObject* CopyToStack_Radius_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapInfo)o).Radius;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Radius_1(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).Radius = (System.Single)v;
        }

        static StackObject* AssignFromStack_Radius_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @Radius = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).Radius = @Radius;
            return ptr_of_this_method;
        }

        static object get_Height_2(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapInfo)o).Height;
        }

        static StackObject* CopyToStack_Height_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapInfo)o).Height;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Height_2(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).Height = (System.Single)v;
        }

        static StackObject* AssignFromStack_Height_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @Height = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).Height = @Height;
            return ptr_of_this_method;
        }

        static object get_Extent_3(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapInfo)o).Extent;
        }

        static StackObject* CopyToStack_Extent_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapInfo)o).Extent;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Extent_3(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).Extent = (System.Single)v;
        }

        static StackObject* AssignFromStack_Extent_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @Extent = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).Extent = @Extent;
            return ptr_of_this_method;
        }

        static object get_LayerMask_4(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapInfo)o).LayerMask;
        }

        static StackObject* CopyToStack_LayerMask_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapInfo)o).LayerMask;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LayerMask_4(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).LayerMask = (UnityEngine.LayerMask)v;
        }

        static StackObject* AssignFromStack_LayerMask_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.LayerMask @LayerMask = (UnityEngine.LayerMask)typeof(UnityEngine.LayerMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).LayerMask = @LayerMask;
            return ptr_of_this_method;
        }

        static object get_TriggerInteraction_5(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapInfo)o).TriggerInteraction;
        }

        static StackObject* CopyToStack_TriggerInteraction_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapInfo)o).TriggerInteraction;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TriggerInteraction_5(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).TriggerInteraction = (UnityEngine.QueryTriggerInteraction)v;
        }

        static StackObject* AssignFromStack_TriggerInteraction_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.QueryTriggerInteraction @TriggerInteraction = (UnityEngine.QueryTriggerInteraction)typeof(UnityEngine.QueryTriggerInteraction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).TriggerInteraction = @TriggerInteraction;
            return ptr_of_this_method;
        }

        static object get_AllHits_6(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapInfo)o).AllHits;
        }

        static StackObject* CopyToStack_AllHits_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapInfo)o).AllHits;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AllHits_6(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).AllHits = (Fusion.Addons.KCC.KCCOverlapHit[])v;
        }

        static StackObject* AssignFromStack_AllHits_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.KCCOverlapHit[] @AllHits = (Fusion.Addons.KCC.KCCOverlapHit[])typeof(Fusion.Addons.KCC.KCCOverlapHit[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).AllHits = @AllHits;
            return ptr_of_this_method;
        }

        static object get_AllHitCount_7(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapInfo)o).AllHitCount;
        }

        static StackObject* CopyToStack_AllHitCount_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapInfo)o).AllHitCount;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_AllHitCount_7(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).AllHitCount = (System.Int32)v;
        }

        static StackObject* AssignFromStack_AllHitCount_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @AllHitCount = ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).AllHitCount = @AllHitCount;
            return ptr_of_this_method;
        }

        static object get_ColliderHits_8(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapInfo)o).ColliderHits;
        }

        static StackObject* CopyToStack_ColliderHits_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapInfo)o).ColliderHits;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ColliderHits_8(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).ColliderHits = (Fusion.Addons.KCC.KCCOverlapHit[])v;
        }

        static StackObject* AssignFromStack_ColliderHits_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.KCCOverlapHit[] @ColliderHits = (Fusion.Addons.KCC.KCCOverlapHit[])typeof(Fusion.Addons.KCC.KCCOverlapHit[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).ColliderHits = @ColliderHits;
            return ptr_of_this_method;
        }

        static object get_ColliderHitCount_9(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapInfo)o).ColliderHitCount;
        }

        static StackObject* CopyToStack_ColliderHitCount_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapInfo)o).ColliderHitCount;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_ColliderHitCount_9(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).ColliderHitCount = (System.Int32)v;
        }

        static StackObject* AssignFromStack_ColliderHitCount_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @ColliderHitCount = ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).ColliderHitCount = @ColliderHitCount;
            return ptr_of_this_method;
        }

        static object get_TriggerHits_10(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapInfo)o).TriggerHits;
        }

        static StackObject* CopyToStack_TriggerHits_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapInfo)o).TriggerHits;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TriggerHits_10(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).TriggerHits = (Fusion.Addons.KCC.KCCOverlapHit[])v;
        }

        static StackObject* AssignFromStack_TriggerHits_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.KCCOverlapHit[] @TriggerHits = (Fusion.Addons.KCC.KCCOverlapHit[])typeof(Fusion.Addons.KCC.KCCOverlapHit[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).TriggerHits = @TriggerHits;
            return ptr_of_this_method;
        }

        static object get_TriggerHitCount_11(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapInfo)o).TriggerHitCount;
        }

        static StackObject* CopyToStack_TriggerHitCount_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapInfo)o).TriggerHitCount;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_TriggerHitCount_11(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).TriggerHitCount = (System.Int32)v;
        }

        static StackObject* AssignFromStack_TriggerHitCount_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @TriggerHitCount = ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCOverlapInfo)o).TriggerHitCount = @TriggerHitCount;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Addons.KCC.KCCOverlapInfo();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @maxHits = ptr_of_this_method->Value;


            var result_of_this_method = new Fusion.Addons.KCC.KCCOverlapInfo(@maxHits);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
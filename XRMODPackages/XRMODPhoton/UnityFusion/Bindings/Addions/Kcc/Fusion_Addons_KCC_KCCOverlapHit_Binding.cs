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
    unsafe class Fusion_Addons_KCC_KCCOverlapHit_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.KCC.KCCOverlapHit);
            args = new Type[]{};
            method = type.GetMethod("IsValid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsValid_0);
            args = new Type[]{typeof(UnityEngine.Collider)};
            method = type.GetMethod("Set", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Set_1);
            args = new Type[]{};
            method = type.GetMethod("Reset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Reset_2);
            args = new Type[]{typeof(Fusion.Addons.KCC.KCCOverlapHit)};
            method = type.GetMethod("CopyFromOther", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyFromOther_3);

            field = type.GetField("Type", flag);
            app.RegisterCLRFieldGetter(field, get_Type_0);
            app.RegisterCLRFieldSetter(field, set_Type_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Type_0, AssignFromStack_Type_0);
            field = type.GetField("Collider", flag);
            app.RegisterCLRFieldGetter(field, get_Collider_1);
            app.RegisterCLRFieldSetter(field, set_Collider_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Collider_1, AssignFromStack_Collider_1);
            field = type.GetField("Transform", flag);
            app.RegisterCLRFieldGetter(field, get_Transform_2);
            app.RegisterCLRFieldSetter(field, set_Transform_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Transform_2, AssignFromStack_Transform_2);
            field = type.GetField("IsConvex", flag);
            app.RegisterCLRFieldGetter(field, get_IsConvex_3);
            app.RegisterCLRFieldSetter(field, set_IsConvex_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsConvex_3, AssignFromStack_IsConvex_3);
            field = type.GetField("IsTrigger", flag);
            app.RegisterCLRFieldGetter(field, get_IsTrigger_4);
            app.RegisterCLRFieldSetter(field, set_IsTrigger_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsTrigger_4, AssignFromStack_IsTrigger_4);
            field = type.GetField("IsPrimitive", flag);
            app.RegisterCLRFieldGetter(field, get_IsPrimitive_5);
            app.RegisterCLRFieldSetter(field, set_IsPrimitive_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsPrimitive_5, AssignFromStack_IsPrimitive_5);
            field = type.GetField("IsConvertible", flag);
            app.RegisterCLRFieldGetter(field, get_IsConvertible_6);
            app.RegisterCLRFieldSetter(field, set_IsConvertible_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsConvertible_6, AssignFromStack_IsConvertible_6);
            field = type.GetField("IsWithinExtent", flag);
            app.RegisterCLRFieldGetter(field, get_IsWithinExtent_7);
            app.RegisterCLRFieldSetter(field, set_IsWithinExtent_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsWithinExtent_7, AssignFromStack_IsWithinExtent_7);
            field = type.GetField("HasPenetration", flag);
            app.RegisterCLRFieldGetter(field, get_HasPenetration_8);
            app.RegisterCLRFieldSetter(field, set_HasPenetration_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_HasPenetration_8, AssignFromStack_HasPenetration_8);
            field = type.GetField("MaxPenetration", flag);
            app.RegisterCLRFieldGetter(field, get_MaxPenetration_9);
            app.RegisterCLRFieldSetter(field, set_MaxPenetration_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_MaxPenetration_9, AssignFromStack_MaxPenetration_9);
            field = type.GetField("UpDirectionDot", flag);
            app.RegisterCLRFieldGetter(field, get_UpDirectionDot_10);
            app.RegisterCLRFieldSetter(field, set_UpDirectionDot_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_UpDirectionDot_10, AssignFromStack_UpDirectionDot_10);
            field = type.GetField("CollisionType", flag);
            app.RegisterCLRFieldGetter(field, get_CollisionType_11);
            app.RegisterCLRFieldSetter(field, set_CollisionType_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_CollisionType_11, AssignFromStack_CollisionType_11);
            field = type.GetField("CachedPosition", flag);
            app.RegisterCLRFieldGetter(field, get_CachedPosition_12);
            app.RegisterCLRFieldSetter(field, set_CachedPosition_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_CachedPosition_12, AssignFromStack_CachedPosition_12);
            field = type.GetField("CachedRotation", flag);
            app.RegisterCLRFieldGetter(field, get_CachedRotation_13);
            app.RegisterCLRFieldSetter(field, set_CachedRotation_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_CachedRotation_13, AssignFromStack_CachedRotation_13);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.KCCOverlapHit());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.KCCOverlapHit[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* IsValid_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCOverlapHit instance_of_this_method = (Fusion.Addons.KCC.KCCOverlapHit)typeof(Fusion.Addons.KCC.KCCOverlapHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsValid();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Set_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Collider @collider = (UnityEngine.Collider)typeof(UnityEngine.Collider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCOverlapHit instance_of_this_method = (Fusion.Addons.KCC.KCCOverlapHit)typeof(Fusion.Addons.KCC.KCCOverlapHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Set(@collider);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Reset_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCOverlapHit instance_of_this_method = (Fusion.Addons.KCC.KCCOverlapHit)typeof(Fusion.Addons.KCC.KCCOverlapHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Reset();

            return __ret;
        }

        static StackObject* CopyFromOther_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCOverlapHit @other = (Fusion.Addons.KCC.KCCOverlapHit)typeof(Fusion.Addons.KCC.KCCOverlapHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCOverlapHit instance_of_this_method = (Fusion.Addons.KCC.KCCOverlapHit)typeof(Fusion.Addons.KCC.KCCOverlapHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyFromOther(@other);

            return __ret;
        }


        static object get_Type_0(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapHit)o).Type;
        }

        static StackObject* CopyToStack_Type_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapHit)o).Type;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Type_0(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapHit)o).Type = (Fusion.Addons.KCC.EColliderType)v;
        }

        static StackObject* AssignFromStack_Type_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.EColliderType @Type = (Fusion.Addons.KCC.EColliderType)typeof(Fusion.Addons.KCC.EColliderType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Fusion.Addons.KCC.KCCOverlapHit)o).Type = @Type;
            return ptr_of_this_method;
        }

        static object get_Collider_1(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapHit)o).Collider;
        }

        static StackObject* CopyToStack_Collider_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapHit)o).Collider;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Collider_1(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapHit)o).Collider = (UnityEngine.Collider)v;
        }

        static StackObject* AssignFromStack_Collider_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Collider @Collider = (UnityEngine.Collider)typeof(UnityEngine.Collider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCOverlapHit)o).Collider = @Collider;
            return ptr_of_this_method;
        }

        static object get_Transform_2(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapHit)o).Transform;
        }

        static StackObject* CopyToStack_Transform_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapHit)o).Transform;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Transform_2(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapHit)o).Transform = (UnityEngine.Transform)v;
        }

        static StackObject* AssignFromStack_Transform_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Transform @Transform = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCOverlapHit)o).Transform = @Transform;
            return ptr_of_this_method;
        }

        static object get_IsConvex_3(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapHit)o).IsConvex;
        }

        static StackObject* CopyToStack_IsConvex_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapHit)o).IsConvex;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsConvex_3(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapHit)o).IsConvex = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsConvex_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsConvex = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCOverlapHit)o).IsConvex = @IsConvex;
            return ptr_of_this_method;
        }

        static object get_IsTrigger_4(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapHit)o).IsTrigger;
        }

        static StackObject* CopyToStack_IsTrigger_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapHit)o).IsTrigger;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsTrigger_4(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapHit)o).IsTrigger = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsTrigger_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsTrigger = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCOverlapHit)o).IsTrigger = @IsTrigger;
            return ptr_of_this_method;
        }

        static object get_IsPrimitive_5(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapHit)o).IsPrimitive;
        }

        static StackObject* CopyToStack_IsPrimitive_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapHit)o).IsPrimitive;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsPrimitive_5(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapHit)o).IsPrimitive = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsPrimitive_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsPrimitive = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCOverlapHit)o).IsPrimitive = @IsPrimitive;
            return ptr_of_this_method;
        }

        static object get_IsConvertible_6(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapHit)o).IsConvertible;
        }

        static StackObject* CopyToStack_IsConvertible_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapHit)o).IsConvertible;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsConvertible_6(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapHit)o).IsConvertible = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsConvertible_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsConvertible = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCOverlapHit)o).IsConvertible = @IsConvertible;
            return ptr_of_this_method;
        }

        static object get_IsWithinExtent_7(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapHit)o).IsWithinExtent;
        }

        static StackObject* CopyToStack_IsWithinExtent_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapHit)o).IsWithinExtent;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsWithinExtent_7(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapHit)o).IsWithinExtent = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsWithinExtent_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsWithinExtent = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCOverlapHit)o).IsWithinExtent = @IsWithinExtent;
            return ptr_of_this_method;
        }

        static object get_HasPenetration_8(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapHit)o).HasPenetration;
        }

        static StackObject* CopyToStack_HasPenetration_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapHit)o).HasPenetration;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_HasPenetration_8(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapHit)o).HasPenetration = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_HasPenetration_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @HasPenetration = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCOverlapHit)o).HasPenetration = @HasPenetration;
            return ptr_of_this_method;
        }

        static object get_MaxPenetration_9(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapHit)o).MaxPenetration;
        }

        static StackObject* CopyToStack_MaxPenetration_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapHit)o).MaxPenetration;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_MaxPenetration_9(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapHit)o).MaxPenetration = (System.Single)v;
        }

        static StackObject* AssignFromStack_MaxPenetration_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @MaxPenetration = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCOverlapHit)o).MaxPenetration = @MaxPenetration;
            return ptr_of_this_method;
        }

        static object get_UpDirectionDot_10(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapHit)o).UpDirectionDot;
        }

        static StackObject* CopyToStack_UpDirectionDot_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapHit)o).UpDirectionDot;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_UpDirectionDot_10(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapHit)o).UpDirectionDot = (System.Single)v;
        }

        static StackObject* AssignFromStack_UpDirectionDot_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @UpDirectionDot = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCOverlapHit)o).UpDirectionDot = @UpDirectionDot;
            return ptr_of_this_method;
        }

        static object get_CollisionType_11(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapHit)o).CollisionType;
        }

        static StackObject* CopyToStack_CollisionType_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapHit)o).CollisionType;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_CollisionType_11(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapHit)o).CollisionType = (Fusion.Addons.KCC.ECollisionType)v;
        }

        static StackObject* AssignFromStack_CollisionType_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.ECollisionType @CollisionType = (Fusion.Addons.KCC.ECollisionType)typeof(Fusion.Addons.KCC.ECollisionType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Fusion.Addons.KCC.KCCOverlapHit)o).CollisionType = @CollisionType;
            return ptr_of_this_method;
        }

        static object get_CachedPosition_12(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapHit)o).CachedPosition;
        }

        static StackObject* CopyToStack_CachedPosition_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapHit)o).CachedPosition;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_CachedPosition_12(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapHit)o).CachedPosition = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_CachedPosition_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @CachedPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCOverlapHit)o).CachedPosition = @CachedPosition;
            return ptr_of_this_method;
        }

        static object get_CachedRotation_13(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCOverlapHit)o).CachedRotation;
        }

        static StackObject* CopyToStack_CachedRotation_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCOverlapHit)o).CachedRotation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_CachedRotation_13(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCOverlapHit)o).CachedRotation = (UnityEngine.Quaternion)v;
        }

        static StackObject* AssignFromStack_CachedRotation_13(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Quaternion @CachedRotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCOverlapHit)o).CachedRotation = @CachedRotation;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Addons.KCC.KCCOverlapHit();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
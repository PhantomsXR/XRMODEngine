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
    unsafe class Fusion_Addons_KCC_KCCCollider_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.KCC.KCCCollider);
            args = new Type[]{typeof(Fusion.Addons.KCC.KCC)};
            method = type.GetMethod("Update", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Update_0);
            args = new Type[]{};
            method = type.GetMethod("Destroy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Destroy_1);

            field = type.GetField("GameObject", flag);
            app.RegisterCLRFieldGetter(field, get_GameObject_0);
            app.RegisterCLRFieldSetter(field, set_GameObject_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_GameObject_0, AssignFromStack_GameObject_0);
            field = type.GetField("Transform", flag);
            app.RegisterCLRFieldGetter(field, get_Transform_1);
            app.RegisterCLRFieldSetter(field, set_Transform_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Transform_1, AssignFromStack_Transform_1);
            field = type.GetField("Collider", flag);
            app.RegisterCLRFieldGetter(field, get_Collider_2);
            app.RegisterCLRFieldSetter(field, set_Collider_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Collider_2, AssignFromStack_Collider_2);
            field = type.GetField("IsSpawned", flag);
            app.RegisterCLRFieldGetter(field, get_IsSpawned_3);
            app.RegisterCLRFieldSetter(field, set_IsSpawned_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsSpawned_3, AssignFromStack_IsSpawned_3);
            field = type.GetField("IsTrigger", flag);
            app.RegisterCLRFieldGetter(field, get_IsTrigger_4);
            app.RegisterCLRFieldSetter(field, set_IsTrigger_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsTrigger_4, AssignFromStack_IsTrigger_4);
            field = type.GetField("Radius", flag);
            app.RegisterCLRFieldGetter(field, get_Radius_5);
            app.RegisterCLRFieldSetter(field, set_Radius_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_Radius_5, AssignFromStack_Radius_5);
            field = type.GetField("Height", flag);
            app.RegisterCLRFieldGetter(field, get_Height_6);
            app.RegisterCLRFieldSetter(field, set_Height_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_Height_6, AssignFromStack_Height_6);
            field = type.GetField("Layer", flag);
            app.RegisterCLRFieldGetter(field, get_Layer_7);
            app.RegisterCLRFieldSetter(field, set_Layer_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_Layer_7, AssignFromStack_Layer_7);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.KCCCollider());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.KCCCollider[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Update_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCC @kcc = (Fusion.Addons.KCC.KCC)typeof(Fusion.Addons.KCC.KCC).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCCollider instance_of_this_method = (Fusion.Addons.KCC.KCCCollider)typeof(Fusion.Addons.KCC.KCCCollider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Update(@kcc);

            return __ret;
        }

        static StackObject* Destroy_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCCollider instance_of_this_method = (Fusion.Addons.KCC.KCCCollider)typeof(Fusion.Addons.KCC.KCCCollider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Destroy();

            return __ret;
        }


        static object get_GameObject_0(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCCollider)o).GameObject;
        }

        static StackObject* CopyToStack_GameObject_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCCollider)o).GameObject;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_GameObject_0(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCCollider)o).GameObject = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_GameObject_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @GameObject = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCCollider)o).GameObject = @GameObject;
            return ptr_of_this_method;
        }

        static object get_Transform_1(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCCollider)o).Transform;
        }

        static StackObject* CopyToStack_Transform_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCCollider)o).Transform;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Transform_1(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCCollider)o).Transform = (UnityEngine.Transform)v;
        }

        static StackObject* AssignFromStack_Transform_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Transform @Transform = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCCollider)o).Transform = @Transform;
            return ptr_of_this_method;
        }

        static object get_Collider_2(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCCollider)o).Collider;
        }

        static StackObject* CopyToStack_Collider_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCCollider)o).Collider;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Collider_2(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCCollider)o).Collider = (UnityEngine.CapsuleCollider)v;
        }

        static StackObject* AssignFromStack_Collider_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.CapsuleCollider @Collider = (UnityEngine.CapsuleCollider)typeof(UnityEngine.CapsuleCollider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCCollider)o).Collider = @Collider;
            return ptr_of_this_method;
        }

        static object get_IsSpawned_3(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCCollider)o).IsSpawned;
        }

        static StackObject* CopyToStack_IsSpawned_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCCollider)o).IsSpawned;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsSpawned_3(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCCollider)o).IsSpawned = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsSpawned_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsSpawned = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCCollider)o).IsSpawned = @IsSpawned;
            return ptr_of_this_method;
        }

        static object get_IsTrigger_4(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCCollider)o).IsTrigger;
        }

        static StackObject* CopyToStack_IsTrigger_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCCollider)o).IsTrigger;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsTrigger_4(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCCollider)o).IsTrigger = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsTrigger_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsTrigger = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCCollider)o).IsTrigger = @IsTrigger;
            return ptr_of_this_method;
        }

        static object get_Radius_5(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCCollider)o).Radius;
        }

        static StackObject* CopyToStack_Radius_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCCollider)o).Radius;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Radius_5(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCCollider)o).Radius = (System.Single)v;
        }

        static StackObject* AssignFromStack_Radius_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @Radius = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCCollider)o).Radius = @Radius;
            return ptr_of_this_method;
        }

        static object get_Height_6(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCCollider)o).Height;
        }

        static StackObject* CopyToStack_Height_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCCollider)o).Height;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Height_6(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCCollider)o).Height = (System.Single)v;
        }

        static StackObject* AssignFromStack_Height_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @Height = *(float*)&ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCCollider)o).Height = @Height;
            return ptr_of_this_method;
        }

        static object get_Layer_7(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCCollider)o).Layer;
        }

        static StackObject* CopyToStack_Layer_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCCollider)o).Layer;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Layer_7(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCCollider)o).Layer = (System.Int32)v;
        }

        static StackObject* AssignFromStack_Layer_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @Layer = ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCCollider)o).Layer = @Layer;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Addons.KCC.KCCCollider();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

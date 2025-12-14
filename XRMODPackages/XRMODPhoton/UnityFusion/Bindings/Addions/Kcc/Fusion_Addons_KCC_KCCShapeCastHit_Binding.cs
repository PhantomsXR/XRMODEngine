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
    unsafe class Fusion_Addons_KCC_KCCShapeCastHit_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.KCC.KCCShapeCastHit);
            args = new Type[]{};
            method = type.GetMethod("IsValid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsValid_0);
            args = new Type[]{typeof(UnityEngine.RaycastHit)};
            method = type.GetMethod("Set", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Set_1);
            args = new Type[]{};
            method = type.GetMethod("Reset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Reset_2);
            args = new Type[]{typeof(Fusion.Addons.KCC.KCCShapeCastHit)};
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
            field = type.GetField("IsTrigger", flag);
            app.RegisterCLRFieldGetter(field, get_IsTrigger_3);
            app.RegisterCLRFieldSetter(field, set_IsTrigger_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsTrigger_3, AssignFromStack_IsTrigger_3);
            field = type.GetField("IsPrimitive", flag);
            app.RegisterCLRFieldGetter(field, get_IsPrimitive_4);
            app.RegisterCLRFieldSetter(field, set_IsPrimitive_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsPrimitive_4, AssignFromStack_IsPrimitive_4);
            field = type.GetField("RaycastHit", flag);
            app.RegisterCLRFieldGetter(field, get_RaycastHit_5);
            app.RegisterCLRFieldSetter(field, set_RaycastHit_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_RaycastHit_5, AssignFromStack_RaycastHit_5);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.KCCShapeCastHit());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.KCCShapeCastHit[s]);

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
            Fusion.Addons.KCC.KCCShapeCastHit instance_of_this_method = (Fusion.Addons.KCC.KCCShapeCastHit)typeof(Fusion.Addons.KCC.KCCShapeCastHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
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
            UnityEngine.RaycastHit @raycastHit = (UnityEngine.RaycastHit)typeof(UnityEngine.RaycastHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCShapeCastHit instance_of_this_method = (Fusion.Addons.KCC.KCCShapeCastHit)typeof(Fusion.Addons.KCC.KCCShapeCastHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Set(@raycastHit);

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
            Fusion.Addons.KCC.KCCShapeCastHit instance_of_this_method = (Fusion.Addons.KCC.KCCShapeCastHit)typeof(Fusion.Addons.KCC.KCCShapeCastHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
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
            Fusion.Addons.KCC.KCCShapeCastHit @other = (Fusion.Addons.KCC.KCCShapeCastHit)typeof(Fusion.Addons.KCC.KCCShapeCastHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCShapeCastHit instance_of_this_method = (Fusion.Addons.KCC.KCCShapeCastHit)typeof(Fusion.Addons.KCC.KCCShapeCastHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyFromOther(@other);

            return __ret;
        }


        static object get_Type_0(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCShapeCastHit)o).Type;
        }

        static StackObject* CopyToStack_Type_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCShapeCastHit)o).Type;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Type_0(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCShapeCastHit)o).Type = (Fusion.Addons.KCC.EColliderType)v;
        }

        static StackObject* AssignFromStack_Type_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.EColliderType @Type = (Fusion.Addons.KCC.EColliderType)typeof(Fusion.Addons.KCC.EColliderType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Fusion.Addons.KCC.KCCShapeCastHit)o).Type = @Type;
            return ptr_of_this_method;
        }

        static object get_Collider_1(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCShapeCastHit)o).Collider;
        }

        static StackObject* CopyToStack_Collider_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCShapeCastHit)o).Collider;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Collider_1(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCShapeCastHit)o).Collider = (UnityEngine.Collider)v;
        }

        static StackObject* AssignFromStack_Collider_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Collider @Collider = (UnityEngine.Collider)typeof(UnityEngine.Collider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCShapeCastHit)o).Collider = @Collider;
            return ptr_of_this_method;
        }

        static object get_Transform_2(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCShapeCastHit)o).Transform;
        }

        static StackObject* CopyToStack_Transform_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCShapeCastHit)o).Transform;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Transform_2(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCShapeCastHit)o).Transform = (UnityEngine.Transform)v;
        }

        static StackObject* AssignFromStack_Transform_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Transform @Transform = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCShapeCastHit)o).Transform = @Transform;
            return ptr_of_this_method;
        }

        static object get_IsTrigger_3(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCShapeCastHit)o).IsTrigger;
        }

        static StackObject* CopyToStack_IsTrigger_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCShapeCastHit)o).IsTrigger;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsTrigger_3(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCShapeCastHit)o).IsTrigger = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsTrigger_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsTrigger = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCShapeCastHit)o).IsTrigger = @IsTrigger;
            return ptr_of_this_method;
        }

        static object get_IsPrimitive_4(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCShapeCastHit)o).IsPrimitive;
        }

        static StackObject* CopyToStack_IsPrimitive_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCShapeCastHit)o).IsPrimitive;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsPrimitive_4(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCShapeCastHit)o).IsPrimitive = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsPrimitive_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsPrimitive = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCShapeCastHit)o).IsPrimitive = @IsPrimitive;
            return ptr_of_this_method;
        }

        static object get_RaycastHit_5(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCShapeCastHit)o).RaycastHit;
        }

        static StackObject* CopyToStack_RaycastHit_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCShapeCastHit)o).RaycastHit;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_RaycastHit_5(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCShapeCastHit)o).RaycastHit = (UnityEngine.RaycastHit)v;
        }

        static StackObject* AssignFromStack_RaycastHit_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.RaycastHit @RaycastHit = (UnityEngine.RaycastHit)typeof(UnityEngine.RaycastHit).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCShapeCastHit)o).RaycastHit = @RaycastHit;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Addons.KCC.KCCShapeCastHit();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
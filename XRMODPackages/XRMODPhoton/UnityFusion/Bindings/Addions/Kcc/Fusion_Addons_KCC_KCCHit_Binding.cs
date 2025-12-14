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
    unsafe class Fusion_Addons_KCC_KCCHit_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.KCC.KCCHit);

            field = type.GetField("Collider", flag);
            app.RegisterCLRFieldGetter(field, get_Collider_0);
            app.RegisterCLRFieldSetter(field, set_Collider_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Collider_0, AssignFromStack_Collider_0);
            field = type.GetField("Transform", flag);
            app.RegisterCLRFieldGetter(field, get_Transform_1);
            app.RegisterCLRFieldSetter(field, set_Transform_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Transform_1, AssignFromStack_Transform_1);
            field = type.GetField("CollisionType", flag);
            app.RegisterCLRFieldGetter(field, get_CollisionType_2);
            app.RegisterCLRFieldSetter(field, set_CollisionType_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_CollisionType_2, AssignFromStack_CollisionType_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.KCCHit());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.KCCHit[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_Collider_0(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCHit)o).Collider;
        }

        static StackObject* CopyToStack_Collider_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCHit)o).Collider;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Collider_0(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCHit)o).Collider = (UnityEngine.Collider)v;
        }

        static StackObject* AssignFromStack_Collider_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Collider @Collider = (UnityEngine.Collider)typeof(UnityEngine.Collider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCHit)o).Collider = @Collider;
            return ptr_of_this_method;
        }

        static object get_Transform_1(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCHit)o).Transform;
        }

        static StackObject* CopyToStack_Transform_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCHit)o).Transform;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Transform_1(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCHit)o).Transform = (UnityEngine.Transform)v;
        }

        static StackObject* AssignFromStack_Transform_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Transform @Transform = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCHit)o).Transform = @Transform;
            return ptr_of_this_method;
        }

        static object get_CollisionType_2(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCHit)o).CollisionType;
        }

        static StackObject* CopyToStack_CollisionType_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCHit)o).CollisionType;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_CollisionType_2(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCHit)o).CollisionType = (Fusion.Addons.KCC.ECollisionType)v;
        }

        static StackObject* AssignFromStack_CollisionType_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.ECollisionType @CollisionType = (Fusion.Addons.KCC.ECollisionType)typeof(Fusion.Addons.KCC.ECollisionType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Fusion.Addons.KCC.KCCHit)o).CollisionType = @CollisionType;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Addons.KCC.KCCHit();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
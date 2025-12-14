using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Phantom.XRMOD.Core.Runtime;
using Phantom.XRMOD.XRMODUtilites.Runtime.UniPool;
using UnityEngine;
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
    unsafe class Phantom_XRMOD_XRMODUtilites_Runtime_UniPool_PoolCell_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell);

            field = type.GetField("IsPooled", flag);
            app.RegisterCLRFieldGetter(field, get_IsPooled_0);
            app.RegisterCLRFieldSetter(field, set_IsPooled_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsPooled_0, AssignFromStack_IsPooled_0);
            field = type.GetField("GameObject", flag);
            app.RegisterCLRFieldGetter(field, get_GameObject_1);
            app.RegisterCLRFieldSetter(field, set_GameObject_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_GameObject_1, AssignFromStack_GameObject_1);
            field = type.GetField("Transform", flag);
            app.RegisterCLRFieldGetter(field, get_Transform_2);
            app.RegisterCLRFieldSetter(field, set_Transform_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Transform_2, AssignFromStack_Transform_2);
            field = type.GetField("Component", flag);
            app.RegisterCLRFieldGetter(field, get_Component_3);
            app.RegisterCLRFieldSetter(field, set_Component_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Component_3, AssignFromStack_Component_3);


            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell[s]);


            args = new Type[] {typeof(UnityEngine.GameObject), typeof(UnityEngine.Transform), typeof(System.Boolean)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static object get_IsPooled_0(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell) o).IsPooled;
        }

        static StackObject* CopyToStack_IsPooled_0(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell) o).IsPooled;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsPooled_0(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell) o).IsPooled = (System.Boolean) v;
        }

        static StackObject* AssignFromStack_IsPooled_0(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsPooled = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell) o).IsPooled = @IsPooled;
            return ptr_of_this_method;
        }

        static object get_GameObject_1(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell) o).GameObject;
        }

        static StackObject* CopyToStack_GameObject_1(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell) o).GameObject;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_GameObject_1(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell) o).GameObject = (UnityEngine.GameObject) v;
        }

        static StackObject* AssignFromStack_GameObject_1(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @GameObject = (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell) o).GameObject = @GameObject;
            return ptr_of_this_method;
        }

        static object get_Transform_2(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell) o).Transform;
        }

        static StackObject* CopyToStack_Transform_2(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell) o).Transform;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Transform_2(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell) o).Transform = (UnityEngine.Transform) v;
        }

        static StackObject* AssignFromStack_Transform_2(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Transform @Transform = (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell) o).Transform = @Transform;
            return ptr_of_this_method;
        }

        static object get_Component_3(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell) o).Component;
        }

        static StackObject* CopyToStack_Component_3(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell) o).Component;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance, true);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method, true);
        }

        static void set_Component_3(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell) o).Component = (System.Object) v;
        }

        static StackObject* AssignFromStack_Component_3(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Object @Component = (System.Object) typeof(System.Object).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell) o).Component = @Component;
            return ptr_of_this_method;
        }


        // static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
        //     bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 3);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     UnityEngine.Transform @_container = (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
        //         StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
        //     UnityEngine.GameObject @_prefab = (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
        //         StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     Phantom.XRMOD.UnityFusion.Runtime.Utility.CheckoutIlTypeInstance(_prefab, out var tmp_Go, out var type);
        //     var tmp_Instantiate = UnityEngine.Object.Instantiate(tmp_Go, @_container);
        //     var tmp_XRMODInstancedGo =
        //         Phantom.XRMOD.UnityFusion.Runtime.Utility.DoBinding(_prefab, tmp_Instantiate, __domain, type) as
        //             GameObject;
        //     var result_of_this_method = new PoolCell(tmp_XRMODInstancedGo, @_container, true);
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }
        
        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @_isXRMOD = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform @_container = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GameObject @_prefab = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new PoolCell(@_prefab, @_container, @_isXRMOD);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

    }
}
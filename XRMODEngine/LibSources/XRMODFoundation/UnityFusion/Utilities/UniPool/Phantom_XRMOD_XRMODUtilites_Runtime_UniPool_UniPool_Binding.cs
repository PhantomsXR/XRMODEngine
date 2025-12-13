using System;
using System.Collections.Generic;
using System.Linq;
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
    unsafe class Phantom_XRMOD_XRMODUtilites_Runtime_UniPool_UniPool_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool);
            MethodInfo[] methods = type.GetMethods(flag).Where(t => !t.IsGenericMethod).ToArray();
            args = new Type[] {typeof(UnityEngine.GameObject)};
            method = type.GetMethod("Get", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Get_0);
            args = new Type[] {typeof(System.String)};
            method = methods.Single(t => t.Name.Equals("Get") && t.CheckMethodParams(args));
            app.RegisterCLRMethodRedirection(method, Get_1);
            args = new Type[] {typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell)};
            method = type.GetMethod("Release", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Release_2);
            args = new Type[] {typeof(UnityEngine.GameObject)};
            method = type.GetMethod("Release", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Release_3);
            args = new Type[] {typeof(UnityEngine.Transform)};
            method = type.GetMethod("Release", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Release_4);
            args = new Type[] {typeof(System.Object)};
            method = type.GetMethod("Release", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Release_5);
            args = new Type[] {typeof(UnityEngine.GameObject)};
            method = type.GetMethod("ReleaseAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReleaseAll_6);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("ReleaseAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReleaseAll_7);
            args = new Type[] {typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell), typeof(System.Single)};
            method = type.GetMethod("Release", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Release_8);
            args = new Type[] {typeof(UnityEngine.GameObject), typeof(System.Single)};
            method = type.GetMethod("Release", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Release_9);
            args = new Type[] {typeof(UnityEngine.Transform), typeof(System.Single)};
            method = type.GetMethod("Release", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Release_10);
            args = new Type[] {typeof(System.Object), typeof(System.Single)};
            method = type.GetMethod("Release", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Release_11);
            args = new Type[] {typeof(UnityEngine.GameObject), typeof(System.Single)};
            method = type.GetMethod("ReleaseAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReleaseAll_12);
            args = new Type[] {typeof(System.String), typeof(System.Single)};
            method = type.GetMethod("ReleaseAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReleaseAll_13);
            args = new Type[] {typeof(UnityEngine.GameObject), typeof(UnityEngine.Transform)};
            method = type.GetMethod("Register", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Register_14);
            args = new Type[] {typeof(UnityEngine.GameObject), typeof(System.String), typeof(UnityEngine.Transform)};
            method = type.GetMethod("Register", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Register_15);
            args = new Type[] {typeof(UnityEngine.GameObject)};
            method = type.GetMethod("Unregister", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Unregister_16);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("Unregister", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Unregister_17);
            args = new Type[] {typeof(UnityEngine.GameObject), typeof(System.Int32)};
            method = type.GetMethod("Fill", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Fill_18);
            args = new Type[] {typeof(System.String), typeof(System.Int32)};
            method = type.GetMethod("Fill", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Fill_19);
            args = new Type[]{typeof(UnityEngine.GameObject), typeof(System.Int32), typeof(UnityEngine.Transform)};
            method = type.GetMethod("Fill", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Fill_19_1);
            args = new Type[] {typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell), typeof(System.Boolean)};
            method = type.GetMethod("Remove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Remove_20);
            args = new Type[] {typeof(UnityEngine.GameObject), typeof(System.Boolean)};
            method = type.GetMethod("Remove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Remove_21);
            args = new Type[] {typeof(UnityEngine.Transform), typeof(System.Boolean)};
            method = type.GetMethod("Remove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Remove_22);
            args = new Type[] {typeof(System.Object), typeof(System.Boolean)};
            method = type.GetMethod("Remove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Remove_23);
            args = new Type[] {typeof(UnityEngine.GameObject)};
            method = type.GetMethod("DestroyAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DestroyAll_24);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("DestroyAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DestroyAll_25);
            args = new Type[] { };
            method = type.GetMethod("DestroyAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DestroyAll_26);
        }


        static StackObject* Get_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @_prefab = (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            SetXRMODEnableMark();
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Get(@_prefab);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        internal static void SetXRMODEnableMark()
        {
            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Pool.isXRMOD = true;
        }

        static StackObject* Get_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            SetXRMODEnableMark();
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Get(@_name);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Release_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            SetXRMODEnableMark();

            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell @_cell =
                (Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell)
                typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Release(@_cell);

            return __ret;
        }

        static StackObject* Release_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            SetXRMODEnableMark();

            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @actor = (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Release(@actor);

            return __ret;
        }

        static StackObject* Release_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            SetXRMODEnableMark();

            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @actorT = (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Release(@actorT);

            return __ret;
        }

        static StackObject* Release_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            SetXRMODEnableMark();

            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object @com = (System.Object) typeof(System.Object).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Release(@com);

            return __ret;
        }

        static StackObject* ReleaseAll_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            SetXRMODEnableMark();

            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @_prefab = (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.ReleaseAll(@_prefab);

            return __ret;
        }

        static StackObject* ReleaseAll_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            SetXRMODEnableMark();

            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.ReleaseAll(@_name);

            return __ret;
        }

        static StackObject* Release_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            SetXRMODEnableMark();
            
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @_delay = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell @_cell =
                (Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell)
                typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Release(@_cell, @_delay);

            return __ret;
        }

        static StackObject* Release_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            SetXRMODEnableMark();
            
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @_delay = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GameObject @_gameObject = (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Release(@_gameObject, @_delay);

            return __ret;
        }

        static StackObject* Release_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            SetXRMODEnableMark();
            
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @_delay = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform @_transform = (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Release(@_transform, @_delay);

            return __ret;
        }

        static StackObject* Release_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            SetXRMODEnableMark();
            
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @_delay = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Object @_component = (System.Object) typeof(System.Object).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Release(@_component, @_delay);

            return __ret;
        }

        static StackObject* ReleaseAll_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            SetXRMODEnableMark();
            
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @_delay = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GameObject @_prefab = (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.ReleaseAll(@_prefab, @_delay);

            return __ret;
        }

        static StackObject* ReleaseAll_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            SetXRMODEnableMark();
            
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @_delay = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.ReleaseAll(@_name, @_delay);

            return __ret;
        }

        static StackObject* Register_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            SetXRMODEnableMark();
            
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @_container = (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GameObject @_prefab = (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Register(@_prefab, @_container);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Register_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            SetXRMODEnableMark();
            
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @_container = (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GameObject @_prefab = (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Register(@_prefab, @_name, @_container);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Unregister_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            SetXRMODEnableMark();
            
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @_prefab = (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Unregister(@_prefab);

            return __ret;
        }

        static StackObject* Unregister_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            SetXRMODEnableMark();
            
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Unregister(@_name);

            return __ret;
        }

        static StackObject* Fill_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            SetXRMODEnableMark();
            
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @_amount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GameObject @_prefab = (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Fill(@_prefab, @_amount);

            return __ret;
        }

        static StackObject* Fill_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            SetXRMODEnableMark();
            
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @_amount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Fill(@_name, @_amount);

            return __ret;
        }

        static StackObject* Fill_19_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @_parent = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @_amount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.GameObject @_prefab = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Fill(@_prefab, @_amount, @_parent);

            return __ret;
        }
        
        static StackObject* Remove_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            SetXRMODEnableMark();
            
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @_destroy = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell @_cell =
                (Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell)
                typeof(Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.PoolCell).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Remove(@_cell, @_destroy);

            return __ret;
        }

        static StackObject* Remove_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            SetXRMODEnableMark();
            
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @_destroy = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GameObject @_gameObject = (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Remove(@_gameObject, @_destroy);

            return __ret;
        }

        static StackObject* Remove_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            SetXRMODEnableMark();
            
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @_destroy = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform @_transform = (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Remove(@_transform, @_destroy);

            return __ret;
        }

        static StackObject* Remove_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            SetXRMODEnableMark();
            
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @_destroy = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Object @_component = (System.Object) typeof(System.Object).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.Remove(@_component, @_destroy);

            return __ret;
        }

        static StackObject* DestroyAll_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            SetXRMODEnableMark();
            
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @_prefab = (UnityEngine.GameObject) typeof(UnityEngine.GameObject).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.DestroyAll(@_prefab);

            return __ret;
        }

        static StackObject* DestroyAll_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            SetXRMODEnableMark();
            
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.DestroyAll(@_name);

            return __ret;
        }

        static StackObject* DestroyAll_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            SetXRMODEnableMark();
            
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            Phantom.XRMOD.XRMODUtilites.Runtime.UniPool.UniPool.DestroyAll();

            return __ret;
        }
    }
}
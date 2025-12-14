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
    unsafe class Unity_AI_Navigation_NavMeshLink_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Unity.AI.Navigation.NavMeshLink);
            args = new Type[] { };
            method = type.GetMethod("get_agentTypeID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_agentTypeID_0);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("set_agentTypeID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_agentTypeID_1);
            args = new Type[] { };
            method = type.GetMethod("get_startPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_startPoint_2);
            args = new Type[] {typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_startPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_startPoint_3);
            args = new Type[] { };
            method = type.GetMethod("get_endPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_endPoint_4);
            args = new Type[] {typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_endPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_endPoint_5);
            args = new Type[] { };
            method = type.GetMethod("get_width", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_width_6);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_width", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_width_7);
            args = new Type[] { };
            method = type.GetMethod("get_costModifier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_costModifier_8);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("set_costModifier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_costModifier_9);
            args = new Type[] { };
            method = type.GetMethod("get_bidirectional", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_bidirectional_10);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_bidirectional", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_bidirectional_11);
            args = new Type[] { };
            method = type.GetMethod("get_autoUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_autoUpdate_12);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_autoUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_autoUpdate_13);
            args = new Type[] { };
            method = type.GetMethod("get_area", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_area_14);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("set_area", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_area_15);
            args = new Type[] { };
            method = type.GetMethod("UpdateLink", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UpdateLink_16);


            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.AI.Navigation.NavMeshLink());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.AI.Navigation.NavMeshLink[s]);

            args = new Type[] { };
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static StackObject* get_agentTypeID_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshLink instance_of_this_method =
                (Unity.AI.Navigation.NavMeshLink) typeof(Unity.AI.Navigation.NavMeshLink).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.agentTypeID;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_agentTypeID_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshLink instance_of_this_method =
                (Unity.AI.Navigation.NavMeshLink) typeof(Unity.AI.Navigation.NavMeshLink).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.agentTypeID = value;

            return __ret;
        }

        static StackObject* get_startPoint_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshLink instance_of_this_method =
                (Unity.AI.Navigation.NavMeshLink) typeof(Unity.AI.Navigation.NavMeshLink).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.startPoint;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_startPoint_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshLink instance_of_this_method =
                (Unity.AI.Navigation.NavMeshLink) typeof(Unity.AI.Navigation.NavMeshLink).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.startPoint = value;

            return __ret;
        }

        static StackObject* get_endPoint_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshLink instance_of_this_method =
                (Unity.AI.Navigation.NavMeshLink) typeof(Unity.AI.Navigation.NavMeshLink).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.endPoint;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_endPoint_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3) typeof(UnityEngine.Vector3).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshLink instance_of_this_method =
                (Unity.AI.Navigation.NavMeshLink) typeof(Unity.AI.Navigation.NavMeshLink).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.endPoint = value;

            return __ret;
        }

        static StackObject* get_width_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshLink instance_of_this_method =
                (Unity.AI.Navigation.NavMeshLink) typeof(Unity.AI.Navigation.NavMeshLink).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.width;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_width_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshLink instance_of_this_method =
                (Unity.AI.Navigation.NavMeshLink) typeof(Unity.AI.Navigation.NavMeshLink).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.width = value;

            return __ret;
        }

        static StackObject* get_costModifier_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshLink instance_of_this_method =
                (Unity.AI.Navigation.NavMeshLink) typeof(Unity.AI.Navigation.NavMeshLink).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.costModifier;

#if UNITY_6000_0_OR_NEWER
            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
#else
            __ret->ObjectType = ObjectTypes.Integer;
             __ret->Value = result_of_this_method;
#endif


            return __ret + 1;
        }

        static StackObject* set_costModifier_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshLink instance_of_this_method =
                (Unity.AI.Navigation.NavMeshLink) typeof(Unity.AI.Navigation.NavMeshLink).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.costModifier = value;

            return __ret;
        }

        static StackObject* get_bidirectional_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshLink instance_of_this_method =
                (Unity.AI.Navigation.NavMeshLink) typeof(Unity.AI.Navigation.NavMeshLink).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.bidirectional;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_bidirectional_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshLink instance_of_this_method =
                (Unity.AI.Navigation.NavMeshLink) typeof(Unity.AI.Navigation.NavMeshLink).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.bidirectional = value;

            return __ret;
        }

        static StackObject* get_autoUpdate_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshLink instance_of_this_method =
                (Unity.AI.Navigation.NavMeshLink) typeof(Unity.AI.Navigation.NavMeshLink).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.autoUpdate;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_autoUpdate_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshLink instance_of_this_method =
                (Unity.AI.Navigation.NavMeshLink) typeof(Unity.AI.Navigation.NavMeshLink).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.autoUpdate = value;

            return __ret;
        }

        static StackObject* get_area_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshLink instance_of_this_method =
                (Unity.AI.Navigation.NavMeshLink) typeof(Unity.AI.Navigation.NavMeshLink).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.area;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_area_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.AI.Navigation.NavMeshLink instance_of_this_method =
                (Unity.AI.Navigation.NavMeshLink) typeof(Unity.AI.Navigation.NavMeshLink).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.area = value;

            return __ret;
        }

        static StackObject* UpdateLink_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.AI.Navigation.NavMeshLink instance_of_this_method =
                (Unity.AI.Navigation.NavMeshLink) typeof(Unity.AI.Navigation.NavMeshLink).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UpdateLink();

            return __ret;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Unity.AI.Navigation.NavMeshLink();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}
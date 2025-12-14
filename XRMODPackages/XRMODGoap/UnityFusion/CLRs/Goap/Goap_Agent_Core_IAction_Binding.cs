using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
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
    unsafe class Goap_Agent_Core_IAction_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Goap.Agent.Core.IAction);
            args = new Type[] {typeof(Goap.Agent.Core.IMonoAgent)};
            method = type.GetMethod("GetMoveMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetMoveMode_0);
            args = new Type[] { };
            method = type.GetMethod("GetStoppingDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetStoppingDistance_1);
            args = new Type[]
            {
                typeof(Goap.Agent.Core.IMonoAgent), typeof(System.Single), typeof(Goap.Agent.Core.IActionData),
                typeof(Goap.Agent.Core.IComponentReference)
            };
            method = type.GetMethod("IsInRange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsInRange_2);
            args = new Type[] { };
            method = type.GetMethod("GetData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetData_3);
            args = new Type[] { };
            method = type.GetMethod("Created", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Created_4);
            args = new Type[] {typeof(Goap.Agent.Core.IActionReceiver), typeof(Goap.Agent.Core.IActionData)};
            method = type.GetMethod("IsValid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsValid_5);
            args = new Type[] {typeof(Goap.Agent.Core.IMonoAgent), typeof(Goap.Agent.Core.IActionData)};
            method = type.GetMethod("Start", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Start_6);
            args = new Type[] {typeof(Goap.Agent.Core.IMonoAgent), typeof(Goap.Agent.Core.IActionData)};
            method = type.GetMethod("BeforePerform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BeforePerform_7);
            args = new Type[]
            {
                typeof(Goap.Agent.Core.IMonoAgent), typeof(Goap.Agent.Core.IActionData),
                typeof(Goap.Agent.Core.IActionContext)
            };
            method = type.GetMethod("Perform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Perform_8);
            args = new Type[] {typeof(Goap.Agent.Core.IMonoAgent), typeof(Goap.Agent.Core.IActionData)};
            method = type.GetMethod("Stop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Stop_9);
            args = new Type[] {typeof(Goap.Agent.Core.IMonoAgent), typeof(Goap.Agent.Core.IActionData)};
            method = type.GetMethod("Complete", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Complete_10);
            args = new Type[] {typeof(Goap.Agent.Core.IActionReceiver), typeof(System.Boolean)};
            method = type.GetMethod("IsExecutable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsExecutable_11);


            app.RegisterCLRCreateArrayInstance(type, s => new Goap.Agent.Core.IAction[s]);
        }


        static StackObject* GetMoveMode_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.IMonoAgent @agent =
                (Goap.Agent.Core.IMonoAgent) typeof(Goap.Agent.Core.IMonoAgent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Agent.Core.IAction instance_of_this_method =
                (Goap.Agent.Core.IAction) typeof(Goap.Agent.Core.IAction).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetMoveMode(@agent);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetStoppingDistance_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.IAction instance_of_this_method =
                (Goap.Agent.Core.IAction) typeof(Goap.Agent.Core.IAction).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetStoppingDistance();

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* IsInRange_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.IComponentReference @references =
                (Goap.Agent.Core.IComponentReference) typeof(Goap.Agent.Core.IComponentReference).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Agent.Core.IActionData @data =
                (Goap.Agent.Core.IActionData) typeof(Goap.Agent.Core.IActionData).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @distance = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Goap.Agent.Core.IMonoAgent @agent =
                (Goap.Agent.Core.IMonoAgent) typeof(Goap.Agent.Core.IMonoAgent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            Goap.Agent.Core.IAction instance_of_this_method =
                (Goap.Agent.Core.IAction) typeof(Goap.Agent.Core.IAction).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsInRange(@agent, @distance, @data, @references);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetData_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            Debug.Log("GetData_3");
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.IAction instance_of_this_method =
                (Goap.Agent.Core.IAction) typeof(Goap.Agent.Core.IAction).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetData();

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Created_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.IAction instance_of_this_method =
                (Goap.Agent.Core.IAction) typeof(Goap.Agent.Core.IAction).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Created();

            return __ret;
        }

        static StackObject* IsValid_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.IActionData @data =
                (Goap.Agent.Core.IActionData) typeof(Goap.Agent.Core.IActionData).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Agent.Core.IActionReceiver @agent =
                (Goap.Agent.Core.IActionReceiver) typeof(Goap.Agent.Core.IActionReceiver).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Goap.Agent.Core.IAction instance_of_this_method =
                (Goap.Agent.Core.IAction) typeof(Goap.Agent.Core.IAction).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsValid(@agent, @data);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Start_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.IActionData @data =
                (Goap.Agent.Core.IActionData) typeof(Goap.Agent.Core.IActionData).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Agent.Core.IMonoAgent @agent =
                (Goap.Agent.Core.IMonoAgent) typeof(Goap.Agent.Core.IMonoAgent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Goap.Agent.Core.IAction instance_of_this_method =
                (Goap.Agent.Core.IAction) typeof(Goap.Agent.Core.IAction).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Start(@agent, @data);

            return __ret;
        }

        static StackObject* BeforePerform_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.IActionData @data =
                (Goap.Agent.Core.IActionData) typeof(Goap.Agent.Core.IActionData).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Agent.Core.IMonoAgent @agent =
                (Goap.Agent.Core.IMonoAgent) typeof(Goap.Agent.Core.IMonoAgent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Goap.Agent.Core.IAction instance_of_this_method =
                (Goap.Agent.Core.IAction) typeof(Goap.Agent.Core.IAction).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.BeforePerform(@agent, @data);

            return __ret;
        }

        static StackObject* Perform_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.IActionContext @context =
                (Goap.Agent.Core.IActionContext) typeof(Goap.Agent.Core.IActionContext).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Agent.Core.IActionData @data =
                (Goap.Agent.Core.IActionData) typeof(Goap.Agent.Core.IActionData).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Goap.Agent.Core.IMonoAgent @agent =
                (Goap.Agent.Core.IMonoAgent) typeof(Goap.Agent.Core.IMonoAgent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Goap.Agent.Core.IAction instance_of_this_method =
                (Goap.Agent.Core.IAction) typeof(Goap.Agent.Core.IAction).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Perform(@agent, @data, @context);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Stop_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.IActionData @data =
                (Goap.Agent.Core.IActionData) typeof(Goap.Agent.Core.IActionData).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Agent.Core.IMonoAgent @agent =
                (Goap.Agent.Core.IMonoAgent) typeof(Goap.Agent.Core.IMonoAgent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Goap.Agent.Core.IAction instance_of_this_method =
                (Goap.Agent.Core.IAction) typeof(Goap.Agent.Core.IAction).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Stop(@agent, @data);

            return __ret;
        }

        static StackObject* Complete_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.IActionData @data =
                (Goap.Agent.Core.IActionData) typeof(Goap.Agent.Core.IActionData).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Agent.Core.IMonoAgent @agent =
                (Goap.Agent.Core.IMonoAgent) typeof(Goap.Agent.Core.IMonoAgent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Goap.Agent.Core.IAction instance_of_this_method =
                (Goap.Agent.Core.IAction) typeof(Goap.Agent.Core.IAction).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Complete(@agent, @data);

            return __ret;
        }

        static StackObject* IsExecutable_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @conditionsMet = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Agent.Core.IActionReceiver @agent =
                (Goap.Agent.Core.IActionReceiver) typeof(Goap.Agent.Core.IActionReceiver).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Goap.Agent.Core.IAction instance_of_this_method =
                (Goap.Agent.Core.IAction) typeof(Goap.Agent.Core.IAction).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsExecutable(@agent, @conditionsMet);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using Goap.Core;
using Goap.Runtime;
using UnityEngine;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.CLR.Method;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using UnityFusion.Runtime.Stack;
using UnityFusion.Reflection;
using UnityFusion.CLR.Utils;
using UnityFusion.CLRBinding.Adapter;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif
namespace UnityFusion.Runtime.Generated
{
    unsafe class Goap_Runtime_GoapActionProvider_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Goap.Runtime.GoapActionProvider);
            MethodInfo[] methods = type.GetMethods(flag).Where(t => !t.IsGenericMethod).ToArray();
            args = new Type[] { };
            method = type.GetMethod("get_LoggerConfig", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_LoggerConfig_0);
            args = new Type[] {typeof(Goap.Agent.Runtime.LoggerConfig)};
            method = type.GetMethod("set_LoggerConfig", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_LoggerConfig_1);
            args = new Type[] { };
            method = type.GetMethod("get_AgentTypeBehaviour", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_AgentTypeBehaviour_2);
            args = new Type[] {typeof(Goap.Runtime.AgentTypeBehaviour)};
            method = type.GetMethod("set_AgentTypeBehaviour", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_AgentTypeBehaviour_3);
            args = new Type[] { };
            method = type.GetMethod("get_DistanceMultiplier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_DistanceMultiplier_4);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_DistanceMultiplier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_DistanceMultiplier_5);
            args = new Type[] { };
            method = type.GetMethod("get_AgentType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_AgentType_6);
            args = new Type[] {typeof(Goap.Core.IAgentType)};
            method = type.GetMethod("set_AgentType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_AgentType_7);
            args = new Type[] { };
            method = type.GetMethod("get_CurrentPlan", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_CurrentPlan_8);
            args = new Type[] { };
            method = type.GetMethod("get_GoalRequest", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GoalRequest_9);
            args = new Type[] { };
            method = type.GetMethod("get_WorldData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_WorldData_10);
            args = new Type[] { };
            method = type.GetMethod("get_Events", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Events_11);
            args = new Type[] { };
            method = type.GetMethod("get_Logger", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Logger_12);
            args = new Type[] { };
            method = type.GetMethod("get_Position", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Position_13);
            args = new Type[] {typeof(System.Type), typeof(System.Boolean)};
            method = type.GetMethod("RequestGoal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RequestGoal_14);
            args = new Type[] {typeof(Goap.Core.IGoal), typeof(System.Boolean)};
            method = type.GetMethod("RequestGoal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RequestGoal_15);
            args = new Type[] {typeof(Goap.Core.IGoalRequest), typeof(System.Boolean)};
            method = type.GetMethod("RequestGoal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RequestGoal_16);
            args = new Type[] {typeof(Goap.Core.IGoalResult)};
            method = type.GetMethod("SetAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAction_17);
            args = new Type[] { };
            method = type.GetMethod("get_Receiver", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Receiver_18);
            args = new Type[] {typeof(Goap.Agent.Core.IActionReceiver)};
            method = type.GetMethod("set_Receiver", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Receiver_19);
            args = new Type[] { };
            method = type.GetMethod("ResolveAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResolveAction_20);
            args = new Type[] { };
            method = type.GetMethod("ClearGoal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearGoal_21);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("SetDistanceMultiplier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDistanceMultiplier_22);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("SetDistanceMultiplierSpeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDistanceMultiplierSpeed_23);
            args = new Type[] { };
            method = methods.Where(t => t.Name.Equals("GetActions") && t.CheckMethodParams(args)).Single();
            app.RegisterCLRMethodRedirection(method, GetActions_24);


            Dictionary<string, List<MethodInfo>> genericMethods = new Dictionary<string, List<MethodInfo>>();
            List<MethodInfo> lst = null;
            foreach (var m in type.GetMethods())
            {
                if (m.IsGenericMethodDefinition)
                {
                    if (!genericMethods.TryGetValue(m.Name, out lst))
                    {
                        lst = new List<MethodInfo>();
                        genericMethods[m.Name] = lst;
                    }

                    lst.Add(m);
                }
            }


            if (genericMethods.TryGetValue("RequestGoal", out lst))
            {
                var tmp_Args1 = new Type[] {typeof(GoalBaseAdapter.Adapter)};
                var tmp_Args2 = new Type[] {typeof(GoalBaseAdapter.Adapter), typeof(GoalBaseAdapter.Adapter)};
                var tmp_Args3 = new Type[]
                    {typeof(GoalBaseAdapter.Adapter), typeof(GoalBaseAdapter.Adapter), typeof(GoalBaseAdapter.Adapter)};
                var tmp_Args4 = new Type[]
                {
                    typeof(GoalBaseAdapter.Adapter), typeof(GoalBaseAdapter.Adapter), typeof(GoalBaseAdapter.Adapter),
                    typeof(GoalBaseAdapter.Adapter)
                };

                var tmp_Args5 = new Type[]
                {
                    typeof(GoalBaseAdapter.Adapter), typeof(GoalBaseAdapter.Adapter), typeof(GoalBaseAdapter.Adapter),
                    typeof(GoalBaseAdapter.Adapter), typeof(GoalBaseAdapter.Adapter)
                };

                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(tmp_Args1, typeof(void), typeof(System.Boolean)))
                    {
                        method = m.MakeGenericMethod(tmp_Args1);
                        app.RegisterCLRMethodRedirection(method, RequestGoal_1);
                    }

                    if (m.MatchGenericParameters(tmp_Args2, typeof(void), typeof(System.Boolean)))
                    {
                        method = m.MakeGenericMethod(tmp_Args2);
                        app.RegisterCLRMethodRedirection(method, RequestGoal_2);
                    }


                    if (m.MatchGenericParameters(tmp_Args3, typeof(void), typeof(System.Boolean)))
                    {
                        method = m.MakeGenericMethod(tmp_Args3);
                        app.RegisterCLRMethodRedirection(method, RequestGoal_3);
                    }


                    if (m.MatchGenericParameters(tmp_Args4, typeof(void), typeof(System.Boolean)))
                    {
                        method = m.MakeGenericMethod(tmp_Args4);
                        app.RegisterCLRMethodRedirection(method, RequestGoal_4);
                    }

                    if (m.MatchGenericParameters(tmp_Args5, typeof(void), typeof(System.Boolean)))
                    {
                        method = m.MakeGenericMethod(tmp_Args5);
                        app.RegisterCLRMethodRedirection(method, RequestGoal_5);
                    }
                }
            }

            args = new Type[] {typeof(IGoapActionAdapter.Adapter)};
            if (genericMethods.TryGetValue("GetActions", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(List<IGoapActionAdapter.Adapter>),
                            typeof(System.Boolean)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, GetActions_24);

                        break;
                    }
                }
            }
        }

        static StackObject* get_LoggerConfig_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LoggerConfig;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_LoggerConfig_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Runtime.LoggerConfig @value =
                (Goap.Agent.Runtime.LoggerConfig) typeof(Goap.Agent.Runtime.LoggerConfig).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.LoggerConfig = value;

            return __ret;
        }

        static StackObject* get_AgentTypeBehaviour_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AgentTypeBehaviour;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_AgentTypeBehaviour_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.AgentTypeBehaviour @value =
                (Goap.Runtime.AgentTypeBehaviour) typeof(Goap.Runtime.AgentTypeBehaviour).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AgentTypeBehaviour = value;

            return __ret;
        }

        static StackObject* get_DistanceMultiplier_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DistanceMultiplier;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_DistanceMultiplier_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DistanceMultiplier = value;

            return __ret;
        }

        static StackObject* get_AgentType_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AgentType;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_AgentType_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Core.IAgentType @value = (Goap.Core.IAgentType) typeof(Goap.Core.IAgentType).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AgentType = value;

            return __ret;
        }

        static StackObject* get_CurrentPlan_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CurrentPlan;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_GoalRequest_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GoalRequest;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_WorldData_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.WorldData;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Events_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Events;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Logger_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Logger;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Position_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Position;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RequestGoal_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @_resolve = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Type @_goalType = (System.Type) typeof(System.Type).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RequestGoal(@_goalType, @_resolve);

            return __ret;
        }

        static StackObject* RequestGoal_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @resolve = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Core.IGoal @goal = (Goap.Core.IGoal) typeof(Goap.Core.IGoal).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RequestGoal(@goal, @resolve);

            return __ret;
        }

        static StackObject* RequestGoal_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @resolve = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Core.IGoalRequest @request = (Goap.Core.IGoalRequest) typeof(Goap.Core.IGoalRequest).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RequestGoal(@request, @resolve);

            return __ret;
        }

        static StackObject* SetAction_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Core.IGoalResult @result = (Goap.Core.IGoalResult) typeof(Goap.Core.IGoalResult).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetAction(@result);

            return __ret;
        }

        static StackObject* get_Receiver_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Receiver;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_Receiver_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Agent.Core.IActionReceiver @value =
                (Goap.Agent.Core.IActionReceiver) typeof(Goap.Agent.Core.IActionReceiver).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Receiver = value;

            return __ret;
        }

        static StackObject* ResolveAction_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ResolveAction();

            return __ret;
        }

        static StackObject* ClearGoal_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClearGoal();

            return __ret;
        }

        static StackObject* SetDistanceMultiplier_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @multiplier = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetDistanceMultiplier(@multiplier);

            return __ret;
        }

        static StackObject* SetDistanceMultiplierSpeed_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @speed = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetDistanceMultiplierSpeed(@speed);

            return __ret;
        }

        static StackObject* GetActions_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetActions();

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static StackObject* RequestGoal_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @resolve = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var tmp_GenericType = __method.GenericArguments.First();

            if (tmp_GenericType is CLRType)
            {
                instance_of_this_method.RequestGoal(tmp_GenericType.TypeForCLR, @resolve);
            }
            else
            {
                instance_of_this_method.RequestGoal(tmp_GenericType.ReflectionType, @resolve);
            }


            return __ret;
        }

        static StackObject* RequestGoal_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @resolve = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var tmp_FirstGenericType = __method.GenericArguments[0];
            var tmp_SecondGenericType = __method.GenericArguments[1];
            Type tmp_Goal1, tmp_Goal2;

            if (tmp_FirstGenericType is CLRType tmp_Goal1ClrType)
            {
                tmp_Goal1 = tmp_Goal1ClrType.TypeForCLR;
            }
            else
            {
                tmp_Goal1 = tmp_FirstGenericType.ReflectionType;
            }

            if (tmp_SecondGenericType is CLRType tmp_Goal2ClrType)
            {
                tmp_Goal2 = tmp_Goal2ClrType.TypeForCLR;
            }
            else
            {
                tmp_Goal2 = tmp_SecondGenericType.ReflectionType;
            }

            instance_of_this_method.RequestGoal(tmp_Goal1, tmp_Goal2, @resolve);

            return __ret;
        }

        static StackObject* RequestGoal_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @resolve = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var tmp_FirstGenericType = __method.GenericArguments[0];
            var tmp_SecondGenericType = __method.GenericArguments[1];
            var tmp_ThirdGenericType = __method.GenericArguments[2];

            Type tmp_Goal1, tmp_Goal2, tmp_Goal3;

            if (tmp_FirstGenericType is CLRType tmp_Goal1ClrType)
            {
                tmp_Goal1 = tmp_Goal1ClrType.TypeForCLR;
            }
            else
            {
                tmp_Goal1 = tmp_FirstGenericType.ReflectionType;
            }

            if (tmp_SecondGenericType is CLRType tmp_Goal2ClrType)
            {
                tmp_Goal2 = tmp_Goal2ClrType.TypeForCLR;
            }
            else
            {
                tmp_Goal2 = tmp_SecondGenericType.ReflectionType;
            }

            if (tmp_ThirdGenericType is CLRType tmp_Goal3ClrType)
            {
                tmp_Goal3 = tmp_Goal3ClrType.TypeForCLR;
            }
            else
            {
                tmp_Goal3 = tmp_ThirdGenericType.ReflectionType;
            }

            instance_of_this_method.RequestGoal(tmp_Goal1, tmp_Goal2, tmp_Goal3, @resolve);


            return __ret;
        }

        static StackObject* RequestGoal_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @resolve = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var tmp_FirstGenericType = __method.GenericArguments[0];
            var tmp_SecondGenericType = __method.GenericArguments[1];
            var tmp_ThirdGenericType = __method.GenericArguments[2];
            var tmp_FourthGenericType = __method.GenericArguments[3];

            Type tmp_Goal1, tmp_Goal2, tmp_Goal3, tmp_Goal4;

            if (tmp_FirstGenericType is CLRType tmp_Goal1ClrType)
            {
                tmp_Goal1 = tmp_Goal1ClrType.TypeForCLR;
            }
            else
            {
                tmp_Goal1 = tmp_FirstGenericType.ReflectionType;
            }

            if (tmp_SecondGenericType is CLRType tmp_Goal2ClrType)
            {
                tmp_Goal2 = tmp_Goal2ClrType.TypeForCLR;
            }
            else
            {
                tmp_Goal2 = tmp_SecondGenericType.ReflectionType;
            }

            if (tmp_ThirdGenericType is CLRType tmp_Goal3ClrType)
            {
                tmp_Goal3 = tmp_Goal3ClrType.TypeForCLR;
            }
            else
            {
                tmp_Goal3 = tmp_ThirdGenericType.ReflectionType;
            }

            if (tmp_FourthGenericType is CLRType tmp_Goal4ClrType)
            {
                tmp_Goal4 = tmp_Goal4ClrType.TypeForCLR;
            }
            else
            {
                tmp_Goal4 = tmp_FourthGenericType.ReflectionType;
            }

            instance_of_this_method.RequestGoal(tmp_Goal1, tmp_Goal2, tmp_Goal3, tmp_Goal4, @resolve);


            return __ret;
        }


        static StackObject* RequestGoal_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @resolve = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.GoapActionProvider instance_of_this_method =
                (Goap.Runtime.GoapActionProvider) typeof(Goap.Runtime.GoapActionProvider).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var tmp_FirstGenericType = __method.GenericArguments[0];
            var tmp_SecondGenericType = __method.GenericArguments[1];
            var tmp_ThirdGenericType = __method.GenericArguments[2];
            var tmp_FourthGenericType = __method.GenericArguments[3];
            var tmp_FifthGenericType = __method.GenericArguments[4];

            Type tmp_Goal1, tmp_Goal2, tmp_Goal3, tmp_Goal4, tmp_Goal5;

            if (tmp_FirstGenericType is CLRType tmp_Goal1ClrType)
            {
                tmp_Goal1 = tmp_Goal1ClrType.TypeForCLR;
            }
            else
            {
                tmp_Goal1 = tmp_FirstGenericType.ReflectionType;
            }

            if (tmp_SecondGenericType is CLRType tmp_Goal2ClrType)
            {
                tmp_Goal2 = tmp_Goal2ClrType.TypeForCLR;
            }
            else
            {
                tmp_Goal2 = tmp_SecondGenericType.ReflectionType;
            }

            if (tmp_ThirdGenericType is CLRType tmp_Goal3ClrType)
            {
                tmp_Goal3 = tmp_Goal3ClrType.TypeForCLR;
            }
            else
            {
                tmp_Goal3 = tmp_ThirdGenericType.ReflectionType;
            }

            if (tmp_FourthGenericType is CLRType tmp_Goal4ClrType)
            {
                tmp_Goal4 = tmp_Goal4ClrType.TypeForCLR;
            }
            else
            {
                tmp_Goal4 = tmp_FourthGenericType.ReflectionType;
            }


            if (tmp_FifthGenericType is CLRType tmp_Goal5ClrType)
            {
                tmp_Goal5 = tmp_Goal5ClrType.TypeForCLR;
            }
            else
            {
                tmp_Goal5 = tmp_FifthGenericType.ReflectionType;
            }

            instance_of_this_method.RequestGoal(tmp_Goal1, tmp_Goal2, tmp_Goal3, tmp_Goal4, tmp_Goal5, @resolve);


            return __ret;
        }
    }
}
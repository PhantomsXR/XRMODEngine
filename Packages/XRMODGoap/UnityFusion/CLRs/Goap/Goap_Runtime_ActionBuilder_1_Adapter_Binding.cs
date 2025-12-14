// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.GoapModue.UnityFusion.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

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
    unsafe class Goap_Runtime_ActionBuilder_1_Adapter_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type =
                typeof(Goap.Runtime.ActionBuilder<UnityFusion.CLRBinding.Adapter.GoapActionBaseAdapter.Adapter>);
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

            args = new Type[] {typeof(UnityFusion.CLRBinding.Adapter.WorldKeyBaseAdapter.Adapter)};
            if (genericMethods.TryGetValue("AddEffect", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args,
                            typeof(Goap.Runtime.ActionBuilder<
                                UnityFusion.CLRBinding.Adapter.GoapActionBaseAdapter.Adapter>),
                            typeof(Goap.Core.EffectType)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AddEffect_0);

                        break;
                    }
                }
            }

            args = new Type[] {typeof(UnityFusion.CLRBinding.Adapter.TargetKeyBaseAdapter.Adapter)};
            if (genericMethods.TryGetValue("SetTarget", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args,
                            typeof(Goap.Runtime.ActionBuilder<
                                UnityFusion.CLRBinding.Adapter.GoapActionBaseAdapter.Adapter>)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, SetTarget_1);

                        break;
                    }
                }
            }

            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("SetStoppingDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetStoppingDistance_2);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("SetRequiresTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetRequiresTarget_3);
            args = new Type[] {typeof(UnityFusion.CLRBinding.Adapter.WorldKeyBaseAdapter.Adapter)};
            if (genericMethods.TryGetValue("AddCondition", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args,
                            typeof(Goap.Runtime.ActionBuilder<
                                UnityFusion.CLRBinding.Adapter.GoapActionBaseAdapter.Adapter>),
                            typeof(Goap.Core.Comparison), typeof(System.Int32)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AddCondition_4);

                        break;
                    }
                }
            }
        }


        static StackObject* AddEffect_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Core.EffectType @type = (Goap.Core.EffectType) typeof(Goap.Core.EffectType).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.ActionBuilder instance_of_this_method =
                (Goap.Runtime.ActionBuilder) typeof(Goap.Runtime.ActionBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method =
                instance_of_this_method.AddEffect(__method.GenericArguments.First().ReflectionType, @type);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetTarget_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.ActionBuilder instance_of_this_method =
                (Goap.Runtime.ActionBuilder) typeof(Goap.Runtime.ActionBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                    0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method =
                instance_of_this_method.SetTarget(__method.GenericArguments.First().ReflectionType);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetStoppingDistance_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @inRange = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.ActionBuilder instance_of_this_method =
                (Goap.Runtime.ActionBuilder) typeof(Goap.Runtime.ActionBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SetStoppingDistance(@inRange);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetRequiresTarget_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @requiresTarget = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.ActionBuilder instance_of_this_method =
                (Goap.Runtime.ActionBuilder) typeof(Goap.Runtime.ActionBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                    0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SetRequiresTarget(@requiresTarget);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* AddCondition_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @amount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Core.Comparison @comparison = (Goap.Core.Comparison) typeof(Goap.Core.Comparison).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Goap.Runtime.ActionBuilder instance_of_this_method =
                (Goap.Runtime.ActionBuilder) typeof(Goap.Runtime.ActionBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method =
                instance_of_this_method.AddCondition(__method.GenericArguments.First().ReflectionType, @comparison,
                    @amount);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}
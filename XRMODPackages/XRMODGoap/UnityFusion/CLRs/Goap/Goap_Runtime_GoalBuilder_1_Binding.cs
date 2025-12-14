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
    unsafe class Goap_Runtime_GoalBuilder_1_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Goap.Runtime.GoalBuilder<UnityFusion.CLRBinding.Adapter.GoalBaseAdapter.Adapter>);
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
            if (genericMethods.TryGetValue("AddCondition", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args,
                            typeof(Goap.Runtime.GoalBuilder<UnityFusion.CLRBinding.Adapter.GoalBaseAdapter.Adapter>),
                            typeof(Goap.Core.Comparison), typeof(System.Int32)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AddCondition_0);

                        break;
                    }
                }
            }

            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("SetBaseCost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetBaseCost_1);
        }


        static StackObject* AddCondition_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            Goap.Runtime.GoalBuilder instance_of_this_method =
                (Goap.Runtime.GoalBuilder) typeof(Goap.Runtime.GoalBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method =
                instance_of_this_method.AddCondition(__method.GenericArguments.First().ReflectionType,
                    @comparison, @amount);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetBaseCost_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @baseCost = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.GoalBuilder instance_of_this_method =
                (Goap.Runtime.GoalBuilder) typeof(Goap.Runtime.GoalBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SetBaseCost(@baseCost);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}
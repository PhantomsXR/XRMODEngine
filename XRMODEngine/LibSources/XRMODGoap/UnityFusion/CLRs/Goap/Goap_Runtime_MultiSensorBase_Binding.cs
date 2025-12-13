using System;
using System.Collections.Generic;
using System.Linq;
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
using UnityFusion.CLRBinding.Adapter;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif
namespace UnityFusion.Runtime.Generated
{
    unsafe class Goap_Runtime_MultiSensorBase_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            MethodBase method;
            Type[] args;
            Type type = typeof(Goap.Runtime.MultiSensorBase);
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

            args = new Type[] {typeof(TargetKeyBaseAdapter.Adapter)};
            if (genericMethods.TryGetValue("AddLocalTargetSensor", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(System.Func<Goap.Agent.Core.IActionReceiver,
                                Goap.Agent.Core.IComponentReference,
                                Goap.Agent.Core.ITarget, Goap.Agent.Core.ITarget>), typeof(Goap.Core.ISensorTimer)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AddLocalTargetSensor_0);

                        break;
                    }
                }
            }

            args = new Type[] {typeof(UnityFusion.CLRBinding.Adapter.WorldKeyBaseAdapter.Adapter)};
            if (genericMethods.TryGetValue("AddLocalWorldSensor", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(System.Func<Goap.Agent.Core.IActionReceiver,
                                Goap.Agent.Core.IComponentReference,
                                Goap.Core.SenseValue>), typeof(Goap.Core.ISensorTimer)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AddLocalWorldSensor_1);

                        break;
                    }
                }
            }

            args = new Type[] {typeof(UnityFusion.CLRBinding.Adapter.WorldKeyBaseAdapter.Adapter)};
            if (genericMethods.TryGetValue("AddGlobalWorldSensor", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void), typeof(System.Func<Goap.Core.SenseValue>),
                            typeof(Goap.Core.ISensorTimer)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AddGlobalWorldSensor_2);

                        break;
                    }
                }
            }

            args = new Type[] {typeof(UnityFusion.CLRBinding.Adapter.ITargetAdapter.Adapter)};
            if (genericMethods.TryGetValue("AddGlobalTargetSensor", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(ITargetAdapter.Adapter),
                            typeof(Func<ITargetAdapter.Adapter, ITargetAdapter.Adapter>),
                            typeof(Goap.Core.ISensorTimer)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AddGlobalTargetSensor_3);

                        break;
                    }
                }
            }
        }


        static StackObject* AddLocalTargetSensor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Core.ISensorTimer @timer = (Goap.Core.ISensorTimer) typeof(Goap.Core.ISensorTimer).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Func<Goap.Agent.Core.IActionReceiver, Goap.Agent.Core.IComponentReference, Goap.Agent.Core.ITarget,
                Goap.Agent.Core.ITarget> @sense =
                (System.Func<Goap.Agent.Core.IActionReceiver, Goap.Agent.Core.IComponentReference,
                    Goap.Agent.Core.ITarget, Goap.Agent.Core.ITarget>)
                typeof(System.Func<Goap.Agent.Core.IActionReceiver, Goap.Agent.Core.IComponentReference,
                    Goap.Agent.Core.ITarget, Goap.Agent.Core.ITarget>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Goap.Runtime.MultiSensorBase instance_of_this_method =
                (Goap.Runtime.MultiSensorBase) typeof(Goap.Runtime.MultiSensorBase).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);
            instance_of_this_method.AddLocalTargetSensor(__method.GenericArguments.First().ReflectionType, @sense,
                @timer);

            return __ret;
        }

        static StackObject* AddLocalWorldSensor_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Core.ISensorTimer @timer = (Goap.Core.ISensorTimer) typeof(Goap.Core.ISensorTimer).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Func<Goap.Agent.Core.IActionReceiver, Goap.Agent.Core.IComponentReference, Goap.Core.SenseValue>
                @sense =
                    (System.Func<Goap.Agent.Core.IActionReceiver, Goap.Agent.Core.IComponentReference,
                        Goap.Core.SenseValue>)
                    typeof(System.Func<Goap.Agent.Core.IActionReceiver, Goap.Agent.Core.IComponentReference,
                            Goap.Core.SenseValue>)
                        .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                            (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Goap.Runtime.MultiSensorBase instance_of_this_method =
                (Goap.Runtime.MultiSensorBase) typeof(Goap.Runtime.MultiSensorBase).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddLocalWorldSensor(__method.GenericArguments.First().ReflectionType, @sense,
                @timer);

            return __ret;
        }

        static StackObject* AddGlobalWorldSensor_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Core.ISensorTimer @timer = (Goap.Core.ISensorTimer) typeof(Goap.Core.ISensorTimer).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Func<Goap.Core.SenseValue> @sense =
                (System.Func<Goap.Core.SenseValue>) typeof(System.Func<Goap.Core.SenseValue>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Goap.Runtime.MultiSensorBase instance_of_this_method =
                (Goap.Runtime.MultiSensorBase) typeof(Goap.Runtime.MultiSensorBase).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddGlobalWorldSensor(__method.GenericArguments.First().ReflectionType, @sense,
                @timer);

            return __ret;
        }

        static StackObject* AddGlobalTargetSensor_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Core.ISensorTimer @timer = (Goap.Core.ISensorTimer) typeof(Goap.Core.ISensorTimer).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Func<Goap.Agent.Core.ITarget, Goap.Agent.Core.ITarget> @sense =
                (System.Func<Goap.Agent.Core.ITarget, Goap.Agent.Core.ITarget>)
                typeof(System.Func<Goap.Agent.Core.ITarget, Goap.Agent.Core.ITarget>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Goap.Runtime.MultiSensorBase instance_of_this_method =
                (Goap.Runtime.MultiSensorBase) typeof(Goap.Runtime.MultiSensorBase).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddGlobalTargetSensor(__method.GenericArguments.First().ReflectionType, @sense,
                @timer);

            return __ret;
        }
    }
}
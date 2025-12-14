using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
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
    unsafe class Goap_Runtime_AgentTypeBuilder_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Goap.Runtime.AgentTypeBuilder);
            args = new Type[] {typeof(System.String)};
            method = type.GetMethod("CreateCapability", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateCapability_0);
            args = new Type[] {typeof(System.String), typeof(System.Action<Goap.Runtime.CapabilityBuilder>)};
            method = type.GetMethod("CreateCapability", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateCapability_1);
            args = new Type[] {typeof(Goap.Runtime.CapabilityFactoryBase)};
            method = type.GetMethod("AddCapability", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddCapability_2);
            args = new Type[] {typeof(Goap.Runtime.MonoCapabilityFactoryBase)};
            method = type.GetMethod("AddCapability", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddCapability_3);
            args = new Type[] {typeof(Goap.Runtime.ScriptableCapabilityFactoryBase)};
            method = type.GetMethod("AddCapability", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddCapability_4);
            args = new Type[] {typeof(Goap.Runtime.CapabilityBuilder)};
            method = type.GetMethod("AddCapability", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddCapability_5);
            args = new Type[] {typeof(Goap.Core.ICapabilityConfig)};
            method = type.GetMethod("AddCapability", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddCapability_6);
            args = new Type[] { };
            method = type.GetMethod("Build", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Build_7);

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

            args = new Type[] {typeof(CapabilityFactoryBaseAdapter.Adapter)};
            if (genericMethods.TryGetValue("AddCapability", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AddCapability_7);

                        break;
                    }
                }
            }

            app.RegisterCLRCreateArrayInstance(type, s => new Goap.Runtime.AgentTypeBuilder[s]);

            args = new Type[] {typeof(System.String)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static StackObject* CreateCapability_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.AgentTypeBuilder instance_of_this_method =
                (Goap.Runtime.AgentTypeBuilder) typeof(Goap.Runtime.AgentTypeBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CreateCapability(@name);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateCapability_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<Goap.Runtime.CapabilityBuilder> @callback =
                (System.Action<Goap.Runtime.CapabilityBuilder>) typeof(System.Action<Goap.Runtime.CapabilityBuilder>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Goap.Runtime.AgentTypeBuilder instance_of_this_method =
                (Goap.Runtime.AgentTypeBuilder) typeof(Goap.Runtime.AgentTypeBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CreateCapability(@name, @callback);

            return __ret;
        }

        static StackObject* AddCapability_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.CapabilityFactoryBase @capabilityFactory =
                (Goap.Runtime.CapabilityFactoryBase) typeof(Goap.Runtime.CapabilityFactoryBase).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.AgentTypeBuilder instance_of_this_method =
                (Goap.Runtime.AgentTypeBuilder) typeof(Goap.Runtime.AgentTypeBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddCapability(@capabilityFactory);

            return __ret;
        }

        static StackObject* AddCapability_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.MonoCapabilityFactoryBase @capabilityFactory =
                (Goap.Runtime.MonoCapabilityFactoryBase) typeof(Goap.Runtime.MonoCapabilityFactoryBase).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.AgentTypeBuilder instance_of_this_method =
                (Goap.Runtime.AgentTypeBuilder) typeof(Goap.Runtime.AgentTypeBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddCapability(@capabilityFactory);

            return __ret;
        }

        static StackObject* AddCapability_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.ScriptableCapabilityFactoryBase @capabilityFactory =
                (Goap.Runtime.ScriptableCapabilityFactoryBase) typeof(Goap.Runtime.ScriptableCapabilityFactoryBase)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.AgentTypeBuilder instance_of_this_method =
                (Goap.Runtime.AgentTypeBuilder) typeof(Goap.Runtime.AgentTypeBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddCapability(@capabilityFactory);

            return __ret;
        }

        static StackObject* AddCapability_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.CapabilityBuilder @capabilityBuilder =
                (Goap.Runtime.CapabilityBuilder) typeof(Goap.Runtime.CapabilityBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.AgentTypeBuilder instance_of_this_method =
                (Goap.Runtime.AgentTypeBuilder) typeof(Goap.Runtime.AgentTypeBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddCapability(@capabilityBuilder);

            return __ret;
        }

        static StackObject* AddCapability_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Core.ICapabilityConfig @capabilityConfig =
                (Goap.Core.ICapabilityConfig) typeof(Goap.Core.ICapabilityConfig).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Goap.Runtime.AgentTypeBuilder instance_of_this_method =
                (Goap.Runtime.AgentTypeBuilder) typeof(Goap.Runtime.AgentTypeBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddCapability(@capabilityConfig);

            return __ret;
        }

        static StackObject* AddCapability_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.AgentTypeBuilder instance_of_this_method =
                (Goap.Runtime.AgentTypeBuilder) typeof(Goap.Runtime.AgentTypeBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var tmp_GenericType = __method.GenericArguments.First().ReflectionType;
            var tmp_CapabilityFactoryBase = __domain.Instantiate(tmp_GenericType.FullName).CLRInstance as CapabilityFactoryBase;
            instance_of_this_method.AddCapability(tmp_CapabilityFactoryBase);
            return __ret;
        }


        static StackObject* Build_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Goap.Runtime.AgentTypeBuilder instance_of_this_method =
                (Goap.Runtime.AgentTypeBuilder) typeof(Goap.Runtime.AgentTypeBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method); 
            var result_of_this_method = instance_of_this_method.Build();

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new Goap.Runtime.AgentTypeBuilder(@name);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}
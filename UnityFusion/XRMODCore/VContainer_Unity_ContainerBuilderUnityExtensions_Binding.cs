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
    unsafe class VContainer_Unity_ContainerBuilderUnityExtensions_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(VContainer.Unity.ContainerBuilderUnityExtensions);
            args = new Type[]
                {typeof(VContainer.IContainerBuilder), typeof(System.Action<VContainer.Unity.EntryPointsBuilder>)};
            method = type.GetMethod("UseEntryPoints", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UseEntryPoints_0);
            args = new Type[]
            {
                typeof(VContainer.IContainerBuilder), typeof(VContainer.Lifetime),
                typeof(System.Action<VContainer.Unity.EntryPointsBuilder>)
            };
            method = type.GetMethod("UseEntryPoints", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UseEntryPoints_1);
            args = new Type[]
                {typeof(VContainer.IContainerBuilder), typeof(System.Action<VContainer.Unity.ComponentsBuilder>)};
            method = type.GetMethod("UseComponents", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UseComponents_2);
            args = new Type[]
            {
                typeof(VContainer.IContainerBuilder), typeof(UnityEngine.Transform),
                typeof(System.Action<VContainer.Unity.ComponentsBuilder>)
            };
            method = type.GetMethod("UseComponents", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UseComponents_3);
            args = new Type[] {typeof(VContainer.IContainerBuilder), typeof(System.Action<System.Exception>)};
            method = type.GetMethod("RegisterEntryPointExceptionHandler", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterEntryPointExceptionHandler_4);
            args = new Type[] {typeof(VContainer.IContainerBuilder), typeof(System.Type)};
            method = type.GetMethod("RegisterComponentInHierarchy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterComponentInHierarchy_5);
            args = new Type[]
            {
                typeof(VContainer.IContainerBuilder), typeof(System.Type), typeof(VContainer.Lifetime),
                typeof(System.String)
            };
            method = type.GetMethod("RegisterComponentOnNewGameObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterComponentOnNewGameObject_6);
            args = new Type[]
            {
                typeof(VContainer.IContainerBuilder), typeof(System.Type), typeof(UnityEngine.Component),
                typeof(VContainer.Lifetime)
            };
            method = type.GetMethod("RegisterComponentInNewPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterComponentInNewPrefab_7);

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

            args = new Type[] {typeof(UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter)};
            if (genericMethods.TryGetValue("RegisterComponent", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(VContainer.RegistrationBuilder),
                            typeof(VContainer.IContainerBuilder),
                            typeof(UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, RegisterComponent_Generic_0);

                        break;
                    }
                }
            }

            args = new Type[] {typeof(UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter)};
            if (genericMethods.TryGetValue("RegisterComponentInHierarchy", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(VContainer.Unity.ComponentRegistrationBuilder),
                            typeof(VContainer.IContainerBuilder)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, RegisterComponentInHierarchy_0);

                        break;
                    }
                }
            }

            args = new Type[] {typeof(UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter)};
            if (genericMethods.TryGetValue("RegisterComponentOnNewGameObject", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(VContainer.Unity.ComponentRegistrationBuilder),
                            typeof(VContainer.IContainerBuilder), typeof(VContainer.Lifetime), typeof(System.String)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, RegisterComponentOnNewGameObject_1);

                        break;
                    }
                }
            }
        }

        static StackObject* RegisterComponent_Generic_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter @component =
                (UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter)
                typeof(UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var tmp_GenericType = __method.GenericArguments[0].ReflectionType;
            var result_of_this_method =
                VContainer.Unity.ContainerBuilderUnityExtensions.RegisterComponent(@builder, @component,
                    tmp_GenericType);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RegisterComponentInHierarchy_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var tmp_GenericType = __method.GenericArguments[0].ReflectionType;

            var result_of_this_method =
                VContainer.Unity.ContainerBuilderUnityExtensions
                    .RegisterComponentInHierarchy(@builder, tmp_GenericType);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static StackObject* RegisterComponentOnNewGameObject_1(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @newGameObjectName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            VContainer.Lifetime @lifetime = (VContainer.Lifetime) typeof(VContainer.Lifetime).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var tmp_GenericType = __method.GenericArguments[0].ReflectionType;

            var result_of_this_method =
                VContainer.Unity.ContainerBuilderUnityExtensions.RegisterComponentOnNewGameObject(@builder,
                    tmp_GenericType, @lifetime, @newGameObjectName);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* UseEntryPoints_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<VContainer.Unity.EntryPointsBuilder> @configuration =
                (System.Action<VContainer.Unity.EntryPointsBuilder>)
                typeof(System.Action<VContainer.Unity.EntryPointsBuilder>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            VContainer.Unity.ContainerBuilderUnityExtensions.UseEntryPoints(@builder, @configuration);

            return __ret;
        }

        static StackObject* UseEntryPoints_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<VContainer.Unity.EntryPointsBuilder> @configuration =
                (System.Action<VContainer.Unity.EntryPointsBuilder>)
                typeof(System.Action<VContainer.Unity.EntryPointsBuilder>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            VContainer.Lifetime @lifetime = (VContainer.Lifetime) typeof(VContainer.Lifetime).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            VContainer.Unity.ContainerBuilderUnityExtensions.UseEntryPoints(@builder, @lifetime, @configuration);

            return __ret;
        }

        static StackObject* UseComponents_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<VContainer.Unity.ComponentsBuilder> @configuration =
                (System.Action<VContainer.Unity.ComponentsBuilder>)
                typeof(System.Action<VContainer.Unity.ComponentsBuilder>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            VContainer.Unity.ContainerBuilderUnityExtensions.UseComponents(@builder, @configuration);

            return __ret;
        }

        static StackObject* UseComponents_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<VContainer.Unity.ComponentsBuilder> @configuration =
                (System.Action<VContainer.Unity.ComponentsBuilder>)
                typeof(System.Action<VContainer.Unity.ComponentsBuilder>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform @root = (UnityEngine.Transform) typeof(UnityEngine.Transform).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            VContainer.Unity.ContainerBuilderUnityExtensions.UseComponents(@builder, @root, @configuration);

            return __ret;
        }

        static StackObject* RegisterEntryPointExceptionHandler_4(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.Exception> @exceptionHandler =
                (System.Action<System.Exception>) typeof(System.Action<System.Exception>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            VContainer.Unity.ContainerBuilderUnityExtensions.RegisterEntryPointExceptionHandler(@builder,
                @exceptionHandler);

            return __ret;
        }

        static StackObject* RegisterComponentInHierarchy_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @type = (System.Type) typeof(System.Type).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                VContainer.Unity.ContainerBuilderUnityExtensions.RegisterComponentInHierarchy(@builder, @type);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RegisterComponentOnNewGameObject_6(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @newGameObjectName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            VContainer.Lifetime @lifetime = (VContainer.Lifetime) typeof(VContainer.Lifetime).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Type @type = (System.Type) typeof(System.Type).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                VContainer.Unity.ContainerBuilderUnityExtensions.RegisterComponentOnNewGameObject(@builder, @type,
                    @lifetime, @newGameObjectName);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RegisterComponentInNewPrefab_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            VContainer.Lifetime @lifetime = (VContainer.Lifetime) typeof(VContainer.Lifetime).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Component @prefab = (UnityEngine.Component) typeof(UnityEngine.Component).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Type @interfaceType = (System.Type) typeof(System.Type).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                VContainer.Unity.ContainerBuilderUnityExtensions.RegisterComponentInNewPrefab(@builder, @interfaceType,
                    @prefab, @lifetime);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}
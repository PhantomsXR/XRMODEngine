using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Assertions;
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
    unsafe class VContainer_ContainerBuilderExtensions_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(VContainer.ContainerBuilderExtensions);
            args = new Type[] {typeof(VContainer.IContainerBuilder), typeof(System.Type), typeof(VContainer.Lifetime)};
            method = type.GetMethod("Register", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Register_0);
            args = new Type[]
            {
                typeof(VContainer.IContainerBuilder), typeof(System.Type), typeof(System.Type),
                typeof(VContainer.Lifetime)
            };
            method = type.GetMethod("Register", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Register_1);
            args = new Type[] {typeof(VContainer.IContainerBuilder), typeof(System.Object), typeof(System.Type)};
            method = type.GetMethod("RegisterInstance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterInstance_2);
            args = new Type[] {typeof(VContainer.IContainerBuilder), typeof(System.Action<VContainer.IObjectResolver>)};
            method = type.GetMethod("RegisterDisposeCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterDisposeCallback_3);


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

            args = new Type[] {typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance)};
            if (genericMethods.TryGetValue("Register", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(VContainer.RegistrationBuilder),
                            typeof(VContainer.IContainerBuilder), typeof(VContainer.Lifetime)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, Register_2_Generic);

                        break;
                    }
                }
            }


            args = new Type[]
            {
                typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance),
                typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance)
            };
            if (genericMethods.TryGetValue("Register", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(VContainer.RegistrationBuilder),
                            typeof(VContainer.IContainerBuilder), typeof(VContainer.Lifetime)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, Register_3);

                        break;
                    }
                }
            }

            args = new Type[]
            {
                typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance),
                typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance),
                typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance)
            };
            if (genericMethods.TryGetValue("Register", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(VContainer.RegistrationBuilder),
                            typeof(VContainer.IContainerBuilder), typeof(VContainer.Lifetime)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, Register_4);

                        break;
                    }
                }
            }

            args = new Type[]
            {
                typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance),
                typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance),
                typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance),
                typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance)
            };
            if (genericMethods.TryGetValue("Register", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(VContainer.RegistrationBuilder),
                            typeof(VContainer.IContainerBuilder), typeof(VContainer.Lifetime)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, Register_5);

                        break;
                    }
                }
            }

            args = new Type[] {typeof(UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter)};
            if (genericMethods.TryGetValue("RegisterInstance", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(VContainer.RegistrationBuilder),
                            typeof(VContainer.IContainerBuilder),
                            typeof(UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, RegisterInstance_1);

                        break;
                    }
                }
            }

            args = new Type[]{typeof(UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter[])};
            if (genericMethods.TryGetValue("RegisterInstance", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(VContainer.RegistrationBuilder), typeof(VContainer.IContainerBuilder), typeof(UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter[])))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, RegisterInstance_6);

                        break;
                    }
                }
            }
            
            args = new Type[]{typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance[])};
            if (genericMethods.TryGetValue("RegisterInstance", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(VContainer.RegistrationBuilder), typeof(VContainer.IContainerBuilder), typeof(UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter[])))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, RegisterInstance_6);

                        break;
                    }
                }
            }
            
            args = new Type[] {typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance)};
            if (genericMethods.TryGetValue("RegisterInstance", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(VContainer.RegistrationBuilder),
                            typeof(VContainer.IContainerBuilder),
                            typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, RegisterInstance_3);

                        break;
                    }
                }
            }

            args = new Type[]
            {
                typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance),
                typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance)
            };
            if (genericMethods.TryGetValue("RegisterInstance", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(VContainer.RegistrationBuilder),
                            typeof(VContainer.IContainerBuilder),
                            typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, RegisterInstance_4);

                        break;
                    }
                }
            }

            args = new Type[]
            {
                typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance),
                typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance),
                typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance)
            };
            if (genericMethods.TryGetValue("RegisterInstance", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(VContainer.RegistrationBuilder),
                            typeof(VContainer.IContainerBuilder),
                            typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, RegisterInstance_5);

                        break;
                    }
                }
            }
        }

        static StackObject* Register_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            VContainer.Lifetime @lifetime = (VContainer.Lifetime) typeof(VContainer.Lifetime).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Type @type = (System.Type) typeof(System.Type).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                    (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = VContainer.ContainerBuilderExtensions.Register(@builder, @type, @lifetime);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Register_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            VContainer.Lifetime @lifetime = (VContainer.Lifetime) typeof(VContainer.Lifetime).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Type @implementationType = (System.Type) typeof(System.Type).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Type @interfaceType = (System.Type) typeof(System.Type).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                    (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                VContainer.ContainerBuilderExtensions.Register(@builder, @interfaceType, @implementationType,
                    @lifetime);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Register_2_Generic(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            VContainer.Lifetime @lifetime = (VContainer.Lifetime) typeof(VContainer.Lifetime).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                    (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var tmp_RegisterType = __method.GenericArguments[0].ReflectionType;
            var result_of_this_method =
                VContainer.ContainerBuilderExtensions.Register(@builder, tmp_RegisterType, @lifetime);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Register_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            VContainer.Lifetime @lifetime = (VContainer.Lifetime) typeof(VContainer.Lifetime).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var tmp_InterfaceType = __method.GenericArguments[0].ReflectionType;
            var tmp_ImplementationType = __method.GenericArguments[1].ReflectionType;

            var result_of_this_method =
                VContainer.ContainerBuilderExtensions.Register(@builder, tmp_InterfaceType, tmp_ImplementationType,
                    @lifetime);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static StackObject* Register_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            VContainer.Lifetime @lifetime = (VContainer.Lifetime) typeof(VContainer.Lifetime).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            Assert.AreEqual(__method.GenericArguments.Length, 3);

            var tmp_InterfaceType1 = __method.GenericArguments[0].ReflectionType;
            var tmp_InterfaceType2 = __method.GenericArguments[1].ReflectionType;
            var tmp_ImplementationType = __method.GenericArguments[2].ReflectionType;

            var result_of_this_method = VContainer.ContainerBuilderExtensions.Register(@builder, tmp_InterfaceType1,
                tmp_InterfaceType2, tmp_ImplementationType, @lifetime);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Register_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            VContainer.Lifetime @lifetime = (VContainer.Lifetime) typeof(VContainer.Lifetime).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            Assert.AreEqual(__method.GenericArguments.Length, 4);

            var tmp_InterfaceType1 = __method.GenericArguments[0].ReflectionType;
            var tmp_InterfaceType2 = __method.GenericArguments[1].ReflectionType;
            var tmp_InterfaceType3 = __method.GenericArguments[2].ReflectionType;
            var tmp_ImplementationType = __method.GenericArguments[3].ReflectionType;

            var result_of_this_method = VContainer.ContainerBuilderExtensions.Register(@builder, tmp_InterfaceType1,
                tmp_InterfaceType2, tmp_InterfaceType3, tmp_ImplementationType, @lifetime);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RegisterInstance_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter @instance =
                (UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter)
                typeof(UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var implementationType = __method.GenericArguments[0].ReflectionType;

            var result_of_this_method =
                VContainer.ContainerBuilderExtensions.RegisterInstance(@builder, @instance, implementationType);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RegisterInstance_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @implementationType = (System.Type) typeof(System.Type).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Object @instance = (System.Object) typeof(System.Object).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                    (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method =
                VContainer.ContainerBuilderExtensions.RegisterInstance(@builder, @instance, @implementationType);

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RegisterInstance_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityFusion.Runtime.Intepreter.ILTypeInstance @instance =
                (UnityFusion.Runtime.Intepreter.ILTypeInstance) typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var tmp_ImptType = __method.GenericArguments[0].ReflectionType;

            var result_of_this_method =
                VContainer.ContainerBuilderExtensions.RegisterInstance(@builder, @instance, tmp_ImptType);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RegisterInstance_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityFusion.Runtime.Intepreter.ILTypeInstance @instance =
                (UnityFusion.Runtime.Intepreter.ILTypeInstance) typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            Assert.AreEqual(__method.GenericArguments.Length, 2);
            var tmp_InterfaceType1 = __method.GenericArguments[0].ReflectionType;
            var tmp_InterfaceType2 = __method.GenericArguments[1].ReflectionType;

            var result_of_this_method =
                VContainer.ContainerBuilderExtensions.RegisterInstance(@builder, @instance, tmp_InterfaceType1)
                    .As(tmp_InterfaceType2);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RegisterInstance_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityFusion.Runtime.Intepreter.ILTypeInstance @instance =
                (UnityFusion.Runtime.Intepreter.ILTypeInstance) typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            Assert.AreEqual(__method.GenericArguments.Length, 3);
            var tmp_InterfaceType1 = __method.GenericArguments[0].ReflectionType;
            var tmp_InterfaceType2 = __method.GenericArguments[1].ReflectionType;
            var tmp_InterfaceType3 = __method.GenericArguments[2].ReflectionType;


            var result_of_this_method = VContainer.ContainerBuilderExtensions
                .RegisterInstance(@builder, @instance, tmp_InterfaceType1)
                .As(tmp_InterfaceType2, tmp_InterfaceType3);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
        
        static StackObject* RegisterInstance_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter[] @instance = (UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter[])typeof(UnityFusion.CLRBinding.Adapter.XRMODBehaviourAdapter.Adapter[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            VContainer.IContainerBuilder @builder = (VContainer.IContainerBuilder)typeof(VContainer.IContainerBuilder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var implementationType = __method.GenericArguments[0].ReflectionType;
            var result_of_this_method = VContainer.ContainerBuilderExtensions.RegisterInstance(@builder, @instance,implementationType);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RegisterDisposeCallback_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<VContainer.IObjectResolver> @callback =
                (System.Action<VContainer.IObjectResolver>) typeof(System.Action<VContainer.IObjectResolver>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            VContainer.IContainerBuilder @builder =
                (VContainer.IContainerBuilder) typeof(VContainer.IContainerBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                    (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);


            VContainer.ContainerBuilderExtensions.RegisterDisposeCallback(@builder, @callback);

            return __ret;
        }
    }
}
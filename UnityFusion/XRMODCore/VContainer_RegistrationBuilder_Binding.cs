using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
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
    unsafe class VContainer_RegistrationBuilder_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(VContainer.RegistrationBuilder);
            args = new Type[] {typeof(System.Object)};
            method = type.GetMethod("Keyed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Keyed_0);
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
            if (genericMethods.TryGetValue("As", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(VContainer.RegistrationBuilder)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, As_1);

                        break;
                    }
                }
            }

            args = new Type[] { };
            method = type.GetMethod("AsImplementedInterfaces", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AsImplementedInterfaces_2);
            args = new Type[] { };
            method = type.GetMethod("AsSelf", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AsSelf_3);
            args = new Type[]
            {
                typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance),
                typeof(UnityFusion.Runtime.Intepreter.ILTypeInstance)
            };
            if (genericMethods.TryGetValue("As", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(VContainer.RegistrationBuilder)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, As_4);

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
            if (genericMethods.TryGetValue("As", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(VContainer.RegistrationBuilder)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, As_5);

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
            if (genericMethods.TryGetValue("As", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(VContainer.RegistrationBuilder)))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, As_6);

                        break;
                    }
                }
            }
        }


        static StackObject* Keyed_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object @key = (System.Object) typeof(System.Object).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            VContainer.RegistrationBuilder instance_of_this_method =
                (VContainer.RegistrationBuilder) typeof(VContainer.RegistrationBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Keyed(@key);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* As_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            VContainer.RegistrationBuilder instance_of_this_method =
                (VContainer.RegistrationBuilder) typeof(VContainer.RegistrationBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var tmp_InterfaceType = __method.GenericArguments[0].ReflectionType;

            var result_of_this_method = instance_of_this_method.As(tmp_InterfaceType);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* AsImplementedInterfaces_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            VContainer.RegistrationBuilder instance_of_this_method =
                (VContainer.RegistrationBuilder) typeof(VContainer.RegistrationBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AsImplementedInterfaces();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* AsSelf_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            VContainer.RegistrationBuilder instance_of_this_method =
                (VContainer.RegistrationBuilder) typeof(VContainer.RegistrationBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AsSelf();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* As_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            VContainer.RegistrationBuilder instance_of_this_method =
                (VContainer.RegistrationBuilder) typeof(VContainer.RegistrationBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            Assert.AreEqual(__method.GenericArguments.Length, 2);
            var tmp_InterfaceType1 = __method.GenericArguments[0].ReflectionType;
            var tmp_InterfaceType2 = __method.GenericArguments[1].ReflectionType;
            var result_of_this_method = instance_of_this_method.As(tmp_InterfaceType1, tmp_InterfaceType2);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* As_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            VContainer.RegistrationBuilder instance_of_this_method =
                (VContainer.RegistrationBuilder) typeof(VContainer.RegistrationBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            Assert.AreEqual(__method.GenericArguments.Length, 3);
            var tmp_InterfaceType1 = __method.GenericArguments[0].ReflectionType;
            var tmp_InterfaceType2 = __method.GenericArguments[1].ReflectionType;
            var tmp_InterfaceType3 = __method.GenericArguments[2].ReflectionType;

            var result_of_this_method =
                instance_of_this_method.As(tmp_InterfaceType1, tmp_InterfaceType2, tmp_InterfaceType3);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* As_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            VContainer.RegistrationBuilder instance_of_this_method =
                (VContainer.RegistrationBuilder) typeof(VContainer.RegistrationBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            Assert.AreEqual(__method.GenericArguments.Length, 4);
            var tmp_InterfaceType1 = __method.GenericArguments[0].ReflectionType;
            var tmp_InterfaceType2 = __method.GenericArguments[1].ReflectionType;
            var tmp_InterfaceType3 = __method.GenericArguments[2].ReflectionType;
            var tmp_InterfaceType4 = __method.GenericArguments[3].ReflectionType;


            var result_of_this_method = instance_of_this_method.As(tmp_InterfaceType1, tmp_InterfaceType2,
                tmp_InterfaceType3, tmp_InterfaceType4);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}
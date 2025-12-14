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
    unsafe class System_Runtime_CompilerServices_AsyncTaskMethodBuilder_1_Dictionary_2_String_PhysicsMaterial_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
#if UNITY_6000_0_OR_NEWER
            Type type =
                typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                    System.String, UnityEngine.PhysicsMaterial>>);
#else
            Type type =
                typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                    System.String, UnityEngine.PhysicMaterial>>);
#endif


            args = new Type[] { };
            method = type.GetMethod("Create", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Create_0);
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

            args = new Type[]
            {
                typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
            };
            if (genericMethods.TryGetValue("Start", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.
                                AsyncStateMachineAdaptor).MakeByRefType()))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, Start_1);

                        break;
                    }
                }
            }

            args = new Type[] { };
            method = type.GetMethod("get_Task", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Task_2);


            args = new Type[]
            {
#if UNITY_6000_0_OR_NEWER
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.PhysicsMaterial[]>),
#else
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.PhysicMaterial[]>),
#endif
                typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
            };
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach (var m in lst)
                {
#if UNITY_6000_0_OR_NEWER
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.PhysicsMaterial[]>)
                                .MakeByRefType(),
                            typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.
                                AsyncStateMachineAdaptor).MakeByRefType()))
#else
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.PhysicMaterial[]>)
                                .MakeByRefType(),
                            typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.
                                AsyncStateMachineAdaptor).MakeByRefType()))
#endif


                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_3);

                        break;
                    }
                }
            }

            args = new Type[] {typeof(System.Exception)};
            method = type.GetMethod("SetException", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetException_4);
#if UNITY_6000_0_OR_NEWER
            args = new Type[]
                {typeof(System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial>)};
#else
            args = new Type[]
                {typeof(System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial>)};
#endif


            method = type.GetMethod("SetResult", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetResult_5);
            args = new Type[] {typeof(System.Runtime.CompilerServices.IAsyncStateMachine)};
            method = type.GetMethod("SetStateMachine", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetStateMachine_6);

#if UNITY_6000_0_OR_NEWER
            app.RegisterCLRCreateDefaultInstance(type,
                () => new System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                    System.String, UnityEngine.PhysicsMaterial>>());
#else
            app.RegisterCLRCreateDefaultInstance(type,
                () => new System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                    System.String, UnityEngine.PhysicMaterial>>());
#endif
        }
#if UNITY_6000_0_OR_NEWER
        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain,
            StackObject* ptr_of_this_method, AutoList __mStack,
            ref System.Runtime.CompilerServices.AsyncTaskMethodBuilder<
                    System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial>>
                instance_of_this_method)
#else
        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain,
            StackObject* ptr_of_this_method, AutoList __mStack,
            ref System.Runtime.CompilerServices.AsyncTaskMethodBuilder<
                    System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial>>
                instance_of_this_method)
#endif

        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch (ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                {
                    __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                }
                    break;
                case ObjectTypes.FieldReference:
                {
                    var ___obj = __mStack[ptr_of_this_method->Value];
                    if (___obj is ILTypeInstance)
                    {
                        ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    else
                    {
                        var t = __domain.GetType(___obj.GetType()) as CLRType;
                        t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                    }
                }
                    break;
                case ObjectTypes.StaticFieldReference:
                {
                    var t = __domain.GetType(ptr_of_this_method->Value);
                    if (t is ILType)
                    {
                        ((ILType) t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    else
                    {
                        ((CLRType) t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                    }
                }
                    break;
                case ObjectTypes.ArrayReference:
                {
#if UNITY_6000_0_OR_NEWER
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as System.Runtime.CompilerServices.AsyncTaskMethodBuilder<
                            System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial>>[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
#else
     var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as System.Runtime.CompilerServices.AsyncTaskMethodBuilder<
                            System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial>>[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
#endif
                }
                    break;
            }
        }

        static StackObject* Create_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

#if UNITY_6000_0_OR_NEWER
            var result_of_this_method = System.Runtime.CompilerServices
                .AsyncTaskMethodBuilder<
                    System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial>>.Create();
#else
            var result_of_this_method = System.Runtime.CompilerServices
                .AsyncTaskMethodBuilder<
                    System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial>>.Create();
#endif


            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Start_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor
                @stateMachine =
                    (UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
                    typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.
                        AsyncStateMachineAdaptor).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
#if UNITY_6000_0_OR_NEWER

            object instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                    System.String, UnityEngine.PhysicsMaterial>>)
                typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                    System.String, UnityEngine.PhysicsMaterial>>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            ((System.Runtime.CompilerServices.AsyncTaskMethodBuilder<
                        System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial>>)
                    instance_of_this_method)
                .Start<
                    UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @stateMachine);
#else
            object instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                    System.String, UnityEngine.PhysicMaterial>>)
                typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                    System.String, UnityEngine.PhysicMaterial>>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            ((System.Runtime.CompilerServices.AsyncTaskMethodBuilder<
                        System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial>>)
                    instance_of_this_method)
                .Start<
                    UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @stateMachine);
#endif


            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch (ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                {
                    var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                    object ___obj = @stateMachine;
                    if (___dst->ObjectType >= ObjectTypes.Object)
                    {
                        if (___obj is CrossBindingAdaptorType)
                            ___obj = ((CrossBindingAdaptorType) ___obj).ILInstance;
                        __mStack[___dst->Value] = ___obj;
                    }
                    else
                    {
                        ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                    }
                }
                    break;
                case ObjectTypes.FieldReference:
                {
                    var ___obj = __mStack[ptr_of_this_method->Value];
                    if (___obj is ILTypeInstance)
                    {
                        ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = @stateMachine;
                    }
                    else
                    {
                        var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                        ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @stateMachine);
                    }
                }
                    break;
                case ObjectTypes.StaticFieldReference:
                {
                    var ___type = __domain.GetType(ptr_of_this_method->Value);
                    if (___type is ILType)
                    {
                        ((ILType) ___type).StaticInstance[ptr_of_this_method->ValueLow] = @stateMachine;
                    }
                    else
                    {
                        ((CLRType) ___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @stateMachine);
                    }
                }
                    break;
                case ObjectTypes.ArrayReference:
                {
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as UnityFusion.CLRBinding.Adapter.
                            AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = @stateMachine;
                }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* get_Task_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
#if UNITY_6000_0_OR_NEWER
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<
                    System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial>>
                instance_of_this_method =
                    (System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                        System.String, UnityEngine.PhysicsMaterial>>)
                    typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                        System.String, UnityEngine.PhysicsMaterial>>).CheckCLRTypes(
                        StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 16);
#else
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<
                    System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial>>
                instance_of_this_method =
                    (System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                        System.String, UnityEngine.PhysicMaterial>>)
                    typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                        System.String, UnityEngine.PhysicMaterial>>).CheckCLRTypes(
                        StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 16);
#endif


            var result_of_this_method = instance_of_this_method.Task;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* AwaitUnsafeOnCompleted_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor
                @stateMachine =
                    (UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
                    typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.
                        AsyncStateMachineAdaptor).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
#if UNITY_6000_0_OR_NEWER
            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.PhysicsMaterial[]> @awaiter =
                (System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.PhysicsMaterial[]>)
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.PhysicsMaterial[]>).CheckCLRTypes(
                    __intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<
                    System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial>>
                instance_of_this_method =
                    (System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                        System.String, UnityEngine.PhysicsMaterial>>)
                    typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                        System.String, UnityEngine.PhysicsMaterial>>).CheckCLRTypes(
                        StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method
                .AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.PhysicsMaterial[]>,
                    UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @awaiter, ref @stateMachine);
#else
            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.PhysicMaterial[]> @awaiter =
                (System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.PhysicMaterial[]>)
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.PhysicMaterial[]>).CheckCLRTypes(
                    __intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<
                    System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial>>
                instance_of_this_method =
                    (System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                        System.String, UnityEngine.PhysicMaterial>>)
                    typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                        System.String, UnityEngine.PhysicMaterial>>).CheckCLRTypes(
                        StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method
                .AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.PhysicMaterial[]>,
                    UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @awaiter, ref @stateMachine);
#endif


            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch (ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                {
                    var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                    object ___obj = @stateMachine;
                    if (___dst->ObjectType >= ObjectTypes.Object)
                    {
                        if (___obj is CrossBindingAdaptorType)
                            ___obj = ((CrossBindingAdaptorType) ___obj).ILInstance;
                        __mStack[___dst->Value] = ___obj;
                    }
                    else
                    {
                        ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                    }
                }
                    break;
                case ObjectTypes.FieldReference:
                {
                    var ___obj = __mStack[ptr_of_this_method->Value];
                    if (___obj is ILTypeInstance)
                    {
                        ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = @stateMachine;
                    }
                    else
                    {
                        var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                        ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @stateMachine);
                    }
                }
                    break;
                case ObjectTypes.StaticFieldReference:
                {
                    var ___type = __domain.GetType(ptr_of_this_method->Value);
                    if (___type is ILType)
                    {
                        ((ILType) ___type).StaticInstance[ptr_of_this_method->ValueLow] = @stateMachine;
                    }
                    else
                    {
                        ((CLRType) ___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @stateMachine);
                    }
                }
                    break;
                case ObjectTypes.ArrayReference:
                {
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as UnityFusion.CLRBinding.Adapter.
                            AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = @stateMachine;
                }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch (ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                {
                    var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                    object ___obj = @awaiter;
                    if (___dst->ObjectType >= ObjectTypes.Object)
                    {
                        if (___obj is CrossBindingAdaptorType)
                            ___obj = ((CrossBindingAdaptorType) ___obj).ILInstance;
                        __mStack[___dst->Value] = ___obj;
                    }
                    else
                    {
                        ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                    }
                }
                    break;
                case ObjectTypes.FieldReference:
                {
                    var ___obj = __mStack[ptr_of_this_method->Value];
                    if (___obj is ILTypeInstance)
                    {
                        ((ILTypeInstance) ___obj)[ptr_of_this_method->ValueLow] = @awaiter;
                    }
                    else
                    {
                        var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                        ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @awaiter);
                    }
                }
                    break;
                case ObjectTypes.StaticFieldReference:
                {
                    var ___type = __domain.GetType(ptr_of_this_method->Value);
                    if (___type is ILType)
                    {
                        ((ILType) ___type).StaticInstance[ptr_of_this_method->ValueLow] = @awaiter;
                    }
                    else
                    {
                        ((CLRType) ___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @awaiter);
                    }
                }
                    break;
                case ObjectTypes.ArrayReference:
                {
#if UNITY_6000_0_OR_NEWER
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as
                            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.PhysicsMaterial[]>[];
#else
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as
                            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.PhysicMaterial[]>[];
#endif


                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = @awaiter;
                }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* SetException_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Exception @exception = (System.Exception) typeof(System.Exception).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
#if UNITY_6000_0_OR_NEWER
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<
                    System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial>>
                instance_of_this_method =
                    (System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                        System.String, UnityEngine.PhysicsMaterial>>)
                    typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                        System.String, UnityEngine.PhysicsMaterial>>).CheckCLRTypes(
                        StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 16);
#else
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<
                    System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial>>
                instance_of_this_method =
                    (System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                        System.String, UnityEngine.PhysicMaterial>>)
                    typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                        System.String, UnityEngine.PhysicMaterial>>).CheckCLRTypes(
                        StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 16);
#endif


            instance_of_this_method.SetException(@exception);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* SetResult_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
#if UNITY_6000_0_OR_NEWER
            System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial> @result =
                (System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial>)
                typeof(System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
#else
            System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial> @result =
                (System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial>)
                typeof(System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
#endif


            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
#if UNITY_6000_0_OR_NEWER
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<
                    System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial>>
                instance_of_this_method =
                    (System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                        System.String, UnityEngine.PhysicsMaterial>>)
                    typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                        System.String, UnityEngine.PhysicsMaterial>>).CheckCLRTypes(
                        StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 16);
#else
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<
                    System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial>>
                instance_of_this_method =
                    (System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                        System.String, UnityEngine.PhysicMaterial>>)
                    typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                        System.String, UnityEngine.PhysicMaterial>>).CheckCLRTypes(
                        StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 16);
#endif


            instance_of_this_method.SetResult(@result);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* SetStateMachine_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Runtime.CompilerServices.IAsyncStateMachine @stateMachine =
                (System.Runtime.CompilerServices.IAsyncStateMachine)
                typeof(System.Runtime.CompilerServices.IAsyncStateMachine).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
#if UNITY_6000_0_OR_NEWER
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<
                    System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicsMaterial>>
                instance_of_this_method =
                    (System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                        System.String, UnityEngine.PhysicsMaterial>>)
                    typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                        System.String, UnityEngine.PhysicsMaterial>>).CheckCLRTypes(
                        StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 16);

#else
            System.Runtime.CompilerServices.AsyncTaskMethodBuilder<
                    System.Collections.Generic.Dictionary<System.String, UnityEngine.PhysicMaterial>>
                instance_of_this_method
                    = (System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                        System.String, UnityEngine.PhysicMaterial>>)
                    typeof(System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.Collections.Generic.Dictionary<
                        System.String, UnityEngine.PhysicMaterial>>).CheckCLRTypes(
                        StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 16);

#endif


            instance_of_this_method.SetStateMachine(@stateMachine);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityFusion.CLR.TypeSystem;
using UnityFusion.CLR.Method;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using UnityFusion.Runtime.Stack;
using UnityFusion.CLR.Utils;
#if DEBUG && !DISABLE_UNITYFUSION_DEBUG
using AutoList = System.Collections.Generic.List<object>;

#else
using AutoList = UnityFusion.Other.UncheckedList<object>;
#endif
namespace UnityFusion.Runtime.Generated
{
    unsafe class System_Runtime_CompilerServices_AsyncVoidMethodBuilder_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder);
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

            args = new Type[]
            {
                typeof(System.Runtime.CompilerServices.TaskAwaiter),
                typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
            };
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(System.Runtime.CompilerServices.TaskAwaiter).MakeByRefType(),
                            typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.
                                AsyncStateMachineAdaptor).MakeByRefType()))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_2);

                        break;
                    }
                }
            }

            args = new Type[] {typeof(System.Exception)};
            method = type.GetMethod("SetException", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetException_3);
            args = new Type[] { };
            method = type.GetMethod("SetResult", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetResult_4);
            args = new Type[]
            {
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.ScriptableObject[]>),
                typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
            };
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.ScriptableObject[]>)
                                .MakeByRefType(),
                            typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.
                                AsyncStateMachineAdaptor).MakeByRefType()))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_5);

                        break;
                    }
                }
            }

            args = new Type[]
            {
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AudioClip[]>),
                typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
            };
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AudioClip[]>)
                                .MakeByRefType(),
                            typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.
                                AsyncStateMachineAdaptor).MakeByRefType()))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_6);

                        break;
                    }
                }
            }

            args = new Type[]
            {
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Sprite[]>),
                typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
            };
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Sprite[]>).MakeByRefType(),
                            typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.
                                AsyncStateMachineAdaptor).MakeByRefType()))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_7);

                        break;
                    }
                }
            }

            args = new Type[]
            {
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Material[]>),
                typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
            };
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Material[]>).MakeByRefType(),
                            typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.
                                AsyncStateMachineAdaptor).MakeByRefType()))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_8);

                        break;
                    }
                }
            }

            args = new Type[]
            {
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.TextAsset[]>),
                typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
            };
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.TextAsset[]>)
                                .MakeByRefType(),
                            typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.
                                AsyncStateMachineAdaptor).MakeByRefType()))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_9);

                        break;
                    }
                }
            }

            args = new Type[]
            {
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.GameObject[]>),
                typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
            };
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.GameObject[]>)
                                .MakeByRefType(),
                            typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.
                                AsyncStateMachineAdaptor).MakeByRefType()))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_10);

                        break;
                    }
                }
            }

            args = new Type[]
            {
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Shader[]>),
                typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
            };
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Shader[]>).MakeByRefType(),
                            typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.
                                AsyncStateMachineAdaptor).MakeByRefType()))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_11);

                        break;
                    }
                }
            }

            args = new Type[]
            {
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Video.VideoClip[]>),
                typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
            };
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Video.VideoClip[]>)
                                .MakeByRefType(),
                            typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.
                                AsyncStateMachineAdaptor).MakeByRefType()))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_12);

                        break;
                    }
                }
            }

            args = new Type[]
            {
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Texture2D[]>),
                typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
            };
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Texture2D[]>)
                                .MakeByRefType(),
                            typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.
                                AsyncStateMachineAdaptor).MakeByRefType()))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_13);

                        break;
                    }
                }
            }

            args = new Type[]
            {
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Font[]>),
                typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
            };
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Font[]>).MakeByRefType(),
                            typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.
                                AsyncStateMachineAdaptor).MakeByRefType()))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_14);

                        break;
                    }
                }
            }

            args = new Type[]
            {
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.TextAsset>),
                typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
            };
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.TextAsset>).MakeByRefType(),
                            typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.
                                AsyncStateMachineAdaptor).MakeByRefType()))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_15);

                        break;
                    }
                }
            }

            args = new Type[]
            {
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.GameObject>),
                typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)
            };
            if (genericMethods.TryGetValue("AwaitUnsafeOnCompleted", out lst))
            {
                foreach (var m in lst)
                {
                    if (m.MatchGenericParameters(args, typeof(void),
                            typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.GameObject>).MakeByRefType(),
                            typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.
                                AsyncStateMachineAdaptor).MakeByRefType()))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitUnsafeOnCompleted_16);

                        break;
                    }
                }
            }
#if UNITY_6000_0_OR_NEWER
            args =
 new Type[]{typeof(UnityEngine.AsyncInstantiateOperation<UnityEngine.GameObject>.Awaiter), typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor)};
            if (genericMethods.TryGetValue("AwaitOnCompleted", out lst))
            {
                foreach(var m in lst)
                {
                    if(m.MatchGenericParameters(args, typeof(void), typeof(UnityEngine.AsyncInstantiateOperation<UnityEngine.GameObject>.Awaiter).MakeByRefType(), typeof(UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor).MakeByRefType()))
                    {
                        method = m.MakeGenericMethod(args);
                        app.RegisterCLRMethodRedirection(method, AwaitOnCompleted_17);

                        break;
                    }
                }
            }
#endif

            app.RegisterCLRCreateDefaultInstance(type,
                () => new System.Runtime.CompilerServices.AsyncVoidMethodBuilder());
        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain,
            StackObject* ptr_of_this_method, AutoList __mStack,
            ref System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method)
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
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as System.Runtime.CompilerServices.AsyncVoidMethodBuilder[];
                    instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                }
                    break;
            }
        }

        static StackObject* Create_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Create();

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
            object instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            ((System.Runtime.CompilerServices.AsyncVoidMethodBuilder) instance_of_this_method)
                .Start<
                    UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @stateMachine);

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

        static StackObject* AwaitUnsafeOnCompleted_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            System.Runtime.CompilerServices.TaskAwaiter @awaiter =
                (System.Runtime.CompilerServices.TaskAwaiter) typeof(System.Runtime.CompilerServices.TaskAwaiter)
                    .CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method
                .AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter,
                    UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @awaiter, ref @stateMachine);

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
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as System.Runtime.CompilerServices.TaskAwaiter[];
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

        static StackObject* SetException_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method.SetException(@exception);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* SetResult_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method.SetResult();

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* AwaitUnsafeOnCompleted_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.ScriptableObject[]> @awaiter =
                (System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.ScriptableObject[]>)
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.ScriptableObject[]>).CheckCLRTypes(
                    __intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method
                .AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.ScriptableObject[]>,
                    UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @awaiter, ref @stateMachine);

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
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as System.Runtime.CompilerServices.TaskAwaiter<
                            UnityEngine.ScriptableObject[]>[];
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

        static StackObject* AwaitUnsafeOnCompleted_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AudioClip[]> @awaiter =
                (System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AudioClip[]>)
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AudioClip[]>).CheckCLRTypes(
                    __intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method
                .AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AudioClip[]>,
                    UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @awaiter, ref @stateMachine);

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
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as
                            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.AudioClip[]>[];
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

        static StackObject* AwaitUnsafeOnCompleted_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Sprite[]> @awaiter =
                (System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Sprite[]>)
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Sprite[]>).CheckCLRTypes(
                    __intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method
                .AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Sprite[]>,
                    UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @awaiter, ref @stateMachine);

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
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as
                            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Sprite[]>[];
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

        static StackObject* AwaitUnsafeOnCompleted_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Material[]> @awaiter =
                (System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Material[]>)
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Material[]>).CheckCLRTypes(
                    __intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method
                .AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Material[]>,
                    UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @awaiter, ref @stateMachine);

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
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as
                            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Material[]>[];
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

        static StackObject* AwaitUnsafeOnCompleted_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.TextAsset[]> @awaiter =
                (System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.TextAsset[]>)
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.TextAsset[]>).CheckCLRTypes(
                    __intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method
                .AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.TextAsset[]>,
                    UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @awaiter, ref @stateMachine);

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
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as
                            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.TextAsset[]>[];
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

        static StackObject* AwaitUnsafeOnCompleted_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.GameObject[]> @awaiter =
                (System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.GameObject[]>)
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.GameObject[]>).CheckCLRTypes(
                    __intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method
                .AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.GameObject[]>,
                    UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @awaiter, ref @stateMachine);

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
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as
                            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.GameObject[]>[];
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

        static StackObject* AwaitUnsafeOnCompleted_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Shader[]> @awaiter =
                (System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Shader[]>)
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Shader[]>).CheckCLRTypes(
                    __intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method
                .AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Shader[]>,
                    UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @awaiter, ref @stateMachine);

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
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as
                            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Shader[]>[];
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

        static StackObject* AwaitUnsafeOnCompleted_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Video.VideoClip[]> @awaiter =
                (System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Video.VideoClip[]>)
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Video.VideoClip[]>).CheckCLRTypes(
                    __intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method
                .AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Video.VideoClip[]>,
                    UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @awaiter, ref @stateMachine);

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
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as
                            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Video.VideoClip[]>[];
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

        static StackObject* AwaitUnsafeOnCompleted_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Texture2D[]> @awaiter =
                (System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Texture2D[]>)
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Texture2D[]>).CheckCLRTypes(
                    __intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method
                .AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Texture2D[]>,
                    UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @awaiter, ref @stateMachine);

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
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as
                            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Texture2D[]>[];
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

        static StackObject* AwaitUnsafeOnCompleted_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Font[]> @awaiter =
                (System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Font[]>)
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Font[]>).CheckCLRTypes(
                    __intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method
                .AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Font[]>,
                    UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @awaiter, ref @stateMachine);

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
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as
                            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.Font[]>[];
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

        static StackObject* AwaitUnsafeOnCompleted_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.TextAsset> @awaiter =
                (System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.TextAsset>)
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.TextAsset>).CheckCLRTypes(
                    __intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method
                .AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.TextAsset>,
                    UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @awaiter, ref @stateMachine);

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
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as
                            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.TextAsset>[];
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

        static StackObject* AwaitUnsafeOnCompleted_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.GameObject> @awaiter =
                (System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.GameObject>)
                typeof(System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.GameObject>).CheckCLRTypes(
                    __intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method
                .AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<UnityEngine.GameObject>,
                    UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @awaiter, ref @stateMachine);

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
                    if (__mStack[ptr_of_this_method->Value] is TaskAwaiter<GameObject>[] tmp_InstanceOfArrayReference)
                        tmp_InstanceOfArrayReference[ptr_of_this_method->ValueLow] = @awaiter;
                }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }
#if UNITY_6000_0_OR_NEWER
        static StackObject* AwaitOnCompleted_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
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
            UnityEngine.AsyncInstantiateOperation<UnityEngine.GameObject>.Awaiter @awaiter =
                (UnityEngine.AsyncInstantiateOperation<UnityEngine.GameObject>.Awaiter)
                typeof(UnityEngine.AsyncInstantiateOperation<UnityEngine.GameObject>.Awaiter).CheckCLRTypes(
                    __intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            System.Runtime.CompilerServices.AsyncVoidMethodBuilder instance_of_this_method =
                (System.Runtime.CompilerServices.AsyncVoidMethodBuilder)
                typeof(System.Runtime.CompilerServices.AsyncVoidMethodBuilder).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);

            instance_of_this_method
                .AwaitOnCompleted<UnityEngine.AsyncInstantiateOperation<UnityEngine.GameObject>.Awaiter,
                    UnityFusion.CLRBinding.Adapter.AsyncStateMachineClassInheritanceAdaptor.AsyncStateMachineAdaptor>(
                    ref @awaiter, ref @stateMachine);

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
                    var instance_of_arrayReference =
                        __mStack[ptr_of_this_method->Value] as
                            UnityEngine.AsyncInstantiateOperation<UnityEngine.GameObject>.Awaiter[];
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
#endif
    }
}
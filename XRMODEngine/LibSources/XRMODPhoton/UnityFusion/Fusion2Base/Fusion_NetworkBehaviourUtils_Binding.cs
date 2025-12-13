using System;
using System.Collections.Generic;
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
    unsafe class Fusion_NetworkBehaviourUtils_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.NetworkBehaviourUtils);
            args = new Type[]{typeof(System.Type)};
            method = type.GetMethod("GetMetaData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetMetaData_0);
            args = new Type[]{typeof(System.Type)};
            method = type.GetMethod("RegisterMetaData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterMetaData_1);
            args = new Type[]{typeof(Fusion.NetworkBehaviour)};
            method = type.GetMethod("GetWordCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetWordCount_2);
            args = new Type[]{typeof(System.Type)};
            method = type.GetMethod("HasStaticWordCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HasStaticWordCount_3);
            args = new Type[]{typeof(System.Type)};
            method = type.GetMethod("GetStaticWordCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetStaticWordCount_4);
            args = new Type[]{typeof(System.Type)};
            method = type.GetMethod("ShouldRegisterRpcInvokeDelegates", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ShouldRegisterRpcInvokeDelegates_5);
            args = new Type[]{typeof(System.Type)};
            method = type.GetMethod("RegisterRpcInvokeDelegates", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterRpcInvokeDelegates_6);
            args = new Type[]{typeof(System.Type), typeof(Fusion.RpcInvokeData[]).MakeByRefType()};
            method = type.GetMethod("TryGetRpcInvokeDelegateArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetRpcInvokeDelegateArray_7);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetRpcStaticIndexOrThrow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRpcStaticIndexOrThrow_8);
            args = new Type[]{typeof(System.Int32), typeof(Fusion.RpcStaticInvokeDelegate).MakeByRefType()};
            method = type.GetMethod("TryGetRpcStaticInvokeDelegate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetRpcStaticInvokeDelegate_9);
            args = new Type[]{typeof(System.String), typeof(System.Int32)};
            method = type.GetMethod("NotifyRpcPayloadSizeExceeded", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, NotifyRpcPayloadSizeExceeded_10);
            args = new Type[]{typeof(Fusion.PlayerRef), typeof(System.String)};
            method = type.GetMethod("NotifyRpcTargetUnreachable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, NotifyRpcTargetUnreachable_11);
            args = new Type[]{typeof(System.String), typeof(Fusion.NetworkObject), typeof(System.Int32)};
            method = type.GetMethod("NotifyLocalSimulationNotAllowedToSendRpc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, NotifyLocalSimulationNotAllowedToSendRpc_12);
            args = new Type[]{typeof(Fusion.PlayerRef), typeof(System.String)};
            method = type.GetMethod("NotifyLocalTargetedRpcCulled", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, NotifyLocalTargetedRpcCulled_13);
            args = new Type[]{typeof(Fusion.NetworkBehaviour)};
            method = type.GetMethod("ThrowIfBehaviourNotInitialized", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ThrowIfBehaviourNotInitialized_14);
            args = new Type[]{typeof(Fusion.SimulationBehaviour)};
            method = type.GetMethod("InternalOnDestroy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InternalOnDestroy_15);
            args = new Type[]{typeof(Fusion.SimulationBehaviour)};
            method = type.GetMethod("InternalOnEnable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InternalOnEnable_16);
            args = new Type[]{typeof(Fusion.SimulationBehaviour)};
            method = type.GetMethod("InternalOnDisable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InternalOnDisable_17);

            field = type.GetField("InvokeRpc", flag);
            app.RegisterCLRFieldGetter(field, get_InvokeRpc_0);
            app.RegisterCLRFieldSetter(field, set_InvokeRpc_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_InvokeRpc_0, AssignFromStack_InvokeRpc_0);




        }


        static StackObject* GetMetaData_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @type = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Fusion.NetworkBehaviourUtils.GetMetaData(@type);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RegisterMetaData_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @type = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Fusion.NetworkBehaviourUtils.RegisterMetaData(@type);

            return __ret;
        }

        static StackObject* GetWordCount_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkBehaviour @behaviour = (Fusion.NetworkBehaviour)typeof(Fusion.NetworkBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Fusion.NetworkBehaviourUtils.GetWordCount(@behaviour);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* HasStaticWordCount_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @type = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Fusion.NetworkBehaviourUtils.HasStaticWordCount(@type);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetStaticWordCount_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @type = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Fusion.NetworkBehaviourUtils.GetStaticWordCount(@type);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* ShouldRegisterRpcInvokeDelegates_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @type = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Fusion.NetworkBehaviourUtils.ShouldRegisterRpcInvokeDelegates(@type);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RegisterRpcInvokeDelegates_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Type @type = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Fusion.NetworkBehaviourUtils.RegisterRpcInvokeDelegates(@type);

            return __ret;
        }

        static StackObject* TryGetRpcInvokeDelegateArray_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.RpcInvokeData[] @delegates = (Fusion.RpcInvokeData[])typeof(Fusion.RpcInvokeData[]).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Type @type = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);


            var result_of_this_method = Fusion.NetworkBehaviourUtils.TryGetRpcInvokeDelegateArray(@type, out @delegates);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @delegates;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
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
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @delegates;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @delegates);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @delegates;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @delegates);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Fusion.RpcInvokeData[][];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @delegates;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetRpcStaticIndexOrThrow_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @key = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Fusion.NetworkBehaviourUtils.GetRpcStaticIndexOrThrow(@key);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* TryGetRpcStaticInvokeDelegate_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.RpcStaticInvokeDelegate @del = (Fusion.RpcStaticInvokeDelegate)typeof(Fusion.RpcStaticInvokeDelegate).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @index = ptr_of_this_method->Value;


            var result_of_this_method = Fusion.NetworkBehaviourUtils.TryGetRpcStaticInvokeDelegate(@index, out @del);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @del;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
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
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @del;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @del);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @del;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @del);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Fusion.RpcStaticInvokeDelegate[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @del;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* NotifyRpcPayloadSizeExceeded_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @size = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @rpc = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Fusion.NetworkBehaviourUtils.NotifyRpcPayloadSizeExceeded(@rpc, @size);

            return __ret;
        }

        static StackObject* NotifyRpcTargetUnreachable_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @rpc = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.PlayerRef @player = (Fusion.PlayerRef)typeof(Fusion.PlayerRef).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            Fusion.NetworkBehaviourUtils.NotifyRpcTargetUnreachable(@player, @rpc);

            return __ret;
        }

        static StackObject* NotifyLocalSimulationNotAllowedToSendRpc_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @sources = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.NetworkObject @obj = (Fusion.NetworkObject)typeof(Fusion.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @rpc = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Fusion.NetworkBehaviourUtils.NotifyLocalSimulationNotAllowedToSendRpc(@rpc, @obj, @sources);

            return __ret;
        }

        static StackObject* NotifyLocalTargetedRpcCulled_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @methodName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.PlayerRef @player = (Fusion.PlayerRef)typeof(Fusion.PlayerRef).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            Fusion.NetworkBehaviourUtils.NotifyLocalTargetedRpcCulled(@player, @methodName);

            return __ret;
        }

        static StackObject* ThrowIfBehaviourNotInitialized_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkBehaviour @behaviour = (Fusion.NetworkBehaviour)typeof(Fusion.NetworkBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Fusion.NetworkBehaviourUtils.ThrowIfBehaviourNotInitialized(@behaviour);

            return __ret;
        }

        static StackObject* InternalOnDestroy_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.SimulationBehaviour @obj = (Fusion.SimulationBehaviour)typeof(Fusion.SimulationBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Fusion.NetworkBehaviourUtils.InternalOnDestroy(@obj);

            return __ret;
        }

        static StackObject* InternalOnEnable_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.SimulationBehaviour @obj = (Fusion.SimulationBehaviour)typeof(Fusion.SimulationBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Fusion.NetworkBehaviourUtils.InternalOnEnable(@obj);

            return __ret;
        }

        static StackObject* InternalOnDisable_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.SimulationBehaviour @obj = (Fusion.SimulationBehaviour)typeof(Fusion.SimulationBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Fusion.NetworkBehaviourUtils.InternalOnDisable(@obj);

            return __ret;
        }


        static object get_InvokeRpc_0(ref object o)
        {
            return Fusion.NetworkBehaviourUtils.InvokeRpc;
        }

        static StackObject* CopyToStack_InvokeRpc_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.NetworkBehaviourUtils.InvokeRpc;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_InvokeRpc_0(ref object o, object v)
        {
            Fusion.NetworkBehaviourUtils.InvokeRpc = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_InvokeRpc_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @InvokeRpc = ptr_of_this_method->Value == 1;
            Fusion.NetworkBehaviourUtils.InvokeRpc = @InvokeRpc;
            return ptr_of_this_method;
        }




    }
}

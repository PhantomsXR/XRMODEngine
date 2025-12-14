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
    unsafe class Unity_Netcode_RpcParams_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Netcode.RpcParams);
            MethodInfo[] methods = type.GetMethods(flag).Where(t => !t.IsGenericMethod).ToArray();
            args = new Type[]{typeof(Unity.Netcode.RpcSendParams)};
            method = methods.Where(t => t.Name.Equals("op_Implicit") && t.ReturnType == typeof(Unity.Netcode.RpcParams) && t.CheckMethodParams(args)).Single();
            app.RegisterCLRMethodRedirection(method, op_Implicit_0);
            args = new Type[]{typeof(Unity.Netcode.BaseRpcTarget)};
            method = methods.Where(t => t.Name.Equals("op_Implicit") && t.ReturnType == typeof(Unity.Netcode.RpcParams) && t.CheckMethodParams(args)).Single();
            app.RegisterCLRMethodRedirection(method, op_Implicit_1);
            args = new Type[]{typeof(Unity.Netcode.LocalDeferMode)};
            method = methods.Where(t => t.Name.Equals("op_Implicit") && t.ReturnType == typeof(Unity.Netcode.RpcParams) && t.CheckMethodParams(args)).Single();
            app.RegisterCLRMethodRedirection(method, op_Implicit_2);
            args = new Type[]{typeof(Unity.Netcode.RpcReceiveParams)};
            method = methods.Where(t => t.Name.Equals("op_Implicit") && t.ReturnType == typeof(Unity.Netcode.RpcParams) && t.CheckMethodParams(args)).Single();
            app.RegisterCLRMethodRedirection(method, op_Implicit_3);

            field = type.GetField("Send", flag);
            app.RegisterCLRFieldGetter(field, get_Send_0);
            app.RegisterCLRFieldSetter(field, set_Send_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Send_0, AssignFromStack_Send_0);
            field = type.GetField("Receive", flag);
            app.RegisterCLRFieldGetter(field, get_Receive_1);
            app.RegisterCLRFieldSetter(field, set_Receive_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Receive_1, AssignFromStack_Receive_1);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.Netcode.RpcParams());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Netcode.RpcParams[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Unity.Netcode.RpcParams instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
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
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Unity.Netcode.RpcParams[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* op_Implicit_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.RpcSendParams @send = (Unity.Netcode.RpcSendParams)typeof(Unity.Netcode.RpcSendParams).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = (Unity.Netcode.RpcParams)send;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* op_Implicit_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.BaseRpcTarget @target = (Unity.Netcode.BaseRpcTarget)typeof(Unity.Netcode.BaseRpcTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = (Unity.Netcode.RpcParams)target;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* op_Implicit_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.LocalDeferMode @deferMode = (Unity.Netcode.LocalDeferMode)typeof(Unity.Netcode.LocalDeferMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = (Unity.Netcode.RpcParams)deferMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* op_Implicit_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.RpcReceiveParams @receive = (Unity.Netcode.RpcReceiveParams)typeof(Unity.Netcode.RpcReceiveParams).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = (Unity.Netcode.RpcParams)receive;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_Send_0(ref object o)
        {
            return ((Unity.Netcode.RpcParams)o).Send;
        }

        static StackObject* CopyToStack_Send_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.RpcParams)o).Send;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Send_0(ref object o, object v)
        {
            Unity.Netcode.RpcParams ins =(Unity.Netcode.RpcParams)o;
            ins.Send = (Unity.Netcode.RpcSendParams)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Send_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.RpcSendParams @Send = (Unity.Netcode.RpcSendParams)typeof(Unity.Netcode.RpcSendParams).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Unity.Netcode.RpcParams ins =(Unity.Netcode.RpcParams)o;
            ins.Send = @Send;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Receive_1(ref object o)
        {
            return ((Unity.Netcode.RpcParams)o).Receive;
        }

        static StackObject* CopyToStack_Receive_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.RpcParams)o).Receive;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Receive_1(ref object o, object v)
        {
            Unity.Netcode.RpcParams ins =(Unity.Netcode.RpcParams)o;
            ins.Receive = (Unity.Netcode.RpcReceiveParams)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Receive_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.RpcReceiveParams @Receive = (Unity.Netcode.RpcReceiveParams)typeof(Unity.Netcode.RpcReceiveParams).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Unity.Netcode.RpcParams ins =(Unity.Netcode.RpcParams)o;
            ins.Receive = @Receive;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Unity.Netcode.RpcParams();
            ins = (Unity.Netcode.RpcParams)o;
            return ins;
        }


    }
}

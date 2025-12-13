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
    unsafe class Unity_Netcode_ServerRpcParams_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Netcode.ServerRpcParams);

            field = type.GetField("Send", flag);
            app.RegisterCLRFieldGetter(field, get_Send_0);
            app.RegisterCLRFieldSetter(field, set_Send_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Send_0, AssignFromStack_Send_0);
            field = type.GetField("Receive", flag);
            app.RegisterCLRFieldGetter(field, get_Receive_1);
            app.RegisterCLRFieldSetter(field, set_Receive_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Receive_1, AssignFromStack_Receive_1);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.Netcode.ServerRpcParams());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Netcode.ServerRpcParams[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Unity.Netcode.ServerRpcParams instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Unity.Netcode.ServerRpcParams[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Send_0(ref object o)
        {
            return ((Unity.Netcode.ServerRpcParams)o).Send;
        }

        static StackObject* CopyToStack_Send_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.ServerRpcParams)o).Send;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Send_0(ref object o, object v)
        {
            Unity.Netcode.ServerRpcParams ins =(Unity.Netcode.ServerRpcParams)o;
            ins.Send = (Unity.Netcode.ServerRpcSendParams)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Send_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.ServerRpcSendParams @Send = (Unity.Netcode.ServerRpcSendParams)typeof(Unity.Netcode.ServerRpcSendParams).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Unity.Netcode.ServerRpcParams ins =(Unity.Netcode.ServerRpcParams)o;
            ins.Send = @Send;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Receive_1(ref object o)
        {
            return ((Unity.Netcode.ServerRpcParams)o).Receive;
        }

        static StackObject* CopyToStack_Receive_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.ServerRpcParams)o).Receive;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Receive_1(ref object o, object v)
        {
            Unity.Netcode.ServerRpcParams ins =(Unity.Netcode.ServerRpcParams)o;
            ins.Receive = (Unity.Netcode.ServerRpcReceiveParams)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Receive_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.ServerRpcReceiveParams @Receive = (Unity.Netcode.ServerRpcReceiveParams)typeof(Unity.Netcode.ServerRpcReceiveParams).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Unity.Netcode.ServerRpcParams ins =(Unity.Netcode.ServerRpcParams)o;
            ins.Receive = @Receive;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Unity.Netcode.ServerRpcParams();
            ins = (Unity.Netcode.ServerRpcParams)o;
            return ins;
        }


    }
}

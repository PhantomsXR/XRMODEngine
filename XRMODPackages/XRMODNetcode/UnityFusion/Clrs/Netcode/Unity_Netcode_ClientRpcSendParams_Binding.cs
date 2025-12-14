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
    unsafe class Unity_Netcode_ClientRpcSendParams_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Netcode.ClientRpcSendParams);

            field = type.GetField("TargetClientIds", flag);
            app.RegisterCLRFieldGetter(field, get_TargetClientIds_0);
            app.RegisterCLRFieldSetter(field, set_TargetClientIds_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetClientIds_0, AssignFromStack_TargetClientIds_0);
            field = type.GetField("TargetClientIdsNativeArray", flag);
            app.RegisterCLRFieldGetter(field, get_TargetClientIdsNativeArray_1);
            app.RegisterCLRFieldSetter(field, set_TargetClientIdsNativeArray_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetClientIdsNativeArray_1, AssignFromStack_TargetClientIdsNativeArray_1);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.Netcode.ClientRpcSendParams());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Netcode.ClientRpcSendParams[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Unity.Netcode.ClientRpcSendParams instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Unity.Netcode.ClientRpcSendParams[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_TargetClientIds_0(ref object o)
        {
            return ((Unity.Netcode.ClientRpcSendParams)o).TargetClientIds;
        }

        static StackObject* CopyToStack_TargetClientIds_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.ClientRpcSendParams)o).TargetClientIds;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetClientIds_0(ref object o, object v)
        {
            Unity.Netcode.ClientRpcSendParams ins =(Unity.Netcode.ClientRpcSendParams)o;
            ins.TargetClientIds = (System.Collections.Generic.IReadOnlyList<System.UInt64>)v;
            o = ins;
        }

        static StackObject* AssignFromStack_TargetClientIds_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.IReadOnlyList<System.UInt64> @TargetClientIds = (System.Collections.Generic.IReadOnlyList<System.UInt64>)typeof(System.Collections.Generic.IReadOnlyList<System.UInt64>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            Unity.Netcode.ClientRpcSendParams ins =(Unity.Netcode.ClientRpcSendParams)o;
            ins.TargetClientIds = @TargetClientIds;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_TargetClientIdsNativeArray_1(ref object o)
        {
            return ((Unity.Netcode.ClientRpcSendParams)o).TargetClientIdsNativeArray;
        }

        static StackObject* CopyToStack_TargetClientIdsNativeArray_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.ClientRpcSendParams)o).TargetClientIdsNativeArray;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetClientIdsNativeArray_1(ref object o, object v)
        {
            Unity.Netcode.ClientRpcSendParams ins =(Unity.Netcode.ClientRpcSendParams)o;
            ins.TargetClientIdsNativeArray = (System.Nullable<Unity.Collections.NativeArray<System.UInt64>>)v;
            o = ins;
        }

        static StackObject* AssignFromStack_TargetClientIdsNativeArray_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Nullable<Unity.Collections.NativeArray<System.UInt64>> @TargetClientIdsNativeArray = (System.Nullable<Unity.Collections.NativeArray<System.UInt64>>)typeof(System.Nullable<Unity.Collections.NativeArray<System.UInt64>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Unity.Netcode.ClientRpcSendParams ins =(Unity.Netcode.ClientRpcSendParams)o;
            ins.TargetClientIdsNativeArray = @TargetClientIdsNativeArray;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Unity.Netcode.ClientRpcSendParams();
            ins = (Unity.Netcode.ClientRpcSendParams)o;
            return ins;
        }


    }
}

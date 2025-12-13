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
    unsafe class Unity_Netcode_NetworkEvent_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Netcode.NetworkEvent);

            field = type.GetField("Data", flag);
            app.RegisterCLRFieldGetter(field, get_Data_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Data_0, null);
            field = type.GetField("Connect", flag);
            app.RegisterCLRFieldGetter(field, get_Connect_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Connect_1, null);
            field = type.GetField("Disconnect", flag);
            app.RegisterCLRFieldGetter(field, get_Disconnect_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Disconnect_2, null);
            field = type.GetField("TransportFailure", flag);
            app.RegisterCLRFieldGetter(field, get_TransportFailure_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_TransportFailure_3, null);
            field = type.GetField("Nothing", flag);
            app.RegisterCLRFieldGetter(field, get_Nothing_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Nothing_4, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.Netcode.NetworkEvent());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Netcode.NetworkEvent[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Unity.Netcode.NetworkEvent instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Unity.Netcode.NetworkEvent[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Data_0(ref object o)
        {
            return Unity.Netcode.NetworkEvent.Data;
        }

        static StackObject* CopyToStack_Data_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.NetworkEvent.Data;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Connect_1(ref object o)
        {
            return Unity.Netcode.NetworkEvent.Connect;
        }

        static StackObject* CopyToStack_Connect_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.NetworkEvent.Connect;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Disconnect_2(ref object o)
        {
            return Unity.Netcode.NetworkEvent.Disconnect;
        }

        static StackObject* CopyToStack_Disconnect_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.NetworkEvent.Disconnect;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_TransportFailure_3(ref object o)
        {
            return Unity.Netcode.NetworkEvent.TransportFailure;
        }

        static StackObject* CopyToStack_TransportFailure_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.NetworkEvent.TransportFailure;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Nothing_4(ref object o)
        {
            return Unity.Netcode.NetworkEvent.Nothing;
        }

        static StackObject* CopyToStack_Nothing_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.NetworkEvent.Nothing;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Unity.Netcode.NetworkEvent();
            ins = (Unity.Netcode.NetworkEvent)o;
            return ins;
        }


    }
}

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
    unsafe class Unity_Netcode_NetworkClient_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Netcode.NetworkClient);

            field = type.GetField("PlayerObject", flag);
            app.RegisterCLRFieldGetter(field, get_PlayerObject_0);
            app.RegisterCLRFieldSetter(field, set_PlayerObject_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_PlayerObject_0, AssignFromStack_PlayerObject_0);


        }



        static object get_PlayerObject_0(ref object o)
        {
            return ((Unity.Netcode.NetworkClient)o).PlayerObject;
        }

        static StackObject* CopyToStack_PlayerObject_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkClient)o).PlayerObject;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PlayerObject_0(ref object o, object v)
        {
            ((Unity.Netcode.NetworkClient)o).PlayerObject = (Unity.Netcode.NetworkObject)v;
        }

        static StackObject* AssignFromStack_PlayerObject_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.NetworkObject @PlayerObject = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.NetworkClient)o).PlayerObject = @PlayerObject;
            return ptr_of_this_method;
        }



    }
}

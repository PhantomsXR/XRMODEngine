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
    unsafe class Unity_Netcode_NetworkManager_Binding_ConnectionApprovalResponse_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Netcode.NetworkManager.ConnectionApprovalResponse);

            field = type.GetField("Approved", flag);
            app.RegisterCLRFieldGetter(field, get_Approved_0);
            app.RegisterCLRFieldSetter(field, set_Approved_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Approved_0, AssignFromStack_Approved_0);
            field = type.GetField("Reason", flag);
            app.RegisterCLRFieldGetter(field, get_Reason_1);
            app.RegisterCLRFieldSetter(field, set_Reason_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Reason_1, AssignFromStack_Reason_1);
            field = type.GetField("CreatePlayerObject", flag);
            app.RegisterCLRFieldGetter(field, get_CreatePlayerObject_2);
            app.RegisterCLRFieldSetter(field, set_CreatePlayerObject_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_CreatePlayerObject_2, AssignFromStack_CreatePlayerObject_2);


        }



        static object get_Approved_0(ref object o)
        {
            return ((Unity.Netcode.NetworkManager.ConnectionApprovalResponse)o).Approved;
        }

        static StackObject* CopyToStack_Approved_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkManager.ConnectionApprovalResponse)o).Approved;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_Approved_0(ref object o, object v)
        {
            ((Unity.Netcode.NetworkManager.ConnectionApprovalResponse)o).Approved = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_Approved_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @Approved = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkManager.ConnectionApprovalResponse)o).Approved = @Approved;
            return ptr_of_this_method;
        }

        static object get_Reason_1(ref object o)
        {
            return ((Unity.Netcode.NetworkManager.ConnectionApprovalResponse)o).Reason;
        }

        static StackObject* CopyToStack_Reason_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkManager.ConnectionApprovalResponse)o).Reason;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Reason_1(ref object o, object v)
        {
            ((Unity.Netcode.NetworkManager.ConnectionApprovalResponse)o).Reason = (System.String)v;
        }

        static StackObject* AssignFromStack_Reason_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @Reason = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.NetworkManager.ConnectionApprovalResponse)o).Reason = @Reason;
            return ptr_of_this_method;
        }

        static object get_CreatePlayerObject_2(ref object o)
        {
            return ((Unity.Netcode.NetworkManager.ConnectionApprovalResponse)o).CreatePlayerObject;
        }

        static StackObject* CopyToStack_CreatePlayerObject_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkManager.ConnectionApprovalResponse)o).CreatePlayerObject;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_CreatePlayerObject_2(ref object o, object v)
        {
            ((Unity.Netcode.NetworkManager.ConnectionApprovalResponse)o).CreatePlayerObject = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_CreatePlayerObject_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @CreatePlayerObject = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.NetworkManager.ConnectionApprovalResponse)o).CreatePlayerObject = @CreatePlayerObject;
            return ptr_of_this_method;
        }



    }
}

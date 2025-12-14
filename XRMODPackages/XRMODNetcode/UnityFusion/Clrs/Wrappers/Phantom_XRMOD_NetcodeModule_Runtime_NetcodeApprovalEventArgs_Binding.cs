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
    unsafe class Phantom_XRMOD_NetcodeModule_Runtime_NetcodeApprovalEventArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetcodeApprovalEventArgs);

            field = type.GetField("ApprovalRequest", flag);
            app.RegisterCLRFieldGetter(field, get_ApprovalRequest_0);
            app.RegisterCLRFieldSetter(field, set_ApprovalRequest_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_ApprovalRequest_0, AssignFromStack_ApprovalRequest_0);
            field = type.GetField("ApprovalResponse", flag);
            app.RegisterCLRFieldGetter(field, get_ApprovalResponse_1);
            app.RegisterCLRFieldSetter(field, set_ApprovalResponse_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_ApprovalResponse_1, AssignFromStack_ApprovalResponse_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.NetcodeModule.Runtime.NetcodeApprovalEventArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.NetcodeModule.Runtime.NetcodeApprovalEventArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_ApprovalRequest_0(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.NetcodeApprovalEventArgs)o).ApprovalRequest;
        }

        static StackObject* CopyToStack_ApprovalRequest_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.NetcodeApprovalEventArgs)o).ApprovalRequest;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ApprovalRequest_0(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetcodeApprovalEventArgs)o).ApprovalRequest = (Unity.Netcode.NetworkManager.ConnectionApprovalRequest)v;
        }

        static StackObject* AssignFromStack_ApprovalRequest_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.NetworkManager.ConnectionApprovalRequest @ApprovalRequest = (Unity.Netcode.NetworkManager.ConnectionApprovalRequest)typeof(Unity.Netcode.NetworkManager.ConnectionApprovalRequest).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetcodeApprovalEventArgs)o).ApprovalRequest = @ApprovalRequest;
            return ptr_of_this_method;
        }

        static object get_ApprovalResponse_1(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.NetcodeApprovalEventArgs)o).ApprovalResponse;
        }

        static StackObject* CopyToStack_ApprovalResponse_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.NetcodeApprovalEventArgs)o).ApprovalResponse;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ApprovalResponse_1(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetcodeApprovalEventArgs)o).ApprovalResponse = (Unity.Netcode.NetworkManager.ConnectionApprovalResponse)v;
        }

        static StackObject* AssignFromStack_ApprovalResponse_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.NetworkManager.ConnectionApprovalResponse @ApprovalResponse = (Unity.Netcode.NetworkManager.ConnectionApprovalResponse)typeof(Unity.Netcode.NetworkManager.ConnectionApprovalResponse).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetcodeApprovalEventArgs)o).ApprovalResponse = @ApprovalResponse;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.NetcodeModule.Runtime.NetcodeApprovalEventArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

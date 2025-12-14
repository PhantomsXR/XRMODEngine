#if FUSION2 && XRMOD_INSTALL
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
    unsafe class OnEventFusionConnectRequestArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionConnectRequestArgs);

            field = type.GetField("Bytes", flag);
            app.RegisterCLRFieldGetter(field, get_Bytes_0);
            app.RegisterCLRFieldSetter(field, set_Bytes_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Bytes_0, AssignFromStack_Bytes_0);
            field = type.GetField("Request", flag);
            app.RegisterCLRFieldGetter(field, get_Request_1);
            app.RegisterCLRFieldSetter(field, set_Request_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Request_1, AssignFromStack_Request_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionConnectRequestArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionConnectRequestArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_Bytes_0(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionConnectRequestArgs)o).Bytes;
        }

        static StackObject* CopyToStack_Bytes_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionConnectRequestArgs)o).Bytes;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Bytes_0(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionConnectRequestArgs)o).Bytes = (System.Byte[])v;
        }

        static StackObject* AssignFromStack_Bytes_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Byte[] @Bytes = (System.Byte[])typeof(System.Byte[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionConnectRequestArgs)o).Bytes = @Bytes;
            return ptr_of_this_method;
        }

        static object get_Request_1(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionConnectRequestArgs)o).Request;
        }

        static StackObject* CopyToStack_Request_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionConnectRequestArgs)o).Request;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Request_1(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionConnectRequestArgs)o).Request = (Fusion.NetworkRunnerCallbackArgs.ConnectRequest)v;
        }

        static StackObject* AssignFromStack_Request_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.NetworkRunnerCallbackArgs.ConnectRequest @Request = (Fusion.NetworkRunnerCallbackArgs.ConnectRequest)typeof(Fusion.NetworkRunnerCallbackArgs.ConnectRequest).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionConnectRequestArgs)o).Request = @Request;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionConnectRequestArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
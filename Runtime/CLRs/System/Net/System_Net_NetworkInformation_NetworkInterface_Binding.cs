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
    unsafe class System_Net_NetworkInformation_NetworkInterface_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(System.Net.NetworkInformation.NetworkInterface);
            args = new Type[]{};
            method = type.GetMethod("GetAllNetworkInterfaces", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAllNetworkInterfaces_0);
            args = new Type[]{};
            method = type.GetMethod("get_OperationalStatus", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_OperationalStatus_1);
            args = new Type[]{};
            method = type.GetMethod("get_NetworkInterfaceType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_NetworkInterfaceType_2);
            args = new Type[]{};
            method = type.GetMethod("get_Description", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Description_3);
            args = new Type[]{};
            method = type.GetMethod("GetIPProperties", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetIPProperties_4);


        }


        static StackObject* GetAllNetworkInterfaces_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_OperationalStatus_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Net.NetworkInformation.NetworkInterface instance_of_this_method = (System.Net.NetworkInformation.NetworkInterface)typeof(System.Net.NetworkInformation.NetworkInterface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.OperationalStatus;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_NetworkInterfaceType_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Net.NetworkInformation.NetworkInterface instance_of_this_method = (System.Net.NetworkInformation.NetworkInterface)typeof(System.Net.NetworkInformation.NetworkInterface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.NetworkInterfaceType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Description_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Net.NetworkInformation.NetworkInterface instance_of_this_method = (System.Net.NetworkInformation.NetworkInterface)typeof(System.Net.NetworkInformation.NetworkInterface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Description;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetIPProperties_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Net.NetworkInformation.NetworkInterface instance_of_this_method = (System.Net.NetworkInformation.NetworkInterface)typeof(System.Net.NetworkInformation.NetworkInterface).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetIPProperties();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



    }
}

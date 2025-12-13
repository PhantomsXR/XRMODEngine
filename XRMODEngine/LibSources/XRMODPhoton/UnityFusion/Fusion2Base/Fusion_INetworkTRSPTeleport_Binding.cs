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
    unsafe class Fusion_INetworkTRSPTeleport_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Fusion.INetworkTRSPTeleport);
            args = new Type[]{typeof(System.Nullable<UnityEngine.Vector3>), typeof(System.Nullable<UnityEngine.Quaternion>)};
            method = type.GetMethod("Teleport", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Teleport_0);



            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.INetworkTRSPTeleport[s]);


        }


        static StackObject* Teleport_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Nullable<UnityEngine.Quaternion> @rotation = (System.Nullable<UnityEngine.Quaternion>)typeof(System.Nullable<UnityEngine.Quaternion>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Nullable<UnityEngine.Vector3> @position = (System.Nullable<UnityEngine.Vector3>)typeof(System.Nullable<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.INetworkTRSPTeleport instance_of_this_method = (Fusion.INetworkTRSPTeleport)typeof(Fusion.INetworkTRSPTeleport).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Teleport(@position, @rotation);

            return __ret;
        }





    }
}

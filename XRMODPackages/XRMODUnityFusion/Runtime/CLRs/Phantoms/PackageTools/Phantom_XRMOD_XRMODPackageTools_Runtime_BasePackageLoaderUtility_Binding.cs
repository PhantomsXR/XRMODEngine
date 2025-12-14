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
    unsafe class Phantom_XRMOD_XRMODPackageTools_Runtime_BasePackageLoaderUtility_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODPackageTools.Runtime.BasePackageLoaderUtility);
            args = new Type[]{};
            method = type.GetMethod("ReleaseAllAssetBundle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReleaseAllAssetBundle_0);
            args = new Type[]{typeof(System.String), typeof(System.String), typeof(System.Boolean)};
            method = type.GetMethod("ReleaseAssetBundle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReleaseAssetBundle_1);





        }


        static StackObject* ReleaseAllAssetBundle_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            Phantom.XRMOD.XRMODPackageTools.Runtime.BasePackageLoaderUtility.ReleaseAllAssetBundle();

            return __ret;
        }

        static StackObject* ReleaseAssetBundle_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @_unloadAll = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_processId = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @_bundleName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODPackageTools.Runtime.BasePackageLoaderUtility.ReleaseAssetBundle(@_bundleName, @_processId, @_unloadAll);

            return __ret;
        }





    }
}

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
    unsafe class Phantom_XRMOD_BaseFeatures_Runtime_BuildTryAcquireLoadObjectCommand_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.BaseFeatures.Runtime.BuildTryAcquireLoadObjectCommand);
            args = new Type[]{};
            method = type.GetMethod("Execute", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Execute_0);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("Release", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Release_1);



            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.BaseFeatures.Runtime.BuildTryAcquireLoadObjectCommand());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.BaseFeatures.Runtime.BuildTryAcquireLoadObjectCommand[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Execute_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.BaseFeatures.Runtime.BuildTryAcquireLoadObjectCommand instance_of_this_method = (Phantom.XRMOD.BaseFeatures.Runtime.BuildTryAcquireLoadObjectCommand)typeof(Phantom.XRMOD.BaseFeatures.Runtime.BuildTryAcquireLoadObjectCommand).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Execute();

            return __ret;
        }

        static StackObject* Release_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_projectName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.BaseFeatures.Runtime.BuildTryAcquireLoadObjectCommand instance_of_this_method = (Phantom.XRMOD.BaseFeatures.Runtime.BuildTryAcquireLoadObjectCommand)typeof(Phantom.XRMOD.BaseFeatures.Runtime.BuildTryAcquireLoadObjectCommand).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Release(@_projectName);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.BaseFeatures.Runtime.BuildTryAcquireLoadObjectCommand();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

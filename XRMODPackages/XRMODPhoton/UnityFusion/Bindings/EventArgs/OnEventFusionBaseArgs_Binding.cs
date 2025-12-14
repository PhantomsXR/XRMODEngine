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
    unsafe class OnEventFusionBaseArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field; 
            Type type = typeof(Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionBaseArgs);

            field = type.GetField("Runner", flag);
            app.RegisterCLRFieldGetter(field, get_Runner_0);
            app.RegisterCLRFieldSetter(field, set_Runner_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Runner_0, AssignFromStack_Runner_0);


            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionBaseArgs[s]);


        }



        static object get_Runner_0(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionBaseArgs)o).Runner;
        }

        static StackObject* CopyToStack_Runner_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionBaseArgs)o).Runner;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Runner_0(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionBaseArgs)o).Runner = (Fusion.NetworkRunner)v;
        }

        static StackObject* AssignFromStack_Runner_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.NetworkRunner @Runner = (Fusion.NetworkRunner)typeof(Fusion.NetworkRunner).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.PhotonModule.Runtime.OnEventFusionBaseArgs)o).Runner = @Runner;
            return ptr_of_this_method;
        }




    }
}
#endif
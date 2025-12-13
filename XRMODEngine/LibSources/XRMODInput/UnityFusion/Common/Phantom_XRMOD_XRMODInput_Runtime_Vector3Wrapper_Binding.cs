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
    unsafe class Phantom_XRMOD_XRMODInput_Runtime_Vector3Wrapper_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODInput.Runtime.Vector3Wrapper);

            field = type.GetField("vector", flag);
            app.RegisterCLRFieldGetter(field, get_vector_0);
            app.RegisterCLRFieldSetter(field, set_vector_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_vector_0, AssignFromStack_vector_0);


            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODInput.Runtime.Vector3Wrapper[s]);

            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_vector_0(ref object o)
        {
            return ((Phantom.XRMOD.XRMODInput.Runtime.Vector3Wrapper)o).vector;
        }

        static StackObject* CopyToStack_vector_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODInput.Runtime.Vector3Wrapper)o).vector;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_vector_0(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODInput.Runtime.Vector3Wrapper)o).vector = (UnityEngine.Vector3)v;
        }

        static StackObject* AssignFromStack_vector_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3 @vector = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.XRMODInput.Runtime.Vector3Wrapper)o).vector = @vector;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @_vector = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new Phantom.XRMOD.XRMODInput.Runtime.Vector3Wrapper(@_vector);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

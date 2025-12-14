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
    unsafe class BaseFusionTypeWithChangeDetector_1_Int32_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.PhotonModule.Runtime.BaseFusionTypeWithChangeDetector<System.Int32>);

            field = type.GetField("OnChangeDetector", flag);
            app.RegisterCLRFieldGetter(field, get_OnChangeDetector_0);
            app.RegisterCLRFieldSetter(field, set_OnChangeDetector_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnChangeDetector_0, AssignFromStack_OnChangeDetector_0);


        }



        static object get_OnChangeDetector_0(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.BaseFusionTypeWithChangeDetector<System.Int32>)o).OnChangeDetector;
        }

        static StackObject* CopyToStack_OnChangeDetector_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.BaseFusionTypeWithChangeDetector<System.Int32>)o).OnChangeDetector;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnChangeDetector_0(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.BaseFusionTypeWithChangeDetector<System.Int32>)o).OnChangeDetector = (UnityEngine.Events.UnityEvent<System.String, System.Int32, System.Int32>)v;
        }

        static StackObject* AssignFromStack_OnChangeDetector_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<System.String, System.Int32, System.Int32> @OnChangeDetector = (UnityEngine.Events.UnityEvent<System.String, System.Int32, System.Int32>)typeof(UnityEngine.Events.UnityEvent<System.String, System.Int32, System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.PhotonModule.Runtime.BaseFusionTypeWithChangeDetector<System.Int32>)o).OnChangeDetector = @OnChangeDetector;
            return ptr_of_this_method;
        }



    }
}

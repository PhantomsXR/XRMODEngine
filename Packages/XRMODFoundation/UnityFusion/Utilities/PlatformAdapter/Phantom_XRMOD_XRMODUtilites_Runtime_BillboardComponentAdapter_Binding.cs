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
    unsafe class Phantom_XRMOD_XRMODUtilites_Runtime_BillboardComponentAdapter_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODUtilites.Runtime.BillboardComponentAdapter);

            field = type.GetField("BlendFactor", flag);
            app.RegisterCLRFieldGetter(field, get_BlendFactor_0);
            app.RegisterCLRFieldSetter(field, set_BlendFactor_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_BlendFactor_0, AssignFromStack_BlendFactor_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODUtilites.Runtime.BillboardComponentAdapter());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODUtilites.Runtime.BillboardComponentAdapter[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_BlendFactor_0(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.BillboardComponentAdapter)o).BlendFactor;
        }

        static StackObject* CopyToStack_BlendFactor_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.BillboardComponentAdapter)o).BlendFactor;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_BlendFactor_0(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.BillboardComponentAdapter)o).BlendFactor = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Single>)v;
        }

        static StackObject* AssignFromStack_BlendFactor_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.Core.Runtime.BindableProperty<System.Single> @BlendFactor = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Single>)typeof(Phantom.XRMOD.Core.Runtime.BindableProperty<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.BillboardComponentAdapter)o).BlendFactor = @BlendFactor;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.XRMODUtilites.Runtime.BillboardComponentAdapter();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

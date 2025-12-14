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
    unsafe class Phantom_XRMOD_XRMODUtilites_Runtime_SortingGroupComponentAdapter_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODUtilites.Runtime.SortingGroupComponentAdapter);

            field = type.GetField("DepthPass", flag);
            app.RegisterCLRFieldGetter(field, get_DepthPass_0);
            app.RegisterCLRFieldSetter(field, set_DepthPass_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_DepthPass_0, AssignFromStack_DepthPass_0);
            field = type.GetField("Renderers", flag);
            app.RegisterCLRFieldGetter(field, get_Renderers_1);
            app.RegisterCLRFieldSetter(field, set_Renderers_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Renderers_1, AssignFromStack_Renderers_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODUtilites.Runtime.SortingGroupComponentAdapter());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODUtilites.Runtime.SortingGroupComponentAdapter[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_DepthPass_0(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.SortingGroupComponentAdapter)o).DepthPass;
        }

        static StackObject* CopyToStack_DepthPass_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.SortingGroupComponentAdapter)o).DepthPass;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_DepthPass_0(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.SortingGroupComponentAdapter)o).DepthPass = (Phantom.XRMOD.Core.Runtime.BindableProperty<Phantom.XRMOD.XRMODUtilites.Runtime.SortingGroupComponentAdapter.DepthPassType>)v;
        }

        static StackObject* AssignFromStack_DepthPass_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.Core.Runtime.BindableProperty<Phantom.XRMOD.XRMODUtilites.Runtime.SortingGroupComponentAdapter.DepthPassType> @DepthPass = (Phantom.XRMOD.Core.Runtime.BindableProperty<Phantom.XRMOD.XRMODUtilites.Runtime.SortingGroupComponentAdapter.DepthPassType>)typeof(Phantom.XRMOD.Core.Runtime.BindableProperty<Phantom.XRMOD.XRMODUtilites.Runtime.SortingGroupComponentAdapter.DepthPassType>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.SortingGroupComponentAdapter)o).DepthPass = @DepthPass;
            return ptr_of_this_method;
        }

        static object get_Renderers_1(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.SortingGroupComponentAdapter)o).Renderers;
        }

        static StackObject* CopyToStack_Renderers_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.SortingGroupComponentAdapter)o).Renderers;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Renderers_1(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.SortingGroupComponentAdapter)o).Renderers = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Collections.Generic.List<Phantom.XRMOD.XRMODUtilites.Runtime.SortingGroupComponentAdapter.RendererSorting>>)v;
        }

        static StackObject* AssignFromStack_Renderers_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.Core.Runtime.BindableProperty<System.Collections.Generic.List<Phantom.XRMOD.XRMODUtilites.Runtime.SortingGroupComponentAdapter.RendererSorting>> @Renderers = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Collections.Generic.List<Phantom.XRMOD.XRMODUtilites.Runtime.SortingGroupComponentAdapter.RendererSorting>>)typeof(Phantom.XRMOD.Core.Runtime.BindableProperty<System.Collections.Generic.List<Phantom.XRMOD.XRMODUtilites.Runtime.SortingGroupComponentAdapter.RendererSorting>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.SortingGroupComponentAdapter)o).Renderers = @Renderers;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.XRMODUtilites.Runtime.SortingGroupComponentAdapter();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

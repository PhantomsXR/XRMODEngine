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
    unsafe class Phantom_XRMOD_XRMODUtilites_Runtime_StaticBatchElementComponentAdapter_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODUtilites.Runtime.StaticBatchElementComponentAdapter);

            field = type.GetField("Root", flag);
            app.RegisterCLRFieldGetter(field, get_Root_0);
            app.RegisterCLRFieldSetter(field, set_Root_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Root_0, AssignFromStack_Root_0);
            field = type.GetField("ApplyToDescendants", flag);
            app.RegisterCLRFieldGetter(field, get_ApplyToDescendants_1);
            app.RegisterCLRFieldSetter(field, set_ApplyToDescendants_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_ApplyToDescendants_1, AssignFromStack_ApplyToDescendants_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODUtilites.Runtime.StaticBatchElementComponentAdapter());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODUtilites.Runtime.StaticBatchElementComponentAdapter[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_Root_0(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.StaticBatchElementComponentAdapter)o).Root;
        }

        static StackObject* CopyToStack_Root_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.StaticBatchElementComponentAdapter)o).Root;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Root_0(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.StaticBatchElementComponentAdapter)o).Root = (Phantom.XRMOD.Core.Runtime.BindableProperty<UnityEngine.GameObject>)v;
        }

        static StackObject* AssignFromStack_Root_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.Core.Runtime.BindableProperty<UnityEngine.GameObject> @Root = (Phantom.XRMOD.Core.Runtime.BindableProperty<UnityEngine.GameObject>)typeof(Phantom.XRMOD.Core.Runtime.BindableProperty<UnityEngine.GameObject>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.StaticBatchElementComponentAdapter)o).Root = @Root;
            return ptr_of_this_method;
        }

        static object get_ApplyToDescendants_1(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.StaticBatchElementComponentAdapter)o).ApplyToDescendants;
        }

        static StackObject* CopyToStack_ApplyToDescendants_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.StaticBatchElementComponentAdapter)o).ApplyToDescendants;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ApplyToDescendants_1(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.StaticBatchElementComponentAdapter)o).ApplyToDescendants = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_ApplyToDescendants_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.Core.Runtime.BindableProperty<System.Boolean> @ApplyToDescendants = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Boolean>)typeof(Phantom.XRMOD.Core.Runtime.BindableProperty<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.StaticBatchElementComponentAdapter)o).ApplyToDescendants = @ApplyToDescendants;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.XRMODUtilites.Runtime.StaticBatchElementComponentAdapter();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

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
    unsafe class Phantom_XRMOD_XRMODInput_Runtime_XRIFilters_XRIHoverFilter_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIHoverFilter);
            args = new Type[]{typeof(System.Func<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor, UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable, System.Boolean>)};
            method = type.GetMethod("Subscribe", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Subscribe_0);
            args = new Type[]{typeof(System.Func<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor, UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable, System.Boolean>)};
            method = type.GetMethod("Unsubscribe", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Unsubscribe_1);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor), typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)};
            method = type.GetMethod("Process", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Process_2);
            args = new Type[]{};
            method = type.GetMethod("get_canProcess", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_canProcess_3);



            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIHoverFilter());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIHoverFilter[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Subscribe_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Func<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor, UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable, System.Boolean> @_processAction = (System.Func<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor, UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable, System.Boolean>)typeof(System.Func<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor, UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable, System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIHoverFilter instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIHoverFilter)typeof(Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIHoverFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Subscribe(@_processAction);

            return __ret;
        }

        static StackObject* Unsubscribe_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Func<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor, UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable, System.Boolean> @_processAction = (System.Func<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor, UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable, System.Boolean>)typeof(System.Func<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor, UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable, System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIHoverFilter instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIHoverFilter)typeof(Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIHoverFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Unsubscribe(@_processAction);

            return __ret;
        }

        static StackObject* Process_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable @_interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor @_interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIHoverFilter instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIHoverFilter)typeof(Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIHoverFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Process(@_interactor, @_interactable);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_canProcess_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIHoverFilter instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIHoverFilter)typeof(Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIHoverFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.canProcess;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIHoverFilter();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

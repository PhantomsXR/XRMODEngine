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
    unsafe class Phantom_XRMOD_XRMODInput_Runtime_XRIFilters_XRITargetFilter_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)};
            method = type.GetMethod("Link", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Link_0);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)};
            method = type.GetMethod("Unlink", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Unlink_1);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor), typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>), typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>)};
            method = type.GetMethod("Process", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Process_2);
            args = new Type[]{};
            method = type.GetMethod("get_canProcess", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_canProcess_3);

            field = type.GetField("OnLink", flag);
            app.RegisterCLRFieldGetter(field, get_OnLink_0);
            app.RegisterCLRFieldSetter(field, set_OnLink_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnLink_0, AssignFromStack_OnLink_0);
            field = type.GetField("OnUnlink", flag);
            app.RegisterCLRFieldGetter(field, get_OnUnlink_1);
            app.RegisterCLRFieldSetter(field, set_OnUnlink_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnUnlink_1, AssignFromStack_OnUnlink_1);
            field = type.GetField("TargetProcessAction", flag);
            app.RegisterCLRFieldGetter(field, get_TargetProcessAction_2);
            app.RegisterCLRFieldSetter(field, set_TargetProcessAction_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetProcessAction_2, AssignFromStack_TargetProcessAction_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Link_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor @_interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter)typeof(Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Link(@_interactor);

            return __ret;
        }

        static StackObject* Unlink_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor @_interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter)typeof(Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Unlink(@_interactor);

            return __ret;
        }

        static StackObject* Process_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable> @_results = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>)typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable> @_targets = (System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>)typeof(System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor @_interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter)typeof(Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Process(@_interactor, @_targets, @_results);

            return __ret;
        }

        static StackObject* get_canProcess_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter)typeof(Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.canProcess;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static object get_OnLink_0(ref object o)
        {
            return ((Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter)o).OnLink;
        }

        static StackObject* CopyToStack_OnLink_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter)o).OnLink;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnLink_0(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter)o).OnLink = (System.Action<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor>)v;
        }

        static StackObject* AssignFromStack_OnLink_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor> @OnLink = (System.Action<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter)o).OnLink = @OnLink;
            return ptr_of_this_method;
        }

        static object get_OnUnlink_1(ref object o)
        {
            return ((Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter)o).OnUnlink;
        }

        static StackObject* CopyToStack_OnUnlink_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter)o).OnUnlink;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnUnlink_1(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter)o).OnUnlink = (System.Action<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor>)v;
        }

        static StackObject* AssignFromStack_OnUnlink_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor> @OnUnlink = (System.Action<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter)o).OnUnlink = @OnUnlink;
            return ptr_of_this_method;
        }

        static object get_TargetProcessAction_2(ref object o)
        {
            return ((Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter)o).TargetProcessAction;
        }

        static StackObject* CopyToStack_TargetProcessAction_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter)o).TargetProcessAction;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetProcessAction_2(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter)o).TargetProcessAction = (System.Action<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor, System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>, System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>>)v;
        }

        static StackObject* AssignFromStack_TargetProcessAction_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor, System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>, System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>> @TargetProcessAction = (System.Action<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor, System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>, System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>>)typeof(System.Action<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor, System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>, System.Collections.Generic.List<UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter)o).TargetProcessAction = @TargetProcessAction;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRITargetFilter();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

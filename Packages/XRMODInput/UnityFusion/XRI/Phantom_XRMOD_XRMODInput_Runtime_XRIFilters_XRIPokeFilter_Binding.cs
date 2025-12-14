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
    unsafe class Phantom_XRMOD_XRMODInput_Runtime_XRIFilters_XRIPokeFilter_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIPokeFilter);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor), typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable), typeof(System.Single)};
            method = type.GetMethod("Process", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Process_0);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor), typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)};
            method = type.GetMethod("Process", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Process_1);
            args = new Type[]{};
            method = type.GetMethod("get_canProcess", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_canProcess_2);

            field = type.GetField("PokerFilterProcessValueAction", flag);
            app.RegisterCLRFieldGetter(field, get_PokerFilterProcessValueAction_0);
            app.RegisterCLRFieldSetter(field, set_PokerFilterProcessValueAction_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_PokerFilterProcessValueAction_0, AssignFromStack_PokerFilterProcessValueAction_0);
            field = type.GetField("PokerFilterProcessAction", flag);
            app.RegisterCLRFieldGetter(field, get_PokerFilterProcessAction_1);
            app.RegisterCLRFieldSetter(field, set_PokerFilterProcessAction_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_PokerFilterProcessAction_1, AssignFromStack_PokerFilterProcessAction_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIPokeFilter());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIPokeFilter[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Process_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @_interactionStrength = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable @_interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor @_interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIPokeFilter instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIPokeFilter)typeof(Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIPokeFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Process(@_interactor, @_interactable, @_interactionStrength);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Process_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable @_interactable = (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor @_interactor = (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIPokeFilter instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIPokeFilter)typeof(Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIPokeFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Process(@_interactor, @_interactable);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_canProcess_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIPokeFilter instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIPokeFilter)typeof(Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIPokeFilter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.canProcess;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static object get_PokerFilterProcessValueAction_0(ref object o)
        {
            return ((Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIPokeFilter)o).PokerFilterProcessValueAction;
        }

        static StackObject* CopyToStack_PokerFilterProcessValueAction_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIPokeFilter)o).PokerFilterProcessValueAction;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PokerFilterProcessValueAction_0(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIPokeFilter)o).PokerFilterProcessValueAction = (System.Func<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor, UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable, System.Single, System.Single>)v;
        }

        static StackObject* AssignFromStack_PokerFilterProcessValueAction_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Func<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor, UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable, System.Single, System.Single> @PokerFilterProcessValueAction = (System.Func<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor, UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable, System.Single, System.Single>)typeof(System.Func<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor, UnityEngine.XR.Interaction.Toolkit.Interactables.IXRInteractable, System.Single, System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIPokeFilter)o).PokerFilterProcessValueAction = @PokerFilterProcessValueAction;
            return ptr_of_this_method;
        }

        static object get_PokerFilterProcessAction_1(ref object o)
        {
            return ((Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIPokeFilter)o).PokerFilterProcessAction;
        }

        static StackObject* CopyToStack_PokerFilterProcessAction_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIPokeFilter)o).PokerFilterProcessAction;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PokerFilterProcessAction_1(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIPokeFilter)o).PokerFilterProcessAction = (System.Func<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor, UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable, System.Boolean>)v;
        }

        static StackObject* AssignFromStack_PokerFilterProcessAction_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Func<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor, UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable, System.Boolean> @PokerFilterProcessAction = (System.Func<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor, UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable, System.Boolean>)typeof(System.Func<UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor, UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable, System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIPokeFilter)o).PokerFilterProcessAction = @PokerFilterProcessAction;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.XRMODInput.Runtime.XRIFilters.XRIPokeFilter();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

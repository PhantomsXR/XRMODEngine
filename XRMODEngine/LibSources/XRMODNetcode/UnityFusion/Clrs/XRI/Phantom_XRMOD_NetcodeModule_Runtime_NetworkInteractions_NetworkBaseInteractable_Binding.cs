#if USE_XRI
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
    unsafe class Phantom_XRMOD_NetcodeModule_Runtime_NetworkInteractions_NetworkBaseInteractable_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable);
            args = new Type[] { };
            method = type.GetMethod("get_allowOverrideOwnership", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_allowOverrideOwnership_0);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_allowOverrideOwnership", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_allowOverrideOwnership_1);
            args = new Type[] { };
            method = type.GetMethod("get_interactionCheckTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_interactionCheckTime_2);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_interactionCheckTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_interactionCheckTime_3);
            args = new Type[] { };
            method = type.GetMethod("get_ignoreSocketSelectedCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ignoreSocketSelectedCallback_4);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_ignoreSocketSelectedCallback", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ignoreSocketSelectedCallback_5);
            args = new Type[] { };
            method = type.GetMethod("get_resetObjectOnDisconenct", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_resetObjectOnDisconenct_6);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_resetObjectOnDisconenct", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_resetObjectOnDisconenct_7);
            args = new Type[] { };
            method = type.GetMethod("get_relinquishOwnershipAfterTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_relinquishOwnershipAfterTime_8);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_relinquishOwnershipAfterTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_relinquishOwnershipAfterTime_9);
            args = new Type[] { };
            method = type.GetMethod("get_relinquishOwnershipTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_relinquishOwnershipTime_10);
            args = new Type[] {typeof(System.Single)};
            method = type.GetMethod("set_relinquishOwnershipTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_relinquishOwnershipTime_11);
            args = new Type[] { };
            method = type.GetMethod("get_isInteracting", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isInteracting_12);
            args = new Type[] { };
            method = type.GetMethod("get_syncHover", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_syncHover_13);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_syncHover", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_syncHover_14);
            args = new Type[] { };
            method = type.GetMethod("get_syncSelect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_syncSelect_15);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_syncSelect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_syncSelect_16);
            args = new Type[] { };
            method = type.GetMethod("get_syncActivate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_syncActivate_17);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_syncActivate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_syncActivate_18);
            args = new Type[] { };
            method = type.GetMethod("get_baseInteractable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_baseInteractable_19);
            args = new Type[] {typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)};
            method = type.GetMethod("set_baseInteractable", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_baseInteractable_20);
            args = new Type[] { };
            method = type.GetMethod("get_canProcess", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_canProcess_21);
            args = new Type[] { };
            method = type.GetMethod("Awake", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Awake_22);
            args = new Type[] { };
            method = type.GetMethod("OnNetworkSpawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkSpawn_23);
            args = new Type[] { };
            method = type.GetMethod("OnNetworkDespawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkDespawn_24);
            args = new Type[] { };
            method = type.GetMethod("ResetObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResetObject_25);
            args = new Type[] {typeof(UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs)};
            method = type.GetMethod("OnHoverEnterLocal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnHoverEnterLocal_26);
            args = new Type[] {typeof(UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs)};
            method = type.GetMethod("OnHoverExitLocal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnHoverExitLocal_27);
            args = new Type[] {typeof(System.Boolean), typeof(System.UInt64)};
            method = type.GetMethod("OnHoverServerRpc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnHoverServerRpc_28);
            args = new Type[] {typeof(System.Boolean), typeof(System.UInt64)};
            method = type.GetMethod("OnHoverClientRpc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnHoverClientRpc_29);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("Hovered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Hovered_30);
            args = new Type[] {typeof(UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs)};
            method = type.GetMethod("OnSelectEnteredLocal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnSelectEnteredLocal_31);
            args = new Type[] {typeof(UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs)};
            method = type.GetMethod("OnSelectExitedLocal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnSelectExitedLocal_32);
            args = new Type[] {typeof(System.Boolean), typeof(System.UInt64)};
            method = type.GetMethod("OnSelectServerRpc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnSelectServerRpc_33);
            args = new Type[] {typeof(System.Boolean), typeof(System.UInt64)};
            method = type.GetMethod("OnSelectClientRpc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnSelectClientRpc_34);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("Selected", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Selected_35);
            args = new Type[] {typeof(UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs)};
            method = type.GetMethod("OnActivateLocal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnActivateLocal_36);
            args = new Type[] {typeof(UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs)};
            method = type.GetMethod("OnDeactivateLocal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnDeactivateLocal_37);
            args = new Type[] {typeof(System.Boolean), typeof(System.UInt64)};
            method = type.GetMethod("OnActivateServerRpc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnActivateServerRpc_38);
            args = new Type[] {typeof(System.Boolean), typeof(System.UInt64)};
            method = type.GetMethod("OnActivateClientRpc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnActivateClientRpc_39);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("Activated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Activated_40);
            args = new Type[] { };
            method = type.GetMethod("OnGainedOwnership", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnGainedOwnership_41);
            args = new Type[] { };
            method = type.GetMethod("OnLostOwnership", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnLostOwnership_42);
            args = new Type[]
            {
                typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor),
                typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)
            };
            method = type.GetMethod("Process", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Process_43);
            args = new Type[]
            {
                typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor),
                typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)
            };
            method = type.GetMethod("Process", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Process_44);

            field = type.GetField("OnInteractingChanged", flag);
            app.RegisterCLRFieldGetter(field, get_OnInteractingChanged_0);
            app.RegisterCLRFieldSetter(field, set_OnInteractingChanged_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnInteractingChanged_0,
                AssignFromStack_OnInteractingChanged_0);
            field = type.GetField("HoverNetworkedEventServer", flag);
            app.RegisterCLRFieldGetter(field, get_HoverNetworkedEventServer_1);
            app.RegisterCLRFieldSetter(field, set_HoverNetworkedEventServer_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_HoverNetworkedEventServer_1,
                AssignFromStack_HoverNetworkedEventServer_1);
            field = type.GetField("HoverNetworkedEventAll", flag);
            app.RegisterCLRFieldGetter(field, get_HoverNetworkedEventAll_2);
            app.RegisterCLRFieldSetter(field, set_HoverNetworkedEventAll_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_HoverNetworkedEventAll_2,
                AssignFromStack_HoverNetworkedEventAll_2);
            field = type.GetField("SelectNetworkedEventServer", flag);
            app.RegisterCLRFieldGetter(field, get_SelectNetworkedEventServer_3);
            app.RegisterCLRFieldSetter(field, set_SelectNetworkedEventServer_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_SelectNetworkedEventServer_3,
                AssignFromStack_SelectNetworkedEventServer_3);
            field = type.GetField("SelectNetworkedEventAll", flag);
            app.RegisterCLRFieldGetter(field, get_SelectNetworkedEventAll_4);
            app.RegisterCLRFieldSetter(field, set_SelectNetworkedEventAll_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_SelectNetworkedEventAll_4,
                AssignFromStack_SelectNetworkedEventAll_4);
            field = type.GetField("ActivateNetworkedEventServer", flag);
            app.RegisterCLRFieldGetter(field, get_ActivateNetworkedEventServer_5);
            app.RegisterCLRFieldSetter(field, set_ActivateNetworkedEventServer_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_ActivateNetworkedEventServer_5,
                AssignFromStack_ActivateNetworkedEventServer_5);
            field = type.GetField("ActivateNetworkedEventAll", flag);
            app.RegisterCLRFieldGetter(field, get_ActivateNetworkedEventAll_6);
            app.RegisterCLRFieldSetter(field, set_ActivateNetworkedEventAll_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_ActivateNetworkedEventAll_6,
                AssignFromStack_ActivateNetworkedEventAll_6);


            app.RegisterCLRCreateDefaultInstance(type,
                () => new Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable());
            app.RegisterCLRCreateArrayInstance(type,
                s => new Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable[s]);

            args = new Type[] { };
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static StackObject* get_allowOverrideOwnership_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.allowOverrideOwnership;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_allowOverrideOwnership_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.allowOverrideOwnership = value;

            return __ret;
        }

        static StackObject* get_interactionCheckTime_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.interactionCheckTime;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_interactionCheckTime_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.interactionCheckTime = value;

            return __ret;
        }

        static StackObject* get_ignoreSocketSelectedCallback_4(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ignoreSocketSelectedCallback;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_ignoreSocketSelectedCallback_5(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ignoreSocketSelectedCallback = value;

            return __ret;
        }

        static StackObject* get_resetObjectOnDisconenct_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.resetObjectOnDisconenct;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_resetObjectOnDisconenct_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.resetObjectOnDisconenct = value;

            return __ret;
        }

        static StackObject* get_relinquishOwnershipAfterTime_8(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.relinquishOwnershipAfterTime;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_relinquishOwnershipAfterTime_9(ILIntepreter __intp, StackObject* __esp,
            AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.relinquishOwnershipAfterTime = value;

            return __ret;
        }

        static StackObject* get_relinquishOwnershipTime_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.relinquishOwnershipTime;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*) &__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_relinquishOwnershipTime_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.relinquishOwnershipTime = value;

            return __ret;
        }

        static StackObject* get_isInteracting_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isInteracting;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_syncHover_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.syncHover;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_syncHover_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.syncHover = value;

            return __ret;
        }

        static StackObject* get_syncSelect_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.syncSelect;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_syncSelect_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.syncSelect = value;

            return __ret;
        }

        static StackObject* get_syncActivate_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.syncActivate;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_syncActivate_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.syncActivate = value;

            return __ret;
        }

        static StackObject* get_baseInteractable_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.baseInteractable;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_baseInteractable_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable @value =
                (UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable)
                typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.XRBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.baseInteractable = value;

            return __ret;
        }

        static StackObject* get_canProcess_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.canProcess;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Awake_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Awake();

            return __ret;
        }

        static StackObject* OnNetworkSpawn_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkSpawn();

            return __ret;
        }

        static StackObject* OnNetworkDespawn_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkDespawn();

            return __ret;
        }

        static StackObject* ResetObject_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ResetObject();

            return __ret;
        }

        static StackObject* OnHoverEnterLocal_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs @args =
                (UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs)
                typeof(UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnHoverEnterLocal(@args);

            return __ret;
        }

        static StackObject* OnHoverExitLocal_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs @args =
                (UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs)
                typeof(UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnHoverExitLocal(@args);

            return __ret;
        }

        static StackObject* OnHoverServerRpc_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @clientId = *(ulong*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @entered = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnHoverServerRpc(@entered, @clientId);

            return __ret;
        }

        static StackObject* OnHoverClientRpc_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @clientId = *(ulong*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @entered = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnHoverClientRpc(@entered, @clientId);

            return __ret;
        }

        static StackObject* Hovered_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @entered = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Hovered(@entered);

            return __ret;
        }

        static StackObject* OnSelectEnteredLocal_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs @args =
                (UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs)
                typeof(UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnSelectEnteredLocal(@args);

            return __ret;
        }

        static StackObject* OnSelectExitedLocal_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs @args =
                (UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs)
                typeof(UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnSelectExitedLocal(@args);

            return __ret;
        }

        static StackObject* OnSelectServerRpc_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @clientId = *(ulong*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @selected = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnSelectServerRpc(@selected, @clientId);

            return __ret;
        }

        static StackObject* OnSelectClientRpc_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @clientId = *(ulong*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @selected = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnSelectClientRpc(@selected, @clientId);

            return __ret;
        }

        static StackObject* Selected_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @selected = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Selected(@selected);

            return __ret;
        }

        static StackObject* OnActivateLocal_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs @args =
                (UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs)
                typeof(UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnActivateLocal(@args);

            return __ret;
        }

        static StackObject* OnDeactivateLocal_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs @args =
                (UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs)
                typeof(UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnDeactivateLocal(@args);

            return __ret;
        }

        static StackObject* OnActivateServerRpc_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @clientId = *(ulong*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @activate = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnActivateServerRpc(@activate, @clientId);

            return __ret;
        }

        static StackObject* OnActivateClientRpc_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @clientId = *(ulong*) &ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @activate = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnActivateClientRpc(@activate, @clientId);

            return __ret;
        }

        static StackObject* Activated_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @activate = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Activated(@activate);

            return __ret;
        }

        static StackObject* OnGainedOwnership_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnGainedOwnership();

            return __ret;
        }

        static StackObject* OnLostOwnership_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnLostOwnership();

            return __ret;
        }

        static StackObject* Process_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable @interactable =
                (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable)
                typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRSelectInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor @interactor =
                (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor)
                typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRSelectInteractor).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Process(@interactor, @interactable);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Process_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable @interactable =
                (UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable)
                typeof(UnityEngine.XR.Interaction.Toolkit.Interactables.IXRHoverInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor @interactor =
                (UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor)
                typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRHoverInteractor).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Process(@interactor, @interactable);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static object get_OnInteractingChanged_0(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .OnInteractingChanged;
        }

        static StackObject* CopyToStack_OnInteractingChanged_0(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method =
                ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .OnInteractingChanged;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnInteractingChanged_0(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o).OnInteractingChanged =
                (UnityEngine.Events.UnityEvent<System.Boolean>) v;
        }

        static StackObject* AssignFromStack_OnInteractingChanged_0(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<System.Boolean> @OnInteractingChanged =
                (UnityEngine.Events.UnityEvent<System.Boolean>) typeof(UnityEngine.Events.UnityEvent<System.Boolean>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o).OnInteractingChanged =
                @OnInteractingChanged;
            return ptr_of_this_method;
        }

        static object get_HoverNetworkedEventServer_1(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .HoverNetworkedEventServer;
        }

        static StackObject* CopyToStack_HoverNetworkedEventServer_1(ref object o, ILIntepreter __intp,
            StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method =
                ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .HoverNetworkedEventServer;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_HoverNetworkedEventServer_1(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .HoverNetworkedEventServer = (UnityEngine.Events.UnityEvent<System.Boolean>) v;
        }

        static StackObject* AssignFromStack_HoverNetworkedEventServer_1(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<System.Boolean> @HoverNetworkedEventServer =
                (UnityEngine.Events.UnityEvent<System.Boolean>) typeof(UnityEngine.Events.UnityEvent<System.Boolean>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .HoverNetworkedEventServer = @HoverNetworkedEventServer;
            return ptr_of_this_method;
        }

        static object get_HoverNetworkedEventAll_2(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .HoverNetworkedEventAll;
        }

        static StackObject* CopyToStack_HoverNetworkedEventAll_2(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method =
                ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .HoverNetworkedEventAll;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_HoverNetworkedEventAll_2(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .HoverNetworkedEventAll = (UnityEngine.Events.UnityEvent<System.Boolean>) v;
        }

        static StackObject* AssignFromStack_HoverNetworkedEventAll_2(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<System.Boolean> @HoverNetworkedEventAll =
                (UnityEngine.Events.UnityEvent<System.Boolean>) typeof(UnityEngine.Events.UnityEvent<System.Boolean>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .HoverNetworkedEventAll = @HoverNetworkedEventAll;
            return ptr_of_this_method;
        }

        static object get_SelectNetworkedEventServer_3(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .SelectNetworkedEventServer;
        }

        static StackObject* CopyToStack_SelectNetworkedEventServer_3(ref object o, ILIntepreter __intp,
            StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method =
                ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .SelectNetworkedEventServer;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_SelectNetworkedEventServer_3(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .SelectNetworkedEventServer = (UnityEngine.Events.UnityEvent<System.Boolean>) v;
        }

        static StackObject* AssignFromStack_SelectNetworkedEventServer_3(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<System.Boolean> @SelectNetworkedEventServer =
                (UnityEngine.Events.UnityEvent<System.Boolean>) typeof(UnityEngine.Events.UnityEvent<System.Boolean>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .SelectNetworkedEventServer = @SelectNetworkedEventServer;
            return ptr_of_this_method;
        }

        static object get_SelectNetworkedEventAll_4(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .SelectNetworkedEventAll;
        }

        static StackObject* CopyToStack_SelectNetworkedEventAll_4(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method =
                ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .SelectNetworkedEventAll;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_SelectNetworkedEventAll_4(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .SelectNetworkedEventAll = (UnityEngine.Events.UnityEvent<System.Boolean>) v;
        }

        static StackObject* AssignFromStack_SelectNetworkedEventAll_4(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<System.Boolean> @SelectNetworkedEventAll =
                (UnityEngine.Events.UnityEvent<System.Boolean>) typeof(UnityEngine.Events.UnityEvent<System.Boolean>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .SelectNetworkedEventAll = @SelectNetworkedEventAll;
            return ptr_of_this_method;
        }

        static object get_ActivateNetworkedEventServer_5(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .ActivateNetworkedEventServer;
        }

        static StackObject* CopyToStack_ActivateNetworkedEventServer_5(ref object o, ILIntepreter __intp,
            StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method =
                ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .ActivateNetworkedEventServer;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ActivateNetworkedEventServer_5(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .ActivateNetworkedEventServer = (UnityEngine.Events.UnityEvent<System.Boolean>) v;
        }

        static StackObject* AssignFromStack_ActivateNetworkedEventServer_5(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<System.Boolean> @ActivateNetworkedEventServer =
                (UnityEngine.Events.UnityEvent<System.Boolean>) typeof(UnityEngine.Events.UnityEvent<System.Boolean>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .ActivateNetworkedEventServer = @ActivateNetworkedEventServer;
            return ptr_of_this_method;
        }

        static object get_ActivateNetworkedEventAll_6(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .ActivateNetworkedEventAll;
        }

        static StackObject* CopyToStack_ActivateNetworkedEventAll_6(ref object o, ILIntepreter __intp,
            StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method =
                ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .ActivateNetworkedEventAll;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ActivateNetworkedEventAll_6(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .ActivateNetworkedEventAll = (UnityEngine.Events.UnityEvent<System.Boolean>) v;
        }

        static StackObject* AssignFromStack_ActivateNetworkedEventAll_6(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<System.Boolean> @ActivateNetworkedEventAll =
                (UnityEngine.Events.UnityEvent<System.Boolean>) typeof(UnityEngine.Events.UnityEvent<System.Boolean>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable) o)
                .ActivateNetworkedEventAll = @ActivateNetworkedEventAll;
            return ptr_of_this_method;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method =
                new Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkBaseInteractable();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}
#endif
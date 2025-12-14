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
    unsafe class Phantom_XRMOD_NetcodeModule_Runtime_NetworkInteractions_NetworkPhysicsInteractable_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable);
            args = new Type[]{};
            method = type.GetMethod("get_lockedOnSpawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lockedOnSpawn_0);
            args = new Type[]{};
            method = type.GetMethod("Awake", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Awake_1);
            args = new Type[]{};
            method = type.GetMethod("OnNetworkSpawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkSpawn_2);
            args = new Type[]{};
            method = type.GetMethod("OnNetworkDespawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkDespawn_3);
            args = new Type[]{};
            method = type.GetMethod("ResetObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResetObject_4);
            args = new Type[]{};
            method = type.GetMethod("ResetObjectPhysics", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResetObjectPhysics_5);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs)};
            method = type.GetMethod("OnSelectEnteredLocal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnSelectEnteredLocal_6);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs)};
            method = type.GetMethod("OnSelectExitedLocal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnSelectExitedLocal_7);
            args = new Type[]{};
            method = type.GetMethod("OnGainedOwnership", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnGainedOwnership_8);
            args = new Type[]{};
            method = type.GetMethod("OnLostOwnership", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnLostOwnership_9);
            args = new Type[]{};
            method = type.GetMethod("OwnershipTransferBlocked", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OwnershipTransferBlocked_10);
            args = new Type[]{};
            method = type.GetMethod("RequestOwnership", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RequestOwnership_11);

            field = type.GetField("spawnLocked", flag);
            app.RegisterCLRFieldGetter(field, get_spawnLocked_0);
            app.RegisterCLRFieldSetter(field, set_spawnLocked_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_spawnLocked_0, AssignFromStack_spawnLocked_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_lockedOnSpawn_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lockedOnSpawn;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Awake_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Awake();

            return __ret;
        }

        static StackObject* OnNetworkSpawn_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkSpawn();

            return __ret;
        }

        static StackObject* OnNetworkDespawn_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkDespawn();

            return __ret;
        }

        static StackObject* ResetObject_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ResetObject();

            return __ret;
        }

        static StackObject* ResetObjectPhysics_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ResetObjectPhysics();

            return __ret;
        }

        static StackObject* OnSelectEnteredLocal_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs @args = (UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs)typeof(UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnSelectEnteredLocal(@args);

            return __ret;
        }

        static StackObject* OnSelectExitedLocal_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs @args = (UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs)typeof(UnityEngine.XR.Interaction.Toolkit.BaseInteractionEventArgs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnSelectExitedLocal(@args);

            return __ret;
        }

        static StackObject* OnGainedOwnership_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnGainedOwnership();

            return __ret;
        }

        static StackObject* OnLostOwnership_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnLostOwnership();

            return __ret;
        }

        static StackObject* OwnershipTransferBlocked_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.OwnershipTransferBlocked();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RequestOwnership_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RequestOwnership();

            return __ret;
        }


        static object get_spawnLocked_0(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable)o).spawnLocked;
        }

        static StackObject* CopyToStack_spawnLocked_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable)o).spawnLocked;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_spawnLocked_0(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable)o).spawnLocked = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_spawnLocked_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @spawnLocked = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable)o).spawnLocked = @spawnLocked;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.NetcodeModule.Runtime.NetworkInteractions.NetworkPhysicsInteractable();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
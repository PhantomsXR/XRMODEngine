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
    unsafe class Phantom_XRMOD_NetcodeModule_Runtime_TableSystem_NetworkTableTopManager_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem);
            args = new Type[] { };
            method = type.GetMethod("get_MaxSeat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_MaxSeat_0);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("set_MaxSeat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_MaxSeat_1);
            args = new Type[] { };
            method = type.GetMethod("get_TableSeatSystem", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_TableSeatSystem_2);
            args = new Type[] { };
            method = type.GetMethod("get_TableTop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_TableTop_3);
            args = new Type[] { };
            method = type.GetMethod("OnNetworkSpawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkSpawn_4);
            args = new Type[] { };
            method = type.GetMethod("OnNetworkDespawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkDespawn_5);
            args = new Type[] {typeof(ulong)};
            method = type.GetMethod("RequestAnySeat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RequestAnySeat_6);
            args = new Type[] {typeof(System.Int32)};
            method = type.GetMethod("RequestSeat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RequestSeat_7);


            field = type.GetField("PlayerListNetworkVariable", flag);
            app.RegisterCLRFieldGetter(field, get_PlayerListNetworkVariable_1);
            app.RegisterCLRFieldSetter(field, set_PlayerListNetworkVariable_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_PlayerListNetworkVariable_1,
                AssignFromStack_PlayerListNetworkVariable_1);
            field = type.GetField("OnJoinSeat", flag);
            app.RegisterCLRFieldGetter(field, get_OnJoinSeat_2);
            app.RegisterCLRFieldSetter(field, set_OnJoinSeat_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnJoinSeat_2, AssignFromStack_OnJoinSeat_2);
            field = type.GetField("OnLeaveSeat", flag);
            app.RegisterCLRFieldGetter(field, get_OnLeaveSeat_3);
            app.RegisterCLRFieldSetter(field, set_OnLeaveSeat_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnLeaveSeat_3, AssignFromStack_OnLeaveSeat_3);
            field = type.GetField("OnOccupiedSeatsChange", flag);
            app.RegisterCLRFieldGetter(field, get_OnOccupiedSeatsChange_4);
            app.RegisterCLRFieldSetter(field, set_OnOccupiedSeatsChange_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnOccupiedSeatsChange_4,
                AssignFromStack_OnOccupiedSeatsChange_4);
            field = type.GetField("OnPlayerStateChanged", flag);
            app.RegisterCLRFieldGetter(field, get_OnPlayerStateChanged_5);
            app.RegisterCLRFieldSetter(field, set_OnPlayerStateChanged_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnPlayerStateChanged_5,
                AssignFromStack_OnPlayerStateChanged_5);


            app.RegisterCLRCreateDefaultInstance(type,
                () => new Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem());
            app.RegisterCLRCreateArrayInstance(type,
                s => new Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem[s]);

            args = new Type[] { };
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static StackObject* get_MaxSeat_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MaxSeat;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_MaxSeat_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MaxSeat = value;

            return __ret;
        }

        static StackObject* get_TableSeatSystem_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TableSeatSystem;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_TableTop_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TableTop;

            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OnNetworkSpawn_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkSpawn();

            return __ret;
        }

        static StackObject* OnNetworkDespawn_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkDespawn();

            return __ret;
        }

        static StackObject* RequestAnySeat_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ulong @_playerRef = (ulong) typeof(ulong).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RequestAnySeat(@_playerRef);

            return __ret;
        }

        static StackObject* RequestSeat_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @_newSeatChoice = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem instance_of_this_method =
                (Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RequestSeat(@_newSeatChoice);

            return __ret;
        }


        static object get_PlayerListNetworkVariable_1(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem) o)
                .PlayerListNetworkVariable;
        }

        static StackObject* CopyToStack_PlayerListNetworkVariable_1(ref object o, ILIntepreter __intp,
            StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem) o)
                .PlayerListNetworkVariable;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PlayerListNetworkVariable_1(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem) o).PlayerListNetworkVariable =
                (Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable) v;
        }

        static StackObject* AssignFromStack_PlayerListNetworkVariable_1(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable @PlayerListNetworkVariable =
                (Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable)
                typeof(Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem) o).PlayerListNetworkVariable =
                @PlayerListNetworkVariable;
            return ptr_of_this_method;
        }

        static object get_OnJoinSeat_2(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem) o).OnJoinSeat;
        }

        static StackObject* CopyToStack_OnJoinSeat_2(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method =
                ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem) o).OnJoinSeat;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnJoinSeat_2(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem) o).OnJoinSeat =
                (UnityEngine.Events.UnityEvent) v;
        }

        static StackObject* AssignFromStack_OnJoinSeat_2(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent @OnJoinSeat =
                (UnityEngine.Events.UnityEvent) typeof(UnityEngine.Events.UnityEvent).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem) o).OnJoinSeat = @OnJoinSeat;
            return ptr_of_this_method;
        }

        static object get_OnLeaveSeat_3(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem) o).OnLeaveSeat;
        }

        static StackObject* CopyToStack_OnLeaveSeat_3(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem) o)
                .OnLeaveSeat;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnLeaveSeat_3(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem) o).OnLeaveSeat =
                (UnityEngine.Events.UnityEvent<System.Int32>) v;
        }

        static StackObject* AssignFromStack_OnLeaveSeat_3(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<System.Int32> @OnLeaveSeat =
                (UnityEngine.Events.UnityEvent<System.Int32>) typeof(UnityEngine.Events.UnityEvent<System.Int32>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem) o).OnLeaveSeat =
                @OnLeaveSeat;
            return ptr_of_this_method;
        }

        static object get_OnOccupiedSeatsChange_4(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem) o).OnOccupiedSeatsChange;
        }

        static StackObject* CopyToStack_OnOccupiedSeatsChange_4(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem) o)
                .OnOccupiedSeatsChange;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnOccupiedSeatsChange_4(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem) o).OnOccupiedSeatsChange =
                (UnityEngine.Events.UnityEvent<Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.NetworkedSeat,
                    Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.NetworkedSeat>) v;
        }

        static StackObject* AssignFromStack_OnOccupiedSeatsChange_4(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.NetworkedSeat,
                Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.NetworkedSeat> @OnOccupiedSeatsChange =
                (UnityEngine.Events.UnityEvent<Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.NetworkedSeat,
                    Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.NetworkedSeat>)
                typeof(UnityEngine.Events.UnityEvent<Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.NetworkedSeat,
                    Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.NetworkedSeat>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem) o).OnOccupiedSeatsChange =
                @OnOccupiedSeatsChange;
            return ptr_of_this_method;
        }

        static object get_OnPlayerStateChanged_5(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem) o).OnPlayerStateChanged;
        }

        static StackObject* CopyToStack_OnPlayerStateChanged_5(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem) o)
                .OnPlayerStateChanged;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnPlayerStateChanged_5(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem) o).OnPlayerStateChanged =
                (System.Action<ulong, System.Boolean>) v;
        }

        static StackObject* AssignFromStack_OnPlayerStateChanged_5(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<ulong, System.Boolean> @OnPlayerStateChanged =
                (System.Action<ulong, System.Boolean>) typeof(System.Action<ulong, System.Boolean>).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 8);
            ((Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem) o).OnPlayerStateChanged =
                @OnPlayerStateChanged;
            return ptr_of_this_method;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.NetcodeModule.Runtime.TableSystem.TableTopNetworkedSystem();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}
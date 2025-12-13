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
    unsafe class Phantom_XRMOD_NetcodeModule_Runtime_PlayerListNetworkVariable_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable);
            args = new Type[]{};
            method = type.GetMethod("get_Count", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Count_0);
            args = new Type[]{typeof(System.Action<Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase>)};
            method = type.GetMethod("add_OnPlayerAdded", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnPlayerAdded_1);
            args = new Type[]{typeof(System.Action<Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase>)};
            method = type.GetMethod("remove_OnPlayerAdded", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnPlayerAdded_2);
            args = new Type[]{typeof(System.Action<System.UInt64>)};
            method = type.GetMethod("add_OnPlayerRemoved", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnPlayerRemoved_3);
            args = new Type[]{typeof(System.Action<System.UInt64>)};
            method = type.GetMethod("remove_OnPlayerRemoved", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnPlayerRemoved_4);
            args = new Type[]{};
            method = type.GetMethod("OnNetworkDespawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkDespawn_5);
            args = new Type[]{};
            method = type.GetMethod("get_GetPlayerList", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GetPlayerList_6);
            args = new Type[]{typeof(System.UInt64)};
            method = type.GetMethod("GetPlayer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPlayer_7);
            args = new Type[]{typeof(System.UInt64)};
            method = type.GetMethod("JoinPlayer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, JoinPlayer_8);
            args = new Type[]{typeof(System.UInt64)};
            method = type.GetMethod("LeavePlayer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, LeavePlayer_9);
            args = new Type[]{};
            method = type.GetMethod("get_AllNgoPlayers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_AllNgoPlayers_10);
            args = new Type[]{};
            method = type.GetMethod("get_AllPlayersReady", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_AllPlayersReady_11);
            args = new Type[]{};
            method = type.GetMethod("Dispose", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Dispose_12);

            field = type.GetField("PlayerList", flag);
            app.RegisterCLRFieldGetter(field, get_PlayerList_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_PlayerList_0, null);
            field = type.GetField("OnValueChanged", flag);
            app.RegisterCLRFieldGetter(field, get_OnValueChanged_1);
            app.RegisterCLRFieldSetter(field, set_OnValueChanged_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnValueChanged_1, AssignFromStack_OnValueChanged_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_Count_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Count;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* add_OnPlayerAdded_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase> @value = (System.Action<Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase>)typeof(System.Action<Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnPlayerAdded += value;

            return __ret;
        }

        static StackObject* remove_OnPlayerAdded_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase> @value = (System.Action<Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase>)typeof(System.Action<Phantom.XRMOD.NetcodeModule.Runtime.Gameplay.NGOPlayerBase>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnPlayerAdded -= value;

            return __ret;
        }

        static StackObject* add_OnPlayerRemoved_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.UInt64> @value = (System.Action<System.UInt64>)typeof(System.Action<System.UInt64>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnPlayerRemoved += value;

            return __ret;
        }

        static StackObject* remove_OnPlayerRemoved_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<System.UInt64> @value = (System.Action<System.UInt64>)typeof(System.Action<System.UInt64>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnPlayerRemoved -= value;

            return __ret;
        }

        static StackObject* OnNetworkDespawn_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkDespawn();

            return __ret;
        }

        static StackObject* get_GetPlayerList_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPlayerList;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPlayer_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @_playerId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPlayer(@_playerId);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* JoinPlayer_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @_playerId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.JoinPlayer(@_playerId);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* LeavePlayer_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @_playerId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.LeavePlayer(@_playerId);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_AllNgoPlayers_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AllNgoPlayers;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_AllPlayersReady_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AllPlayersReady;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Dispose_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Dispose();

            return __ret;
        }


        static object get_PlayerList_0(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable)o).PlayerList;
        }

        static StackObject* CopyToStack_PlayerList_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable)o).PlayerList;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OnValueChanged_1(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable)o).OnValueChanged;
        }

        static StackObject* CopyToStack_OnValueChanged_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable)o).OnValueChanged;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnValueChanged_1(ref object o, object v)
        {
            ((Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable)o).OnValueChanged = (UnityEngine.Events.UnityEvent<Unity.Netcode.NetworkListEvent<Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry>>)v;
        }

        static StackObject* AssignFromStack_OnValueChanged_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<Unity.Netcode.NetworkListEvent<Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry>> @OnValueChanged = (UnityEngine.Events.UnityEvent<Unity.Netcode.NetworkListEvent<Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry>>)typeof(UnityEngine.Events.UnityEvent<Unity.Netcode.NetworkListEvent<Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable)o).OnValueChanged = @OnValueChanged;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.NetcodeModule.Runtime.PlayerListNetworkVariable();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

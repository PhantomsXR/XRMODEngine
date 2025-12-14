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
    unsafe class Unity_Netcode_NetworkSpawnManager_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Netcode.NetworkSpawnManager);
            args = new Type[]{};
            method = type.GetMethod("get_PlayerObjects", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_PlayerObjects_0);
            args = new Type[]{};
            method = type.GetMethod("GetConnectedPlayers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetConnectedPlayers_1);
            args = new Type[]{typeof(System.UInt64)};
            method = type.GetMethod("GetClientOwnedObjects", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetClientOwnedObjects_2);
            args = new Type[]{};
            method = type.GetMethod("get_NetworkManager", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_NetworkManager_3);
            args = new Type[]{};
            method = type.GetMethod("GetLocalPlayerObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetLocalPlayerObject_4);
            args = new Type[]{typeof(System.UInt64)};
            method = type.GetMethod("GetPlayerNetworkObjects", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPlayerNetworkObjects_5);
            args = new Type[]{typeof(System.UInt64)};
            method = type.GetMethod("GetPlayerNetworkObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPlayerNetworkObject_6);
            args = new Type[]{typeof(Unity.Netcode.NetworkObject), typeof(System.UInt64), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(UnityEngine.Vector3), typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("InstantiateAndSpawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InstantiateAndSpawn_7);

            field = type.GetField("SpawnedObjects", flag);
            app.RegisterCLRFieldGetter(field, get_SpawnedObjects_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_SpawnedObjects_0, null);
            field = type.GetField("SpawnedObjectsList", flag);
            app.RegisterCLRFieldGetter(field, get_SpawnedObjectsList_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_SpawnedObjectsList_1, null);
            field = type.GetField("OwnershipToObjectsTable", flag);
            app.RegisterCLRFieldGetter(field, get_OwnershipToObjectsTable_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_OwnershipToObjectsTable_2, null);


            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Netcode.NetworkSpawnManager[s]);


        }


        static StackObject* get_PlayerObjects_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkSpawnManager instance_of_this_method = (Unity.Netcode.NetworkSpawnManager)typeof(Unity.Netcode.NetworkSpawnManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.PlayerObjects;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetConnectedPlayers_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkSpawnManager instance_of_this_method = (Unity.Netcode.NetworkSpawnManager)typeof(Unity.Netcode.NetworkSpawnManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetConnectedPlayers();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetClientOwnedObjects_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @clientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkSpawnManager instance_of_this_method = (Unity.Netcode.NetworkSpawnManager)typeof(Unity.Netcode.NetworkSpawnManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetClientOwnedObjects(@clientId);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_NetworkManager_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkSpawnManager instance_of_this_method = (Unity.Netcode.NetworkSpawnManager)typeof(Unity.Netcode.NetworkSpawnManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.NetworkManager;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetLocalPlayerObject_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkSpawnManager instance_of_this_method = (Unity.Netcode.NetworkSpawnManager)typeof(Unity.Netcode.NetworkSpawnManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetLocalPlayerObject();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPlayerNetworkObjects_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @clientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkSpawnManager instance_of_this_method = (Unity.Netcode.NetworkSpawnManager)typeof(Unity.Netcode.NetworkSpawnManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPlayerNetworkObjects(@clientId);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPlayerNetworkObject_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt64 @clientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkSpawnManager instance_of_this_method = (Unity.Netcode.NetworkSpawnManager)typeof(Unity.Netcode.NetworkSpawnManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPlayerNetworkObject(@clientId);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* InstantiateAndSpawn_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 8);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @forceOverride = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean @isPlayerObject = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Boolean @destroyWithScene = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.UInt64 @ownerClientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            Unity.Netcode.NetworkObject @networkPrefab = (Unity.Netcode.NetworkObject)typeof(Unity.Netcode.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            Unity.Netcode.NetworkSpawnManager instance_of_this_method = (Unity.Netcode.NetworkSpawnManager)typeof(Unity.Netcode.NetworkSpawnManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.InstantiateAndSpawn(@networkPrefab, @ownerClientId, @destroyWithScene, @isPlayerObject, @forceOverride, @position, @rotation);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_SpawnedObjects_0(ref object o)
        {
            return ((Unity.Netcode.NetworkSpawnManager)o).SpawnedObjects;
        }

        static StackObject* CopyToStack_SpawnedObjects_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkSpawnManager)o).SpawnedObjects;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_SpawnedObjectsList_1(ref object o)
        {
            return ((Unity.Netcode.NetworkSpawnManager)o).SpawnedObjectsList;
        }

        static StackObject* CopyToStack_SpawnedObjectsList_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkSpawnManager)o).SpawnedObjectsList;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OwnershipToObjectsTable_2(ref object o)
        {
            return ((Unity.Netcode.NetworkSpawnManager)o).OwnershipToObjectsTable;
        }

        static StackObject* CopyToStack_OwnershipToObjectsTable_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkSpawnManager)o).OwnershipToObjectsTable;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }




    }
}

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
    unsafe class Unity_Netcode_NetworkPrefabs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Netcode.NetworkPrefabs);
            args = new Type[]{};
            method = type.GetMethod("get_Prefabs", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Prefabs_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("Initialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Initialize_1);
            args = new Type[]{typeof(Unity.Netcode.NetworkPrefab)};
            method = type.GetMethod("Add", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Add_2);
            args = new Type[]{typeof(Unity.Netcode.NetworkPrefab)};
            method = type.GetMethod("Remove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Remove_3);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("Remove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Remove_4);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("Contains", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Contains_5);
            args = new Type[]{typeof(Unity.Netcode.NetworkPrefab)};
            method = type.GetMethod("Contains", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Contains_6);

            field = type.GetField("NetworkPrefabsLists", flag);
            app.RegisterCLRFieldGetter(field, get_NetworkPrefabsLists_0);
            app.RegisterCLRFieldSetter(field, set_NetworkPrefabsLists_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_NetworkPrefabsLists_0, AssignFromStack_NetworkPrefabsLists_0);
            field = type.GetField("NetworkPrefabOverrideLinks", flag);
            app.RegisterCLRFieldGetter(field, get_NetworkPrefabOverrideLinks_1);
            app.RegisterCLRFieldSetter(field, set_NetworkPrefabOverrideLinks_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_NetworkPrefabOverrideLinks_1, AssignFromStack_NetworkPrefabOverrideLinks_1);
            field = type.GetField("OverrideToNetworkPrefab", flag);
            app.RegisterCLRFieldGetter(field, get_OverrideToNetworkPrefab_2);
            app.RegisterCLRFieldSetter(field, set_OverrideToNetworkPrefab_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_OverrideToNetworkPrefab_2, AssignFromStack_OverrideToNetworkPrefab_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.Netcode.NetworkPrefabs());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Netcode.NetworkPrefabs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_Prefabs_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkPrefabs instance_of_this_method = (Unity.Netcode.NetworkPrefabs)typeof(Unity.Netcode.NetworkPrefabs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Prefabs;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Initialize_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @warnInvalid = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkPrefabs instance_of_this_method = (Unity.Netcode.NetworkPrefabs)typeof(Unity.Netcode.NetworkPrefabs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Initialize(@warnInvalid);

            return __ret;
        }

        static StackObject* Add_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkPrefab @networkPrefab = (Unity.Netcode.NetworkPrefab)typeof(Unity.Netcode.NetworkPrefab).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkPrefabs instance_of_this_method = (Unity.Netcode.NetworkPrefabs)typeof(Unity.Netcode.NetworkPrefabs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Add(@networkPrefab);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Remove_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkPrefab @prefab = (Unity.Netcode.NetworkPrefab)typeof(Unity.Netcode.NetworkPrefab).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkPrefabs instance_of_this_method = (Unity.Netcode.NetworkPrefabs)typeof(Unity.Netcode.NetworkPrefabs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Remove(@prefab);

            return __ret;
        }

        static StackObject* Remove_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @prefab = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkPrefabs instance_of_this_method = (Unity.Netcode.NetworkPrefabs)typeof(Unity.Netcode.NetworkPrefabs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Remove(@prefab);

            return __ret;
        }

        static StackObject* Contains_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @prefab = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkPrefabs instance_of_this_method = (Unity.Netcode.NetworkPrefabs)typeof(Unity.Netcode.NetworkPrefabs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Contains(@prefab);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Contains_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkPrefab @prefab = (Unity.Netcode.NetworkPrefab)typeof(Unity.Netcode.NetworkPrefab).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkPrefabs instance_of_this_method = (Unity.Netcode.NetworkPrefabs)typeof(Unity.Netcode.NetworkPrefabs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Contains(@prefab);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static object get_NetworkPrefabsLists_0(ref object o)
        {
            return ((Unity.Netcode.NetworkPrefabs)o).NetworkPrefabsLists;
        }

        static StackObject* CopyToStack_NetworkPrefabsLists_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkPrefabs)o).NetworkPrefabsLists;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_NetworkPrefabsLists_0(ref object o, object v)
        {
            ((Unity.Netcode.NetworkPrefabs)o).NetworkPrefabsLists = (System.Collections.Generic.List<Unity.Netcode.NetworkPrefabsList>)v;
        }

        static StackObject* AssignFromStack_NetworkPrefabsLists_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.List<Unity.Netcode.NetworkPrefabsList> @NetworkPrefabsLists = (System.Collections.Generic.List<Unity.Netcode.NetworkPrefabsList>)typeof(System.Collections.Generic.List<Unity.Netcode.NetworkPrefabsList>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.NetworkPrefabs)o).NetworkPrefabsLists = @NetworkPrefabsLists;
            return ptr_of_this_method;
        }

        static object get_NetworkPrefabOverrideLinks_1(ref object o)
        {
            return ((Unity.Netcode.NetworkPrefabs)o).NetworkPrefabOverrideLinks;
        }

        static StackObject* CopyToStack_NetworkPrefabOverrideLinks_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkPrefabs)o).NetworkPrefabOverrideLinks;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_NetworkPrefabOverrideLinks_1(ref object o, object v)
        {
            ((Unity.Netcode.NetworkPrefabs)o).NetworkPrefabOverrideLinks = (System.Collections.Generic.Dictionary<System.UInt32, Unity.Netcode.NetworkPrefab>)v;
        }

        static StackObject* AssignFromStack_NetworkPrefabOverrideLinks_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.UInt32, Unity.Netcode.NetworkPrefab> @NetworkPrefabOverrideLinks = (System.Collections.Generic.Dictionary<System.UInt32, Unity.Netcode.NetworkPrefab>)typeof(System.Collections.Generic.Dictionary<System.UInt32, Unity.Netcode.NetworkPrefab>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.NetworkPrefabs)o).NetworkPrefabOverrideLinks = @NetworkPrefabOverrideLinks;
            return ptr_of_this_method;
        }

        static object get_OverrideToNetworkPrefab_2(ref object o)
        {
            return ((Unity.Netcode.NetworkPrefabs)o).OverrideToNetworkPrefab;
        }

        static StackObject* CopyToStack_OverrideToNetworkPrefab_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkPrefabs)o).OverrideToNetworkPrefab;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OverrideToNetworkPrefab_2(ref object o, object v)
        {
            ((Unity.Netcode.NetworkPrefabs)o).OverrideToNetworkPrefab = (System.Collections.Generic.Dictionary<System.UInt32, System.UInt32>)v;
        }

        static StackObject* AssignFromStack_OverrideToNetworkPrefab_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.UInt32, System.UInt32> @OverrideToNetworkPrefab = (System.Collections.Generic.Dictionary<System.UInt32, System.UInt32>)typeof(System.Collections.Generic.Dictionary<System.UInt32, System.UInt32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.NetworkPrefabs)o).OverrideToNetworkPrefab = @OverrideToNetworkPrefab;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Unity.Netcode.NetworkPrefabs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

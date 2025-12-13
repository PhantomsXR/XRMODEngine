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
    unsafe class Unity_Netcode_NetworkPrefab_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Netcode.NetworkPrefab);
            args = new Type[]{typeof(Unity.Netcode.NetworkPrefab)};
            method = type.GetMethod("Equals", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Equals_0);
            args = new Type[]{};
            method = type.GetMethod("get_SourcePrefabGlobalObjectIdHash", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_SourcePrefabGlobalObjectIdHash_1);
            args = new Type[]{};
            method = type.GetMethod("get_TargetPrefabGlobalObjectIdHash", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_TargetPrefabGlobalObjectIdHash_2);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("Validate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Validate_3);
            args = new Type[]{};
            method = type.GetMethod("ToString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToString_4);

            field = type.GetField("Override", flag);
            app.RegisterCLRFieldGetter(field, get_Override_0);
            app.RegisterCLRFieldSetter(field, set_Override_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Override_0, AssignFromStack_Override_0);
            field = type.GetField("Prefab", flag);
            app.RegisterCLRFieldGetter(field, get_Prefab_1);
            app.RegisterCLRFieldSetter(field, set_Prefab_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Prefab_1, AssignFromStack_Prefab_1);
            field = type.GetField("SourcePrefabToOverride", flag);
            app.RegisterCLRFieldGetter(field, get_SourcePrefabToOverride_2);
            app.RegisterCLRFieldSetter(field, set_SourcePrefabToOverride_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_SourcePrefabToOverride_2, AssignFromStack_SourcePrefabToOverride_2);
            field = type.GetField("SourceHashToOverride", flag);
            app.RegisterCLRFieldGetter(field, get_SourceHashToOverride_3);
            app.RegisterCLRFieldSetter(field, set_SourceHashToOverride_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_SourceHashToOverride_3, AssignFromStack_SourceHashToOverride_3);
            field = type.GetField("OverridingTargetPrefab", flag);
            app.RegisterCLRFieldGetter(field, get_OverridingTargetPrefab_4);
            app.RegisterCLRFieldSetter(field, set_OverridingTargetPrefab_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_OverridingTargetPrefab_4, AssignFromStack_OverridingTargetPrefab_4);


            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.Netcode.NetworkPrefab());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Netcode.NetworkPrefab[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Equals_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkPrefab @other = (Unity.Netcode.NetworkPrefab)typeof(Unity.Netcode.NetworkPrefab).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkPrefab instance_of_this_method = (Unity.Netcode.NetworkPrefab)typeof(Unity.Netcode.NetworkPrefab).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Equals(@other);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_SourcePrefabGlobalObjectIdHash_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkPrefab instance_of_this_method = (Unity.Netcode.NetworkPrefab)typeof(Unity.Netcode.NetworkPrefab).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SourcePrefabGlobalObjectIdHash;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_TargetPrefabGlobalObjectIdHash_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkPrefab instance_of_this_method = (Unity.Netcode.NetworkPrefab)typeof(Unity.Netcode.NetworkPrefab).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TargetPrefabGlobalObjectIdHash;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* Validate_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @index = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkPrefab instance_of_this_method = (Unity.Netcode.NetworkPrefab)typeof(Unity.Netcode.NetworkPrefab).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Validate(@index);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* ToString_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkPrefab instance_of_this_method = (Unity.Netcode.NetworkPrefab)typeof(Unity.Netcode.NetworkPrefab).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ToString();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_Override_0(ref object o)
        {
            return ((Unity.Netcode.NetworkPrefab)o).Override;
        }

        static StackObject* CopyToStack_Override_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkPrefab)o).Override;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Override_0(ref object o, object v)
        {
            ((Unity.Netcode.NetworkPrefab)o).Override = (Unity.Netcode.NetworkPrefabOverride)v;
        }

        static StackObject* AssignFromStack_Override_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.NetworkPrefabOverride @Override = (Unity.Netcode.NetworkPrefabOverride)typeof(Unity.Netcode.NetworkPrefabOverride).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Unity.Netcode.NetworkPrefab)o).Override = @Override;
            return ptr_of_this_method;
        }

        static object get_Prefab_1(ref object o)
        {
            return ((Unity.Netcode.NetworkPrefab)o).Prefab;
        }

        static StackObject* CopyToStack_Prefab_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkPrefab)o).Prefab;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Prefab_1(ref object o, object v)
        {
            ((Unity.Netcode.NetworkPrefab)o).Prefab = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_Prefab_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @Prefab = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.NetworkPrefab)o).Prefab = @Prefab;
            return ptr_of_this_method;
        }

        static object get_SourcePrefabToOverride_2(ref object o)
        {
            return ((Unity.Netcode.NetworkPrefab)o).SourcePrefabToOverride;
        }

        static StackObject* CopyToStack_SourcePrefabToOverride_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkPrefab)o).SourcePrefabToOverride;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_SourcePrefabToOverride_2(ref object o, object v)
        {
            ((Unity.Netcode.NetworkPrefab)o).SourcePrefabToOverride = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_SourcePrefabToOverride_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @SourcePrefabToOverride = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.NetworkPrefab)o).SourcePrefabToOverride = @SourcePrefabToOverride;
            return ptr_of_this_method;
        }

        static object get_SourceHashToOverride_3(ref object o)
        {
            return ((Unity.Netcode.NetworkPrefab)o).SourceHashToOverride;
        }

        static StackObject* CopyToStack_SourceHashToOverride_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkPrefab)o).SourceHashToOverride;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static void set_SourceHashToOverride_3(ref object o, object v)
        {
            ((Unity.Netcode.NetworkPrefab)o).SourceHashToOverride = (System.UInt32)v;
        }

        static StackObject* AssignFromStack_SourceHashToOverride_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.UInt32 @SourceHashToOverride = (uint)ptr_of_this_method->Value;
            ((Unity.Netcode.NetworkPrefab)o).SourceHashToOverride = @SourceHashToOverride;
            return ptr_of_this_method;
        }

        static object get_OverridingTargetPrefab_4(ref object o)
        {
            return ((Unity.Netcode.NetworkPrefab)o).OverridingTargetPrefab;
        }

        static StackObject* CopyToStack_OverridingTargetPrefab_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkPrefab)o).OverridingTargetPrefab;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OverridingTargetPrefab_4(ref object o, object v)
        {
            ((Unity.Netcode.NetworkPrefab)o).OverridingTargetPrefab = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_OverridingTargetPrefab_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @OverridingTargetPrefab = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.NetworkPrefab)o).OverridingTargetPrefab = @OverridingTargetPrefab;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Unity.Netcode.NetworkPrefab();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

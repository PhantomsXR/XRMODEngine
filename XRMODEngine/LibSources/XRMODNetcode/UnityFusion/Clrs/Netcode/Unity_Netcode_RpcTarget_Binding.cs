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
    unsafe class Unity_Netcode_RpcTarget_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Netcode.RpcTarget);
            args = new Type[]{};
            method = type.GetMethod("Dispose", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Dispose_0);
            args = new Type[]{typeof(System.UInt64), typeof(Unity.Netcode.RpcTargetUse)};
            method = type.GetMethod("Single", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Single_1);
            args = new Type[]{typeof(System.UInt64), typeof(Unity.Netcode.RpcTargetUse)};
            method = type.GetMethod("Not", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Not_2);
            args = new Type[]{typeof(Unity.Collections.NativeArray<System.UInt64>), typeof(Unity.Netcode.RpcTargetUse)};
            method = type.GetMethod("Group", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Group_3);
            args = new Type[]{typeof(Unity.Collections.NativeList<System.UInt64>), typeof(Unity.Netcode.RpcTargetUse)};
            method = type.GetMethod("Group", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Group_4);
            args = new Type[]{typeof(System.UInt64[]), typeof(Unity.Netcode.RpcTargetUse)};
            method = type.GetMethod("Group", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Group_5);
            args = new Type[]{typeof(Unity.Collections.NativeArray<System.UInt64>), typeof(Unity.Netcode.RpcTargetUse)};
            method = type.GetMethod("Not", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Not_6);
            args = new Type[]{typeof(Unity.Collections.NativeList<System.UInt64>), typeof(Unity.Netcode.RpcTargetUse)};
            method = type.GetMethod("Not", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Not_7);
            args = new Type[]{typeof(System.UInt64[]), typeof(Unity.Netcode.RpcTargetUse)};
            method = type.GetMethod("Not", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Not_8);

            field = type.GetField("Owner", flag);
            app.RegisterCLRFieldGetter(field, get_Owner_0);
            app.RegisterCLRFieldSetter(field, set_Owner_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Owner_0, AssignFromStack_Owner_0);
            field = type.GetField("NotOwner", flag);
            app.RegisterCLRFieldGetter(field, get_NotOwner_1);
            app.RegisterCLRFieldSetter(field, set_NotOwner_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_NotOwner_1, AssignFromStack_NotOwner_1);
            field = type.GetField("Server", flag);
            app.RegisterCLRFieldGetter(field, get_Server_2);
            app.RegisterCLRFieldSetter(field, set_Server_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Server_2, AssignFromStack_Server_2);
            field = type.GetField("NotServer", flag);
            app.RegisterCLRFieldGetter(field, get_NotServer_3);
            app.RegisterCLRFieldSetter(field, set_NotServer_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_NotServer_3, AssignFromStack_NotServer_3);
            field = type.GetField("Me", flag);
            app.RegisterCLRFieldGetter(field, get_Me_4);
            app.RegisterCLRFieldSetter(field, set_Me_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Me_4, AssignFromStack_Me_4);
            field = type.GetField("NotMe", flag);
            app.RegisterCLRFieldGetter(field, get_NotMe_5);
            app.RegisterCLRFieldSetter(field, set_NotMe_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_NotMe_5, AssignFromStack_NotMe_5);
            field = type.GetField("Everyone", flag);
            app.RegisterCLRFieldGetter(field, get_Everyone_6);
            app.RegisterCLRFieldSetter(field, set_Everyone_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_Everyone_6, AssignFromStack_Everyone_6);
            field = type.GetField("ClientsAndHost", flag);
            app.RegisterCLRFieldGetter(field, get_ClientsAndHost_7);
            app.RegisterCLRFieldSetter(field, set_ClientsAndHost_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientsAndHost_7, AssignFromStack_ClientsAndHost_7);
            field = type.GetField("Authority", flag);
            app.RegisterCLRFieldGetter(field, get_Authority_8);
            app.RegisterCLRFieldSetter(field, set_Authority_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_Authority_8, AssignFromStack_Authority_8);
            field = type.GetField("NotAuthority", flag);
            app.RegisterCLRFieldGetter(field, get_NotAuthority_9);
            app.RegisterCLRFieldSetter(field, set_NotAuthority_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_NotAuthority_9, AssignFromStack_NotAuthority_9);


            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Netcode.RpcTarget[s]);


        }


        static StackObject* Dispose_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.RpcTarget instance_of_this_method = (Unity.Netcode.RpcTarget)typeof(Unity.Netcode.RpcTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Dispose();

            return __ret;
        }

        static StackObject* Single_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.RpcTargetUse @use = (Unity.Netcode.RpcTargetUse)typeof(Unity.Netcode.RpcTargetUse).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt64 @clientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Netcode.RpcTarget instance_of_this_method = (Unity.Netcode.RpcTarget)typeof(Unity.Netcode.RpcTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Single(@clientId, @use);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Not_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.RpcTargetUse @use = (Unity.Netcode.RpcTargetUse)typeof(Unity.Netcode.RpcTargetUse).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt64 @excludedClientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Netcode.RpcTarget instance_of_this_method = (Unity.Netcode.RpcTarget)typeof(Unity.Netcode.RpcTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Not(@excludedClientId, @use);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Group_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.RpcTargetUse @use = (Unity.Netcode.RpcTargetUse)typeof(Unity.Netcode.RpcTargetUse).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Collections.NativeArray<System.UInt64> @clientIds = (Unity.Collections.NativeArray<System.UInt64>)typeof(Unity.Collections.NativeArray<System.UInt64>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Netcode.RpcTarget instance_of_this_method = (Unity.Netcode.RpcTarget)typeof(Unity.Netcode.RpcTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Group(@clientIds, @use);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Group_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.RpcTargetUse @use = (Unity.Netcode.RpcTargetUse)typeof(Unity.Netcode.RpcTargetUse).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Collections.NativeList<System.UInt64> @clientIds = (Unity.Collections.NativeList<System.UInt64>)typeof(Unity.Collections.NativeList<System.UInt64>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Netcode.RpcTarget instance_of_this_method = (Unity.Netcode.RpcTarget)typeof(Unity.Netcode.RpcTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Group(@clientIds, @use);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Group_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.RpcTargetUse @use = (Unity.Netcode.RpcTargetUse)typeof(Unity.Netcode.RpcTargetUse).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt64[] @clientIds = (System.UInt64[])typeof(System.UInt64[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Netcode.RpcTarget instance_of_this_method = (Unity.Netcode.RpcTarget)typeof(Unity.Netcode.RpcTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Group(@clientIds, @use);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Not_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.RpcTargetUse @use = (Unity.Netcode.RpcTargetUse)typeof(Unity.Netcode.RpcTargetUse).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Collections.NativeArray<System.UInt64> @excludedClientIds = (Unity.Collections.NativeArray<System.UInt64>)typeof(Unity.Collections.NativeArray<System.UInt64>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Netcode.RpcTarget instance_of_this_method = (Unity.Netcode.RpcTarget)typeof(Unity.Netcode.RpcTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Not(@excludedClientIds, @use);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Not_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.RpcTargetUse @use = (Unity.Netcode.RpcTargetUse)typeof(Unity.Netcode.RpcTargetUse).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Collections.NativeList<System.UInt64> @excludedClientIds = (Unity.Collections.NativeList<System.UInt64>)typeof(Unity.Collections.NativeList<System.UInt64>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Netcode.RpcTarget instance_of_this_method = (Unity.Netcode.RpcTarget)typeof(Unity.Netcode.RpcTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Not(@excludedClientIds, @use);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Not_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.RpcTargetUse @use = (Unity.Netcode.RpcTargetUse)typeof(Unity.Netcode.RpcTargetUse).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt64[] @excludedClientIds = (System.UInt64[])typeof(System.UInt64[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Netcode.RpcTarget instance_of_this_method = (Unity.Netcode.RpcTarget)typeof(Unity.Netcode.RpcTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Not(@excludedClientIds, @use);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_Owner_0(ref object o)
        {
            return ((Unity.Netcode.RpcTarget)o).Owner;
        }

        static StackObject* CopyToStack_Owner_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.RpcTarget)o).Owner;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Owner_0(ref object o, object v)
        {
            ((Unity.Netcode.RpcTarget)o).Owner = (Unity.Netcode.BaseRpcTarget)v;
        }

        static StackObject* AssignFromStack_Owner_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.BaseRpcTarget @Owner = (Unity.Netcode.BaseRpcTarget)typeof(Unity.Netcode.BaseRpcTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.RpcTarget)o).Owner = @Owner;
            return ptr_of_this_method;
        }

        static object get_NotOwner_1(ref object o)
        {
            return ((Unity.Netcode.RpcTarget)o).NotOwner;
        }

        static StackObject* CopyToStack_NotOwner_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.RpcTarget)o).NotOwner;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_NotOwner_1(ref object o, object v)
        {
            ((Unity.Netcode.RpcTarget)o).NotOwner = (Unity.Netcode.BaseRpcTarget)v;
        }

        static StackObject* AssignFromStack_NotOwner_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.BaseRpcTarget @NotOwner = (Unity.Netcode.BaseRpcTarget)typeof(Unity.Netcode.BaseRpcTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.RpcTarget)o).NotOwner = @NotOwner;
            return ptr_of_this_method;
        }

        static object get_Server_2(ref object o)
        {
            return ((Unity.Netcode.RpcTarget)o).Server;
        }

        static StackObject* CopyToStack_Server_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.RpcTarget)o).Server;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Server_2(ref object o, object v)
        {
            ((Unity.Netcode.RpcTarget)o).Server = (Unity.Netcode.BaseRpcTarget)v;
        }

        static StackObject* AssignFromStack_Server_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.BaseRpcTarget @Server = (Unity.Netcode.BaseRpcTarget)typeof(Unity.Netcode.BaseRpcTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.RpcTarget)o).Server = @Server;
            return ptr_of_this_method;
        }

        static object get_NotServer_3(ref object o)
        {
            return ((Unity.Netcode.RpcTarget)o).NotServer;
        }

        static StackObject* CopyToStack_NotServer_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.RpcTarget)o).NotServer;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_NotServer_3(ref object o, object v)
        {
            ((Unity.Netcode.RpcTarget)o).NotServer = (Unity.Netcode.BaseRpcTarget)v;
        }

        static StackObject* AssignFromStack_NotServer_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.BaseRpcTarget @NotServer = (Unity.Netcode.BaseRpcTarget)typeof(Unity.Netcode.BaseRpcTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.RpcTarget)o).NotServer = @NotServer;
            return ptr_of_this_method;
        }

        static object get_Me_4(ref object o)
        {
            return ((Unity.Netcode.RpcTarget)o).Me;
        }

        static StackObject* CopyToStack_Me_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.RpcTarget)o).Me;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Me_4(ref object o, object v)
        {
            ((Unity.Netcode.RpcTarget)o).Me = (Unity.Netcode.BaseRpcTarget)v;
        }

        static StackObject* AssignFromStack_Me_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.BaseRpcTarget @Me = (Unity.Netcode.BaseRpcTarget)typeof(Unity.Netcode.BaseRpcTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.RpcTarget)o).Me = @Me;
            return ptr_of_this_method;
        }

        static object get_NotMe_5(ref object o)
        {
            return ((Unity.Netcode.RpcTarget)o).NotMe;
        }

        static StackObject* CopyToStack_NotMe_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.RpcTarget)o).NotMe;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_NotMe_5(ref object o, object v)
        {
            ((Unity.Netcode.RpcTarget)o).NotMe = (Unity.Netcode.BaseRpcTarget)v;
        }

        static StackObject* AssignFromStack_NotMe_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.BaseRpcTarget @NotMe = (Unity.Netcode.BaseRpcTarget)typeof(Unity.Netcode.BaseRpcTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.RpcTarget)o).NotMe = @NotMe;
            return ptr_of_this_method;
        }

        static object get_Everyone_6(ref object o)
        {
            return ((Unity.Netcode.RpcTarget)o).Everyone;
        }

        static StackObject* CopyToStack_Everyone_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.RpcTarget)o).Everyone;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Everyone_6(ref object o, object v)
        {
            ((Unity.Netcode.RpcTarget)o).Everyone = (Unity.Netcode.BaseRpcTarget)v;
        }

        static StackObject* AssignFromStack_Everyone_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.BaseRpcTarget @Everyone = (Unity.Netcode.BaseRpcTarget)typeof(Unity.Netcode.BaseRpcTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.RpcTarget)o).Everyone = @Everyone;
            return ptr_of_this_method;
        }

        static object get_ClientsAndHost_7(ref object o)
        {
            return ((Unity.Netcode.RpcTarget)o).ClientsAndHost;
        }

        static StackObject* CopyToStack_ClientsAndHost_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.RpcTarget)o).ClientsAndHost;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientsAndHost_7(ref object o, object v)
        {
            ((Unity.Netcode.RpcTarget)o).ClientsAndHost = (Unity.Netcode.BaseRpcTarget)v;
        }

        static StackObject* AssignFromStack_ClientsAndHost_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.BaseRpcTarget @ClientsAndHost = (Unity.Netcode.BaseRpcTarget)typeof(Unity.Netcode.BaseRpcTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.RpcTarget)o).ClientsAndHost = @ClientsAndHost;
            return ptr_of_this_method;
        }

        static object get_Authority_8(ref object o)
        {
            return ((Unity.Netcode.RpcTarget)o).Authority;
        }

        static StackObject* CopyToStack_Authority_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.RpcTarget)o).Authority;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Authority_8(ref object o, object v)
        {
            ((Unity.Netcode.RpcTarget)o).Authority = (Unity.Netcode.BaseRpcTarget)v;
        }

        static StackObject* AssignFromStack_Authority_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.BaseRpcTarget @Authority = (Unity.Netcode.BaseRpcTarget)typeof(Unity.Netcode.BaseRpcTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.RpcTarget)o).Authority = @Authority;
            return ptr_of_this_method;
        }

        static object get_NotAuthority_9(ref object o)
        {
            return ((Unity.Netcode.RpcTarget)o).NotAuthority;
        }

        static StackObject* CopyToStack_NotAuthority_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.RpcTarget)o).NotAuthority;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_NotAuthority_9(ref object o, object v)
        {
            ((Unity.Netcode.RpcTarget)o).NotAuthority = (Unity.Netcode.BaseRpcTarget)v;
        }

        static StackObject* AssignFromStack_NotAuthority_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.BaseRpcTarget @NotAuthority = (Unity.Netcode.BaseRpcTarget)typeof(Unity.Netcode.BaseRpcTarget).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.RpcTarget)o).NotAuthority = @NotAuthority;
            return ptr_of_this_method;
        }




    }
}

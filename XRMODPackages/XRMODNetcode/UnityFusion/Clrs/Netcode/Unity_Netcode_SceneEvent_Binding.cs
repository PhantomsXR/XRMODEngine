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
    unsafe class Unity_Netcode_SceneEvent_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Netcode.SceneEvent);

            field = type.GetField("AsyncOperation", flag);
            app.RegisterCLRFieldGetter(field, get_AsyncOperation_0);
            app.RegisterCLRFieldSetter(field, set_AsyncOperation_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_AsyncOperation_0, AssignFromStack_AsyncOperation_0);
            field = type.GetField("SceneEventType", flag);
            app.RegisterCLRFieldGetter(field, get_SceneEventType_1);
            app.RegisterCLRFieldSetter(field, set_SceneEventType_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_SceneEventType_1, AssignFromStack_SceneEventType_1);
            field = type.GetField("LoadSceneMode", flag);
            app.RegisterCLRFieldGetter(field, get_LoadSceneMode_2);
            app.RegisterCLRFieldSetter(field, set_LoadSceneMode_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_LoadSceneMode_2, AssignFromStack_LoadSceneMode_2);
            field = type.GetField("SceneName", flag);
            app.RegisterCLRFieldGetter(field, get_SceneName_3);
            app.RegisterCLRFieldSetter(field, set_SceneName_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_SceneName_3, AssignFromStack_SceneName_3);
            field = type.GetField("Scene", flag);
            app.RegisterCLRFieldGetter(field, get_Scene_4);
            app.RegisterCLRFieldSetter(field, set_Scene_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Scene_4, AssignFromStack_Scene_4);
            field = type.GetField("ClientId", flag);
            app.RegisterCLRFieldGetter(field, get_ClientId_5);
            app.RegisterCLRFieldSetter(field, set_ClientId_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientId_5, AssignFromStack_ClientId_5);
            field = type.GetField("ClientsThatCompleted", flag);
            app.RegisterCLRFieldGetter(field, get_ClientsThatCompleted_6);
            app.RegisterCLRFieldSetter(field, set_ClientsThatCompleted_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientsThatCompleted_6, AssignFromStack_ClientsThatCompleted_6);
            field = type.GetField("ClientsThatTimedOut", flag);
            app.RegisterCLRFieldGetter(field, get_ClientsThatTimedOut_7);
            app.RegisterCLRFieldSetter(field, set_ClientsThatTimedOut_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientsThatTimedOut_7, AssignFromStack_ClientsThatTimedOut_7);


            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.Netcode.SceneEvent());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Netcode.SceneEvent[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_AsyncOperation_0(ref object o)
        {
            return ((Unity.Netcode.SceneEvent)o).AsyncOperation;
        }

        static StackObject* CopyToStack_AsyncOperation_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.SceneEvent)o).AsyncOperation;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AsyncOperation_0(ref object o, object v)
        {
            ((Unity.Netcode.SceneEvent)o).AsyncOperation = (UnityEngine.AsyncOperation)v;
        }

        static StackObject* AssignFromStack_AsyncOperation_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.AsyncOperation @AsyncOperation = (UnityEngine.AsyncOperation)typeof(UnityEngine.AsyncOperation).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.SceneEvent)o).AsyncOperation = @AsyncOperation;
            return ptr_of_this_method;
        }

        static object get_SceneEventType_1(ref object o)
        {
            return ((Unity.Netcode.SceneEvent)o).SceneEventType;
        }

        static StackObject* CopyToStack_SceneEventType_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.SceneEvent)o).SceneEventType;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_SceneEventType_1(ref object o, object v)
        {
            ((Unity.Netcode.SceneEvent)o).SceneEventType = (Unity.Netcode.SceneEventType)v;
        }

        static StackObject* AssignFromStack_SceneEventType_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.SceneEventType @SceneEventType = (Unity.Netcode.SceneEventType)typeof(Unity.Netcode.SceneEventType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Unity.Netcode.SceneEvent)o).SceneEventType = @SceneEventType;
            return ptr_of_this_method;
        }

        static object get_LoadSceneMode_2(ref object o)
        {
            return ((Unity.Netcode.SceneEvent)o).LoadSceneMode;
        }

        static StackObject* CopyToStack_LoadSceneMode_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.SceneEvent)o).LoadSceneMode;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LoadSceneMode_2(ref object o, object v)
        {
            ((Unity.Netcode.SceneEvent)o).LoadSceneMode = (UnityEngine.SceneManagement.LoadSceneMode)v;
        }

        static StackObject* AssignFromStack_LoadSceneMode_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.SceneManagement.LoadSceneMode @LoadSceneMode = (UnityEngine.SceneManagement.LoadSceneMode)typeof(UnityEngine.SceneManagement.LoadSceneMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Unity.Netcode.SceneEvent)o).LoadSceneMode = @LoadSceneMode;
            return ptr_of_this_method;
        }

        static object get_SceneName_3(ref object o)
        {
            return ((Unity.Netcode.SceneEvent)o).SceneName;
        }

        static StackObject* CopyToStack_SceneName_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.SceneEvent)o).SceneName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_SceneName_3(ref object o, object v)
        {
            ((Unity.Netcode.SceneEvent)o).SceneName = (System.String)v;
        }

        static StackObject* AssignFromStack_SceneName_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @SceneName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.SceneEvent)o).SceneName = @SceneName;
            return ptr_of_this_method;
        }

        static object get_Scene_4(ref object o)
        {
            return ((Unity.Netcode.SceneEvent)o).Scene;
        }

        static StackObject* CopyToStack_Scene_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.SceneEvent)o).Scene;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Scene_4(ref object o, object v)
        {
            ((Unity.Netcode.SceneEvent)o).Scene = (UnityEngine.SceneManagement.Scene)v;
        }

        static StackObject* AssignFromStack_Scene_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.SceneManagement.Scene @Scene = (UnityEngine.SceneManagement.Scene)typeof(UnityEngine.SceneManagement.Scene).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Unity.Netcode.SceneEvent)o).Scene = @Scene;
            return ptr_of_this_method;
        }

        static object get_ClientId_5(ref object o)
        {
            return ((Unity.Netcode.SceneEvent)o).ClientId;
        }

        static StackObject* CopyToStack_ClientId_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.SceneEvent)o).ClientId;
            __ret->ObjectType = ObjectTypes.Long;
            *(ulong*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_ClientId_5(ref object o, object v)
        {
            ((Unity.Netcode.SceneEvent)o).ClientId = (System.UInt64)v;
        }

        static StackObject* AssignFromStack_ClientId_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.UInt64 @ClientId = *(ulong*)&ptr_of_this_method->Value;
            ((Unity.Netcode.SceneEvent)o).ClientId = @ClientId;
            return ptr_of_this_method;
        }

        static object get_ClientsThatCompleted_6(ref object o)
        {
            return ((Unity.Netcode.SceneEvent)o).ClientsThatCompleted;
        }

        static StackObject* CopyToStack_ClientsThatCompleted_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.SceneEvent)o).ClientsThatCompleted;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientsThatCompleted_6(ref object o, object v)
        {
            ((Unity.Netcode.SceneEvent)o).ClientsThatCompleted = (System.Collections.Generic.List<System.UInt64>)v;
        }

        static StackObject* AssignFromStack_ClientsThatCompleted_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.List<System.UInt64> @ClientsThatCompleted = (System.Collections.Generic.List<System.UInt64>)typeof(System.Collections.Generic.List<System.UInt64>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.SceneEvent)o).ClientsThatCompleted = @ClientsThatCompleted;
            return ptr_of_this_method;
        }

        static object get_ClientsThatTimedOut_7(ref object o)
        {
            return ((Unity.Netcode.SceneEvent)o).ClientsThatTimedOut;
        }

        static StackObject* CopyToStack_ClientsThatTimedOut_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.SceneEvent)o).ClientsThatTimedOut;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ClientsThatTimedOut_7(ref object o, object v)
        {
            ((Unity.Netcode.SceneEvent)o).ClientsThatTimedOut = (System.Collections.Generic.List<System.UInt64>)v;
        }

        static StackObject* AssignFromStack_ClientsThatTimedOut_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.List<System.UInt64> @ClientsThatTimedOut = (System.Collections.Generic.List<System.UInt64>)typeof(System.Collections.Generic.List<System.UInt64>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Unity.Netcode.SceneEvent)o).ClientsThatTimedOut = @ClientsThatTimedOut;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Unity.Netcode.SceneEvent();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

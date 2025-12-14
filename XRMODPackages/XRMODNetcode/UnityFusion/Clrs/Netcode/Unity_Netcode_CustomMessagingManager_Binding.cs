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
    unsafe class Unity_Netcode_CustomMessagingManager_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Unity.Netcode.CustomMessagingManager);
            args = new Type[]{typeof(Unity.Netcode.CustomMessagingManager.UnnamedMessageDelegate)};
            method = type.GetMethod("add_OnUnnamedMessage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnUnnamedMessage_0);
            args = new Type[]{typeof(Unity.Netcode.CustomMessagingManager.UnnamedMessageDelegate)};
            method = type.GetMethod("remove_OnUnnamedMessage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnUnnamedMessage_1);
            args = new Type[]{typeof(Unity.Netcode.FastBufferWriter), typeof(Unity.Netcode.NetworkDelivery)};
            method = type.GetMethod("SendUnnamedMessageToAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendUnnamedMessageToAll_2);
            args = new Type[]{typeof(System.Collections.Generic.IReadOnlyList<System.UInt64>), typeof(Unity.Netcode.FastBufferWriter), typeof(Unity.Netcode.NetworkDelivery)};
            method = type.GetMethod("SendUnnamedMessage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendUnnamedMessage_3);
            args = new Type[]{typeof(System.UInt64), typeof(Unity.Netcode.FastBufferWriter), typeof(Unity.Netcode.NetworkDelivery)};
            method = type.GetMethod("SendUnnamedMessage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendUnnamedMessage_4);
            args = new Type[]{typeof(System.String), typeof(Unity.Netcode.CustomMessagingManager.HandleNamedMessageDelegate)};
            method = type.GetMethod("RegisterNamedMessageHandler", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterNamedMessageHandler_5);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("UnregisterNamedMessageHandler", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UnregisterNamedMessageHandler_6);
            args = new Type[]{typeof(System.String), typeof(Unity.Netcode.FastBufferWriter), typeof(Unity.Netcode.NetworkDelivery)};
            method = type.GetMethod("SendNamedMessageToAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendNamedMessageToAll_7);
            args = new Type[]{typeof(System.String), typeof(System.UInt64), typeof(Unity.Netcode.FastBufferWriter), typeof(Unity.Netcode.NetworkDelivery)};
            method = type.GetMethod("SendNamedMessage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendNamedMessage_8);
            args = new Type[]{typeof(System.String), typeof(System.Collections.Generic.IReadOnlyList<System.UInt64>), typeof(Unity.Netcode.FastBufferWriter), typeof(Unity.Netcode.NetworkDelivery)};
            method = type.GetMethod("SendNamedMessage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendNamedMessage_9);



            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Netcode.CustomMessagingManager[s]);


        }


        static StackObject* add_OnUnnamedMessage_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.CustomMessagingManager.UnnamedMessageDelegate @value = (Unity.Netcode.CustomMessagingManager.UnnamedMessageDelegate)typeof(Unity.Netcode.CustomMessagingManager.UnnamedMessageDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.CustomMessagingManager instance_of_this_method = (Unity.Netcode.CustomMessagingManager)typeof(Unity.Netcode.CustomMessagingManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnUnnamedMessage += value;

            return __ret;
        }

        static StackObject* remove_OnUnnamedMessage_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.CustomMessagingManager.UnnamedMessageDelegate @value = (Unity.Netcode.CustomMessagingManager.UnnamedMessageDelegate)typeof(Unity.Netcode.CustomMessagingManager.UnnamedMessageDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.CustomMessagingManager instance_of_this_method = (Unity.Netcode.CustomMessagingManager)typeof(Unity.Netcode.CustomMessagingManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnUnnamedMessage -= value;

            return __ret;
        }

        static StackObject* SendUnnamedMessageToAll_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkDelivery @networkDelivery = (Unity.Netcode.NetworkDelivery)typeof(Unity.Netcode.NetworkDelivery).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.FastBufferWriter @messageBuffer = (Unity.Netcode.FastBufferWriter)typeof(Unity.Netcode.FastBufferWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Netcode.CustomMessagingManager instance_of_this_method = (Unity.Netcode.CustomMessagingManager)typeof(Unity.Netcode.CustomMessagingManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SendUnnamedMessageToAll(@messageBuffer, @networkDelivery);

            return __ret;
        }

        static StackObject* SendUnnamedMessage_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkDelivery @networkDelivery = (Unity.Netcode.NetworkDelivery)typeof(Unity.Netcode.NetworkDelivery).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.FastBufferWriter @messageBuffer = (Unity.Netcode.FastBufferWriter)typeof(Unity.Netcode.FastBufferWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.IReadOnlyList<System.UInt64> @clientIds = (System.Collections.Generic.IReadOnlyList<System.UInt64>)typeof(System.Collections.Generic.IReadOnlyList<System.UInt64>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Unity.Netcode.CustomMessagingManager instance_of_this_method = (Unity.Netcode.CustomMessagingManager)typeof(Unity.Netcode.CustomMessagingManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SendUnnamedMessage(@clientIds, @messageBuffer, @networkDelivery);

            return __ret;
        }

        static StackObject* SendUnnamedMessage_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkDelivery @networkDelivery = (Unity.Netcode.NetworkDelivery)typeof(Unity.Netcode.NetworkDelivery).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.FastBufferWriter @messageBuffer = (Unity.Netcode.FastBufferWriter)typeof(Unity.Netcode.FastBufferWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.UInt64 @clientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Unity.Netcode.CustomMessagingManager instance_of_this_method = (Unity.Netcode.CustomMessagingManager)typeof(Unity.Netcode.CustomMessagingManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SendUnnamedMessage(@clientId, @messageBuffer, @networkDelivery);

            return __ret;
        }

        static StackObject* RegisterNamedMessageHandler_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.CustomMessagingManager.HandleNamedMessageDelegate @callback = (Unity.Netcode.CustomMessagingManager.HandleNamedMessageDelegate)typeof(Unity.Netcode.CustomMessagingManager.HandleNamedMessageDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Netcode.CustomMessagingManager instance_of_this_method = (Unity.Netcode.CustomMessagingManager)typeof(Unity.Netcode.CustomMessagingManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RegisterNamedMessageHandler(@name, @callback);

            return __ret;
        }

        static StackObject* UnregisterNamedMessageHandler_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.CustomMessagingManager instance_of_this_method = (Unity.Netcode.CustomMessagingManager)typeof(Unity.Netcode.CustomMessagingManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UnregisterNamedMessageHandler(@name);

            return __ret;
        }

        static StackObject* SendNamedMessageToAll_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkDelivery @networkDelivery = (Unity.Netcode.NetworkDelivery)typeof(Unity.Netcode.NetworkDelivery).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.FastBufferWriter @messageStream = (Unity.Netcode.FastBufferWriter)typeof(Unity.Netcode.FastBufferWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @messageName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Unity.Netcode.CustomMessagingManager instance_of_this_method = (Unity.Netcode.CustomMessagingManager)typeof(Unity.Netcode.CustomMessagingManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SendNamedMessageToAll(@messageName, @messageStream, @networkDelivery);

            return __ret;
        }

        static StackObject* SendNamedMessage_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkDelivery @networkDelivery = (Unity.Netcode.NetworkDelivery)typeof(Unity.Netcode.NetworkDelivery).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.FastBufferWriter @messageStream = (Unity.Netcode.FastBufferWriter)typeof(Unity.Netcode.FastBufferWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.UInt64 @clientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String @messageName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            Unity.Netcode.CustomMessagingManager instance_of_this_method = (Unity.Netcode.CustomMessagingManager)typeof(Unity.Netcode.CustomMessagingManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SendNamedMessage(@messageName, @clientId, @messageStream, @networkDelivery);

            return __ret;
        }

        static StackObject* SendNamedMessage_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkDelivery @networkDelivery = (Unity.Netcode.NetworkDelivery)typeof(Unity.Netcode.NetworkDelivery).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.FastBufferWriter @messageStream = (Unity.Netcode.FastBufferWriter)typeof(Unity.Netcode.FastBufferWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.IReadOnlyList<System.UInt64> @clientIds = (System.Collections.Generic.IReadOnlyList<System.UInt64>)typeof(System.Collections.Generic.IReadOnlyList<System.UInt64>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.String @messageName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            Unity.Netcode.CustomMessagingManager instance_of_this_method = (Unity.Netcode.CustomMessagingManager)typeof(Unity.Netcode.CustomMessagingManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SendNamedMessage(@messageName, @clientIds, @messageStream, @networkDelivery);

            return __ret;
        }





    }
}

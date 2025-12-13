using System;
using System.Collections.Generic;
using System.Linq;
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
    unsafe class Unity_Services_Friends_IFriendsService_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Unity.Services.Friends.IFriendsService);
            args = new Type[]{};
            method = type.GetMethod("get_Blocks", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Blocks_0);
            args = new Type[]{};
            method = type.GetMethod("get_Friends", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Friends_1);
            args = new Type[]{};
            method = type.GetMethod("get_IncomingFriendRequests", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IncomingFriendRequests_2);
            args = new Type[]{typeof(System.Action<Unity.Services.Friends.Notifications.IRelationshipAddedEvent>)};
            method = type.GetMethod("add_RelationshipAdded", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_RelationshipAdded_3);
            args = new Type[]{typeof(System.Action<Unity.Services.Friends.Notifications.IMessageReceivedEvent>)};
            method = type.GetMethod("add_MessageReceived", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_MessageReceived_4);
            args = new Type[]{typeof(System.Action<Unity.Services.Friends.Notifications.IPresenceUpdatedEvent>)};
            method = type.GetMethod("add_PresenceUpdated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_PresenceUpdated_5);
            args = new Type[]{typeof(System.Action<Unity.Services.Friends.Notifications.IRelationshipDeletedEvent>)};
            method = type.GetMethod("add_RelationshipDeleted", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_RelationshipDeleted_6);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("AddBlockAsync", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddBlockAsync_7);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("DeleteIncomingFriendRequestAsync", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DeleteIncomingFriendRequestAsync_8);
            args = new Type[]{typeof(Unity.Services.Friends.Options.InitializeOptions)};
            method = type.GetMethod("InitializeAsync", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InitializeAsync_9);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("DeleteFriendAsync", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DeleteFriendAsync_10);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("AddFriendByNameAsync", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddFriendByNameAsync_11);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("DeleteBlockAsync", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DeleteBlockAsync_12);


        }


        static StackObject* get_Blocks_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Services.Friends.IFriendsService instance_of_this_method = (Unity.Services.Friends.IFriendsService)typeof(Unity.Services.Friends.IFriendsService).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Blocks;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Friends_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Services.Friends.IFriendsService instance_of_this_method = (Unity.Services.Friends.IFriendsService)typeof(Unity.Services.Friends.IFriendsService).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Friends;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_IncomingFriendRequests_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Services.Friends.IFriendsService instance_of_this_method = (Unity.Services.Friends.IFriendsService)typeof(Unity.Services.Friends.IFriendsService).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IncomingFriendRequests;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* add_RelationshipAdded_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<Unity.Services.Friends.Notifications.IRelationshipAddedEvent> @value = (System.Action<Unity.Services.Friends.Notifications.IRelationshipAddedEvent>)typeof(System.Action<Unity.Services.Friends.Notifications.IRelationshipAddedEvent>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Services.Friends.IFriendsService instance_of_this_method = (Unity.Services.Friends.IFriendsService)typeof(Unity.Services.Friends.IFriendsService).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RelationshipAdded += value;

            return __ret;
        }

        static StackObject* add_MessageReceived_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<Unity.Services.Friends.Notifications.IMessageReceivedEvent> @value = (System.Action<Unity.Services.Friends.Notifications.IMessageReceivedEvent>)typeof(System.Action<Unity.Services.Friends.Notifications.IMessageReceivedEvent>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Services.Friends.IFriendsService instance_of_this_method = (Unity.Services.Friends.IFriendsService)typeof(Unity.Services.Friends.IFriendsService).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MessageReceived += value;

            return __ret;
        }

        static StackObject* add_PresenceUpdated_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<Unity.Services.Friends.Notifications.IPresenceUpdatedEvent> @value = (System.Action<Unity.Services.Friends.Notifications.IPresenceUpdatedEvent>)typeof(System.Action<Unity.Services.Friends.Notifications.IPresenceUpdatedEvent>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Services.Friends.IFriendsService instance_of_this_method = (Unity.Services.Friends.IFriendsService)typeof(Unity.Services.Friends.IFriendsService).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PresenceUpdated += value;

            return __ret;
        }

        static StackObject* add_RelationshipDeleted_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<Unity.Services.Friends.Notifications.IRelationshipDeletedEvent> @value = (System.Action<Unity.Services.Friends.Notifications.IRelationshipDeletedEvent>)typeof(System.Action<Unity.Services.Friends.Notifications.IRelationshipDeletedEvent>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Services.Friends.IFriendsService instance_of_this_method = (Unity.Services.Friends.IFriendsService)typeof(Unity.Services.Friends.IFriendsService).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RelationshipDeleted += value;

            return __ret;
        }

        static StackObject* AddBlockAsync_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @memberId = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Services.Friends.IFriendsService instance_of_this_method = (Unity.Services.Friends.IFriendsService)typeof(Unity.Services.Friends.IFriendsService).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AddBlockAsync(@memberId);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* DeleteIncomingFriendRequestAsync_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @memberId = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Services.Friends.IFriendsService instance_of_this_method = (Unity.Services.Friends.IFriendsService)typeof(Unity.Services.Friends.IFriendsService).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DeleteIncomingFriendRequestAsync(@memberId);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* InitializeAsync_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Services.Friends.Options.InitializeOptions @initializeOptions = (Unity.Services.Friends.Options.InitializeOptions)typeof(Unity.Services.Friends.Options.InitializeOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Services.Friends.IFriendsService instance_of_this_method = (Unity.Services.Friends.IFriendsService)typeof(Unity.Services.Friends.IFriendsService).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.InitializeAsync(@initializeOptions);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* DeleteFriendAsync_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @memberId = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Services.Friends.IFriendsService instance_of_this_method = (Unity.Services.Friends.IFriendsService)typeof(Unity.Services.Friends.IFriendsService).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DeleteFriendAsync(@memberId);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* AddFriendByNameAsync_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Services.Friends.IFriendsService instance_of_this_method = (Unity.Services.Friends.IFriendsService)typeof(Unity.Services.Friends.IFriendsService).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AddFriendByNameAsync(@name);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* DeleteBlockAsync_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @memberId = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Services.Friends.IFriendsService instance_of_this_method = (Unity.Services.Friends.IFriendsService)typeof(Unity.Services.Friends.IFriendsService).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DeleteBlockAsync(@memberId);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



    }
}

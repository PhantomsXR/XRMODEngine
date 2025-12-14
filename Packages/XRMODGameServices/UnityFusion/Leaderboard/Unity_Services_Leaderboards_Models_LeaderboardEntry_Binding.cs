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
    unsafe class Unity_Services_Leaderboards_Models_LeaderboardEntry_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Unity.Services.Leaderboards.Models.LeaderboardEntry);
            args = new Type[]{};
            method = type.GetMethod("get_PlayerId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_PlayerId_0);
            args = new Type[]{};
            method = type.GetMethod("get_PlayerName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_PlayerName_1);
            args = new Type[]{};
            method = type.GetMethod("get_Rank", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Rank_2);
            args = new Type[]{};
            method = type.GetMethod("get_Score", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Score_3);
            args = new Type[]{};
            method = type.GetMethod("get_Tier", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Tier_4);
            args = new Type[]{};
            method = type.GetMethod("get_UpdatedTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_UpdatedTime_5);
            args = new Type[]{};
            method = type.GetMethod("get_Metadata", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Metadata_6);


        }


        static StackObject* get_PlayerId_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Services.Leaderboards.Models.LeaderboardEntry instance_of_this_method = (Unity.Services.Leaderboards.Models.LeaderboardEntry)typeof(Unity.Services.Leaderboards.Models.LeaderboardEntry).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.PlayerId;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_PlayerName_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Services.Leaderboards.Models.LeaderboardEntry instance_of_this_method = (Unity.Services.Leaderboards.Models.LeaderboardEntry)typeof(Unity.Services.Leaderboards.Models.LeaderboardEntry).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.PlayerName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Rank_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Services.Leaderboards.Models.LeaderboardEntry instance_of_this_method = (Unity.Services.Leaderboards.Models.LeaderboardEntry)typeof(Unity.Services.Leaderboards.Models.LeaderboardEntry).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Rank;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_Score_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Services.Leaderboards.Models.LeaderboardEntry instance_of_this_method = (Unity.Services.Leaderboards.Models.LeaderboardEntry)typeof(Unity.Services.Leaderboards.Models.LeaderboardEntry).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Score;

            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_Tier_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Services.Leaderboards.Models.LeaderboardEntry instance_of_this_method = (Unity.Services.Leaderboards.Models.LeaderboardEntry)typeof(Unity.Services.Leaderboards.Models.LeaderboardEntry).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Tier;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_UpdatedTime_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Services.Leaderboards.Models.LeaderboardEntry instance_of_this_method = (Unity.Services.Leaderboards.Models.LeaderboardEntry)typeof(Unity.Services.Leaderboards.Models.LeaderboardEntry).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.UpdatedTime;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_Metadata_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Services.Leaderboards.Models.LeaderboardEntry instance_of_this_method = (Unity.Services.Leaderboards.Models.LeaderboardEntry)typeof(Unity.Services.Leaderboards.Models.LeaderboardEntry).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Metadata;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



    }
}

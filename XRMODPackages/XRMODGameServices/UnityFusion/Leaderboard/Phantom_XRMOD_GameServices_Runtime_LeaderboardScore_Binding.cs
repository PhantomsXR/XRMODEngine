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
    unsafe class Phantom_XRMOD_GameServices_Runtime_LeaderboardScore_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.GameServices.Runtime.LeaderboardScore);

            field = type.GetField("PlayerId", flag);
            app.RegisterCLRFieldGetter(field, get_PlayerId_0);
            app.RegisterCLRFieldSetter(field, set_PlayerId_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_PlayerId_0, AssignFromStack_PlayerId_0);
            field = type.GetField("PlayerName", flag);
            app.RegisterCLRFieldGetter(field, get_PlayerName_1);
            app.RegisterCLRFieldSetter(field, set_PlayerName_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_PlayerName_1, AssignFromStack_PlayerName_1);
            field = type.GetField("Rank", flag);
            app.RegisterCLRFieldGetter(field, get_Rank_2);
            app.RegisterCLRFieldSetter(field, set_Rank_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Rank_2, AssignFromStack_Rank_2);
            field = type.GetField("Score", flag);
            app.RegisterCLRFieldGetter(field, get_Score_3);
            app.RegisterCLRFieldSetter(field, set_Score_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Score_3, AssignFromStack_Score_3);
            field = type.GetField("Tier", flag);
            app.RegisterCLRFieldGetter(field, get_Tier_4);
            app.RegisterCLRFieldSetter(field, set_Tier_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Tier_4, AssignFromStack_Tier_4);
            field = type.GetField("UpdatedTime", flag);
            app.RegisterCLRFieldGetter(field, get_UpdatedTime_5);
            app.RegisterCLRFieldSetter(field, set_UpdatedTime_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_UpdatedTime_5, AssignFromStack_UpdatedTime_5);
            field = type.GetField("Metadata", flag);
            app.RegisterCLRFieldGetter(field, get_Metadata_6);
            app.RegisterCLRFieldSetter(field, set_Metadata_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_Metadata_6, AssignFromStack_Metadata_6);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.GameServices.Runtime.LeaderboardScore());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.GameServices.Runtime.LeaderboardScore[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_PlayerId_0(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).PlayerId;
        }

        static StackObject* CopyToStack_PlayerId_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).PlayerId;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PlayerId_0(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).PlayerId = (System.String)v;
        }

        static StackObject* AssignFromStack_PlayerId_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @PlayerId = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).PlayerId = @PlayerId;
            return ptr_of_this_method;
        }

        static object get_PlayerName_1(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).PlayerName;
        }

        static StackObject* CopyToStack_PlayerName_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).PlayerName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PlayerName_1(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).PlayerName = (System.String)v;
        }

        static StackObject* AssignFromStack_PlayerName_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @PlayerName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).PlayerName = @PlayerName;
            return ptr_of_this_method;
        }

        static object get_Rank_2(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).Rank;
        }

        static StackObject* CopyToStack_Rank_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).Rank;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Rank_2(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).Rank = (System.Int32)v;
        }

        static StackObject* AssignFromStack_Rank_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @Rank = ptr_of_this_method->Value;
            ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).Rank = @Rank;
            return ptr_of_this_method;
        }

        static object get_Score_3(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).Score;
        }

        static StackObject* CopyToStack_Score_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).Score;
            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Score_3(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).Score = (System.Double)v;
        }

        static StackObject* AssignFromStack_Score_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Double @Score = *(double*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).Score = @Score;
            return ptr_of_this_method;
        }

        static object get_Tier_4(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).Tier;
        }

        static StackObject* CopyToStack_Tier_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).Tier;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Tier_4(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).Tier = (System.String)v;
        }

        static StackObject* AssignFromStack_Tier_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @Tier = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).Tier = @Tier;
            return ptr_of_this_method;
        }

        static object get_UpdatedTime_5(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).UpdatedTime;
        }

        static StackObject* CopyToStack_UpdatedTime_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).UpdatedTime;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_UpdatedTime_5(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).UpdatedTime = (System.DateTime)v;
        }

        static StackObject* AssignFromStack_UpdatedTime_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.DateTime @UpdatedTime = (System.DateTime)typeof(System.DateTime).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).UpdatedTime = @UpdatedTime;
            return ptr_of_this_method;
        }

        static object get_Metadata_6(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).Metadata;
        }

        static StackObject* CopyToStack_Metadata_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).Metadata;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Metadata_6(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).Metadata = (System.String)v;
        }

        static StackObject* AssignFromStack_Metadata_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @Metadata = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.LeaderboardScore)o).Metadata = @Metadata;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.GameServices.Runtime.LeaderboardScore();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

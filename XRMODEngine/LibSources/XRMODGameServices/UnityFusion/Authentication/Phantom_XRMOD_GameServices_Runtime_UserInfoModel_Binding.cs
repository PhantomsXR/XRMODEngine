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
    unsafe class Phantom_XRMOD_GameServices_Runtime_UserInfoModel_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.GameServices.Runtime.UserInfoModel);
            args = new Type[] { };
            method = type.GetMethod("CleanUp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CleanUp_0);

            field = type.GetField("token", flag);
            app.RegisterCLRFieldGetter(field, get_token_0);
            app.RegisterCLRFieldSetter(field, set_token_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_token_0, AssignFromStack_token_0);
            field = type.GetField("player_name", flag);
            app.RegisterCLRFieldGetter(field, get_player_name_1);
            app.RegisterCLRFieldSetter(field, set_player_name_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_player_name_1, AssignFromStack_player_name_1);
            field = type.GetField("email", flag);
            app.RegisterCLRFieldGetter(field, get_email_3);
            app.RegisterCLRFieldSetter(field, set_email_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_email_3, AssignFromStack_email_3);
            field = type.GetField("user_avatar", flag);
            app.RegisterCLRFieldGetter(field, get_user_avatar_4);
            app.RegisterCLRFieldSetter(field, set_user_avatar_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_user_avatar_4, AssignFromStack_user_avatar_4);
            field = type.GetField("mobile", flag);
            app.RegisterCLRFieldGetter(field, get_mobile_5);
            app.RegisterCLRFieldSetter(field, set_mobile_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_mobile_5, AssignFromStack_mobile_5);
            field = type.GetField("accountId", flag);
            app.RegisterCLRFieldGetter(field, get_accountId_6);
            app.RegisterCLRFieldSetter(field, set_accountId_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_accountId_6, AssignFromStack_accountId_6);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.GameServices.Runtime.UserInfoModel());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.GameServices.Runtime.UserInfoModel[s]);

            args = new Type[] { };
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static StackObject* CleanUp_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.GameServices.Runtime.UserInfoModel instance_of_this_method =
                (Phantom.XRMOD.GameServices.Runtime.UserInfoModel)
                typeof(Phantom.XRMOD.GameServices.Runtime.UserInfoModel).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CleanUp();

            return __ret;
        }


        static object get_token_0(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).token;
        }

        static StackObject* CopyToStack_token_0(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).token;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_token_0(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).token = (System.String) v;
        }

        static StackObject* AssignFromStack_token_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method,
            AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @token = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).token = @token;
            return ptr_of_this_method;
        }

        static object get_player_name_1(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).player_name;
        }

        static StackObject* CopyToStack_player_name_1(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).player_name;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_player_name_1(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).player_name = (System.String) v;
        }

        static StackObject* AssignFromStack_player_name_1(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @player_name = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).player_name = @player_name;
            return ptr_of_this_method;
        }


        static object get_email_3(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).email;
        }

        static StackObject* CopyToStack_email_3(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).email;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_email_3(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).email = (System.String) v;
        }

        static StackObject* AssignFromStack_email_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method,
            AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @email = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).email = @email;
            return ptr_of_this_method;
        }

        static object get_user_avatar_4(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).user_avatar;
        }

        static StackObject* CopyToStack_user_avatar_4(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).user_avatar;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_user_avatar_4(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).user_avatar = (System.String) v;
        }

        static StackObject* AssignFromStack_user_avatar_4(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @user_avatar = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).user_avatar = @user_avatar;
            return ptr_of_this_method;
        }

        static object get_mobile_5(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).mobile;
        }

        static StackObject* CopyToStack_mobile_5(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).mobile;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_mobile_5(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).mobile = (System.String) v;
        }

        static StackObject* AssignFromStack_mobile_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method,
            AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @mobile = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).mobile = @mobile;
            return ptr_of_this_method;
        }

        static object get_accountId_6(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).accountId;
        }

        static StackObject* CopyToStack_accountId_6(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).accountId;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_accountId_6(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).accountId = (System.String) v;
        }

        static StackObject* AssignFromStack_accountId_6(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @accountId = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.GameServices.Runtime.UserInfoModel) o).accountId = @accountId;
            return ptr_of_this_method;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.GameServices.Runtime.UserInfoModel();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}
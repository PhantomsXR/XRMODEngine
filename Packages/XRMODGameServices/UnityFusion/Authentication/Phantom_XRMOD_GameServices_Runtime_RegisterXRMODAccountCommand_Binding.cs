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
    unsafe class Phantom_XRMOD_GameServices_Runtime_RegisterXRMODAccountCommand_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.GameServices.Runtime.RegisterXRMODAccountCommand);
            args = new Type[]{typeof(Phantom.XRMOD.GameServices.Runtime.UserInfoModel)};
            method = type.GetMethod("Execute", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Execute_0);

            field = type.GetField("CONST_XRMOD_ACCOUNT_TOKEN", flag);
            app.RegisterCLRFieldGetter(field, get_CONST_XRMOD_ACCOUNT_TOKEN_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_CONST_XRMOD_ACCOUNT_TOKEN_0, null);
            field = type.GetField("CONST_DEFAULT_AVATAR_IMG", flag);
            app.RegisterCLRFieldGetter(field, get_CONST_DEFAULT_AVATAR_IMG_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_CONST_DEFAULT_AVATAR_IMG_1, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.GameServices.Runtime.RegisterXRMODAccountCommand());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.GameServices.Runtime.RegisterXRMODAccountCommand[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Execute_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.GameServices.Runtime.UserInfoModel @_userInfoModel = (Phantom.XRMOD.GameServices.Runtime.UserInfoModel)typeof(Phantom.XRMOD.GameServices.Runtime.UserInfoModel).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.GameServices.Runtime.RegisterXRMODAccountCommand instance_of_this_method = (Phantom.XRMOD.GameServices.Runtime.RegisterXRMODAccountCommand)typeof(Phantom.XRMOD.GameServices.Runtime.RegisterXRMODAccountCommand).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Execute(@_userInfoModel);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_CONST_XRMOD_ACCOUNT_TOKEN_0(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.RegisterXRMODAccountCommand.CONST_XRMOD_ACCOUNT_TOKEN;
        }

        static StackObject* CopyToStack_CONST_XRMOD_ACCOUNT_TOKEN_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.RegisterXRMODAccountCommand.CONST_XRMOD_ACCOUNT_TOKEN;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_CONST_DEFAULT_AVATAR_IMG_1(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.RegisterXRMODAccountCommand.CONST_DEFAULT_AVATAR_IMG;
        }

        static StackObject* CopyToStack_CONST_DEFAULT_AVATAR_IMG_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.RegisterXRMODAccountCommand.CONST_DEFAULT_AVATAR_IMG;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.GameServices.Runtime.RegisterXRMODAccountCommand();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

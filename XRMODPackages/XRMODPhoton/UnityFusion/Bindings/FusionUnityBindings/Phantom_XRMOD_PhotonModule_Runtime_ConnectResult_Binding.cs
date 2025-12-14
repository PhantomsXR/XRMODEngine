#if FUSION2 && XRMOD_INSTALL
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
    unsafe class Phantom_XRMOD_PhotonModule_Runtime_ConnectResult_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.PhotonModule.Runtime.ConnectResult);

            field = type.GetField("Success", flag);
            app.RegisterCLRFieldGetter(field, get_Success_0);
            app.RegisterCLRFieldSetter(field, set_Success_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Success_0, AssignFromStack_Success_0);
            field = type.GetField("FailReason", flag);
            app.RegisterCLRFieldGetter(field, get_FailReason_1);
            app.RegisterCLRFieldSetter(field, set_FailReason_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_FailReason_1, AssignFromStack_FailReason_1);
            field = type.GetField("DisconnectCause", flag);
            app.RegisterCLRFieldGetter(field, get_DisconnectCause_2);
            app.RegisterCLRFieldSetter(field, set_DisconnectCause_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_DisconnectCause_2, AssignFromStack_DisconnectCause_2);
            field = type.GetField("DebugMessage", flag);
            app.RegisterCLRFieldGetter(field, get_DebugMessage_3);
            app.RegisterCLRFieldSetter(field, set_DebugMessage_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_DebugMessage_3, AssignFromStack_DebugMessage_3);
            field = type.GetField("CustomResultHandling", flag);
            app.RegisterCLRFieldGetter(field, get_CustomResultHandling_4);
            app.RegisterCLRFieldSetter(field, set_CustomResultHandling_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_CustomResultHandling_4, AssignFromStack_CustomResultHandling_4);
            field = type.GetField("WaitForCleanup", flag);
            app.RegisterCLRFieldGetter(field, get_WaitForCleanup_5);
            app.RegisterCLRFieldSetter(field, set_WaitForCleanup_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_WaitForCleanup_5, AssignFromStack_WaitForCleanup_5);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.PhotonModule.Runtime.ConnectResult());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.PhotonModule.Runtime.ConnectResult[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_Success_0(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).Success;
        }

        static StackObject* CopyToStack_Success_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).Success;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_Success_0(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).Success = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_Success_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @Success = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).Success = @Success;
            return ptr_of_this_method;
        }

        static object get_FailReason_1(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).FailReason;
        }

        static StackObject* CopyToStack_FailReason_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).FailReason;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_FailReason_1(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).FailReason = (System.Int32)v;
        }

        static StackObject* AssignFromStack_FailReason_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @FailReason = ptr_of_this_method->Value;
            ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).FailReason = @FailReason;
            return ptr_of_this_method;
        }

        static object get_DisconnectCause_2(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).DisconnectCause;
        }

        static StackObject* CopyToStack_DisconnectCause_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).DisconnectCause;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_DisconnectCause_2(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).DisconnectCause = (System.Int32)v;
        }

        static StackObject* AssignFromStack_DisconnectCause_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @DisconnectCause = ptr_of_this_method->Value;
            ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).DisconnectCause = @DisconnectCause;
            return ptr_of_this_method;
        }

        static object get_DebugMessage_3(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).DebugMessage;
        }

        static StackObject* CopyToStack_DebugMessage_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).DebugMessage;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_DebugMessage_3(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).DebugMessage = (System.String)v;
        }

        static StackObject* AssignFromStack_DebugMessage_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @DebugMessage = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).DebugMessage = @DebugMessage;
            return ptr_of_this_method;
        }

        static object get_CustomResultHandling_4(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).CustomResultHandling;
        }

        static StackObject* CopyToStack_CustomResultHandling_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).CustomResultHandling;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_CustomResultHandling_4(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).CustomResultHandling = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_CustomResultHandling_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @CustomResultHandling = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).CustomResultHandling = @CustomResultHandling;
            return ptr_of_this_method;
        }

        static object get_WaitForCleanup_5(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).WaitForCleanup;
        }

        static StackObject* CopyToStack_WaitForCleanup_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).WaitForCleanup;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_WaitForCleanup_5(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).WaitForCleanup = (System.Threading.Tasks.Task)v;
        }

        static StackObject* AssignFromStack_WaitForCleanup_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Threading.Tasks.Task @WaitForCleanup = (System.Threading.Tasks.Task)typeof(System.Threading.Tasks.Task).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.PhotonModule.Runtime.ConnectResult)o).WaitForCleanup = @WaitForCleanup;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.PhotonModule.Runtime.ConnectResult();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
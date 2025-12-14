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
    unsafe class Phantom_XRMOD_GameServices_Runtime_WebResponse_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.GameServices.Runtime.WebResponse);

            field = type.GetField("status_code", flag);
            app.RegisterCLRFieldGetter(field, get_status_code_0);
            app.RegisterCLRFieldSetter(field, set_status_code_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_status_code_0, AssignFromStack_status_code_0);
            field = type.GetField("msg", flag);
            app.RegisterCLRFieldGetter(field, get_msg_1);
            app.RegisterCLRFieldSetter(field, set_msg_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_msg_1, AssignFromStack_msg_1);
            field = type.GetField("data", flag);
            app.RegisterCLRFieldGetter(field, get_data_2);
            app.RegisterCLRFieldSetter(field, set_data_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_data_2, AssignFromStack_data_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.GameServices.Runtime.WebResponse());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.GameServices.Runtime.WebResponse[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_status_code_0(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.WebResponse)o).status_code;
        }

        static StackObject* CopyToStack_status_code_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.WebResponse)o).status_code;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_status_code_0(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.WebResponse)o).status_code = (System.Int32)v;
        }

        static StackObject* AssignFromStack_status_code_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @status_code = ptr_of_this_method->Value;
            ((Phantom.XRMOD.GameServices.Runtime.WebResponse)o).status_code = @status_code;
            return ptr_of_this_method;
        }

        static object get_msg_1(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.WebResponse)o).msg;
        }

        static StackObject* CopyToStack_msg_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.WebResponse)o).msg;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_msg_1(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.WebResponse)o).msg = (System.String)v;
        }

        static StackObject* AssignFromStack_msg_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @msg = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.WebResponse)o).msg = @msg;
            return ptr_of_this_method;
        }

        static object get_data_2(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.WebResponse)o).data;
        }

        static StackObject* CopyToStack_data_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.WebResponse)o).data;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_data_2(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.WebResponse)o).data = (Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody)v;
        }

        static StackObject* AssignFromStack_data_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody @data = (Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody)typeof(Phantom.XRMOD.GameServices.Runtime.WebResponseDataBody).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.WebResponse)o).data = @data;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.GameServices.Runtime.WebResponse();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

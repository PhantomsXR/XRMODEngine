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
    unsafe class Unity_Netcode_ServerRpcAttribute_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Netcode.ServerRpcAttribute);

            field = type.GetField("RequireOwnership", flag);
            app.RegisterCLRFieldGetter(field, get_RequireOwnership_0);
            app.RegisterCLRFieldSetter(field, set_RequireOwnership_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_RequireOwnership_0, AssignFromStack_RequireOwnership_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.Netcode.ServerRpcAttribute());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Netcode.ServerRpcAttribute[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_RequireOwnership_0(ref object o)
        {
            return ((Unity.Netcode.ServerRpcAttribute)o).RequireOwnership;
        }

        static StackObject* CopyToStack_RequireOwnership_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.ServerRpcAttribute)o).RequireOwnership;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_RequireOwnership_0(ref object o, object v)
        {
            ((Unity.Netcode.ServerRpcAttribute)o).RequireOwnership = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_RequireOwnership_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @RequireOwnership = ptr_of_this_method->Value == 1;
            ((Unity.Netcode.ServerRpcAttribute)o).RequireOwnership = @RequireOwnership;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Unity.Netcode.ServerRpcAttribute();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

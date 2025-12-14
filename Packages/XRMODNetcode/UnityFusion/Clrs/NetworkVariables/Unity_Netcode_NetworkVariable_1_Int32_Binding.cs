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
    unsafe class Unity_Netcode_NetworkVariable_1_Int32_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Netcode.NetworkVariable<System.Int32>);
            args = new Type[]{};
            method = type.GetMethod("get_Value", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Value_0);

            field = type.GetField("OnValueChanged", flag);
            app.RegisterCLRFieldGetter(field, get_OnValueChanged_0);
            app.RegisterCLRFieldSetter(field, set_OnValueChanged_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnValueChanged_0, AssignFromStack_OnValueChanged_0);

            args = new Type[]{typeof(System.Int32), typeof(Unity.Netcode.NetworkVariableReadPermission), typeof(Unity.Netcode.NetworkVariableWritePermission)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_Value_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkVariable<System.Int32> instance_of_this_method = (Unity.Netcode.NetworkVariable<System.Int32>)typeof(Unity.Netcode.NetworkVariable<System.Int32>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Value;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }


        static object get_OnValueChanged_0(ref object o)
        {
            return ((Unity.Netcode.NetworkVariable<System.Int32>)o).OnValueChanged;
        }

        static StackObject* CopyToStack_OnValueChanged_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.NetworkVariable<System.Int32>)o).OnValueChanged;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnValueChanged_0(ref object o, object v)
        {
            ((Unity.Netcode.NetworkVariable<System.Int32>)o).OnValueChanged = (Unity.Netcode.NetworkVariable<System.Int32>.OnValueChangedDelegate)v;
        }

        static StackObject* AssignFromStack_OnValueChanged_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.NetworkVariable<System.Int32>.OnValueChangedDelegate @OnValueChanged = (Unity.Netcode.NetworkVariable<System.Int32>.OnValueChangedDelegate)typeof(Unity.Netcode.NetworkVariable<System.Int32>.OnValueChangedDelegate).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Unity.Netcode.NetworkVariable<System.Int32>)o).OnValueChanged = @OnValueChanged;
            return ptr_of_this_method;
        }


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.NetworkVariableWritePermission @writePerm = (Unity.Netcode.NetworkVariableWritePermission)typeof(Unity.Netcode.NetworkVariableWritePermission).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.NetworkVariableReadPermission @readPerm = (Unity.Netcode.NetworkVariableReadPermission)typeof(Unity.Netcode.NetworkVariableReadPermission).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @value = ptr_of_this_method->Value;


            var result_of_this_method = new Unity.Netcode.NetworkVariable<System.Int32>(@value, @readPerm, @writePerm);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

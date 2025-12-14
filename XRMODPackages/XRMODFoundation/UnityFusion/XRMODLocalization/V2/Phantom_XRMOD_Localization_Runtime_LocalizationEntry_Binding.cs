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
    unsafe class Phantom_XRMOD_Localization_Runtime_LocalizationEntry_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.Localization.Runtime.LocalizationEntry);

            field = type.GetField("Key", flag);
            app.RegisterCLRFieldGetter(field, get_Key_0);
            app.RegisterCLRFieldSetter(field, set_Key_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Key_0, AssignFromStack_Key_0);


        }



        static object get_Key_0(ref object o)
        {
            return ((Phantom.XRMOD.Localization.Runtime.LocalizationEntry)o).Key;
        }

        static StackObject* CopyToStack_Key_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.Localization.Runtime.LocalizationEntry)o).Key;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Key_0(ref object o, object v)
        {
            ((Phantom.XRMOD.Localization.Runtime.LocalizationEntry)o).Key = (System.String)v;
        }

        static StackObject* AssignFromStack_Key_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @Key = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.Localization.Runtime.LocalizationEntry)o).Key = @Key;
            return ptr_of_this_method;
        }



    }
}

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
    unsafe class Phantom_XRMOD_Localization_Runtime_LocalizationDatabase_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.Localization.Runtime.LocalizationDatabase);

            field = type.GetField("Tables", flag);
            app.RegisterCLRFieldGetter(field, get_Tables_0);
            app.RegisterCLRFieldSetter(field, set_Tables_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Tables_0, AssignFromStack_Tables_0);


        }



        static object get_Tables_0(ref object o)
        {
            return ((Phantom.XRMOD.Localization.Runtime.LocalizationDatabase)o).Tables;
        }

        static StackObject* CopyToStack_Tables_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.Localization.Runtime.LocalizationDatabase)o).Tables;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Tables_0(ref object o, object v)
        {
            ((Phantom.XRMOD.Localization.Runtime.LocalizationDatabase)o).Tables = (System.Collections.Generic.List<Phantom.XRMOD.Localization.Runtime.LocalizationTable>)v;
        }

        static StackObject* AssignFromStack_Tables_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.List<Phantom.XRMOD.Localization.Runtime.LocalizationTable> @Tables = (System.Collections.Generic.List<Phantom.XRMOD.Localization.Runtime.LocalizationTable>)typeof(System.Collections.Generic.List<Phantom.XRMOD.Localization.Runtime.LocalizationTable>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.Localization.Runtime.LocalizationDatabase)o).Tables = @Tables;
            return ptr_of_this_method;
        }



    }
}

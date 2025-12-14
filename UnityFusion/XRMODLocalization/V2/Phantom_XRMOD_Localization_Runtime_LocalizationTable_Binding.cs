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
    unsafe class Phantom_XRMOD_Localization_Runtime_LocalizationTable_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.Localization.Runtime.LocalizationTable);

            field = type.GetField("Entries", flag);
            app.RegisterCLRFieldGetter(field, get_Entries_0);
            app.RegisterCLRFieldSetter(field, set_Entries_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Entries_0, AssignFromStack_Entries_0);


        }



        static object get_Entries_0(ref object o)
        {
            return ((Phantom.XRMOD.Localization.Runtime.LocalizationTable)o).Entries;
        }

        static StackObject* CopyToStack_Entries_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.Localization.Runtime.LocalizationTable)o).Entries;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Entries_0(ref object o, object v)
        {
            ((Phantom.XRMOD.Localization.Runtime.LocalizationTable)o).Entries = (System.Collections.Generic.List<Phantom.XRMOD.Localization.Runtime.LocalizationEntry>)v;
        }

        static StackObject* AssignFromStack_Entries_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.List<Phantom.XRMOD.Localization.Runtime.LocalizationEntry> @Entries = (System.Collections.Generic.List<Phantom.XRMOD.Localization.Runtime.LocalizationEntry>)typeof(System.Collections.Generic.List<Phantom.XRMOD.Localization.Runtime.LocalizationEntry>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.Localization.Runtime.LocalizationTable)o).Entries = @Entries;
            return ptr_of_this_method;
        }



    }
}

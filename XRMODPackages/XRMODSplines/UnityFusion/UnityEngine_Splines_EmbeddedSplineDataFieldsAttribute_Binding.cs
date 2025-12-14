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
    unsafe class UnityEngine_Splines_EmbeddedSplineDataFieldsAttribute_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Splines.EmbeddedSplineDataFieldsAttribute);

            field = type.GetField("Fields", flag);
            app.RegisterCLRFieldGetter(field, get_Fields_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Fields_0, null);


            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Splines.EmbeddedSplineDataFieldsAttribute[s]);

            args = new Type[]{typeof(UnityEngine.Splines.EmbeddedSplineDataField)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_Fields_0(ref object o)
        {
            return ((UnityEngine.Splines.EmbeddedSplineDataFieldsAttribute)o).Fields;
        }

        static StackObject* CopyToStack_Fields_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Splines.EmbeddedSplineDataFieldsAttribute)o).Fields;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.EmbeddedSplineDataField @fields = (UnityEngine.Splines.EmbeddedSplineDataField)typeof(UnityEngine.Splines.EmbeddedSplineDataField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new UnityEngine.Splines.EmbeddedSplineDataFieldsAttribute(@fields);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

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
    unsafe class EPPZ_Persistence_JSONSerializer_Binding_Mode_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field; 
            Type type = typeof(EPPZ.Persistence.JSONSerializer.Mode);

            field = type.GetField("Default", flag);
            app.RegisterCLRFieldGetter(field, get_Default_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Default_0, null);
            field = type.GetField("Pretty", flag);
            app.RegisterCLRFieldGetter(field, get_Pretty_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Pretty_1, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new EPPZ.Persistence.JSONSerializer.Mode());
            app.RegisterCLRCreateArrayInstance(type, s => new EPPZ.Persistence.JSONSerializer.Mode[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref EPPZ.Persistence.JSONSerializer.Mode instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as EPPZ.Persistence.JSONSerializer.Mode[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Default_0(ref object o)
        {
            return EPPZ.Persistence.JSONSerializer.Mode.Default;
        }

        static StackObject* CopyToStack_Default_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = EPPZ.Persistence.JSONSerializer.Mode.Default;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Pretty_1(ref object o)
        {
            return EPPZ.Persistence.JSONSerializer.Mode.Pretty;
        }

        static StackObject* CopyToStack_Pretty_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = EPPZ.Persistence.JSONSerializer.Mode.Pretty;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new EPPZ.Persistence.JSONSerializer.Mode();
            ins = (EPPZ.Persistence.JSONSerializer.Mode)o;
            return ins;
        }


    }
}
#endif
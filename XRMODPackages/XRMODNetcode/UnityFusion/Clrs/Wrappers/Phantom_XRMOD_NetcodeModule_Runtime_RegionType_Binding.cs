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
    unsafe class Phantom_XRMOD_NetcodeModule_Runtime_RegionType_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.NetcodeModule.Runtime.RegionType);

            field = type.GetField("SouthCarolina", flag);
            app.RegisterCLRFieldGetter(field, get_SouthCarolina_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_SouthCarolina_0, null);
            field = type.GetField("Iowa", flag);
            app.RegisterCLRFieldGetter(field, get_Iowa_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Iowa_1, null);
            field = type.GetField("Oregon", flag);
            app.RegisterCLRFieldGetter(field, get_Oregon_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Oregon_2, null);
            field = type.GetField("SaoPaulo", flag);
            app.RegisterCLRFieldGetter(field, get_SaoPaulo_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_SaoPaulo_3, null);
            field = type.GetField("Finland", flag);
            app.RegisterCLRFieldGetter(field, get_Finland_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Finland_4, null);
            field = type.GetField("Poland", flag);
            app.RegisterCLRFieldGetter(field, get_Poland_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_Poland_5, null);
            field = type.GetField("Netherlands", flag);
            app.RegisterCLRFieldGetter(field, get_Netherlands_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_Netherlands_6, null);
            field = type.GetField("Singapore", flag);
            app.RegisterCLRFieldGetter(field, get_Singapore_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_Singapore_7, null);
            field = type.GetField("Tokyo", flag);
            app.RegisterCLRFieldGetter(field, get_Tokyo_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_Tokyo_8, null);
            field = type.GetField("Mumbai", flag);
            app.RegisterCLRFieldGetter(field, get_Mumbai_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_Mumbai_9, null);
            field = type.GetField("Sydney", flag);
            app.RegisterCLRFieldGetter(field, get_Sydney_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_Sydney_10, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.NetcodeModule.Runtime.RegionType());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.NetcodeModule.Runtime.RegionType[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Phantom.XRMOD.NetcodeModule.Runtime.RegionType instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Phantom.XRMOD.NetcodeModule.Runtime.RegionType[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_SouthCarolina_0(ref object o)
        {
            return Phantom.XRMOD.NetcodeModule.Runtime.RegionType.SouthCarolina;
        }

        static StackObject* CopyToStack_SouthCarolina_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.NetcodeModule.Runtime.RegionType.SouthCarolina;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Iowa_1(ref object o)
        {
            return Phantom.XRMOD.NetcodeModule.Runtime.RegionType.Iowa;
        }

        static StackObject* CopyToStack_Iowa_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.NetcodeModule.Runtime.RegionType.Iowa;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Oregon_2(ref object o)
        {
            return Phantom.XRMOD.NetcodeModule.Runtime.RegionType.Oregon;
        }

        static StackObject* CopyToStack_Oregon_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.NetcodeModule.Runtime.RegionType.Oregon;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_SaoPaulo_3(ref object o)
        {
            return Phantom.XRMOD.NetcodeModule.Runtime.RegionType.SaoPaulo;
        }

        static StackObject* CopyToStack_SaoPaulo_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.NetcodeModule.Runtime.RegionType.SaoPaulo;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Finland_4(ref object o)
        {
            return Phantom.XRMOD.NetcodeModule.Runtime.RegionType.Finland;
        }

        static StackObject* CopyToStack_Finland_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.NetcodeModule.Runtime.RegionType.Finland;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Poland_5(ref object o)
        {
            return Phantom.XRMOD.NetcodeModule.Runtime.RegionType.Poland;
        }

        static StackObject* CopyToStack_Poland_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.NetcodeModule.Runtime.RegionType.Poland;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Netherlands_6(ref object o)
        {
            return Phantom.XRMOD.NetcodeModule.Runtime.RegionType.Netherlands;
        }

        static StackObject* CopyToStack_Netherlands_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.NetcodeModule.Runtime.RegionType.Netherlands;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Singapore_7(ref object o)
        {
            return Phantom.XRMOD.NetcodeModule.Runtime.RegionType.Singapore;
        }

        static StackObject* CopyToStack_Singapore_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.NetcodeModule.Runtime.RegionType.Singapore;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Tokyo_8(ref object o)
        {
            return Phantom.XRMOD.NetcodeModule.Runtime.RegionType.Tokyo;
        }

        static StackObject* CopyToStack_Tokyo_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.NetcodeModule.Runtime.RegionType.Tokyo;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Mumbai_9(ref object o)
        {
            return Phantom.XRMOD.NetcodeModule.Runtime.RegionType.Mumbai;
        }

        static StackObject* CopyToStack_Mumbai_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.NetcodeModule.Runtime.RegionType.Mumbai;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Sydney_10(ref object o)
        {
            return Phantom.XRMOD.NetcodeModule.Runtime.RegionType.Sydney;
        }

        static StackObject* CopyToStack_Sydney_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.NetcodeModule.Runtime.RegionType.Sydney;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Phantom.XRMOD.NetcodeModule.Runtime.RegionType();
            ins = (Phantom.XRMOD.NetcodeModule.Runtime.RegionType)o;
            return ins;
        }


    }
}

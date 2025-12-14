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
    unsafe class Phantom_XRMOD_GameServices_Runtime_PlatformProviderType_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.GameServices.Runtime.PlatformProviderType);

            field = type.GetField("Apple", flag);
            app.RegisterCLRFieldGetter(field, get_Apple_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Apple_0, null);
            field = type.GetField("Google", flag);
            app.RegisterCLRFieldGetter(field, get_Google_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Google_1, null);
            field = type.GetField("Meta", flag);
            app.RegisterCLRFieldGetter(field, get_Meta_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Meta_2, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.GameServices.Runtime.PlatformProviderType());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.GameServices.Runtime.PlatformProviderType[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Phantom.XRMOD.GameServices.Runtime.PlatformProviderType instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Phantom.XRMOD.GameServices.Runtime.PlatformProviderType[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Apple_0(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.PlatformProviderType.Apple;
        }

        static StackObject* CopyToStack_Apple_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.PlatformProviderType.Apple;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Google_1(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.PlatformProviderType.Google;
        }

        static StackObject* CopyToStack_Google_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.PlatformProviderType.Google;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Meta_2(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.PlatformProviderType.Meta;
        }

        static StackObject* CopyToStack_Meta_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.PlatformProviderType.Meta;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Phantom.XRMOD.GameServices.Runtime.PlatformProviderType();
            ins = (Phantom.XRMOD.GameServices.Runtime.PlatformProviderType)o;
            return ins;
        }


    }
}

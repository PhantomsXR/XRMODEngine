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
    unsafe class Unity_Netcode_SendTo_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Netcode.SendTo);

            field = type.GetField("Owner", flag);
            app.RegisterCLRFieldGetter(field, get_Owner_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Owner_0, null);
            field = type.GetField("NotOwner", flag);
            app.RegisterCLRFieldGetter(field, get_NotOwner_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_NotOwner_1, null);
            field = type.GetField("Server", flag);
            app.RegisterCLRFieldGetter(field, get_Server_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Server_2, null);
            field = type.GetField("NotServer", flag);
            app.RegisterCLRFieldGetter(field, get_NotServer_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_NotServer_3, null);
            field = type.GetField("Me", flag);
            app.RegisterCLRFieldGetter(field, get_Me_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Me_4, null);
            field = type.GetField("NotMe", flag);
            app.RegisterCLRFieldGetter(field, get_NotMe_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_NotMe_5, null);
            field = type.GetField("Everyone", flag);
            app.RegisterCLRFieldGetter(field, get_Everyone_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_Everyone_6, null);
            field = type.GetField("ClientsAndHost", flag);
            app.RegisterCLRFieldGetter(field, get_ClientsAndHost_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientsAndHost_7, null);
            field = type.GetField("Authority", flag);
            app.RegisterCLRFieldGetter(field, get_Authority_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_Authority_8, null);
            field = type.GetField("NotAuthority", flag);
            app.RegisterCLRFieldGetter(field, get_NotAuthority_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_NotAuthority_9, null);
            field = type.GetField("SpecifiedInParams", flag);
            app.RegisterCLRFieldGetter(field, get_SpecifiedInParams_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_SpecifiedInParams_10, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.Netcode.SendTo());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Netcode.SendTo[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Unity.Netcode.SendTo instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Unity.Netcode.SendTo[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Owner_0(ref object o)
        {
            return Unity.Netcode.SendTo.Owner;
        }

        static StackObject* CopyToStack_Owner_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.SendTo.Owner;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_NotOwner_1(ref object o)
        {
            return Unity.Netcode.SendTo.NotOwner;
        }

        static StackObject* CopyToStack_NotOwner_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.SendTo.NotOwner;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Server_2(ref object o)
        {
            return Unity.Netcode.SendTo.Server;
        }

        static StackObject* CopyToStack_Server_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.SendTo.Server;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_NotServer_3(ref object o)
        {
            return Unity.Netcode.SendTo.NotServer;
        }

        static StackObject* CopyToStack_NotServer_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.SendTo.NotServer;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Me_4(ref object o)
        {
            return Unity.Netcode.SendTo.Me;
        }

        static StackObject* CopyToStack_Me_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.SendTo.Me;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_NotMe_5(ref object o)
        {
            return Unity.Netcode.SendTo.NotMe;
        }

        static StackObject* CopyToStack_NotMe_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.SendTo.NotMe;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Everyone_6(ref object o)
        {
            return Unity.Netcode.SendTo.Everyone;
        }

        static StackObject* CopyToStack_Everyone_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.SendTo.Everyone;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ClientsAndHost_7(ref object o)
        {
            return Unity.Netcode.SendTo.ClientsAndHost;
        }

        static StackObject* CopyToStack_ClientsAndHost_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.SendTo.ClientsAndHost;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Authority_8(ref object o)
        {
            return Unity.Netcode.SendTo.Authority;
        }

        static StackObject* CopyToStack_Authority_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.SendTo.Authority;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_NotAuthority_9(ref object o)
        {
            return Unity.Netcode.SendTo.NotAuthority;
        }

        static StackObject* CopyToStack_NotAuthority_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.SendTo.NotAuthority;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_SpecifiedInParams_10(ref object o)
        {
            return Unity.Netcode.SendTo.SpecifiedInParams;
        }

        static StackObject* CopyToStack_SpecifiedInParams_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Unity.Netcode.SendTo.SpecifiedInParams;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Unity.Netcode.SendTo();
            ins = (Unity.Netcode.SendTo)o;
            return ins;
        }


    }
}

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
    unsafe class Fusion_SessionLobby_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field; 
            Type type = typeof(Fusion.SessionLobby);

            field = type.GetField("Invalid", flag);
            app.RegisterCLRFieldGetter(field, get_Invalid_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Invalid_0, null);
            field = type.GetField("ClientServer", flag);
            app.RegisterCLRFieldGetter(field, get_ClientServer_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientServer_1, null);
            field = type.GetField("Shared", flag);
            app.RegisterCLRFieldGetter(field, get_Shared_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Shared_2, null);
            field = type.GetField("Custom", flag);
            app.RegisterCLRFieldGetter(field, get_Custom_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Custom_3, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.SessionLobby());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.SessionLobby[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Fusion.SessionLobby instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Fusion.SessionLobby[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Invalid_0(ref object o)
        {
            return Fusion.SessionLobby.Invalid;
        }

        static StackObject* CopyToStack_Invalid_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.SessionLobby.Invalid;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ClientServer_1(ref object o)
        {
            return Fusion.SessionLobby.ClientServer;
        }

        static StackObject* CopyToStack_ClientServer_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.SessionLobby.ClientServer;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Shared_2(ref object o)
        {
            return Fusion.SessionLobby.Shared;
        }

        static StackObject* CopyToStack_Shared_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.SessionLobby.Shared;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Custom_3(ref object o)
        {
            return Fusion.SessionLobby.Custom;
        }

        static StackObject* CopyToStack_Custom_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.SessionLobby.Custom;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Fusion.SessionLobby();
            ins = (Fusion.SessionLobby)o;
            return ins;
        }


    }
}

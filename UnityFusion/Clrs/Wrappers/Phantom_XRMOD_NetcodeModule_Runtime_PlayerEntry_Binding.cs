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
    unsafe class Phantom_XRMOD_NetcodeModule_Runtime_PlayerEntry_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry);
            args = new Type[]{typeof(Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry)};
            method = type.GetMethod("Equals", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Equals_0);

            field = type.GetField("ClientId", flag);
            app.RegisterCLRFieldGetter(field, get_ClientId_0);
            app.RegisterCLRFieldSetter(field, set_ClientId_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_ClientId_0, AssignFromStack_ClientId_0);
            field = type.GetField("PlayerObject", flag);
            app.RegisterCLRFieldGetter(field, get_PlayerObject_1);
            app.RegisterCLRFieldSetter(field, set_PlayerObject_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_PlayerObject_1, AssignFromStack_PlayerObject_1);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* Equals_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry @_other = (Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.Equals(@_other);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static object get_ClientId_0(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry)o).ClientId;
        }

        static StackObject* CopyToStack_ClientId_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry)o).ClientId;
            __ret->ObjectType = ObjectTypes.Long;
            *(ulong*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_ClientId_0(ref object o, object v)
        {
            Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry ins =(Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry)o;
            ins.ClientId = (System.UInt64)v;
            o = ins;
        }

        static StackObject* AssignFromStack_ClientId_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.UInt64 @ClientId = *(ulong*)&ptr_of_this_method->Value;
            Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry ins =(Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry)o;
            ins.ClientId = @ClientId;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_PlayerObject_1(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry)o).PlayerObject;
        }

        static StackObject* CopyToStack_PlayerObject_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry)o).PlayerObject;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PlayerObject_1(ref object o, object v)
        {
            Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry ins =(Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry)o;
            ins.PlayerObject = (Unity.Netcode.NetworkObjectReference)v;
            o = ins;
        }

        static StackObject* AssignFromStack_PlayerObject_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.NetworkObjectReference @PlayerObject = (Unity.Netcode.NetworkObjectReference)typeof(Unity.Netcode.NetworkObjectReference).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry ins =(Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry)o;
            ins.PlayerObject = @PlayerObject;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry();
            ins = (Phantom.XRMOD.NetcodeModule.Runtime.PlayerEntry)o;
            return ins;
        }


    }
}

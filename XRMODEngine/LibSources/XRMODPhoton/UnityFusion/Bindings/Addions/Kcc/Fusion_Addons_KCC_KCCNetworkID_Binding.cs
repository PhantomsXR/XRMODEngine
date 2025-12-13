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
    unsafe class Fusion_Addons_KCC_KCCNetworkID_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.KCC.KCCNetworkID);
            args = new Type[]{};
            method = type.GetMethod("get_IsValid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsValid_0);
            args = new Type[]{typeof(Fusion.Addons.KCC.KCCNetworkID)};
            method = type.GetMethod("Equals", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Equals_1);
            args = new Type[]{typeof(Fusion.NetworkRunner), typeof(Fusion.NetworkObject)};
            method = type.GetMethod("GetNetworkID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetNetworkID_2);
            args = new Type[]{typeof(Fusion.NetworkRunner), typeof(Fusion.Addons.KCC.KCCNetworkID)};
            method = type.GetMethod("GetNetworkObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetNetworkObject_3);

            field = type.GetField("WORD_COUNT", flag);
            app.RegisterCLRFieldGetter(field, get_WORD_COUNT_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_WORD_COUNT_0, null);
            field = type.GetField("Value0", flag);
            app.RegisterCLRFieldGetter(field, get_Value0_1);
            app.RegisterCLRFieldSetter(field, set_Value0_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Value0_1, AssignFromStack_Value0_1);
            field = type.GetField("Value1", flag);
            app.RegisterCLRFieldGetter(field, get_Value1_2);
            app.RegisterCLRFieldSetter(field, set_Value1_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Value1_2, AssignFromStack_Value1_2);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.KCCNetworkID());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.KCCNetworkID[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Fusion.Addons.KCC.KCCNetworkID instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Fusion.Addons.KCC.KCCNetworkID[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* get_IsValid_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Fusion.Addons.KCC.KCCNetworkID instance_of_this_method = (Fusion.Addons.KCC.KCCNetworkID)typeof(Fusion.Addons.KCC.KCCNetworkID).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.IsValid;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Equals_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCNetworkID @other = (Fusion.Addons.KCC.KCCNetworkID)typeof(Fusion.Addons.KCC.KCCNetworkID).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            Fusion.Addons.KCC.KCCNetworkID instance_of_this_method = (Fusion.Addons.KCC.KCCNetworkID)typeof(Fusion.Addons.KCC.KCCNetworkID).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.Equals(@other);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetNetworkID_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkObject @networkObject = (Fusion.NetworkObject)typeof(Fusion.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.NetworkRunner @runner = (Fusion.NetworkRunner)typeof(Fusion.NetworkRunner).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Fusion.Addons.KCC.KCCNetworkID.GetNetworkID(@runner, @networkObject);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetNetworkObject_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCNetworkID @networkID = (Fusion.Addons.KCC.KCCNetworkID)typeof(Fusion.Addons.KCC.KCCNetworkID).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.NetworkRunner @runner = (Fusion.NetworkRunner)typeof(Fusion.NetworkRunner).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Fusion.Addons.KCC.KCCNetworkID.GetNetworkObject(@runner, @networkID);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_WORD_COUNT_0(ref object o)
        {
            return Fusion.Addons.KCC.KCCNetworkID.WORD_COUNT;
        }

        static StackObject* CopyToStack_WORD_COUNT_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Addons.KCC.KCCNetworkID.WORD_COUNT;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_Value0_1(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCNetworkID)o).Value0;
        }

        static StackObject* CopyToStack_Value0_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCNetworkID)o).Value0;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static void set_Value0_1(ref object o, object v)
        {
            Fusion.Addons.KCC.KCCNetworkID ins =(Fusion.Addons.KCC.KCCNetworkID)o;
            ins.Value0 = (System.UInt32)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Value0_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.UInt32 @Value0 = (uint)ptr_of_this_method->Value;
            Fusion.Addons.KCC.KCCNetworkID ins =(Fusion.Addons.KCC.KCCNetworkID)o;
            ins.Value0 = @Value0;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Value1_2(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCNetworkID)o).Value1;
        }

        static StackObject* CopyToStack_Value1_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCNetworkID)o).Value1;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static void set_Value1_2(ref object o, object v)
        {
            Fusion.Addons.KCC.KCCNetworkID ins =(Fusion.Addons.KCC.KCCNetworkID)o;
            ins.Value1 = (System.UInt32)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Value1_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.UInt32 @Value1 = (uint)ptr_of_this_method->Value;
            Fusion.Addons.KCC.KCCNetworkID ins =(Fusion.Addons.KCC.KCCNetworkID)o;
            ins.Value1 = @Value1;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Fusion.Addons.KCC.KCCNetworkID();
            ins = (Fusion.Addons.KCC.KCCNetworkID)o;
            return ins;
        }


    }
}

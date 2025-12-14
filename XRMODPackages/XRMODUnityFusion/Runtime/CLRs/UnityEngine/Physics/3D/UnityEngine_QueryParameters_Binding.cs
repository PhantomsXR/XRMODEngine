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
    unsafe class UnityEngine_QueryParameters_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.QueryParameters);
            args = new Type[]{};
            method = type.GetMethod("get_Default", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Default_0);

            field = type.GetField("layerMask", flag);
            app.RegisterCLRFieldGetter(field, get_layerMask_0);
            app.RegisterCLRFieldSetter(field, set_layerMask_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_layerMask_0, AssignFromStack_layerMask_0);
            field = type.GetField("hitMultipleFaces", flag);
            app.RegisterCLRFieldGetter(field, get_hitMultipleFaces_1);
            app.RegisterCLRFieldSetter(field, set_hitMultipleFaces_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_hitMultipleFaces_1, AssignFromStack_hitMultipleFaces_1);
            field = type.GetField("hitTriggers", flag);
            app.RegisterCLRFieldGetter(field, get_hitTriggers_2);
            app.RegisterCLRFieldSetter(field, set_hitTriggers_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_hitTriggers_2, AssignFromStack_hitTriggers_2);
            field = type.GetField("hitBackfaces", flag);
            app.RegisterCLRFieldGetter(field, get_hitBackfaces_3);
            app.RegisterCLRFieldSetter(field, set_hitBackfaces_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_hitBackfaces_3, AssignFromStack_hitBackfaces_3);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.QueryParameters());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.QueryParameters[s]);

            args = new Type[]{typeof(System.Int32), typeof(System.Boolean), typeof(UnityEngine.QueryTriggerInteraction), typeof(System.Boolean)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.QueryParameters instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.QueryParameters[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* get_Default_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.QueryParameters.Default;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_layerMask_0(ref object o)
        {
            return ((UnityEngine.QueryParameters)o).layerMask;
        }

        static StackObject* CopyToStack_layerMask_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.QueryParameters)o).layerMask;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_layerMask_0(ref object o, object v)
        {
            UnityEngine.QueryParameters ins =(UnityEngine.QueryParameters)o;
            ins.layerMask = (System.Int32)v;
            o = ins;
        }

        static StackObject* AssignFromStack_layerMask_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @layerMask = ptr_of_this_method->Value;
            UnityEngine.QueryParameters ins =(UnityEngine.QueryParameters)o;
            ins.layerMask = @layerMask;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_hitMultipleFaces_1(ref object o)
        {
            return ((UnityEngine.QueryParameters)o).hitMultipleFaces;
        }

        static StackObject* CopyToStack_hitMultipleFaces_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.QueryParameters)o).hitMultipleFaces;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_hitMultipleFaces_1(ref object o, object v)
        {
            UnityEngine.QueryParameters ins =(UnityEngine.QueryParameters)o;
            ins.hitMultipleFaces = (System.Boolean)v;
            o = ins;
        }

        static StackObject* AssignFromStack_hitMultipleFaces_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @hitMultipleFaces = ptr_of_this_method->Value == 1;
            UnityEngine.QueryParameters ins =(UnityEngine.QueryParameters)o;
            ins.hitMultipleFaces = @hitMultipleFaces;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_hitTriggers_2(ref object o)
        {
            return ((UnityEngine.QueryParameters)o).hitTriggers;
        }

        static StackObject* CopyToStack_hitTriggers_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.QueryParameters)o).hitTriggers;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_hitTriggers_2(ref object o, object v)
        {
            UnityEngine.QueryParameters ins =(UnityEngine.QueryParameters)o;
            ins.hitTriggers = (UnityEngine.QueryTriggerInteraction)v;
            o = ins;
        }

        static StackObject* AssignFromStack_hitTriggers_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.QueryTriggerInteraction @hitTriggers = (UnityEngine.QueryTriggerInteraction)typeof(UnityEngine.QueryTriggerInteraction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            UnityEngine.QueryParameters ins =(UnityEngine.QueryParameters)o;
            ins.hitTriggers = @hitTriggers;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_hitBackfaces_3(ref object o)
        {
            return ((UnityEngine.QueryParameters)o).hitBackfaces;
        }

        static StackObject* CopyToStack_hitBackfaces_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.QueryParameters)o).hitBackfaces;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_hitBackfaces_3(ref object o, object v)
        {
            UnityEngine.QueryParameters ins =(UnityEngine.QueryParameters)o;
            ins.hitBackfaces = (System.Boolean)v;
            o = ins;
        }

        static StackObject* AssignFromStack_hitBackfaces_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @hitBackfaces = ptr_of_this_method->Value == 1;
            UnityEngine.QueryParameters ins =(UnityEngine.QueryParameters)o;
            ins.hitBackfaces = @hitBackfaces;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.QueryParameters();
            ins = (UnityEngine.QueryParameters)o;
            return ins;
        }

        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @hitBackfaces = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.QueryTriggerInteraction @hitTriggers = (UnityEngine.QueryTriggerInteraction)typeof(UnityEngine.QueryTriggerInteraction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @hitMultipleFaces = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @layerMask = ptr_of_this_method->Value;


            var result_of_this_method = new UnityEngine.QueryParameters(@layerMask, @hitMultipleFaces, @hitTriggers, @hitBackfaces);

            if(!isNewObj)
            {
                __ret--;
                WriteBackInstance(__domain, __ret, __mStack, ref result_of_this_method);
                return __ret;
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

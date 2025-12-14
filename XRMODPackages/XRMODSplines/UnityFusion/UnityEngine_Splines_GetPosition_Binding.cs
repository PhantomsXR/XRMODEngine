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
    unsafe class UnityEngine_Splines_GetPosition_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Splines.GetPosition);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("Execute", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Execute_0);

            field = type.GetField("Spline", flag);
            app.RegisterCLRFieldGetter(field, get_Spline_0);
            app.RegisterCLRFieldSetter(field, set_Spline_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Spline_0, AssignFromStack_Spline_0);
            field = type.GetField("Positions", flag);
            app.RegisterCLRFieldGetter(field, get_Positions_1);
            app.RegisterCLRFieldSetter(field, set_Positions_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Positions_1, AssignFromStack_Positions_1);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Splines.GetPosition());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Splines.GetPosition[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.Splines.GetPosition instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Splines.GetPosition[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* Execute_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @index = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.Splines.GetPosition instance_of_this_method = (UnityEngine.Splines.GetPosition)typeof(UnityEngine.Splines.GetPosition).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            instance_of_this_method.Execute(@index);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }


        static object get_Spline_0(ref object o)
        {
            return ((UnityEngine.Splines.GetPosition)o).Spline;
        }

        static StackObject* CopyToStack_Spline_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Splines.GetPosition)o).Spline;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Spline_0(ref object o, object v)
        {
            UnityEngine.Splines.GetPosition ins =(UnityEngine.Splines.GetPosition)o;
            ins.Spline = (UnityEngine.Splines.NativeSpline)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Spline_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Splines.NativeSpline @Spline = (UnityEngine.Splines.NativeSpline)typeof(UnityEngine.Splines.NativeSpline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.Splines.GetPosition ins =(UnityEngine.Splines.GetPosition)o;
            ins.Spline = @Spline;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Positions_1(ref object o)
        {
            return ((UnityEngine.Splines.GetPosition)o).Positions;
        }

        static StackObject* CopyToStack_Positions_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Splines.GetPosition)o).Positions;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Positions_1(ref object o, object v)
        {
            UnityEngine.Splines.GetPosition ins =(UnityEngine.Splines.GetPosition)o;
            ins.Positions = (Unity.Collections.NativeArray<Unity.Mathematics.float3>)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Positions_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Collections.NativeArray<Unity.Mathematics.float3> @Positions = (Unity.Collections.NativeArray<Unity.Mathematics.float3>)typeof(Unity.Collections.NativeArray<Unity.Mathematics.float3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.Splines.GetPosition ins =(UnityEngine.Splines.GetPosition)o;
            ins.Positions = @Positions;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Splines.GetPosition();
            ins = (UnityEngine.Splines.GetPosition)o;
            return ins;
        }


    }
}

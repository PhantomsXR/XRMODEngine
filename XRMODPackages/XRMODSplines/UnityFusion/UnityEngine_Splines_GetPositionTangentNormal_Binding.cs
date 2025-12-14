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
    unsafe class UnityEngine_Splines_GetPositionTangentNormal_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Splines.GetPositionTangentNormal);
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
            field = type.GetField("Tangents", flag);
            app.RegisterCLRFieldGetter(field, get_Tangents_2);
            app.RegisterCLRFieldSetter(field, set_Tangents_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Tangents_2, AssignFromStack_Tangents_2);
            field = type.GetField("Normals", flag);
            app.RegisterCLRFieldGetter(field, get_Normals_3);
            app.RegisterCLRFieldSetter(field, set_Normals_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Normals_3, AssignFromStack_Normals_3);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Splines.GetPositionTangentNormal());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Splines.GetPositionTangentNormal[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.Splines.GetPositionTangentNormal instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Splines.GetPositionTangentNormal[];
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
            UnityEngine.Splines.GetPositionTangentNormal instance_of_this_method = (UnityEngine.Splines.GetPositionTangentNormal)typeof(UnityEngine.Splines.GetPositionTangentNormal).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            instance_of_this_method.Execute(@index);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }


        static object get_Spline_0(ref object o)
        {
            return ((UnityEngine.Splines.GetPositionTangentNormal)o).Spline;
        }

        static StackObject* CopyToStack_Spline_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Splines.GetPositionTangentNormal)o).Spline;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Spline_0(ref object o, object v)
        {
            UnityEngine.Splines.GetPositionTangentNormal ins =(UnityEngine.Splines.GetPositionTangentNormal)o;
            ins.Spline = (UnityEngine.Splines.NativeSpline)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Spline_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Splines.NativeSpline @Spline = (UnityEngine.Splines.NativeSpline)typeof(UnityEngine.Splines.NativeSpline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.Splines.GetPositionTangentNormal ins =(UnityEngine.Splines.GetPositionTangentNormal)o;
            ins.Spline = @Spline;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Positions_1(ref object o)
        {
            return ((UnityEngine.Splines.GetPositionTangentNormal)o).Positions;
        }

        static StackObject* CopyToStack_Positions_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Splines.GetPositionTangentNormal)o).Positions;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Positions_1(ref object o, object v)
        {
            UnityEngine.Splines.GetPositionTangentNormal ins =(UnityEngine.Splines.GetPositionTangentNormal)o;
            ins.Positions = (Unity.Collections.NativeArray<Unity.Mathematics.float3>)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Positions_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Collections.NativeArray<Unity.Mathematics.float3> @Positions = (Unity.Collections.NativeArray<Unity.Mathematics.float3>)typeof(Unity.Collections.NativeArray<Unity.Mathematics.float3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.Splines.GetPositionTangentNormal ins =(UnityEngine.Splines.GetPositionTangentNormal)o;
            ins.Positions = @Positions;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Tangents_2(ref object o)
        {
            return ((UnityEngine.Splines.GetPositionTangentNormal)o).Tangents;
        }

        static StackObject* CopyToStack_Tangents_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Splines.GetPositionTangentNormal)o).Tangents;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Tangents_2(ref object o, object v)
        {
            UnityEngine.Splines.GetPositionTangentNormal ins =(UnityEngine.Splines.GetPositionTangentNormal)o;
            ins.Tangents = (Unity.Collections.NativeArray<Unity.Mathematics.float3>)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Tangents_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Collections.NativeArray<Unity.Mathematics.float3> @Tangents = (Unity.Collections.NativeArray<Unity.Mathematics.float3>)typeof(Unity.Collections.NativeArray<Unity.Mathematics.float3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.Splines.GetPositionTangentNormal ins =(UnityEngine.Splines.GetPositionTangentNormal)o;
            ins.Tangents = @Tangents;
            o = ins;
            return ptr_of_this_method;
        }

        static object get_Normals_3(ref object o)
        {
            return ((UnityEngine.Splines.GetPositionTangentNormal)o).Normals;
        }

        static StackObject* CopyToStack_Normals_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((UnityEngine.Splines.GetPositionTangentNormal)o).Normals;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Normals_3(ref object o, object v)
        {
            UnityEngine.Splines.GetPositionTangentNormal ins =(UnityEngine.Splines.GetPositionTangentNormal)o;
            ins.Normals = (Unity.Collections.NativeArray<Unity.Mathematics.float3>)v;
            o = ins;
        }

        static StackObject* AssignFromStack_Normals_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Collections.NativeArray<Unity.Mathematics.float3> @Normals = (Unity.Collections.NativeArray<Unity.Mathematics.float3>)typeof(Unity.Collections.NativeArray<Unity.Mathematics.float3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            UnityEngine.Splines.GetPositionTangentNormal ins =(UnityEngine.Splines.GetPositionTangentNormal)o;
            ins.Normals = @Normals;
            o = ins;
            return ptr_of_this_method;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.Splines.GetPositionTangentNormal();
            ins = (UnityEngine.Splines.GetPositionTangentNormal)o;
            return ins;
        }


    }
}

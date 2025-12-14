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
    unsafe class UnityEngine_Splines_SplineJobs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Splines.SplineJobs);
            args = new Type[]{typeof(UnityEngine.Splines.NativeSpline), typeof(Unity.Collections.NativeArray<Unity.Mathematics.float3>)};
            method = type.GetMethod("EvaluatePosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EvaluatePosition_0);
            args = new Type[]{typeof(UnityEngine.Splines.NativeSpline), typeof(Unity.Collections.NativeArray<Unity.Mathematics.float3>), typeof(Unity.Collections.NativeArray<Unity.Mathematics.float3>), typeof(Unity.Collections.NativeArray<Unity.Mathematics.float3>)};
            method = type.GetMethod("EvaluatePositionTangentNormal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EvaluatePositionTangentNormal_1);





        }


        static StackObject* EvaluatePosition_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Collections.NativeArray<Unity.Mathematics.float3> @positions = (Unity.Collections.NativeArray<Unity.Mathematics.float3>)typeof(Unity.Collections.NativeArray<Unity.Mathematics.float3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.NativeSpline @spline = (UnityEngine.Splines.NativeSpline)typeof(UnityEngine.Splines.NativeSpline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Splines.SplineJobs.EvaluatePosition(@spline, @positions);

            return __ret;
        }

        static StackObject* EvaluatePositionTangentNormal_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Collections.NativeArray<Unity.Mathematics.float3> @normals = (Unity.Collections.NativeArray<Unity.Mathematics.float3>)typeof(Unity.Collections.NativeArray<Unity.Mathematics.float3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Collections.NativeArray<Unity.Mathematics.float3> @tangents = (Unity.Collections.NativeArray<Unity.Mathematics.float3>)typeof(Unity.Collections.NativeArray<Unity.Mathematics.float3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Collections.NativeArray<Unity.Mathematics.float3> @positions = (Unity.Collections.NativeArray<Unity.Mathematics.float3>)typeof(Unity.Collections.NativeArray<Unity.Mathematics.float3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Splines.NativeSpline @spline = (UnityEngine.Splines.NativeSpline)typeof(UnityEngine.Splines.NativeSpline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Splines.SplineJobs.EvaluatePositionTangentNormal(@spline, @positions, @tangents, @normals);

            return __ret;
        }





    }
}

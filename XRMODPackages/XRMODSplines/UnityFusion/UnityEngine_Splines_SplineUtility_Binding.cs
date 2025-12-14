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
    unsafe class UnityEngine_Splines_SplineUtility_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.Splines.SplineUtility);
            args = new Type[]{typeof(System.Single), typeof(System.Collections.Generic.List<Unity.Mathematics.float3>), typeof(System.Collections.Generic.List<System.Double>), typeof(System.Int32), typeof(Unity.Mathematics.float3).MakeByRefType()};
            method = type.GetMethod("EvaluateNurbs", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EvaluateNurbs_0);
            args = new Type[]{typeof(System.Single), typeof(System.Int32)};
            method = type.GetMethod("GetSubdivisionCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSubdivisionCount_1);
            args = new Type[]{typeof(Unity.Mathematics.float3), typeof(Unity.Mathematics.float3)};
            method = type.GetMethod("GetCatmullRomTangent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCatmullRomTangent_2);
            args = new Type[]{typeof(Unity.Mathematics.float3), typeof(Unity.Mathematics.float3), typeof(System.Single)};
            method = type.GetMethod("GetAutoSmoothTangent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAutoSmoothTangent_3);
            args = new Type[]{typeof(Unity.Mathematics.float3), typeof(Unity.Mathematics.float3), typeof(Unity.Mathematics.float3), typeof(System.Single)};
            method = type.GetMethod("GetAutoSmoothTangent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAutoSmoothTangent_4);
            args = new Type[]{typeof(Unity.Mathematics.float3), typeof(Unity.Mathematics.float3), typeof(Unity.Mathematics.float3)};
            method = type.GetMethod("GetAutoSmoothKnot", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAutoSmoothKnot_5);
            args = new Type[]{typeof(Unity.Mathematics.float3), typeof(Unity.Mathematics.float3), typeof(Unity.Mathematics.float3), typeof(Unity.Mathematics.float3)};
            method = type.GetMethod("GetAutoSmoothKnot", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAutoSmoothKnot_6);
            args = new Type[]{typeof(Unity.Mathematics.float3), typeof(Unity.Mathematics.float3), typeof(Unity.Mathematics.float3), typeof(Unity.Mathematics.float3), typeof(System.Single)};
            method = type.GetMethod("GetAutoSmoothKnot", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAutoSmoothKnot_7);
            args = new Type[]{typeof(UnityEngine.Splines.SplineContainer), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("SetPivot", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPivot_8);
            args = new Type[]{typeof(System.Collections.Generic.List<Unity.Mathematics.float3>), typeof(System.Single), typeof(System.Boolean), typeof(UnityEngine.Splines.Spline).MakeByRefType()};
            method = type.GetMethod("FitSplineToPoints", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FitSplineToPoints_9);
            args = new Type[]{typeof(UnityEngine.Splines.ISplineContainer), typeof(UnityEngine.Splines.SplineKnotIndex), typeof(UnityEngine.Splines.SplineKnotIndex)};
            method = type.GetMethod("AreKnotLinked", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AreKnotLinked_10);
            args = new Type[]{typeof(UnityEngine.Splines.ISplineContainer), typeof(System.Int32)};
            method = type.GetMethod("ReverseFlow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReverseFlow_11);
            args = new Type[]{typeof(UnityEngine.Splines.SplineInfo)};
            method = type.GetMethod("ReverseFlow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReverseFlow_12);
            args = new Type[]{typeof(UnityEngine.Splines.Spline)};
            method = type.GetMethod("ReverseFlow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ReverseFlow_13);
            args = new Type[]{typeof(UnityEngine.Splines.ISplineContainer), typeof(UnityEngine.Splines.SplineKnotIndex), typeof(UnityEngine.Splines.SplineKnotIndex)};
            method = type.GetMethod("JoinSplinesOnKnots", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, JoinSplinesOnKnots_14);
            args = new Type[]{typeof(UnityEngine.Splines.ISplineContainer), typeof(UnityEngine.Splines.SplineKnotIndex), typeof(UnityEngine.Splines.SplineKnotIndex), typeof(System.Int32).MakeByRefType()};
            method = type.GetMethod("DuplicateSpline", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DuplicateSpline_15);
            args = new Type[]{typeof(UnityEngine.Splines.ISplineContainer), typeof(UnityEngine.Splines.SplineKnotIndex)};
            method = type.GetMethod("SplitSplineOnKnot", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SplitSplineOnKnot_16);

            field = type.GetField("DefaultTension", flag);
            app.RegisterCLRFieldGetter(field, get_DefaultTension_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_DefaultTension_0, null);
            field = type.GetField("CatmullRomTension", flag);
            app.RegisterCLRFieldGetter(field, get_CatmullRomTension_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_CatmullRomTension_1, null);
            field = type.GetField("PickResolutionMin", flag);
            app.RegisterCLRFieldGetter(field, get_PickResolutionMin_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_PickResolutionMin_2, null);
            field = type.GetField("PickResolutionDefault", flag);
            app.RegisterCLRFieldGetter(field, get_PickResolutionDefault_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_PickResolutionDefault_3, null);
            field = type.GetField("PickResolutionMax", flag);
            app.RegisterCLRFieldGetter(field, get_PickResolutionMax_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_PickResolutionMax_4, null);
            field = type.GetField("DrawResolutionDefault", flag);
            app.RegisterCLRFieldGetter(field, get_DrawResolutionDefault_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_DrawResolutionDefault_5, null);




        }


        static StackObject* EvaluateNurbs_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Mathematics.float3 @position = (Unity.Mathematics.float3)typeof(Unity.Mathematics.float3).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @order = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Collections.Generic.List<System.Double> @knotVector = (System.Collections.Generic.List<System.Double>)typeof(System.Collections.Generic.List<System.Double>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.List<Unity.Mathematics.float3> @controlPoints = (System.Collections.Generic.List<Unity.Mathematics.float3>)typeof(System.Collections.Generic.List<Unity.Mathematics.float3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Single @t = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Splines.SplineUtility.EvaluateNurbs(@t, @controlPoints, @knotVector, @order, out @position);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @position;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @position;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @position);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @position;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @position);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Unity.Mathematics.float3[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @position;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetSubdivisionCount_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @resolution = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @length = *(float*)&ptr_of_this_method->Value;


            var result_of_this_method = UnityEngine.Splines.SplineUtility.GetSubdivisionCount(@length, @resolution);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetCatmullRomTangent_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Mathematics.float3 @next = (Unity.Mathematics.float3)typeof(Unity.Mathematics.float3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Mathematics.float3 @previous = (Unity.Mathematics.float3)typeof(Unity.Mathematics.float3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Splines.SplineUtility.GetCatmullRomTangent(@previous, @next);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAutoSmoothTangent_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @tension = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Mathematics.float3 @next = (Unity.Mathematics.float3)typeof(Unity.Mathematics.float3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Mathematics.float3 @previous = (Unity.Mathematics.float3)typeof(Unity.Mathematics.float3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Splines.SplineUtility.GetAutoSmoothTangent(@previous, @next, @tension);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAutoSmoothTangent_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @tension = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Mathematics.float3 @next = (Unity.Mathematics.float3)typeof(Unity.Mathematics.float3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Mathematics.float3 @current = (Unity.Mathematics.float3)typeof(Unity.Mathematics.float3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Unity.Mathematics.float3 @previous = (Unity.Mathematics.float3)typeof(Unity.Mathematics.float3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Splines.SplineUtility.GetAutoSmoothTangent(@previous, @current, @next, @tension);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAutoSmoothKnot_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Mathematics.float3 @next = (Unity.Mathematics.float3)typeof(Unity.Mathematics.float3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Mathematics.float3 @previous = (Unity.Mathematics.float3)typeof(Unity.Mathematics.float3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Mathematics.float3 @position = (Unity.Mathematics.float3)typeof(Unity.Mathematics.float3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Splines.SplineUtility.GetAutoSmoothKnot(@position, @previous, @next);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAutoSmoothKnot_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Mathematics.float3 @normal = (Unity.Mathematics.float3)typeof(Unity.Mathematics.float3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Mathematics.float3 @next = (Unity.Mathematics.float3)typeof(Unity.Mathematics.float3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Mathematics.float3 @previous = (Unity.Mathematics.float3)typeof(Unity.Mathematics.float3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Unity.Mathematics.float3 @position = (Unity.Mathematics.float3)typeof(Unity.Mathematics.float3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Splines.SplineUtility.GetAutoSmoothKnot(@position, @previous, @next, @normal);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAutoSmoothKnot_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @tension = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Mathematics.float3 @normal = (Unity.Mathematics.float3)typeof(Unity.Mathematics.float3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Mathematics.float3 @next = (Unity.Mathematics.float3)typeof(Unity.Mathematics.float3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Unity.Mathematics.float3 @previous = (Unity.Mathematics.float3)typeof(Unity.Mathematics.float3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            Unity.Mathematics.float3 @position = (Unity.Mathematics.float3)typeof(Unity.Mathematics.float3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Splines.SplineUtility.GetAutoSmoothKnot(@position, @previous, @next, @normal, @tension);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetPivot_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineContainer @container = (UnityEngine.Splines.SplineContainer)typeof(UnityEngine.Splines.SplineContainer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Splines.SplineUtility.SetPivot(@container, @position);

            return __ret;
        }

        static StackObject* FitSplineToPoints_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.Spline @spline = (UnityEngine.Splines.Spline)typeof(UnityEngine.Splines.Spline).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @closed = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @errorThreshold = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Collections.Generic.List<Unity.Mathematics.float3> @points = (System.Collections.Generic.List<Unity.Mathematics.float3>)typeof(System.Collections.Generic.List<Unity.Mathematics.float3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);


            var result_of_this_method = UnityEngine.Splines.SplineUtility.FitSplineToPoints(@points, @errorThreshold, @closed, out @spline);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @spline;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @spline;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @spline);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @spline;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @spline);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Splines.Spline[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @spline;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* AreKnotLinked_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineKnotIndex @knotB = (UnityEngine.Splines.SplineKnotIndex)typeof(UnityEngine.Splines.SplineKnotIndex).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineKnotIndex @knotA = (UnityEngine.Splines.SplineKnotIndex)typeof(UnityEngine.Splines.SplineKnotIndex).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Splines.ISplineContainer @container = (UnityEngine.Splines.ISplineContainer)typeof(UnityEngine.Splines.ISplineContainer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Splines.SplineUtility.AreKnotLinked(@container, @knotA, @knotB);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* ReverseFlow_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @splineIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.ISplineContainer @container = (UnityEngine.Splines.ISplineContainer)typeof(UnityEngine.Splines.ISplineContainer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Splines.SplineUtility.ReverseFlow(@container, @splineIndex);

            return __ret;
        }

        static StackObject* ReverseFlow_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineInfo @splineInfo = (UnityEngine.Splines.SplineInfo)typeof(UnityEngine.Splines.SplineInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Splines.SplineUtility.ReverseFlow(@splineInfo);

            return __ret;
        }

        static StackObject* ReverseFlow_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.Spline @spline = (UnityEngine.Splines.Spline)typeof(UnityEngine.Splines.Spline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Splines.SplineUtility.ReverseFlow(@spline);

            return __ret;
        }

        static StackObject* JoinSplinesOnKnots_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineKnotIndex @otherKnot = (UnityEngine.Splines.SplineKnotIndex)typeof(UnityEngine.Splines.SplineKnotIndex).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineKnotIndex @mainKnot = (UnityEngine.Splines.SplineKnotIndex)typeof(UnityEngine.Splines.SplineKnotIndex).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Splines.ISplineContainer @container = (UnityEngine.Splines.ISplineContainer)typeof(UnityEngine.Splines.ISplineContainer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Splines.SplineUtility.JoinSplinesOnKnots(@container, @mainKnot, @otherKnot);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* DuplicateSpline_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @newSplineIndex = __intp.RetriveInt32(ptr_of_this_method, __mStack);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.SplineKnotIndex @toKnot = (UnityEngine.Splines.SplineKnotIndex)typeof(UnityEngine.Splines.SplineKnotIndex).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Splines.SplineKnotIndex @fromKnot = (UnityEngine.Splines.SplineKnotIndex)typeof(UnityEngine.Splines.SplineKnotIndex).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Splines.ISplineContainer @container = (UnityEngine.Splines.ISplineContainer)typeof(UnityEngine.Splines.ISplineContainer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);


            UnityEngine.Splines.SplineUtility.DuplicateSpline(@container, @fromKnot, @toKnot, out @newSplineIndex);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        ___dst->ObjectType = ObjectTypes.Integer;
                        ___dst->Value = @newSplineIndex;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @newSplineIndex;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @newSplineIndex);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @newSplineIndex;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @newSplineIndex);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Int32[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @newSplineIndex;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* SplitSplineOnKnot_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Splines.SplineKnotIndex @knotInfo = (UnityEngine.Splines.SplineKnotIndex)typeof(UnityEngine.Splines.SplineKnotIndex).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Splines.ISplineContainer @container = (UnityEngine.Splines.ISplineContainer)typeof(UnityEngine.Splines.ISplineContainer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.Splines.SplineUtility.SplitSplineOnKnot(@container, @knotInfo);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_DefaultTension_0(ref object o)
        {
            return UnityEngine.Splines.SplineUtility.DefaultTension;
        }

        static StackObject* CopyToStack_DefaultTension_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Splines.SplineUtility.DefaultTension;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_CatmullRomTension_1(ref object o)
        {
            return UnityEngine.Splines.SplineUtility.CatmullRomTension;
        }

        static StackObject* CopyToStack_CatmullRomTension_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Splines.SplineUtility.CatmullRomTension;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_PickResolutionMin_2(ref object o)
        {
            return UnityEngine.Splines.SplineUtility.PickResolutionMin;
        }

        static StackObject* CopyToStack_PickResolutionMin_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Splines.SplineUtility.PickResolutionMin;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_PickResolutionDefault_3(ref object o)
        {
            return UnityEngine.Splines.SplineUtility.PickResolutionDefault;
        }

        static StackObject* CopyToStack_PickResolutionDefault_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Splines.SplineUtility.PickResolutionDefault;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_PickResolutionMax_4(ref object o)
        {
            return UnityEngine.Splines.SplineUtility.PickResolutionMax;
        }

        static StackObject* CopyToStack_PickResolutionMax_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Splines.SplineUtility.PickResolutionMax;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static object get_DrawResolutionDefault_5(ref object o)
        {
            return UnityEngine.Splines.SplineUtility.DrawResolutionDefault;
        }

        static StackObject* CopyToStack_DrawResolutionDefault_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.Splines.SplineUtility.DrawResolutionDefault;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }




    }
}

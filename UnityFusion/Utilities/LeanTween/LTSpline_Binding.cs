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
    unsafe class LTSpline_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::LTSpline);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("map", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, map_0);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("interp", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, interp_1);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("ratioAtPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ratioAtPoint_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("point", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, point_3);
            args = new Type[]{typeof(UnityEngine.Transform), typeof(System.Single)};
            method = type.GetMethod("place2d", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, place2d_4);
            args = new Type[]{typeof(UnityEngine.Transform), typeof(System.Single)};
            method = type.GetMethod("placeLocal2d", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, placeLocal2d_5);
            args = new Type[]{typeof(UnityEngine.Transform), typeof(System.Single)};
            method = type.GetMethod("place", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, place_6);
            args = new Type[]{typeof(UnityEngine.Transform), typeof(System.Single), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("place", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, place_7);
            args = new Type[]{typeof(UnityEngine.Transform), typeof(System.Single)};
            method = type.GetMethod("placeLocal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, placeLocal_8);
            args = new Type[]{typeof(UnityEngine.Transform), typeof(System.Single), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("placeLocal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, placeLocal_9);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("gizmoDraw", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, gizmoDraw_10);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("drawGizmo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, drawGizmo_11);
            args = new Type[]{typeof(UnityEngine.Transform[]), typeof(UnityEngine.Color)};
            method = type.GetMethod("drawGizmo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, drawGizmo_12);
            args = new Type[]{typeof(UnityEngine.Transform[]), typeof(System.Single), typeof(UnityEngine.Color)};
            method = type.GetMethod("drawLine", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, drawLine_13);
            args = new Type[]{typeof(UnityEngine.Material), typeof(UnityEngine.Color), typeof(System.Single)};
            method = type.GetMethod("drawLinesGLLines", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, drawLinesGLLines_14);
            args = new Type[]{};
            method = type.GetMethod("generateVectors", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, generateVectors_15);

            field = type.GetField("DISTANCE_COUNT", flag);
            app.RegisterCLRFieldGetter(field, get_DISTANCE_COUNT_0);
            app.RegisterCLRFieldSetter(field, set_DISTANCE_COUNT_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_DISTANCE_COUNT_0, AssignFromStack_DISTANCE_COUNT_0);
            field = type.GetField("SUBLINE_COUNT", flag);
            app.RegisterCLRFieldGetter(field, get_SUBLINE_COUNT_1);
            app.RegisterCLRFieldSetter(field, set_SUBLINE_COUNT_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_SUBLINE_COUNT_1, AssignFromStack_SUBLINE_COUNT_1);
            field = type.GetField("distance", flag);
            app.RegisterCLRFieldGetter(field, get_distance_2);
            app.RegisterCLRFieldSetter(field, set_distance_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_distance_2, AssignFromStack_distance_2);
            field = type.GetField("constantSpeed", flag);
            app.RegisterCLRFieldGetter(field, get_constantSpeed_3);
            app.RegisterCLRFieldSetter(field, set_constantSpeed_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_constantSpeed_3, AssignFromStack_constantSpeed_3);
            field = type.GetField("pts", flag);
            app.RegisterCLRFieldGetter(field, get_pts_4);
            app.RegisterCLRFieldSetter(field, set_pts_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_pts_4, AssignFromStack_pts_4);
            field = type.GetField("ptsAdj", flag);
            app.RegisterCLRFieldGetter(field, get_ptsAdj_5);
            app.RegisterCLRFieldSetter(field, set_ptsAdj_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_ptsAdj_5, AssignFromStack_ptsAdj_5);
            field = type.GetField("ptsAdjLength", flag);
            app.RegisterCLRFieldGetter(field, get_ptsAdjLength_6);
            app.RegisterCLRFieldSetter(field, set_ptsAdjLength_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_ptsAdjLength_6, AssignFromStack_ptsAdjLength_6);
            field = type.GetField("orientToPath", flag);
            app.RegisterCLRFieldGetter(field, get_orientToPath_7);
            app.RegisterCLRFieldSetter(field, set_orientToPath_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_orientToPath_7, AssignFromStack_orientToPath_7);
            field = type.GetField("orientToPath2d", flag);
            app.RegisterCLRFieldGetter(field, get_orientToPath2d_8);
            app.RegisterCLRFieldSetter(field, set_orientToPath2d_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_orientToPath2d_8, AssignFromStack_orientToPath2d_8);


            app.RegisterCLRCreateArrayInstance(type, s => new global::LTSpline[s]);

            args = new Type[]{typeof(UnityEngine.Vector3[])};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(UnityEngine.Vector3[]), typeof(System.Boolean)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);

        }


        static StackObject* map_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @u = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTSpline instance_of_this_method = (global::LTSpline)typeof(global::LTSpline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.map(@u);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* interp_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @t = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTSpline instance_of_this_method = (global::LTSpline)typeof(global::LTSpline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.interp(@t);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ratioAtPoint_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @pt = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTSpline instance_of_this_method = (global::LTSpline)typeof(global::LTSpline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ratioAtPoint(@pt);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* point_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @ratio = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTSpline instance_of_this_method = (global::LTSpline)typeof(global::LTSpline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.point(@ratio);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* place2d_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @ratio = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform @transform = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            global::LTSpline instance_of_this_method = (global::LTSpline)typeof(global::LTSpline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.place2d(@transform, @ratio);

            return __ret;
        }

        static StackObject* placeLocal2d_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @ratio = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform @transform = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            global::LTSpline instance_of_this_method = (global::LTSpline)typeof(global::LTSpline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.placeLocal2d(@transform, @ratio);

            return __ret;
        }

        static StackObject* place_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @ratio = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform @transform = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            global::LTSpline instance_of_this_method = (global::LTSpline)typeof(global::LTSpline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.place(@transform, @ratio);

            return __ret;
        }

        static StackObject* place_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @worldUp = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @ratio = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Transform @transform = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            global::LTSpline instance_of_this_method = (global::LTSpline)typeof(global::LTSpline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.place(@transform, @ratio, @worldUp);

            return __ret;
        }

        static StackObject* placeLocal_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @ratio = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform @transform = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            global::LTSpline instance_of_this_method = (global::LTSpline)typeof(global::LTSpline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.placeLocal(@transform, @ratio);

            return __ret;
        }

        static StackObject* placeLocal_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @worldUp = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @ratio = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Transform @transform = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            global::LTSpline instance_of_this_method = (global::LTSpline)typeof(global::LTSpline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.placeLocal(@transform, @ratio, @worldUp);

            return __ret;
        }

        static StackObject* gizmoDraw_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @t = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTSpline instance_of_this_method = (global::LTSpline)typeof(global::LTSpline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.gizmoDraw(@t);

            return __ret;
        }

        static StackObject* drawGizmo_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @color = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTSpline instance_of_this_method = (global::LTSpline)typeof(global::LTSpline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.drawGizmo(@color);

            return __ret;
        }

        static StackObject* drawGizmo_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @color = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform[] @arr = (UnityEngine.Transform[])typeof(UnityEngine.Transform[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            global::LTSpline.drawGizmo(@arr, @color);

            return __ret;
        }

        static StackObject* drawLine_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @color = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @width = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Transform[] @arr = (UnityEngine.Transform[])typeof(UnityEngine.Transform[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            global::LTSpline.drawLine(@arr, @width, @color);

            return __ret;
        }

        static StackObject* drawLinesGLLines_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @width = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Color @color = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Material @outlineMaterial = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            global::LTSpline instance_of_this_method = (global::LTSpline)typeof(global::LTSpline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.drawLinesGLLines(@outlineMaterial, @color, @width);

            return __ret;
        }

        static StackObject* generateVectors_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTSpline instance_of_this_method = (global::LTSpline)typeof(global::LTSpline).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.generateVectors();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_DISTANCE_COUNT_0(ref object o)
        {
            return global::LTSpline.DISTANCE_COUNT;
        }

        static StackObject* CopyToStack_DISTANCE_COUNT_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LTSpline.DISTANCE_COUNT;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_DISTANCE_COUNT_0(ref object o, object v)
        {
            global::LTSpline.DISTANCE_COUNT = (System.Int32)v;
        }

        static StackObject* AssignFromStack_DISTANCE_COUNT_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @DISTANCE_COUNT = ptr_of_this_method->Value;
            global::LTSpline.DISTANCE_COUNT = @DISTANCE_COUNT;
            return ptr_of_this_method;
        }

        static object get_SUBLINE_COUNT_1(ref object o)
        {
            return global::LTSpline.SUBLINE_COUNT;
        }

        static StackObject* CopyToStack_SUBLINE_COUNT_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = global::LTSpline.SUBLINE_COUNT;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_SUBLINE_COUNT_1(ref object o, object v)
        {
            global::LTSpline.SUBLINE_COUNT = (System.Int32)v;
        }

        static StackObject* AssignFromStack_SUBLINE_COUNT_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @SUBLINE_COUNT = ptr_of_this_method->Value;
            global::LTSpline.SUBLINE_COUNT = @SUBLINE_COUNT;
            return ptr_of_this_method;
        }

        static object get_distance_2(ref object o)
        {
            return ((global::LTSpline)o).distance;
        }

        static StackObject* CopyToStack_distance_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTSpline)o).distance;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_distance_2(ref object o, object v)
        {
            ((global::LTSpline)o).distance = (System.Single)v;
        }

        static StackObject* AssignFromStack_distance_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @distance = *(float*)&ptr_of_this_method->Value;
            ((global::LTSpline)o).distance = @distance;
            return ptr_of_this_method;
        }

        static object get_constantSpeed_3(ref object o)
        {
            return ((global::LTSpline)o).constantSpeed;
        }

        static StackObject* CopyToStack_constantSpeed_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTSpline)o).constantSpeed;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_constantSpeed_3(ref object o, object v)
        {
            ((global::LTSpline)o).constantSpeed = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_constantSpeed_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @constantSpeed = ptr_of_this_method->Value == 1;
            ((global::LTSpline)o).constantSpeed = @constantSpeed;
            return ptr_of_this_method;
        }

        static object get_pts_4(ref object o)
        {
            return ((global::LTSpline)o).pts;
        }

        static StackObject* CopyToStack_pts_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTSpline)o).pts;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_pts_4(ref object o, object v)
        {
            ((global::LTSpline)o).pts = (UnityEngine.Vector3[])v;
        }

        static StackObject* AssignFromStack_pts_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3[] @pts = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::LTSpline)o).pts = @pts;
            return ptr_of_this_method;
        }

        static object get_ptsAdj_5(ref object o)
        {
            return ((global::LTSpline)o).ptsAdj;
        }

        static StackObject* CopyToStack_ptsAdj_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTSpline)o).ptsAdj;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ptsAdj_5(ref object o, object v)
        {
            ((global::LTSpline)o).ptsAdj = (UnityEngine.Vector3[])v;
        }

        static StackObject* AssignFromStack_ptsAdj_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3[] @ptsAdj = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::LTSpline)o).ptsAdj = @ptsAdj;
            return ptr_of_this_method;
        }

        static object get_ptsAdjLength_6(ref object o)
        {
            return ((global::LTSpline)o).ptsAdjLength;
        }

        static StackObject* CopyToStack_ptsAdjLength_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTSpline)o).ptsAdjLength;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_ptsAdjLength_6(ref object o, object v)
        {
            ((global::LTSpline)o).ptsAdjLength = (System.Int32)v;
        }

        static StackObject* AssignFromStack_ptsAdjLength_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @ptsAdjLength = ptr_of_this_method->Value;
            ((global::LTSpline)o).ptsAdjLength = @ptsAdjLength;
            return ptr_of_this_method;
        }

        static object get_orientToPath_7(ref object o)
        {
            return ((global::LTSpline)o).orientToPath;
        }

        static StackObject* CopyToStack_orientToPath_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTSpline)o).orientToPath;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_orientToPath_7(ref object o, object v)
        {
            ((global::LTSpline)o).orientToPath = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_orientToPath_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @orientToPath = ptr_of_this_method->Value == 1;
            ((global::LTSpline)o).orientToPath = @orientToPath;
            return ptr_of_this_method;
        }

        static object get_orientToPath2d_8(ref object o)
        {
            return ((global::LTSpline)o).orientToPath2d;
        }

        static StackObject* CopyToStack_orientToPath2d_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTSpline)o).orientToPath2d;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_orientToPath2d_8(ref object o, object v)
        {
            ((global::LTSpline)o).orientToPath2d = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_orientToPath2d_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @orientToPath2d = ptr_of_this_method->Value == 1;
            ((global::LTSpline)o).orientToPath2d = @orientToPath2d;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3[] @pts = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new global::LTSpline(@pts);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @constantSpeed = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3[] @pts = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new global::LTSpline(@pts, @constantSpeed);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

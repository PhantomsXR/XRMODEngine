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
    unsafe class LTBezierPath_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(global::LTBezierPath);
            args = new Type[]{typeof(UnityEngine.Vector3[])};
            method = type.GetMethod("setPoints", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, setPoints_0);
            args = new Type[]{};
            method = type.GetMethod("get_distance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_distance_1);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("point", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, point_2);
            args = new Type[]{typeof(UnityEngine.Transform), typeof(System.Single)};
            method = type.GetMethod("place2d", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, place2d_3);
            args = new Type[]{typeof(UnityEngine.Transform), typeof(System.Single)};
            method = type.GetMethod("placeLocal2d", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, placeLocal2d_4);
            args = new Type[]{typeof(UnityEngine.Transform), typeof(System.Single)};
            method = type.GetMethod("place", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, place_5);
            args = new Type[]{typeof(UnityEngine.Transform), typeof(System.Single), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("place", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, place_6);
            args = new Type[]{typeof(UnityEngine.Transform), typeof(System.Single)};
            method = type.GetMethod("placeLocal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, placeLocal_7);
            args = new Type[]{typeof(UnityEngine.Transform), typeof(System.Single), typeof(UnityEngine.Vector3)};
            method = type.GetMethod("placeLocal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, placeLocal_8);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("gizmoDraw", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, gizmoDraw_9);
            args = new Type[]{typeof(UnityEngine.Vector3), typeof(System.Single)};
            method = type.GetMethod("ratioAtPoint", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ratioAtPoint_10);

            field = type.GetField("pts", flag);
            app.RegisterCLRFieldGetter(field, get_pts_0);
            app.RegisterCLRFieldSetter(field, set_pts_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_pts_0, AssignFromStack_pts_0);
            field = type.GetField("length", flag);
            app.RegisterCLRFieldGetter(field, get_length_1);
            app.RegisterCLRFieldSetter(field, set_length_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_length_1, AssignFromStack_length_1);
            field = type.GetField("orientToPath", flag);
            app.RegisterCLRFieldGetter(field, get_orientToPath_2);
            app.RegisterCLRFieldSetter(field, set_orientToPath_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_orientToPath_2, AssignFromStack_orientToPath_2);
            field = type.GetField("orientToPath2d", flag);
            app.RegisterCLRFieldGetter(field, get_orientToPath2d_3);
            app.RegisterCLRFieldSetter(field, set_orientToPath2d_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_orientToPath2d_3, AssignFromStack_orientToPath2d_3);


            app.RegisterCLRCreateDefaultInstance(type, () => new global::LTBezierPath());
            app.RegisterCLRCreateArrayInstance(type, s => new global::LTBezierPath[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
            args = new Type[]{typeof(UnityEngine.Vector3[])};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_1);

        }


        static StackObject* setPoints_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3[] @pts_ = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTBezierPath instance_of_this_method = (global::LTBezierPath)typeof(global::LTBezierPath).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.setPoints(@pts_);

            return __ret;
        }

        static StackObject* get_distance_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            global::LTBezierPath instance_of_this_method = (global::LTBezierPath)typeof(global::LTBezierPath).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.distance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* point_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @ratio = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTBezierPath instance_of_this_method = (global::LTBezierPath)typeof(global::LTBezierPath).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.point(@ratio);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* place2d_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            global::LTBezierPath instance_of_this_method = (global::LTBezierPath)typeof(global::LTBezierPath).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.place2d(@transform, @ratio);

            return __ret;
        }

        static StackObject* placeLocal2d_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            global::LTBezierPath instance_of_this_method = (global::LTBezierPath)typeof(global::LTBezierPath).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.placeLocal2d(@transform, @ratio);

            return __ret;
        }

        static StackObject* place_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            global::LTBezierPath instance_of_this_method = (global::LTBezierPath)typeof(global::LTBezierPath).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.place(@transform, @ratio);

            return __ret;
        }

        static StackObject* place_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            global::LTBezierPath instance_of_this_method = (global::LTBezierPath)typeof(global::LTBezierPath).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.place(@transform, @ratio, @worldUp);

            return __ret;
        }

        static StackObject* placeLocal_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            global::LTBezierPath instance_of_this_method = (global::LTBezierPath)typeof(global::LTBezierPath).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.placeLocal(@transform, @ratio);

            return __ret;
        }

        static StackObject* placeLocal_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            global::LTBezierPath instance_of_this_method = (global::LTBezierPath)typeof(global::LTBezierPath).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.placeLocal(@transform, @ratio, @worldUp);

            return __ret;
        }

        static StackObject* gizmoDraw_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @t = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            global::LTBezierPath instance_of_this_method = (global::LTBezierPath)typeof(global::LTBezierPath).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.gizmoDraw(@t);

            return __ret;
        }

        static StackObject* ratioAtPoint_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @precision = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @pt = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            global::LTBezierPath instance_of_this_method = (global::LTBezierPath)typeof(global::LTBezierPath).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ratioAtPoint(@pt, @precision);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }


        static object get_pts_0(ref object o)
        {
            return ((global::LTBezierPath)o).pts;
        }

        static StackObject* CopyToStack_pts_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTBezierPath)o).pts;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_pts_0(ref object o, object v)
        {
            ((global::LTBezierPath)o).pts = (UnityEngine.Vector3[])v;
        }

        static StackObject* AssignFromStack_pts_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Vector3[] @pts = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((global::LTBezierPath)o).pts = @pts;
            return ptr_of_this_method;
        }

        static object get_length_1(ref object o)
        {
            return ((global::LTBezierPath)o).length;
        }

        static StackObject* CopyToStack_length_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTBezierPath)o).length;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_length_1(ref object o, object v)
        {
            ((global::LTBezierPath)o).length = (System.Single)v;
        }

        static StackObject* AssignFromStack_length_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @length = *(float*)&ptr_of_this_method->Value;
            ((global::LTBezierPath)o).length = @length;
            return ptr_of_this_method;
        }

        static object get_orientToPath_2(ref object o)
        {
            return ((global::LTBezierPath)o).orientToPath;
        }

        static StackObject* CopyToStack_orientToPath_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTBezierPath)o).orientToPath;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_orientToPath_2(ref object o, object v)
        {
            ((global::LTBezierPath)o).orientToPath = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_orientToPath_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @orientToPath = ptr_of_this_method->Value == 1;
            ((global::LTBezierPath)o).orientToPath = @orientToPath;
            return ptr_of_this_method;
        }

        static object get_orientToPath2d_3(ref object o)
        {
            return ((global::LTBezierPath)o).orientToPath2d;
        }

        static StackObject* CopyToStack_orientToPath2d_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((global::LTBezierPath)o).orientToPath2d;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_orientToPath2d_3(ref object o, object v)
        {
            ((global::LTBezierPath)o).orientToPath2d = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_orientToPath2d_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @orientToPath2d = ptr_of_this_method->Value == 1;
            ((global::LTBezierPath)o).orientToPath2d = @orientToPath2d;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new global::LTBezierPath();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Ctor_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3[] @pts_ = (UnityEngine.Vector3[])typeof(UnityEngine.Vector3[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new global::LTBezierPath(@pts_);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

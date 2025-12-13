// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.UnityFusion.ValueBinder.
// //
// // The TankBrawl cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using UnityEngine;
using System.Collections.Generic;
using UnityFusion.Other;
using System;
using System.Reflection;
using UnityFusion.Runtime.Enviorment;
using UnityFusion.Runtime.Intepreter;
using UnityFusion.CLR.Method;
using UnityFusion.Runtime.Stack;
using AppDomain = UnityFusion.Runtime.Enviorment.AppDomain;

namespace Phantom.XRMOD.UnityFusion.ValueBinder
{
    public unsafe class Vector4Binder : ValueTypeBinder<Vector4>
    {
        public override unsafe void AssignFromStack(ref Vector4 ins, StackObject* ptr, IList<object> mStack)
        {
            var v = ILIntepreter.Minus(ptr, 1);
            ins.x = *(float*) &v->Value;
            v = ILIntepreter.Minus(ptr, 2);
            ins.y = *(float*) &v->Value;
            v = ILIntepreter.Minus(ptr, 3);
            ins.z = *(float*) &v->Value;
        }

        public override unsafe void CopyValueTypeToStack(ref Vector4 ins, StackObject* ptr, IList<object> mStack)
        {
            var v = ILIntepreter.Minus(ptr, 1);
            *(float*) &v->Value = ins.x;
            v = ILIntepreter.Minus(ptr, 2);
            *(float*) &v->Value = ins.y;
            v = ILIntepreter.Minus(ptr, 3);
            *(float*) &v->Value = ins.z;
        }

        public override void RegisterCLRRedirection(AppDomain appdomain)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Vector4);
            args = new Type[] {typeof(float), typeof(float), typeof(float)};
            method = type.GetConstructor(flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, NewVector4);

            args = new Type[] {typeof(float), typeof(float)};
            method = type.GetConstructor(flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, NewVector4_2);

            args = new Type[] {typeof(Vector4), typeof(Vector4)};
            method = type.GetMethod("op_Addition", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector4_Add);

            args = new Type[] {typeof(Vector4), typeof(Vector4)};
            method = type.GetMethod("op_Subtraction", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector4_Subtraction);

            args = new Type[] {typeof(Vector4), typeof(float)};
            method = type.GetMethod("op_Multiply", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector4_Multiply);

            args = new Type[] {typeof(float), typeof(Vector4)};
            method = type.GetMethod("op_Multiply", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector4_Multiply2);

            args = new Type[] {typeof(Vector4), typeof(float)};
            method = type.GetMethod("op_Division", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector4_Division);

            args = new Type[] {typeof(Vector4)};
            method = type.GetMethod("op_UnaryNegation", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector4_Negate);

            args = new Type[] {typeof(Vector4), typeof(Vector4)};
            method = type.GetMethod("op_Equality", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector4_Equality);

            args = new Type[] {typeof(Vector4), typeof(Vector4)};
            method = type.GetMethod("op_Inequality", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector4_Inequality);

            args = new Type[] {typeof(Vector4)};
            method = type.GetMethod("Normalize", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector4_Normalize);

            args = new Type[] {typeof(Vector4), typeof(Vector4)};
            method = type.GetMethod("Dot", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector4_Dot);


            args = new Type[] {typeof(Vector4), typeof(Vector4)};
            method = type.GetMethod("Distance", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Vector4_Distance);

            args = new Type[] { };
            method = type.GetMethod("get_magnitude", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Get_Magnitude);

            args = new Type[] { };
            method = type.GetMethod("get_sqrMagnitude", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Get_SqrMagnitude);

            args = new Type[] { };
            method = type.GetMethod("get_normalized", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Get_Normalized);

            args = new Type[] { };
            method = type.GetMethod("get_one", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Get_One);

            args = new Type[] { };
            method = type.GetMethod("get_zero", flag, null, args, null);
            appdomain.RegisterCLRMethodRedirection(method, Get_Zero);
        }

        StackObject* Vector4_Add(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method,
            bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);
            var ptr = ILIntepreter.Minus(esp, 1);

            Vector4 left, right;
            ParseVector4(out right, intp, ptr, mStack);

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector4(out left, intp, ptr, mStack);

            var res = left + right;
            PushVector4(ref res, intp, ret, mStack);

            return ret + 1;
        }

        StackObject* Vector4_Subtraction(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method,
            bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);
            var ptr = ILIntepreter.Minus(esp, 1);

            Vector4 left, right;
            ParseVector4(out right, intp, ptr, mStack);

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector4(out left, intp, ptr, mStack);

            var res = left - right;
            PushVector4(ref res, intp, ret, mStack);

            return ret + 1;
        }

        StackObject* Vector4_Multiply(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method,
            bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);

            var ptr = ILIntepreter.Minus(esp, 1);
            var b = ILIntepreter.GetObjectAndResolveReference(ptr);

            float val = *(float*) &b->Value;

            Vector4 vec;

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector4(out vec, intp, ptr, mStack);

            vec = vec * val;
            PushVector4(ref vec, intp, ret, mStack);

            return ret + 1;
        }

        StackObject* Vector4_Multiply2(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method,
            bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);
            Vector4 vec;

            var ptr = ILIntepreter.Minus(esp, 1);
            ParseVector4(out vec, intp, ptr, mStack);

            ptr = ILIntepreter.Minus(esp, 2);
            var b = ILIntepreter.GetObjectAndResolveReference(ptr);

            float val = *(float*) &b->Value;

            vec = val * vec;
            PushVector4(ref vec, intp, ret, mStack);

            return ret + 1;
        }

        StackObject* Vector4_Division(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method,
            bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);

            var ptr = ILIntepreter.Minus(esp, 1);
            var b = ILIntepreter.GetObjectAndResolveReference(ptr);

            float val = *(float*) &b->Value;

            Vector4 vec;

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector4(out vec, intp, ptr, mStack);

            vec = vec / val;
            PushVector4(ref vec, intp, ret, mStack);

            return ret + 1;
        }

        StackObject* Vector4_Negate(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method,
            bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 1);

            var ptr = ILIntepreter.Minus(esp, 1);
            Vector4 vec;

            ptr = ILIntepreter.Minus(esp, 1);
            ParseVector4(out vec, intp, ptr, mStack);

            vec = -vec;
            PushVector4(ref vec, intp, ret, mStack);

            return ret + 1;
        }

        StackObject* Vector4_Normalize(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method,
            bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 1);

            var ptr = ILIntepreter.Minus(esp, 1);
            Vector4 vec;

            ptr = ILIntepreter.Minus(esp, 1);
            ParseVector4(out vec, intp, ptr, mStack);

            vec = Vector4.Normalize(vec);
            PushVector4(ref vec, intp, ret, mStack);

            return ret + 1;
        }

        StackObject* Vector4_Equality(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method,
            bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);
            var ptr = ILIntepreter.Minus(esp, 1);

            Vector4 left, right;
            ParseVector4(out right, intp, ptr, mStack);

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector4(out left, intp, ptr, mStack);

            var res = left == right;

            ret->ObjectType = ObjectTypes.Integer;
            ret->Value = res ? 1 : 0;
            return ret + 1;
        }

        StackObject* Vector4_Inequality(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method,
            bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);
            var ptr = ILIntepreter.Minus(esp, 1);

            Vector4 left, right;
            ParseVector4(out right, intp, ptr, mStack);

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector4(out left, intp, ptr, mStack);

            var res = left != right;

            ret->ObjectType = ObjectTypes.Integer;
            ret->Value = res ? 1 : 0;
            return ret + 1;
        }

        StackObject* Vector4_Dot(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method,
            bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);
            var ptr = ILIntepreter.Minus(esp, 1);

            Vector4 left, right;
            ParseVector4(out right, intp, ptr, mStack);

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector4(out left, intp, ptr, mStack);

            var res = Vector4.Dot(left, right);

            ret->ObjectType = ObjectTypes.Float;
            *(float*) &ret->Value = res;
            return ret + 1;
        }

        StackObject* Vector4_Distance(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method,
            bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 2);
            var ptr = ILIntepreter.Minus(esp, 1);

            Vector4 left, right;
            ParseVector4(out right, intp, ptr, mStack);

            ptr = ILIntepreter.Minus(esp, 2);
            ParseVector4(out left, intp, ptr, mStack);

            var res = Vector4.Distance(left, right);

            ret->ObjectType = ObjectTypes.Float;
            *(float*) &ret->Value = res;
            return ret + 1;
        }


        StackObject* NewVector4(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method,
            bool isNewObj)
        {
            StackObject* ret;
            if (isNewObj)
            {
                ret = ILIntepreter.Minus(esp, 2);
                Vector4 vec = default;
                var ptr = ILIntepreter.Minus(esp, 1);
                vec.z = *(float*) &ptr->Value;
                ptr = ILIntepreter.Minus(esp, 2);
                vec.y = *(float*) &ptr->Value;
                ptr = ILIntepreter.Minus(esp, 3);
                vec.x = *(float*) &ptr->Value;

                PushVector4(ref vec, intp, ptr, mStack);
            }
            else
            {
                ret = ILIntepreter.Minus(esp, 4);
                var instance = ILIntepreter.GetObjectAndResolveReference(ret);
                var dst = *(StackObject**) &instance->Value;
                var f = ILIntepreter.Minus(dst, 1);
                var v = ILIntepreter.Minus(esp, 3);
                *f = *v;

                f = ILIntepreter.Minus(dst, 2);
                v = ILIntepreter.Minus(esp, 2);
                *f = *v;

                f = ILIntepreter.Minus(dst, 3);
                v = ILIntepreter.Minus(esp, 1);
                *f = *v;
            }

            return ret;
        }

        StackObject* NewVector4_2(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method,
            bool isNewObj)
        {
            StackObject* ret;
            if (isNewObj)
            {
                ret = ILIntepreter.Minus(esp, 1);
                Vector4 vec = default;
                var ptr = ILIntepreter.Minus(esp, 1);
                vec.y = *(float*) &ptr->Value;
                ptr = ILIntepreter.Minus(esp, 2);
                vec.x = *(float*) &ptr->Value;
                vec.z = 0;

                PushVector4(ref vec, intp, ptr, mStack);
            }
            else
            {
                ret = ILIntepreter.Minus(esp, 3);
                var instance = ILIntepreter.GetObjectAndResolveReference(ret);
                var dst = *(StackObject**) &instance->Value;
                var f = ILIntepreter.Minus(dst, 1);
                var v = ILIntepreter.Minus(esp, 2);
                *f = *v;

                f = ILIntepreter.Minus(dst, 2);
                v = ILIntepreter.Minus(esp, 1);
                *f = *v;

                f = ILIntepreter.Minus(dst, 3);
                *(float*) &f->Value = 0f;
            }

            return ret;
        }

        StackObject* Get_Magnitude(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method,
            bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 1);

            var ptr = ILIntepreter.Minus(esp, 1);
            Vector4 vec;
            ParseVector4(out vec, intp, ptr, mStack);

            float res = vec.magnitude;

            ret->ObjectType = ObjectTypes.Float;
            *(float*) &ret->Value = res;
            return ret + 1;
        }

        StackObject* Get_SqrMagnitude(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method,
            bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 1);

            var ptr = ILIntepreter.Minus(esp, 1);
            Vector4 vec;
            ParseVector4(out vec, intp, ptr, mStack);

            float res = vec.sqrMagnitude;

            ret->ObjectType = ObjectTypes.Float;
            *(float*) &ret->Value = res;
            return ret + 1;
        }

        StackObject* Get_Normalized(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method,
            bool isNewObj)
        {
            var ret = ILIntepreter.Minus(esp, 1);
            var ptr = ILIntepreter.Minus(esp, 1);
            Vector4 vec;
            ParseVector4(out vec, intp, ptr, mStack);

            var res = vec.normalized;

            PushVector4(ref res, intp, ret, mStack);
            return ret + 1;
        }

        StackObject* Get_One(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method, bool isNewObj)
        {
            var ret = esp;
            var res = Vector4.one;
            PushVector4(ref res, intp, ret, mStack);
            return ret + 1;
        }

        StackObject* Get_Zero(ILIntepreter intp, StackObject* esp, IList<object> mStack, CLRMethod method,
            bool isNewObj)
        {
            var ret = esp;
            var res = Vector4.zero;
            PushVector4(ref res, intp, ret, mStack);
            return ret + 1;
        }


        public static void ParseVector4(out Vector4 vec, ILIntepreter intp, StackObject* ptr, IList<object> mStack)
        {
            vec = default;
            var a = ILIntepreter.GetObjectAndResolveReference(ptr);
            if (a->ObjectType == ObjectTypes.ValueTypeObjectReference)
            {
                var src = *(StackObject**) &a->Value;
                vec.x = *(float*) &ILIntepreter.Minus(src, 1)->Value;
                vec.y = *(float*) &ILIntepreter.Minus(src, 2)->Value;
                vec.z = *(float*) &ILIntepreter.Minus(src, 3)->Value;
                intp.FreeStackValueType(ptr);
            }
            else
            {
                vec = (Vector4) StackObject.ToObject(a, intp.AppDomain, mStack);
                intp.Free(ptr);
            }
        }

        public void PushVector4(ref Vector4 vec, ILIntepreter intp, StackObject* ptr, IList<object> mStack)
        {
            intp.AllocValueType(ptr, CLRType);
            var dst = *((StackObject**) &ptr->Value);
            CopyValueTypeToStack(ref vec, dst, mStack);
        }
    }
}
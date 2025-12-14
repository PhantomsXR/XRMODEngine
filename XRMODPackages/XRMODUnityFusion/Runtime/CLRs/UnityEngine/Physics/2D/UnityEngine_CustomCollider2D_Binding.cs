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
    unsafe class UnityEngine_CustomCollider2D_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.CustomCollider2D);
            args = new Type[]{};
            method = type.GetMethod("get_customShapeCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_customShapeCount_0);
            args = new Type[]{};
            method = type.GetMethod("get_customVertexCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_customVertexCount_1);
            args = new Type[]{typeof(UnityEngine.PhysicsShapeGroup2D)};
            method = type.GetMethod("GetCustomShapes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCustomShapes_2);
            args = new Type[]{typeof(UnityEngine.PhysicsShapeGroup2D), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("GetCustomShapes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCustomShapes_3);
            args = new Type[]{typeof(Unity.Collections.NativeArray<UnityEngine.PhysicsShape2D>), typeof(Unity.Collections.NativeArray<UnityEngine.Vector2>)};
            method = type.GetMethod("GetCustomShapes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCustomShapes_4);
            args = new Type[]{typeof(UnityEngine.PhysicsShapeGroup2D)};
            method = type.GetMethod("SetCustomShapes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetCustomShapes_5);
            args = new Type[]{typeof(Unity.Collections.NativeArray<UnityEngine.PhysicsShape2D>), typeof(Unity.Collections.NativeArray<UnityEngine.Vector2>)};
            method = type.GetMethod("SetCustomShapes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetCustomShapes_6);
            args = new Type[]{typeof(UnityEngine.PhysicsShapeGroup2D), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SetCustomShape", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetCustomShape_7);
            args = new Type[]{typeof(Unity.Collections.NativeArray<UnityEngine.PhysicsShape2D>), typeof(Unity.Collections.NativeArray<UnityEngine.Vector2>), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("SetCustomShape", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetCustomShape_8);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("ClearCustomShapes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearCustomShapes_9);
            args = new Type[]{};
            method = type.GetMethod("ClearCustomShapes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearCustomShapes_10);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.CustomCollider2D());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.CustomCollider2D[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_customShapeCount_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CustomCollider2D instance_of_this_method = (UnityEngine.CustomCollider2D)typeof(UnityEngine.CustomCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.customShapeCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_customVertexCount_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CustomCollider2D instance_of_this_method = (UnityEngine.CustomCollider2D)typeof(UnityEngine.CustomCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.customVertexCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetCustomShapes_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PhysicsShapeGroup2D @physicsShapeGroup = (UnityEngine.PhysicsShapeGroup2D)typeof(UnityEngine.PhysicsShapeGroup2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CustomCollider2D instance_of_this_method = (UnityEngine.CustomCollider2D)typeof(UnityEngine.CustomCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetCustomShapes(@physicsShapeGroup);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetCustomShapes_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @shapeCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @shapeIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.PhysicsShapeGroup2D @physicsShapeGroup = (UnityEngine.PhysicsShapeGroup2D)typeof(UnityEngine.PhysicsShapeGroup2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.CustomCollider2D instance_of_this_method = (UnityEngine.CustomCollider2D)typeof(UnityEngine.CustomCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetCustomShapes(@physicsShapeGroup, @shapeIndex, @shapeCount);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetCustomShapes_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Collections.NativeArray<UnityEngine.Vector2> @vertices = (Unity.Collections.NativeArray<UnityEngine.Vector2>)typeof(Unity.Collections.NativeArray<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Collections.NativeArray<UnityEngine.PhysicsShape2D> @shapes = (Unity.Collections.NativeArray<UnityEngine.PhysicsShape2D>)typeof(Unity.Collections.NativeArray<UnityEngine.PhysicsShape2D>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.CustomCollider2D instance_of_this_method = (UnityEngine.CustomCollider2D)typeof(UnityEngine.CustomCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetCustomShapes(@shapes, @vertices);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetCustomShapes_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.PhysicsShapeGroup2D @physicsShapeGroup = (UnityEngine.PhysicsShapeGroup2D)typeof(UnityEngine.PhysicsShapeGroup2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.CustomCollider2D instance_of_this_method = (UnityEngine.CustomCollider2D)typeof(UnityEngine.CustomCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetCustomShapes(@physicsShapeGroup);

            return __ret;
        }

        static StackObject* SetCustomShapes_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Collections.NativeArray<UnityEngine.Vector2> @vertices = (Unity.Collections.NativeArray<UnityEngine.Vector2>)typeof(Unity.Collections.NativeArray<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Collections.NativeArray<UnityEngine.PhysicsShape2D> @shapes = (Unity.Collections.NativeArray<UnityEngine.PhysicsShape2D>)typeof(Unity.Collections.NativeArray<UnityEngine.PhysicsShape2D>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.CustomCollider2D instance_of_this_method = (UnityEngine.CustomCollider2D)typeof(UnityEngine.CustomCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetCustomShapes(@shapes, @vertices);

            return __ret;
        }

        static StackObject* SetCustomShape_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @dstShapeIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @srcShapeIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.PhysicsShapeGroup2D @physicsShapeGroup = (UnityEngine.PhysicsShapeGroup2D)typeof(UnityEngine.PhysicsShapeGroup2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.CustomCollider2D instance_of_this_method = (UnityEngine.CustomCollider2D)typeof(UnityEngine.CustomCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetCustomShape(@physicsShapeGroup, @srcShapeIndex, @dstShapeIndex);

            return __ret;
        }

        static StackObject* SetCustomShape_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @dstShapeIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @srcShapeIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Collections.NativeArray<UnityEngine.Vector2> @vertices = (Unity.Collections.NativeArray<UnityEngine.Vector2>)typeof(Unity.Collections.NativeArray<UnityEngine.Vector2>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Unity.Collections.NativeArray<UnityEngine.PhysicsShape2D> @shapes = (Unity.Collections.NativeArray<UnityEngine.PhysicsShape2D>)typeof(Unity.Collections.NativeArray<UnityEngine.PhysicsShape2D>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.CustomCollider2D instance_of_this_method = (UnityEngine.CustomCollider2D)typeof(UnityEngine.CustomCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetCustomShape(@shapes, @vertices, @srcShapeIndex, @dstShapeIndex);

            return __ret;
        }

        static StackObject* ClearCustomShapes_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @shapeCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @shapeIndex = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.CustomCollider2D instance_of_this_method = (UnityEngine.CustomCollider2D)typeof(UnityEngine.CustomCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClearCustomShapes(@shapeIndex, @shapeCount);

            return __ret;
        }

        static StackObject* ClearCustomShapes_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.CustomCollider2D instance_of_this_method = (UnityEngine.CustomCollider2D)typeof(UnityEngine.CustomCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClearCustomShapes();

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.CustomCollider2D();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

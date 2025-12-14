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
    unsafe class UnityEngine_Tilemaps_TilemapCollider2D_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Tilemaps.TilemapCollider2D);
            args = new Type[]{};
            method = type.GetMethod("get_useDelaunayMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_useDelaunayMesh_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_useDelaunayMesh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_useDelaunayMesh_1);
            args = new Type[]{};
            method = type.GetMethod("get_maximumTileChangeCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maximumTileChangeCount_2);
            args = new Type[]{typeof(System.UInt32)};
            method = type.GetMethod("set_maximumTileChangeCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maximumTileChangeCount_3);
            args = new Type[]{};
            method = type.GetMethod("get_extrusionFactor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_extrusionFactor_4);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_extrusionFactor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_extrusionFactor_5);
            args = new Type[]{};
            method = type.GetMethod("get_hasTilemapChanges", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasTilemapChanges_6);
            args = new Type[]{};
            method = type.GetMethod("ProcessTilemapChanges", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ProcessTilemapChanges_7);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Tilemaps.TilemapCollider2D());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Tilemaps.TilemapCollider2D[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_useDelaunayMesh_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TilemapCollider2D instance_of_this_method = (UnityEngine.Tilemaps.TilemapCollider2D)typeof(UnityEngine.Tilemaps.TilemapCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.useDelaunayMesh;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_useDelaunayMesh_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.TilemapCollider2D instance_of_this_method = (UnityEngine.Tilemaps.TilemapCollider2D)typeof(UnityEngine.Tilemaps.TilemapCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.useDelaunayMesh = value;

            return __ret;
        }

        static StackObject* get_maximumTileChangeCount_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TilemapCollider2D instance_of_this_method = (UnityEngine.Tilemaps.TilemapCollider2D)typeof(UnityEngine.Tilemaps.TilemapCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maximumTileChangeCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maximumTileChangeCount_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 @value = (uint)ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.TilemapCollider2D instance_of_this_method = (UnityEngine.Tilemaps.TilemapCollider2D)typeof(UnityEngine.Tilemaps.TilemapCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maximumTileChangeCount = value;

            return __ret;
        }

        static StackObject* get_extrusionFactor_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TilemapCollider2D instance_of_this_method = (UnityEngine.Tilemaps.TilemapCollider2D)typeof(UnityEngine.Tilemaps.TilemapCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.extrusionFactor;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_extrusionFactor_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.TilemapCollider2D instance_of_this_method = (UnityEngine.Tilemaps.TilemapCollider2D)typeof(UnityEngine.Tilemaps.TilemapCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.extrusionFactor = value;

            return __ret;
        }

        static StackObject* get_hasTilemapChanges_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TilemapCollider2D instance_of_this_method = (UnityEngine.Tilemaps.TilemapCollider2D)typeof(UnityEngine.Tilemaps.TilemapCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hasTilemapChanges;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* ProcessTilemapChanges_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TilemapCollider2D instance_of_this_method = (UnityEngine.Tilemaps.TilemapCollider2D)typeof(UnityEngine.Tilemaps.TilemapCollider2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ProcessTilemapChanges();

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Tilemaps.TilemapCollider2D();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

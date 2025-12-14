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
    unsafe class UnityEngine_Tilemaps_TilemapRenderer_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Tilemaps.TilemapRenderer);
            args = new Type[]{};
            method = type.GetMethod("get_chunkSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_chunkSize_0);
            args = new Type[]{typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("set_chunkSize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_chunkSize_1);
            args = new Type[]{};
            method = type.GetMethod("get_chunkCullingBounds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_chunkCullingBounds_2);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_chunkCullingBounds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_chunkCullingBounds_3);
            args = new Type[]{};
            method = type.GetMethod("get_maxChunkCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxChunkCount_4);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_maxChunkCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxChunkCount_5);
            args = new Type[]{};
            method = type.GetMethod("get_maxFrameAge", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxFrameAge_6);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_maxFrameAge", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxFrameAge_7);
            args = new Type[]{};
            method = type.GetMethod("get_sortOrder", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sortOrder_8);
            args = new Type[]{typeof(UnityEngine.Tilemaps.TilemapRenderer.SortOrder)};
            method = type.GetMethod("set_sortOrder", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sortOrder_9);
            args = new Type[]{};
            method = type.GetMethod("get_mode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mode_10);
            args = new Type[]{typeof(UnityEngine.Tilemaps.TilemapRenderer.Mode)};
            method = type.GetMethod("set_mode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_mode_11);
            args = new Type[]{};
            method = type.GetMethod("get_detectChunkCullingBounds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_detectChunkCullingBounds_12);
            args = new Type[]{typeof(UnityEngine.Tilemaps.TilemapRenderer.DetectChunkCullingBounds)};
            method = type.GetMethod("set_detectChunkCullingBounds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_detectChunkCullingBounds_13);
            args = new Type[]{};
            method = type.GetMethod("get_maskInteraction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maskInteraction_14);
            args = new Type[]{typeof(UnityEngine.SpriteMaskInteraction)};
            method = type.GetMethod("set_maskInteraction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maskInteraction_15);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Tilemaps.TilemapRenderer());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Tilemaps.TilemapRenderer[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_chunkSize_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TilemapRenderer instance_of_this_method = (UnityEngine.Tilemaps.TilemapRenderer)typeof(UnityEngine.Tilemaps.TilemapRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.chunkSize;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_chunkSize_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @value = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.TilemapRenderer instance_of_this_method = (UnityEngine.Tilemaps.TilemapRenderer)typeof(UnityEngine.Tilemaps.TilemapRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.chunkSize = value;

            return __ret;
        }

        static StackObject* get_chunkCullingBounds_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TilemapRenderer instance_of_this_method = (UnityEngine.Tilemaps.TilemapRenderer)typeof(UnityEngine.Tilemaps.TilemapRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.chunkCullingBounds;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_chunkCullingBounds_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.TilemapRenderer instance_of_this_method = (UnityEngine.Tilemaps.TilemapRenderer)typeof(UnityEngine.Tilemaps.TilemapRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.chunkCullingBounds = value;

            return __ret;
        }

        static StackObject* get_maxChunkCount_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TilemapRenderer instance_of_this_method = (UnityEngine.Tilemaps.TilemapRenderer)typeof(UnityEngine.Tilemaps.TilemapRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxChunkCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxChunkCount_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.TilemapRenderer instance_of_this_method = (UnityEngine.Tilemaps.TilemapRenderer)typeof(UnityEngine.Tilemaps.TilemapRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maxChunkCount = value;

            return __ret;
        }

        static StackObject* get_maxFrameAge_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TilemapRenderer instance_of_this_method = (UnityEngine.Tilemaps.TilemapRenderer)typeof(UnityEngine.Tilemaps.TilemapRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxFrameAge;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxFrameAge_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.TilemapRenderer instance_of_this_method = (UnityEngine.Tilemaps.TilemapRenderer)typeof(UnityEngine.Tilemaps.TilemapRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maxFrameAge = value;

            return __ret;
        }

        static StackObject* get_sortOrder_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TilemapRenderer instance_of_this_method = (UnityEngine.Tilemaps.TilemapRenderer)typeof(UnityEngine.Tilemaps.TilemapRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sortOrder;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_sortOrder_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TilemapRenderer.SortOrder @value = (UnityEngine.Tilemaps.TilemapRenderer.SortOrder)typeof(UnityEngine.Tilemaps.TilemapRenderer.SortOrder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.TilemapRenderer instance_of_this_method = (UnityEngine.Tilemaps.TilemapRenderer)typeof(UnityEngine.Tilemaps.TilemapRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.sortOrder = value;

            return __ret;
        }

        static StackObject* get_mode_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TilemapRenderer instance_of_this_method = (UnityEngine.Tilemaps.TilemapRenderer)typeof(UnityEngine.Tilemaps.TilemapRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.mode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_mode_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TilemapRenderer.Mode @value = (UnityEngine.Tilemaps.TilemapRenderer.Mode)typeof(UnityEngine.Tilemaps.TilemapRenderer.Mode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.TilemapRenderer instance_of_this_method = (UnityEngine.Tilemaps.TilemapRenderer)typeof(UnityEngine.Tilemaps.TilemapRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.mode = value;

            return __ret;
        }

        static StackObject* get_detectChunkCullingBounds_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TilemapRenderer instance_of_this_method = (UnityEngine.Tilemaps.TilemapRenderer)typeof(UnityEngine.Tilemaps.TilemapRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.detectChunkCullingBounds;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_detectChunkCullingBounds_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TilemapRenderer.DetectChunkCullingBounds @value = (UnityEngine.Tilemaps.TilemapRenderer.DetectChunkCullingBounds)typeof(UnityEngine.Tilemaps.TilemapRenderer.DetectChunkCullingBounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.TilemapRenderer instance_of_this_method = (UnityEngine.Tilemaps.TilemapRenderer)typeof(UnityEngine.Tilemaps.TilemapRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.detectChunkCullingBounds = value;

            return __ret;
        }

        static StackObject* get_maskInteraction_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TilemapRenderer instance_of_this_method = (UnityEngine.Tilemaps.TilemapRenderer)typeof(UnityEngine.Tilemaps.TilemapRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maskInteraction;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_maskInteraction_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.SpriteMaskInteraction @value = (UnityEngine.SpriteMaskInteraction)typeof(UnityEngine.SpriteMaskInteraction).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.TilemapRenderer instance_of_this_method = (UnityEngine.Tilemaps.TilemapRenderer)typeof(UnityEngine.Tilemaps.TilemapRenderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maskInteraction = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Tilemaps.TilemapRenderer();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

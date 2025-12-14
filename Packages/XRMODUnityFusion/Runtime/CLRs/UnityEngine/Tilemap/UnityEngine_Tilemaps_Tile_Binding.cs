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
    unsafe class UnityEngine_Tilemaps_Tile_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Tilemaps.Tile);
            args = new Type[]{};
            method = type.GetMethod("get_sprite", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_sprite_0);
            args = new Type[]{typeof(UnityEngine.Sprite)};
            method = type.GetMethod("set_sprite", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_sprite_1);
            args = new Type[]{};
            method = type.GetMethod("get_color", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_color_2);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("set_color", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_color_3);
            args = new Type[]{};
            method = type.GetMethod("get_transform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_transform_4);
            args = new Type[]{typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("set_transform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_transform_5);
            args = new Type[]{};
            method = type.GetMethod("get_gameObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_gameObject_6);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("set_gameObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_gameObject_7);
            args = new Type[]{};
            method = type.GetMethod("get_flags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_flags_8);
            args = new Type[]{typeof(UnityEngine.Tilemaps.TileFlags)};
            method = type.GetMethod("set_flags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_flags_9);
            args = new Type[]{};
            method = type.GetMethod("get_colliderType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_colliderType_10);
            args = new Type[]{typeof(UnityEngine.Tilemaps.Tile.ColliderType)};
            method = type.GetMethod("set_colliderType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_colliderType_11);
            args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Tilemaps.ITilemap), typeof(UnityEngine.Tilemaps.TileData).MakeByRefType()};
            method = type.GetMethod("GetTileData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTileData_12);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Tilemaps.Tile());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Tilemaps.Tile[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_sprite_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tile instance_of_this_method = (UnityEngine.Tilemaps.Tile)typeof(UnityEngine.Tilemaps.Tile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.sprite;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_sprite_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Sprite @value = (UnityEngine.Sprite)typeof(UnityEngine.Sprite).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tile instance_of_this_method = (UnityEngine.Tilemaps.Tile)typeof(UnityEngine.Tilemaps.Tile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.sprite = value;

            return __ret;
        }

        static StackObject* get_color_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tile instance_of_this_method = (UnityEngine.Tilemaps.Tile)typeof(UnityEngine.Tilemaps.Tile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.color;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_color_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tile instance_of_this_method = (UnityEngine.Tilemaps.Tile)typeof(UnityEngine.Tilemaps.Tile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.color = value;

            return __ret;
        }

        static StackObject* get_transform_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tile instance_of_this_method = (UnityEngine.Tilemaps.Tile)typeof(UnityEngine.Tilemaps.Tile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.transform;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_transform_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 @value = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tile instance_of_this_method = (UnityEngine.Tilemaps.Tile)typeof(UnityEngine.Tilemaps.Tile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.transform = value;

            return __ret;
        }

        static StackObject* get_gameObject_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tile instance_of_this_method = (UnityEngine.Tilemaps.Tile)typeof(UnityEngine.Tilemaps.Tile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.gameObject;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_gameObject_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @value = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tile instance_of_this_method = (UnityEngine.Tilemaps.Tile)typeof(UnityEngine.Tilemaps.Tile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.gameObject = value;

            return __ret;
        }

        static StackObject* get_flags_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tile instance_of_this_method = (UnityEngine.Tilemaps.Tile)typeof(UnityEngine.Tilemaps.Tile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.flags;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_flags_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TileFlags @value = (UnityEngine.Tilemaps.TileFlags)typeof(UnityEngine.Tilemaps.TileFlags).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tile instance_of_this_method = (UnityEngine.Tilemaps.Tile)typeof(UnityEngine.Tilemaps.Tile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.flags = value;

            return __ret;
        }

        static StackObject* get_colliderType_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tile instance_of_this_method = (UnityEngine.Tilemaps.Tile)typeof(UnityEngine.Tilemaps.Tile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.colliderType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_colliderType_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tile.ColliderType @value = (UnityEngine.Tilemaps.Tile.ColliderType)typeof(UnityEngine.Tilemaps.Tile.ColliderType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tile instance_of_this_method = (UnityEngine.Tilemaps.Tile)typeof(UnityEngine.Tilemaps.Tile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.colliderType = value;

            return __ret;
        }

        static StackObject* GetTileData_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TileData @tileData = (UnityEngine.Tilemaps.TileData)typeof(UnityEngine.Tilemaps.TileData).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.ITilemap @tilemap = (UnityEngine.Tilemaps.ITilemap)typeof(UnityEngine.Tilemaps.ITilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Tilemaps.Tile instance_of_this_method = (UnityEngine.Tilemaps.Tile)typeof(UnityEngine.Tilemaps.Tile).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            instance_of_this_method.GetTileData(@position, @tilemap, ref @tileData);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @tileData;
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
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @tileData;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @tileData);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @tileData;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @tileData);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Tilemaps.TileData[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @tileData;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.Free(ptr_of_this_method);
            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Tilemaps.Tile();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

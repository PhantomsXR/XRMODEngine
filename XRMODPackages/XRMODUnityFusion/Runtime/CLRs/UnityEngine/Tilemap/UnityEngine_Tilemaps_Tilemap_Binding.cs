using System;
using System.Collections.Generic;
using System.Linq;
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
    unsafe class UnityEngine_Tilemaps_Tilemap_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.Tilemaps.Tilemap);
            MethodInfo[] methods = type.GetMethods(flag).Where(t => !t.IsGenericMethod).ToArray();
            args = new Type[]{typeof(System.Action<UnityEngine.Tilemaps.Tilemap, UnityEngine.Tilemaps.Tilemap.SyncTile[]>)};
            method = type.GetMethod("add_tilemapTileChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_tilemapTileChanged_0);
            args = new Type[]{typeof(System.Action<UnityEngine.Tilemaps.Tilemap, UnityEngine.Tilemaps.Tilemap.SyncTile[]>)};
            method = type.GetMethod("remove_tilemapTileChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_tilemapTileChanged_1);
            args = new Type[]{typeof(System.Action<UnityEngine.Tilemaps.Tilemap, Unity.Collections.NativeArray<UnityEngine.Vector3Int>>)};
            method = type.GetMethod("add_tilemapPositionsChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_tilemapPositionsChanged_2);
            args = new Type[]{typeof(System.Action<UnityEngine.Tilemaps.Tilemap, Unity.Collections.NativeArray<UnityEngine.Vector3Int>>)};
            method = type.GetMethod("remove_tilemapPositionsChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_tilemapPositionsChanged_3);
            args = new Type[]{};
            method = type.GetMethod("get_layoutGrid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_layoutGrid_4);
            args = new Type[]{typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("GetCellCenterLocal", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCellCenterLocal_5);
            args = new Type[]{typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("GetCellCenterWorld", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCellCenterWorld_6);
            args = new Type[]{};
            method = type.GetMethod("get_cellBounds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cellBounds_7);
            args = new Type[]{};
            method = type.GetMethod("get_localBounds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_localBounds_8);
            args = new Type[]{};
            method = type.GetMethod("get_animationFrameRate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_animationFrameRate_9);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_animationFrameRate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_animationFrameRate_10);
            args = new Type[]{};
            method = type.GetMethod("get_color", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_color_11);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("set_color", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_color_12);
            args = new Type[]{};
            method = type.GetMethod("get_origin", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_origin_13);
            args = new Type[]{typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("set_origin", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_origin_14);
            args = new Type[]{};
            method = type.GetMethod("get_size", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_size_15);
            args = new Type[]{typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("set_size", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_size_16);
            args = new Type[]{};
            method = type.GetMethod("get_tileAnchor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_tileAnchor_17);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_tileAnchor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_tileAnchor_18);
            args = new Type[]{};
            method = type.GetMethod("get_orientation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_orientation_19);
            args = new Type[]{typeof(UnityEngine.Tilemaps.Tilemap.Orientation)};
            method = type.GetMethod("set_orientation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_orientation_20);
            args = new Type[]{};
            method = type.GetMethod("get_orientationMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_orientationMatrix_21);
            args = new Type[]{typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("set_orientationMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_orientationMatrix_22);
            args = new Type[]{typeof(UnityEngine.Vector3Int)};
            method = methods.Where(t => t.Name.Equals("GetTile") && t.CheckMethodParams(args)).Single();
            app.RegisterCLRMethodRedirection(method, GetTile_23);
            args = new Type[]{typeof(UnityEngine.BoundsInt)};
            method = type.GetMethod("GetTilesBlock", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTilesBlock_24);
            args = new Type[]{typeof(UnityEngine.BoundsInt), typeof(UnityEngine.Tilemaps.TileBase[])};
            method = type.GetMethod("GetTilesBlockNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTilesBlockNonAlloc_25);
            args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("GetTilesRangeCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTilesRangeCount_26);
            args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int[]), typeof(UnityEngine.Tilemaps.TileBase[])};
            method = type.GetMethod("GetTilesRangeNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTilesRangeNonAlloc_27);
            args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Tilemaps.TileBase)};
            method = type.GetMethod("SetTile", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTile_28);
            args = new Type[]{typeof(UnityEngine.Vector3Int[]), typeof(UnityEngine.Tilemaps.TileBase[])};
            method = type.GetMethod("SetTiles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTiles_29);
            args = new Type[]{typeof(UnityEngine.BoundsInt), typeof(UnityEngine.Tilemaps.TileBase[])};
            method = type.GetMethod("SetTilesBlock", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTilesBlock_30);
            args = new Type[]{typeof(UnityEngine.Tilemaps.TileChangeData), typeof(System.Boolean)};
            method = type.GetMethod("SetTile", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTile_31);
            args = new Type[]{typeof(UnityEngine.Tilemaps.TileChangeData[]), typeof(System.Boolean)};
            method = type.GetMethod("SetTiles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTiles_32);
            args = new Type[]{typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("HasTile", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HasTile_33);
            args = new Type[]{typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("RefreshTile", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RefreshTile_34);
            args = new Type[]{};
            method = type.GetMethod("RefreshAllTiles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RefreshAllTiles_35);
            args = new Type[]{typeof(UnityEngine.Tilemaps.TileBase), typeof(UnityEngine.Tilemaps.TileBase)};
            method = type.GetMethod("SwapTile", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SwapTile_36);
            args = new Type[]{typeof(UnityEngine.Tilemaps.TileBase)};
            method = type.GetMethod("ContainsTile", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ContainsTile_37);
            args = new Type[]{};
            method = type.GetMethod("GetUsedTilesCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetUsedTilesCount_38);
            args = new Type[]{};
            method = type.GetMethod("GetUsedSpritesCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetUsedSpritesCount_39);
            args = new Type[]{typeof(UnityEngine.Tilemaps.TileBase[])};
            method = type.GetMethod("GetUsedTilesNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetUsedTilesNonAlloc_40);
            args = new Type[]{typeof(UnityEngine.Sprite[])};
            method = type.GetMethod("GetUsedSpritesNonAlloc", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetUsedSpritesNonAlloc_41);
            args = new Type[]{typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("GetSprite", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetSprite_42);
            args = new Type[]{typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("GetTransformMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTransformMatrix_43);
            args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("SetTransformMatrix", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTransformMatrix_44);
            args = new Type[]{typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("GetColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetColor_45);
            args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Color)};
            method = type.GetMethod("SetColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetColor_46);
            args = new Type[]{typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("GetTileFlags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTileFlags_47);
            args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Tilemaps.TileFlags)};
            method = type.GetMethod("SetTileFlags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTileFlags_48);
            args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Tilemaps.TileFlags)};
            method = type.GetMethod("AddTileFlags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddTileFlags_49);
            args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Tilemaps.TileFlags)};
            method = type.GetMethod("RemoveTileFlags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveTileFlags_50);
            args = new Type[]{typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("GetInstantiatedObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetInstantiatedObject_51);
            args = new Type[]{typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("GetObjectToInstantiate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetObjectToInstantiate_52);
            args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Tilemaps.Tile.ColliderType)};
            method = type.GetMethod("SetColliderType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetColliderType_53);
            args = new Type[]{typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("GetColliderType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetColliderType_54);
            args = new Type[]{typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("GetAnimationFrameCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAnimationFrameCount_55);
            args = new Type[]{typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("GetAnimationFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAnimationFrame_56);
            args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(System.Int32)};
            method = type.GetMethod("SetAnimationFrame", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAnimationFrame_57);
            args = new Type[]{typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("GetAnimationTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAnimationTime_58);
            args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(System.Single)};
            method = type.GetMethod("SetAnimationTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAnimationTime_59);
            args = new Type[]{typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("GetTileAnimationFlags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetTileAnimationFlags_60);
            args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Tilemaps.TileAnimationFlags)};
            method = type.GetMethod("SetTileAnimationFlags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetTileAnimationFlags_61);
            args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Tilemaps.TileAnimationFlags)};
            method = type.GetMethod("AddTileAnimationFlags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddTileAnimationFlags_62);
            args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Tilemaps.TileAnimationFlags)};
            method = type.GetMethod("RemoveTileAnimationFlags", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveTileAnimationFlags_63);
            args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Tilemaps.TileBase)};
            method = type.GetMethod("FloodFill", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FloodFill_64);
            args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Tilemaps.TileBase), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("BoxFill", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, BoxFill_65);
            args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("InsertCells", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InsertCells_66);
            args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("InsertCells", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InsertCells_67);
            args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("DeleteCells", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DeleteCells_68);
            args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32)};
            method = type.GetMethod("DeleteCells", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DeleteCells_69);
            args = new Type[]{};
            method = type.GetMethod("ClearAllTiles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ClearAllTiles_70);
            args = new Type[]{};
            method = type.GetMethod("ResizeBounds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResizeBounds_71);
            args = new Type[]{};
            method = type.GetMethod("CompressBounds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CompressBounds_72);
            // args = new Type[]{};
            // method = type.GetMethod("get_editorPreviewOrigin", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_editorPreviewOrigin_73);
            // args = new Type[]{};
            // method = type.GetMethod("get_editorPreviewSize", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, get_editorPreviewSize_74);
            // args = new Type[]{typeof(UnityEngine.Vector3Int)};
            // method = methods.Where(t => t.Name.Equals("GetEditorPreviewTile") && t.CheckMethodParams(args)).Single();
            // app.RegisterCLRMethodRedirection(method, GetEditorPreviewTile_75);
            // args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Tilemaps.TileBase)};
            // method = type.GetMethod("SetEditorPreviewTile", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, SetEditorPreviewTile_76);
            // args = new Type[]{typeof(UnityEngine.Vector3Int)};
            // method = type.GetMethod("HasEditorPreviewTile", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, HasEditorPreviewTile_77);
            // args = new Type[]{typeof(UnityEngine.Vector3Int)};
            // method = type.GetMethod("GetEditorPreviewSprite", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, GetEditorPreviewSprite_78);
            // args = new Type[]{typeof(UnityEngine.Vector3Int)};
            // method = type.GetMethod("GetEditorPreviewTransformMatrix", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, GetEditorPreviewTransformMatrix_79);
            // args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Matrix4x4)};
            // method = type.GetMethod("SetEditorPreviewTransformMatrix", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, SetEditorPreviewTransformMatrix_80);
            // args = new Type[]{typeof(UnityEngine.Vector3Int)};
            // method = type.GetMethod("GetEditorPreviewColor", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, GetEditorPreviewColor_81);
            // args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Color)};
            // method = type.GetMethod("SetEditorPreviewColor", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, SetEditorPreviewColor_82);
            // args = new Type[]{typeof(UnityEngine.Vector3Int)};
            // method = type.GetMethod("GetEditorPreviewTileFlags", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, GetEditorPreviewTileFlags_83);
            // args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Tilemaps.TileBase)};
            // method = type.GetMethod("EditorPreviewFloodFill", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, EditorPreviewFloodFill_84);
            // args = new Type[]{typeof(UnityEngine.Vector3Int), typeof(UnityEngine.Object), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32), typeof(System.Int32)};
            // method = type.GetMethod("EditorPreviewBoxFill", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, EditorPreviewBoxFill_85);
            // args = new Type[]{};
            // method = type.GetMethod("ClearAllEditorPreviewTiles", flag, null, args, null);
            // app.RegisterCLRMethodRedirection(method, ClearAllEditorPreviewTiles_86);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.Tilemaps.Tilemap());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.Tilemaps.Tilemap[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* add_tilemapTileChanged_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.Tilemaps.Tilemap, UnityEngine.Tilemaps.Tilemap.SyncTile[]> @value = (System.Action<UnityEngine.Tilemaps.Tilemap, UnityEngine.Tilemaps.Tilemap.SyncTile[]>)typeof(System.Action<UnityEngine.Tilemaps.Tilemap, UnityEngine.Tilemaps.Tilemap.SyncTile[]>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Tilemaps.Tilemap.tilemapTileChanged += value;

            return __ret;
        }

        static StackObject* remove_tilemapTileChanged_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.Tilemaps.Tilemap, UnityEngine.Tilemaps.Tilemap.SyncTile[]> @value = (System.Action<UnityEngine.Tilemaps.Tilemap, UnityEngine.Tilemaps.Tilemap.SyncTile[]>)typeof(System.Action<UnityEngine.Tilemaps.Tilemap, UnityEngine.Tilemaps.Tilemap.SyncTile[]>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Tilemaps.Tilemap.tilemapTileChanged -= value;

            return __ret;
        }

        static StackObject* add_tilemapPositionsChanged_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.Tilemaps.Tilemap, Unity.Collections.NativeArray<UnityEngine.Vector3Int>> @value = (System.Action<UnityEngine.Tilemaps.Tilemap, Unity.Collections.NativeArray<UnityEngine.Vector3Int>>)typeof(System.Action<UnityEngine.Tilemaps.Tilemap, Unity.Collections.NativeArray<UnityEngine.Vector3Int>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Tilemaps.Tilemap.tilemapPositionsChanged += value;

            return __ret;
        }

        static StackObject* remove_tilemapPositionsChanged_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.Tilemaps.Tilemap, Unity.Collections.NativeArray<UnityEngine.Vector3Int>> @value = (System.Action<UnityEngine.Tilemaps.Tilemap, Unity.Collections.NativeArray<UnityEngine.Vector3Int>>)typeof(System.Action<UnityEngine.Tilemaps.Tilemap, Unity.Collections.NativeArray<UnityEngine.Vector3Int>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.Tilemaps.Tilemap.tilemapPositionsChanged -= value;

            return __ret;
        }

        static StackObject* get_layoutGrid_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.layoutGrid;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetCellCenterLocal_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetCellCenterLocal(@position);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetCellCenterWorld_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetCellCenterWorld(@position);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_cellBounds_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.cellBounds;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_localBounds_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.localBounds;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_animationFrameRate_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.animationFrameRate;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_animationFrameRate_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.animationFrameRate = value;

            return __ret;
        }

        static StackObject* get_color_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.color;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_color_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @value = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.color = value;

            return __ret;
        }

        static StackObject* get_origin_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.origin;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_origin_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @value = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.origin = value;

            return __ret;
        }

        static StackObject* get_size_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.size;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_size_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @value = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.size = value;

            return __ret;
        }

        static StackObject* get_tileAnchor_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.tileAnchor;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_tileAnchor_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.tileAnchor = value;

            return __ret;
        }

        static StackObject* get_orientation_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.orientation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_orientation_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tilemap.Orientation @value = (UnityEngine.Tilemaps.Tilemap.Orientation)typeof(UnityEngine.Tilemaps.Tilemap.Orientation).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.orientation = value;

            return __ret;
        }

        static StackObject* get_orientationMatrix_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.orientationMatrix;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_orientationMatrix_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 @value = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.orientationMatrix = value;

            return __ret;
        }

        static StackObject* GetTile_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetTile(@position);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetTilesBlock_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.BoundsInt @bounds = (UnityEngine.BoundsInt)typeof(UnityEngine.BoundsInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetTilesBlock(@bounds);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetTilesBlockNonAlloc_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TileBase[] @tiles = (UnityEngine.Tilemaps.TileBase[])typeof(UnityEngine.Tilemaps.TileBase[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.BoundsInt @bounds = (UnityEngine.BoundsInt)typeof(UnityEngine.BoundsInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetTilesBlockNonAlloc(@bounds, @tiles);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetTilesRangeCount_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @endPosition = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3Int @startPosition = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetTilesRangeCount(@startPosition, @endPosition);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetTilesRangeNonAlloc_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TileBase[] @tiles = (UnityEngine.Tilemaps.TileBase[])typeof(UnityEngine.Tilemaps.TileBase[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3Int[] @positions = (UnityEngine.Vector3Int[])typeof(UnityEngine.Vector3Int[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector3Int @endPosition = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector3Int @startPosition = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetTilesRangeNonAlloc(@startPosition, @endPosition, @positions, @tiles);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetTile_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TileBase @tile = (UnityEngine.Tilemaps.TileBase)typeof(UnityEngine.Tilemaps.TileBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTile(@position, @tile);

            return __ret;
        }

        static StackObject* SetTiles_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TileBase[] @tileArray = (UnityEngine.Tilemaps.TileBase[])typeof(UnityEngine.Tilemaps.TileBase[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3Int[] @positionArray = (UnityEngine.Vector3Int[])typeof(UnityEngine.Vector3Int[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTiles(@positionArray, @tileArray);

            return __ret;
        }

        static StackObject* SetTilesBlock_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TileBase[] @tileArray = (UnityEngine.Tilemaps.TileBase[])typeof(UnityEngine.Tilemaps.TileBase[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.BoundsInt @position = (UnityEngine.BoundsInt)typeof(UnityEngine.BoundsInt).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTilesBlock(@position, @tileArray);

            return __ret;
        }

        static StackObject* SetTile_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @ignoreLockFlags = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.TileChangeData @tileChangeData = (UnityEngine.Tilemaps.TileChangeData)typeof(UnityEngine.Tilemaps.TileChangeData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTile(@tileChangeData, @ignoreLockFlags);

            return __ret;
        }

        static StackObject* SetTiles_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @ignoreLockFlags = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.TileChangeData[] @tileChangeDataArray = (UnityEngine.Tilemaps.TileChangeData[])typeof(UnityEngine.Tilemaps.TileChangeData[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTiles(@tileChangeDataArray, @ignoreLockFlags);

            return __ret;
        }

        static StackObject* HasTile_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.HasTile(@position);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RefreshTile_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RefreshTile(@position);

            return __ret;
        }

        static StackObject* RefreshAllTiles_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RefreshAllTiles();

            return __ret;
        }

        static StackObject* SwapTile_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TileBase @newTile = (UnityEngine.Tilemaps.TileBase)typeof(UnityEngine.Tilemaps.TileBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.TileBase @changeTile = (UnityEngine.Tilemaps.TileBase)typeof(UnityEngine.Tilemaps.TileBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SwapTile(@changeTile, @newTile);

            return __ret;
        }

        static StackObject* ContainsTile_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TileBase @tileAsset = (UnityEngine.Tilemaps.TileBase)typeof(UnityEngine.Tilemaps.TileBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ContainsTile(@tileAsset);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetUsedTilesCount_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetUsedTilesCount();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetUsedSpritesCount_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetUsedSpritesCount();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetUsedTilesNonAlloc_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TileBase[] @usedTiles = (UnityEngine.Tilemaps.TileBase[])typeof(UnityEngine.Tilemaps.TileBase[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetUsedTilesNonAlloc(@usedTiles);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetUsedSpritesNonAlloc_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Sprite[] @usedSprites = (UnityEngine.Sprite[])typeof(UnityEngine.Sprite[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetUsedSpritesNonAlloc(@usedSprites);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetSprite_42(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetSprite(@position);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetTransformMatrix_43(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetTransformMatrix(@position);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetTransformMatrix_44(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 @transform = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTransformMatrix(@position, @transform);

            return __ret;
        }

        static StackObject* GetColor_45(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetColor(@position);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetColor_46(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @color = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetColor(@position, @color);

            return __ret;
        }

        static StackObject* GetTileFlags_47(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetTileFlags(@position);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetTileFlags_48(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TileFlags @flags = (UnityEngine.Tilemaps.TileFlags)typeof(UnityEngine.Tilemaps.TileFlags).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTileFlags(@position, @flags);

            return __ret;
        }

        static StackObject* AddTileFlags_49(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TileFlags @flags = (UnityEngine.Tilemaps.TileFlags)typeof(UnityEngine.Tilemaps.TileFlags).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddTileFlags(@position, @flags);

            return __ret;
        }

        static StackObject* RemoveTileFlags_50(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TileFlags @flags = (UnityEngine.Tilemaps.TileFlags)typeof(UnityEngine.Tilemaps.TileFlags).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveTileFlags(@position, @flags);

            return __ret;
        }

        static StackObject* GetInstantiatedObject_51(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetInstantiatedObject(@position);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetObjectToInstantiate_52(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetObjectToInstantiate(@position);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetColliderType_53(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tile.ColliderType @colliderType = (UnityEngine.Tilemaps.Tile.ColliderType)typeof(UnityEngine.Tilemaps.Tile.ColliderType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetColliderType(@position, @colliderType);

            return __ret;
        }

        static StackObject* GetColliderType_54(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetColliderType(@position);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetAnimationFrameCount_55(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAnimationFrameCount(@position);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* GetAnimationFrame_56(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAnimationFrame(@position);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetAnimationFrame_57(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @frame = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetAnimationFrame(@position, @frame);

            return __ret;
        }

        static StackObject* GetAnimationTime_58(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAnimationTime(@position);

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* SetAnimationTime_59(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @time = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetAnimationTime(@position, @time);

            return __ret;
        }

        static StackObject* GetTileAnimationFlags_60(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetTileAnimationFlags(@position);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetTileAnimationFlags_61(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TileAnimationFlags @flags = (UnityEngine.Tilemaps.TileAnimationFlags)typeof(UnityEngine.Tilemaps.TileAnimationFlags).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetTileAnimationFlags(@position, @flags);

            return __ret;
        }

        static StackObject* AddTileAnimationFlags_62(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TileAnimationFlags @flags = (UnityEngine.Tilemaps.TileAnimationFlags)typeof(UnityEngine.Tilemaps.TileAnimationFlags).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AddTileAnimationFlags(@position, @flags);

            return __ret;
        }

        static StackObject* RemoveTileAnimationFlags_63(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TileAnimationFlags @flags = (UnityEngine.Tilemaps.TileAnimationFlags)typeof(UnityEngine.Tilemaps.TileAnimationFlags).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveTileAnimationFlags(@position, @flags);

            return __ret;
        }

        static StackObject* FloodFill_64(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.TileBase @tile = (UnityEngine.Tilemaps.TileBase)typeof(UnityEngine.Tilemaps.TileBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.FloodFill(@position, @tile);

            return __ret;
        }

        static StackObject* BoxFill_65(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 7);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @endY = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @endX = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @startY = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Int32 @startX = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Tilemaps.TileBase @tile = (UnityEngine.Tilemaps.TileBase)typeof(UnityEngine.Tilemaps.TileBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.BoxFill(@position, @tile, @startX, @startY, @endX, @endY);

            return __ret;
        }

        static StackObject* InsertCells_66(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @insertCells = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.InsertCells(@position, @insertCells);

            return __ret;
        }

        static StackObject* InsertCells_67(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @numLayers = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @numRows = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @numColumns = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.InsertCells(@position, @numColumns, @numRows, @numLayers);

            return __ret;
        }

        static StackObject* DeleteCells_68(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @deleteCells = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DeleteCells(@position, @deleteCells);

            return __ret;
        }

        static StackObject* DeleteCells_69(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @numLayers = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @numRows = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @numColumns = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DeleteCells(@position, @numColumns, @numRows, @numLayers);

            return __ret;
        }

        static StackObject* ClearAllTiles_70(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ClearAllTiles();

            return __ret;
        }

        static StackObject* ResizeBounds_71(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ResizeBounds();

            return __ret;
        }

        static StackObject* CompressBounds_72(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CompressBounds();

            return __ret;
        }

        // static StackObject* get_editorPreviewOrigin_73(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.editorPreviewOrigin;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }

        // static StackObject* get_editorPreviewSize_74(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.editorPreviewSize;
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }

        // static StackObject* GetEditorPreviewTile_75(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.GetEditorPreviewTile(@position);
        //
        //     object obj_result_of_this_method = result_of_this_method;
        //     if(obj_result_of_this_method is CrossBindingAdaptorType)
        //     {    
        //         return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
        //     }
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }

        // static StackObject* SetEditorPreviewTile_76(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 3);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Tilemaps.TileBase @tile = (UnityEngine.Tilemaps.TileBase)typeof(UnityEngine.Tilemaps.TileBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
        //     UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.SetEditorPreviewTile(@position, @tile);
        //
        //     return __ret;
        // }

        // static StackObject* HasEditorPreviewTile_77(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.HasEditorPreviewTile(@position);
        //
        //     __ret->ObjectType = ObjectTypes.Integer;
        //     __ret->Value = result_of_this_method ? 1 : 0;
        //     return __ret + 1;
        // }

        // static StackObject* GetEditorPreviewSprite_78(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.GetEditorPreviewSprite(@position);
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }

        // static StackObject* GetEditorPreviewTransformMatrix_79(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.GetEditorPreviewTransformMatrix(@position);
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }

        // static StackObject* SetEditorPreviewTransformMatrix_80(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 3);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Matrix4x4 @transform = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
        //     UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.SetEditorPreviewTransformMatrix(@position, @transform);
        //
        //     return __ret;
        // }

        // static StackObject* GetEditorPreviewColor_81(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.GetEditorPreviewColor(@position);
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }

        // static StackObject* SetEditorPreviewColor_82(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 3);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Color @color = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
        //     UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.SetEditorPreviewColor(@position, @color);
        //
        //     return __ret;
        // }

        // static StackObject* GetEditorPreviewTileFlags_83(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 2);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     var result_of_this_method = instance_of_this_method.GetEditorPreviewTileFlags(@position);
        //
        //     return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        // }

        // static StackObject* EditorPreviewFloodFill_84(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 3);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Tilemaps.TileBase @tile = (UnityEngine.Tilemaps.TileBase)typeof(UnityEngine.Tilemaps.TileBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
        //     UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.EditorPreviewFloodFill(@position, @tile);
        //
        //     return __ret;
        // }

        // static StackObject* EditorPreviewBoxFill_85(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 7);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     System.Int32 @endY = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
        //     System.Int32 @endX = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
        //     System.Int32 @startY = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
        //     System.Int32 @startX = ptr_of_this_method->Value;
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
        //     UnityEngine.Object @tile = (UnityEngine.Object)typeof(UnityEngine.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
        //     UnityEngine.Vector3Int @position = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
        //     __intp.Free(ptr_of_this_method);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
        //     UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.EditorPreviewBoxFill(@position, @tile, @startX, @startY, @endX, @endY);
        //
        //     return __ret;
        // }

        // static StackObject* ClearAllEditorPreviewTiles_86(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        // {
        //     UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
        //     StackObject* ptr_of_this_method;
        //     StackObject* __ret = ILIntepreter.Minus(__esp, 1);
        //
        //     ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
        //     UnityEngine.Tilemaps.Tilemap instance_of_this_method = (UnityEngine.Tilemaps.Tilemap)typeof(UnityEngine.Tilemaps.Tilemap).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
        //     __intp.Free(ptr_of_this_method);
        //
        //     instance_of_this_method.ClearAllEditorPreviewTiles();
        //
        //     return __ret;
        // }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.Tilemaps.Tilemap();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

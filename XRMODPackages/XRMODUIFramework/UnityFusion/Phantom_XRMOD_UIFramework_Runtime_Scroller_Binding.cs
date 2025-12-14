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
    unsafe class Phantom_XRMOD_UIFramework_Runtime_Scroller_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller.HeightItem)};
            method = type.GetMethod("add_OnHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnHeight_0);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller.HeightItem)};
            method = type.GetMethod("remove_OnHeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnHeight_1);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller.HeightItem)};
            method = type.GetMethod("add_OnWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnWidth_2);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller.HeightItem)};
            method = type.GetMethod("remove_OnWidth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnWidth_3);
            args = new Type[]{};
            method = type.GetMethod("get_IsInited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsInited_4);
            args = new Type[]{};
            method = type.GetMethod("get_ViewsCount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ViewsCount_5);
            args = new Type[]{};
            method = type.GetMethod("get_NormalizedPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_NormalizedPosition_6);
            args = new Type[]{typeof(UnityEngine.EventSystems.PointerEventData)};
            method = type.GetMethod("OnDrop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnDrop_7);
            args = new Type[]{typeof(System.Int32), typeof(System.Boolean)};
            method = type.GetMethod("InitData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InitData_8);
            args = new Type[]{typeof(System.Int32), typeof(System.Int32), typeof(Phantom.XRMOD.UIFramework.Runtime.ScrollerDirection)};
            method = type.GetMethod("ApplyDataTo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ApplyDataTo_9);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("ScrollTo", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ScrollTo_10);
            args = new Type[]{};
            method = type.GetMethod("RecycleAll", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RecycleAll_11);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("Recycle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Recycle_12);
            args = new Type[]{};
            method = type.GetMethod("UpdateVisible", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UpdateVisible_13);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("RefreshViews", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RefreshViews_14);
            args = new Type[]{};
            method = type.GetMethod("GetAllViews", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAllViews_15);

            field = type.GetField("OnFill", flag);
            app.RegisterCLRFieldGetter(field, get_OnFill_0);
            app.RegisterCLRFieldSetter(field, set_OnFill_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnFill_0, AssignFromStack_OnFill_0);
            field = type.GetField("OnPull", flag);
            app.RegisterCLRFieldGetter(field, get_OnPull_1);
            app.RegisterCLRFieldSetter(field, set_OnPull_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnPull_1, AssignFromStack_OnPull_1);
            field = type.GetField("Prefab", flag);
            app.RegisterCLRFieldGetter(field, get_Prefab_2);
            app.RegisterCLRFieldSetter(field, set_Prefab_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Prefab_2, AssignFromStack_Prefab_2);
            field = type.GetField("TopPadding", flag);
            app.RegisterCLRFieldGetter(field, get_TopPadding_3);
            app.RegisterCLRFieldSetter(field, set_TopPadding_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_TopPadding_3, AssignFromStack_TopPadding_3);
            field = type.GetField("BottomPadding", flag);
            app.RegisterCLRFieldGetter(field, get_BottomPadding_4);
            app.RegisterCLRFieldSetter(field, set_BottomPadding_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_BottomPadding_4, AssignFromStack_BottomPadding_4);
            field = type.GetField("LeftPadding", flag);
            app.RegisterCLRFieldGetter(field, get_LeftPadding_5);
            app.RegisterCLRFieldSetter(field, set_LeftPadding_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_LeftPadding_5, AssignFromStack_LeftPadding_5);
            field = type.GetField("RightPadding", flag);
            app.RegisterCLRFieldGetter(field, get_RightPadding_6);
            app.RegisterCLRFieldSetter(field, set_RightPadding_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_RightPadding_6, AssignFromStack_RightPadding_6);
            field = type.GetField("ItemSpacing", flag);
            app.RegisterCLRFieldGetter(field, get_ItemSpacing_7);
            app.RegisterCLRFieldSetter(field, set_ItemSpacing_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_ItemSpacing_7, AssignFromStack_ItemSpacing_7);
            field = type.GetField("LabelsFont", flag);
            app.RegisterCLRFieldGetter(field, get_LabelsFont_8);
            app.RegisterCLRFieldSetter(field, set_LabelsFont_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_LabelsFont_8, AssignFromStack_LabelsFont_8);
            field = type.GetField("FontSize", flag);
            app.RegisterCLRFieldGetter(field, get_FontSize_9);
            app.RegisterCLRFieldSetter(field, set_FontSize_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_FontSize_9, AssignFromStack_FontSize_9);
            field = type.GetField("FontColor", flag);
            app.RegisterCLRFieldGetter(field, get_FontColor_10);
            app.RegisterCLRFieldSetter(field, set_FontColor_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_FontColor_10, AssignFromStack_FontColor_10);
            field = type.GetField("TopPullLabel", flag);
            app.RegisterCLRFieldGetter(field, get_TopPullLabel_11);
            app.RegisterCLRFieldSetter(field, set_TopPullLabel_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_TopPullLabel_11, AssignFromStack_TopPullLabel_11);
            field = type.GetField("TopReleaseLabel", flag);
            app.RegisterCLRFieldGetter(field, get_TopReleaseLabel_12);
            app.RegisterCLRFieldSetter(field, set_TopReleaseLabel_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_TopReleaseLabel_12, AssignFromStack_TopReleaseLabel_12);
            field = type.GetField("BottomPullLabel", flag);
            app.RegisterCLRFieldGetter(field, get_BottomPullLabel_13);
            app.RegisterCLRFieldSetter(field, set_BottomPullLabel_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_BottomPullLabel_13, AssignFromStack_BottomPullLabel_13);
            field = type.GetField("BottomReleaseLabel", flag);
            app.RegisterCLRFieldGetter(field, get_BottomReleaseLabel_14);
            app.RegisterCLRFieldSetter(field, set_BottomReleaseLabel_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_BottomReleaseLabel_14, AssignFromStack_BottomReleaseLabel_14);
            field = type.GetField("LeftPullLabel", flag);
            app.RegisterCLRFieldGetter(field, get_LeftPullLabel_15);
            app.RegisterCLRFieldSetter(field, set_LeftPullLabel_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_LeftPullLabel_15, AssignFromStack_LeftPullLabel_15);
            field = type.GetField("LeftReleaseLabel", flag);
            app.RegisterCLRFieldGetter(field, get_LeftReleaseLabel_16);
            app.RegisterCLRFieldSetter(field, set_LeftReleaseLabel_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_LeftReleaseLabel_16, AssignFromStack_LeftReleaseLabel_16);
            field = type.GetField("RightPullLabel", flag);
            app.RegisterCLRFieldGetter(field, get_RightPullLabel_17);
            app.RegisterCLRFieldSetter(field, set_RightPullLabel_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_RightPullLabel_17, AssignFromStack_RightPullLabel_17);
            field = type.GetField("RightReleaseLabel", flag);
            app.RegisterCLRFieldGetter(field, get_RightReleaseLabel_18);
            app.RegisterCLRFieldSetter(field, set_RightReleaseLabel_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_RightReleaseLabel_18, AssignFromStack_RightReleaseLabel_18);
            field = type.GetField("IsPullTop", flag);
            app.RegisterCLRFieldGetter(field, get_IsPullTop_19);
            app.RegisterCLRFieldSetter(field, set_IsPullTop_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsPullTop_19, AssignFromStack_IsPullTop_19);
            field = type.GetField("IsPullBottom", flag);
            app.RegisterCLRFieldGetter(field, get_IsPullBottom_20);
            app.RegisterCLRFieldSetter(field, set_IsPullBottom_20);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsPullBottom_20, AssignFromStack_IsPullBottom_20);
            field = type.GetField("IsPullLeft", flag);
            app.RegisterCLRFieldGetter(field, get_IsPullLeft_21);
            app.RegisterCLRFieldSetter(field, set_IsPullLeft_21);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsPullLeft_21, AssignFromStack_IsPullLeft_21);
            field = type.GetField("IsPullRight", flag);
            app.RegisterCLRFieldGetter(field, get_IsPullRight_22);
            app.RegisterCLRFieldSetter(field, set_IsPullRight_22);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsPullRight_22, AssignFromStack_IsPullRight_22);
            field = type.GetField("PullValue", flag);
            app.RegisterCLRFieldGetter(field, get_PullValue_23);
            app.RegisterCLRFieldSetter(field, set_PullValue_23);
            app.RegisterCLRFieldBinding(field, CopyToStack_PullValue_23, AssignFromStack_PullValue_23);
            field = type.GetField("LabelOffset", flag);
            app.RegisterCLRFieldGetter(field, get_LabelOffset_24);
            app.RegisterCLRFieldSetter(field, set_LabelOffset_24);
            app.RegisterCLRFieldBinding(field, CopyToStack_LabelOffset_24, AssignFromStack_LabelOffset_24);
            field = type.GetField("ParentContainer", flag);
            app.RegisterCLRFieldGetter(field, get_ParentContainer_25);
            app.RegisterCLRFieldSetter(field, set_ParentContainer_25);
            app.RegisterCLRFieldBinding(field, CopyToStack_ParentContainer_25, AssignFromStack_ParentContainer_25);
            field = type.GetField("AddonViewsCount", flag);
            app.RegisterCLRFieldGetter(field, get_AddonViewsCount_26);
            app.RegisterCLRFieldSetter(field, set_AddonViewsCount_26);
            app.RegisterCLRFieldBinding(field, CopyToStack_AddonViewsCount_26, AssignFromStack_AddonViewsCount_26);
            field = type.GetField("TopLabel", flag);
            app.RegisterCLRFieldGetter(field, get_TopLabel_27);
            app.RegisterCLRFieldSetter(field, set_TopLabel_27);
            app.RegisterCLRFieldBinding(field, CopyToStack_TopLabel_27, AssignFromStack_TopLabel_27);
            field = type.GetField("BottomLabel", flag);
            app.RegisterCLRFieldGetter(field, get_BottomLabel_28);
            app.RegisterCLRFieldSetter(field, set_BottomLabel_28);
            app.RegisterCLRFieldBinding(field, CopyToStack_BottomLabel_28, AssignFromStack_BottomLabel_28);
            field = type.GetField("LeftLabel", flag);
            app.RegisterCLRFieldGetter(field, get_LeftLabel_29);
            app.RegisterCLRFieldSetter(field, set_LeftLabel_29);
            app.RegisterCLRFieldBinding(field, CopyToStack_LeftLabel_29, AssignFromStack_LeftLabel_29);
            field = type.GetField("RightLabel", flag);
            app.RegisterCLRFieldGetter(field, get_RightLabel_30);
            app.RegisterCLRFieldSetter(field, set_RightLabel_30);
            app.RegisterCLRFieldBinding(field, CopyToStack_RightLabel_30, AssignFromStack_RightLabel_30);
            field = type.GetField("Type", flag);
            app.RegisterCLRFieldGetter(field, get_Type_31);
            app.RegisterCLRFieldSetter(field, set_Type_31);
            app.RegisterCLRFieldBinding(field, CopyToStack_Type_31, AssignFromStack_Type_31);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.UIFramework.Runtime.Scroller());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.UIFramework.Runtime.Scroller[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* add_OnHeight_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.Scroller.HeightItem @value = (Phantom.XRMOD.UIFramework.Runtime.Scroller.HeightItem)typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller.HeightItem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.Scroller instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.Scroller)typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnHeight += value;

            return __ret;
        }

        static StackObject* remove_OnHeight_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.Scroller.HeightItem @value = (Phantom.XRMOD.UIFramework.Runtime.Scroller.HeightItem)typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller.HeightItem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.Scroller instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.Scroller)typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnHeight -= value;

            return __ret;
        }

        static StackObject* add_OnWidth_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.Scroller.HeightItem @value = (Phantom.XRMOD.UIFramework.Runtime.Scroller.HeightItem)typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller.HeightItem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.Scroller instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.Scroller)typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnWidth += value;

            return __ret;
        }

        static StackObject* remove_OnWidth_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.Scroller.HeightItem @value = (Phantom.XRMOD.UIFramework.Runtime.Scroller.HeightItem)typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller.HeightItem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.Scroller instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.Scroller)typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnWidth -= value;

            return __ret;
        }

        static StackObject* get_IsInited_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.Scroller instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.Scroller)typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsInited;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_ViewsCount_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.Scroller instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.Scroller)typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ViewsCount;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_NormalizedPosition_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.Scroller instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.Scroller)typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.NormalizedPosition;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* OnDrop_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.EventSystems.PointerEventData @eventData = (UnityEngine.EventSystems.PointerEventData)typeof(UnityEngine.EventSystems.PointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.Scroller instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.Scroller)typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnDrop(@eventData);

            return __ret;
        }

        static StackObject* InitData_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @isOtherSide = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @count = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.UIFramework.Runtime.Scroller instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.Scroller)typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.InitData(@count, @isOtherSide);

            return __ret;
        }

        static StackObject* ApplyDataTo_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.ScrollerDirection @direction = (Phantom.XRMOD.UIFramework.Runtime.ScrollerDirection)typeof(Phantom.XRMOD.UIFramework.Runtime.ScrollerDirection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @newCount = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Int32 @count = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.UIFramework.Runtime.Scroller instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.Scroller)typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ApplyDataTo(@count, @newCount, @direction);

            return __ret;
        }

        static StackObject* ScrollTo_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @index = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.Scroller instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.Scroller)typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ScrollTo(@index);

            return __ret;
        }

        static StackObject* RecycleAll_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.Scroller instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.Scroller)typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RecycleAll();

            return __ret;
        }

        static StackObject* Recycle_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @index = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.Scroller instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.Scroller)typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Recycle(@index);

            return __ret;
        }

        static StackObject* UpdateVisible_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.Scroller instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.Scroller)typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UpdateVisible();

            return __ret;
        }

        static StackObject* RefreshViews_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @count = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.Scroller instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.Scroller)typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RefreshViews(@count);

            return __ret;
        }

        static StackObject* GetAllViews_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.Scroller instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.Scroller)typeof(Phantom.XRMOD.UIFramework.Runtime.Scroller).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAllViews();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object get_OnFill_0(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).OnFill;
        }

        static StackObject* CopyToStack_OnFill_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).OnFill;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnFill_0(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).OnFill = (System.Action<System.Int32, UnityEngine.GameObject>)v;
        }

        static StackObject* AssignFromStack_OnFill_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<System.Int32, UnityEngine.GameObject> @OnFill = (System.Action<System.Int32, UnityEngine.GameObject>)typeof(System.Action<System.Int32, UnityEngine.GameObject>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).OnFill = @OnFill;
            return ptr_of_this_method;
        }

        static object get_OnPull_1(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).OnPull;
        }

        static StackObject* CopyToStack_OnPull_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).OnPull;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnPull_1(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).OnPull = (System.Action<Phantom.XRMOD.UIFramework.Runtime.ScrollerDirection>)v;
        }

        static StackObject* AssignFromStack_OnPull_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action<Phantom.XRMOD.UIFramework.Runtime.ScrollerDirection> @OnPull = (System.Action<Phantom.XRMOD.UIFramework.Runtime.ScrollerDirection>)typeof(System.Action<Phantom.XRMOD.UIFramework.Runtime.ScrollerDirection>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).OnPull = @OnPull;
            return ptr_of_this_method;
        }

        static object get_Prefab_2(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).Prefab;
        }

        static StackObject* CopyToStack_Prefab_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).Prefab;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Prefab_2(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).Prefab = (UnityEngine.GameObject)v;
        }

        static StackObject* AssignFromStack_Prefab_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GameObject @Prefab = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).Prefab = @Prefab;
            return ptr_of_this_method;
        }

        static object get_TopPadding_3(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).TopPadding;
        }

        static StackObject* CopyToStack_TopPadding_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).TopPadding;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_TopPadding_3(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).TopPadding = (System.Int32)v;
        }

        static StackObject* AssignFromStack_TopPadding_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @TopPadding = ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).TopPadding = @TopPadding;
            return ptr_of_this_method;
        }

        static object get_BottomPadding_4(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).BottomPadding;
        }

        static StackObject* CopyToStack_BottomPadding_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).BottomPadding;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_BottomPadding_4(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).BottomPadding = (System.Int32)v;
        }

        static StackObject* AssignFromStack_BottomPadding_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @BottomPadding = ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).BottomPadding = @BottomPadding;
            return ptr_of_this_method;
        }

        static object get_LeftPadding_5(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LeftPadding;
        }

        static StackObject* CopyToStack_LeftPadding_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LeftPadding;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_LeftPadding_5(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LeftPadding = (System.Int32)v;
        }

        static StackObject* AssignFromStack_LeftPadding_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @LeftPadding = ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LeftPadding = @LeftPadding;
            return ptr_of_this_method;
        }

        static object get_RightPadding_6(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).RightPadding;
        }

        static StackObject* CopyToStack_RightPadding_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).RightPadding;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_RightPadding_6(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).RightPadding = (System.Int32)v;
        }

        static StackObject* AssignFromStack_RightPadding_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @RightPadding = ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).RightPadding = @RightPadding;
            return ptr_of_this_method;
        }

        static object get_ItemSpacing_7(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).ItemSpacing;
        }

        static StackObject* CopyToStack_ItemSpacing_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).ItemSpacing;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_ItemSpacing_7(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).ItemSpacing = (System.Int32)v;
        }

        static StackObject* AssignFromStack_ItemSpacing_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @ItemSpacing = ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).ItemSpacing = @ItemSpacing;
            return ptr_of_this_method;
        }

        static object get_LabelsFont_8(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LabelsFont;
        }

        static StackObject* CopyToStack_LabelsFont_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LabelsFont;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LabelsFont_8(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LabelsFont = (TMPro.TMP_FontAsset)v;
        }

        static StackObject* AssignFromStack_LabelsFont_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            TMPro.TMP_FontAsset @LabelsFont = (TMPro.TMP_FontAsset)typeof(TMPro.TMP_FontAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LabelsFont = @LabelsFont;
            return ptr_of_this_method;
        }

        static object get_FontSize_9(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).FontSize;
        }

        static StackObject* CopyToStack_FontSize_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).FontSize;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_FontSize_9(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).FontSize = (System.Int32)v;
        }

        static StackObject* AssignFromStack_FontSize_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @FontSize = ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).FontSize = @FontSize;
            return ptr_of_this_method;
        }

        static object get_FontColor_10(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).FontColor;
        }

        static StackObject* CopyToStack_FontColor_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).FontColor;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_FontColor_10(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).FontColor = (UnityEngine.Color)v;
        }

        static StackObject* AssignFromStack_FontColor_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Color @FontColor = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).FontColor = @FontColor;
            return ptr_of_this_method;
        }

        static object get_TopPullLabel_11(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).TopPullLabel;
        }

        static StackObject* CopyToStack_TopPullLabel_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).TopPullLabel;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TopPullLabel_11(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).TopPullLabel = (System.String)v;
        }

        static StackObject* AssignFromStack_TopPullLabel_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @TopPullLabel = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).TopPullLabel = @TopPullLabel;
            return ptr_of_this_method;
        }

        static object get_TopReleaseLabel_12(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).TopReleaseLabel;
        }

        static StackObject* CopyToStack_TopReleaseLabel_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).TopReleaseLabel;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TopReleaseLabel_12(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).TopReleaseLabel = (System.String)v;
        }

        static StackObject* AssignFromStack_TopReleaseLabel_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @TopReleaseLabel = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).TopReleaseLabel = @TopReleaseLabel;
            return ptr_of_this_method;
        }

        static object get_BottomPullLabel_13(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).BottomPullLabel;
        }

        static StackObject* CopyToStack_BottomPullLabel_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).BottomPullLabel;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_BottomPullLabel_13(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).BottomPullLabel = (System.String)v;
        }

        static StackObject* AssignFromStack_BottomPullLabel_13(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @BottomPullLabel = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).BottomPullLabel = @BottomPullLabel;
            return ptr_of_this_method;
        }

        static object get_BottomReleaseLabel_14(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).BottomReleaseLabel;
        }

        static StackObject* CopyToStack_BottomReleaseLabel_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).BottomReleaseLabel;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_BottomReleaseLabel_14(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).BottomReleaseLabel = (System.String)v;
        }

        static StackObject* AssignFromStack_BottomReleaseLabel_14(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @BottomReleaseLabel = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).BottomReleaseLabel = @BottomReleaseLabel;
            return ptr_of_this_method;
        }

        static object get_LeftPullLabel_15(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LeftPullLabel;
        }

        static StackObject* CopyToStack_LeftPullLabel_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LeftPullLabel;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LeftPullLabel_15(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LeftPullLabel = (System.String)v;
        }

        static StackObject* AssignFromStack_LeftPullLabel_15(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @LeftPullLabel = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LeftPullLabel = @LeftPullLabel;
            return ptr_of_this_method;
        }

        static object get_LeftReleaseLabel_16(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LeftReleaseLabel;
        }

        static StackObject* CopyToStack_LeftReleaseLabel_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LeftReleaseLabel;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LeftReleaseLabel_16(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LeftReleaseLabel = (System.String)v;
        }

        static StackObject* AssignFromStack_LeftReleaseLabel_16(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @LeftReleaseLabel = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LeftReleaseLabel = @LeftReleaseLabel;
            return ptr_of_this_method;
        }

        static object get_RightPullLabel_17(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).RightPullLabel;
        }

        static StackObject* CopyToStack_RightPullLabel_17(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).RightPullLabel;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_RightPullLabel_17(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).RightPullLabel = (System.String)v;
        }

        static StackObject* AssignFromStack_RightPullLabel_17(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @RightPullLabel = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).RightPullLabel = @RightPullLabel;
            return ptr_of_this_method;
        }

        static object get_RightReleaseLabel_18(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).RightReleaseLabel;
        }

        static StackObject* CopyToStack_RightReleaseLabel_18(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).RightReleaseLabel;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_RightReleaseLabel_18(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).RightReleaseLabel = (System.String)v;
        }

        static StackObject* AssignFromStack_RightReleaseLabel_18(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @RightReleaseLabel = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).RightReleaseLabel = @RightReleaseLabel;
            return ptr_of_this_method;
        }

        static object get_IsPullTop_19(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).IsPullTop;
        }

        static StackObject* CopyToStack_IsPullTop_19(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).IsPullTop;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsPullTop_19(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).IsPullTop = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsPullTop_19(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsPullTop = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).IsPullTop = @IsPullTop;
            return ptr_of_this_method;
        }

        static object get_IsPullBottom_20(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).IsPullBottom;
        }

        static StackObject* CopyToStack_IsPullBottom_20(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).IsPullBottom;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsPullBottom_20(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).IsPullBottom = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsPullBottom_20(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsPullBottom = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).IsPullBottom = @IsPullBottom;
            return ptr_of_this_method;
        }

        static object get_IsPullLeft_21(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).IsPullLeft;
        }

        static StackObject* CopyToStack_IsPullLeft_21(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).IsPullLeft;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsPullLeft_21(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).IsPullLeft = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsPullLeft_21(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsPullLeft = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).IsPullLeft = @IsPullLeft;
            return ptr_of_this_method;
        }

        static object get_IsPullRight_22(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).IsPullRight;
        }

        static StackObject* CopyToStack_IsPullRight_22(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).IsPullRight;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsPullRight_22(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).IsPullRight = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsPullRight_22(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsPullRight = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).IsPullRight = @IsPullRight;
            return ptr_of_this_method;
        }

        static object get_PullValue_23(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).PullValue;
        }

        static StackObject* CopyToStack_PullValue_23(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).PullValue;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_PullValue_23(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).PullValue = (System.Single)v;
        }

        static StackObject* AssignFromStack_PullValue_23(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @PullValue = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).PullValue = @PullValue;
            return ptr_of_this_method;
        }

        static object get_LabelOffset_24(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LabelOffset;
        }

        static StackObject* CopyToStack_LabelOffset_24(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LabelOffset;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_LabelOffset_24(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LabelOffset = (System.Single)v;
        }

        static StackObject* AssignFromStack_LabelOffset_24(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @LabelOffset = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LabelOffset = @LabelOffset;
            return ptr_of_this_method;
        }

        static object get_ParentContainer_25(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).ParentContainer;
        }

        static StackObject* CopyToStack_ParentContainer_25(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).ParentContainer;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ParentContainer_25(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).ParentContainer = (UnityEngine.RectTransform)v;
        }

        static StackObject* AssignFromStack_ParentContainer_25(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.RectTransform @ParentContainer = (UnityEngine.RectTransform)typeof(UnityEngine.RectTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).ParentContainer = @ParentContainer;
            return ptr_of_this_method;
        }

        static object get_AddonViewsCount_26(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).AddonViewsCount;
        }

        static StackObject* CopyToStack_AddonViewsCount_26(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).AddonViewsCount;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_AddonViewsCount_26(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).AddonViewsCount = (System.Int32)v;
        }

        static StackObject* AssignFromStack_AddonViewsCount_26(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @AddonViewsCount = ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).AddonViewsCount = @AddonViewsCount;
            return ptr_of_this_method;
        }

        static object get_TopLabel_27(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).TopLabel;
        }

        static StackObject* CopyToStack_TopLabel_27(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).TopLabel;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TopLabel_27(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).TopLabel = (TMPro.TextMeshProUGUI)v;
        }

        static StackObject* AssignFromStack_TopLabel_27(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            TMPro.TextMeshProUGUI @TopLabel = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).TopLabel = @TopLabel;
            return ptr_of_this_method;
        }

        static object get_BottomLabel_28(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).BottomLabel;
        }

        static StackObject* CopyToStack_BottomLabel_28(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).BottomLabel;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_BottomLabel_28(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).BottomLabel = (TMPro.TextMeshProUGUI)v;
        }

        static StackObject* AssignFromStack_BottomLabel_28(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            TMPro.TextMeshProUGUI @BottomLabel = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).BottomLabel = @BottomLabel;
            return ptr_of_this_method;
        }

        static object get_LeftLabel_29(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LeftLabel;
        }

        static StackObject* CopyToStack_LeftLabel_29(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LeftLabel;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_LeftLabel_29(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LeftLabel = (TMPro.TextMeshProUGUI)v;
        }

        static StackObject* AssignFromStack_LeftLabel_29(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            TMPro.TextMeshProUGUI @LeftLabel = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).LeftLabel = @LeftLabel;
            return ptr_of_this_method;
        }

        static object get_RightLabel_30(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).RightLabel;
        }

        static StackObject* CopyToStack_RightLabel_30(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).RightLabel;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_RightLabel_30(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).RightLabel = (TMPro.TextMeshProUGUI)v;
        }

        static StackObject* AssignFromStack_RightLabel_30(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            TMPro.TextMeshProUGUI @RightLabel = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).RightLabel = @RightLabel;
            return ptr_of_this_method;
        }

        static object get_Type_31(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).Type;
        }

        static StackObject* CopyToStack_Type_31(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).Type;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Type_31(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).Type = (System.Int32)v;
        }

        static StackObject* AssignFromStack_Type_31(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @Type = ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.Scroller)o).Type = @Type;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.UIFramework.Runtime.Scroller();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

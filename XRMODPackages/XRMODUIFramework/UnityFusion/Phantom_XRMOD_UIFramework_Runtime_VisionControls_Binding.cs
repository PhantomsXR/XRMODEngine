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
    unsafe class Phantom_XRMOD_UIFramework_Runtime_VisionControls_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("CreateTextButton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateTextButton_0);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("CreateTextButtonNoPlatter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateTextButtonNoPlatter_1);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("CreateTextSymbolButton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateTextSymbolButton_2);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("CreateTextSymbolButtonNoPlatter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateTextSymbolButtonNoPlatter_3);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("CreateRoundedRectButton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateRoundedRectButton_4);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources), typeof(System.Single), typeof(System.Single), typeof(System.Single)};
            method = type.GetMethod("CreateRoundedRectButtonNoPlatter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateRoundedRectButtonNoPlatter_5);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources), typeof(System.Single)};
            method = type.GetMethod("CreateSymbolButton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateSymbolButton_6);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources), typeof(System.Single)};
            method = type.GetMethod("CreateSymbolButtonNoPlatter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateSymbolButtonNoPlatter_7);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources), typeof(System.Single)};
            method = type.GetMethod("CreateMiniSlider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateMiniSlider_8);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources), typeof(System.Single)};
            method = type.GetMethod("CreateSmallSlider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateSmallSlider_9);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources), typeof(System.Single)};
            method = type.GetMethod("CreateRegularSlider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateRegularSlider_10);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources), typeof(System.Single)};
            method = type.GetMethod("CreateLargeSlider", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateLargeSlider_11);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateThrobber", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateThrobber_12);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateWindow", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateWindow_13);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateToggle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateToggle_14);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateScrollbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateScrollbar_15);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateDropdown", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateDropdown_16);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateTooltip", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateTooltip_17);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateInputField", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateInputField_18);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateVerticalSeparator", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateVerticalSeparator_19);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateHorizontalSeparator", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateHorizontalSeparator_20);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateToolbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateToolbar_21);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateAlert", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateAlert_22);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateTabbarToggle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateTabbarToggle_23);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateTabbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateTabbar_24);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateWindowWithTabbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateWindowWithTabbar_25);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateProgressBar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateProgressBar_26);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateWindowWithToolbar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateWindowWithToolbar_27);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateSidebar", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateSidebar_28);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateWindowsStacker", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateWindowsStacker_29);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateWindowControls", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateWindowControls_30);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateSegmentedControl", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateSegmentedControl_31);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateCompletedList", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateCompletedList_32);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateListElement", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateListElement_33);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateListElementNoPlatter", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateListElementNoPlatter_34);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateVolume", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateVolume_35);
            args = new Type[]{typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)};
            method = type.GetMethod("CreateWindowResizer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateWindowResizer_36);
            args = new Type[]{typeof(UnityEngine.RectTransform), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2), typeof(UnityEngine.Vector2)};
            method = type.GetMethod("SetupRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetupRect_37);
            args = new Type[]{typeof(UnityEngine.UI.Image), typeof(UnityEngine.Sprite), typeof(UnityEngine.Color), typeof(UnityEngine.Material), typeof(System.Boolean), typeof(UnityEngine.Vector4), typeof(System.Boolean), typeof(UnityEngine.UI.Image.Type), typeof(System.Boolean), typeof(System.Single)};
            method = type.GetMethod("SetupImage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetupImage_38);
            args = new Type[]{typeof(TMPro.TextMeshProUGUI), typeof(System.String), typeof(TMPro.TMP_FontAsset), typeof(System.Single), typeof(UnityEngine.Color), typeof(TMPro.HorizontalAlignmentOptions), typeof(TMPro.VerticalAlignmentOptions), typeof(System.Boolean), typeof(TMPro.TextOverflowModes)};
            method = type.GetMethod("SetupTextMeshProUGUI", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetupTextMeshProUGUI_39);
            args = new Type[]{typeof(UnityEngine.UI.Toggle), typeof(UnityEngine.UI.Selectable.Transition), typeof(UnityEngine.UI.Navigation.Mode), typeof(System.Boolean), typeof(UnityEngine.UI.Image), typeof(UnityEngine.UI.ToggleGroup)};
            method = type.GetMethod("SetupToggle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetupToggle_40);
            args = new Type[]{typeof(UnityEngine.UI.HorizontalOrVerticalLayoutGroup), typeof(UnityEngine.RectOffset), typeof(System.Single), typeof(UnityEngine.TextAnchor), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean), typeof(System.Boolean)};
            method = type.GetMethod("SetupLayoutGroup", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetupLayoutGroup_41);





        }


        static StackObject* CreateTextButton_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @fontSize = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @height = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @width = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateTextButton(@resources, @width, @height, @fontSize);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateTextButtonNoPlatter_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @fontSize = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @height = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @width = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateTextButtonNoPlatter(@resources, @width, @height, @fontSize);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateTextSymbolButton_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @fontSize = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @height = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @width = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateTextSymbolButton(@resources, @width, @height, @fontSize);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateTextSymbolButtonNoPlatter_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @fontSize = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @height = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @width = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateTextSymbolButtonNoPlatter(@resources, @width, @height, @fontSize);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateRoundedRectButton_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @fontSize = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @height = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @width = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateRoundedRectButton(@resources, @width, @height, @fontSize);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateRoundedRectButtonNoPlatter_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @fontSize = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @height = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @width = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateRoundedRectButtonNoPlatter(@resources, @width, @height, @fontSize);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateSymbolButton_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @size = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateSymbolButton(@resources, @size);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateSymbolButtonNoPlatter_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @size = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateSymbolButtonNoPlatter(@resources, @size);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateMiniSlider_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @height = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateMiniSlider(@resources, @height);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateSmallSlider_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @height = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateSmallSlider(@resources, @height);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateRegularSlider_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @height = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateRegularSlider(@resources, @height);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateLargeSlider_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @height = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateLargeSlider(@resources, @height);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateThrobber_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateThrobber(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateWindow_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateWindow(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateToggle_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateToggle(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateScrollbar_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateScrollbar(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateDropdown_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateDropdown(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateTooltip_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateTooltip(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateInputField_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateInputField(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateVerticalSeparator_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateVerticalSeparator(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateHorizontalSeparator_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateHorizontalSeparator(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateToolbar_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateToolbar(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateAlert_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateAlert(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateTabbarToggle_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateTabbarToggle(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateTabbar_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateTabbar(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateWindowWithTabbar_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateWindowWithTabbar(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateProgressBar_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateProgressBar(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateWindowWithToolbar_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateWindowWithToolbar(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateSidebar_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateSidebar(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateWindowsStacker_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateWindowsStacker(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateWindowControls_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateWindowControls(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateSegmentedControl_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateSegmentedControl(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateCompletedList_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateCompletedList(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateListElement_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateListElement(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateListElementNoPlatter_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateListElementNoPlatter(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateVolume_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateVolume(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateWindowResizer_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources @resources = (Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources)typeof(Phantom.XRMOD.UIFramework.Runtime.VisionControls.Resources).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = Phantom.XRMOD.UIFramework.Runtime.VisionControls.CreateWindowResizer(@resources);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetupRect_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @anchoredPosition = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @sizeDelta = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @anchorMax = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.Vector2 @anchorMin = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.RectTransform @rectTransform = (UnityEngine.RectTransform)typeof(UnityEngine.RectTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.UIFramework.Runtime.VisionControls.SetupRect(@rectTransform, @anchorMin, @anchorMax, @sizeDelta, @anchoredPosition);

            return __ret;
        }

        static StackObject* SetupImage_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @pixelsPerUnitMultiplier = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @fillCenter = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.UI.Image.Type @type = (UnityEngine.UI.Image.Type)typeof(UnityEngine.UI.Image.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean @maskable = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Vector4 @raycastPadding = (UnityEngine.Vector4)typeof(UnityEngine.Vector4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Boolean @raycastTarget = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.Material @material = (UnityEngine.Material)typeof(UnityEngine.Material).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            UnityEngine.Color @color = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.Sprite @sprite = (UnityEngine.Sprite)typeof(UnityEngine.Sprite).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.UI.Image @image = (UnityEngine.UI.Image)typeof(UnityEngine.UI.Image).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.UIFramework.Runtime.VisionControls.SetupImage(@image, @sprite, @color, @material, @raycastTarget, @raycastPadding, @maskable, @type, @fillCenter, @pixelsPerUnitMultiplier);

            return __ret;
        }

        static StackObject* SetupTextMeshProUGUI_39(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 9);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TMPro.TextOverflowModes @overflowMode = (TMPro.TextOverflowModes)typeof(TMPro.TextOverflowModes).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @enableWordWrapping = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            TMPro.VerticalAlignmentOptions @verticalAlignment = (TMPro.VerticalAlignmentOptions)typeof(TMPro.VerticalAlignmentOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            TMPro.HorizontalAlignmentOptions @horizontalAlignment = (TMPro.HorizontalAlignmentOptions)typeof(TMPro.HorizontalAlignmentOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.Color @color = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Single @fontSize = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            TMPro.TMP_FontAsset @font = (TMPro.TMP_FontAsset)typeof(TMPro.TMP_FontAsset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            TMPro.TextMeshProUGUI @textMeshProUGUI = (TMPro.TextMeshProUGUI)typeof(TMPro.TextMeshProUGUI).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.UIFramework.Runtime.VisionControls.SetupTextMeshProUGUI(@textMeshProUGUI, @text, @font, @fontSize, @color, @horizontalAlignment, @verticalAlignment, @enableWordWrapping, @overflowMode);

            return __ret;
        }

        static StackObject* SetupToggle_40(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.UI.ToggleGroup @toggleGroup = (UnityEngine.UI.ToggleGroup)typeof(UnityEngine.UI.ToggleGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.UI.Image @graphic = (UnityEngine.UI.Image)typeof(UnityEngine.UI.Image).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @isOn = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.UI.Navigation.Mode @mode = (UnityEngine.UI.Navigation.Mode)typeof(UnityEngine.UI.Navigation.Mode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            UnityEngine.UI.Selectable.Transition @transition = (UnityEngine.UI.Selectable.Transition)typeof(UnityEngine.UI.Selectable.Transition).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            UnityEngine.UI.Toggle @toggle = (UnityEngine.UI.Toggle)typeof(UnityEngine.UI.Toggle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.UIFramework.Runtime.VisionControls.SetupToggle(@toggle, @transition, @mode, @isOn, @graphic, @toggleGroup);

            return __ret;
        }

        static StackObject* SetupLayoutGroup_41(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 10);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @childForceExpandHeight = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @childForceExpandWidth = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @childScaleHeight = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Boolean @childScaleWidth = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            System.Boolean @childControlHeight = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            System.Boolean @childControlWidth = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 7);
            UnityEngine.TextAnchor @childAligment = (UnityEngine.TextAnchor)typeof(UnityEngine.TextAnchor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 8);
            System.Single @spacing = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 9);
            UnityEngine.RectOffset @padding = (UnityEngine.RectOffset)typeof(UnityEngine.RectOffset).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 10);
            UnityEngine.UI.HorizontalOrVerticalLayoutGroup @horizontalLayoutGroup = (UnityEngine.UI.HorizontalOrVerticalLayoutGroup)typeof(UnityEngine.UI.HorizontalOrVerticalLayoutGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.UIFramework.Runtime.VisionControls.SetupLayoutGroup(@horizontalLayoutGroup, @padding, @spacing, @childAligment, @childControlWidth, @childControlHeight, @childScaleWidth, @childScaleHeight, @childForceExpandWidth, @childForceExpandHeight);

            return __ret;
        }





    }
}

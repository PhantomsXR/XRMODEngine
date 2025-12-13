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
    unsafe class Phantom_XRMOD_XRMODUtilites_Runtime_PlatformType_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType);

            field = type.GetField("Pico", flag);
            app.RegisterCLRFieldGetter(field, get_Pico_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Pico_0, null);
            field = type.GetField("Pico3", flag);
            app.RegisterCLRFieldGetter(field, get_Pico3_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Pico3_1, null);
            field = type.GetField("Pico4", flag);
            app.RegisterCLRFieldGetter(field, get_Pico4_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Pico4_2, null);
            field = type.GetField("Pico4p", flag);
            app.RegisterCLRFieldGetter(field, get_Pico4p_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Pico4p_3, null);
            field = type.GetField("Pico4u", flag);
            app.RegisterCLRFieldGetter(field, get_Pico4u_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Pico4u_4, null);
            field = type.GetField("QuestPro", flag);
            app.RegisterCLRFieldGetter(field, get_QuestPro_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_QuestPro_5, null);
            field = type.GetField("Quest2", flag);
            app.RegisterCLRFieldGetter(field, get_Quest2_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_Quest2_6, null);
            field = type.GetField("Quest3", flag);
            app.RegisterCLRFieldGetter(field, get_Quest3_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_Quest3_7, null);
            field = type.GetField("Quest3s", flag);
            app.RegisterCLRFieldGetter(field, get_Quest3s_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_Quest3s_8, null);
            field = type.GetField("VisionOS", flag);
            app.RegisterCLRFieldGetter(field, get_VisionOS_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_VisionOS_9, null);
            field = type.GetField("VisionOS_1_X", flag);
            app.RegisterCLRFieldGetter(field, get_VisionOS_1_X_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_VisionOS_1_X_10, null);
            field = type.GetField("VisionOS_2_X", flag);
            app.RegisterCLRFieldGetter(field, get_VisionOS_2_X_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_VisionOS_2_X_11, null);
            field = type.GetField("RokidLite", flag);
            app.RegisterCLRFieldGetter(field, get_RokidLite_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_RokidLite_12, null);
            field = type.GetField("RokidStudio", flag);
            app.RegisterCLRFieldGetter(field, get_RokidStudio_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_RokidStudio_13, null);
            field = type.GetField("HandheldARiOS", flag);
            app.RegisterCLRFieldGetter(field, get_HandheldARiOS_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_HandheldARiOS_14, null);
            field = type.GetField("HandheldARAndroid", flag);
            app.RegisterCLRFieldGetter(field, get_HandheldARAndroid_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_HandheldARAndroid_15, null);
            field = type.GetField("Web", flag);
            app.RegisterCLRFieldGetter(field, get_Web_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_Web_16, null);
            field = type.GetField("WebAR", flag);
            app.RegisterCLRFieldGetter(field, get_WebAR_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_WebAR_17, null);
            field = type.GetField("WebVR", flag);
            app.RegisterCLRFieldGetter(field, get_WebVR_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_WebVR_18, null);
            field = type.GetField("WebXR", flag);
            app.RegisterCLRFieldGetter(field, get_WebXR_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_WebXR_19, null);
            field = type.GetField("XReal", flag);
            app.RegisterCLRFieldGetter(field, get_XReal_20);
            app.RegisterCLRFieldBinding(field, CopyToStack_XReal_20, null);
            field = type.GetField("Classic3DOSX", flag);
            app.RegisterCLRFieldGetter(field, get_Classic3DOSX_21);
            app.RegisterCLRFieldBinding(field, CopyToStack_Classic3DOSX_21, null);
            field = type.GetField("Classic3DiOS", flag);
            app.RegisterCLRFieldGetter(field, get_Classic3DiOS_22);
            app.RegisterCLRFieldBinding(field, CopyToStack_Classic3DiOS_22, null);
            field = type.GetField("Classic3DLinux", flag);
            app.RegisterCLRFieldGetter(field, get_Classic3DLinux_23);
            app.RegisterCLRFieldBinding(field, CopyToStack_Classic3DLinux_23, null);
            field = type.GetField("Classic3DWindows", flag);
            app.RegisterCLRFieldGetter(field, get_Classic3DWindows_24);
            app.RegisterCLRFieldBinding(field, CopyToStack_Classic3DWindows_24, null);
            field = type.GetField("Classic3DAndroid", flag);
            app.RegisterCLRFieldGetter(field, get_Classic3DAndroid_25);
            app.RegisterCLRFieldBinding(field, CopyToStack_Classic3DAndroid_25, null);
            field = type.GetField("DedicatedServerOSX", flag);
            app.RegisterCLRFieldGetter(field, get_DedicatedServerOSX_26);
            app.RegisterCLRFieldBinding(field, CopyToStack_DedicatedServerOSX_26, null);
            field = type.GetField("DedicatedServerWin", flag);
            app.RegisterCLRFieldGetter(field, get_DedicatedServerWin_27);
            app.RegisterCLRFieldBinding(field, CopyToStack_DedicatedServerWin_27, null);
            field = type.GetField("DedicatedServerLinux", flag);
            app.RegisterCLRFieldGetter(field, get_DedicatedServerLinux_28);
            app.RegisterCLRFieldBinding(field, CopyToStack_DedicatedServerLinux_28, null);
            field = type.GetField("Unknow", flag);
            app.RegisterCLRFieldGetter(field, get_Unknow_29);
            app.RegisterCLRFieldBinding(field, CopyToStack_Unknow_29, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_Pico_0(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Pico;
        }

        static StackObject* CopyToStack_Pico_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Pico;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Pico3_1(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Pico3;
        }

        static StackObject* CopyToStack_Pico3_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Pico3;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Pico4_2(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Pico4;
        }

        static StackObject* CopyToStack_Pico4_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Pico4;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Pico4p_3(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Pico4p;
        }

        static StackObject* CopyToStack_Pico4p_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Pico4p;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Pico4u_4(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Pico4u;
        }

        static StackObject* CopyToStack_Pico4u_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Pico4u;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_QuestPro_5(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.QuestPro;
        }

        static StackObject* CopyToStack_QuestPro_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.QuestPro;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Quest2_6(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Quest2;
        }

        static StackObject* CopyToStack_Quest2_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Quest2;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Quest3_7(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Quest3;
        }

        static StackObject* CopyToStack_Quest3_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Quest3;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Quest3s_8(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Quest3s;
        }

        static StackObject* CopyToStack_Quest3s_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Quest3s;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_VisionOS_9(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.VisionOS;
        }

        static StackObject* CopyToStack_VisionOS_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.VisionOS;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_VisionOS_1_X_10(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.VisionOS_1_X;
        }

        static StackObject* CopyToStack_VisionOS_1_X_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.VisionOS_1_X;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_VisionOS_2_X_11(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.VisionOS_2_X;
        }

        static StackObject* CopyToStack_VisionOS_2_X_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.VisionOS_2_X;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_RokidLite_12(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.RokidLite;
        }

        static StackObject* CopyToStack_RokidLite_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.RokidLite;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_RokidStudio_13(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.RokidStudio;
        }

        static StackObject* CopyToStack_RokidStudio_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.RokidStudio;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_HandheldARiOS_14(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.HandheldARiOS;
        }

        static StackObject* CopyToStack_HandheldARiOS_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.HandheldARiOS;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_HandheldARAndroid_15(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.HandheldARAndroid;
        }

        static StackObject* CopyToStack_HandheldARAndroid_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.HandheldARAndroid;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Web_16(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Web;
        }

        static StackObject* CopyToStack_Web_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Web;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_WebAR_17(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.WebAR;
        }

        static StackObject* CopyToStack_WebAR_17(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.WebAR;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_WebVR_18(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.WebVR;
        }

        static StackObject* CopyToStack_WebVR_18(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.WebVR;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_WebXR_19(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.WebXR;
        }

        static StackObject* CopyToStack_WebXR_19(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.WebXR;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_XReal_20(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.XReal;
        }

        static StackObject* CopyToStack_XReal_20(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.XReal;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Classic3DOSX_21(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Classic3DOSX;
        }

        static StackObject* CopyToStack_Classic3DOSX_21(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Classic3DOSX;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Classic3DiOS_22(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Classic3DiOS;
        }

        static StackObject* CopyToStack_Classic3DiOS_22(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Classic3DiOS;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Classic3DLinux_23(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Classic3DLinux;
        }

        static StackObject* CopyToStack_Classic3DLinux_23(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Classic3DLinux;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Classic3DWindows_24(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Classic3DWindows;
        }

        static StackObject* CopyToStack_Classic3DWindows_24(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Classic3DWindows;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Classic3DAndroid_25(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Classic3DAndroid;
        }

        static StackObject* CopyToStack_Classic3DAndroid_25(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Classic3DAndroid;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_DedicatedServerOSX_26(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.DedicatedServerOSX;
        }

        static StackObject* CopyToStack_DedicatedServerOSX_26(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.DedicatedServerOSX;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_DedicatedServerWin_27(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.DedicatedServerWin;
        }

        static StackObject* CopyToStack_DedicatedServerWin_27(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.DedicatedServerWin;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_DedicatedServerLinux_28(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.DedicatedServerLinux;
        }

        static StackObject* CopyToStack_DedicatedServerLinux_28(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.DedicatedServerLinux;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Unknow_29(ref object o)
        {
            return Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Unknow;
        }

        static StackObject* CopyToStack_Unknow_29(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType.Unknow;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType();
            ins = (Phantom.XRMOD.XRMODUtilites.Runtime.PlatformType)o;
            return ins;
        }


    }
}

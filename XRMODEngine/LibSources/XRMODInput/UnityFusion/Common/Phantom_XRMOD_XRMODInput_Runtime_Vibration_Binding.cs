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
    unsafe class Phantom_XRMOD_XRMODInput_Runtime_Vibration_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODInput.Runtime.Vibration);
            args = new Type[] { };
            method = type.GetMethod("Init", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Init_0);
            args = new Type[] {typeof(Phantom.XRMOD.XRMODInput.Runtime.ImpactFeedbackStyle)};
            method = type.GetMethod("VibrateIOS", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, VibrateIOS_1);
            args = new Type[] {typeof(Phantom.XRMOD.XRMODInput.Runtime.NotificationFeedbackStyle)};
            method = type.GetMethod("VibrateIOS", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, VibrateIOS_2);
            args = new Type[] { };
            method = type.GetMethod("VibrateIOS_SelectionChanged", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, VibrateIOS_SelectionChanged_3);
            args = new Type[] { };
            method = type.GetMethod("VibratePop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, VibratePop_4);
            args = new Type[] { };
            method = type.GetMethod("VibratePeek", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, VibratePeek_5);
            args = new Type[] { };
            method = type.GetMethod("VibrateNope", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, VibrateNope_6);
#if UNITY_ANDROID
            args = new Type[] {typeof(System.Int64)};
            method = type.GetMethod("VibrateAndroid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, VibrateAndroid_7);
            args = new Type[] {typeof(System.Int64[]), typeof(System.Int32)};
            method = type.GetMethod("VibrateAndroid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, VibrateAndroid_8);
            args = new Type[] { };
            method = type.GetMethod("CancelAndroid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CancelAndroid_9);
            args = new Type[] { };
            method = type.GetMethod("HasVibrator", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HasVibrator_10);
            args = new Type[] { };
            method = type.GetMethod("Vibrate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Vibrate_11);
            args = new Type[] { };
            method = type.GetMethod("get_AndroidVersion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_AndroidVersion_12);

            field = type.GetField("UnityPlayer", flag);
            app.RegisterCLRFieldGetter(field, get_UnityPlayer_0);
            app.RegisterCLRFieldSetter(field, set_UnityPlayer_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_UnityPlayer_0, AssignFromStack_UnityPlayer_0);
            field = type.GetField("CurrentActivity", flag);
            app.RegisterCLRFieldGetter(field, get_CurrentActivity_1);
            app.RegisterCLRFieldSetter(field, set_CurrentActivity_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_CurrentActivity_1, AssignFromStack_CurrentActivity_1);
            field = type.GetField("Vibrator", flag);
            app.RegisterCLRFieldGetter(field, get_Vibrator_2);
            app.RegisterCLRFieldSetter(field, set_Vibrator_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Vibrator_2, AssignFromStack_Vibrator_2);
            field = type.GetField("Context", flag);
            app.RegisterCLRFieldGetter(field, get_Context_3);
            app.RegisterCLRFieldSetter(field, set_Context_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Context_3, AssignFromStack_Context_3);
            field = type.GetField("VibrationEffect", flag);
            app.RegisterCLRFieldGetter(field, get_VibrationEffect_4);
            app.RegisterCLRFieldSetter(field, set_VibrationEffect_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_VibrationEffect_4, AssignFromStack_VibrationEffect_4);
#endif
        }


        static StackObject* Init_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            Phantom.XRMOD.XRMODInput.Runtime.Vibration.Init();

            return __ret;
        }

        static StackObject* VibrateIOS_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.ImpactFeedbackStyle @_style =
                (Phantom.XRMOD.XRMODInput.Runtime.ImpactFeedbackStyle)
                typeof(Phantom.XRMOD.XRMODInput.Runtime.ImpactFeedbackStyle).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODInput.Runtime.Vibration.VibrateIOS(@_style);

            return __ret;
        }

        static StackObject* VibrateIOS_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.NotificationFeedbackStyle @_style =
                (Phantom.XRMOD.XRMODInput.Runtime.NotificationFeedbackStyle)
                typeof(Phantom.XRMOD.XRMODInput.Runtime.NotificationFeedbackStyle).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODInput.Runtime.Vibration.VibrateIOS(@_style);

            return __ret;
        }

        static StackObject* VibrateIOS_SelectionChanged_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            Phantom.XRMOD.XRMODInput.Runtime.Vibration.VibrateIOS_SelectionChanged();

            return __ret;
        }

        static StackObject* VibratePop_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            Phantom.XRMOD.XRMODInput.Runtime.Vibration.VibratePop();

            return __ret;
        }

        static StackObject* VibratePeek_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            Phantom.XRMOD.XRMODInput.Runtime.Vibration.VibratePeek();

            return __ret;
        }

        static StackObject* VibrateNope_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            Phantom.XRMOD.XRMODInput.Runtime.Vibration.VibrateNope();

            return __ret;
        }
#if UNITY_ANDROID
        static StackObject* VibrateAndroid_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int64 @_milliseconds = *(long*)&ptr_of_this_method->Value;


            Phantom.XRMOD.XRMODInput.Runtime.Vibration.VibrateAndroid(@_milliseconds);

            return __ret;
        }

        static StackObject* VibrateAndroid_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @repeat = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int64[] @pattern =
 (System.Int64[])typeof(System.Int64[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.XRMODInput.Runtime.Vibration.VibrateAndroid(@pattern, @repeat);

            return __ret;
        }

        static StackObject* CancelAndroid_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            Phantom.XRMOD.XRMODInput.Runtime.Vibration.CancelAndroid();

            return __ret;
        }

        static StackObject* HasVibrator_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.Vibration.HasVibrator();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Vibrate_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            Phantom.XRMOD.XRMODInput.Runtime.Vibration.Vibrate();

            return __ret;
        }

        static StackObject* get_AndroidVersion_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.Vibration.AndroidVersion;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }


        static object get_UnityPlayer_0(ref object o)
        {
            return Phantom.XRMOD.XRMODInput.Runtime.Vibration.UnityPlayer;
        }

        static StackObject* CopyToStack_UnityPlayer_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.Vibration.UnityPlayer;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_UnityPlayer_0(ref object o, object v)
        {
            Phantom.XRMOD.XRMODInput.Runtime.Vibration.UnityPlayer = (UnityEngine.AndroidJavaClass)v;
        }

        static StackObject* AssignFromStack_UnityPlayer_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.AndroidJavaClass @UnityPlayer =
 (UnityEngine.AndroidJavaClass)typeof(UnityEngine.AndroidJavaClass).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            Phantom.XRMOD.XRMODInput.Runtime.Vibration.UnityPlayer = @UnityPlayer;
            return ptr_of_this_method;
        }

        static object get_CurrentActivity_1(ref object o)
        {
            return Phantom.XRMOD.XRMODInput.Runtime.Vibration.CurrentActivity;
        }

        static StackObject* CopyToStack_CurrentActivity_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.Vibration.CurrentActivity;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_CurrentActivity_1(ref object o, object v)
        {
            Phantom.XRMOD.XRMODInput.Runtime.Vibration.CurrentActivity = (UnityEngine.AndroidJavaObject)v;
        }

        static StackObject* AssignFromStack_CurrentActivity_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.AndroidJavaObject @CurrentActivity =
 (UnityEngine.AndroidJavaObject)typeof(UnityEngine.AndroidJavaObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            Phantom.XRMOD.XRMODInput.Runtime.Vibration.CurrentActivity = @CurrentActivity;
            return ptr_of_this_method;
        }

        static object get_Vibrator_2(ref object o)
        {
            return Phantom.XRMOD.XRMODInput.Runtime.Vibration.Vibrator;
        }

        static StackObject* CopyToStack_Vibrator_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.Vibration.Vibrator;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Vibrator_2(ref object o, object v)
        {
            Phantom.XRMOD.XRMODInput.Runtime.Vibration.Vibrator = (UnityEngine.AndroidJavaObject)v;
        }

        static StackObject* AssignFromStack_Vibrator_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.AndroidJavaObject @Vibrator =
 (UnityEngine.AndroidJavaObject)typeof(UnityEngine.AndroidJavaObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            Phantom.XRMOD.XRMODInput.Runtime.Vibration.Vibrator = @Vibrator;
            return ptr_of_this_method;
        }

        static object get_Context_3(ref object o)
        {
            return Phantom.XRMOD.XRMODInput.Runtime.Vibration.Context;
        }

        static StackObject* CopyToStack_Context_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.Vibration.Context;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Context_3(ref object o, object v)
        {
            Phantom.XRMOD.XRMODInput.Runtime.Vibration.Context = (UnityEngine.AndroidJavaObject)v;
        }

        static StackObject* AssignFromStack_Context_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.AndroidJavaObject @Context =
 (UnityEngine.AndroidJavaObject)typeof(UnityEngine.AndroidJavaObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            Phantom.XRMOD.XRMODInput.Runtime.Vibration.Context = @Context;
            return ptr_of_this_method;
        }

        static object get_VibrationEffect_4(ref object o)
        {
            return Phantom.XRMOD.XRMODInput.Runtime.Vibration.VibrationEffect;
        }

        static StackObject* CopyToStack_VibrationEffect_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.Vibration.VibrationEffect;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_VibrationEffect_4(ref object o, object v)
        {
            Phantom.XRMOD.XRMODInput.Runtime.Vibration.VibrationEffect = (UnityEngine.AndroidJavaClass)v;
        }

        static StackObject* AssignFromStack_VibrationEffect_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.AndroidJavaClass @VibrationEffect =
 (UnityEngine.AndroidJavaClass)typeof(UnityEngine.AndroidJavaClass).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            Phantom.XRMOD.XRMODInput.Runtime.Vibration.VibrationEffect = @VibrationEffect;
            return ptr_of_this_method;
        }

#endif
    }
}
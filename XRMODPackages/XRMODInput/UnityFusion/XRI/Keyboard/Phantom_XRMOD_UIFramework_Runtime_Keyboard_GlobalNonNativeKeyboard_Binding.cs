#if USE_XRI
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
    unsafe class Phantom_XRMOD_UIFramework_Runtime_Keyboard_GlobalNonNativeKeyboard_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard);
            args = new Type[]{};
            method = type.GetMethod("get_Instance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Instance_0);
            args = new Type[]{};
            method = type.GetMethod("get_keyboardPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_keyboardPrefab_1);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("set_keyboardPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_keyboardPrefab_2);
            args = new Type[]{};
            method = type.GetMethod("get_playerRoot", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_playerRoot_3);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("set_playerRoot", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_playerRoot_4);
            args = new Type[]{};
            method = type.GetMethod("get_keyboard", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_keyboard_5);
            args = new Type[]{typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.XRKeyboard)};
            method = type.GetMethod("set_keyboard", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_keyboard_6);
            args = new Type[]{};
            method = type.GetMethod("get_keyboardOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_keyboardOffset_7);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_keyboardOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_keyboardOffset_8);
            args = new Type[]{};
            method = type.GetMethod("get_cameraTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cameraTransform_9);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("set_cameraTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_cameraTransform_10);
            args = new Type[]{};
            method = type.GetMethod("get_repositionOutOfViewKeyboardOnOpen", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_repositionOutOfViewKeyboardOnOpen_11);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_repositionOutOfViewKeyboardOnOpen", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_repositionOutOfViewKeyboardOnOpen_12);
            args = new Type[]{};
            method = type.GetMethod("get_facingKeyboardThreshold", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_facingKeyboardThreshold_13);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_facingKeyboardThreshold", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_facingKeyboardThreshold_14);
            args = new Type[]{typeof(TMPro.TMP_InputField), typeof(System.Boolean)};
            method = type.GetMethod("ShowKeyboard", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ShowKeyboard_15);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("ShowKeyboard", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ShowKeyboard_16);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("ShowKeyboard", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ShowKeyboard_17);
            args = new Type[]{};
            method = type.GetMethod("HideKeyboard", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HideKeyboard_18);
            args = new Type[]{};
            method = type.GetMethod("RepositionKeyboardIfOutOfView", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RepositionKeyboardIfOutOfView_19);



            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_Instance_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard.Instance;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_keyboardPrefab_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard)typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.keyboardPrefab;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_keyboardPrefab_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @value = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard)typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.keyboardPrefab = value;

            return __ret;
        }

        static StackObject* get_playerRoot_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard)typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.playerRoot;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_playerRoot_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @value = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard)typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.playerRoot = value;

            return __ret;
        }

        static StackObject* get_keyboard_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard)typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.keyboard;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_keyboard_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.Keyboard.XRKeyboard @value = (Phantom.XRMOD.XRMODInput.Runtime.Keyboard.XRKeyboard)typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.XRKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard)typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.keyboard = value;

            return __ret;
        }

        static StackObject* get_keyboardOffset_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard)typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.keyboardOffset;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_keyboardOffset_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard)typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.keyboardOffset = value;

            return __ret;
        }

        static StackObject* get_cameraTransform_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard)typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.cameraTransform;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_cameraTransform_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @value = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard)typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.cameraTransform = value;

            return __ret;
        }

        static StackObject* get_repositionOutOfViewKeyboardOnOpen_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard)typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.repositionOutOfViewKeyboardOnOpen;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_repositionOutOfViewKeyboardOnOpen_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard)typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.repositionOutOfViewKeyboardOnOpen = value;

            return __ret;
        }

        static StackObject* get_facingKeyboardThreshold_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard)typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.facingKeyboardThreshold;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_facingKeyboardThreshold_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard)typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.facingKeyboardThreshold = value;

            return __ret;
        }

        static StackObject* ShowKeyboard_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @observeCharacterLimit = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TMPro.TMP_InputField @inputField = (TMPro.TMP_InputField)typeof(TMPro.TMP_InputField).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard)typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ShowKeyboard(@inputField, @observeCharacterLimit);

            return __ret;
        }

        static StackObject* ShowKeyboard_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @text = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard)typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ShowKeyboard(@text);

            return __ret;
        }

        static StackObject* ShowKeyboard_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @clearKeyboardText = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard)typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ShowKeyboard(@clearKeyboardText);

            return __ret;
        }

        static StackObject* HideKeyboard_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard)typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.HideKeyboard();

            return __ret;
        }

        static StackObject* RepositionKeyboardIfOutOfView_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard)typeof(Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RepositionKeyboardIfOutOfView();

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.XRMODInput.Runtime.Keyboard.GlobalNonNativeKeyboard();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
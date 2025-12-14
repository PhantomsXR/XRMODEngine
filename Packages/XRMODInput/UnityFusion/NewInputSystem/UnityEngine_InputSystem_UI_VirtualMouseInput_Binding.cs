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
    unsafe class UnityEngine_InputSystem_UI_VirtualMouseInput_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.UI.VirtualMouseInput);
            args = new Type[]{};
            method = type.GetMethod("get_cursorTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cursorTransform_0);
            args = new Type[]{typeof(UnityEngine.RectTransform)};
            method = type.GetMethod("set_cursorTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_cursorTransform_1);
            args = new Type[]{};
            method = type.GetMethod("get_cursorSpeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cursorSpeed_2);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_cursorSpeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_cursorSpeed_3);
            args = new Type[]{};
            method = type.GetMethod("get_cursorMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cursorMode_4);
            args = new Type[]{typeof(UnityEngine.InputSystem.UI.VirtualMouseInput.CursorMode)};
            method = type.GetMethod("set_cursorMode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_cursorMode_5);
            args = new Type[]{};
            method = type.GetMethod("get_cursorGraphic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_cursorGraphic_6);
            args = new Type[]{typeof(UnityEngine.UI.Graphic)};
            method = type.GetMethod("set_cursorGraphic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_cursorGraphic_7);
            args = new Type[]{};
            method = type.GetMethod("get_scrollSpeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_scrollSpeed_8);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_scrollSpeed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_scrollSpeed_9);
            args = new Type[]{};
            method = type.GetMethod("get_virtualMouse", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_virtualMouse_10);
            args = new Type[]{};
            method = type.GetMethod("get_stickAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_stickAction_11);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionProperty)};
            method = type.GetMethod("set_stickAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_stickAction_12);
            args = new Type[]{};
            method = type.GetMethod("get_leftButtonAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_leftButtonAction_13);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionProperty)};
            method = type.GetMethod("set_leftButtonAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_leftButtonAction_14);
            args = new Type[]{};
            method = type.GetMethod("get_rightButtonAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_rightButtonAction_15);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionProperty)};
            method = type.GetMethod("set_rightButtonAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_rightButtonAction_16);
            args = new Type[]{};
            method = type.GetMethod("get_middleButtonAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_middleButtonAction_17);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionProperty)};
            method = type.GetMethod("set_middleButtonAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_middleButtonAction_18);
            args = new Type[]{};
            method = type.GetMethod("get_forwardButtonAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_forwardButtonAction_19);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionProperty)};
            method = type.GetMethod("set_forwardButtonAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_forwardButtonAction_20);
            args = new Type[]{};
            method = type.GetMethod("get_backButtonAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_backButtonAction_21);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionProperty)};
            method = type.GetMethod("set_backButtonAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_backButtonAction_22);
            args = new Type[]{};
            method = type.GetMethod("get_scrollWheelAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_scrollWheelAction_23);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputActionProperty)};
            method = type.GetMethod("set_scrollWheelAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_scrollWheelAction_24);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.InputSystem.UI.VirtualMouseInput());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.InputSystem.UI.VirtualMouseInput[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_cursorTransform_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.cursorTransform;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_cursorTransform_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.RectTransform @value = (UnityEngine.RectTransform)typeof(UnityEngine.RectTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.cursorTransform = value;

            return __ret;
        }

        static StackObject* get_cursorSpeed_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.cursorSpeed;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_cursorSpeed_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.cursorSpeed = value;

            return __ret;
        }

        static StackObject* get_cursorMode_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.cursorMode;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_cursorMode_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.VirtualMouseInput.CursorMode @value = (UnityEngine.InputSystem.UI.VirtualMouseInput.CursorMode)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput.CursorMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.cursorMode = value;

            return __ret;
        }

        static StackObject* get_cursorGraphic_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.cursorGraphic;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_cursorGraphic_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.UI.Graphic @value = (UnityEngine.UI.Graphic)typeof(UnityEngine.UI.Graphic).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.cursorGraphic = value;

            return __ret;
        }

        static StackObject* get_scrollSpeed_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.scrollSpeed;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_scrollSpeed_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.scrollSpeed = value;

            return __ret;
        }

        static StackObject* get_virtualMouse_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.virtualMouse;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_stickAction_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.stickAction;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_stickAction_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputActionProperty @value = (UnityEngine.InputSystem.InputActionProperty)typeof(UnityEngine.InputSystem.InputActionProperty).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.stickAction = value;

            return __ret;
        }

        static StackObject* get_leftButtonAction_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.leftButtonAction;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_leftButtonAction_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputActionProperty @value = (UnityEngine.InputSystem.InputActionProperty)typeof(UnityEngine.InputSystem.InputActionProperty).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.leftButtonAction = value;

            return __ret;
        }

        static StackObject* get_rightButtonAction_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.rightButtonAction;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_rightButtonAction_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputActionProperty @value = (UnityEngine.InputSystem.InputActionProperty)typeof(UnityEngine.InputSystem.InputActionProperty).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.rightButtonAction = value;

            return __ret;
        }

        static StackObject* get_middleButtonAction_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.middleButtonAction;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_middleButtonAction_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputActionProperty @value = (UnityEngine.InputSystem.InputActionProperty)typeof(UnityEngine.InputSystem.InputActionProperty).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.middleButtonAction = value;

            return __ret;
        }

        static StackObject* get_forwardButtonAction_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.forwardButtonAction;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_forwardButtonAction_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputActionProperty @value = (UnityEngine.InputSystem.InputActionProperty)typeof(UnityEngine.InputSystem.InputActionProperty).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.forwardButtonAction = value;

            return __ret;
        }

        static StackObject* get_backButtonAction_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.backButtonAction;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_backButtonAction_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputActionProperty @value = (UnityEngine.InputSystem.InputActionProperty)typeof(UnityEngine.InputSystem.InputActionProperty).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.backButtonAction = value;

            return __ret;
        }

        static StackObject* get_scrollWheelAction_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.scrollWheelAction;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_scrollWheelAction_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputActionProperty @value = (UnityEngine.InputSystem.InputActionProperty)typeof(UnityEngine.InputSystem.InputActionProperty).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.VirtualMouseInput instance_of_this_method = (UnityEngine.InputSystem.UI.VirtualMouseInput)typeof(UnityEngine.InputSystem.UI.VirtualMouseInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.scrollWheelAction = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.InputSystem.UI.VirtualMouseInput();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

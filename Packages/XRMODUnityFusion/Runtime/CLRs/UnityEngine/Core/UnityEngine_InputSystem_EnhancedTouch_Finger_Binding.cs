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
    unsafe class UnityEngine_InputSystem_EnhancedTouch_Finger_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.EnhancedTouch.Finger);
            args = new Type[]{};
            method = type.GetMethod("get_screen", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_screen_0);
            args = new Type[]{};
            method = type.GetMethod("get_index", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_index_1);
            args = new Type[]{};
            method = type.GetMethod("get_isActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_isActive_2);
            args = new Type[]{};
            method = type.GetMethod("get_screenPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_screenPosition_3);
            args = new Type[]{};
            method = type.GetMethod("get_lastTouch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lastTouch_4);
            args = new Type[]{};
            method = type.GetMethod("get_currentTouch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_currentTouch_5);
            args = new Type[]{};
            method = type.GetMethod("get_touchHistory", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_touchHistory_6);



            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.InputSystem.EnhancedTouch.Finger[s]);


        }


        static StackObject* get_screen_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.EnhancedTouch.Finger instance_of_this_method = (UnityEngine.InputSystem.EnhancedTouch.Finger)typeof(UnityEngine.InputSystem.EnhancedTouch.Finger).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.screen;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_index_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.EnhancedTouch.Finger instance_of_this_method = (UnityEngine.InputSystem.EnhancedTouch.Finger)typeof(UnityEngine.InputSystem.EnhancedTouch.Finger).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.index;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_isActive_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.EnhancedTouch.Finger instance_of_this_method = (UnityEngine.InputSystem.EnhancedTouch.Finger)typeof(UnityEngine.InputSystem.EnhancedTouch.Finger).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.isActive;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_screenPosition_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.EnhancedTouch.Finger instance_of_this_method = (UnityEngine.InputSystem.EnhancedTouch.Finger)typeof(UnityEngine.InputSystem.EnhancedTouch.Finger).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.screenPosition;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_lastTouch_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.EnhancedTouch.Finger instance_of_this_method = (UnityEngine.InputSystem.EnhancedTouch.Finger)typeof(UnityEngine.InputSystem.EnhancedTouch.Finger).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.lastTouch;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_currentTouch_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.EnhancedTouch.Finger instance_of_this_method = (UnityEngine.InputSystem.EnhancedTouch.Finger)typeof(UnityEngine.InputSystem.EnhancedTouch.Finger).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.currentTouch;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_touchHistory_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.EnhancedTouch.Finger instance_of_this_method = (UnityEngine.InputSystem.EnhancedTouch.Finger)typeof(UnityEngine.InputSystem.EnhancedTouch.Finger).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.touchHistory;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }





    }
}

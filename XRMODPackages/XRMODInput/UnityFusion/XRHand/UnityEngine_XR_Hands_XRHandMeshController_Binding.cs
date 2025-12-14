#if XR_HAND

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
    unsafe class UnityEngine_XR_Hands_XRHandMeshController_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.Hands.XRHandMeshController);
            args = new Type[]{};
            method = type.GetMethod("get_handIsTracked", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_handIsTracked_0);
            args = new Type[]{};
            method = type.GetMethod("get_showMeshWhenTrackingIsAcquired", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_showMeshWhenTrackingIsAcquired_1);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_showMeshWhenTrackingIsAcquired", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_showMeshWhenTrackingIsAcquired_2);
            args = new Type[]{};
            method = type.GetMethod("get_hideMeshWhenTrackingIsLost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hideMeshWhenTrackingIsLost_3);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_hideMeshWhenTrackingIsLost", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_hideMeshWhenTrackingIsLost_4);
            args = new Type[]{};
            method = type.GetMethod("get_handMeshRenderer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_handMeshRenderer_5);
            args = new Type[]{typeof(UnityEngine.Renderer)};
            method = type.GetMethod("set_handMeshRenderer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_handMeshRenderer_6);
            args = new Type[]{};
            method = type.GetMethod("get_handTrackingEvents", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_handTrackingEvents_7);
            args = new Type[]{typeof(UnityEngine.XR.Hands.XRHandTrackingEvents)};
            method = type.GetMethod("set_handTrackingEvents", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_handTrackingEvents_8);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.Hands.XRHandMeshController());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.Hands.XRHandMeshController[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_handIsTracked_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Hands.XRHandMeshController instance_of_this_method = (UnityEngine.XR.Hands.XRHandMeshController)typeof(UnityEngine.XR.Hands.XRHandMeshController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.handIsTracked;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_showMeshWhenTrackingIsAcquired_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Hands.XRHandMeshController instance_of_this_method = (UnityEngine.XR.Hands.XRHandMeshController)typeof(UnityEngine.XR.Hands.XRHandMeshController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.showMeshWhenTrackingIsAcquired;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_showMeshWhenTrackingIsAcquired_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Hands.XRHandMeshController instance_of_this_method = (UnityEngine.XR.Hands.XRHandMeshController)typeof(UnityEngine.XR.Hands.XRHandMeshController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.showMeshWhenTrackingIsAcquired = value;

            return __ret;
        }

        static StackObject* get_hideMeshWhenTrackingIsLost_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Hands.XRHandMeshController instance_of_this_method = (UnityEngine.XR.Hands.XRHandMeshController)typeof(UnityEngine.XR.Hands.XRHandMeshController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.hideMeshWhenTrackingIsLost;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_hideMeshWhenTrackingIsLost_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Hands.XRHandMeshController instance_of_this_method = (UnityEngine.XR.Hands.XRHandMeshController)typeof(UnityEngine.XR.Hands.XRHandMeshController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.hideMeshWhenTrackingIsLost = value;

            return __ret;
        }

        static StackObject* get_handMeshRenderer_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Hands.XRHandMeshController instance_of_this_method = (UnityEngine.XR.Hands.XRHandMeshController)typeof(UnityEngine.XR.Hands.XRHandMeshController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.handMeshRenderer;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_handMeshRenderer_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Renderer @value = (UnityEngine.Renderer)typeof(UnityEngine.Renderer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Hands.XRHandMeshController instance_of_this_method = (UnityEngine.XR.Hands.XRHandMeshController)typeof(UnityEngine.XR.Hands.XRHandMeshController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.handMeshRenderer = value;

            return __ret;
        }

        static StackObject* get_handTrackingEvents_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Hands.XRHandMeshController instance_of_this_method = (UnityEngine.XR.Hands.XRHandMeshController)typeof(UnityEngine.XR.Hands.XRHandMeshController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.handTrackingEvents;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_handTrackingEvents_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Hands.XRHandTrackingEvents @value = (UnityEngine.XR.Hands.XRHandTrackingEvents)typeof(UnityEngine.XR.Hands.XRHandTrackingEvents).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Hands.XRHandMeshController instance_of_this_method = (UnityEngine.XR.Hands.XRHandMeshController)typeof(UnityEngine.XR.Hands.XRHandMeshController).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.handTrackingEvents = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.Hands.XRHandMeshController();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
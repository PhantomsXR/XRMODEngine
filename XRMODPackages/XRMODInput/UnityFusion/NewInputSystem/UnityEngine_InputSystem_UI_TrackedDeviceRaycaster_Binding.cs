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
    unsafe class UnityEngine_InputSystem_UI_TrackedDeviceRaycaster_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.UI.TrackedDeviceRaycaster);
            args = new Type[]{};
            method = type.GetMethod("get_eventCamera", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_eventCamera_0);
            args = new Type[]{};
            method = type.GetMethod("get_blockingMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_blockingMask_1);
            args = new Type[]{typeof(UnityEngine.LayerMask)};
            method = type.GetMethod("set_blockingMask", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_blockingMask_2);
            args = new Type[]{};
            method = type.GetMethod("get_checkFor3DOcclusion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_checkFor3DOcclusion_3);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_checkFor3DOcclusion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_checkFor3DOcclusion_4);
            args = new Type[]{};
            method = type.GetMethod("get_checkFor2DOcclusion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_checkFor2DOcclusion_5);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_checkFor2DOcclusion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_checkFor2DOcclusion_6);
            args = new Type[]{};
            method = type.GetMethod("get_ignoreReversedGraphics", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ignoreReversedGraphics_7);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_ignoreReversedGraphics", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ignoreReversedGraphics_8);
            args = new Type[]{};
            method = type.GetMethod("get_maxDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxDistance_9);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_maxDistance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_maxDistance_10);
            args = new Type[]{typeof(UnityEngine.EventSystems.PointerEventData), typeof(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>)};
            method = type.GetMethod("Raycast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Raycast_11);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.InputSystem.UI.TrackedDeviceRaycaster());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.InputSystem.UI.TrackedDeviceRaycaster[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_eventCamera_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.TrackedDeviceRaycaster instance_of_this_method = (UnityEngine.InputSystem.UI.TrackedDeviceRaycaster)typeof(UnityEngine.InputSystem.UI.TrackedDeviceRaycaster).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.eventCamera;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_blockingMask_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.TrackedDeviceRaycaster instance_of_this_method = (UnityEngine.InputSystem.UI.TrackedDeviceRaycaster)typeof(UnityEngine.InputSystem.UI.TrackedDeviceRaycaster).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.blockingMask;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_blockingMask_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.LayerMask @value = (UnityEngine.LayerMask)typeof(UnityEngine.LayerMask).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.TrackedDeviceRaycaster instance_of_this_method = (UnityEngine.InputSystem.UI.TrackedDeviceRaycaster)typeof(UnityEngine.InputSystem.UI.TrackedDeviceRaycaster).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.blockingMask = value;

            return __ret;
        }

        static StackObject* get_checkFor3DOcclusion_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.TrackedDeviceRaycaster instance_of_this_method = (UnityEngine.InputSystem.UI.TrackedDeviceRaycaster)typeof(UnityEngine.InputSystem.UI.TrackedDeviceRaycaster).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.checkFor3DOcclusion;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_checkFor3DOcclusion_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.TrackedDeviceRaycaster instance_of_this_method = (UnityEngine.InputSystem.UI.TrackedDeviceRaycaster)typeof(UnityEngine.InputSystem.UI.TrackedDeviceRaycaster).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.checkFor3DOcclusion = value;

            return __ret;
        }

        static StackObject* get_checkFor2DOcclusion_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.TrackedDeviceRaycaster instance_of_this_method = (UnityEngine.InputSystem.UI.TrackedDeviceRaycaster)typeof(UnityEngine.InputSystem.UI.TrackedDeviceRaycaster).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.checkFor2DOcclusion;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_checkFor2DOcclusion_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.TrackedDeviceRaycaster instance_of_this_method = (UnityEngine.InputSystem.UI.TrackedDeviceRaycaster)typeof(UnityEngine.InputSystem.UI.TrackedDeviceRaycaster).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.checkFor2DOcclusion = value;

            return __ret;
        }

        static StackObject* get_ignoreReversedGraphics_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.TrackedDeviceRaycaster instance_of_this_method = (UnityEngine.InputSystem.UI.TrackedDeviceRaycaster)typeof(UnityEngine.InputSystem.UI.TrackedDeviceRaycaster).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ignoreReversedGraphics;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_ignoreReversedGraphics_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.TrackedDeviceRaycaster instance_of_this_method = (UnityEngine.InputSystem.UI.TrackedDeviceRaycaster)typeof(UnityEngine.InputSystem.UI.TrackedDeviceRaycaster).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ignoreReversedGraphics = value;

            return __ret;
        }

        static StackObject* get_maxDistance_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.UI.TrackedDeviceRaycaster instance_of_this_method = (UnityEngine.InputSystem.UI.TrackedDeviceRaycaster)typeof(UnityEngine.InputSystem.UI.TrackedDeviceRaycaster).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxDistance;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_maxDistance_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.UI.TrackedDeviceRaycaster instance_of_this_method = (UnityEngine.InputSystem.UI.TrackedDeviceRaycaster)typeof(UnityEngine.InputSystem.UI.TrackedDeviceRaycaster).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.maxDistance = value;

            return __ret;
        }

        static StackObject* Raycast_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult> @resultAppendList = (System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>)typeof(System.Collections.Generic.List<UnityEngine.EventSystems.RaycastResult>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.EventSystems.PointerEventData @eventData = (UnityEngine.EventSystems.PointerEventData)typeof(UnityEngine.EventSystems.PointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.InputSystem.UI.TrackedDeviceRaycaster instance_of_this_method = (UnityEngine.InputSystem.UI.TrackedDeviceRaycaster)typeof(UnityEngine.InputSystem.UI.TrackedDeviceRaycaster).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Raycast(@eventData, @resultAppendList);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.InputSystem.UI.TrackedDeviceRaycaster();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

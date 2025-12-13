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
    unsafe class UnityEngine_XR_VisionOS_InputDevices_VisionOSSpatialPointerDevice_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerDevice);
            args = new Type[]{};
            method = type.GetMethod("get_primaryInput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_primaryInput_0);
            args = new Type[]{};
            method = type.GetMethod("get_inputs", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_inputs_1);
            args = new Type[]{};
            method = type.GetMethod("OnNextUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNextUpdate_2);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputControl), typeof(UnityEngine.InputSystem.LowLevel.InputEventPtr), typeof(System.UInt32).MakeByRefType()};
            method = type.GetMethod("GetStateOffsetForEvent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetStateOffsetForEvent_3);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerDevice());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerDevice[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_primaryInput_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerDevice instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerDevice)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerDevice).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.primaryInput;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_inputs_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerDevice instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerDevice)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerDevice).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.inputs;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* OnNextUpdate_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerDevice instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerDevice)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerDevice).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNextUpdate();

            return __ret;
        }

        static StackObject* GetStateOffsetForEvent_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.UInt32 @offset = (System.UInt32)__intp.RetriveInt32(ptr_of_this_method, __mStack);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.LowLevel.InputEventPtr @eventPtr = (UnityEngine.InputSystem.LowLevel.InputEventPtr)typeof(UnityEngine.InputSystem.LowLevel.InputEventPtr).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.InputSystem.InputControl @control = (UnityEngine.InputSystem.InputControl)typeof(UnityEngine.InputSystem.InputControl).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerDevice instance_of_this_method = (UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerDevice)typeof(UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerDevice).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.GetStateOffsetForEvent(@control, @eventPtr, ref @offset);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        ___dst->ObjectType = ObjectTypes.Integer;
                        ___dst->Value = (int)@offset;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @offset;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @offset);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @offset;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @offset);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.UInt32[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @offset;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.VisionOS.InputDevices.VisionOSSpatialPointerDevice();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

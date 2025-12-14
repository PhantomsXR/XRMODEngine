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
    unsafe class Phantom_XRMOD_XRMODInput_Runtime_UniversalXRInput_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput);
            args = new Type[]{};
            method = type.GetMethod("get_GetInstance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_GetInstance_0);
            args = new Type[]{typeof(Phantom.XRMOD.XRMODInput.Runtime.InteractorMode), typeof(System.Boolean)};
            method = type.GetMethod("SetupInteractorState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetupInteractorState_1);
            args = new Type[]{};
            method = type.GetMethod("TryGetPinch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetPinch_2);
            args = new Type[]{typeof(UnityEngine.XR.Hands.Handedness)};
            method = type.GetMethod("TryGetPinch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetPinch_3);
            args = new Type[]{typeof(UnityEngine.XR.Hands.Handedness), typeof(Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)};
            method = type.GetMethod("RegisterHandGesture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterHandGesture_4);
            args = new Type[]{typeof(UnityEngine.XR.Hands.Handedness), typeof(Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)};
            method = type.GetMethod("UnregisterHandGesture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UnregisterHandGesture_5);
            args = new Type[]{typeof(UnityEngine.XR.XRNode), typeof(System.Boolean).MakeByRefType(), typeof(System.Boolean).MakeByRefType(), typeof(System.Single).MakeByRefType()};
            method = type.GetMethod("TryGetPinchProgress", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetPinchProgress_6);
            args = new Type[]{typeof(UnityEngine.XR.Hands.XRHandJointID), typeof(UnityEngine.XR.XRNode), typeof(UnityEngine.Pose).MakeByRefType(), typeof(System.Boolean)};
            method = type.GetMethod("TryGetJointPose", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetJointPose_7);
            args = new Type[]{typeof(UnityEngine.XR.XRNode), typeof(UnityEngine.XR.Hands.XRHandJointID), typeof(UnityEngine.Transform).MakeByRefType()};
            method = type.GetMethod("TryGetJointTransform", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetJointTransform_8);
            args = new Type[]{typeof(UnityEngine.XR.XRNode), typeof(System.Boolean).MakeByRefType()};
            method = type.GetMethod("TryGetPalmFacingAway", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetPalmFacingAway_9);
            args = new Type[]{typeof(Phantom.XRMOD.XRMODInput.Runtime.InputType)};
            method = type.GetMethod("SwitchInput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SwitchInput_10);
            args = new Type[]{typeof(Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType()};
            method = type.GetMethod("GetRayInteractorPose", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRayInteractorPose_11);
            args = new Type[]{typeof(Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness), typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor).MakeByRefType()};
            method = type.GetMethod("GetRayInteractor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetRayInteractor_12);
            args = new Type[]{};
            method = type.GetMethod("GetCurrentInputType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetCurrentInputType_13);
            args = new Type[]{typeof(UnityEngine.XR.Hands.Handedness[])};
            method = type.GetMethod("IsHandTracked", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsHandTracked_14);
            args = new Type[]{typeof(UnityEngine.XR.Hands.Handedness), typeof(Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey), typeof(System.Single).MakeByRefType()};
            method = type.GetMethod("TryGetXRControllerButtonInput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetXRControllerButtonInput_15);
            args = new Type[]{typeof(UnityEngine.XR.Hands.Handedness), typeof(UnityEngine.Vector2).MakeByRefType()};
            method = type.GetMethod("TryGetXRControllerAxis", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetXRControllerAxis_16);
            args = new Type[]{typeof(UnityEngine.XR.Hands.Handedness), typeof(UnityEngine.Vector3).MakeByRefType(), typeof(UnityEngine.Quaternion).MakeByRefType()};
            method = type.GetMethod("TryGetXRControllerPose", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryGetXRControllerPose_17);

            field = type.GetField("HandnessDict", flag);
            app.RegisterCLRFieldGetter(field, get_HandnessDict_0);
            app.RegisterCLRFieldSetter(field, set_HandnessDict_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_HandnessDict_0, AssignFromStack_HandnessDict_0);


            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput[s]);


        }


        static StackObject* get_GetInstance_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput.GetInstance;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetupInteractorState_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @_enable = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.InteractorMode @_interactorMode = (Phantom.XRMOD.XRMODInput.Runtime.InteractorMode)typeof(Phantom.XRMOD.XRMODInput.Runtime.InteractorMode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput)typeof(Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetupInteractorState(@_interactorMode, @_enable);

            return __ret;
        }

        static StackObject* TryGetPinch_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput)typeof(Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryGetPinch();

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* TryGetPinch_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Hands.Handedness @_handedness = (UnityEngine.XR.Hands.Handedness)typeof(UnityEngine.XR.Hands.Handedness).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput)typeof(Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TryGetPinch(@_handedness);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RegisterHandGesture_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData @_customGestureData = (Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)typeof(Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Hands.Handedness @_handedness = (UnityEngine.XR.Hands.Handedness)typeof(UnityEngine.XR.Hands.Handedness).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput)typeof(Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RegisterHandGesture(@_handedness, @_customGestureData);

            return __ret;
        }

        static StackObject* UnregisterHandGesture_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData @_customGestureData = (Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData)typeof(Phantom.XRMOD.XRMODInput.Runtime.CustomGestureData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Hands.Handedness @_handedness = (UnityEngine.XR.Hands.Handedness)typeof(UnityEngine.XR.Hands.Handedness).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput)typeof(Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UnregisterHandGesture(@_handedness, @_customGestureData);

            return __ret;
        }

        static StackObject* TryGetPinchProgress_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @_pinchAmount = __intp.RetriveFloat(ptr_of_this_method, __mStack);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @_isPinching = __intp.RetriveInt32(ptr_of_this_method, __mStack) == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Boolean @_isReadyToPinch = __intp.RetriveInt32(ptr_of_this_method, __mStack) == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.XR.XRNode @_handNode = (UnityEngine.XR.XRNode)typeof(UnityEngine.XR.XRNode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput)typeof(Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.TryGetPinchProgress(@_handNode, out @_isReadyToPinch, out @_isPinching, out @_pinchAmount);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        ___dst->ObjectType = ObjectTypes.Float;
                        *(float*)&___dst->Value = @_pinchAmount;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @_pinchAmount;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @_pinchAmount);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @_pinchAmount;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @_pinchAmount);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Single[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @_pinchAmount;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        ___dst->ObjectType = ObjectTypes.Integer;
                        ___dst->Value = @_isPinching ? 1 : 0;;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @_isPinching;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @_isPinching);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @_isPinching;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @_isPinching);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Boolean[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @_isPinching;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        ___dst->ObjectType = ObjectTypes.Integer;
                        ___dst->Value = @_isReadyToPinch ? 1 : 0;;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @_isReadyToPinch;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @_isReadyToPinch);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @_isReadyToPinch;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @_isReadyToPinch);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Boolean[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @_isReadyToPinch;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* TryGetJointPose_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @_convertToWorldPose = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Pose @_jointPose = (UnityEngine.Pose)typeof(UnityEngine.Pose).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.XRNode @_hand = (UnityEngine.XR.XRNode)typeof(UnityEngine.XR.XRNode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.XR.Hands.XRHandJointID @_joint = (UnityEngine.XR.Hands.XRHandJointID)typeof(UnityEngine.XR.Hands.XRHandJointID).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput)typeof(Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.TryGetJointPose(@_joint, @_hand, out @_jointPose, @_convertToWorldPose);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @_jointPose;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @_jointPose;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @_jointPose);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @_jointPose;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @_jointPose);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Pose[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @_jointPose;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* TryGetJointTransform_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @_jointTransform = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Hands.XRHandJointID @_jointId = (UnityEngine.XR.Hands.XRHandJointID)typeof(UnityEngine.XR.Hands.XRHandJointID).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.XRNode @_xrNode = (UnityEngine.XR.XRNode)typeof(UnityEngine.XR.XRNode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput)typeof(Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.TryGetJointTransform(@_xrNode, @_jointId, out @_jointTransform);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @_jointTransform;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @_jointTransform;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @_jointTransform);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @_jointTransform;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @_jointTransform);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Transform[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @_jointTransform;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* TryGetPalmFacingAway_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @_palmFacingAway = __intp.RetriveInt32(ptr_of_this_method, __mStack) == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.XRNode @_hand = (UnityEngine.XR.XRNode)typeof(UnityEngine.XR.XRNode).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput)typeof(Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            instance_of_this_method.TryGetPalmFacingAway(@_hand, out @_palmFacingAway);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        ___dst->ObjectType = ObjectTypes.Integer;
                        ___dst->Value = @_palmFacingAway ? 1 : 0;;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @_palmFacingAway;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @_palmFacingAway);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @_palmFacingAway;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @_palmFacingAway);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Boolean[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @_palmFacingAway;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* SwitchInput_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.InputType @_inputType = (Phantom.XRMOD.XRMODInput.Runtime.InputType)typeof(Phantom.XRMOD.XRMODInput.Runtime.InputType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput)typeof(Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SwitchInput(@_inputType);

            return __ret;
        }

        static StackObject* GetRayInteractorPose_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @_rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @_position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness @_handedness = (Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness)typeof(Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput)typeof(Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            instance_of_this_method.GetRayInteractorPose(@_handedness, out @_position, out @_rotation);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @_rotation;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @_rotation;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @_rotation);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @_rotation;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @_rotation);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Quaternion[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @_rotation;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @_position;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @_position;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @_position);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @_position;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @_position);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Vector3[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @_position;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* GetRayInteractor_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor @_nearFarInteractor = (UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor)typeof(UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness @_handness = (Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness)typeof(Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput)typeof(Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.GetRayInteractor(@_handness, out @_nearFarInteractor);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @_nearFarInteractor;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @_nearFarInteractor;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @_nearFarInteractor);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @_nearFarInteractor;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @_nearFarInteractor);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.XR.Interaction.Toolkit.Interactors.NearFarInteractor[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @_nearFarInteractor;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetCurrentInputType_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput)typeof(Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetCurrentInputType();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* IsHandTracked_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Hands.Handedness[] @_hands = (UnityEngine.XR.Hands.Handedness[])typeof(UnityEngine.XR.Hands.Handedness[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput)typeof(Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsHandTracked(@_hands);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* TryGetXRControllerButtonInput_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @_value = __intp.RetriveFloat(ptr_of_this_method, __mStack);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey @_controllerKey = (Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey)typeof(Phantom.XRMOD.XRMODInput.Runtime.XRControllerKey).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.Hands.Handedness @_handedness = (UnityEngine.XR.Hands.Handedness)typeof(UnityEngine.XR.Hands.Handedness).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput)typeof(Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.TryGetXRControllerButtonInput(@_handedness, @_controllerKey, out @_value);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        ___dst->ObjectType = ObjectTypes.Float;
                        *(float*)&___dst->Value = @_value;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @_value;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @_value);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @_value;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @_value);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as System.Single[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @_value;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* TryGetXRControllerAxis_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @_axis = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.Hands.Handedness @_handedness = (UnityEngine.XR.Hands.Handedness)typeof(UnityEngine.XR.Hands.Handedness).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput)typeof(Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.TryGetXRControllerAxis(@_handedness, out @_axis);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @_axis;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @_axis;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @_axis);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @_axis;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @_axis);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Vector2[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @_axis;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* TryGetXRControllerPose_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @_rotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector3 @_position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.Hands.Handedness @_handedness = (UnityEngine.XR.Hands.Handedness)typeof(UnityEngine.XR.Hands.Handedness).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput instance_of_this_method = (Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput)typeof(Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);

            var result_of_this_method = instance_of_this_method.TryGetXRControllerPose(@_handedness, out @_position, out @_rotation);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @_rotation;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @_rotation;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @_rotation);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @_rotation;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @_rotation);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Quaternion[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @_rotation;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @_position;
                        if (___dst->ObjectType >= ObjectTypes.Object)
                        {
                            if (___obj is CrossBindingAdaptorType)
                                ___obj = ((CrossBindingAdaptorType)___obj).ILInstance;
                            __mStack[___dst->Value] = ___obj;
                        }
                        else
                        {
                            ILIntepreter.UnboxObject(___dst, ___obj, __mStack, __domain);
                        }
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @_position;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @_position);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @_position;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @_position);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.Vector3[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @_position;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            __intp.FreeStackValueType(ptr_of_this_method);
            __intp.Free(ptr_of_this_method);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static object get_HandnessDict_0(ref object o)
        {
            return ((Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput)o).HandnessDict;
        }

        static StackObject* CopyToStack_HandnessDict_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput)o).HandnessDict;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_HandnessDict_0(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput)o).HandnessDict = (System.Collections.Generic.Dictionary<Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness, UnityEngine.Transform>)v;
        }

        static StackObject* AssignFromStack_HandnessDict_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness, UnityEngine.Transform> @HandnessDict = (System.Collections.Generic.Dictionary<Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness, UnityEngine.Transform>)typeof(System.Collections.Generic.Dictionary<Phantom.XRMOD.XRMODInput.Runtime.InteractorHandness, UnityEngine.Transform>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODInput.Runtime.UniversalXRInput)o).HandnessDict = @HandnessDict;
            return ptr_of_this_method;
        }




    }
}
#endif
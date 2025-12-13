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
    unsafe class UnityEngine_InputSystem_Users_InputUser_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.InputSystem.Users.InputUser);
            args = new Type[]{};
            method = type.GetMethod("get_valid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_valid_0);
            args = new Type[]{};
            method = type.GetMethod("get_index", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_index_1);
            args = new Type[]{};
            method = type.GetMethod("get_id", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_id_2);
            args = new Type[]{};
            method = type.GetMethod("get_platformUserAccountHandle", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_platformUserAccountHandle_3);
            args = new Type[]{};
            method = type.GetMethod("get_platformUserAccountName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_platformUserAccountName_4);
            args = new Type[]{};
            method = type.GetMethod("get_platformUserAccountId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_platformUserAccountId_5);
            args = new Type[]{};
            method = type.GetMethod("get_pairedDevices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_pairedDevices_6);
            args = new Type[]{};
            method = type.GetMethod("get_lostDevices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_lostDevices_7);
            args = new Type[]{};
            method = type.GetMethod("get_actions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_actions_8);
            args = new Type[]{};
            method = type.GetMethod("get_controlScheme", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_controlScheme_9);
            args = new Type[]{};
            method = type.GetMethod("get_controlSchemeMatch", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_controlSchemeMatch_10);
            args = new Type[]{};
            method = type.GetMethod("get_hasMissingRequiredDevices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_hasMissingRequiredDevices_11);
            args = new Type[]{};
            method = type.GetMethod("get_all", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_all_12);
            args = new Type[]{typeof(System.Action<UnityEngine.InputSystem.Users.InputUser, UnityEngine.InputSystem.Users.InputUserChange, UnityEngine.InputSystem.InputDevice>)};
            method = type.GetMethod("add_onChange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_onChange_13);
            args = new Type[]{typeof(System.Action<UnityEngine.InputSystem.Users.InputUser, UnityEngine.InputSystem.Users.InputUserChange, UnityEngine.InputSystem.InputDevice>)};
            method = type.GetMethod("remove_onChange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_onChange_14);
            args = new Type[]{typeof(System.Action<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr>)};
            method = type.GetMethod("add_onUnpairedDeviceUsed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_onUnpairedDeviceUsed_15);
            args = new Type[]{typeof(System.Action<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr>)};
            method = type.GetMethod("remove_onUnpairedDeviceUsed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_onUnpairedDeviceUsed_16);
            args = new Type[]{typeof(System.Func<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr, System.Boolean>)};
            method = type.GetMethod("add_onPrefilterUnpairedDeviceActivity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_onPrefilterUnpairedDeviceActivity_17);
            args = new Type[]{typeof(System.Func<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr, System.Boolean>)};
            method = type.GetMethod("remove_onPrefilterUnpairedDeviceActivity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_onPrefilterUnpairedDeviceActivity_18);
            args = new Type[]{};
            method = type.GetMethod("get_listenForUnpairedDeviceActivity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_listenForUnpairedDeviceActivity_19);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("set_listenForUnpairedDeviceActivity", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_listenForUnpairedDeviceActivity_20);
            args = new Type[]{};
            method = type.GetMethod("ToString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToString_21);
            args = new Type[]{typeof(UnityEngine.InputSystem.IInputActionCollection)};
            method = type.GetMethod("AssociateActionsWithUser", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AssociateActionsWithUser_22);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("ActivateControlScheme", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ActivateControlScheme_23);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputControlScheme)};
            method = type.GetMethod("ActivateControlScheme", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ActivateControlScheme_24);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputDevice)};
            method = type.GetMethod("UnpairDevice", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UnpairDevice_25);
            args = new Type[]{};
            method = type.GetMethod("UnpairDevices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UnpairDevices_26);
            args = new Type[]{};
            method = type.GetMethod("UnpairDevicesAndRemoveUser", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UnpairDevicesAndRemoveUser_27);
            args = new Type[]{};
            method = type.GetMethod("GetUnpairedInputDevices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetUnpairedInputDevices_28);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice>).MakeByRefType()};
            method = type.GetMethod("GetUnpairedInputDevices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetUnpairedInputDevices_29);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputDevice)};
            method = type.GetMethod("FindUserPairedToDevice", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindUserPairedToDevice_30);
            args = new Type[]{typeof(UnityEngine.InputSystem.Users.InputUserAccountHandle)};
            method = type.GetMethod("FindUserByAccount", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindUserByAccount_31);
            args = new Type[]{};
            method = type.GetMethod("CreateUserWithoutPairedDevices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateUserWithoutPairedDevices_32);
            args = new Type[]{typeof(UnityEngine.InputSystem.InputDevice), typeof(UnityEngine.InputSystem.Users.InputUser), typeof(UnityEngine.InputSystem.Users.InputUserPairingOptions)};
            method = type.GetMethod("PerformPairingWithDevice", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PerformPairingWithDevice_33);
            args = new Type[]{typeof(UnityEngine.InputSystem.Users.InputUser)};
            method = type.GetMethod("Equals", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Equals_34);
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("Equals", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Equals_35);
            args = new Type[]{};
            method = type.GetMethod("GetHashCode", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetHashCode_36);
            args = new Type[]{typeof(UnityEngine.InputSystem.Users.InputUser), typeof(UnityEngine.InputSystem.Users.InputUser)};
            method = type.GetMethod("op_Equality", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, op_Equality_37);
            args = new Type[]{typeof(UnityEngine.InputSystem.Users.InputUser), typeof(UnityEngine.InputSystem.Users.InputUser)};
            method = type.GetMethod("op_Inequality", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, op_Inequality_38);

            field = type.GetField("InvalidId", flag);
            app.RegisterCLRFieldGetter(field, get_InvalidId_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_InvalidId_0, null);

            app.RegisterCLRMemberwiseClone(type, PerformMemberwiseClone);

            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.InputSystem.Users.InputUser());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.InputSystem.Users.InputUser[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref UnityEngine.InputSystem.Users.InputUser instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.InputSystem.Users.InputUser[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }

        static StackObject* get_valid_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.valid;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_index_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.index;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_id_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.id;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_platformUserAccountHandle_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.platformUserAccountHandle;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_platformUserAccountName_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.platformUserAccountName;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_platformUserAccountId_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.platformUserAccountId;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_pairedDevices_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.pairedDevices;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_lostDevices_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.lostDevices;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_actions_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.actions;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_controlScheme_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.controlScheme;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_controlSchemeMatch_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.controlSchemeMatch;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_hasMissingRequiredDevices_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.hasMissingRequiredDevices;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_all_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.InputSystem.Users.InputUser.all;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* add_onChange_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.InputSystem.Users.InputUser, UnityEngine.InputSystem.Users.InputUserChange, UnityEngine.InputSystem.InputDevice> @value = (System.Action<UnityEngine.InputSystem.Users.InputUser, UnityEngine.InputSystem.Users.InputUserChange, UnityEngine.InputSystem.InputDevice>)typeof(System.Action<UnityEngine.InputSystem.Users.InputUser, UnityEngine.InputSystem.Users.InputUserChange, UnityEngine.InputSystem.InputDevice>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.Users.InputUser.onChange += value;

            return __ret;
        }

        static StackObject* remove_onChange_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.InputSystem.Users.InputUser, UnityEngine.InputSystem.Users.InputUserChange, UnityEngine.InputSystem.InputDevice> @value = (System.Action<UnityEngine.InputSystem.Users.InputUser, UnityEngine.InputSystem.Users.InputUserChange, UnityEngine.InputSystem.InputDevice>)typeof(System.Action<UnityEngine.InputSystem.Users.InputUser, UnityEngine.InputSystem.Users.InputUserChange, UnityEngine.InputSystem.InputDevice>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.Users.InputUser.onChange -= value;

            return __ret;
        }

        static StackObject* add_onUnpairedDeviceUsed_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr> @value = (System.Action<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr>)typeof(System.Action<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.Users.InputUser.onUnpairedDeviceUsed += value;

            return __ret;
        }

        static StackObject* remove_onUnpairedDeviceUsed_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr> @value = (System.Action<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr>)typeof(System.Action<UnityEngine.InputSystem.InputControl, UnityEngine.InputSystem.LowLevel.InputEventPtr>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.Users.InputUser.onUnpairedDeviceUsed -= value;

            return __ret;
        }

        static StackObject* add_onPrefilterUnpairedDeviceActivity_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Func<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr, System.Boolean> @value = (System.Func<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr, System.Boolean>)typeof(System.Func<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr, System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.Users.InputUser.onPrefilterUnpairedDeviceActivity += value;

            return __ret;
        }

        static StackObject* remove_onPrefilterUnpairedDeviceActivity_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Func<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr, System.Boolean> @value = (System.Func<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr, System.Boolean>)typeof(System.Func<UnityEngine.InputSystem.InputDevice, UnityEngine.InputSystem.LowLevel.InputEventPtr, System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);


            UnityEngine.InputSystem.Users.InputUser.onPrefilterUnpairedDeviceActivity -= value;

            return __ret;
        }

        static StackObject* get_listenForUnpairedDeviceActivity_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.InputSystem.Users.InputUser.listenForUnpairedDeviceActivity;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_listenForUnpairedDeviceActivity_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @value = ptr_of_this_method->Value;


            UnityEngine.InputSystem.Users.InputUser.listenForUnpairedDeviceActivity = value;

            return __ret;
        }

        static StackObject* ToString_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.ToString();

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* AssociateActionsWithUser_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.IInputActionCollection @actions = (UnityEngine.InputSystem.IInputActionCollection)typeof(UnityEngine.InputSystem.IInputActionCollection).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            instance_of_this_method.AssociateActionsWithUser(@actions);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* ActivateControlScheme_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @schemeName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.ActivateControlScheme(@schemeName);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ActivateControlScheme_24(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputControlScheme @scheme = (UnityEngine.InputSystem.InputControlScheme)typeof(UnityEngine.InputSystem.InputControlScheme).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.ActivateControlScheme(@scheme);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* UnpairDevice_25(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputDevice @device = (UnityEngine.InputSystem.InputDevice)typeof(UnityEngine.InputSystem.InputDevice).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            instance_of_this_method.UnpairDevice(@device);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* UnpairDevices_26(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            instance_of_this_method.UnpairDevices();

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* UnpairDevicesAndRemoveUser_27(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            instance_of_this_method.UnpairDevicesAndRemoveUser();

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            return __ret;
        }

        static StackObject* GetUnpairedInputDevices_28(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.InputSystem.Users.InputUser.GetUnpairedInputDevices();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetUnpairedInputDevices_29(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice> @list = (UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice>)typeof(UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice>).CheckCLRTypes(__intp.RetriveObject(ptr_of_this_method, __mStack), (CLR.Utils.Extensions.TypeFlags)16);


            var result_of_this_method = UnityEngine.InputSystem.Users.InputUser.GetUnpairedInputDevices(ref @list);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.StackObjectReference:
                    {
                        var ___dst = ILIntepreter.ResolveReference(ptr_of_this_method);
                        object ___obj = @list;
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
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = @list;
                        }
                        else
                        {
                            var ___type = __domain.GetType(___obj.GetType()) as CLRType;
                            ___type.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, @list);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var ___type = __domain.GetType(ptr_of_this_method->Value);
                        if(___type is ILType)
                        {
                            ((ILType)___type).StaticInstance[ptr_of_this_method->ValueLow] = @list;
                        }
                        else
                        {
                            ((CLRType)___type).SetStaticFieldValue(ptr_of_this_method->ValueLow, @list);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as UnityEngine.InputSystem.InputControlList<UnityEngine.InputSystem.InputDevice>[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = @list;
                    }
                    break;
            }

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* FindUserPairedToDevice_30(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.InputDevice @device = (UnityEngine.InputSystem.InputDevice)typeof(UnityEngine.InputSystem.InputDevice).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.Users.InputUser.FindUserPairedToDevice(@device);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* FindUserByAccount_31(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Users.InputUserAccountHandle @platformUserAccountHandle = (UnityEngine.InputSystem.Users.InputUserAccountHandle)typeof(UnityEngine.InputSystem.Users.InputUserAccountHandle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.Users.InputUser.FindUserByAccount(@platformUserAccountHandle);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateUserWithoutPairedDevices_32(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.InputSystem.Users.InputUser.CreateUserWithoutPairedDevices();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* PerformPairingWithDevice_33(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Users.InputUserPairingOptions @options = (UnityEngine.InputSystem.Users.InputUserPairingOptions)typeof(UnityEngine.InputSystem.Users.InputUserPairingOptions).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.Users.InputUser @user = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.InputSystem.InputDevice @device = (UnityEngine.InputSystem.InputDevice)typeof(UnityEngine.InputSystem.InputDevice).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = UnityEngine.InputSystem.Users.InputUser.PerformPairingWithDevice(@device, @user, @options);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Equals_34(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Users.InputUser @other = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.Equals(@other);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Equals_35(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object @obj = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.Equals(@obj);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* GetHashCode_36(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            UnityEngine.InputSystem.Users.InputUser instance_of_this_method = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);

            var result_of_this_method = instance_of_this_method.GetHashCode();

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            WriteBackInstance(__domain, ptr_of_this_method, __mStack, ref instance_of_this_method);

            __intp.Free(ptr_of_this_method);
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* op_Equality_37(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Users.InputUser @right = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.Users.InputUser @left = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = left == right;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* op_Inequality_38(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.InputSystem.Users.InputUser @right = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.InputSystem.Users.InputUser @left = (UnityEngine.InputSystem.Users.InputUser)typeof(UnityEngine.InputSystem.Users.InputUser).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = left != right;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }


        static object get_InvalidId_0(ref object o)
        {
            return UnityEngine.InputSystem.Users.InputUser.InvalidId;
        }

        static StackObject* CopyToStack_InvalidId_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.InputSystem.Users.InputUser.InvalidId;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = (int)result_of_this_method;
            return __ret + 1;
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new UnityEngine.InputSystem.Users.InputUser();
            ins = (UnityEngine.InputSystem.Users.InputUser)o;
            return ins;
        }


    }
}

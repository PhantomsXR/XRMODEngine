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
    unsafe class Phantom_XRMOD_GameServices_Runtime_VoiceNotificationKey_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey);

            field = type.GetField("OnParticipantAdded", flag);
            app.RegisterCLRFieldGetter(field, get_OnParticipantAdded_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnParticipantAdded_0, null);
            field = type.GetField("OnParticipantRemoved", flag);
            app.RegisterCLRFieldGetter(field, get_OnParticipantRemoved_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnParticipantRemoved_1, null);
            field = type.GetField("OnDirectedMessageEdited", flag);
            app.RegisterCLRFieldGetter(field, get_OnDirectedMessageEdited_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnDirectedMessageEdited_2, null);
            field = type.GetField("OnDirectedMessageDeleted", flag);
            app.RegisterCLRFieldGetter(field, get_OnDirectedMessageDeleted_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnDirectedMessageDeleted_3, null);
            field = type.GetField("OnDirectedMessageReceived", flag);
            app.RegisterCLRFieldGetter(field, get_OnDirectedMessageReceived_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnDirectedMessageReceived_4, null);
            field = type.GetField("OnChannelMessageDeleted", flag);
            app.RegisterCLRFieldGetter(field, get_OnChannelMessageDeleted_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnChannelMessageDeleted_5, null);
            field = type.GetField("OnChannelMessageEdited", flag);
            app.RegisterCLRFieldGetter(field, get_OnChannelMessageEdited_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnChannelMessageEdited_6, null);
            field = type.GetField("OnChannelMessageReceived", flag);
            app.RegisterCLRFieldGetter(field, get_OnChannelMessageReceived_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnChannelMessageReceived_7, null);
            field = type.GetField("OnChannelLeft", flag);
            app.RegisterCLRFieldGetter(field, get_OnChannelLeft_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnChannelLeft_8, null);
            field = type.GetField("OnChannelJoined", flag);
            app.RegisterCLRFieldGetter(field, get_OnChannelJoined_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnChannelJoined_9, null);
            field = type.GetField("OnConnectionFailedToRecover", flag);
            app.RegisterCLRFieldGetter(field, get_OnConnectionFailedToRecover_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnConnectionFailedToRecover_10, null);
            field = type.GetField("OnConnectionRecovered", flag);
            app.RegisterCLRFieldGetter(field, get_OnConnectionRecovered_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnConnectionRecovered_11, null);
            field = type.GetField("OnConnectionRecovering", flag);
            app.RegisterCLRFieldGetter(field, get_OnConnectionRecovering_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnConnectionRecovering_12, null);
            field = type.GetField("OnEffectiveOutputDeviceChanged", flag);
            app.RegisterCLRFieldGetter(field, get_OnEffectiveOutputDeviceChanged_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnEffectiveOutputDeviceChanged_13, null);
            field = type.GetField("OnAvailableOutputDevicesChanged", flag);
            app.RegisterCLRFieldGetter(field, get_OnAvailableOutputDevicesChanged_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnAvailableOutputDevicesChanged_14, null);
            field = type.GetField("OnEffectiveInputDeviceChanged", flag);
            app.RegisterCLRFieldGetter(field, get_OnEffectiveInputDeviceChanged_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnEffectiveInputDeviceChanged_15, null);
            field = type.GetField("OnAvailableInputDevicesChanged", flag);
            app.RegisterCLRFieldGetter(field, get_OnAvailableInputDevicesChanged_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnAvailableInputDevicesChanged_16, null);
            field = type.GetField("OnLoginFailed", flag);
            app.RegisterCLRFieldGetter(field, get_OnLoginFailed_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnLoginFailed_17, null);
            field = type.GetField("OnLogged", flag);
            app.RegisterCLRFieldGetter(field, get_OnLogged_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnLogged_18, null);
            field = type.GetField("OnLoggedOut", flag);
            app.RegisterCLRFieldGetter(field, get_OnLoggedOut_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnLoggedOut_19, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey instance_of_this_method)
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
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_OnParticipantAdded_0(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnParticipantAdded;
        }

        static StackObject* CopyToStack_OnParticipantAdded_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnParticipantAdded;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OnParticipantRemoved_1(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnParticipantRemoved;
        }

        static StackObject* CopyToStack_OnParticipantRemoved_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnParticipantRemoved;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OnDirectedMessageEdited_2(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnDirectedMessageEdited;
        }

        static StackObject* CopyToStack_OnDirectedMessageEdited_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnDirectedMessageEdited;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OnDirectedMessageDeleted_3(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnDirectedMessageDeleted;
        }

        static StackObject* CopyToStack_OnDirectedMessageDeleted_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnDirectedMessageDeleted;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OnDirectedMessageReceived_4(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnDirectedMessageReceived;
        }

        static StackObject* CopyToStack_OnDirectedMessageReceived_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnDirectedMessageReceived;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OnChannelMessageDeleted_5(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnChannelMessageDeleted;
        }

        static StackObject* CopyToStack_OnChannelMessageDeleted_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnChannelMessageDeleted;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OnChannelMessageEdited_6(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnChannelMessageEdited;
        }

        static StackObject* CopyToStack_OnChannelMessageEdited_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnChannelMessageEdited;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OnChannelMessageReceived_7(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnChannelMessageReceived;
        }

        static StackObject* CopyToStack_OnChannelMessageReceived_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnChannelMessageReceived;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OnChannelLeft_8(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnChannelLeft;
        }

        static StackObject* CopyToStack_OnChannelLeft_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnChannelLeft;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OnChannelJoined_9(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnChannelJoined;
        }

        static StackObject* CopyToStack_OnChannelJoined_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnChannelJoined;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OnConnectionFailedToRecover_10(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnConnectionFailedToRecover;
        }

        static StackObject* CopyToStack_OnConnectionFailedToRecover_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnConnectionFailedToRecover;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OnConnectionRecovered_11(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnConnectionRecovered;
        }

        static StackObject* CopyToStack_OnConnectionRecovered_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnConnectionRecovered;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OnConnectionRecovering_12(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnConnectionRecovering;
        }

        static StackObject* CopyToStack_OnConnectionRecovering_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnConnectionRecovering;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OnEffectiveOutputDeviceChanged_13(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnEffectiveOutputDeviceChanged;
        }

        static StackObject* CopyToStack_OnEffectiveOutputDeviceChanged_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnEffectiveOutputDeviceChanged;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OnAvailableOutputDevicesChanged_14(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnAvailableOutputDevicesChanged;
        }

        static StackObject* CopyToStack_OnAvailableOutputDevicesChanged_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnAvailableOutputDevicesChanged;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OnEffectiveInputDeviceChanged_15(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnEffectiveInputDeviceChanged;
        }

        static StackObject* CopyToStack_OnEffectiveInputDeviceChanged_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnEffectiveInputDeviceChanged;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OnAvailableInputDevicesChanged_16(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnAvailableInputDevicesChanged;
        }

        static StackObject* CopyToStack_OnAvailableInputDevicesChanged_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnAvailableInputDevicesChanged;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OnLoginFailed_17(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnLoginFailed;
        }

        static StackObject* CopyToStack_OnLoginFailed_17(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnLoginFailed;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OnLogged_18(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnLogged;
        }

        static StackObject* CopyToStack_OnLogged_18(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnLogged;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OnLoggedOut_19(ref object o)
        {
            return Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnLoggedOut;
        }

        static StackObject* CopyToStack_OnLoggedOut_19(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey.OnLoggedOut;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey();
            ins = (Phantom.XRMOD.GameServices.Runtime.VoiceNotificationKey)o;
            return ins;
        }


    }
}

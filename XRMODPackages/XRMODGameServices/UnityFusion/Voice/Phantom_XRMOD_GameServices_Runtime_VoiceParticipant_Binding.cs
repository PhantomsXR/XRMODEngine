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
    unsafe class Phantom_XRMOD_GameServices_Runtime_VoiceParticipant_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.GameServices.Runtime.VoiceParticipant);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("SetLocalVolume", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetLocalVolume_0);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("SetOutputVolume", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetOutputVolume_1);
            args = new Type[]{};
            method = type.GetMethod("MuteUserLocally", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MuteUserLocally_2);
            args = new Type[]{};
            method = type.GetMethod("UnmuteUserLocally", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UnmuteUserLocally_3);

            field = type.GetField("ParticipantMuteStateChanged", flag);
            app.RegisterCLRFieldGetter(field, get_ParticipantMuteStateChanged_0);
            app.RegisterCLRFieldSetter(field, set_ParticipantMuteStateChanged_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_ParticipantMuteStateChanged_0, AssignFromStack_ParticipantMuteStateChanged_0);
            field = type.GetField("ParticipantSpeechDetected", flag);
            app.RegisterCLRFieldGetter(field, get_ParticipantSpeechDetected_1);
            app.RegisterCLRFieldSetter(field, set_ParticipantSpeechDetected_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_ParticipantSpeechDetected_1, AssignFromStack_ParticipantSpeechDetected_1);
            field = type.GetField("ParticipantAudioEnergyChanged", flag);
            app.RegisterCLRFieldGetter(field, get_ParticipantAudioEnergyChanged_2);
            app.RegisterCLRFieldSetter(field, set_ParticipantAudioEnergyChanged_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_ParticipantAudioEnergyChanged_2, AssignFromStack_ParticipantAudioEnergyChanged_2);
            field = type.GetField("DisplayName", flag);
            app.RegisterCLRFieldGetter(field, get_DisplayName_3);
            app.RegisterCLRFieldSetter(field, set_DisplayName_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_DisplayName_3, AssignFromStack_DisplayName_3);
            field = type.GetField("UserId", flag);
            app.RegisterCLRFieldGetter(field, get_UserId_4);
            app.RegisterCLRFieldSetter(field, set_UserId_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_UserId_4, AssignFromStack_UserId_4);
            field = type.GetField("URI", flag);
            app.RegisterCLRFieldGetter(field, get_URI_5);
            app.RegisterCLRFieldSetter(field, set_URI_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_URI_5, AssignFromStack_URI_5);
            field = type.GetField("ChannelName", flag);
            app.RegisterCLRFieldGetter(field, get_ChannelName_6);
            app.RegisterCLRFieldSetter(field, set_ChannelName_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_ChannelName_6, AssignFromStack_ChannelName_6);
            field = type.GetField("ChannelURI", flag);
            app.RegisterCLRFieldGetter(field, get_ChannelURI_7);
            app.RegisterCLRFieldSetter(field, set_ChannelURI_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_ChannelURI_7, AssignFromStack_ChannelURI_7);
            field = type.GetField("SpeechDetected", flag);
            app.RegisterCLRFieldGetter(field, get_SpeechDetected_8);
            app.RegisterCLRFieldSetter(field, set_SpeechDetected_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_SpeechDetected_8, AssignFromStack_SpeechDetected_8);
            field = type.GetField("IsMuted", flag);
            app.RegisterCLRFieldGetter(field, get_IsMuted_9);
            app.RegisterCLRFieldSetter(field, set_IsMuted_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsMuted_9, AssignFromStack_IsMuted_9);
            field = type.GetField("IsSelf", flag);
            app.RegisterCLRFieldGetter(field, get_IsSelf_10);
            app.RegisterCLRFieldSetter(field, set_IsSelf_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsSelf_10, AssignFromStack_IsSelf_10);
            field = type.GetField("LocalVolume", flag);
            app.RegisterCLRFieldGetter(field, get_LocalVolume_11);
            app.RegisterCLRFieldSetter(field, set_LocalVolume_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_LocalVolume_11, AssignFromStack_LocalVolume_11);
            field = type.GetField("AudioEnergy", flag);
            app.RegisterCLRFieldGetter(field, get_AudioEnergy_12);
            app.RegisterCLRFieldSetter(field, set_AudioEnergy_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_AudioEnergy_12, AssignFromStack_AudioEnergy_12);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.GameServices.Runtime.VoiceParticipant());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.GameServices.Runtime.VoiceParticipant[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* SetLocalVolume_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @_volume = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.GameServices.Runtime.VoiceParticipant instance_of_this_method = (Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)typeof(Phantom.XRMOD.GameServices.Runtime.VoiceParticipant).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetLocalVolume(@_volume);

            return __ret;
        }

        static StackObject* SetOutputVolume_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @_volume = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.GameServices.Runtime.VoiceParticipant instance_of_this_method = (Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)typeof(Phantom.XRMOD.GameServices.Runtime.VoiceParticipant).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetOutputVolume(@_volume);

            return __ret;
        }

        static StackObject* MuteUserLocally_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.GameServices.Runtime.VoiceParticipant instance_of_this_method = (Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)typeof(Phantom.XRMOD.GameServices.Runtime.VoiceParticipant).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.MuteUserLocally();

            return __ret;
        }

        static StackObject* UnmuteUserLocally_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.GameServices.Runtime.VoiceParticipant instance_of_this_method = (Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)typeof(Phantom.XRMOD.GameServices.Runtime.VoiceParticipant).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UnmuteUserLocally();

            return __ret;
        }


        static object get_ParticipantMuteStateChanged_0(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).ParticipantMuteStateChanged;
        }

        static StackObject* CopyToStack_ParticipantMuteStateChanged_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).ParticipantMuteStateChanged;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ParticipantMuteStateChanged_0(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).ParticipantMuteStateChanged = (System.Action)v;
        }

        static StackObject* AssignFromStack_ParticipantMuteStateChanged_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action @ParticipantMuteStateChanged = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).ParticipantMuteStateChanged = @ParticipantMuteStateChanged;
            return ptr_of_this_method;
        }

        static object get_ParticipantSpeechDetected_1(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).ParticipantSpeechDetected;
        }

        static StackObject* CopyToStack_ParticipantSpeechDetected_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).ParticipantSpeechDetected;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ParticipantSpeechDetected_1(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).ParticipantSpeechDetected = (System.Action)v;
        }

        static StackObject* AssignFromStack_ParticipantSpeechDetected_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action @ParticipantSpeechDetected = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).ParticipantSpeechDetected = @ParticipantSpeechDetected;
            return ptr_of_this_method;
        }

        static object get_ParticipantAudioEnergyChanged_2(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).ParticipantAudioEnergyChanged;
        }

        static StackObject* CopyToStack_ParticipantAudioEnergyChanged_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).ParticipantAudioEnergyChanged;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ParticipantAudioEnergyChanged_2(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).ParticipantAudioEnergyChanged = (System.Action)v;
        }

        static StackObject* AssignFromStack_ParticipantAudioEnergyChanged_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action @ParticipantAudioEnergyChanged = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).ParticipantAudioEnergyChanged = @ParticipantAudioEnergyChanged;
            return ptr_of_this_method;
        }

        static object get_DisplayName_3(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).DisplayName;
        }

        static StackObject* CopyToStack_DisplayName_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).DisplayName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_DisplayName_3(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).DisplayName = (System.String)v;
        }

        static StackObject* AssignFromStack_DisplayName_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @DisplayName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).DisplayName = @DisplayName;
            return ptr_of_this_method;
        }

        static object get_UserId_4(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).UserId;
        }

        static StackObject* CopyToStack_UserId_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).UserId;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_UserId_4(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).UserId = (System.String)v;
        }

        static StackObject* AssignFromStack_UserId_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @UserId = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).UserId = @UserId;
            return ptr_of_this_method;
        }

        static object get_URI_5(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).URI;
        }

        static StackObject* CopyToStack_URI_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).URI;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_URI_5(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).URI = (System.String)v;
        }

        static StackObject* AssignFromStack_URI_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @URI = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).URI = @URI;
            return ptr_of_this_method;
        }

        static object get_ChannelName_6(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).ChannelName;
        }

        static StackObject* CopyToStack_ChannelName_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).ChannelName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ChannelName_6(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).ChannelName = (System.String)v;
        }

        static StackObject* AssignFromStack_ChannelName_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @ChannelName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).ChannelName = @ChannelName;
            return ptr_of_this_method;
        }

        static object get_ChannelURI_7(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).ChannelURI;
        }

        static StackObject* CopyToStack_ChannelURI_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).ChannelURI;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ChannelURI_7(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).ChannelURI = (System.String)v;
        }

        static StackObject* AssignFromStack_ChannelURI_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @ChannelURI = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).ChannelURI = @ChannelURI;
            return ptr_of_this_method;
        }

        static object get_SpeechDetected_8(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).SpeechDetected;
        }

        static StackObject* CopyToStack_SpeechDetected_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).SpeechDetected;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SpeechDetected_8(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).SpeechDetected = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SpeechDetected_8(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SpeechDetected = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).SpeechDetected = @SpeechDetected;
            return ptr_of_this_method;
        }

        static object get_IsMuted_9(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).IsMuted;
        }

        static StackObject* CopyToStack_IsMuted_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).IsMuted;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsMuted_9(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).IsMuted = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsMuted_9(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsMuted = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).IsMuted = @IsMuted;
            return ptr_of_this_method;
        }

        static object get_IsSelf_10(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).IsSelf;
        }

        static StackObject* CopyToStack_IsSelf_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).IsSelf;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsSelf_10(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).IsSelf = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsSelf_10(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsSelf = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).IsSelf = @IsSelf;
            return ptr_of_this_method;
        }

        static object get_LocalVolume_11(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).LocalVolume;
        }

        static StackObject* CopyToStack_LocalVolume_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).LocalVolume;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_LocalVolume_11(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).LocalVolume = (System.Int32)v;
        }

        static StackObject* AssignFromStack_LocalVolume_11(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @LocalVolume = ptr_of_this_method->Value;
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).LocalVolume = @LocalVolume;
            return ptr_of_this_method;
        }

        static object get_AudioEnergy_12(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).AudioEnergy;
        }

        static StackObject* CopyToStack_AudioEnergy_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).AudioEnergy;
            __ret->ObjectType = ObjectTypes.Double;
            *(double*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_AudioEnergy_12(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).AudioEnergy = (System.Double)v;
        }

        static StackObject* AssignFromStack_AudioEnergy_12(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Double @AudioEnergy = *(double*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.GameServices.Runtime.VoiceParticipant)o).AudioEnergy = @AudioEnergy;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.GameServices.Runtime.VoiceParticipant();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

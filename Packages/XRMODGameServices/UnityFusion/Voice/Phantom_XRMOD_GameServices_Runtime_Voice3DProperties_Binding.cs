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
    unsafe class Phantom_XRMOD_GameServices_Runtime_Voice3DProperties_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.GameServices.Runtime.Voice3DProperties);

            field = type.GetField("AudibleDistance", flag);
            app.RegisterCLRFieldGetter(field, get_AudibleDistance_0);
            app.RegisterCLRFieldSetter(field, set_AudibleDistance_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_AudibleDistance_0, AssignFromStack_AudibleDistance_0);
            field = type.GetField("ConversationalDistance", flag);
            app.RegisterCLRFieldGetter(field, get_ConversationalDistance_1);
            app.RegisterCLRFieldSetter(field, set_ConversationalDistance_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_ConversationalDistance_1, AssignFromStack_ConversationalDistance_1);
            field = type.GetField("AudioFadeIntensityByDistance", flag);
            app.RegisterCLRFieldGetter(field, get_AudioFadeIntensityByDistance_2);
            app.RegisterCLRFieldSetter(field, set_AudioFadeIntensityByDistance_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_AudioFadeIntensityByDistance_2, AssignFromStack_AudioFadeIntensityByDistance_2);
            field = type.GetField("AudioFadeModel", flag);
            app.RegisterCLRFieldGetter(field, get_AudioFadeModel_3);
            app.RegisterCLRFieldSetter(field, set_AudioFadeModel_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_AudioFadeModel_3, AssignFromStack_AudioFadeModel_3);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.GameServices.Runtime.Voice3DProperties());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.GameServices.Runtime.Voice3DProperties[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_AudibleDistance_0(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.Voice3DProperties)o).AudibleDistance;
        }

        static StackObject* CopyToStack_AudibleDistance_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.Voice3DProperties)o).AudibleDistance;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_AudibleDistance_0(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.Voice3DProperties)o).AudibleDistance = (System.Int32)v;
        }

        static StackObject* AssignFromStack_AudibleDistance_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @AudibleDistance = ptr_of_this_method->Value;
            ((Phantom.XRMOD.GameServices.Runtime.Voice3DProperties)o).AudibleDistance = @AudibleDistance;
            return ptr_of_this_method;
        }

        static object get_ConversationalDistance_1(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.Voice3DProperties)o).ConversationalDistance;
        }

        static StackObject* CopyToStack_ConversationalDistance_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.Voice3DProperties)o).ConversationalDistance;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_ConversationalDistance_1(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.Voice3DProperties)o).ConversationalDistance = (System.Int32)v;
        }

        static StackObject* AssignFromStack_ConversationalDistance_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @ConversationalDistance = ptr_of_this_method->Value;
            ((Phantom.XRMOD.GameServices.Runtime.Voice3DProperties)o).ConversationalDistance = @ConversationalDistance;
            return ptr_of_this_method;
        }

        static object get_AudioFadeIntensityByDistance_2(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.Voice3DProperties)o).AudioFadeIntensityByDistance;
        }

        static StackObject* CopyToStack_AudioFadeIntensityByDistance_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.Voice3DProperties)o).AudioFadeIntensityByDistance;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_AudioFadeIntensityByDistance_2(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.Voice3DProperties)o).AudioFadeIntensityByDistance = (System.Single)v;
        }

        static StackObject* AssignFromStack_AudioFadeIntensityByDistance_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @AudioFadeIntensityByDistance = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.GameServices.Runtime.Voice3DProperties)o).AudioFadeIntensityByDistance = @AudioFadeIntensityByDistance;
            return ptr_of_this_method;
        }

        static object get_AudioFadeModel_3(ref object o)
        {
            return ((Phantom.XRMOD.GameServices.Runtime.Voice3DProperties)o).AudioFadeModel;
        }

        static StackObject* CopyToStack_AudioFadeModel_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.GameServices.Runtime.Voice3DProperties)o).AudioFadeModel;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AudioFadeModel_3(ref object o, object v)
        {
            ((Phantom.XRMOD.GameServices.Runtime.Voice3DProperties)o).AudioFadeModel = (Phantom.XRMOD.GameServices.Runtime.VoiceAudioFadeModel)v;
        }

        static StackObject* AssignFromStack_AudioFadeModel_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.GameServices.Runtime.VoiceAudioFadeModel @AudioFadeModel = (Phantom.XRMOD.GameServices.Runtime.VoiceAudioFadeModel)typeof(Phantom.XRMOD.GameServices.Runtime.VoiceAudioFadeModel).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Phantom.XRMOD.GameServices.Runtime.Voice3DProperties)o).AudioFadeModel = @AudioFadeModel;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.GameServices.Runtime.Voice3DProperties();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

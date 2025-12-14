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
    unsafe class Phantom_XRMOD_AudioModule_Runtime_AudioClipData_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.AudioModule.Runtime.AudioClipData);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("Initialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Initialize_0);
            args = new Type[]{typeof(System.Single), typeof(System.Single), typeof(System.Boolean), typeof(UnityEngine.AudioClip[])};
            method = type.GetMethod("Initialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Initialize_1);
            args = new Type[]{};
            method = type.GetMethod("GetAudioClip", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetAudioClip_2);
            args = new Type[]{};
            method = type.GetMethod("GetPitchOffset", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetPitchOffset_3);



            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.AudioModule.Runtime.AudioClipData());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.AudioModule.Runtime.AudioClipData[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Initialize_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @_loadIntoMemory = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.AudioModule.Runtime.AudioClipData instance_of_this_method = (Phantom.XRMOD.AudioModule.Runtime.AudioClipData)typeof(Phantom.XRMOD.AudioModule.Runtime.AudioClipData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Initialize(@_loadIntoMemory);

            return __ret;
        }

        static StackObject* Initialize_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 5);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioClip[] @_audioClips = (UnityEngine.AudioClip[])typeof(UnityEngine.AudioClip[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Boolean @_loadIntoMemory = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @_pitchVariation = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Single @_pitchBase = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            Phantom.XRMOD.AudioModule.Runtime.AudioClipData instance_of_this_method = (Phantom.XRMOD.AudioModule.Runtime.AudioClipData)typeof(Phantom.XRMOD.AudioModule.Runtime.AudioClipData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Initialize(@_pitchBase, @_pitchVariation, @_loadIntoMemory, @_audioClips);

            return __ret;
        }

        static StackObject* GetAudioClip_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.AudioModule.Runtime.AudioClipData instance_of_this_method = (Phantom.XRMOD.AudioModule.Runtime.AudioClipData)typeof(Phantom.XRMOD.AudioModule.Runtime.AudioClipData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetAudioClip();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetPitchOffset_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.AudioModule.Runtime.AudioClipData instance_of_this_method = (Phantom.XRMOD.AudioModule.Runtime.AudioClipData)typeof(Phantom.XRMOD.AudioModule.Runtime.AudioClipData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetPitchOffset();

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.AudioModule.Runtime.AudioClipData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

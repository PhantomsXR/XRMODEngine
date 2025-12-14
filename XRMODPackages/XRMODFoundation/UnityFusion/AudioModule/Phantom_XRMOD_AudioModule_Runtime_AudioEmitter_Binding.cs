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
    unsafe class Phantom_XRMOD_AudioModule_Runtime_AudioEmitter_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.AudioModule.Runtime.AudioEmitter);
            args = new Type[]{};
            method = type.GetMethod("get_AudioSource", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_AudioSource_0);
            args = new Type[]{};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_1);
            args = new Type[]{typeof(Phantom.XRMOD.AudioModule.Runtime.AudioClipData)};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_2);
            args = new Type[]{};
            method = type.GetMethod("Stop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Stop_3);
            args = new Type[]{};
            method = type.GetMethod("PlayOneShot", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PlayOneShot_4);
            args = new Type[]{typeof(Phantom.XRMOD.AudioModule.Runtime.AudioClipData)};
            method = type.GetMethod("PlayOneShot", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PlayOneShot_5);
            args = new Type[]{typeof(Phantom.XRMOD.AudioModule.Runtime.AudioClipData)};
            method = type.GetMethod("SetAudioClipData", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAudioClipData_6);



            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.AudioModule.Runtime.AudioEmitter());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.AudioModule.Runtime.AudioEmitter[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_AudioSource_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.AudioModule.Runtime.AudioEmitter instance_of_this_method = (Phantom.XRMOD.AudioModule.Runtime.AudioEmitter)typeof(Phantom.XRMOD.AudioModule.Runtime.AudioEmitter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AudioSource;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Play_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.AudioModule.Runtime.AudioEmitter instance_of_this_method = (Phantom.XRMOD.AudioModule.Runtime.AudioEmitter)typeof(Phantom.XRMOD.AudioModule.Runtime.AudioEmitter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play();

            return __ret;
        }

        static StackObject* Play_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.AudioModule.Runtime.AudioClipData @_audioClipData = (Phantom.XRMOD.AudioModule.Runtime.AudioClipData)typeof(Phantom.XRMOD.AudioModule.Runtime.AudioClipData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.AudioModule.Runtime.AudioEmitter instance_of_this_method = (Phantom.XRMOD.AudioModule.Runtime.AudioEmitter)typeof(Phantom.XRMOD.AudioModule.Runtime.AudioEmitter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play(@_audioClipData);

            return __ret;
        }

        static StackObject* Stop_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.AudioModule.Runtime.AudioEmitter instance_of_this_method = (Phantom.XRMOD.AudioModule.Runtime.AudioEmitter)typeof(Phantom.XRMOD.AudioModule.Runtime.AudioEmitter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Stop();

            return __ret;
        }

        static StackObject* PlayOneShot_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.AudioModule.Runtime.AudioEmitter instance_of_this_method = (Phantom.XRMOD.AudioModule.Runtime.AudioEmitter)typeof(Phantom.XRMOD.AudioModule.Runtime.AudioEmitter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PlayOneShot();

            return __ret;
        }

        static StackObject* PlayOneShot_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.AudioModule.Runtime.AudioClipData @_audioClip = (Phantom.XRMOD.AudioModule.Runtime.AudioClipData)typeof(Phantom.XRMOD.AudioModule.Runtime.AudioClipData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.AudioModule.Runtime.AudioEmitter instance_of_this_method = (Phantom.XRMOD.AudioModule.Runtime.AudioEmitter)typeof(Phantom.XRMOD.AudioModule.Runtime.AudioEmitter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PlayOneShot(@_audioClip);

            return __ret;
        }

        static StackObject* SetAudioClipData_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.AudioModule.Runtime.AudioClipData @_audioClipData = (Phantom.XRMOD.AudioModule.Runtime.AudioClipData)typeof(Phantom.XRMOD.AudioModule.Runtime.AudioClipData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.AudioModule.Runtime.AudioEmitter instance_of_this_method = (Phantom.XRMOD.AudioModule.Runtime.AudioEmitter)typeof(Phantom.XRMOD.AudioModule.Runtime.AudioEmitter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetAudioClipData(@_audioClipData);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.AudioModule.Runtime.AudioEmitter();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

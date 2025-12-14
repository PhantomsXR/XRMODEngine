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
    unsafe class Phantom_XRMOD_UIFramework_Runtime_AnimationUICustomizable_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.UIFramework.Runtime.AnimationUICustomizable);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("SetActiveAllInput", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetActiveAllInput_0);
            args = new Type[]{typeof(UnityEngine.AudioClip)};
            method = type.GetMethod("PlaySound", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PlaySound_1);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("PlaySound", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PlaySound_2);





        }


        static StackObject* SetActiveAllInput_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @_isActivating = ptr_of_this_method->Value == 1;


            Phantom.XRMOD.UIFramework.Runtime.AnimationUICustomizable.SetActiveAllInput(@_isActivating);

            return __ret;
        }

        static StackObject* PlaySound_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.AudioClip @_sfxFile = (UnityEngine.AudioClip)typeof(UnityEngine.AudioClip).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Phantom.XRMOD.UIFramework.Runtime.AnimationUICustomizable.PlaySound(@_sfxFile);

            return __ret;
        }

        static StackObject* PlaySound_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @_index = ptr_of_this_method->Value;


            Phantom.XRMOD.UIFramework.Runtime.AnimationUICustomizable.PlaySound(@_index);

            return __ret;
        }





    }
}

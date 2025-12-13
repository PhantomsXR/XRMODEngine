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
    unsafe class Phantom_XRMOD_UIFramework_Runtime_Grabber_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.UIFramework.Runtime.Grabber);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs)};
            method = type.GetMethod("OnSelectEntered", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnSelectEntered_0);
            args = new Type[]{typeof(UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs)};
            method = type.GetMethod("OnSelectExited", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnSelectExited_1);
            args = new Type[]{typeof(UnityEngine.EventSystems.PointerEventData)};
            method = type.GetMethod("OnDrag", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnDrag_2);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("SetReferences", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetReferences_3);



            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.UIFramework.Runtime.Grabber());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.UIFramework.Runtime.Grabber[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* OnSelectEntered_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs @eventData = (UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs)typeof(UnityEngine.XR.Interaction.Toolkit.SelectEnterEventArgs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.Grabber instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.Grabber)typeof(Phantom.XRMOD.UIFramework.Runtime.Grabber).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnSelectEntered(@eventData);

            return __ret;
        }

        static StackObject* OnSelectExited_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs @eventData = (UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs)typeof(UnityEngine.XR.Interaction.Toolkit.SelectExitEventArgs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.Grabber instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.Grabber)typeof(Phantom.XRMOD.UIFramework.Runtime.Grabber).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnSelectExited(@eventData);

            return __ret;
        }

        static StackObject* OnDrag_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.EventSystems.PointerEventData @eventData = (UnityEngine.EventSystems.PointerEventData)typeof(UnityEngine.EventSystems.PointerEventData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.Grabber instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.Grabber)typeof(Phantom.XRMOD.UIFramework.Runtime.Grabber).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnDrag(@eventData);

            return __ret;
        }

        static StackObject* SetReferences_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @windowTransform = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.Grabber instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.Grabber)typeof(Phantom.XRMOD.UIFramework.Runtime.Grabber).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetReferences(@windowTransform);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.UIFramework.Runtime.Grabber();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
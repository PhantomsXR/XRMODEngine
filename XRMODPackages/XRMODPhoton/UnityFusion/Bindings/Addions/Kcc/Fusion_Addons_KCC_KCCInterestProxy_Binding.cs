#if FUSION2 && XRMOD_INSTALL

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
    unsafe class Fusion_Addons_KCC_KCCInterestProxy_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Fusion.Addons.KCC.KCCInterestProxy);
            args = new Type[]{};
            method = type.GetMethod("get_PositionSource", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_PositionSource_0);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("SetPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPosition_1);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("SetPositionSource", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetPositionSource_2);
            args = new Type[]{};
            method = type.GetMethod("ResetPositionSource", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResetPositionSource_3);
            args = new Type[]{};
            method = type.GetMethod("FindPositionSourceInParent", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FindPositionSourceInParent_4);
            args = new Type[]{};
            method = type.GetMethod("Synchronize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Synchronize_5);
            args = new Type[]{};
            method = type.GetMethod("Spawned", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Spawned_6);
            args = new Type[]{typeof(Fusion.NetworkRunner), typeof(System.Boolean)};
            method = type.GetMethod("Despawned", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Despawned_7);
            args = new Type[]{};
            method = type.GetMethod("FixedUpdateNetwork", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FixedUpdateNetwork_8);



            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.KCCInterestProxy());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.KCCInterestProxy[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_PositionSource_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCInterestProxy instance_of_this_method = (Fusion.Addons.KCC.KCCInterestProxy)typeof(Fusion.Addons.KCC.KCCInterestProxy).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.PositionSource;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetPosition_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @position = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCInterestProxy instance_of_this_method = (Fusion.Addons.KCC.KCCInterestProxy)typeof(Fusion.Addons.KCC.KCCInterestProxy).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPosition(@position);

            return __ret;
        }

        static StackObject* SetPositionSource_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @positionSource = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCInterestProxy instance_of_this_method = (Fusion.Addons.KCC.KCCInterestProxy)typeof(Fusion.Addons.KCC.KCCInterestProxy).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetPositionSource(@positionSource);

            return __ret;
        }

        static StackObject* ResetPositionSource_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCInterestProxy instance_of_this_method = (Fusion.Addons.KCC.KCCInterestProxy)typeof(Fusion.Addons.KCC.KCCInterestProxy).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ResetPositionSource();

            return __ret;
        }

        static StackObject* FindPositionSourceInParent_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCInterestProxy instance_of_this_method = (Fusion.Addons.KCC.KCCInterestProxy)typeof(Fusion.Addons.KCC.KCCInterestProxy).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.FindPositionSourceInParent();

            return __ret;
        }

        static StackObject* Synchronize_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCInterestProxy instance_of_this_method = (Fusion.Addons.KCC.KCCInterestProxy)typeof(Fusion.Addons.KCC.KCCInterestProxy).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Synchronize();

            return __ret;
        }

        static StackObject* Spawned_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCInterestProxy instance_of_this_method = (Fusion.Addons.KCC.KCCInterestProxy)typeof(Fusion.Addons.KCC.KCCInterestProxy).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Spawned();

            return __ret;
        }

        static StackObject* Despawned_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @hasState = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.NetworkRunner @runner = (Fusion.NetworkRunner)typeof(Fusion.NetworkRunner).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.Addons.KCC.KCCInterestProxy instance_of_this_method = (Fusion.Addons.KCC.KCCInterestProxy)typeof(Fusion.Addons.KCC.KCCInterestProxy).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Despawned(@runner, @hasState);

            return __ret;
        }

        static StackObject* FixedUpdateNetwork_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCInterestProxy instance_of_this_method = (Fusion.Addons.KCC.KCCInterestProxy)typeof(Fusion.Addons.KCC.KCCInterestProxy).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.FixedUpdateNetwork();

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Addons.KCC.KCCInterestProxy();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
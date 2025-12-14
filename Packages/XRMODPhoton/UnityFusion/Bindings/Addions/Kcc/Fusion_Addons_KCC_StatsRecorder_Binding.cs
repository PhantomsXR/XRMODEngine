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
    unsafe class Fusion_Addons_KCC_StatsRecorder_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Fusion.Addons.KCC.StatsRecorder);
            args = new Type[]{};
            method = type.GetMethod("get_IsActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsActive_0);
            args = new Type[]{typeof(Fusion.Addons.KCC.ERecorderType)};
            method = type.GetMethod("IsSupported", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsSupported_1);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("SetActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetActive_2);
            args = new Type[]{typeof(Fusion.Addons.KCC.ERecorderType)};
            method = type.GetMethod("SetActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetActive_3);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("SetReferenceRefreshRate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetReferenceRefreshRate_4);
            args = new Type[]{};
            method = type.GetMethod("Spawned", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Spawned_5);
            args = new Type[]{typeof(Fusion.NetworkRunner), typeof(System.Boolean)};
            method = type.GetMethod("Despawned", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Despawned_6);
            args = new Type[]{};
            method = type.GetMethod("FixedUpdateNetwork", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, FixedUpdateNetwork_7);
            args = new Type[]{};
            method = type.GetMethod("Render", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Render_8);



            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.StatsRecorder[s]);


        }


        static StackObject* get_IsActive_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.StatsRecorder instance_of_this_method = (Fusion.Addons.KCC.StatsRecorder)typeof(Fusion.Addons.KCC.StatsRecorder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsActive;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsSupported_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.ERecorderType @recorderType = (Fusion.Addons.KCC.ERecorderType)typeof(Fusion.Addons.KCC.ERecorderType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.StatsRecorder instance_of_this_method = (Fusion.Addons.KCC.StatsRecorder)typeof(Fusion.Addons.KCC.StatsRecorder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsSupported(@recorderType);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetActive_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @isActive = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.StatsRecorder instance_of_this_method = (Fusion.Addons.KCC.StatsRecorder)typeof(Fusion.Addons.KCC.StatsRecorder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetActive(@isActive);

            return __ret;
        }

        static StackObject* SetActive_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.ERecorderType @recorderType = (Fusion.Addons.KCC.ERecorderType)typeof(Fusion.Addons.KCC.ERecorderType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.StatsRecorder instance_of_this_method = (Fusion.Addons.KCC.StatsRecorder)typeof(Fusion.Addons.KCC.StatsRecorder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetActive(@recorderType);

            return __ret;
        }

        static StackObject* SetReferenceRefreshRate_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @referenceRefreshRate = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.StatsRecorder instance_of_this_method = (Fusion.Addons.KCC.StatsRecorder)typeof(Fusion.Addons.KCC.StatsRecorder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetReferenceRefreshRate(@referenceRefreshRate);

            return __ret;
        }

        static StackObject* Spawned_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.StatsRecorder instance_of_this_method = (Fusion.Addons.KCC.StatsRecorder)typeof(Fusion.Addons.KCC.StatsRecorder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Spawned();

            return __ret;
        }

        static StackObject* Despawned_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            Fusion.Addons.KCC.StatsRecorder instance_of_this_method = (Fusion.Addons.KCC.StatsRecorder)typeof(Fusion.Addons.KCC.StatsRecorder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Despawned(@runner, @hasState);

            return __ret;
        }

        static StackObject* FixedUpdateNetwork_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.StatsRecorder instance_of_this_method = (Fusion.Addons.KCC.StatsRecorder)typeof(Fusion.Addons.KCC.StatsRecorder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.FixedUpdateNetwork();

            return __ret;
        }

        static StackObject* Render_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.StatsRecorder instance_of_this_method = (Fusion.Addons.KCC.StatsRecorder)typeof(Fusion.Addons.KCC.StatsRecorder).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Render();

            return __ret;
        }





    }
}
#endif
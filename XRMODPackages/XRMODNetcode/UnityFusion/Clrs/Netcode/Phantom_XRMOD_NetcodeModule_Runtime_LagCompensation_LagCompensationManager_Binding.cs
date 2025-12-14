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
    unsafe class Phantom_XRMOD_NetcodeModule_Runtime_LagCompensation_LagCompensationManager_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.NetcodeModule.Runtime.LagCompensation.LagCompensationManager);
            args = new Type[]{};
            method = type.GetMethod("get_Singleton", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Singleton_0);
            args = new Type[]{typeof(System.Single), typeof(System.Action)};
            method = type.GetMethod("Simulate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Simulate_1);
            args = new Type[]{typeof(System.Single), typeof(System.Collections.Generic.IList<Phantom.XRMOD.NetcodeModule.Runtime.LagCompensation.TrackedObject>), typeof(System.Action)};
            method = type.GetMethod("Simulate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Simulate_2);
            args = new Type[]{typeof(System.UInt64), typeof(System.Action)};
            method = type.GetMethod("Simulate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Simulate_3);

            field = type.GetField("SimulationObjects", flag);
            app.RegisterCLRFieldGetter(field, get_SimulationObjects_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_SimulationObjects_0, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.NetcodeModule.Runtime.LagCompensation.LagCompensationManager());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.NetcodeModule.Runtime.LagCompensation.LagCompensationManager[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_Singleton_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Phantom.XRMOD.NetcodeModule.Runtime.LagCompensation.LagCompensationManager.Singleton;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Simulate_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @action = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Single @secondsAgo = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.NetcodeModule.Runtime.LagCompensation.LagCompensationManager instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.LagCompensation.LagCompensationManager)typeof(Phantom.XRMOD.NetcodeModule.Runtime.LagCompensation.LagCompensationManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Simulate(@secondsAgo, @action);

            return __ret;
        }

        static StackObject* Simulate_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @action = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.IList<Phantom.XRMOD.NetcodeModule.Runtime.LagCompensation.TrackedObject> @simulatedObjects = (System.Collections.Generic.IList<Phantom.XRMOD.NetcodeModule.Runtime.LagCompensation.TrackedObject>)typeof(System.Collections.Generic.IList<Phantom.XRMOD.NetcodeModule.Runtime.LagCompensation.TrackedObject>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.Single @secondsAgo = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Phantom.XRMOD.NetcodeModule.Runtime.LagCompensation.LagCompensationManager instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.LagCompensation.LagCompensationManager)typeof(Phantom.XRMOD.NetcodeModule.Runtime.LagCompensation.LagCompensationManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Simulate(@secondsAgo, @simulatedObjects, @action);

            return __ret;
        }

        static StackObject* Simulate_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @action = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.UInt64 @clientId = *(ulong*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.NetcodeModule.Runtime.LagCompensation.LagCompensationManager instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.LagCompensation.LagCompensationManager)typeof(Phantom.XRMOD.NetcodeModule.Runtime.LagCompensation.LagCompensationManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Simulate(@clientId, @action);

            return __ret;
        }


        static object get_SimulationObjects_0(ref object o)
        {
            return ((Phantom.XRMOD.NetcodeModule.Runtime.LagCompensation.LagCompensationManager)o).SimulationObjects;
        }

        static StackObject* CopyToStack_SimulationObjects_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.NetcodeModule.Runtime.LagCompensation.LagCompensationManager)o).SimulationObjects;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.NetcodeModule.Runtime.LagCompensation.LagCompensationManager();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

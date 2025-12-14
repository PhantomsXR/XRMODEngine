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
    unsafe class Unity_PolySpatial_VisionOSEnvironmentLightingConfiguration_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Unity.PolySpatial.VisionOSEnvironmentLightingConfiguration);
            args = new Type[]{};
            method = type.GetMethod("get_EnvironmentLightingWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_EnvironmentLightingWeight_0);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_EnvironmentLightingWeight", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_EnvironmentLightingWeight_1);



            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.PolySpatial.VisionOSEnvironmentLightingConfiguration());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.PolySpatial.VisionOSEnvironmentLightingConfiguration[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_EnvironmentLightingWeight_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSEnvironmentLightingConfiguration instance_of_this_method = (Unity.PolySpatial.VisionOSEnvironmentLightingConfiguration)typeof(Unity.PolySpatial.VisionOSEnvironmentLightingConfiguration).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.EnvironmentLightingWeight;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_EnvironmentLightingWeight_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VisionOSEnvironmentLightingConfiguration instance_of_this_method = (Unity.PolySpatial.VisionOSEnvironmentLightingConfiguration)typeof(Unity.PolySpatial.VisionOSEnvironmentLightingConfiguration).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.EnvironmentLightingWeight = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Unity.PolySpatial.VisionOSEnvironmentLightingConfiguration();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

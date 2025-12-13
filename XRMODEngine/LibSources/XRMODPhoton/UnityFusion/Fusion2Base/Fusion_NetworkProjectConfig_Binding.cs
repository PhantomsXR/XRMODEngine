using System;
using System.Collections.Generic;
using System.Linq;
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
    unsafe class Fusion_NetworkProjectConfig_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.NetworkProjectConfig);

            field = type.GetField("Simulation", flag);
            app.RegisterCLRFieldGetter(field, get_Simulation_0);
            app.RegisterCLRFieldSetter(field, set_Simulation_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Simulation_0, AssignFromStack_Simulation_0);


        }



        static object get_Simulation_0(ref object o)
        {
            return ((Fusion.NetworkProjectConfig)o).Simulation;
        }

        static StackObject* CopyToStack_Simulation_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.NetworkProjectConfig)o).Simulation;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Simulation_0(ref object o, object v)
        {
            ((Fusion.NetworkProjectConfig)o).Simulation = (Fusion.SimulationConfig)v;
        }

        static StackObject* AssignFromStack_Simulation_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.SimulationConfig @Simulation = (Fusion.SimulationConfig)typeof(Fusion.SimulationConfig).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.NetworkProjectConfig)o).Simulation = @Simulation;
            return ptr_of_this_method;
        }



    }
}

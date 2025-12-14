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
    unsafe class Fusion_SimulationConfig_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.SimulationConfig);

            field = type.GetField("PlayerCount", flag);
            app.RegisterCLRFieldGetter(field, get_PlayerCount_0);
            app.RegisterCLRFieldSetter(field, set_PlayerCount_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_PlayerCount_0, AssignFromStack_PlayerCount_0);


        } 



        static object get_PlayerCount_0(ref object o)
        {
            return ((Fusion.SimulationConfig)o).PlayerCount;
        }

        static StackObject* CopyToStack_PlayerCount_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.SimulationConfig)o).PlayerCount;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_PlayerCount_0(ref object o, object v)
        {
            ((Fusion.SimulationConfig)o).PlayerCount = (System.Int32)v;
        }

        static StackObject* AssignFromStack_PlayerCount_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @PlayerCount = ptr_of_this_method->Value;
            ((Fusion.SimulationConfig)o).PlayerCount = @PlayerCount;
            return ptr_of_this_method;
        }



    }
}

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
    unsafe class Phantom_XRMOD_XRMODUtilites_Runtime_ProcessIdComponent_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODUtilites.Runtime.ProcessIdComponent);
            args = new Type[]{};
            method = type.GetMethod("get_ProcessId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ProcessId_0);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("InitProcessId", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, InitProcessId_1);

            field = type.GetField("SpaceType", flag);
            app.RegisterCLRFieldGetter(field, get_SpaceType_0);
            app.RegisterCLRFieldSetter(field, set_SpaceType_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_SpaceType_0, AssignFromStack_SpaceType_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODUtilites.Runtime.ProcessIdComponent());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODUtilites.Runtime.ProcessIdComponent[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_ProcessId_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODUtilites.Runtime.ProcessIdComponent instance_of_this_method = (Phantom.XRMOD.XRMODUtilites.Runtime.ProcessIdComponent)typeof(Phantom.XRMOD.XRMODUtilites.Runtime.ProcessIdComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ProcessId;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* InitProcessId_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_processId = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODUtilites.Runtime.ProcessIdComponent instance_of_this_method = (Phantom.XRMOD.XRMODUtilites.Runtime.ProcessIdComponent)typeof(Phantom.XRMOD.XRMODUtilites.Runtime.ProcessIdComponent).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.InitProcessId(@_processId);

            return __ret;
        }


        static object get_SpaceType_0(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.ProcessIdComponent)o).SpaceType;
        }

        static StackObject* CopyToStack_SpaceType_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.ProcessIdComponent)o).SpaceType;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_SpaceType_0(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.ProcessIdComponent)o).SpaceType = (System.Byte)v;
        }

        static StackObject* AssignFromStack_SpaceType_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Byte @SpaceType = (byte)ptr_of_this_method->Value;
            ((Phantom.XRMOD.XRMODUtilites.Runtime.ProcessIdComponent)o).SpaceType = @SpaceType;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.XRMODUtilites.Runtime.ProcessIdComponent();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

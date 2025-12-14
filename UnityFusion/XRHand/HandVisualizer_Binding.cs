#if XR_HAND

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
    unsafe class HandVisualizer_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer);
            args = new Type[] { };
            method = type.GetMethod("get_DrawMeshes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_DrawMeshes_0);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_DrawMeshes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_DrawMeshes_1);
            args = new Type[] { };
            method = type.GetMethod("get_DebugDrawJoints", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_DebugDrawJoints_2);
            args = new Type[] {typeof(System.Boolean)};
            method = type.GetMethod("set_DebugDrawJoints", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_DebugDrawJoints_3);
            args = new Type[] { };
            method = type.GetMethod("get_VelocityType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_VelocityType_4);
            args = new Type[] {typeof(Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer.VelocityType)};
            method = type.GetMethod("set_VelocityType", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_VelocityType_5);

            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer[s]);

            args = new Type[] { };
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static StackObject* get_DrawMeshes_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer instance_of_this_method =
                (Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer)
                typeof(Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.drawMeshes;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_DrawMeshes_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer instance_of_this_method =
                (Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer)
                typeof(Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.drawMeshes = value;

            return __ret;
        }

        static StackObject* get_DebugDrawJoints_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer instance_of_this_method =
                (Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer)
                typeof(Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.debugDrawJoints;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_DebugDrawJoints_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer instance_of_this_method =
                (Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer)
                typeof(Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.debugDrawJoints = value;

            return __ret;
        }

        static StackObject* get_VelocityType_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer instance_of_this_method =
                (Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer)
                typeof(Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.velocityType;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_VelocityType_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack,
            CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer.VelocityType @value =
                (Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer.VelocityType)
                typeof(Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer.VelocityType).CheckCLRTypes(
                    StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer instance_of_this_method =
                (Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer)
                typeof(Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.velocityType = value;

            return __ret;
        }

        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.XRMODInput.Runtime.HandVisualizer();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}
#endif
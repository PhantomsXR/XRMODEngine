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
    unsafe class Phantom_XRMOD_XRMODInput_Runtime_PoseWrapper_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODInput.Runtime.PoseWrapper);

            field = type.GetField("pose", flag);
            app.RegisterCLRFieldGetter(field, get_pose_0);
            app.RegisterCLRFieldSetter(field, set_pose_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_pose_0, AssignFromStack_pose_0);


            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODInput.Runtime.PoseWrapper[s]);

            args = new Type[]{typeof(UnityEngine.Pose)};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_pose_0(ref object o)
        {
            return ((Phantom.XRMOD.XRMODInput.Runtime.PoseWrapper)o).pose;
        }

        static StackObject* CopyToStack_pose_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODInput.Runtime.PoseWrapper)o).pose;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_pose_0(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODInput.Runtime.PoseWrapper)o).pose = (UnityEngine.Pose)v;
        }

        static StackObject* AssignFromStack_pose_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Pose @pose = (UnityEngine.Pose)typeof(UnityEngine.Pose).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Phantom.XRMOD.XRMODInput.Runtime.PoseWrapper)o).pose = @pose;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);
            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Pose @_pose = (UnityEngine.Pose)typeof(UnityEngine.Pose).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = new Phantom.XRMOD.XRMODInput.Runtime.PoseWrapper(@_pose);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

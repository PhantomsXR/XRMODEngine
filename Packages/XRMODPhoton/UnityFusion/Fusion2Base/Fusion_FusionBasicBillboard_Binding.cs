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
    unsafe class Fusion_FusionBasicBillboard_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.FusionBasicBillboard);
            args = new Type[]{};
            method = type.GetMethod("UpdateLookAt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UpdateLookAt_0);

            field = type.GetField("Camera", flag);
            app.RegisterCLRFieldGetter(field, get_Camera_0);
            app.RegisterCLRFieldSetter(field, set_Camera_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Camera_0, AssignFromStack_Camera_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.FusionBasicBillboard());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.FusionBasicBillboard[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* UpdateLookAt_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.FusionBasicBillboard instance_of_this_method = (Fusion.FusionBasicBillboard)typeof(Fusion.FusionBasicBillboard).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UpdateLookAt();

            return __ret;
        }


        static object get_Camera_0(ref object o)
        {
            return ((Fusion.FusionBasicBillboard)o).Camera;
        }

        static StackObject* CopyToStack_Camera_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.FusionBasicBillboard)o).Camera;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Camera_0(ref object o, object v)
        {
            ((Fusion.FusionBasicBillboard)o).Camera = (UnityEngine.Camera)v;
        }

        static StackObject* AssignFromStack_Camera_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Camera @Camera = (UnityEngine.Camera)typeof(UnityEngine.Camera).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.FusionBasicBillboard)o).Camera = @Camera;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.FusionBasicBillboard();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

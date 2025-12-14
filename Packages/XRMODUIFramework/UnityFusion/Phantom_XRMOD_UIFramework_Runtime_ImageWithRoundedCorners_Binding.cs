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
    unsafe class Phantom_XRMOD_UIFramework_Runtime_ImageWithRoundedCorners_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.UIFramework.Runtime.ImageWithRoundedCorners);
            args = new Type[]{};
            method = type.GetMethod("Validate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Validate_0);
            args = new Type[]{};
            method = type.GetMethod("Refresh", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Refresh_1);

            field = type.GetField("radius", flag);
            app.RegisterCLRFieldGetter(field, get_radius_0);
            app.RegisterCLRFieldSetter(field, set_radius_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_radius_0, AssignFromStack_radius_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.UIFramework.Runtime.ImageWithRoundedCorners());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.UIFramework.Runtime.ImageWithRoundedCorners[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Validate_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.ImageWithRoundedCorners instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.ImageWithRoundedCorners)typeof(Phantom.XRMOD.UIFramework.Runtime.ImageWithRoundedCorners).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Validate();

            return __ret;
        }

        static StackObject* Refresh_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.ImageWithRoundedCorners instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.ImageWithRoundedCorners)typeof(Phantom.XRMOD.UIFramework.Runtime.ImageWithRoundedCorners).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Refresh();

            return __ret;
        }


        static object get_radius_0(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.ImageWithRoundedCorners)o).radius;
        }

        static StackObject* CopyToStack_radius_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.ImageWithRoundedCorners)o).radius;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_radius_0(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.ImageWithRoundedCorners)o).radius = (System.Single)v;
        }

        static StackObject* AssignFromStack_radius_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @radius = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.ImageWithRoundedCorners)o).radius = @radius;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.UIFramework.Runtime.ImageWithRoundedCorners();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

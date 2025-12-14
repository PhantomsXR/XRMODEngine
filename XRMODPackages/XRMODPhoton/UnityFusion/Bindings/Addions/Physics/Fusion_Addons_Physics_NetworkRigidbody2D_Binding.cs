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
    unsafe class Fusion_Addons_Physics_NetworkRigidbody2D_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Fusion.Addons.Physics.NetworkRigidbody2D);
            args = new Type[]{};
            method = type.GetMethod("get_RBPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_RBPosition_0);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_RBPosition", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_RBPosition_1);
            args = new Type[]{};
            method = type.GetMethod("get_RBRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_RBRotation_2);
            args = new Type[]{typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("set_RBRotation", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_RBRotation_3);
            args = new Type[]{};
            method = type.GetMethod("get_RBIsKinematic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_RBIsKinematic_4);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_RBIsKinematic", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_RBIsKinematic_5);
            args = new Type[]{};
            method = type.GetMethod("ResetRigidbody", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ResetRigidbody_6);



            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.Physics.NetworkRigidbody2D());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.Physics.NetworkRigidbody2D[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_RBPosition_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.Physics.NetworkRigidbody2D instance_of_this_method = (Fusion.Addons.Physics.NetworkRigidbody2D)typeof(Fusion.Addons.Physics.NetworkRigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.RBPosition;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_RBPosition_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.Physics.NetworkRigidbody2D instance_of_this_method = (Fusion.Addons.Physics.NetworkRigidbody2D)typeof(Fusion.Addons.Physics.NetworkRigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RBPosition = value;

            return __ret;
        }

        static StackObject* get_RBRotation_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.Physics.NetworkRigidbody2D instance_of_this_method = (Fusion.Addons.Physics.NetworkRigidbody2D)typeof(Fusion.Addons.Physics.NetworkRigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.RBRotation;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_RBRotation_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @value = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.Physics.NetworkRigidbody2D instance_of_this_method = (Fusion.Addons.Physics.NetworkRigidbody2D)typeof(Fusion.Addons.Physics.NetworkRigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RBRotation = value;

            return __ret;
        }

        static StackObject* get_RBIsKinematic_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.Physics.NetworkRigidbody2D instance_of_this_method = (Fusion.Addons.Physics.NetworkRigidbody2D)typeof(Fusion.Addons.Physics.NetworkRigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.RBIsKinematic;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_RBIsKinematic_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.Physics.NetworkRigidbody2D instance_of_this_method = (Fusion.Addons.Physics.NetworkRigidbody2D)typeof(Fusion.Addons.Physics.NetworkRigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RBIsKinematic = value;

            return __ret;
        }

        static StackObject* ResetRigidbody_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.Physics.NetworkRigidbody2D instance_of_this_method = (Fusion.Addons.Physics.NetworkRigidbody2D)typeof(Fusion.Addons.Physics.NetworkRigidbody2D).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ResetRigidbody();

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Addons.Physics.NetworkRigidbody2D();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
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
    unsafe class Fusion_Addons_Physics_NetworkRigidbodyBase_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.Physics.NetworkRigidbodyBase);
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
            method = type.GetMethod("get_InterpolationTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_InterpolationTarget_6);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("set_InterpolationTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_InterpolationTarget_7);
            args = new Type[]{typeof(UnityEngine.Transform)};
            method = type.GetMethod("SetInterpolationTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetInterpolationTarget_8);
            args = new Type[]{};
            method = type.GetMethod("Spawned", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Spawned_9);
            args = new Type[]{typeof(System.Nullable<UnityEngine.Vector3>), typeof(System.Nullable<UnityEngine.Quaternion>)};
            method = type.GetMethod("Teleport", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Teleport_10);

            field = type.GetField("SyncScale", flag);
            app.RegisterCLRFieldGetter(field, get_SyncScale_0);
            app.RegisterCLRFieldSetter(field, set_SyncScale_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_SyncScale_0, AssignFromStack_SyncScale_0);
            field = type.GetField("SyncParent", flag);
            app.RegisterCLRFieldGetter(field, get_SyncParent_1);
            app.RegisterCLRFieldSetter(field, set_SyncParent_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_SyncParent_1, AssignFromStack_SyncParent_1);
            field = type.GetField("UsePreciseRotation", flag);
            app.RegisterCLRFieldGetter(field, get_UsePreciseRotation_2);
            app.RegisterCLRFieldSetter(field, set_UsePreciseRotation_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_UsePreciseRotation_2, AssignFromStack_UsePreciseRotation_2);
            field = type.GetField("UseRenderSleepThresholds", flag);
            app.RegisterCLRFieldGetter(field, get_UseRenderSleepThresholds_3);
            app.RegisterCLRFieldSetter(field, set_UseRenderSleepThresholds_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_UseRenderSleepThresholds_3, AssignFromStack_UseRenderSleepThresholds_3);
            field = type.GetField("RenderThresholds", flag);
            app.RegisterCLRFieldGetter(field, get_RenderThresholds_4);
            app.RegisterCLRFieldSetter(field, set_RenderThresholds_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_RenderThresholds_4, AssignFromStack_RenderThresholds_4);


            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.Physics.NetworkRigidbodyBase[s]);


        }


        static StackObject* get_RBPosition_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.Physics.NetworkRigidbodyBase instance_of_this_method = (Fusion.Addons.Physics.NetworkRigidbodyBase)typeof(Fusion.Addons.Physics.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
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
            Fusion.Addons.Physics.NetworkRigidbodyBase instance_of_this_method = (Fusion.Addons.Physics.NetworkRigidbodyBase)typeof(Fusion.Addons.Physics.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
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
            Fusion.Addons.Physics.NetworkRigidbodyBase instance_of_this_method = (Fusion.Addons.Physics.NetworkRigidbodyBase)typeof(Fusion.Addons.Physics.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
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
            Fusion.Addons.Physics.NetworkRigidbodyBase instance_of_this_method = (Fusion.Addons.Physics.NetworkRigidbodyBase)typeof(Fusion.Addons.Physics.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
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
            Fusion.Addons.Physics.NetworkRigidbodyBase instance_of_this_method = (Fusion.Addons.Physics.NetworkRigidbodyBase)typeof(Fusion.Addons.Physics.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
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
            Fusion.Addons.Physics.NetworkRigidbodyBase instance_of_this_method = (Fusion.Addons.Physics.NetworkRigidbodyBase)typeof(Fusion.Addons.Physics.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RBIsKinematic = value;

            return __ret;
        }

        static StackObject* get_InterpolationTarget_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.Physics.NetworkRigidbodyBase instance_of_this_method = (Fusion.Addons.Physics.NetworkRigidbodyBase)typeof(Fusion.Addons.Physics.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.InterpolationTarget;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_InterpolationTarget_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @value = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.Physics.NetworkRigidbodyBase instance_of_this_method = (Fusion.Addons.Physics.NetworkRigidbodyBase)typeof(Fusion.Addons.Physics.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.InterpolationTarget = value;

            return __ret;
        }

        static StackObject* SetInterpolationTarget_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @target = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.Physics.NetworkRigidbodyBase instance_of_this_method = (Fusion.Addons.Physics.NetworkRigidbodyBase)typeof(Fusion.Addons.Physics.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetInterpolationTarget(@target);

            return __ret;
        }

        static StackObject* Spawned_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.Physics.NetworkRigidbodyBase instance_of_this_method = (Fusion.Addons.Physics.NetworkRigidbodyBase)typeof(Fusion.Addons.Physics.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Spawned();

            return __ret;
        }

        static StackObject* Teleport_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Nullable<UnityEngine.Quaternion> @rotation = (System.Nullable<UnityEngine.Quaternion>)typeof(System.Nullable<UnityEngine.Quaternion>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Nullable<UnityEngine.Vector3> @position = (System.Nullable<UnityEngine.Vector3>)typeof(System.Nullable<UnityEngine.Vector3>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.Addons.Physics.NetworkRigidbodyBase instance_of_this_method = (Fusion.Addons.Physics.NetworkRigidbodyBase)typeof(Fusion.Addons.Physics.NetworkRigidbodyBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Teleport(@position, @rotation);

            return __ret;
        }


        static object get_SyncScale_0(ref object o)
        {
            return ((Fusion.Addons.Physics.NetworkRigidbodyBase)o).SyncScale;
        }

        static StackObject* CopyToStack_SyncScale_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.NetworkRigidbodyBase)o).SyncScale;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SyncScale_0(ref object o, object v)
        {
            ((Fusion.Addons.Physics.NetworkRigidbodyBase)o).SyncScale = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SyncScale_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SyncScale = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.Physics.NetworkRigidbodyBase)o).SyncScale = @SyncScale;
            return ptr_of_this_method;
        }

        static object get_SyncParent_1(ref object o)
        {
            return ((Fusion.Addons.Physics.NetworkRigidbodyBase)o).SyncParent;
        }

        static StackObject* CopyToStack_SyncParent_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.NetworkRigidbodyBase)o).SyncParent;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SyncParent_1(ref object o, object v)
        {
            ((Fusion.Addons.Physics.NetworkRigidbodyBase)o).SyncParent = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SyncParent_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SyncParent = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.Physics.NetworkRigidbodyBase)o).SyncParent = @SyncParent;
            return ptr_of_this_method;
        }

        static object get_UsePreciseRotation_2(ref object o)
        {
            return ((Fusion.Addons.Physics.NetworkRigidbodyBase)o).UsePreciseRotation;
        }

        static StackObject* CopyToStack_UsePreciseRotation_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.NetworkRigidbodyBase)o).UsePreciseRotation;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_UsePreciseRotation_2(ref object o, object v)
        {
            ((Fusion.Addons.Physics.NetworkRigidbodyBase)o).UsePreciseRotation = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_UsePreciseRotation_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @UsePreciseRotation = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.Physics.NetworkRigidbodyBase)o).UsePreciseRotation = @UsePreciseRotation;
            return ptr_of_this_method;
        }

        static object get_UseRenderSleepThresholds_3(ref object o)
        {
            return ((Fusion.Addons.Physics.NetworkRigidbodyBase)o).UseRenderSleepThresholds;
        }

        static StackObject* CopyToStack_UseRenderSleepThresholds_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.NetworkRigidbodyBase)o).UseRenderSleepThresholds;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_UseRenderSleepThresholds_3(ref object o, object v)
        {
            ((Fusion.Addons.Physics.NetworkRigidbodyBase)o).UseRenderSleepThresholds = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_UseRenderSleepThresholds_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @UseRenderSleepThresholds = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.Physics.NetworkRigidbodyBase)o).UseRenderSleepThresholds = @UseRenderSleepThresholds;
            return ptr_of_this_method;
        }

        static object get_RenderThresholds_4(ref object o)
        {
            return ((Fusion.Addons.Physics.NetworkRigidbodyBase)o).RenderThresholds;
        }

        static StackObject* CopyToStack_RenderThresholds_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.Physics.NetworkRigidbodyBase)o).RenderThresholds;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_RenderThresholds_4(ref object o, object v)
        {
            ((Fusion.Addons.Physics.NetworkRigidbodyBase)o).RenderThresholds = (Fusion.Addons.Physics.TRSThresholds)v;
        }

        static StackObject* AssignFromStack_RenderThresholds_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.Physics.TRSThresholds @RenderThresholds = (Fusion.Addons.Physics.TRSThresholds)typeof(Fusion.Addons.Physics.TRSThresholds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.Physics.NetworkRigidbodyBase)o).RenderThresholds = @RenderThresholds;
            return ptr_of_this_method;
        }




    }
}
#endif
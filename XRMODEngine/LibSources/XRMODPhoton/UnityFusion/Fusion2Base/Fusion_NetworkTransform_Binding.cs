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
    unsafe class Fusion_NetworkTransform_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.NetworkTransform);
            args = new Type[]{};
            method = type.GetMethod("get_AutoUpdateAreaOfInterestOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_AutoUpdateAreaOfInterestOverride_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_AutoUpdateAreaOfInterestOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_AutoUpdateAreaOfInterestOverride_1);
            args = new Type[]{typeof(System.Nullable<UnityEngine.Vector3>), typeof(System.Nullable<UnityEngine.Quaternion>)};
            method = type.GetMethod("Teleport", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Teleport_2);
            args = new Type[]{typeof(Fusion.NetworkObject)};
            method = type.GetMethod("SetAreaOfInterestOverride", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetAreaOfInterestOverride_3);
            args = new Type[]{};
            method = type.GetMethod("Spawned", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Spawned_4);
            args = new Type[]{};
            method = type.GetMethod("Render", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Render_5);

            field = type.GetField("SyncScale", flag);
            app.RegisterCLRFieldGetter(field, get_SyncScale_0);
            app.RegisterCLRFieldSetter(field, set_SyncScale_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_SyncScale_0, AssignFromStack_SyncScale_0);
            field = type.GetField("SyncParent", flag);
            app.RegisterCLRFieldGetter(field, get_SyncParent_1);
            app.RegisterCLRFieldSetter(field, set_SyncParent_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_SyncParent_1, AssignFromStack_SyncParent_1);
            field = type.GetField("DisableSharedModeInterpolation", flag);
            app.RegisterCLRFieldGetter(field, get_DisableSharedModeInterpolation_2);
            app.RegisterCLRFieldSetter(field, set_DisableSharedModeInterpolation_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_DisableSharedModeInterpolation_2, AssignFromStack_DisableSharedModeInterpolation_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.NetworkTransform());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.NetworkTransform[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_AutoUpdateAreaOfInterestOverride_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkTransform instance_of_this_method = (Fusion.NetworkTransform)typeof(Fusion.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AutoUpdateAreaOfInterestOverride;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_AutoUpdateAreaOfInterestOverride_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.NetworkTransform instance_of_this_method = (Fusion.NetworkTransform)typeof(Fusion.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AutoUpdateAreaOfInterestOverride = value;

            return __ret;
        }

        static StackObject* Teleport_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
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
            Fusion.NetworkTransform instance_of_this_method = (Fusion.NetworkTransform)typeof(Fusion.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Teleport(@position, @rotation);

            return __ret;
        }

        static StackObject* SetAreaOfInterestOverride_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkObject @obj = (Fusion.NetworkObject)typeof(Fusion.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.NetworkTransform instance_of_this_method = (Fusion.NetworkTransform)typeof(Fusion.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetAreaOfInterestOverride(@obj);

            return __ret;
        }

        static StackObject* Spawned_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkTransform instance_of_this_method = (Fusion.NetworkTransform)typeof(Fusion.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Spawned();

            return __ret;
        }

        static StackObject* Render_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.NetworkTransform instance_of_this_method = (Fusion.NetworkTransform)typeof(Fusion.NetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Render();

            return __ret;
        }


        static object get_SyncScale_0(ref object o)
        {
            return ((Fusion.NetworkTransform)o).SyncScale;
        }

        static StackObject* CopyToStack_SyncScale_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.NetworkTransform)o).SyncScale;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SyncScale_0(ref object o, object v)
        {
            ((Fusion.NetworkTransform)o).SyncScale = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SyncScale_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SyncScale = ptr_of_this_method->Value == 1;
            ((Fusion.NetworkTransform)o).SyncScale = @SyncScale;
            return ptr_of_this_method;
        }

        static object get_SyncParent_1(ref object o)
        {
            return ((Fusion.NetworkTransform)o).SyncParent;
        }

        static StackObject* CopyToStack_SyncParent_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.NetworkTransform)o).SyncParent;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_SyncParent_1(ref object o, object v)
        {
            ((Fusion.NetworkTransform)o).SyncParent = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_SyncParent_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @SyncParent = ptr_of_this_method->Value == 1;
            ((Fusion.NetworkTransform)o).SyncParent = @SyncParent;
            return ptr_of_this_method;
        }

        static object get_DisableSharedModeInterpolation_2(ref object o)
        {
            return ((Fusion.NetworkTransform)o).DisableSharedModeInterpolation;
        }

        static StackObject* CopyToStack_DisableSharedModeInterpolation_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.NetworkTransform)o).DisableSharedModeInterpolation;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_DisableSharedModeInterpolation_2(ref object o, object v)
        {
            ((Fusion.NetworkTransform)o).DisableSharedModeInterpolation = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_DisableSharedModeInterpolation_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @DisableSharedModeInterpolation = ptr_of_this_method->Value == 1;
            ((Fusion.NetworkTransform)o).DisableSharedModeInterpolation = @DisableSharedModeInterpolation;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.NetworkTransform();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

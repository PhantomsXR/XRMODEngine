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
    unsafe class Unity_Netcode_Components_AnticipatedNetworkTransform_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Unity.Netcode.Components.AnticipatedNetworkTransform);
            args = new Type[]{};
            method = type.GetMethod("get_AuthoritativeState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_AuthoritativeState_0);
            args = new Type[]{};
            method = type.GetMethod("get_AnticipatedState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_AnticipatedState_1);
            args = new Type[]{};
            method = type.GetMethod("get_ShouldReanticipate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ShouldReanticipate_2);
            args = new Type[]{};
            method = type.GetMethod("get_PreviousAnticipatedState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_PreviousAnticipatedState_3);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("AnticipateMove", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AnticipateMove_4);
            args = new Type[]{typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("AnticipateRotate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AnticipateRotate_5);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("AnticipateScale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AnticipateScale_6);
            args = new Type[]{typeof(Unity.Netcode.Components.AnticipatedNetworkTransform.TransformState)};
            method = type.GetMethod("AnticipateState", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AnticipateState_7);
            args = new Type[]{};
            method = type.GetMethod("OnUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnUpdate_8);
            args = new Type[]{};
            method = type.GetMethod("OnNetworkSpawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkSpawn_9);
            args = new Type[]{};
            method = type.GetMethod("OnNetworkDespawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkDespawn_10);
            args = new Type[]{};
            method = type.GetMethod("OnDestroy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnDestroy_11);
            args = new Type[]{typeof(Unity.Netcode.Components.AnticipatedNetworkTransform.TransformState), typeof(Unity.Netcode.Components.AnticipatedNetworkTransform.TransformState), typeof(System.Single)};
            method = type.GetMethod("Smooth", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Smooth_12);

            field = type.GetField("StaleDataHandling", flag);
            app.RegisterCLRFieldGetter(field, get_StaleDataHandling_0);
            app.RegisterCLRFieldSetter(field, set_StaleDataHandling_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_StaleDataHandling_0, AssignFromStack_StaleDataHandling_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.Netcode.Components.AnticipatedNetworkTransform());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.Netcode.Components.AnticipatedNetworkTransform[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_AuthoritativeState_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.AnticipatedNetworkTransform instance_of_this_method = (Unity.Netcode.Components.AnticipatedNetworkTransform)typeof(Unity.Netcode.Components.AnticipatedNetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AuthoritativeState;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_AnticipatedState_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.AnticipatedNetworkTransform instance_of_this_method = (Unity.Netcode.Components.AnticipatedNetworkTransform)typeof(Unity.Netcode.Components.AnticipatedNetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AnticipatedState;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_ShouldReanticipate_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.AnticipatedNetworkTransform instance_of_this_method = (Unity.Netcode.Components.AnticipatedNetworkTransform)typeof(Unity.Netcode.Components.AnticipatedNetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ShouldReanticipate;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_PreviousAnticipatedState_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.AnticipatedNetworkTransform instance_of_this_method = (Unity.Netcode.Components.AnticipatedNetworkTransform)typeof(Unity.Netcode.Components.AnticipatedNetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.PreviousAnticipatedState;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* AnticipateMove_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @newPosition = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.Components.AnticipatedNetworkTransform instance_of_this_method = (Unity.Netcode.Components.AnticipatedNetworkTransform)typeof(Unity.Netcode.Components.AnticipatedNetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AnticipateMove(@newPosition);

            return __ret;
        }

        static StackObject* AnticipateRotate_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @newRotation = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.Components.AnticipatedNetworkTransform instance_of_this_method = (Unity.Netcode.Components.AnticipatedNetworkTransform)typeof(Unity.Netcode.Components.AnticipatedNetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AnticipateRotate(@newRotation);

            return __ret;
        }

        static StackObject* AnticipateScale_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @newScale = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.Components.AnticipatedNetworkTransform instance_of_this_method = (Unity.Netcode.Components.AnticipatedNetworkTransform)typeof(Unity.Netcode.Components.AnticipatedNetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AnticipateScale(@newScale);

            return __ret;
        }

        static StackObject* AnticipateState_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.AnticipatedNetworkTransform.TransformState @newState = (Unity.Netcode.Components.AnticipatedNetworkTransform.TransformState)typeof(Unity.Netcode.Components.AnticipatedNetworkTransform.TransformState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.Components.AnticipatedNetworkTransform instance_of_this_method = (Unity.Netcode.Components.AnticipatedNetworkTransform)typeof(Unity.Netcode.Components.AnticipatedNetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.AnticipateState(@newState);

            return __ret;
        }

        static StackObject* OnUpdate_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.AnticipatedNetworkTransform instance_of_this_method = (Unity.Netcode.Components.AnticipatedNetworkTransform)typeof(Unity.Netcode.Components.AnticipatedNetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnUpdate();

            return __ret;
        }

        static StackObject* OnNetworkSpawn_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.AnticipatedNetworkTransform instance_of_this_method = (Unity.Netcode.Components.AnticipatedNetworkTransform)typeof(Unity.Netcode.Components.AnticipatedNetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkSpawn();

            return __ret;
        }

        static StackObject* OnNetworkDespawn_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.AnticipatedNetworkTransform instance_of_this_method = (Unity.Netcode.Components.AnticipatedNetworkTransform)typeof(Unity.Netcode.Components.AnticipatedNetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkDespawn();

            return __ret;
        }

        static StackObject* OnDestroy_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.Netcode.Components.AnticipatedNetworkTransform instance_of_this_method = (Unity.Netcode.Components.AnticipatedNetworkTransform)typeof(Unity.Netcode.Components.AnticipatedNetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnDestroy();

            return __ret;
        }

        static StackObject* Smooth_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @durationSeconds = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.Netcode.Components.AnticipatedNetworkTransform.TransformState @to = (Unity.Netcode.Components.AnticipatedNetworkTransform.TransformState)typeof(Unity.Netcode.Components.AnticipatedNetworkTransform.TransformState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Unity.Netcode.Components.AnticipatedNetworkTransform.TransformState @from = (Unity.Netcode.Components.AnticipatedNetworkTransform.TransformState)typeof(Unity.Netcode.Components.AnticipatedNetworkTransform.TransformState).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Unity.Netcode.Components.AnticipatedNetworkTransform instance_of_this_method = (Unity.Netcode.Components.AnticipatedNetworkTransform)typeof(Unity.Netcode.Components.AnticipatedNetworkTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Smooth(@from, @to, @durationSeconds);

            return __ret;
        }


        static object get_StaleDataHandling_0(ref object o)
        {
            return ((Unity.Netcode.Components.AnticipatedNetworkTransform)o).StaleDataHandling;
        }

        static StackObject* CopyToStack_StaleDataHandling_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Unity.Netcode.Components.AnticipatedNetworkTransform)o).StaleDataHandling;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_StaleDataHandling_0(ref object o, object v)
        {
            ((Unity.Netcode.Components.AnticipatedNetworkTransform)o).StaleDataHandling = (Unity.Netcode.StaleDataHandling)v;
        }

        static StackObject* AssignFromStack_StaleDataHandling_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Unity.Netcode.StaleDataHandling @StaleDataHandling = (Unity.Netcode.StaleDataHandling)typeof(Unity.Netcode.StaleDataHandling).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Unity.Netcode.Components.AnticipatedNetworkTransform)o).StaleDataHandling = @StaleDataHandling;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Unity.Netcode.Components.AnticipatedNetworkTransform();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

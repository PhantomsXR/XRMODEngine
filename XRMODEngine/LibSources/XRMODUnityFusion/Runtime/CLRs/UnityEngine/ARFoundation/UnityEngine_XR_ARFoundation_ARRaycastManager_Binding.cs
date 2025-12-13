#if USE_ARFOUNDATION
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
    unsafe class UnityEngine_XR_ARFoundation_ARRaycastManager_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(UnityEngine.XR.ARFoundation.ARRaycastManager);
            args = new Type[]{};
            method = type.GetMethod("get_raycastPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_raycastPrefab_0);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("set_raycastPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_raycastPrefab_1);
            args = new Type[]{typeof(UnityEngine.Vector2), typeof(System.Collections.Generic.List<UnityEngine.XR.ARFoundation.ARRaycastHit>), typeof(UnityEngine.XR.ARSubsystems.TrackableType)};
            method = type.GetMethod("Raycast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Raycast_2);
            args = new Type[]{typeof(UnityEngine.Ray), typeof(System.Collections.Generic.List<UnityEngine.XR.ARFoundation.ARRaycastHit>), typeof(UnityEngine.XR.ARSubsystems.TrackableType)};
            method = type.GetMethod("Raycast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Raycast_3);
            args = new Type[]{typeof(UnityEngine.Vector2), typeof(System.Single)};
            method = type.GetMethod("AddRaycast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, AddRaycast_4);
            args = new Type[]{typeof(UnityEngine.XR.ARFoundation.ARRaycast)};
            method = type.GetMethod("RemoveRaycast", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveRaycast_5);



            app.RegisterCLRCreateDefaultInstance(type, () => new UnityEngine.XR.ARFoundation.ARRaycastManager());
            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.XR.ARFoundation.ARRaycastManager[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_raycastPrefab_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARRaycastManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARRaycastManager)typeof(UnityEngine.XR.ARFoundation.ARRaycastManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.raycastPrefab;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_raycastPrefab_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @value = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARRaycastManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARRaycastManager)typeof(UnityEngine.XR.ARFoundation.ARRaycastManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.raycastPrefab = value;

            return __ret;
        }

        static StackObject* Raycast_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARSubsystems.TrackableType @trackableTypes = (UnityEngine.XR.ARSubsystems.TrackableType)typeof(UnityEngine.XR.ARSubsystems.TrackableType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityEngine.XR.ARFoundation.ARRaycastHit> @hitResults = (System.Collections.Generic.List<UnityEngine.XR.ARFoundation.ARRaycastHit>)typeof(System.Collections.Generic.List<UnityEngine.XR.ARFoundation.ARRaycastHit>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Vector2 @screenPoint = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.XR.ARFoundation.ARRaycastManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARRaycastManager)typeof(UnityEngine.XR.ARFoundation.ARRaycastManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Raycast(@screenPoint, @hitResults, @trackableTypes);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Raycast_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARSubsystems.TrackableType @trackableTypes = (UnityEngine.XR.ARSubsystems.TrackableType)typeof(UnityEngine.XR.ARSubsystems.TrackableType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Collections.Generic.List<UnityEngine.XR.ARFoundation.ARRaycastHit> @hitResults = (System.Collections.Generic.List<UnityEngine.XR.ARFoundation.ARRaycastHit>)typeof(System.Collections.Generic.List<UnityEngine.XR.ARFoundation.ARRaycastHit>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.Ray @ray = (UnityEngine.Ray)typeof(UnityEngine.Ray).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            UnityEngine.XR.ARFoundation.ARRaycastManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARRaycastManager)typeof(UnityEngine.XR.ARFoundation.ARRaycastManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Raycast(@ray, @hitResults, @trackableTypes);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* AddRaycast_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @estimatedDistance = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Vector2 @screenPoint = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            UnityEngine.XR.ARFoundation.ARRaycastManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARRaycastManager)typeof(UnityEngine.XR.ARFoundation.ARRaycastManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.AddRaycast(@screenPoint, @estimatedDistance);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RemoveRaycast_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.XR.ARFoundation.ARRaycast @raycast = (UnityEngine.XR.ARFoundation.ARRaycast)typeof(UnityEngine.XR.ARFoundation.ARRaycast).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.XR.ARFoundation.ARRaycastManager instance_of_this_method = (UnityEngine.XR.ARFoundation.ARRaycastManager)typeof(UnityEngine.XR.ARFoundation.ARRaycastManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveRaycast(@raycast);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new UnityEngine.XR.ARFoundation.ARRaycastManager();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
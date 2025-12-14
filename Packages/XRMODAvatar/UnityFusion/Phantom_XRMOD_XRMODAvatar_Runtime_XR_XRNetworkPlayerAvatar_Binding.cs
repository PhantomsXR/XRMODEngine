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
    unsafe class Phantom_XRMOD_XRMODAvatar_Runtime_XR_XRNetworkPlayerAvatar_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar);
            args = new Type[]{};
            method = type.GetMethod("OnDestroy", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnDestroy_0);
            args = new Type[]{};
            method = type.GetMethod("OnNetworkSpawn", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnNetworkSpawn_1);
            args = new Type[]{typeof(UnityEngine.Transform), typeof(UnityEngine.Transform)};
            method = type.GetMethod("SetHandOrigins", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetHandOrigins_2);

            field = type.GetField("head", flag);
            app.RegisterCLRFieldGetter(field, get_head_0);
            app.RegisterCLRFieldSetter(field, set_head_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_head_0, AssignFromStack_head_0);
            field = type.GetField("leftHand", flag);
            app.RegisterCLRFieldGetter(field, get_leftHand_1);
            app.RegisterCLRFieldSetter(field, set_leftHand_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_leftHand_1, AssignFromStack_leftHand_1);
            field = type.GetField("rightHand", flag);
            app.RegisterCLRFieldGetter(field, get_rightHand_2);
            app.RegisterCLRFieldSetter(field, set_rightHand_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_rightHand_2, AssignFromStack_rightHand_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* OnDestroy_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar instance_of_this_method = (Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar)typeof(Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnDestroy();

            return __ret;
        }

        static StackObject* OnNetworkSpawn_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar instance_of_this_method = (Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar)typeof(Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnNetworkSpawn();

            return __ret;
        }

        static StackObject* SetHandOrigins_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Transform @right = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.Transform @left = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar instance_of_this_method = (Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar)typeof(Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetHandOrigins(@left, @right);

            return __ret;
        }


        static object get_head_0(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar)o).head;
        }

        static StackObject* CopyToStack_head_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar)o).head;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_head_0(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar)o).head = (UnityEngine.Transform)v;
        }

        static StackObject* AssignFromStack_head_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Transform @head = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar)o).head = @head;
            return ptr_of_this_method;
        }

        static object get_leftHand_1(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar)o).leftHand;
        }

        static StackObject* CopyToStack_leftHand_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar)o).leftHand;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_leftHand_1(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar)o).leftHand = (UnityEngine.Transform)v;
        }

        static StackObject* AssignFromStack_leftHand_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Transform @leftHand = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar)o).leftHand = @leftHand;
            return ptr_of_this_method;
        }

        static object get_rightHand_2(ref object o)
        {
            return ((Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar)o).rightHand;
        }

        static StackObject* CopyToStack_rightHand_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar)o).rightHand;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_rightHand_2(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar)o).rightHand = (UnityEngine.Transform)v;
        }

        static StackObject* AssignFromStack_rightHand_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Transform @rightHand = (UnityEngine.Transform)typeof(UnityEngine.Transform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar)o).rightHand = @rightHand;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.XRMODAvatar.Runtime.XR.XRNetworkPlayerAvatar();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

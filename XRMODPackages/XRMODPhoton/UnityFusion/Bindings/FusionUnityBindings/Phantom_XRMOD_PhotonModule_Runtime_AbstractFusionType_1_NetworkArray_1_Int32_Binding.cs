// // /*===============================================================================
// // Copyright (C) 2025 PhantomsXR Ltd. All Rights Reserved.
// //
// // This file is part of the Phantom.XRMOD.PhotonModule.UnityFusion.
// //
// // The XR-MOD cannot be copied, distributed, or made available to
// // third-parties for commercial purposes without written permission of PhantomsXR Ltd.
// //
// // Contact nswell@phantomsxr.com for licensing requests.
// // ===============================================================================*/

using System;
using System.Collections.Generic;
using System.Linq;
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
    unsafe class Phantom_XRMOD_PhotonModule_Runtime_AbstractFusionType_1_NetworkArray_1_Int32_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.PhotonModule.Runtime.AbstractFusionType<Fusion.NetworkArray<System.Int32>>);

            field = type.GetField("OnValueChanged", flag);
            app.RegisterCLRFieldGetter(field, get_OnValueChanged_0);
            app.RegisterCLRFieldSetter(field, set_OnValueChanged_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnValueChanged_0, AssignFromStack_OnValueChanged_0);


        }



        static object get_OnValueChanged_0(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.AbstractFusionType<Fusion.NetworkArray<System.Int32>>)o).OnValueChanged;
        }

        static StackObject* CopyToStack_OnValueChanged_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.AbstractFusionType<Fusion.NetworkArray<System.Int32>>)o).OnValueChanged;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnValueChanged_0(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.AbstractFusionType<Fusion.NetworkArray<System.Int32>>)o).OnValueChanged = (UnityEngine.Events.UnityEvent<Fusion.NetworkArray<System.Int32>>)v;
        }

        static StackObject* AssignFromStack_OnValueChanged_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Events.UnityEvent<Fusion.NetworkArray<System.Int32>> @OnValueChanged = (UnityEngine.Events.UnityEvent<Fusion.NetworkArray<System.Int32>>)typeof(UnityEngine.Events.UnityEvent<Fusion.NetworkArray<System.Int32>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.PhotonModule.Runtime.AbstractFusionType<Fusion.NetworkArray<System.Int32>>)o).OnValueChanged = @OnValueChanged;
            return ptr_of_this_method;
        }



    }
}

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
    unsafe class Phantom_XRMOD_PhotonModule_Runtime_BaseFusionType_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.PhotonModule.Runtime.BaseFusionType);

            args = new Type[]{};
            method = type.GetMethod("CopyStateToBackingFields", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyStateToBackingFields_1);

            field = type.GetField("Key", flag);
            app.RegisterCLRFieldGetter(field, get_Key_0);
            app.RegisterCLRFieldSetter(field, set_Key_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Key_0, AssignFromStack_Key_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.PhotonModule.Runtime.BaseFusionType());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.PhotonModule.Runtime.BaseFusionType[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static StackObject* CopyStateToBackingFields_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.PhotonModule.Runtime.BaseFusionType instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.BaseFusionType)typeof(Phantom.XRMOD.PhotonModule.Runtime.BaseFusionType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyStateToBackingFields();

            return __ret;
        }


        static object get_Key_0(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.BaseFusionType)o).Key;
        }

        static StackObject* CopyToStack_Key_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.BaseFusionType)o).Key;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Key_0(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.BaseFusionType)o).Key = (System.String)v;
        }

        static StackObject* AssignFromStack_Key_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @Key = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.PhotonModule.Runtime.BaseFusionType)o).Key = @Key;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.PhotonModule.Runtime.BaseFusionType();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
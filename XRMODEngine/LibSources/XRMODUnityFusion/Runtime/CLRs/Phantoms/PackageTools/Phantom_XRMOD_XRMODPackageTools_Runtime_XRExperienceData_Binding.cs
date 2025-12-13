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
    unsafe class Phantom_XRMOD_XRMODPackageTools_Runtime_XRExperienceData_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static |
                                BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODPackageTools.Runtime.XRExperienceData);

            field = type.GetField("BundleName", flag);
            app.RegisterCLRFieldGetter(field, get_BundleName_0);
            app.RegisterCLRFieldSetter(field, set_BundleName_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_BundleName_0, AssignFromStack_BundleName_0);
            field = type.GetField("AddressableName", flag);
            app.RegisterCLRFieldGetter(field, get_AddressableName_1);
            app.RegisterCLRFieldSetter(field, set_AddressableName_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_AddressableName_1, AssignFromStack_AddressableName_1);
            field = type.GetField("AssetsName", flag);
            app.RegisterCLRFieldGetter(field, get_AssetsName_2);
            app.RegisterCLRFieldSetter(field, set_AssetsName_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_AssetsName_2, AssignFromStack_AssetsName_2); 
           

            app.RegisterCLRCreateDefaultInstance(type,
                () => new Phantom.XRMOD.XRMODPackageTools.Runtime.XRExperienceData());
            app.RegisterCLRCreateArrayInstance(type,
                s => new Phantom.XRMOD.XRMODPackageTools.Runtime.XRExperienceData[s]);

            args = new Type[] { };
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);
        }


        static object get_BundleName_0(ref object o)
        {
            return ((Phantom.XRMOD.XRMODPackageTools.Runtime.XRExperienceData) o).BundleName;
        }

        static StackObject* CopyToStack_BundleName_0(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODPackageTools.Runtime.XRExperienceData) o).BundleName;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_BundleName_0(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODPackageTools.Runtime.XRExperienceData) o).BundleName = (System.String) v;
        }

        static StackObject* AssignFromStack_BundleName_0(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @BundleName = (System.String) typeof(System.String).CheckCLRTypes(
                StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.XRMODPackageTools.Runtime.XRExperienceData) o).BundleName = @BundleName;
            return ptr_of_this_method;
        }

        static object get_AddressableName_1(ref object o)
        {
            return ((Phantom.XRMOD.XRMODPackageTools.Runtime.XRExperienceData) o).AddressableName;
        }

        static StackObject* CopyToStack_AddressableName_1(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODPackageTools.Runtime.XRExperienceData) o).AddressableName;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AddressableName_1(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODPackageTools.Runtime.XRExperienceData) o).AddressableName =
                (System.Collections.Generic.List<System.String>) v;
        }

        static StackObject* AssignFromStack_AddressableName_1(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.List<System.String> @AddressableName =
                (System.Collections.Generic.List<System.String>) typeof(System.Collections.Generic.List<System.String>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.XRMODPackageTools.Runtime.XRExperienceData) o).AddressableName = @AddressableName;
            return ptr_of_this_method;
        }

        static object get_AssetsName_2(ref object o)
        {
            return ((Phantom.XRMOD.XRMODPackageTools.Runtime.XRExperienceData) o).AssetsName;
        }

        static StackObject* CopyToStack_AssetsName_2(ref object o, ILIntepreter __intp, StackObject* __ret,
            AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODPackageTools.Runtime.XRExperienceData) o).AssetsName;
            object obj_result_of_this_method = result_of_this_method;
            if (obj_result_of_this_method is CrossBindingAdaptorType)
            {
                return ILIntepreter.PushObject(__ret, __mStack,
                    ((CrossBindingAdaptorType) obj_result_of_this_method).ILInstance);
            }

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AssetsName_2(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODPackageTools.Runtime.XRExperienceData) o).AssetsName =
                (System.Collections.Generic.List<System.String>) v;
        }

        static StackObject* AssignFromStack_AssetsName_2(ref object o, ILIntepreter __intp,
            StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.List<System.String> @AssetsName =
                (System.Collections.Generic.List<System.String>) typeof(System.Collections.Generic.List<System.String>)
                    .CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack),
                        (CLR.Utils.Extensions.TypeFlags) 0);
            ((Phantom.XRMOD.XRMODPackageTools.Runtime.XRExperienceData) o).AssetsName = @AssetsName;
            return ptr_of_this_method;
        }
 


        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method,
            bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.XRMODPackageTools.Runtime.XRExperienceData();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }
    }
}
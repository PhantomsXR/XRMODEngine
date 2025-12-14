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
    unsafe class OnEventPlaneEventArgs_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs);
            args = new Type[]{};
            method = type.GetMethod("get_Added", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Added_0);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Transform>)};
            method = type.GetMethod("set_Added", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Added_1);
            args = new Type[]{};
            method = type.GetMethod("get_Updated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Updated_2);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Transform>)};
            method = type.GetMethod("set_Updated", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Updated_3);
            args = new Type[]{};
            method = type.GetMethod("get_Removed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_Removed_4);
            args = new Type[]{typeof(System.Collections.Generic.List<UnityEngine.Transform>)};
            method = type.GetMethod("set_Removed", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_Removed_5);



            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_Added_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs instance_of_this_method = (Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs)typeof(Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Added;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_Added_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Transform> @value = (System.Collections.Generic.List<UnityEngine.Transform>)typeof(System.Collections.Generic.List<UnityEngine.Transform>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs instance_of_this_method = (Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs)typeof(Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Added = value;

            return __ret;
        }

        static StackObject* get_Updated_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs instance_of_this_method = (Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs)typeof(Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Updated;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_Updated_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Transform> @value = (System.Collections.Generic.List<UnityEngine.Transform>)typeof(System.Collections.Generic.List<UnityEngine.Transform>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs instance_of_this_method = (Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs)typeof(Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Updated = value;

            return __ret;
        }

        static StackObject* get_Removed_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs instance_of_this_method = (Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs)typeof(Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Removed;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_Removed_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<UnityEngine.Transform> @value = (System.Collections.Generic.List<UnityEngine.Transform>)typeof(System.Collections.Generic.List<UnityEngine.Transform>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs instance_of_this_method = (Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs)typeof(Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Removed = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.ActionNotification.Runtime.OnEventPlaneEventArgs();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

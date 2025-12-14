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
    unsafe class Fusion_Addons_KCC_KCCIgnore_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.KCC.KCCIgnore);
            args = new Type[]{typeof(Fusion.Addons.KCC.KCCIgnore)};
            method = type.GetMethod("CopyFromOther", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CopyFromOther_0);
            args = new Type[]{};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_1);

            field = type.GetField("NetworkID", flag);
            app.RegisterCLRFieldGetter(field, get_NetworkID_0);
            app.RegisterCLRFieldSetter(field, set_NetworkID_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_NetworkID_0, AssignFromStack_NetworkID_0);
            field = type.GetField("NetworkObject", flag);
            app.RegisterCLRFieldGetter(field, get_NetworkObject_1);
            app.RegisterCLRFieldSetter(field, set_NetworkObject_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_NetworkObject_1, AssignFromStack_NetworkObject_1);
            field = type.GetField("Collider", flag);
            app.RegisterCLRFieldGetter(field, get_Collider_2);
            app.RegisterCLRFieldSetter(field, set_Collider_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Collider_2, AssignFromStack_Collider_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.KCCIgnore());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.KCCIgnore[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* CopyFromOther_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCIgnore @other = (Fusion.Addons.KCC.KCCIgnore)typeof(Fusion.Addons.KCC.KCCIgnore).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCIgnore instance_of_this_method = (Fusion.Addons.KCC.KCCIgnore)typeof(Fusion.Addons.KCC.KCCIgnore).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.CopyFromOther(@other);

            return __ret;
        }

        static StackObject* Clear_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCIgnore instance_of_this_method = (Fusion.Addons.KCC.KCCIgnore)typeof(Fusion.Addons.KCC.KCCIgnore).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Clear();

            return __ret;
        }


        static object get_NetworkID_0(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCIgnore)o).NetworkID;
        }

        static StackObject* CopyToStack_NetworkID_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCIgnore)o).NetworkID;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_NetworkID_0(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCIgnore)o).NetworkID = (Fusion.Addons.KCC.KCCNetworkID)v;
        }

        static StackObject* AssignFromStack_NetworkID_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.KCCNetworkID @NetworkID = (Fusion.Addons.KCC.KCCNetworkID)typeof(Fusion.Addons.KCC.KCCNetworkID).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.Addons.KCC.KCCIgnore)o).NetworkID = @NetworkID;
            return ptr_of_this_method;
        }

        static object get_NetworkObject_1(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCIgnore)o).NetworkObject;
        }

        static StackObject* CopyToStack_NetworkObject_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCIgnore)o).NetworkObject;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_NetworkObject_1(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCIgnore)o).NetworkObject = (Fusion.NetworkObject)v;
        }

        static StackObject* AssignFromStack_NetworkObject_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.NetworkObject @NetworkObject = (Fusion.NetworkObject)typeof(Fusion.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCIgnore)o).NetworkObject = @NetworkObject;
            return ptr_of_this_method;
        }

        static object get_Collider_2(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCIgnore)o).Collider;
        }

        static StackObject* CopyToStack_Collider_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCIgnore)o).Collider;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Collider_2(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCIgnore)o).Collider = (UnityEngine.Collider)v;
        }

        static StackObject* AssignFromStack_Collider_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Collider @Collider = (UnityEngine.Collider)typeof(UnityEngine.Collider).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCIgnore)o).Collider = @Collider;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Addons.KCC.KCCIgnore();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

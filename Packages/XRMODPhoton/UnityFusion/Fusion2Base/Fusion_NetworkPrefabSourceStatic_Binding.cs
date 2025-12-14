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
    unsafe class Fusion_NetworkPrefabSourceStatic_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.NetworkPrefabSourceStatic);

            field = type.GetField("AssetGuid", flag);
            app.RegisterCLRFieldGetter(field, get_AssetGuid_0);
            app.RegisterCLRFieldSetter(field, set_AssetGuid_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_AssetGuid_0, AssignFromStack_AssetGuid_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.NetworkPrefabSourceStatic());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.NetworkPrefabSourceStatic[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_AssetGuid_0(ref object o)
        {
            return ((Fusion.NetworkPrefabSourceStatic)o).AssetGuid;
        }

        static StackObject* CopyToStack_AssetGuid_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.NetworkPrefabSourceStatic)o).AssetGuid;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_AssetGuid_0(ref object o, object v)
        {
            ((Fusion.NetworkPrefabSourceStatic)o).AssetGuid = (Fusion.NetworkObjectGuid)v;
        }

        static StackObject* AssignFromStack_AssetGuid_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.NetworkObjectGuid @AssetGuid = (Fusion.NetworkObjectGuid)typeof(Fusion.NetworkObjectGuid).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            ((Fusion.NetworkPrefabSourceStatic)o).AssetGuid = @AssetGuid;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.NetworkPrefabSourceStatic();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

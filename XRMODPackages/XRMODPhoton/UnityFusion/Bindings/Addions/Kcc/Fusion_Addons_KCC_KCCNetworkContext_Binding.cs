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
    unsafe class Fusion_Addons_KCC_KCCNetworkContext_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.KCC.KCCNetworkContext);

            field = type.GetField("KCC", flag);
            app.RegisterCLRFieldGetter(field, get_KCC_0);
            app.RegisterCLRFieldSetter(field, set_KCC_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_KCC_0, AssignFromStack_KCC_0);
            field = type.GetField("Data", flag);
            app.RegisterCLRFieldGetter(field, get_Data_1);
            app.RegisterCLRFieldSetter(field, set_Data_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Data_1, AssignFromStack_Data_1);
            field = type.GetField("Settings", flag);
            app.RegisterCLRFieldGetter(field, get_Settings_2);
            app.RegisterCLRFieldSetter(field, set_Settings_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Settings_2, AssignFromStack_Settings_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.KCCNetworkContext());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.KCCNetworkContext[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_KCC_0(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCNetworkContext)o).KCC;
        }

        static StackObject* CopyToStack_KCC_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCNetworkContext)o).KCC;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_KCC_0(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCNetworkContext)o).KCC = (Fusion.Addons.KCC.KCC)v;
        }

        static StackObject* AssignFromStack_KCC_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.KCC @KCC = (Fusion.Addons.KCC.KCC)typeof(Fusion.Addons.KCC.KCC).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCNetworkContext)o).KCC = @KCC;
            return ptr_of_this_method;
        }

        static object get_Data_1(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCNetworkContext)o).Data;
        }

        static StackObject* CopyToStack_Data_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCNetworkContext)o).Data;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Data_1(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCNetworkContext)o).Data = (Fusion.Addons.KCC.KCCData)v;
        }

        static StackObject* AssignFromStack_Data_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.KCCData @Data = (Fusion.Addons.KCC.KCCData)typeof(Fusion.Addons.KCC.KCCData).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCNetworkContext)o).Data = @Data;
            return ptr_of_this_method;
        }

        static object get_Settings_2(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCNetworkContext)o).Settings;
        }

        static StackObject* CopyToStack_Settings_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCNetworkContext)o).Settings;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Settings_2(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCNetworkContext)o).Settings = (Fusion.Addons.KCC.KCCSettings)v;
        }

        static StackObject* AssignFromStack_Settings_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.KCCSettings @Settings = (Fusion.Addons.KCC.KCCSettings)typeof(Fusion.Addons.KCC.KCCSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCNetworkContext)o).Settings = @Settings;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Addons.KCC.KCCNetworkContext();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
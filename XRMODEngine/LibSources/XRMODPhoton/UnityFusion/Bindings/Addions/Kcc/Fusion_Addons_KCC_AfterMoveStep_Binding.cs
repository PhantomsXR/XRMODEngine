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
    unsafe class Fusion_Addons_KCC_AfterMoveStep_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.KCC.AfterMoveStep);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("RequestUpdateHits", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RequestUpdateHits_0);

            field = type.GetField("OverlapInfo", flag);
            app.RegisterCLRFieldGetter(field, get_OverlapInfo_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_OverlapInfo_0, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.AfterMoveStep());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.AfterMoveStep[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* RequestUpdateHits_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @forceNewOverlapQuery = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.AfterMoveStep instance_of_this_method = (Fusion.Addons.KCC.AfterMoveStep)typeof(Fusion.Addons.KCC.AfterMoveStep).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RequestUpdateHits(@forceNewOverlapQuery);

            return __ret;
        }


        static object get_OverlapInfo_0(ref object o)
        {
            return ((Fusion.Addons.KCC.AfterMoveStep)o).OverlapInfo;
        }

        static StackObject* CopyToStack_OverlapInfo_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.AfterMoveStep)o).OverlapInfo;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Addons.KCC.AfterMoveStep();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif

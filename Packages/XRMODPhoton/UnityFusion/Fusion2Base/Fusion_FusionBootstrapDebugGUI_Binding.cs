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
    unsafe class Fusion_FusionBootstrapDebugGUI_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.FusionBootstrapDebugGUI);

            field = type.GetField("EnableHotkeys", flag);
            app.RegisterCLRFieldGetter(field, get_EnableHotkeys_0);
            app.RegisterCLRFieldSetter(field, set_EnableHotkeys_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_EnableHotkeys_0, AssignFromStack_EnableHotkeys_0);
            field = type.GetField("BaseSkin", flag);
            app.RegisterCLRFieldGetter(field, get_BaseSkin_1);
            app.RegisterCLRFieldSetter(field, set_BaseSkin_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_BaseSkin_1, AssignFromStack_BaseSkin_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.FusionBootstrapDebugGUI());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.FusionBootstrapDebugGUI[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_EnableHotkeys_0(ref object o)
        {
            return ((Fusion.FusionBootstrapDebugGUI)o).EnableHotkeys;
        }

        static StackObject* CopyToStack_EnableHotkeys_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.FusionBootstrapDebugGUI)o).EnableHotkeys;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_EnableHotkeys_0(ref object o, object v)
        {
            ((Fusion.FusionBootstrapDebugGUI)o).EnableHotkeys = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_EnableHotkeys_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @EnableHotkeys = ptr_of_this_method->Value == 1;
            ((Fusion.FusionBootstrapDebugGUI)o).EnableHotkeys = @EnableHotkeys;
            return ptr_of_this_method;
        }

        static object get_BaseSkin_1(ref object o)
        {
            return ((Fusion.FusionBootstrapDebugGUI)o).BaseSkin;
        }

        static StackObject* CopyToStack_BaseSkin_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.FusionBootstrapDebugGUI)o).BaseSkin;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_BaseSkin_1(ref object o, object v)
        {
            ((Fusion.FusionBootstrapDebugGUI)o).BaseSkin = (UnityEngine.GUISkin)v;
        }

        static StackObject* AssignFromStack_BaseSkin_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.GUISkin @BaseSkin = (UnityEngine.GUISkin)typeof(UnityEngine.GUISkin).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.FusionBootstrapDebugGUI)o).BaseSkin = @BaseSkin;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.FusionBootstrapDebugGUI();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

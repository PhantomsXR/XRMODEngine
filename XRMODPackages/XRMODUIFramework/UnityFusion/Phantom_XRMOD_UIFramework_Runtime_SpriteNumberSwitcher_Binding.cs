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
    unsafe class Phantom_XRMOD_UIFramework_Runtime_SpriteNumberSwitcher_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.UIFramework.Runtime.SpriteNumberSwitcher);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("SetValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetValue_0);

            field = type.GetField("Sprites", flag);
            app.RegisterCLRFieldGetter(field, get_Sprites_0);
            app.RegisterCLRFieldSetter(field, set_Sprites_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Sprites_0, AssignFromStack_Sprites_0);
            field = type.GetField("MaxValue", flag);
            app.RegisterCLRFieldGetter(field, get_MaxValue_1);
            app.RegisterCLRFieldSetter(field, set_MaxValue_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_MaxValue_1, AssignFromStack_MaxValue_1);
            field = type.GetField("Target", flag);
            app.RegisterCLRFieldGetter(field, get_Target_2);
            app.RegisterCLRFieldSetter(field, set_Target_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Target_2, AssignFromStack_Target_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.UIFramework.Runtime.SpriteNumberSwitcher());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.UIFramework.Runtime.SpriteNumberSwitcher[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* SetValue_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.SpriteNumberSwitcher instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.SpriteNumberSwitcher)typeof(Phantom.XRMOD.UIFramework.Runtime.SpriteNumberSwitcher).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetValue(@value);

            return __ret;
        }


        static object get_Sprites_0(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.SpriteNumberSwitcher)o).Sprites;
        }

        static StackObject* CopyToStack_Sprites_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.SpriteNumberSwitcher)o).Sprites;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Sprites_0(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.SpriteNumberSwitcher)o).Sprites = (UnityEngine.Sprite[])v;
        }

        static StackObject* AssignFromStack_Sprites_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Sprite[] @Sprites = (UnityEngine.Sprite[])typeof(UnityEngine.Sprite[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.SpriteNumberSwitcher)o).Sprites = @Sprites;
            return ptr_of_this_method;
        }

        static object get_MaxValue_1(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.SpriteNumberSwitcher)o).MaxValue;
        }

        static StackObject* CopyToStack_MaxValue_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.SpriteNumberSwitcher)o).MaxValue;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_MaxValue_1(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.SpriteNumberSwitcher)o).MaxValue = (System.Single)v;
        }

        static StackObject* AssignFromStack_MaxValue_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @MaxValue = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.UIFramework.Runtime.SpriteNumberSwitcher)o).MaxValue = @MaxValue;
            return ptr_of_this_method;
        }

        static object get_Target_2(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.SpriteNumberSwitcher)o).Target;
        }

        static StackObject* CopyToStack_Target_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.SpriteNumberSwitcher)o).Target;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Target_2(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.SpriteNumberSwitcher)o).Target = (UnityEngine.UI.Image)v;
        }

        static StackObject* AssignFromStack_Target_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.UI.Image @Target = (UnityEngine.UI.Image)typeof(UnityEngine.UI.Image).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.UIFramework.Runtime.SpriteNumberSwitcher)o).Target = @Target;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.UIFramework.Runtime.SpriteNumberSwitcher();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

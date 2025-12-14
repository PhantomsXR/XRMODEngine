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
    unsafe class Phantom_XRMOD_XRMODUtilites_Runtime_HoverEffectComponentAdapter_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter);

            field = type.GetField("Color", flag);
            app.RegisterCLRFieldGetter(field, get_Color_0);
            app.RegisterCLRFieldSetter(field, set_Color_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Color_0, AssignFromStack_Color_0);
            field = type.GetField("IntensityMultiplier", flag);
            app.RegisterCLRFieldGetter(field, get_IntensityMultiplier_1);
            app.RegisterCLRFieldSetter(field, set_IntensityMultiplier_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_IntensityMultiplier_1, AssignFromStack_IntensityMultiplier_1);
            field = type.GetField("FadeInDuration", flag);
            app.RegisterCLRFieldGetter(field, get_FadeInDuration_2);
            app.RegisterCLRFieldSetter(field, set_FadeInDuration_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_FadeInDuration_2, AssignFromStack_FadeInDuration_2);
            field = type.GetField("FadeOutDuration", flag);
            app.RegisterCLRFieldGetter(field, get_FadeOutDuration_3);
            app.RegisterCLRFieldSetter(field, set_FadeOutDuration_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_FadeOutDuration_3, AssignFromStack_FadeOutDuration_3);
            field = type.GetField("EffectType", flag);
            app.RegisterCLRFieldGetter(field, get_EffectType_4);
            app.RegisterCLRFieldSetter(field, set_EffectType_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_EffectType_4, AssignFromStack_EffectType_4);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_Color_0(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter)o).Color;
        }

        static StackObject* CopyToStack_Color_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter)o).Color;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Color_0(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter)o).Color = (Phantom.XRMOD.Core.Runtime.BindableProperty<UnityEngine.Color>)v;
        }

        static StackObject* AssignFromStack_Color_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.Core.Runtime.BindableProperty<UnityEngine.Color> @Color = (Phantom.XRMOD.Core.Runtime.BindableProperty<UnityEngine.Color>)typeof(Phantom.XRMOD.Core.Runtime.BindableProperty<UnityEngine.Color>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter)o).Color = @Color;
            return ptr_of_this_method;
        }

        static object get_IntensityMultiplier_1(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter)o).IntensityMultiplier;
        }

        static StackObject* CopyToStack_IntensityMultiplier_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter)o).IntensityMultiplier;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_IntensityMultiplier_1(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter)o).IntensityMultiplier = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Single>)v;
        }

        static StackObject* AssignFromStack_IntensityMultiplier_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.Core.Runtime.BindableProperty<System.Single> @IntensityMultiplier = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Single>)typeof(Phantom.XRMOD.Core.Runtime.BindableProperty<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter)o).IntensityMultiplier = @IntensityMultiplier;
            return ptr_of_this_method;
        }

        static object get_FadeInDuration_2(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter)o).FadeInDuration;
        }

        static StackObject* CopyToStack_FadeInDuration_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter)o).FadeInDuration;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_FadeInDuration_2(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter)o).FadeInDuration = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Single>)v;
        }

        static StackObject* AssignFromStack_FadeInDuration_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.Core.Runtime.BindableProperty<System.Single> @FadeInDuration = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Single>)typeof(Phantom.XRMOD.Core.Runtime.BindableProperty<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter)o).FadeInDuration = @FadeInDuration;
            return ptr_of_this_method;
        }

        static object get_FadeOutDuration_3(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter)o).FadeOutDuration;
        }

        static StackObject* CopyToStack_FadeOutDuration_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter)o).FadeOutDuration;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_FadeOutDuration_3(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter)o).FadeOutDuration = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Single>)v;
        }

        static StackObject* AssignFromStack_FadeOutDuration_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.Core.Runtime.BindableProperty<System.Single> @FadeOutDuration = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Single>)typeof(Phantom.XRMOD.Core.Runtime.BindableProperty<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter)o).FadeOutDuration = @FadeOutDuration;
            return ptr_of_this_method;
        }

        static object get_EffectType_4(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter)o).EffectType;
        }

        static StackObject* CopyToStack_EffectType_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter)o).EffectType;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_EffectType_4(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter)o).EffectType = (Phantom.XRMOD.Core.Runtime.BindableProperty<Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter.HoverEffectType>)v;
        }

        static StackObject* AssignFromStack_EffectType_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.Core.Runtime.BindableProperty<Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter.HoverEffectType> @EffectType = (Phantom.XRMOD.Core.Runtime.BindableProperty<Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter.HoverEffectType>)typeof(Phantom.XRMOD.Core.Runtime.BindableProperty<Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter.HoverEffectType>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter)o).EffectType = @EffectType;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.XRMODUtilites.Runtime.HoverEffectComponentAdapter();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

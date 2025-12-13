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
    unsafe class Phantom_XRMOD_XRMODUtilites_Runtime_VideoComponentAdapter_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter);

            field = type.GetField("TargetMaterialRenderer", flag);
            app.RegisterCLRFieldGetter(field, get_TargetMaterialRenderer_0);
            app.RegisterCLRFieldSetter(field, set_TargetMaterialRenderer_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_TargetMaterialRenderer_0, AssignFromStack_TargetMaterialRenderer_0);
            field = type.GetField("Clip", flag);
            app.RegisterCLRFieldGetter(field, get_Clip_1);
            app.RegisterCLRFieldSetter(field, set_Clip_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Clip_1, AssignFromStack_Clip_1);
            field = type.GetField("IsLooping", flag);
            app.RegisterCLRFieldGetter(field, get_IsLooping_2);
            app.RegisterCLRFieldSetter(field, set_IsLooping_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsLooping_2, AssignFromStack_IsLooping_2);
            field = type.GetField("PlayOnAwake", flag);
            app.RegisterCLRFieldGetter(field, get_PlayOnAwake_3);
            app.RegisterCLRFieldSetter(field, set_PlayOnAwake_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_PlayOnAwake_3, AssignFromStack_PlayOnAwake_3);
            field = type.GetField("Mute", flag);
            app.RegisterCLRFieldGetter(field, get_Mute_4);
            app.RegisterCLRFieldSetter(field, set_Mute_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Mute_4, AssignFromStack_Mute_4);
            field = type.GetField("Volume", flag);
            app.RegisterCLRFieldGetter(field, get_Volume_5);
            app.RegisterCLRFieldSetter(field, set_Volume_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_Volume_5, AssignFromStack_Volume_5);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }



        static object get_TargetMaterialRenderer_0(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).TargetMaterialRenderer;
        }

        static StackObject* CopyToStack_TargetMaterialRenderer_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).TargetMaterialRenderer;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_TargetMaterialRenderer_0(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).TargetMaterialRenderer = (Phantom.XRMOD.Core.Runtime.BindableProperty<UnityEngine.MeshRenderer>)v;
        }

        static StackObject* AssignFromStack_TargetMaterialRenderer_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.Core.Runtime.BindableProperty<UnityEngine.MeshRenderer> @TargetMaterialRenderer = (Phantom.XRMOD.Core.Runtime.BindableProperty<UnityEngine.MeshRenderer>)typeof(Phantom.XRMOD.Core.Runtime.BindableProperty<UnityEngine.MeshRenderer>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).TargetMaterialRenderer = @TargetMaterialRenderer;
            return ptr_of_this_method;
        }

        static object get_Clip_1(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).Clip;
        }

        static StackObject* CopyToStack_Clip_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).Clip;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Clip_1(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).Clip = (Phantom.XRMOD.Core.Runtime.BindableProperty<UnityEngine.Video.VideoClip>)v;
        }

        static StackObject* AssignFromStack_Clip_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.Core.Runtime.BindableProperty<UnityEngine.Video.VideoClip> @Clip = (Phantom.XRMOD.Core.Runtime.BindableProperty<UnityEngine.Video.VideoClip>)typeof(Phantom.XRMOD.Core.Runtime.BindableProperty<UnityEngine.Video.VideoClip>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).Clip = @Clip;
            return ptr_of_this_method;
        }

        static object get_IsLooping_2(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).IsLooping;
        }

        static StackObject* CopyToStack_IsLooping_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).IsLooping;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_IsLooping_2(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).IsLooping = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_IsLooping_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.Core.Runtime.BindableProperty<System.Boolean> @IsLooping = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Boolean>)typeof(Phantom.XRMOD.Core.Runtime.BindableProperty<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).IsLooping = @IsLooping;
            return ptr_of_this_method;
        }

        static object get_PlayOnAwake_3(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).PlayOnAwake;
        }

        static StackObject* CopyToStack_PlayOnAwake_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).PlayOnAwake;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PlayOnAwake_3(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).PlayOnAwake = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_PlayOnAwake_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.Core.Runtime.BindableProperty<System.Boolean> @PlayOnAwake = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Boolean>)typeof(Phantom.XRMOD.Core.Runtime.BindableProperty<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).PlayOnAwake = @PlayOnAwake;
            return ptr_of_this_method;
        }

        static object get_Mute_4(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).Mute;
        }

        static StackObject* CopyToStack_Mute_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).Mute;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Mute_4(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).Mute = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Boolean>)v;
        }

        static StackObject* AssignFromStack_Mute_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.Core.Runtime.BindableProperty<System.Boolean> @Mute = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Boolean>)typeof(Phantom.XRMOD.Core.Runtime.BindableProperty<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).Mute = @Mute;
            return ptr_of_this_method;
        }

        static object get_Volume_5(ref object o)
        {
            return ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).Volume;
        }

        static StackObject* CopyToStack_Volume_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).Volume;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Volume_5(ref object o, object v)
        {
            ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).Volume = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Single>)v;
        }

        static StackObject* AssignFromStack_Volume_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.Core.Runtime.BindableProperty<System.Single> @Volume = (Phantom.XRMOD.Core.Runtime.BindableProperty<System.Single>)typeof(Phantom.XRMOD.Core.Runtime.BindableProperty<System.Single>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter)o).Volume = @Volume;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.XRMODUtilites.Runtime.VideoComponentAdapter();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

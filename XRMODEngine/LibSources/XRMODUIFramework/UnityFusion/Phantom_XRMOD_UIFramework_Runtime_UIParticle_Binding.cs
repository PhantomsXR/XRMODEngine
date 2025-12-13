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
    unsafe class Phantom_XRMOD_UIFramework_Runtime_UIParticle_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle);
            args = new Type[]{};
            method = type.GetMethod("get_raycastTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_raycastTarget_0);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_raycastTarget", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_raycastTarget_1);
            args = new Type[]{};
            method = type.GetMethod("get_ignoreCanvasScaler", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_ignoreCanvasScaler_2);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_ignoreCanvasScaler", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_ignoreCanvasScaler_3);
            args = new Type[]{};
            method = type.GetMethod("get_shrinkByMaterial", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_shrinkByMaterial_4);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_shrinkByMaterial", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_shrinkByMaterial_5);
            args = new Type[]{};
            method = type.GetMethod("get_scale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_scale_6);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_scale", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_scale_7);
            args = new Type[]{};
            method = type.GetMethod("get_scale3D", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_scale3D_8);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("set_scale3D", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_scale3D_9);
            args = new Type[]{};
            method = type.GetMethod("get_particles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_particles_10);
            args = new Type[]{};
            method = type.GetMethod("get_materials", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_materials_11);
            args = new Type[]{};
            method = type.GetMethod("get_materialForRendering", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_materialForRendering_12);
            args = new Type[]{};
            method = type.GetMethod("get_activeMeshIndices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_activeMeshIndices_13);
            args = new Type[]{typeof(System.Collections.Generic.List<System.Boolean>)};
            method = type.GetMethod("set_activeMeshIndices", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_activeMeshIndices_14);
            args = new Type[]{};
            method = type.GetMethod("Play", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Play_15);
            args = new Type[]{};
            method = type.GetMethod("Pause", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Pause_16);
            args = new Type[]{};
            method = type.GetMethod("Stop", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Stop_17);
            args = new Type[]{};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_18);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("SetParticleSystemInstance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetParticleSystemInstance_19);
            args = new Type[]{typeof(UnityEngine.GameObject), typeof(System.Boolean)};
            method = type.GetMethod("SetParticleSystemInstance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetParticleSystemInstance_20);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("SetParticleSystemPrefab", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetParticleSystemPrefab_21);
            args = new Type[]{};
            method = type.GetMethod("RefreshParticles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RefreshParticles_22);
            args = new Type[]{typeof(UnityEngine.GameObject)};
            method = type.GetMethod("RefreshParticles", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RefreshParticles_23);



            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.UIFramework.Runtime.UIParticle());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.UIFramework.Runtime.UIParticle[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_raycastTarget_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.raycastTarget;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_raycastTarget_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.raycastTarget = value;

            return __ret;
        }

        static StackObject* get_ignoreCanvasScaler_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ignoreCanvasScaler;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_ignoreCanvasScaler_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ignoreCanvasScaler = value;

            return __ret;
        }

        static StackObject* get_shrinkByMaterial_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.shrinkByMaterial;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_shrinkByMaterial_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.shrinkByMaterial = value;

            return __ret;
        }

        static StackObject* get_scale_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.scale;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_scale_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.scale = value;

            return __ret;
        }

        static StackObject* get_scale3D_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.scale3D;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_scale3D_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @value = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.scale3D = value;

            return __ret;
        }

        static StackObject* get_particles_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.particles;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_materials_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.materials;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_materialForRendering_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.materialForRendering;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_activeMeshIndices_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.activeMeshIndices;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_activeMeshIndices_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<System.Boolean> @value = (System.Collections.Generic.List<System.Boolean>)typeof(System.Collections.Generic.List<System.Boolean>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.activeMeshIndices = value;

            return __ret;
        }

        static StackObject* Play_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Play();

            return __ret;
        }

        static StackObject* Pause_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Pause();

            return __ret;
        }

        static StackObject* Stop_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Stop();

            return __ret;
        }

        static StackObject* Clear_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Clear();

            return __ret;
        }

        static StackObject* SetParticleSystemInstance_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @instance = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetParticleSystemInstance(@instance);

            return __ret;
        }

        static StackObject* SetParticleSystemInstance_20(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @destroyOldParticles = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.GameObject @instance = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetParticleSystemInstance(@instance, @destroyOldParticles);

            return __ret;
        }

        static StackObject* SetParticleSystemPrefab_21(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @prefab = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetParticleSystemPrefab(@prefab);

            return __ret;
        }

        static StackObject* RefreshParticles_22(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RefreshParticles();

            return __ret;
        }

        static StackObject* RefreshParticles_23(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.GameObject @root = (UnityEngine.GameObject)typeof(UnityEngine.GameObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.UIFramework.Runtime.UIParticle instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticle)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticle).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RefreshParticles(@root);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.UIFramework.Runtime.UIParticle();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

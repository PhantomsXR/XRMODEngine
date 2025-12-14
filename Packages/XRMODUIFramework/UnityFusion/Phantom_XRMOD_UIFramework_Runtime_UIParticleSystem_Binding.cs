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
    unsafe class Phantom_XRMOD_UIFramework_Runtime_UIParticleSystem_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem);
            args = new Type[]{};
            method = type.GetMethod("get_mainTexture", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_mainTexture_0);
            args = new Type[]{};
            method = type.GetMethod("StartParticleEmission", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StartParticleEmission_1);
            args = new Type[]{};
            method = type.GetMethod("StopParticleEmission", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, StopParticleEmission_2);
            args = new Type[]{};
            method = type.GetMethod("PauseParticleEmission", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, PauseParticleEmission_3);

            field = type.GetField("fixedTime", flag);
            app.RegisterCLRFieldGetter(field, get_fixedTime_0);
            app.RegisterCLRFieldSetter(field, set_fixedTime_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_fixedTime_0, AssignFromStack_fixedTime_0);
            field = type.GetField("use3dRotation", flag);
            app.RegisterCLRFieldGetter(field, get_use3dRotation_1);
            app.RegisterCLRFieldSetter(field, set_use3dRotation_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_use3dRotation_1, AssignFromStack_use3dRotation_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_mainTexture_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.mainTexture;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* StartParticleEmission_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StartParticleEmission();

            return __ret;
        }

        static StackObject* StopParticleEmission_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.StopParticleEmission();

            return __ret;
        }

        static StackObject* PauseParticleEmission_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem instance_of_this_method = (Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem)typeof(Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.PauseParticleEmission();

            return __ret;
        }


        static object get_fixedTime_0(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem)o).fixedTime;
        }

        static StackObject* CopyToStack_fixedTime_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem)o).fixedTime;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_fixedTime_0(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem)o).fixedTime = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_fixedTime_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @fixedTime = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem)o).fixedTime = @fixedTime;
            return ptr_of_this_method;
        }

        static object get_use3dRotation_1(ref object o)
        {
            return ((Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem)o).use3dRotation;
        }

        static StackObject* CopyToStack_use3dRotation_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem)o).use3dRotation;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_use3dRotation_1(ref object o, object v)
        {
            ((Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem)o).use3dRotation = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_use3dRotation_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @use3dRotation = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem)o).use3dRotation = @use3dRotation;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.UIFramework.Runtime.UIParticleSystem();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

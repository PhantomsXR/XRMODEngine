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
    unsafe class Phantom_XRMOD_BaseFeatures_Runtime_Models_BaseFeatureModel_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel);
            args = new Type[]{};
            method = type.GetMethod("Initialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Initialize_0);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("Release", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Release_1);

            field = type.GetField("GltfFileCacheManager", flag);
            app.RegisterCLRFieldGetter(field, get_GltfFileCacheManager_0);
            app.RegisterCLRFieldSetter(field, set_GltfFileCacheManager_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_GltfFileCacheManager_0, AssignFromStack_GltfFileCacheManager_0);
            field = type.GetField("Processes", flag);
            app.RegisterCLRFieldGetter(field, get_Processes_1);
            app.RegisterCLRFieldSetter(field, set_Processes_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Processes_1, AssignFromStack_Processes_1);
            field = type.GetField("EventSystem", flag);
            app.RegisterCLRFieldGetter(field, get_EventSystem_2);
            app.RegisterCLRFieldSetter(field, set_EventSystem_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_EventSystem_2, AssignFromStack_EventSystem_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Initialize_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel instance_of_this_method = (Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel)typeof(Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Initialize();

            return __ret;
        }

        static StackObject* Release_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_projectName = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel instance_of_this_method = (Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel)typeof(Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Release(@_projectName);

            return __ret;
        }


        static object get_GltfFileCacheManager_0(ref object o)
        {
            return ((Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel)o).GltfFileCacheManager;
        }

        static StackObject* CopyToStack_GltfFileCacheManager_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel)o).GltfFileCacheManager;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_GltfFileCacheManager_0(ref object o, object v)
        {
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel)o).GltfFileCacheManager = (Phantom.XRMOD.GLTFExtension.Runtime.GltfFileCacheManager)v;
        }

        static StackObject* AssignFromStack_GltfFileCacheManager_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Phantom.XRMOD.GLTFExtension.Runtime.GltfFileCacheManager @GltfFileCacheManager = (Phantom.XRMOD.GLTFExtension.Runtime.GltfFileCacheManager)typeof(Phantom.XRMOD.GLTFExtension.Runtime.GltfFileCacheManager).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel)o).GltfFileCacheManager = @GltfFileCacheManager;
            return ptr_of_this_method;
        }

        static object get_Processes_1(ref object o)
        {
            return ((Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel)o).Processes;
        }

        static StackObject* CopyToStack_Processes_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel)o).Processes;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Processes_1(ref object o, object v)
        {
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel)o).Processes = (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>>)v;
        }

        static StackObject* AssignFromStack_Processes_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>> @Processes = (System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>>)typeof(System.Collections.Generic.Dictionary<System.String, System.Collections.Generic.List<System.String>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel)o).Processes = @Processes;
            return ptr_of_this_method;
        }

        static object get_EventSystem_2(ref object o)
        {
            return ((Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel)o).EventSystem;
        }

        static StackObject* CopyToStack_EventSystem_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel)o).EventSystem;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_EventSystem_2(ref object o, object v)
        {
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel)o).EventSystem = (UnityEngine.EventSystems.EventSystem)v;
        }

        static StackObject* AssignFromStack_EventSystem_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.EventSystems.EventSystem @EventSystem = (UnityEngine.EventSystems.EventSystem)typeof(UnityEngine.EventSystems.EventSystem).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel)o).EventSystem = @EventSystem;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.BaseFeatures.Runtime.Models.BaseFeatureModel();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

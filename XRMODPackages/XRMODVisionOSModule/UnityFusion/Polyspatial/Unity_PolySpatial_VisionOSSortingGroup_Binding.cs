using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using UnityEngine.Rendering;
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
    unsafe class Unity_PolySpatial_VisionOSSortingGroup_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Unity.PolySpatial.VisionOSSortingGroup);
            args = new Type[]{};
            method = type.GetMethod("get_depthPass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_depthPass_0);
            args = new Type[]{typeof(Unity.PolySpatial.VisionOSSortingGroup.DepthPassType)};
            method = type.GetMethod("set_depthPass", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_depthPass_1);
            args = new Type[]{};
            method = type.GetMethod("get_renderers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_renderers_2);
            args = new Type[]{typeof(System.Collections.Generic.List<Unity.PolySpatial.VisionOSSortingGroup.RendererSorting>)};
            method = type.GetMethod("set_renderers", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_renderers_3);



            app.RegisterCLRCreateDefaultInstance(type, () => new Unity.PolySpatial.VisionOSSortingGroup());
            app.RegisterCLRCreateArrayInstance(type, s => new Unity.PolySpatial.VisionOSSortingGroup[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_depthPass_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSSortingGroup instance_of_this_method = (Unity.PolySpatial.VisionOSSortingGroup)typeof(Unity.PolySpatial.VisionOSSortingGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DepthPass;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_depthPass_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSSortingGroup.DepthPassType @value = (Unity.PolySpatial.VisionOSSortingGroup.DepthPassType)typeof(Unity.PolySpatial.VisionOSSortingGroup.DepthPassType).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VisionOSSortingGroup instance_of_this_method = (Unity.PolySpatial.VisionOSSortingGroup)typeof(Unity.PolySpatial.VisionOSSortingGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DepthPass = value;

            return __ret;
        }

        static StackObject* get_renderers_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Unity.PolySpatial.VisionOSSortingGroup instance_of_this_method = (Unity.PolySpatial.VisionOSSortingGroup)typeof(Unity.PolySpatial.VisionOSSortingGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Renderers;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* set_renderers_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            ObservableList<Unity.PolySpatial.VisionOSSortingGroup.RendererSorting> @value = (ObservableList<Unity.PolySpatial.VisionOSSortingGroup.RendererSorting>)typeof(System.Collections.Generic.List<Unity.PolySpatial.VisionOSSortingGroup.RendererSorting>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Unity.PolySpatial.VisionOSSortingGroup instance_of_this_method = (Unity.PolySpatial.VisionOSSortingGroup)typeof(Unity.PolySpatial.VisionOSSortingGroup).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Renderers = value;

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Unity.PolySpatial.VisionOSSortingGroup();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

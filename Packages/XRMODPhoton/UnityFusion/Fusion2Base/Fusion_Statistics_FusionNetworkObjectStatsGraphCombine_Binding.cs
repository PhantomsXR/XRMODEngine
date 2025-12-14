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
    unsafe class Fusion_Statistics_FusionNetworkObjectStatsGraphCombine_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Fusion.Statistics.FusionNetworkObjectStatsGraphCombine);
            args = new Type[]{};
            method = type.GetMethod("get_NetworkObjectID", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_NetworkObjectID_0);
            args = new Type[]{typeof(Fusion.NetworkObject), typeof(Fusion.Statistics.FusionStatistics), typeof(Fusion.Statistics.FusionNetworkObjectStatistics)};
            method = type.GetMethod("SetupNetworkObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetupNetworkObject_1);
            args = new Type[]{};
            method = type.GetMethod("ToggleRenderDisplay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToggleRenderDisplay_2);
            args = new Type[]{};
            method = type.GetMethod("DestroyCombinedGraph", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DestroyCombinedGraph_3);



            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Statistics.FusionNetworkObjectStatsGraphCombine());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Statistics.FusionNetworkObjectStatsGraphCombine[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_NetworkObjectID_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Statistics.FusionNetworkObjectStatsGraphCombine instance_of_this_method = (Fusion.Statistics.FusionNetworkObjectStatsGraphCombine)typeof(Fusion.Statistics.FusionNetworkObjectStatsGraphCombine).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.NetworkObjectID;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetupNetworkObject_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Statistics.FusionNetworkObjectStatistics @objectStatisticsInstance = (Fusion.Statistics.FusionNetworkObjectStatistics)typeof(Fusion.Statistics.FusionNetworkObjectStatistics).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Statistics.FusionStatistics @fusionStatistics = (Fusion.Statistics.FusionStatistics)typeof(Fusion.Statistics.FusionStatistics).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.NetworkObject @networkObject = (Fusion.NetworkObject)typeof(Fusion.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Fusion.Statistics.FusionNetworkObjectStatsGraphCombine instance_of_this_method = (Fusion.Statistics.FusionNetworkObjectStatsGraphCombine)typeof(Fusion.Statistics.FusionNetworkObjectStatsGraphCombine).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetupNetworkObject(@networkObject, @fusionStatistics, @objectStatisticsInstance);

            return __ret;
        }

        static StackObject* ToggleRenderDisplay_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Statistics.FusionNetworkObjectStatsGraphCombine instance_of_this_method = (Fusion.Statistics.FusionNetworkObjectStatsGraphCombine)typeof(Fusion.Statistics.FusionNetworkObjectStatsGraphCombine).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ToggleRenderDisplay();

            return __ret;
        }

        static StackObject* DestroyCombinedGraph_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Statistics.FusionNetworkObjectStatsGraphCombine instance_of_this_method = (Fusion.Statistics.FusionNetworkObjectStatsGraphCombine)typeof(Fusion.Statistics.FusionNetworkObjectStatsGraphCombine).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DestroyCombinedGraph();

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Statistics.FusionNetworkObjectStatsGraphCombine();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

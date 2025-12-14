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
    unsafe class Fusion_Statistics_FusionStatistics_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Fusion.Statistics.FusionStatistics);
            args = new Type[]{};
            method = type.GetMethod("get_IsPanelActive", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsPanelActive_0);
            args = new Type[]{typeof(System.Collections.Generic.List<Fusion.Statistics.FusionStatistics.FusionStatisticsStatCustomConfig>)};
            method = type.GetMethod("SetStatsCustomConfig", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetStatsCustomConfig_1);
            args = new Type[]{typeof(Fusion.Statistics.CanvasAnchor)};
            method = type.GetMethod("SetCanvasAnchor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetCanvasAnchor_2);
            args = new Type[]{};
            method = type.GetMethod("OnEditorChange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, OnEditorChange_3);
            args = new Type[]{};
            method = type.GetMethod("SetupStatisticsPanel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetupStatisticsPanel_4);
            args = new Type[]{typeof(Fusion.Statistics.FusionStatsWorldAnchor), typeof(System.Single)};
            method = type.GetMethod("SetWorldAnchor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetWorldAnchor_5);
            args = new Type[]{};
            method = type.GetMethod("DestroyStatisticsPanel", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DestroyStatisticsPanel_6);
            args = new Type[]{typeof(Fusion.NetworkObject), typeof(Fusion.Statistics.FusionNetworkObjectStatistics), typeof(System.Boolean)};
            method = type.GetMethod("MonitorNetworkObject", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, MonitorNetworkObject_7);
            args = new Type[]{typeof(Fusion.Statistics.FusionStatsGraphBase)};
            method = type.GetMethod("RegisterGraph", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterGraph_8);
            args = new Type[]{typeof(Fusion.Statistics.FusionStatsGraphBase)};
            method = type.GetMethod("UnregisterGraph", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, UnregisterGraph_9);



            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Statistics.FusionStatistics());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Statistics.FusionStatistics[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_IsPanelActive_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Statistics.FusionStatistics instance_of_this_method = (Fusion.Statistics.FusionStatistics)typeof(Fusion.Statistics.FusionStatistics).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsPanelActive;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SetStatsCustomConfig_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Collections.Generic.List<Fusion.Statistics.FusionStatistics.FusionStatisticsStatCustomConfig> @customConfig = (System.Collections.Generic.List<Fusion.Statistics.FusionStatistics.FusionStatisticsStatCustomConfig>)typeof(System.Collections.Generic.List<Fusion.Statistics.FusionStatistics.FusionStatisticsStatCustomConfig>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Statistics.FusionStatistics instance_of_this_method = (Fusion.Statistics.FusionStatistics)typeof(Fusion.Statistics.FusionStatistics).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetStatsCustomConfig(@customConfig);

            return __ret;
        }

        static StackObject* SetCanvasAnchor_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Statistics.CanvasAnchor @anchor = (Fusion.Statistics.CanvasAnchor)typeof(Fusion.Statistics.CanvasAnchor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Statistics.FusionStatistics instance_of_this_method = (Fusion.Statistics.FusionStatistics)typeof(Fusion.Statistics.FusionStatistics).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetCanvasAnchor(@anchor);

            return __ret;
        }

        static StackObject* OnEditorChange_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Statistics.FusionStatistics instance_of_this_method = (Fusion.Statistics.FusionStatistics)typeof(Fusion.Statistics.FusionStatistics).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnEditorChange();

            return __ret;
        }

        static StackObject* SetupStatisticsPanel_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Statistics.FusionStatistics instance_of_this_method = (Fusion.Statistics.FusionStatistics)typeof(Fusion.Statistics.FusionStatistics).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetupStatisticsPanel();

            return __ret;
        }

        static StackObject* SetWorldAnchor_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @scale = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Statistics.FusionStatsWorldAnchor @anchor = (Fusion.Statistics.FusionStatsWorldAnchor)typeof(Fusion.Statistics.FusionStatsWorldAnchor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.Statistics.FusionStatistics instance_of_this_method = (Fusion.Statistics.FusionStatistics)typeof(Fusion.Statistics.FusionStatistics).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetWorldAnchor(@anchor, @scale);

            return __ret;
        }

        static StackObject* DestroyStatisticsPanel_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Statistics.FusionStatistics instance_of_this_method = (Fusion.Statistics.FusionStatistics)typeof(Fusion.Statistics.FusionStatistics).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.DestroyStatisticsPanel();

            return __ret;
        }

        static StackObject* MonitorNetworkObject_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 4);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @monitor = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Statistics.FusionNetworkObjectStatistics @objectStatisticsInstance = (Fusion.Statistics.FusionNetworkObjectStatistics)typeof(Fusion.Statistics.FusionNetworkObjectStatistics).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.NetworkObject @networkObject = (Fusion.NetworkObject)typeof(Fusion.NetworkObject).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            Fusion.Statistics.FusionStatistics instance_of_this_method = (Fusion.Statistics.FusionStatistics)typeof(Fusion.Statistics.FusionStatistics).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.MonitorNetworkObject(@networkObject, @objectStatisticsInstance, @monitor);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RegisterGraph_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Statistics.FusionStatsGraphBase @graph = (Fusion.Statistics.FusionStatsGraphBase)typeof(Fusion.Statistics.FusionStatsGraphBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Statistics.FusionStatistics instance_of_this_method = (Fusion.Statistics.FusionStatistics)typeof(Fusion.Statistics.FusionStatistics).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RegisterGraph(@graph);

            return __ret;
        }

        static StackObject* UnregisterGraph_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Statistics.FusionStatsGraphBase @graph = (Fusion.Statistics.FusionStatsGraphBase)typeof(Fusion.Statistics.FusionStatsGraphBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Statistics.FusionStatistics instance_of_this_method = (Fusion.Statistics.FusionStatistics)typeof(Fusion.Statistics.FusionStatistics).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.UnregisterGraph(@graph);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Statistics.FusionStatistics();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

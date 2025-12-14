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
    unsafe class Fusion_Statistics_FusionStatsPanelHeader_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Statistics.FusionStatsPanelHeader);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("add_OnRenderStatsUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, add_OnRenderStatsUpdate_0);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("remove_OnRenderStatsUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, remove_OnRenderStatsUpdate_1);
            args = new Type[]{typeof(System.String), typeof(Fusion.Statistics.FusionStatistics)};
            method = type.GetMethod("SetupHeader", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetupHeader_2);

            field = type.GetField("ContentRect", flag);
            app.RegisterCLRFieldGetter(field, get_ContentRect_0);
            app.RegisterCLRFieldSetter(field, set_ContentRect_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_ContentRect_0, AssignFromStack_ContentRect_0);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Statistics.FusionStatsPanelHeader());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Statistics.FusionStatsPanelHeader[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* add_OnRenderStatsUpdate_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Statistics.FusionStatsPanelHeader instance_of_this_method = (Fusion.Statistics.FusionStatsPanelHeader)typeof(Fusion.Statistics.FusionStatsPanelHeader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnRenderStatsUpdate += value;

            return __ret;
        }

        static StackObject* remove_OnRenderStatsUpdate_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @value = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)8);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Statistics.FusionStatsPanelHeader instance_of_this_method = (Fusion.Statistics.FusionStatsPanelHeader)typeof(Fusion.Statistics.FusionStatsPanelHeader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.OnRenderStatsUpdate -= value;

            return __ret;
        }

        static StackObject* SetupHeader_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Statistics.FusionStatistics @fusionStatistics = (Fusion.Statistics.FusionStatistics)typeof(Fusion.Statistics.FusionStatistics).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @title = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Fusion.Statistics.FusionStatsPanelHeader instance_of_this_method = (Fusion.Statistics.FusionStatsPanelHeader)typeof(Fusion.Statistics.FusionStatsPanelHeader).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetupHeader(@title, @fusionStatistics);

            return __ret;
        }


        static object get_ContentRect_0(ref object o)
        {
            return ((Fusion.Statistics.FusionStatsPanelHeader)o).ContentRect;
        }

        static StackObject* CopyToStack_ContentRect_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Statistics.FusionStatsPanelHeader)o).ContentRect;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ContentRect_0(ref object o, object v)
        {
            ((Fusion.Statistics.FusionStatsPanelHeader)o).ContentRect = (UnityEngine.RectTransform)v;
        }

        static StackObject* AssignFromStack_ContentRect_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.RectTransform @ContentRect = (UnityEngine.RectTransform)typeof(UnityEngine.RectTransform).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Statistics.FusionStatsPanelHeader)o).ContentRect = @ContentRect;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Statistics.FusionStatsPanelHeader();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

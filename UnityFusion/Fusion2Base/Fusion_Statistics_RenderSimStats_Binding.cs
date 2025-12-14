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
    unsafe class Fusion_Statistics_RenderSimStats_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            FieldInfo field; 
            Type type = typeof(Fusion.Statistics.RenderSimStats);

            field = type.GetField("InPackets", flag);
            app.RegisterCLRFieldGetter(field, get_InPackets_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_InPackets_0, null);
            field = type.GetField("OutPackets", flag);
            app.RegisterCLRFieldGetter(field, get_OutPackets_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_OutPackets_1, null);
            field = type.GetField("RTT", flag);
            app.RegisterCLRFieldGetter(field, get_RTT_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_RTT_2, null);
            field = type.GetField("InBandwidth", flag);
            app.RegisterCLRFieldGetter(field, get_InBandwidth_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_InBandwidth_3, null);
            field = type.GetField("OutBandwidth", flag);
            app.RegisterCLRFieldGetter(field, get_OutBandwidth_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_OutBandwidth_4, null);
            field = type.GetField("Resimulations", flag);
            app.RegisterCLRFieldGetter(field, get_Resimulations_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_Resimulations_5, null);
            field = type.GetField("ForwardTicks", flag);
            app.RegisterCLRFieldGetter(field, get_ForwardTicks_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_ForwardTicks_6, null);
            field = type.GetField("InputReceiveDelta", flag);
            app.RegisterCLRFieldGetter(field, get_InputReceiveDelta_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_InputReceiveDelta_7, null);
            field = type.GetField("TimeResets", flag);
            app.RegisterCLRFieldGetter(field, get_TimeResets_8);
            app.RegisterCLRFieldBinding(field, CopyToStack_TimeResets_8, null);
            field = type.GetField("StateReceiveDelta", flag);
            app.RegisterCLRFieldGetter(field, get_StateReceiveDelta_9);
            app.RegisterCLRFieldBinding(field, CopyToStack_StateReceiveDelta_9, null);
            field = type.GetField("SimulationTimeOffset", flag);
            app.RegisterCLRFieldGetter(field, get_SimulationTimeOffset_10);
            app.RegisterCLRFieldBinding(field, CopyToStack_SimulationTimeOffset_10, null);
            field = type.GetField("SimulationSpeed", flag);
            app.RegisterCLRFieldGetter(field, get_SimulationSpeed_11);
            app.RegisterCLRFieldBinding(field, CopyToStack_SimulationSpeed_11, null);
            field = type.GetField("InterpolationOffset", flag);
            app.RegisterCLRFieldGetter(field, get_InterpolationOffset_12);
            app.RegisterCLRFieldBinding(field, CopyToStack_InterpolationOffset_12, null);
            field = type.GetField("InterpolationSpeed", flag);
            app.RegisterCLRFieldGetter(field, get_InterpolationSpeed_13);
            app.RegisterCLRFieldBinding(field, CopyToStack_InterpolationSpeed_13, null);
            field = type.GetField("InputInBandwidth", flag);
            app.RegisterCLRFieldGetter(field, get_InputInBandwidth_14);
            app.RegisterCLRFieldBinding(field, CopyToStack_InputInBandwidth_14, null);
            field = type.GetField("InputOutBandwidth", flag);
            app.RegisterCLRFieldGetter(field, get_InputOutBandwidth_15);
            app.RegisterCLRFieldBinding(field, CopyToStack_InputOutBandwidth_15, null);
            field = type.GetField("AverageInPacketSize", flag);
            app.RegisterCLRFieldGetter(field, get_AverageInPacketSize_16);
            app.RegisterCLRFieldBinding(field, CopyToStack_AverageInPacketSize_16, null);
            field = type.GetField("AverageOutPacketSize", flag);
            app.RegisterCLRFieldGetter(field, get_AverageOutPacketSize_17);
            app.RegisterCLRFieldBinding(field, CopyToStack_AverageOutPacketSize_17, null);
            field = type.GetField("InObjectUpdates", flag);
            app.RegisterCLRFieldGetter(field, get_InObjectUpdates_18);
            app.RegisterCLRFieldBinding(field, CopyToStack_InObjectUpdates_18, null);
            field = type.GetField("OutObjectUpdates", flag);
            app.RegisterCLRFieldGetter(field, get_OutObjectUpdates_19);
            app.RegisterCLRFieldBinding(field, CopyToStack_OutObjectUpdates_19, null);
            field = type.GetField("ObjectsAllocatedMemoryInUse", flag);
            app.RegisterCLRFieldGetter(field, get_ObjectsAllocatedMemoryInUse_20);
            app.RegisterCLRFieldBinding(field, CopyToStack_ObjectsAllocatedMemoryInUse_20, null);
            field = type.GetField("GeneralAllocatedMemoryInUse", flag);
            app.RegisterCLRFieldGetter(field, get_GeneralAllocatedMemoryInUse_21);
            app.RegisterCLRFieldBinding(field, CopyToStack_GeneralAllocatedMemoryInUse_21, null);
            field = type.GetField("ObjectsAllocatedMemoryFree", flag);
            app.RegisterCLRFieldGetter(field, get_ObjectsAllocatedMemoryFree_22);
            app.RegisterCLRFieldBinding(field, CopyToStack_ObjectsAllocatedMemoryFree_22, null);
            field = type.GetField("GeneralAllocatedMemoryFree", flag);
            app.RegisterCLRFieldGetter(field, get_GeneralAllocatedMemoryFree_23);
            app.RegisterCLRFieldBinding(field, CopyToStack_GeneralAllocatedMemoryFree_23, null);
            field = type.GetField("WordsWrittenCount", flag);
            app.RegisterCLRFieldGetter(field, get_WordsWrittenCount_24);
            app.RegisterCLRFieldBinding(field, CopyToStack_WordsWrittenCount_24, null);
            field = type.GetField("WordsWrittenSize", flag);
            app.RegisterCLRFieldGetter(field, get_WordsWrittenSize_25);
            app.RegisterCLRFieldBinding(field, CopyToStack_WordsWrittenSize_25, null);
            field = type.GetField("WordsReadCount", flag);
            app.RegisterCLRFieldGetter(field, get_WordsReadCount_26);
            app.RegisterCLRFieldBinding(field, CopyToStack_WordsReadCount_26, null);
            field = type.GetField("WordsReadSize", flag);
            app.RegisterCLRFieldGetter(field, get_WordsReadSize_27);
            app.RegisterCLRFieldBinding(field, CopyToStack_WordsReadSize_27, null);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Statistics.RenderSimStats());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Statistics.RenderSimStats[s]);


        }

        static void WriteBackInstance(UnityFusion.Runtime.Enviorment.AppDomain __domain, StackObject* ptr_of_this_method, AutoList __mStack, ref Fusion.Statistics.RenderSimStats instance_of_this_method)
        {
            ptr_of_this_method = ILIntepreter.GetObjectAndResolveReference(ptr_of_this_method);
            switch(ptr_of_this_method->ObjectType)
            {
                case ObjectTypes.Object:
                    {
                        __mStack[ptr_of_this_method->Value] = instance_of_this_method;
                    }
                    break;
                case ObjectTypes.FieldReference:
                    {
                        var ___obj = __mStack[ptr_of_this_method->Value];
                        if(___obj is ILTypeInstance)
                        {
                            ((ILTypeInstance)___obj)[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            var t = __domain.GetType(___obj.GetType()) as CLRType;
                            t.SetFieldValue(ptr_of_this_method->ValueLow, ref ___obj, instance_of_this_method);
                        }
                    }
                    break;
                case ObjectTypes.StaticFieldReference:
                    {
                        var t = __domain.GetType(ptr_of_this_method->Value);
                        if(t is ILType)
                        {
                            ((ILType)t).StaticInstance[ptr_of_this_method->ValueLow] = instance_of_this_method;
                        }
                        else
                        {
                            ((CLRType)t).SetStaticFieldValue(ptr_of_this_method->ValueLow, instance_of_this_method);
                        }
                    }
                    break;
                 case ObjectTypes.ArrayReference:
                    {
                        var instance_of_arrayReference = __mStack[ptr_of_this_method->Value] as Fusion.Statistics.RenderSimStats[];
                        instance_of_arrayReference[ptr_of_this_method->ValueLow] = instance_of_this_method;
                    }
                    break;
            }
        }


        static object get_InPackets_0(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.InPackets;
        }

        static StackObject* CopyToStack_InPackets_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.InPackets;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OutPackets_1(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.OutPackets;
        }

        static StackObject* CopyToStack_OutPackets_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.OutPackets;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_RTT_2(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.RTT;
        }

        static StackObject* CopyToStack_RTT_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.RTT;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_InBandwidth_3(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.InBandwidth;
        }

        static StackObject* CopyToStack_InBandwidth_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.InBandwidth;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OutBandwidth_4(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.OutBandwidth;
        }

        static StackObject* CopyToStack_OutBandwidth_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.OutBandwidth;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_Resimulations_5(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.Resimulations;
        }

        static StackObject* CopyToStack_Resimulations_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.Resimulations;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ForwardTicks_6(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.ForwardTicks;
        }

        static StackObject* CopyToStack_ForwardTicks_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.ForwardTicks;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_InputReceiveDelta_7(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.InputReceiveDelta;
        }

        static StackObject* CopyToStack_InputReceiveDelta_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.InputReceiveDelta;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_TimeResets_8(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.TimeResets;
        }

        static StackObject* CopyToStack_TimeResets_8(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.TimeResets;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_StateReceiveDelta_9(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.StateReceiveDelta;
        }

        static StackObject* CopyToStack_StateReceiveDelta_9(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.StateReceiveDelta;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_SimulationTimeOffset_10(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.SimulationTimeOffset;
        }

        static StackObject* CopyToStack_SimulationTimeOffset_10(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.SimulationTimeOffset;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_SimulationSpeed_11(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.SimulationSpeed;
        }

        static StackObject* CopyToStack_SimulationSpeed_11(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.SimulationSpeed;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_InterpolationOffset_12(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.InterpolationOffset;
        }

        static StackObject* CopyToStack_InterpolationOffset_12(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.InterpolationOffset;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_InterpolationSpeed_13(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.InterpolationSpeed;
        }

        static StackObject* CopyToStack_InterpolationSpeed_13(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.InterpolationSpeed;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_InputInBandwidth_14(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.InputInBandwidth;
        }

        static StackObject* CopyToStack_InputInBandwidth_14(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.InputInBandwidth;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_InputOutBandwidth_15(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.InputOutBandwidth;
        }

        static StackObject* CopyToStack_InputOutBandwidth_15(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.InputOutBandwidth;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_AverageInPacketSize_16(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.AverageInPacketSize;
        }

        static StackObject* CopyToStack_AverageInPacketSize_16(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.AverageInPacketSize;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_AverageOutPacketSize_17(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.AverageOutPacketSize;
        }

        static StackObject* CopyToStack_AverageOutPacketSize_17(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.AverageOutPacketSize;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_InObjectUpdates_18(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.InObjectUpdates;
        }

        static StackObject* CopyToStack_InObjectUpdates_18(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.InObjectUpdates;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_OutObjectUpdates_19(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.OutObjectUpdates;
        }

        static StackObject* CopyToStack_OutObjectUpdates_19(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.OutObjectUpdates;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ObjectsAllocatedMemoryInUse_20(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.ObjectsAllocatedMemoryInUse;
        }

        static StackObject* CopyToStack_ObjectsAllocatedMemoryInUse_20(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.ObjectsAllocatedMemoryInUse;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_GeneralAllocatedMemoryInUse_21(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.GeneralAllocatedMemoryInUse;
        }

        static StackObject* CopyToStack_GeneralAllocatedMemoryInUse_21(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.GeneralAllocatedMemoryInUse;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_ObjectsAllocatedMemoryFree_22(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.ObjectsAllocatedMemoryFree;
        }

        static StackObject* CopyToStack_ObjectsAllocatedMemoryFree_22(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.ObjectsAllocatedMemoryFree;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_GeneralAllocatedMemoryFree_23(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.GeneralAllocatedMemoryFree;
        }

        static StackObject* CopyToStack_GeneralAllocatedMemoryFree_23(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.GeneralAllocatedMemoryFree;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_WordsWrittenCount_24(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.WordsWrittenCount;
        }

        static StackObject* CopyToStack_WordsWrittenCount_24(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.WordsWrittenCount;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_WordsWrittenSize_25(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.WordsWrittenSize;
        }

        static StackObject* CopyToStack_WordsWrittenSize_25(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.WordsWrittenSize;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_WordsReadCount_26(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.WordsReadCount;
        }

        static StackObject* CopyToStack_WordsReadCount_26(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.WordsReadCount;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static object get_WordsReadSize_27(ref object o)
        {
            return Fusion.Statistics.RenderSimStats.WordsReadSize;
        }

        static StackObject* CopyToStack_WordsReadSize_27(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = Fusion.Statistics.RenderSimStats.WordsReadSize;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


        static object PerformMemberwiseClone(ref object o)
        {
            var ins = new Fusion.Statistics.RenderSimStats();
            ins = (Fusion.Statistics.RenderSimStats)o;
            return ins;
        }


    }
}

#if FUSION2 && XRMOD_INSTALL

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
    unsafe class Fusion_Addons_KCC_KCCStageInfo_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.KCC.KCCStageInfo);
            args = new Type[]{typeof(Fusion.Addons.KCC.IKCCProcessor)};
            method = type.GetMethod("HasPendingProcessor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HasPendingProcessor_0);
            args = new Type[]{typeof(Fusion.Addons.KCC.IKCCProcessor)};
            method = type.GetMethod("HasExecutedProcessor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, HasExecutedProcessor_1);
            args = new Type[]{typeof(Fusion.Addons.KCC.IKCCProcessor)};
            method = type.GetMethod("SuppressProcessor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SuppressProcessor_2);
            args = new Type[]{typeof(Fusion.Addons.KCC.IKCCProcessor)};
            method = type.GetMethod("SuppressProcessorsExcept", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SuppressProcessorsExcept_3);
            args = new Type[]{};
            method = type.GetMethod("Clear", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Clear_4);
            args = new Type[]{};
            method = type.GetMethod("Allocate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Allocate_5);
            args = new Type[]{typeof(Fusion.Addons.KCC.KCCStageInfo)};
            method = type.GetMethod("Release", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Release_6);

            field = type.GetField("Type", flag);
            app.RegisterCLRFieldGetter(field, get_Type_0);
            app.RegisterCLRFieldSetter(field, set_Type_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Type_0, AssignFromStack_Type_0);
            field = type.GetField("Level", flag);
            app.RegisterCLRFieldGetter(field, get_Level_1);
            app.RegisterCLRFieldSetter(field, set_Level_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Level_1, AssignFromStack_Level_1);
            field = type.GetField("StageObject", flag);
            app.RegisterCLRFieldGetter(field, get_StageObject_2);
            app.RegisterCLRFieldSetter(field, set_StageObject_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_StageObject_2, AssignFromStack_StageObject_2);
            field = type.GetField("StageObjectType", flag);
            app.RegisterCLRFieldGetter(field, get_StageObjectType_3);
            app.RegisterCLRFieldSetter(field, set_StageObjectType_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_StageObjectType_3, AssignFromStack_StageObjectType_3);
            field = type.GetField("Processors", flag);
            app.RegisterCLRFieldGetter(field, get_Processors_4);
            app.RegisterCLRFieldSetter(field, set_Processors_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Processors_4, AssignFromStack_Processors_4);
            field = type.GetField("ProcessorCount", flag);
            app.RegisterCLRFieldGetter(field, get_ProcessorCount_5);
            app.RegisterCLRFieldSetter(field, set_ProcessorCount_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_ProcessorCount_5, AssignFromStack_ProcessorCount_5);
            field = type.GetField("ProcessorIndex", flag);
            app.RegisterCLRFieldGetter(field, get_ProcessorIndex_6);
            app.RegisterCLRFieldSetter(field, set_ProcessorIndex_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_ProcessorIndex_6, AssignFromStack_ProcessorIndex_6);
            field = type.GetField("PostProcesses", flag);
            app.RegisterCLRFieldGetter(field, get_PostProcesses_7);
            app.RegisterCLRFieldSetter(field, set_PostProcesses_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_PostProcesses_7, AssignFromStack_PostProcesses_7);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.KCCStageInfo());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.KCCStageInfo[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* HasPendingProcessor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.IKCCProcessor @processor = (Fusion.Addons.KCC.IKCCProcessor)typeof(Fusion.Addons.KCC.IKCCProcessor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCStageInfo instance_of_this_method = (Fusion.Addons.KCC.KCCStageInfo)typeof(Fusion.Addons.KCC.KCCStageInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.HasPendingProcessor(@processor);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* HasExecutedProcessor_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.IKCCProcessor @processor = (Fusion.Addons.KCC.IKCCProcessor)typeof(Fusion.Addons.KCC.IKCCProcessor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCStageInfo instance_of_this_method = (Fusion.Addons.KCC.KCCStageInfo)typeof(Fusion.Addons.KCC.KCCStageInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.HasExecutedProcessor(@processor);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SuppressProcessor_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.IKCCProcessor @processor = (Fusion.Addons.KCC.IKCCProcessor)typeof(Fusion.Addons.KCC.IKCCProcessor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCStageInfo instance_of_this_method = (Fusion.Addons.KCC.KCCStageInfo)typeof(Fusion.Addons.KCC.KCCStageInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SuppressProcessor(@processor);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* SuppressProcessorsExcept_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.IKCCProcessor @processor = (Fusion.Addons.KCC.IKCCProcessor)typeof(Fusion.Addons.KCC.IKCCProcessor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Fusion.Addons.KCC.KCCStageInfo instance_of_this_method = (Fusion.Addons.KCC.KCCStageInfo)typeof(Fusion.Addons.KCC.KCCStageInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SuppressProcessorsExcept(@processor);

            return __ret;
        }

        static StackObject* Clear_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCStageInfo instance_of_this_method = (Fusion.Addons.KCC.KCCStageInfo)typeof(Fusion.Addons.KCC.KCCStageInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Clear();

            return __ret;
        }

        static StackObject* Allocate_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = Fusion.Addons.KCC.KCCStageInfo.Allocate();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Release_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCStageInfo @stageInfo = (Fusion.Addons.KCC.KCCStageInfo)typeof(Fusion.Addons.KCC.KCCStageInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            Fusion.Addons.KCC.KCCStageInfo.Release(@stageInfo);

            return __ret;
        }


        static object get_Type_0(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCStageInfo)o).Type;
        }

        static StackObject* CopyToStack_Type_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCStageInfo)o).Type;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Type_0(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCStageInfo)o).Type = (System.Type)v;
        }

        static StackObject* AssignFromStack_Type_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Type @Type = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCStageInfo)o).Type = @Type;
            return ptr_of_this_method;
        }

        static object get_Level_1(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCStageInfo)o).Level;
        }

        static StackObject* CopyToStack_Level_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCStageInfo)o).Level;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Level_1(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCStageInfo)o).Level = (System.Int32)v;
        }

        static StackObject* AssignFromStack_Level_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @Level = ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCStageInfo)o).Level = @Level;
            return ptr_of_this_method;
        }

        static object get_StageObject_2(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCStageInfo)o).StageObject;
        }

        static StackObject* CopyToStack_StageObject_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCStageInfo)o).StageObject;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_StageObject_2(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCStageInfo)o).StageObject = (Fusion.Addons.KCC.IKCCStage)v;
        }

        static StackObject* AssignFromStack_StageObject_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.IKCCStage @StageObject = (Fusion.Addons.KCC.IKCCStage)typeof(Fusion.Addons.KCC.IKCCStage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCStageInfo)o).StageObject = @StageObject;
            return ptr_of_this_method;
        }

        static object get_StageObjectType_3(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCStageInfo)o).StageObjectType;
        }

        static StackObject* CopyToStack_StageObjectType_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCStageInfo)o).StageObjectType;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_StageObjectType_3(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCStageInfo)o).StageObjectType = (System.Type)v;
        }

        static StackObject* AssignFromStack_StageObjectType_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Type @StageObjectType = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCStageInfo)o).StageObjectType = @StageObjectType;
            return ptr_of_this_method;
        }

        static object get_Processors_4(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCStageInfo)o).Processors;
        }

        static StackObject* CopyToStack_Processors_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCStageInfo)o).Processors;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Processors_4(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCStageInfo)o).Processors = (Fusion.Addons.KCC.IKCCProcessor[])v;
        }

        static StackObject* AssignFromStack_Processors_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.IKCCProcessor[] @Processors = (Fusion.Addons.KCC.IKCCProcessor[])typeof(Fusion.Addons.KCC.IKCCProcessor[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCStageInfo)o).Processors = @Processors;
            return ptr_of_this_method;
        }

        static object get_ProcessorCount_5(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCStageInfo)o).ProcessorCount;
        }

        static StackObject* CopyToStack_ProcessorCount_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCStageInfo)o).ProcessorCount;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_ProcessorCount_5(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCStageInfo)o).ProcessorCount = (System.Int32)v;
        }

        static StackObject* AssignFromStack_ProcessorCount_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @ProcessorCount = ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCStageInfo)o).ProcessorCount = @ProcessorCount;
            return ptr_of_this_method;
        }

        static object get_ProcessorIndex_6(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCStageInfo)o).ProcessorIndex;
        }

        static StackObject* CopyToStack_ProcessorIndex_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCStageInfo)o).ProcessorIndex;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_ProcessorIndex_6(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCStageInfo)o).ProcessorIndex = (System.Int32)v;
        }

        static StackObject* AssignFromStack_ProcessorIndex_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @ProcessorIndex = ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCStageInfo)o).ProcessorIndex = @ProcessorIndex;
            return ptr_of_this_method;
        }

        static object get_PostProcesses_7(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCStageInfo)o).PostProcesses;
        }

        static StackObject* CopyToStack_PostProcesses_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCStageInfo)o).PostProcesses;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_PostProcesses_7(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCStageInfo)o).PostProcesses = (System.Collections.Generic.List<System.Action<Fusion.Addons.KCC.KCC, Fusion.Addons.KCC.KCCData>>)v;
        }

        static StackObject* AssignFromStack_PostProcesses_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Collections.Generic.List<System.Action<Fusion.Addons.KCC.KCC, Fusion.Addons.KCC.KCCData>> @PostProcesses = (System.Collections.Generic.List<System.Action<Fusion.Addons.KCC.KCC, Fusion.Addons.KCC.KCCData>>)typeof(System.Collections.Generic.List<System.Action<Fusion.Addons.KCC.KCC, Fusion.Addons.KCC.KCCData>>).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCStageInfo)o).PostProcesses = @PostProcesses;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Addons.KCC.KCCStageInfo();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
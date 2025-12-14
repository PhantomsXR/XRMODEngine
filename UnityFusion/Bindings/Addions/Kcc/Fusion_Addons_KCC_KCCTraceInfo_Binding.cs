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
    unsafe class Fusion_Addons_KCC_KCCTraceInfo_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Fusion.Addons.KCC.KCCTraceInfo);
            args = new Type[]{};
            method = type.GetMethod("get_IsValid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsValid_0);
            args = new Type[]{};
            method = type.GetMethod("get_IsStage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsStage_1);
            args = new Type[]{};
            method = type.GetMethod("get_IsProcessor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_IsProcessor_2);
            args = new Type[]{typeof(Fusion.Addons.KCC.EKCCTrace), typeof(System.Type), typeof(System.String), typeof(System.Int32), typeof(Fusion.Addons.KCC.IKCCProcessor)};
            method = type.GetMethod("Set", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Set_3);

            field = type.GetField("Trace", flag);
            app.RegisterCLRFieldGetter(field, get_Trace_0);
            app.RegisterCLRFieldSetter(field, set_Trace_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_Trace_0, AssignFromStack_Trace_0);
            field = type.GetField("Type", flag);
            app.RegisterCLRFieldGetter(field, get_Type_1);
            app.RegisterCLRFieldSetter(field, set_Type_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Type_1, AssignFromStack_Type_1);
            field = type.GetField("Name", flag);
            app.RegisterCLRFieldGetter(field, get_Name_2);
            app.RegisterCLRFieldSetter(field, set_Name_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_Name_2, AssignFromStack_Name_2);
            field = type.GetField("Level", flag);
            app.RegisterCLRFieldGetter(field, get_Level_3);
            app.RegisterCLRFieldSetter(field, set_Level_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_Level_3, AssignFromStack_Level_3);
            field = type.GetField("Processor", flag);
            app.RegisterCLRFieldGetter(field, get_Processor_4);
            app.RegisterCLRFieldSetter(field, set_Processor_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_Processor_4, AssignFromStack_Processor_4);
            field = type.GetField("IsVisible", flag);
            app.RegisterCLRFieldGetter(field, get_IsVisible_5);
            app.RegisterCLRFieldSetter(field, set_IsVisible_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_IsVisible_5, AssignFromStack_IsVisible_5);


            app.RegisterCLRCreateDefaultInstance(type, () => new Fusion.Addons.KCC.KCCTraceInfo());
            app.RegisterCLRCreateArrayInstance(type, s => new Fusion.Addons.KCC.KCCTraceInfo[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_IsValid_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCTraceInfo instance_of_this_method = (Fusion.Addons.KCC.KCCTraceInfo)typeof(Fusion.Addons.KCC.KCCTraceInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsValid;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_IsStage_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCTraceInfo instance_of_this_method = (Fusion.Addons.KCC.KCCTraceInfo)typeof(Fusion.Addons.KCC.KCCTraceInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsStage;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_IsProcessor_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.KCCTraceInfo instance_of_this_method = (Fusion.Addons.KCC.KCCTraceInfo)typeof(Fusion.Addons.KCC.KCCTraceInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsProcessor;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* Set_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 6);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Fusion.Addons.KCC.IKCCProcessor @processor = (Fusion.Addons.KCC.IKCCProcessor)typeof(Fusion.Addons.KCC.IKCCProcessor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @level = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            System.String @name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 4);
            System.Type @type = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 5);
            Fusion.Addons.KCC.EKCCTrace @trace = (Fusion.Addons.KCC.EKCCTrace)typeof(Fusion.Addons.KCC.EKCCTrace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 6);
            Fusion.Addons.KCC.KCCTraceInfo instance_of_this_method = (Fusion.Addons.KCC.KCCTraceInfo)typeof(Fusion.Addons.KCC.KCCTraceInfo).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Set(@trace, @type, @name, @level, @processor);

            return __ret;
        }


        static object get_Trace_0(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCTraceInfo)o).Trace;
        }

        static StackObject* CopyToStack_Trace_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCTraceInfo)o).Trace;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Trace_0(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCTraceInfo)o).Trace = (Fusion.Addons.KCC.EKCCTrace)v;
        }

        static StackObject* AssignFromStack_Trace_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.EKCCTrace @Trace = (Fusion.Addons.KCC.EKCCTrace)typeof(Fusion.Addons.KCC.EKCCTrace).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)20);
            ((Fusion.Addons.KCC.KCCTraceInfo)o).Trace = @Trace;
            return ptr_of_this_method;
        }

        static object get_Type_1(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCTraceInfo)o).Type;
        }

        static StackObject* CopyToStack_Type_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCTraceInfo)o).Type;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Type_1(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCTraceInfo)o).Type = (System.Type)v;
        }

        static StackObject* AssignFromStack_Type_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Type @Type = (System.Type)typeof(System.Type).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCTraceInfo)o).Type = @Type;
            return ptr_of_this_method;
        }

        static object get_Name_2(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCTraceInfo)o).Name;
        }

        static StackObject* CopyToStack_Name_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCTraceInfo)o).Name;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Name_2(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCTraceInfo)o).Name = (System.String)v;
        }

        static StackObject* AssignFromStack_Name_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @Name = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCTraceInfo)o).Name = @Name;
            return ptr_of_this_method;
        }

        static object get_Level_3(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCTraceInfo)o).Level;
        }

        static StackObject* CopyToStack_Level_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCTraceInfo)o).Level;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Level_3(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCTraceInfo)o).Level = (System.Int32)v;
        }

        static StackObject* AssignFromStack_Level_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @Level = ptr_of_this_method->Value;
            ((Fusion.Addons.KCC.KCCTraceInfo)o).Level = @Level;
            return ptr_of_this_method;
        }

        static object get_Processor_4(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCTraceInfo)o).Processor;
        }

        static StackObject* CopyToStack_Processor_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCTraceInfo)o).Processor;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_Processor_4(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCTraceInfo)o).Processor = (Fusion.Addons.KCC.IKCCProcessor)v;
        }

        static StackObject* AssignFromStack_Processor_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            Fusion.Addons.KCC.IKCCProcessor @Processor = (Fusion.Addons.KCC.IKCCProcessor)typeof(Fusion.Addons.KCC.IKCCProcessor).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Fusion.Addons.KCC.KCCTraceInfo)o).Processor = @Processor;
            return ptr_of_this_method;
        }

        static object get_IsVisible_5(ref object o)
        {
            return ((Fusion.Addons.KCC.KCCTraceInfo)o).IsVisible;
        }

        static StackObject* CopyToStack_IsVisible_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Fusion.Addons.KCC.KCCTraceInfo)o).IsVisible;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_IsVisible_5(ref object o, object v)
        {
            ((Fusion.Addons.KCC.KCCTraceInfo)o).IsVisible = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_IsVisible_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @IsVisible = ptr_of_this_method->Value == 1;
            ((Fusion.Addons.KCC.KCCTraceInfo)o).IsVisible = @IsVisible;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Fusion.Addons.KCC.KCCTraceInfo();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
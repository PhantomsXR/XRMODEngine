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
    unsafe class UnityEngine_HDROutputSettings_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(UnityEngine.HDROutputSettings);
            args = new Type[]{};
            method = type.GetMethod("get_main", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_main_0);
            args = new Type[]{};
            method = type.GetMethod("get_active", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_active_1);
            args = new Type[]{};
            method = type.GetMethod("get_available", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_available_2);
            args = new Type[]{};
            method = type.GetMethod("get_automaticHDRTonemapping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_automaticHDRTonemapping_3);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("set_automaticHDRTonemapping", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_automaticHDRTonemapping_4);
            args = new Type[]{};
            method = type.GetMethod("get_displayColorGamut", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_displayColorGamut_5);
            args = new Type[]{};
            method = type.GetMethod("get_format", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_format_6);
            args = new Type[]{};
            method = type.GetMethod("get_graphicsFormat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_graphicsFormat_7);
            args = new Type[]{};
            method = type.GetMethod("get_paperWhiteNits", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_paperWhiteNits_8);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("set_paperWhiteNits", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, set_paperWhiteNits_9);
            args = new Type[]{};
            method = type.GetMethod("get_maxFullFrameToneMapLuminance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxFullFrameToneMapLuminance_10);
            args = new Type[]{};
            method = type.GetMethod("get_maxToneMapLuminance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_maxToneMapLuminance_11);
            args = new Type[]{};
            method = type.GetMethod("get_minToneMapLuminance", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_minToneMapLuminance_12);
            args = new Type[]{};
            method = type.GetMethod("get_HDRModeChangeRequested", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_HDRModeChangeRequested_13);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("RequestHDRModeChange", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RequestHDRModeChange_14);

            field = type.GetField("displays", flag);
            app.RegisterCLRFieldGetter(field, get_displays_0);
            app.RegisterCLRFieldSetter(field, set_displays_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_displays_0, AssignFromStack_displays_0);


            app.RegisterCLRCreateArrayInstance(type, s => new UnityEngine.HDROutputSettings[s]);


        }


        static StackObject* get_main_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);


            var result_of_this_method = UnityEngine.HDROutputSettings.main;

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_active_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.HDROutputSettings instance_of_this_method = (UnityEngine.HDROutputSettings)typeof(UnityEngine.HDROutputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.active;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_available_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.HDROutputSettings instance_of_this_method = (UnityEngine.HDROutputSettings)typeof(UnityEngine.HDROutputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.available;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* get_automaticHDRTonemapping_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.HDROutputSettings instance_of_this_method = (UnityEngine.HDROutputSettings)typeof(UnityEngine.HDROutputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.automaticHDRTonemapping;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* set_automaticHDRTonemapping_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @value = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.HDROutputSettings instance_of_this_method = (UnityEngine.HDROutputSettings)typeof(UnityEngine.HDROutputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.automaticHDRTonemapping = value;

            return __ret;
        }

        static StackObject* get_displayColorGamut_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.HDROutputSettings instance_of_this_method = (UnityEngine.HDROutputSettings)typeof(UnityEngine.HDROutputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.displayColorGamut;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_format_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.HDROutputSettings instance_of_this_method = (UnityEngine.HDROutputSettings)typeof(UnityEngine.HDROutputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.format;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_graphicsFormat_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.HDROutputSettings instance_of_this_method = (UnityEngine.HDROutputSettings)typeof(UnityEngine.HDROutputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.graphicsFormat;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_paperWhiteNits_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.HDROutputSettings instance_of_this_method = (UnityEngine.HDROutputSettings)typeof(UnityEngine.HDROutputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.paperWhiteNits;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* set_paperWhiteNits_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @value = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.HDROutputSettings instance_of_this_method = (UnityEngine.HDROutputSettings)typeof(UnityEngine.HDROutputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.paperWhiteNits = value;

            return __ret;
        }

        static StackObject* get_maxFullFrameToneMapLuminance_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.HDROutputSettings instance_of_this_method = (UnityEngine.HDROutputSettings)typeof(UnityEngine.HDROutputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxFullFrameToneMapLuminance;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_maxToneMapLuminance_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.HDROutputSettings instance_of_this_method = (UnityEngine.HDROutputSettings)typeof(UnityEngine.HDROutputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.maxToneMapLuminance;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_minToneMapLuminance_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.HDROutputSettings instance_of_this_method = (UnityEngine.HDROutputSettings)typeof(UnityEngine.HDROutputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.minToneMapLuminance;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_HDRModeChangeRequested_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.HDROutputSettings instance_of_this_method = (UnityEngine.HDROutputSettings)typeof(UnityEngine.HDROutputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.HDRModeChangeRequested;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* RequestHDRModeChange_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @enabled = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            UnityEngine.HDROutputSettings instance_of_this_method = (UnityEngine.HDROutputSettings)typeof(UnityEngine.HDROutputSettings).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RequestHDRModeChange(@enabled);

            return __ret;
        }


        static object get_displays_0(ref object o)
        {
            return UnityEngine.HDROutputSettings.displays;
        }

        static StackObject* CopyToStack_displays_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = UnityEngine.HDROutputSettings.displays;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_displays_0(ref object o, object v)
        {
            UnityEngine.HDROutputSettings.displays = (UnityEngine.HDROutputSettings[])v;
        }

        static StackObject* AssignFromStack_displays_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.HDROutputSettings[] @displays = (UnityEngine.HDROutputSettings[])typeof(UnityEngine.HDROutputSettings[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            UnityEngine.HDROutputSettings.displays = @displays;
            return ptr_of_this_method;
        }




    }
}

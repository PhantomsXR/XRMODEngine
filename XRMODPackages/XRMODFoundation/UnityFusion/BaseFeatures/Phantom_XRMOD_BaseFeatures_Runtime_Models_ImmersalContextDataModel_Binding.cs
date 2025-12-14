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
    unsafe class Phantom_XRMOD_BaseFeatures_Runtime_Models_ImmersalContextDataModel_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel);
            args = new Type[]{};
            method = type.GetMethod("Initialize", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Initialize_0);

            field = type.GetField("DeveloperToken", flag);
            app.RegisterCLRFieldGetter(field, get_DeveloperToken_0);
            app.RegisterCLRFieldSetter(field, set_DeveloperToken_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_DeveloperToken_0, AssignFromStack_DeveloperToken_0);
            field = type.GetField("AutoStart", flag);
            app.RegisterCLRFieldGetter(field, get_AutoStart_1);
            app.RegisterCLRFieldSetter(field, set_AutoStart_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_AutoStart_1, AssignFromStack_AutoStart_1);
            field = type.GetField("UseFiltering", flag);
            app.RegisterCLRFieldGetter(field, get_UseFiltering_2);
            app.RegisterCLRFieldSetter(field, set_UseFiltering_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_UseFiltering_2, AssignFromStack_UseFiltering_2);
            field = type.GetField("LocalizationInterval", flag);
            app.RegisterCLRFieldGetter(field, get_LocalizationInterval_3);
            app.RegisterCLRFieldSetter(field, set_LocalizationInterval_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_LocalizationInterval_3, AssignFromStack_LocalizationInterval_3);
            field = type.GetField("UseServerLocalizer", flag);
            app.RegisterCLRFieldGetter(field, get_UseServerLocalizer_4);
            app.RegisterCLRFieldSetter(field, set_UseServerLocalizer_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_UseServerLocalizer_4, AssignFromStack_UseServerLocalizer_4);
            field = type.GetField("BurstMode", flag);
            app.RegisterCLRFieldGetter(field, get_BurstMode_5);
            app.RegisterCLRFieldSetter(field, set_BurstMode_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_BurstMode_5, AssignFromStack_BurstMode_5);
            field = type.GetField("StopLocalizedAfterSuccess", flag);
            app.RegisterCLRFieldGetter(field, get_StopLocalizedAfterSuccess_6);
            app.RegisterCLRFieldSetter(field, set_StopLocalizedAfterSuccess_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_StopLocalizedAfterSuccess_6, AssignFromStack_StopLocalizedAfterSuccess_6);
            field = type.GetField("ResetOnMapChange", flag);
            app.RegisterCLRFieldGetter(field, get_ResetOnMapChange_7);
            app.RegisterCLRFieldSetter(field, set_ResetOnMapChange_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_ResetOnMapChange_7, AssignFromStack_ResetOnMapChange_7);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel[s]);

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
            Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel instance_of_this_method = (Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)typeof(Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.Initialize();

            return __ret;
        }


        static object get_DeveloperToken_0(ref object o)
        {
            return ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).DeveloperToken;
        }

        static StackObject* CopyToStack_DeveloperToken_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).DeveloperToken;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_DeveloperToken_0(ref object o, object v)
        {
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).DeveloperToken = (System.String)v;
        }

        static StackObject* AssignFromStack_DeveloperToken_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @DeveloperToken = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).DeveloperToken = @DeveloperToken;
            return ptr_of_this_method;
        }

        static object get_AutoStart_1(ref object o)
        {
            return ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).AutoStart;
        }

        static StackObject* CopyToStack_AutoStart_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).AutoStart;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_AutoStart_1(ref object o, object v)
        {
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).AutoStart = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_AutoStart_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @AutoStart = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).AutoStart = @AutoStart;
            return ptr_of_this_method;
        }

        static object get_UseFiltering_2(ref object o)
        {
            return ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).UseFiltering;
        }

        static StackObject* CopyToStack_UseFiltering_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).UseFiltering;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_UseFiltering_2(ref object o, object v)
        {
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).UseFiltering = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_UseFiltering_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @UseFiltering = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).UseFiltering = @UseFiltering;
            return ptr_of_this_method;
        }

        static object get_LocalizationInterval_3(ref object o)
        {
            return ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).LocalizationInterval;
        }

        static StackObject* CopyToStack_LocalizationInterval_3(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).LocalizationInterval;
            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_LocalizationInterval_3(ref object o, object v)
        {
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).LocalizationInterval = (System.Single)v;
        }

        static StackObject* AssignFromStack_LocalizationInterval_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Single @LocalizationInterval = *(float*)&ptr_of_this_method->Value;
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).LocalizationInterval = @LocalizationInterval;
            return ptr_of_this_method;
        }

        static object get_UseServerLocalizer_4(ref object o)
        {
            return ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).UseServerLocalizer;
        }

        static StackObject* CopyToStack_UseServerLocalizer_4(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).UseServerLocalizer;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_UseServerLocalizer_4(ref object o, object v)
        {
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).UseServerLocalizer = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_UseServerLocalizer_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @UseServerLocalizer = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).UseServerLocalizer = @UseServerLocalizer;
            return ptr_of_this_method;
        }

        static object get_BurstMode_5(ref object o)
        {
            return ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).BurstMode;
        }

        static StackObject* CopyToStack_BurstMode_5(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).BurstMode;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_BurstMode_5(ref object o, object v)
        {
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).BurstMode = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_BurstMode_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @BurstMode = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).BurstMode = @BurstMode;
            return ptr_of_this_method;
        }

        static object get_StopLocalizedAfterSuccess_6(ref object o)
        {
            return ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).StopLocalizedAfterSuccess;
        }

        static StackObject* CopyToStack_StopLocalizedAfterSuccess_6(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).StopLocalizedAfterSuccess;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_StopLocalizedAfterSuccess_6(ref object o, object v)
        {
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).StopLocalizedAfterSuccess = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_StopLocalizedAfterSuccess_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @StopLocalizedAfterSuccess = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).StopLocalizedAfterSuccess = @StopLocalizedAfterSuccess;
            return ptr_of_this_method;
        }

        static object get_ResetOnMapChange_7(ref object o)
        {
            return ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).ResetOnMapChange;
        }

        static StackObject* CopyToStack_ResetOnMapChange_7(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).ResetOnMapChange;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_ResetOnMapChange_7(ref object o, object v)
        {
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).ResetOnMapChange = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_ResetOnMapChange_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @ResetOnMapChange = ptr_of_this_method->Value == 1;
            ((Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel)o).ResetOnMapChange = @ResetOnMapChange;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.BaseFeatures.Runtime.Models.ImmersalContextDataModel();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

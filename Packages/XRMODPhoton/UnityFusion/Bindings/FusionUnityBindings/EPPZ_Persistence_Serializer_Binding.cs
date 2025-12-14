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
    unsafe class EPPZ_Persistence_Serializer_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(EPPZ.Persistence.Serializer);
            args = new Type[]{};
            method = type.GetMethod("TurnOffFileExtensionManagement", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TurnOffFileExtensionManagement_0);
            args = new Type[]{};
            method = type.GetMethod("TurnOnFileExtensionManagement", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TurnOnFileExtensionManagement_1);
            args = new Type[]{typeof(EPPZ.Persistence.Serializer)};
            method = type.GetMethod("SerializerOrDefault", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SerializerOrDefault_2);
            args = new Type[]{};
            method = type.GetMethod("SetDefaultSerializer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SetDefaultSerializer_3);
            args = new Type[]{};
            method = type.GetMethod("get_PrimaryFileExtension", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_PrimaryFileExtension_4);
            args = new Type[]{};
            method = type.GetMethod("get_SecondaryFileExtension", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_SecondaryFileExtension_5);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("GetExistingFilePathWithFileExtensions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, GetExistingFilePathWithFileExtensions_6);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("CreateFilePathWithPrimaryFileExtension", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateFilePathWithPrimaryFileExtension_7);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("CreateFilePathWithSecondaryFileExtension", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, CreateFilePathWithSecondaryFileExtension_8);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("IsFileExistWithFileExtensions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsFileExistWithFileExtensions_9);
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("ObjectToString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ObjectToString_10);
            args = new Type[]{typeof(System.Object), typeof(System.String)};
            method = type.GetMethod("ObjectToFile", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ObjectToFile_11);
            args = new Type[]{};
            method = type.GetMethod("get_FileExtensions", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_FileExtensions_12);
            args = new Type[]{typeof(System.Object)};
            method = type.GetMethod("SerializeObjectToString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SerializeObjectToString_13);
            args = new Type[]{typeof(System.Object), typeof(System.String)};
            method = type.GetMethod("SerializeObjectToFile", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SerializeObjectToFile_14);

            field = type.GetField("log", flag);
            app.RegisterCLRFieldGetter(field, get_log_0);
            app.RegisterCLRFieldSetter(field, set_log_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_log_0, AssignFromStack_log_0);
            field = type.GetField("manageFileExtensions", flag);
            app.RegisterCLRFieldGetter(field, get_manageFileExtensions_1);
            app.RegisterCLRFieldSetter(field, set_manageFileExtensions_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_manageFileExtensions_1, AssignFromStack_manageFileExtensions_1);


            app.RegisterCLRCreateDefaultInstance(type, () => new EPPZ.Persistence.Serializer());
            app.RegisterCLRCreateArrayInstance(type, s => new EPPZ.Persistence.Serializer[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* TurnOffFileExtensionManagement_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            EPPZ.Persistence.Serializer instance_of_this_method = (EPPZ.Persistence.Serializer)typeof(EPPZ.Persistence.Serializer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TurnOffFileExtensionManagement();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* TurnOnFileExtensionManagement_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            EPPZ.Persistence.Serializer instance_of_this_method = (EPPZ.Persistence.Serializer)typeof(EPPZ.Persistence.Serializer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.TurnOnFileExtensionManagement();

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SerializerOrDefault_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            EPPZ.Persistence.Serializer @serializer = (EPPZ.Persistence.Serializer)typeof(EPPZ.Persistence.Serializer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = EPPZ.Persistence.Serializer.SerializerOrDefault(@serializer);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SetDefaultSerializer_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            EPPZ.Persistence.Serializer instance_of_this_method = (EPPZ.Persistence.Serializer)typeof(EPPZ.Persistence.Serializer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SetDefaultSerializer();

            return __ret;
        }

        static StackObject* get_PrimaryFileExtension_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            EPPZ.Persistence.Serializer instance_of_this_method = (EPPZ.Persistence.Serializer)typeof(EPPZ.Persistence.Serializer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.PrimaryFileExtension;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_SecondaryFileExtension_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            EPPZ.Persistence.Serializer instance_of_this_method = (EPPZ.Persistence.Serializer)typeof(EPPZ.Persistence.Serializer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SecondaryFileExtension;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* GetExistingFilePathWithFileExtensions_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @filePath = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            EPPZ.Persistence.Serializer instance_of_this_method = (EPPZ.Persistence.Serializer)typeof(EPPZ.Persistence.Serializer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.GetExistingFilePathWithFileExtensions(@filePath);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateFilePathWithPrimaryFileExtension_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @filePath = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            EPPZ.Persistence.Serializer instance_of_this_method = (EPPZ.Persistence.Serializer)typeof(EPPZ.Persistence.Serializer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CreateFilePathWithPrimaryFileExtension(@filePath);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* CreateFilePathWithSecondaryFileExtension_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @filePath = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            EPPZ.Persistence.Serializer instance_of_this_method = (EPPZ.Persistence.Serializer)typeof(EPPZ.Persistence.Serializer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.CreateFilePathWithSecondaryFileExtension(@filePath);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* IsFileExistWithFileExtensions_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @filePath = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            EPPZ.Persistence.Serializer instance_of_this_method = (EPPZ.Persistence.Serializer)typeof(EPPZ.Persistence.Serializer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsFileExistWithFileExtensions(@filePath);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* ObjectToString_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object @_object = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            EPPZ.Persistence.Serializer instance_of_this_method = (EPPZ.Persistence.Serializer)typeof(EPPZ.Persistence.Serializer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ObjectToString(@_object);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* ObjectToFile_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @filePath = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Object @_object = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            EPPZ.Persistence.Serializer instance_of_this_method = (EPPZ.Persistence.Serializer)typeof(EPPZ.Persistence.Serializer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.ObjectToFile(@_object, @filePath);

            return __ret;
        }

        static StackObject* get_FileExtensions_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            EPPZ.Persistence.Serializer instance_of_this_method = (EPPZ.Persistence.Serializer)typeof(EPPZ.Persistence.Serializer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.FileExtensions;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SerializeObjectToString_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object @_object = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            EPPZ.Persistence.Serializer instance_of_this_method = (EPPZ.Persistence.Serializer)typeof(EPPZ.Persistence.Serializer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SerializeObjectToString(@_object);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* SerializeObjectToFile_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @filePath = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Object @_object = (System.Object)typeof(System.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            EPPZ.Persistence.Serializer instance_of_this_method = (EPPZ.Persistence.Serializer)typeof(EPPZ.Persistence.Serializer).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SerializeObjectToFile(@_object, @filePath);

            return __ret;
        }


        static object get_log_0(ref object o)
        {
            return ((EPPZ.Persistence.Serializer)o).log;
        }

        static StackObject* CopyToStack_log_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((EPPZ.Persistence.Serializer)o).log;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_log_0(ref object o, object v)
        {
            ((EPPZ.Persistence.Serializer)o).log = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_log_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @log = ptr_of_this_method->Value == 1;
            ((EPPZ.Persistence.Serializer)o).log = @log;
            return ptr_of_this_method;
        }

        static object get_manageFileExtensions_1(ref object o)
        {
            return ((EPPZ.Persistence.Serializer)o).manageFileExtensions;
        }

        static StackObject* CopyToStack_manageFileExtensions_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((EPPZ.Persistence.Serializer)o).manageFileExtensions;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_manageFileExtensions_1(ref object o, object v)
        {
            ((EPPZ.Persistence.Serializer)o).manageFileExtensions = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_manageFileExtensions_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @manageFileExtensions = ptr_of_this_method->Value == 1;
            ((EPPZ.Persistence.Serializer)o).manageFileExtensions = @manageFileExtensions;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new EPPZ.Persistence.Serializer();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
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
    unsafe class Phantom_XRMOD_PhotonModule_Runtime_PartyCodeGenerator_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator);
            args = new Type[]{};
            method = type.GetMethod("Create", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Create_0);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("Create", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Create_1);
            args = new Type[]{typeof(System.Int32), typeof(System.String)};
            method = type.GetMethod("Create", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Create_2);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("IsValid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsValid_3);
            args = new Type[]{typeof(System.String), typeof(System.Int32)};
            method = type.GetMethod("IsValid", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, IsValid_4);
            args = new Type[]{typeof(System.String), typeof(System.Int32)};
            method = type.GetMethod("EncodeRegion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, EncodeRegion_5);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("DecodeRegion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, DecodeRegion_6);

            field = type.GetField("ValidCharacters", flag);
            app.RegisterCLRFieldGetter(field, get_ValidCharacters_0);
            app.RegisterCLRFieldSetter(field, set_ValidCharacters_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_ValidCharacters_0, AssignFromStack_ValidCharacters_0);
            field = type.GetField("Length", flag);
            app.RegisterCLRFieldGetter(field, get_Length_1);
            app.RegisterCLRFieldSetter(field, set_Length_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_Length_1, AssignFromStack_Length_1);
            field = type.GetField("EncodedRegionPosition", flag);
            app.RegisterCLRFieldGetter(field, get_EncodedRegionPosition_2);
            app.RegisterCLRFieldSetter(field, set_EncodedRegionPosition_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_EncodedRegionPosition_2, AssignFromStack_EncodedRegionPosition_2);


            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* Create_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator)typeof(Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Create();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Create_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @_length = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator)typeof(Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.Create(@_length);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* Create_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_validCharacters = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Int32 @_length = ptr_of_this_method->Value;


            var result_of_this_method = Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator.Create(@_length, @_validCharacters);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* IsValid_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @_code = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator)typeof(Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsValid(@_code);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* IsValid_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @_length = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_code = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator)typeof(Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.IsValid(@_code, @_length);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static StackObject* EncodeRegion_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @_region = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.String @_code = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator)typeof(Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.EncodeRegion(@_code, @_region);

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* DecodeRegion_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @code = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator instance_of_this_method = (Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator)typeof(Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DecodeRegion(@code);

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }


        static object get_ValidCharacters_0(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator)o).ValidCharacters;
        }

        static StackObject* CopyToStack_ValidCharacters_0(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator)o).ValidCharacters;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_ValidCharacters_0(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator)o).ValidCharacters = (System.String)v;
        }

        static StackObject* AssignFromStack_ValidCharacters_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.String @ValidCharacters = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            ((Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator)o).ValidCharacters = @ValidCharacters;
            return ptr_of_this_method;
        }

        static object get_Length_1(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator)o).Length;
        }

        static StackObject* CopyToStack_Length_1(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator)o).Length;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_Length_1(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator)o).Length = (System.Int32)v;
        }

        static StackObject* AssignFromStack_Length_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @Length = ptr_of_this_method->Value;
            ((Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator)o).Length = @Length;
            return ptr_of_this_method;
        }

        static object get_EncodedRegionPosition_2(ref object o)
        {
            return ((Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator)o).EncodedRegionPosition;
        }

        static StackObject* CopyToStack_EncodedRegionPosition_2(ref object o, ILIntepreter __intp, StackObject* __ret, AutoList __mStack)
        {
            var result_of_this_method = ((Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator)o).EncodedRegionPosition;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_EncodedRegionPosition_2(ref object o, object v)
        {
            ((Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator)o).EncodedRegionPosition = (System.Int32)v;
        }

        static StackObject* AssignFromStack_EncodedRegionPosition_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, AutoList __mStack)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @EncodedRegionPosition = ptr_of_this_method->Value;
            ((Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator)o).EncodedRegionPosition = @EncodedRegionPosition;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.PhotonModule.Runtime.PartyCodeGenerator();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
#endif
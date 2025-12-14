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
    unsafe class Phantom_XRMOD_NetcodeModule_Runtime_PacketWriter_Binding
    {
        public static void Register(UnityFusion.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("WriteInt", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteInt_0);
            args = new Type[]{typeof(System.Int64)};
            method = type.GetMethod("WriteLong", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteLong_1);
            args = new Type[]{typeof(System.Single)};
            method = type.GetMethod("WriteFloat", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteFloat_2);
            args = new Type[]{typeof(System.Double)};
            method = type.GetMethod("WriteDouble", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteDouble_3);
            args = new Type[]{typeof(System.Boolean)};
            method = type.GetMethod("WriteBool", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteBool_4);
            args = new Type[]{typeof(System.String)};
            method = type.GetMethod("WriteString", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteString_5);
            args = new Type[]{typeof(System.Byte[])};
            method = type.GetMethod("WriteBytes", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteBytes_6);
            args = new Type[]{};
            method = type.GetMethod("ToArray", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, ToArray_7);
            args = new Type[]{typeof(UnityEngine.Vector2)};
            method = type.GetMethod("WriteVector2", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteVector2_8);
            args = new Type[]{typeof(UnityEngine.Vector3)};
            method = type.GetMethod("WriteVector3", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteVector3_9);
            args = new Type[]{typeof(UnityEngine.Vector4)};
            method = type.GetMethod("WriteVector4", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteVector4_10);
            args = new Type[]{typeof(UnityEngine.Quaternion)};
            method = type.GetMethod("WriteQuaternion", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteQuaternion_11);
            args = new Type[]{typeof(UnityEngine.Color)};
            method = type.GetMethod("WriteColor", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteColor_12);
            args = new Type[]{typeof(UnityEngine.Color32)};
            method = type.GetMethod("WriteColor32", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteColor32_13);
            args = new Type[]{typeof(UnityEngine.Vector2Int)};
            method = type.GetMethod("WriteVector2Int", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteVector2Int_14);
            args = new Type[]{typeof(UnityEngine.Vector3Int)};
            method = type.GetMethod("WriteVector3Int", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteVector3Int_15);
            args = new Type[]{typeof(UnityEngine.Rect)};
            method = type.GetMethod("WriteRect", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteRect_16);
            args = new Type[]{typeof(UnityEngine.Bounds)};
            method = type.GetMethod("WriteBounds", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteBounds_17);
            args = new Type[]{typeof(UnityEngine.Matrix4x4)};
            method = type.GetMethod("WriteMatrix4x4", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteMatrix4x4_18);
            args = new Type[]{typeof(UnityEngine.Ray)};
            method = type.GetMethod("WriteRay", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, WriteRay_19);



            app.RegisterCLRCreateDefaultInstance(type, () => new Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter());
            app.RegisterCLRCreateArrayInstance(type, s => new Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* WriteInt_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @v = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteInt(@v);

            return __ret;
        }

        static StackObject* WriteLong_1(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int64 @v = *(long*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteLong(@v);

            return __ret;
        }

        static StackObject* WriteFloat_2(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Single @v = *(float*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteFloat(@v);

            return __ret;
        }

        static StackObject* WriteDouble_3(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Double @v = *(double*)&ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteDouble(@v);

            return __ret;
        }

        static StackObject* WriteBool_4(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @v = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteBool(@v);

            return __ret;
        }

        static StackObject* WriteString_5(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.String @s = (System.String)typeof(System.String).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteString(@s);

            return __ret;
        }

        static StackObject* WriteBytes_6(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Byte[] @d = (System.Byte[])typeof(System.Byte[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteBytes(@d);

            return __ret;
        }

        static StackObject* ToArray_7(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.ToArray();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* WriteVector2_8(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2 @v = (UnityEngine.Vector2)typeof(UnityEngine.Vector2).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteVector2(@v);

            return __ret;
        }

        static StackObject* WriteVector3_9(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3 @v = (UnityEngine.Vector3)typeof(UnityEngine.Vector3).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteVector3(@v);

            return __ret;
        }

        static StackObject* WriteVector4_10(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector4 @v = (UnityEngine.Vector4)typeof(UnityEngine.Vector4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteVector4(@v);

            return __ret;
        }

        static StackObject* WriteQuaternion_11(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Quaternion @q = (UnityEngine.Quaternion)typeof(UnityEngine.Quaternion).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteQuaternion(@q);

            return __ret;
        }

        static StackObject* WriteColor_12(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color @c = (UnityEngine.Color)typeof(UnityEngine.Color).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteColor(@c);

            return __ret;
        }

        static StackObject* WriteColor32_13(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Color32 @c = (UnityEngine.Color32)typeof(UnityEngine.Color32).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteColor32(@c);

            return __ret;
        }

        static StackObject* WriteVector2Int_14(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector2Int @v = (UnityEngine.Vector2Int)typeof(UnityEngine.Vector2Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteVector2Int(@v);

            return __ret;
        }

        static StackObject* WriteVector3Int_15(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Vector3Int @v = (UnityEngine.Vector3Int)typeof(UnityEngine.Vector3Int).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteVector3Int(@v);

            return __ret;
        }

        static StackObject* WriteRect_16(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Rect @r = (UnityEngine.Rect)typeof(UnityEngine.Rect).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteRect(@r);

            return __ret;
        }

        static StackObject* WriteBounds_17(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Bounds @b = (UnityEngine.Bounds)typeof(UnityEngine.Bounds).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteBounds(@b);

            return __ret;
        }

        static StackObject* WriteMatrix4x4_18(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Matrix4x4 @m = (UnityEngine.Matrix4x4)typeof(UnityEngine.Matrix4x4).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteMatrix4x4(@m);

            return __ret;
        }

        static StackObject* WriteRay_19(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            UnityEngine.Ray @r = (UnityEngine.Ray)typeof(UnityEngine.Ray).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)16);
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter instance_of_this_method = (Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter)typeof(Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack), (CLR.Utils.Extensions.TypeFlags)0);
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.WriteRay(@r);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, AutoList __mStack, CLRMethod __method, bool isNewObj)
        {
            UnityFusion.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new Phantom.XRMOD.NetcodeModule.Runtime.PacketWriter();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}
